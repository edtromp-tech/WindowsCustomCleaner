/*
Creator: Ethan Tromp
Created: 8/5/2022
Modified: 8/5/2022

A lot of the hard work was done by others. I built off of
their designs to create a GUI that dynamically creates a 
script to clean up a windows image. 

Credits:
Cole Bermudez
https://github.com/Sycnex/Windows10Debloater
https://github.com/Disassembler0
 */








using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Management.Automation;

namespace WindowsCustomClean
{
    public partial class frm_custom_clean : Form
    {
        bool DebloaterLoaded = false;
        bool RegisterLoaded = false;


        public frm_custom_clean()
        {
            InitializeComponent();
        }


        private void frm_custom_clean_Load(object sender, EventArgs e)
        {
            string supportFolder = @"C:\\Support";
            System.IO.Directory.CreateDirectory(supportFolder);
            textBox_warning_msg.Visible = false;
            button_cancel.Visible = false;
            button_run.Visible = false;
            textBox_review_code.Visible = false;
        }

        private void button_submit_Click(object sender, EventArgs e)
        {
            List<string> stringCommand = new List<string>();
            string supportFolder = @"C:\\Support\\Logs";
            label_form_info.Text = "Creating script file...";
            label_form_info.Visible = true;


            if (checkBox_createLogFile.Checked)
            {
                Directory.CreateDirectory(supportFolder);
                stringCommand.Add("Start-Transcript -Append C:\\Support\\Logs\\WindowsSetupLog.txt");
            }
            if (checkBox_ChangeComputerName.Checked)
            {
                stringCommand.Add("Rename-Computer -NewName \"" + textBox_ChangeComputerName.Text + "\"");
            }
            if (checkBox_BootLegacy.Checked)
            {
                stringCommand.Add("bcdedit /set \"{ current}\" bootmenupolicy legacy");
            }
            if (checkBox_ConfigTRIM.Checked)
            {
                stringCommand.Add("fsutil behavior set DisableDeleteNotify 0");
            }
            if (checkBox_CreateRestore.Checked)
            {
                stringCommand.Add("vssadmin resize shadowstorage /for=C: /on=C: /maxsize=5%");
                stringCommand.Add("Enable-ComputerRestore -Drive \"$env: SystemDrive\"");
                stringCommand.Add("REG ADD \"HKLM\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\SystemRestore\" /V \"SystemRestorePointCreationFrequency\" /T REG_DWORD /D 0 /F");
                stringCommand.Add("Checkpoint-Computer -Description \"RestorePoint1\" -RestorePointType \"MODIFY_SETTINGS\"");
                stringCommand.Add("powercfg.exe -change -monitor-timeout-ac 0");
                stringCommand.Add("powercfg.exe -change -monitor-timeout-dc 0");
                stringCommand.Add("powercfg.exe -change -disk-timeout-ac 0");
                stringCommand.Add("powercfg.exe -change -disk-timeout-dc 0");
                stringCommand.Add("powercfg.exe -change -standby-timeout-ac 0");
                stringCommand.Add("powercfg.exe -change -standby-timeout-dc 0");
                stringCommand.Add("powercfg.exe -change -hibernate-timeout-ac 0");
                stringCommand.Add("powercfg.exe -change -hibernate-timeout-dc 0");
            }
            if (checkBox_WinUpgrade.Checked)
            {
                stringCommand.Add("REG ADD HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate / f / v TargetReleaseVersion / t Reg_DWORD / d 1");
                stringCommand.Add("REG ADD HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\WindowsUpdate /f /v TargetReleaseVersionInfo /t REG_SZ /d 21H2");
            }

            if (comboBox_netFramework.SelectedIndex != -1)
            {
                if (comboBox_netFramework.SelectedItem.ToString() == "Enable")
                {
                    stringCommand.Add("Enable-WindowsOptionalFeature -Online -FeatureName NetFx3 -All");
                }
                else if (comboBox_netFramework.SelectedItem.ToString() == "Disable")
                {
                    stringCommand.Add("Disable-WindowsOptionalFeature -Online -FeatureName NetFx3 -All");
                }
            }

            if (comboBox_NBTNS.SelectedIndex > -1)
            {
                if (comboBox_NBTNS.SelectedItem.ToString() == "Enable")
                {
                    stringCommand.Add("$regkey = \"HKLM: SYSTEM\\CurrentControlSet\\services\\NetBT\\Parameters\\Interfaces\"");
                    stringCommand.Add("Get-ChildItem $regkey |foreach { Set-ItemProperty -Path \"$regkey\\$($_.pschildname)\" -Name NetbiosOptions -Value 1 -Verbose}");

                }
                else if (comboBox_NBTNS.SelectedItem.ToString() == "Disable")
                {
                    stringCommand.Add("$regkey = \"HKLM: SYSTEM\\CurrentControlSet\\services\\NetBT\\Parameters\\Interfaces\"");
                    stringCommand.Add("Get-ChildItem $regkey |foreach { Set-ItemProperty -Path \"$regkey\\$($_.pschildname)\" -Name NetbiosOptions -Value 2 -Verbose}");
                }
            }

            if (comboBox_LLMNR.SelectedIndex > -1)
            {
                if (comboBox_LLMNR.SelectedItem.ToString() == "Enable")
                {
                    stringCommand.Add("REG ADD  \"HKLM\\Software\\policies\\Microsoft\\Windows NT\\DNSClient\"");
                    stringCommand.Add("REG ADD  \"HKLM\\Software\\policies\\Microsoft\\Windows NT\\DNSClient\" /v \"EnableMulticast\" /t REG_DWORD /d \"1\" /f");
                }
                else if (comboBox_LLMNR.SelectedItem.ToString() == "Disable")
                {
                    stringCommand.Add("REG ADD  \"HKLM\\Software\\policies\\Microsoft\\Windows NT\\DNSClient\"");
                    stringCommand.Add("REG ADD  \"HKLM\\Software\\policies\\Microsoft\\Windows NT\\DNSClient\" /v \"EnableMulticast\" /t REG_DWORD /d \"0\" /f");
                }
            }

            if (comboBox_TimeZone.SelectedIndex > -1)
            {
                if (comboBox_TimeZone.SelectedItem.ToString() != "")
                {
                    stringCommand.Add("Set-TimeZone -Id \"" + comboBox_TimeZone.SelectedItem.ToString() + "\"");
                }
            }

            if (comboBox_ad.SelectedIndex > -1)
            {
                if (comboBox_ad.SelectedItem.ToString() == "Enable")
                {
                    stringCommand.Add("$Advertising = \"HKLM:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\AdvertisingInfo\"");
                    stringCommand.Add("If (Test-Path $Advertising) {Set -ItemProperty $Advertising Enabled -Value 1");

                }
                else if (comboBox_ad.SelectedItem.ToString() == "Disable")
                {
                    stringCommand.Add("$Advertising = \"HKLM:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\AdvertisingInfo\"");
                    stringCommand.Add("If (Test-Path $Advertising) {Set -ItemProperty $Advertising Enabled -Value 0");
                }
            }

            if (comboBox_diagnosticTracking.SelectedIndex > -1)
            {
                if (comboBox_diagnosticTracking.SelectedItem.ToString() == "Enable")
                {
                    stringCommand.Add("Start-Service \"DiagTrack\"");
                    stringCommand.Add("Set-Service \"DiagTrack\" -StartupType Enabled");

                }
                else if (comboBox_diagnosticTracking.SelectedItem.ToString() == "Disable")
                {
                    stringCommand.Add("Stop-Service \"DiagTrack\"");
                    stringCommand.Add("Set-Service \"DiagTrack\" -StartupType Disabled");
                }
            }

            if (comboBox_locationTracking.SelectedIndex > -1)
            {
                if (comboBox_locationTracking.SelectedItem.ToString() == "Enable")
                {
                    stringCommand.Add("$SensorState = \"HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Sensor\\Overrides\\{BFA794E4-F964-4FDB-90F6-51056BFE4B44}\"");
                    stringCommand.Add("$LocationConfig = \"HKLM:\\SYSTEM\\CurrentControlSet\\Services\\lfsvc\\Service\\Configuration\"");
                    stringCommand.Add("If (!(Test-Path $SensorState)) {New-Item $SensorState}");
                    stringCommand.Add("Set-ItemProperty $SensorState SensorPermissionState -Value 1");
                    stringCommand.Add("If (!(Test-Path $LocationConfig)) {New-Item $LocationConfig}");
                    stringCommand.Add("Set-ItemProperty $LocationConfig Status -Value 1");

                }
                else if (comboBox_locationTracking.SelectedItem.ToString() == "Disable")
                {
                    stringCommand.Add("$SensorState = \"HKLM:\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Sensor\\Overrides\\{BFA794E4-F964-4FDB-90F6-51056BFE4B44}\"");
                    stringCommand.Add("$LocationConfig = \"HKLM:\\SYSTEM\\CurrentControlSet\\Services\\lfsvc\\Service\\Configuration\"");
                    stringCommand.Add("If (!(Test-Path $SensorState)) {New-Item $SensorState}");
                    stringCommand.Add("Set-ItemProperty $SensorState SensorPermissionState -Value 0");
                    stringCommand.Add("If (!(Test-Path $LocationConfig)) {New-Item $LocationConfig}");
                    stringCommand.Add("Set-ItemProperty $LocationConfig Status -Value 0");
                }
            }

            if (comboBox_dataCollection.SelectedIndex > -1)
            {
                if (comboBox_dataCollection.SelectedItem.ToString() == "Enable")
                {
                    stringCommand.Add("$DataCollection = @(\"HKLM:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\DataCollection\"");
                    stringCommand.Add("\"HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection\"");
                    stringCommand.Add("\"HKLM:\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Policies\\DataCollection\")");
                    stringCommand.Add("foreach ($DC in $DataCollection){");
                    stringCommand.Add("If (Test-Path $DC) {Set-ItemProperty $DC  AllowTelemetry -Value 1}");
                    stringCommand.Add("}");

                }
                else if (comboBox_dataCollection.SelectedItem.ToString() == "Disable")
                {
                    stringCommand.Add("$DataCollection = @(\"HKLM:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\DataCollection\"");
                    stringCommand.Add("\"HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\DataCollection\"");
                    stringCommand.Add("\"HKLM:\\SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Policies\\DataCollection\")");
                    stringCommand.Add("foreach ($DC in $DataCollection){");
                    stringCommand.Add("If (Test-Path $DC) {Set-ItemProperty $DC  AllowTelemetry -Value 0}");
                    stringCommand.Add("}");
                }
            }

            if (comboBox_wifiSense.SelectedIndex > -1)
            {
                if (comboBox_wifiSense.SelectedItem.ToString() == "Enable")
                {
                    stringCommand.Add("$WifiSense = @(\"HKLM:\\SOFTWARE\\Microsoft\\PolicyManager\\default\\WiFi\\AllowWiFiHotSpotReporting\"");
                    stringCommand.Add("\"HKLM:\\SOFTWARE\\Microsoft\\PolicyManager\\default\\WiFi\\AllowAutoConnectToWiFiSenseHotspots\")");
                    stringCommand.Add("$WifiSense1 = \"HKLM:\\SOFTWARE\\Microsoft\\WcmSvc\\wifinetworkmanager\\config\"");
                    stringCommand.Add("foreach ($WS in $WifiSense){");
                    stringCommand.Add("If (!(Test-Path $WS)) {New-Item $WS}");
                    stringCommand.Add("Set-ItemProperty $WS  Value -Value 1 ");
                    stringCommand.Add("}");
                    stringCommand.Add("Set-ItemProperty $WifiSense1  AutoConnectAllowedOEM -Value 1");

                }
                else if (comboBox_wifiSense.SelectedItem.ToString() == "Disable")
                {
                    stringCommand.Add("$WifiSense = @(\"HKLM:\\SOFTWARE\\Microsoft\\PolicyManager\\default\\WiFi\\AllowWiFiHotSpotReporting\"");
                    stringCommand.Add("\"HKLM:\\SOFTWARE\\Microsoft\\PolicyManager\\default\\WiFi\\AllowAutoConnectToWiFiSenseHotspots\")");
                    stringCommand.Add("$WifiSense1 = \"HKLM:\\SOFTWARE\\Microsoft\\WcmSvc\\wifinetworkmanager\\config\"");
                    stringCommand.Add("foreach ($WS in $WifiSense){");
                    stringCommand.Add("If (!(Test-Path $WS)) {New-Item $WS");
                    stringCommand.Add("Set-ItemProperty $WS  Value -Value 0 ");
                    stringCommand.Add("}");
                    stringCommand.Add("Set-ItemProperty $WifiSense1  AutoConnectAllowedOEM -Value 0");
                }
            }

            if (comboBox_cortana.SelectedIndex > -1)
            {
                if (comboBox_cortana.SelectedItem.ToString() == "Enable")
                {
                    stringCommand.Add("$Search = \"HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search\"");
                    stringCommand.Add("If (Test-Path $Search) {Set-ItemProperty $Search AllowCortana -Value 1}");

                }
                else if (comboBox_cortana.SelectedItem.ToString() == "Disable")
                {
                    stringCommand.Add("$Search = \"HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search\"");
                    stringCommand.Add("If (Test-Path $Search) {Set-ItemProperty $Search AllowCortana -Value 0}");
                }
            }

            if (comboBox_webSearch.SelectedIndex > -1)
            {
                if (comboBox_webSearch.SelectedItem.ToString() == "Enable")
                {
                    stringCommand.Add("$WebSearch = \"HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search\"");
                    stringCommand.Add("Set-ItemProperty \"HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search\" BingSearchEnabled -Value 1");
                    stringCommand.Add("If (!(Test-Path $WebSearch)) {New-Item $WebSearch}");
                    stringCommand.Add("Set-ItemProperty $WebSearch DisableWebSearch -Value 0");
                }
                else if (comboBox_webSearch.SelectedItem.ToString() == "Disable")
                {
                    stringCommand.Add("$WebSearch = \"HKLM:\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search\"");
                    stringCommand.Add("Set-ItemProperty \"HKCU:\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Search\" BingSearchEnabled -Value 0");
                    stringCommand.Add("If (!(Test-Path $WebSearch)) {New-Item $WebSearch}");
                    stringCommand.Add("Set-ItemProperty $WebSearch DisableWebSearch -Value 1");
                }
            }

            if (comboBox_anonymousData.SelectedIndex > -1)
            {
                if (comboBox_anonymousData.SelectedItem.ToString() == "Enable")
                {
                    stringCommand.Add("$Period = \"HKCU:\\Software\\Microsoft\\Siuf\\Rules\"");
                    stringCommand.Add("If (!(Test-Path $Period)) { New-Item $Period}");
                    stringCommand.Add("Set-ItemProperty $Period PeriodInNanoSeconds -Value 1");
                }
                else if (comboBox_anonymousData.SelectedItem.ToString() == "Disable")
                {
                    stringCommand.Add("$Period = \"HKCU:\\Software\\Microsoft\\Siuf\\Rules\"");
                    stringCommand.Add("If (!(Test-Path $Period)) { New-Item $Period}");
                    stringCommand.Add("Set-ItemProperty $Period PeriodInNanoSeconds -Value 0");
                }
            }


            if (checkedListBox_debloat.Items.Count > 0)
            {
                stringCommand.Add("$Bloatware = @(");
                foreach (string item in checkedListBox_debloat.Items)
                {
                    stringCommand.Add("\"" + item.ToString() + "\"");
                }
                stringCommand.Add(")");
                stringCommand.Add("foreach ($Bloat in $Bloatware) {");
                stringCommand.Add("Get-AppxPackage -Name $Bloat| Remove-AppxPackage");
                stringCommand.Add("Get-AppxProvisionedPackage -Online | Where-Object DisplayName -like $Bloat | Remove-AppxProvisionedPackage -Online");
                stringCommand.Add("Write-Output \"Trying to remove $Bloat.\"");
            }

            if (checkedListBox_register.Items.Count > 0)
            {
                stringCommand.Add("$Keys = @(");
                foreach (string item in checkedListBox_register.Items)
                {
                    stringCommand.Add("\"" + item.ToString() + "\"");
                }
                stringCommand.Add(")");
                stringCommand.Add("foreach ($Key in $Keys) {");
                stringCommand.Add("Write-Output \"Removing $Key from registry\"");
                stringCommand.Add("Remove-Item $Key -Recurse}");
                
            }

            if (checkedListBox_tasks.Items.Count > 0)
            {
                stringCommand.Add("Write-Output \"Disabling scheduled tasks\"");
                foreach (string item in checkedListBox_tasks.Items)
                {
                    stringCommand.Add("Get-ScheduledTask " + item.ToString() + " | Disable-ScheduledTask");
                }
            }





            File.WriteAllLinesAsync(@"C:\\Support\\CustomCleanScript.ps1", stringCommand.ToArray());

            label_form_info.Text = "Script File was created at C:\\Support";
            textBox_warning_msg.Visible = true;
            button_cancel.Visible = true;
            button_run.Visible = true;
            tabControl_1.Visible = false;
            button_submit.Visible = false;
            textBox_review_code.Visible = true;
            textBox_review_code.Text = string.Join("\n", stringCommand.ToArray());

        }

        private void load_debloat(object sender, EventArgs e)
        {
            int i = 0;
            if (!DebloaterLoaded)
            {
                DebloaterLoaded = true;
                label_form_info.Text = "Checking apps on your computer...";
                List<string> bloatware = new List<string>();

                bloatware.AddRange(new List<string>{
                    "Microsoft.BingNews",
                    "Microsoft.GetHelp",
                    "Microsoft.Getstarted",
                    "Microsoft.Messaging",
                    "Microsoft.Microsoft3DViewer",
                    "Microsoft.MicrosoftOfficeHub",
                    "Microsoft.MicrosoftSolitaireCollection",
                    "Microsoft.NetworkSpeedTest",
                    "Microsoft.News",
                    "Microsoft.Office.Lens",
                    "Microsoft.Office.OneNote",
                    "Microsoft.Office.Sway",
                    "Microsoft.OneConnect",
                    "Microsoft.People",
                    "Microsoft.Print3D",
                    "Microsoft.RemoteDesktop",
                    "Microsoft.SkypeApp",
                    "Microsoft.StorePurchaseApp",
                    "Microsoft.Office.Todo.List",
                    "Microsoft.Whiteboard",
                    "Microsoft.WindowsAlarms",
                    "Microsoft.WindowsCamera",
                    "microsoft.windowscommunicationsapps",
                    "Microsoft.WindowsFeedbackHub",
                    "Microsoft.WindowsMaps",
                    "Microsoft.WindowsSoundRecorder",
                    "Microsoft.Xbox.TCUI",
                    "Microsoft.XboxApp",
                    "Microsoft.XboxGameOverlay",
                    "Microsoft.XboxIdentityProvider",
                    "Microsoft.XboxSpeechToTextOverlay",
                    "Microsoft.ZuneMusic",
                    "Microsoft.ZuneVideo",

                    "*EclipseManager*",
                    "*ActiproSoftwareLLC*",
                    "*AdobeSystemsIncorporated.AdobePhotoshopExpress*",
                    "*Duolingo-LearnLanguagesforFree*",
                    "*PandoraMediaInc*",
                    "*CandyCrush*",
                    "*BubbleWitch3Saga*",
                    "*Wunderlist*",
                    "*Flipboard*",
                    "*Twitter*",
                    "*Facebook*",
                    "*Spotify*",
                    "*Minecraft*",
                    "*Royal Revolt*",
                    "*Sway*",
                    "*Speed Test*",
                    "*Dolby*"

                });

                //https://stackoverflow.com/questions/59952511/how-to-get-store-app-version-from-c-sharp-using-powershell
                foreach (string line in bloatware)
                {
                    if (i % 10 == 0)
                        label_form_info.Text = "Checking apps on your computer... (" + i.ToString() + "/" + bloatware.Count + ")";
                    i++;

                    var process = new Process
                    {
                        StartInfo =
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-Command (Get-AppxPackage \"{line}\" | Select Name).Name",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        }
                    };

                    process.Start();
                    process.WaitForExit();

                    var output = process.StandardOutput.ReadToEnd();

                    if (output.ToString() != "")
                        checkedListBox_debloat.Items.Add(line);

                }
                label_form_info.Text = "Done";
            }





        }

        private void load_registery(object sender, EventArgs e)
        {
            List<string> registeries = new List<string>();
            int i = 0;

            if (!RegisterLoaded)
            {
                RegisterLoaded = true;
                registeries.AddRange(new List<string>
                {
                    //Remove Background Tasks
                    "HKCR:\\Extensions\\ContractId\\Windows.BackgroundTasks\\PackageId\\46928bounde.EclipseManager_2.2.4.51_neutral__a5h4egax66k6y",
                    "HKCR:\\Extensions\\ContractId\\Windows.BackgroundTasks\\PackageId\\ActiproSoftwareLLC.562882FEEB491_2.6.18.18_neutral__24pqs290vpjk0",
                    "HKCR:\\Extensions\\ContractId\\Windows.BackgroundTasks\\PackageId\\Microsoft.MicrosoftOfficeHub_17.7909.7600.0_x64__8wekyb3d8bbwe",
                    "HKCR:\\Extensions\\ContractId\\Windows.BackgroundTasks\\PackageId\\Microsoft.PPIProjection_10.0.15063.0_neutral_neutral_cw5n1h2txyewy",
                    "HKCR:\\Extensions\\ContractId\\Windows.BackgroundTasks\\PackageId\\Microsoft.XboxGameCallableUI_1000.15063.0.0_neutral_neutral_cw5n1h2txyewy",
                    "HKCR:\\Extensions\\ContractId\\Windows.BackgroundTasks\\PackageId\\Microsoft.XboxGameCallableUI_1000.16299.15.0_neutral_neutral_cw5n1h2txyewy",
            
                    //Windows File
                    "HKCR:\\Extensions\\ContractId\\Windows.File\\PackageId\\ActiproSoftwareLLC.562882FEEB491_2.6.18.18_neutral__24pqs290vpjk0",
            
                    //Registry keys to delete if they aren't uninstalled by RemoveAppXPackage/RemoveAppXProvisionedPackage
                    "HKCR:\\Extensions\\ContractId\\Windows.Launch\\PackageId\\46928bounde.EclipseManager_2.2.4.51_neutral__a5h4egax66k6y",
                    "HKCR:\\Extensions\\ContractId\\Windows.Launch\\PackageId\\ActiproSoftwareLLC.562882FEEB491_2.6.18.18_neutral__24pqs290vpjk0",
                    "HKCR:\\Extensions\\ContractId\\Windows.Launch\\PackageId\\Microsoft.PPIProjection_10.0.15063.0_neutral_neutral_cw5n1h2txyewy",
                    "HKCR:\\Extensions\\ContractId\\Windows.Launch\\PackageId\\Microsoft.XboxGameCallableUI_1000.15063.0.0_neutral_neutral_cw5n1h2txyewy",
                    "HKCR:\\Extensions\\ContractId\\Windows.Launch\\PackageId\\Microsoft.XboxGameCallableUI_1000.16299.15.0_neutral_neutral_cw5n1h2txyewy",
            
                    //Scheduled Tasks to delete
                    "HKCR:\\Extensions\\ContractId\\Windows.PreInstalledConfigTask\\PackageId\\Microsoft.MicrosoftOfficeHub_17.7909.7600.0_x64__8wekyb3d8bbwe",
            
                    //Windows Protocol Keys
                    "HKCR:\\Extensions\\ContractId\\Windows.Protocol\\PackageId\\ActiproSoftwareLLC.562882FEEB491_2.6.18.18_neutral__24pqs290vpjk0",
                    "HKCR:\\Extensions\\ContractId\\Windows.Protocol\\PackageId\\Microsoft.PPIProjection_10.0.15063.0_neutral_neutral_cw5n1h2txyewy",
                    "HKCR:\\Extensions\\ContractId\\Windows.Protocol\\PackageId\\Microsoft.XboxGameCallableUI_1000.15063.0.0_neutral_neutral_cw5n1h2txyewy",
                    "HKCR:\\Extensions\\ContractId\\Windows.Protocol\\PackageId\\Microsoft.XboxGameCallableUI_1000.16299.15.0_neutral_neutral_cw5n1h2txyewy",
               
                    //Windows Share Target
                    "HKCR:\\Extensions\\ContractId\\Windows.ShareTarget\\PackageId\\ActiproSoftwareLLC.562882FEEB491_2.6.18.18_neutral__24pqs290vpjk0"
                });


                foreach (string line in registeries)
                {
                    if (i % 10 == 0)
                        label_form_info.Text = "Checking registeries on your computer... (" + i.ToString() + "/" + registeries.Count + ")";
                    i++;

                    var process = new Process
                    {
                        StartInfo =
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-Command (Test-Path \"{line}\")",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = true
                        }
                    };

                    process.Start();
                    process.WaitForExit();

                    var output = process.StandardOutput.ReadToEnd();

                    if (output.ToString() != "False")
                        checkedListBox_register.Items.Add(line);

                }
                label_form_info.Text = "Done";





            }
        }

        private void load_tasks(object sender, EventArgs e)
        {
            List<string> tasks = new List<string>();
            tasks.AddRange(new List<string>
            {
                "XblGameSaveTaskLogon",
                "XblGameSaveTask",
                "Consolidator",
                "UsbCeip",
                "DmClient",
                "DmClientOnScenarioDownload"
            });
            foreach(string line in tasks)
            {
                checkedListBox_tasks.Items.Add(line);
            }


        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            textBox_warning_msg.Visible = false;
            button_cancel.Visible = false;
            button_run.Visible = false;
            tabControl_1.Visible = true;
            button_submit.Visible = true;
            textBox_review_code.Visible = false;
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            textBox_warning_msg.Visible = false;
            button_cancel.Visible = false;
            button_run.Visible = false;
            tabControl_1.Visible = true;
            button_submit.Visible = true;
            textBox_review_code.Visible = false;

            label_form_info.Text = "Running script. Please see C:\\Support\\Log file.";

            var process = new Process
            {
                StartInfo =
                        {
                            FileName = "powershell.exe",
                            Arguments = $"-Command (\"C:\\Support\\CustomCleanScript.ps1\"",
                            UseShellExecute = false,
                            RedirectStandardOutput = true,
                            CreateNoWindow = false
                        }
            };

            process.Start();
            process.WaitForExit();

          



            

        }
    }   
}