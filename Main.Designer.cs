namespace WindowsCustomClean
{
    partial class frm_custom_clean
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_feature_list = new System.Windows.Forms.Label();
            this.checkBox_WinUpgrade = new System.Windows.Forms.CheckBox();
            this.label_TimeZone = new System.Windows.Forms.Label();
            this.comboBox_TimeZone = new System.Windows.Forms.ComboBox();
            this.checkBox_CreateRestore = new System.Windows.Forms.CheckBox();
            this.checkBox_ConfigTRIM = new System.Windows.Forms.CheckBox();
            this.checkBox_BootLegacy = new System.Windows.Forms.CheckBox();
            this.textBox_ChangeComputerName = new System.Windows.Forms.TextBox();
            this.checkBox_ChangeComputerName = new System.Windows.Forms.CheckBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tabControl_1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox_createLogFile = new System.Windows.Forms.CheckBox();
            this.label_LLMNR = new System.Windows.Forms.Label();
            this.comboBox_LLMNR = new System.Windows.Forms.ComboBox();
            this.label_NBTNS = new System.Windows.Forms.Label();
            this.comboBox_NBTNS = new System.Windows.Forms.ComboBox();
            this.label_netFramework = new System.Windows.Forms.Label();
            this.comboBox_netFramework = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label_DiagnosticsTracking = new System.Windows.Forms.Label();
            this.comboBox_diagnosticTracking = new System.Windows.Forms.ComboBox();
            this.label_LocationTracking = new System.Windows.Forms.Label();
            this.comboBox_locationTracking = new System.Windows.Forms.ComboBox();
            this.label_DataCollection = new System.Windows.Forms.Label();
            this.comboBox_dataCollection = new System.Windows.Forms.ComboBox();
            this.label_wifiSense = new System.Windows.Forms.Label();
            this.comboBox_wifiSense = new System.Windows.Forms.ComboBox();
            this.label_cortana = new System.Windows.Forms.Label();
            this.comboBox_cortana = new System.Windows.Forms.ComboBox();
            this.label_webSearch = new System.Windows.Forms.Label();
            this.comboBox_webSearch = new System.Windows.Forms.ComboBox();
            this.label_anonymousData = new System.Windows.Forms.Label();
            this.comboBox_anonymousData = new System.Windows.Forms.ComboBox();
            this.label_ad = new System.Windows.Forms.Label();
            this.comboBox_ad = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkedListBox_debloat = new System.Windows.Forms.CheckedListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.checkedListBox_register = new System.Windows.Forms.CheckedListBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.checkedListBox_tasks = new System.Windows.Forms.CheckedListBox();
            this.button_submit = new System.Windows.Forms.Button();
            this.label_form_info = new System.Windows.Forms.Label();
            this.textBox_warning_msg = new System.Windows.Forms.TextBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_run = new System.Windows.Forms.Button();
            this.textBox_review_code = new System.Windows.Forms.RichTextBox();
            this.tabControl_1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_feature_list
            // 
            this.lbl_feature_list.AutoSize = true;
            this.lbl_feature_list.Location = new System.Drawing.Point(6, 10);
            this.lbl_feature_list.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_feature_list.Name = "lbl_feature_list";
            this.lbl_feature_list.Size = new System.Drawing.Size(128, 51);
            this.lbl_feature_list.TabIndex = 6;
            this.lbl_feature_list.Text = "* Remove Apps\r\n* Edit Services\r\n* Edit Privacy";
            // 
            // checkBox_WinUpgrade
            // 
            this.checkBox_WinUpgrade.AutoSize = true;
            this.checkBox_WinUpgrade.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_WinUpgrade.Location = new System.Drawing.Point(4, 115);
            this.checkBox_WinUpgrade.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_WinUpgrade.Name = "checkBox_WinUpgrade";
            this.checkBox_WinUpgrade.Size = new System.Drawing.Size(208, 19);
            this.checkBox_WinUpgrade.TabIndex = 12;
            this.checkBox_WinUpgrade.Text = "Locking Windows 11 Upgrade";
            this.checkBox_WinUpgrade.UseVisualStyleBackColor = true;
            // 
            // label_TimeZone
            // 
            this.label_TimeZone.AutoSize = true;
            this.label_TimeZone.Location = new System.Drawing.Point(24, 221);
            this.label_TimeZone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_TimeZone.Name = "label_TimeZone";
            this.label_TimeZone.Size = new System.Drawing.Size(88, 17);
            this.label_TimeZone.TabIndex = 8;
            this.label_TimeZone.Text = "Time Zone:";
            // 
            // comboBox_TimeZone
            // 
            this.comboBox_TimeZone.FormattingEnabled = true;
            this.comboBox_TimeZone.Items.AddRange(new object[] {
            "Central Standard Time",
            "Mountain Standard Time"});
            this.comboBox_TimeZone.Location = new System.Drawing.Point(6, 236);
            this.comboBox_TimeZone.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_TimeZone.Name = "comboBox_TimeZone";
            this.comboBox_TimeZone.Size = new System.Drawing.Size(214, 24);
            this.comboBox_TimeZone.TabIndex = 7;
            this.comboBox_TimeZone.Text = "Central Standard Time";
            // 
            // checkBox_CreateRestore
            // 
            this.checkBox_CreateRestore.AutoSize = true;
            this.checkBox_CreateRestore.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_CreateRestore.Location = new System.Drawing.Point(4, 92);
            this.checkBox_CreateRestore.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_CreateRestore.Name = "checkBox_CreateRestore";
            this.checkBox_CreateRestore.Size = new System.Drawing.Size(166, 19);
            this.checkBox_CreateRestore.TabIndex = 6;
            this.checkBox_CreateRestore.Text = "Create Restore Point";
            this.checkBox_CreateRestore.UseVisualStyleBackColor = true;
            // 
            // checkBox_ConfigTRIM
            // 
            this.checkBox_ConfigTRIM.AutoSize = true;
            this.checkBox_ConfigTRIM.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_ConfigTRIM.Location = new System.Drawing.Point(4, 69);
            this.checkBox_ConfigTRIM.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_ConfigTRIM.Name = "checkBox_ConfigTRIM";
            this.checkBox_ConfigTRIM.Size = new System.Drawing.Size(278, 19);
            this.checkBox_ConfigTRIM.TabIndex = 5;
            this.checkBox_ConfigTRIM.Text = "Configure Over Provisioning via TRIM";
            this.checkBox_ConfigTRIM.UseVisualStyleBackColor = true;
            // 
            // checkBox_BootLegacy
            // 
            this.checkBox_BootLegacy.AutoSize = true;
            this.checkBox_BootLegacy.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_BootLegacy.Location = new System.Drawing.Point(4, 46);
            this.checkBox_BootLegacy.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_BootLegacy.Name = "checkBox_BootLegacy";
            this.checkBox_BootLegacy.Size = new System.Drawing.Size(124, 19);
            this.checkBox_BootLegacy.TabIndex = 4;
            this.checkBox_BootLegacy.Text = "Boot to Legacy";
            this.checkBox_BootLegacy.UseVisualStyleBackColor = true;
            // 
            // textBox_ChangeComputerName
            // 
            this.textBox_ChangeComputerName.Location = new System.Drawing.Point(174, 23);
            this.textBox_ChangeComputerName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ChangeComputerName.Name = "textBox_ChangeComputerName";
            this.textBox_ChangeComputerName.Size = new System.Drawing.Size(157, 23);
            this.textBox_ChangeComputerName.TabIndex = 3;
            // 
            // checkBox_ChangeComputerName
            // 
            this.checkBox_ChangeComputerName.AutoSize = true;
            this.checkBox_ChangeComputerName.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_ChangeComputerName.Location = new System.Drawing.Point(4, 23);
            this.checkBox_ChangeComputerName.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_ChangeComputerName.Name = "checkBox_ChangeComputerName";
            this.checkBox_ChangeComputerName.Size = new System.Drawing.Size(166, 19);
            this.checkBox_ChangeComputerName.TabIndex = 2;
            this.checkBox_ChangeComputerName.Text = "Change Computer Name";
            this.checkBox_ChangeComputerName.UseVisualStyleBackColor = true;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(8, 5);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(334, 27);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Window\'s Custom Cleaner";
            // 
            // tabControl_1
            // 
            this.tabControl_1.Controls.Add(this.tabPage1);
            this.tabControl_1.Controls.Add(this.tabPage2);
            this.tabControl_1.Controls.Add(this.tabPage3);
            this.tabControl_1.Controls.Add(this.tabPage4);
            this.tabControl_1.Controls.Add(this.tabPage5);
            this.tabControl_1.Controls.Add(this.tabPage6);
            this.tabControl_1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl_1.Location = new System.Drawing.Point(11, 81);
            this.tabControl_1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl_1.Name = "tabControl_1";
            this.tabControl_1.SelectedIndex = 0;
            this.tabControl_1.Size = new System.Drawing.Size(539, 293);
            this.tabControl_1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.lbl_feature_list);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(531, 264);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Features";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.checkBox_createLogFile);
            this.tabPage2.Controls.Add(this.label_LLMNR);
            this.tabPage2.Controls.Add(this.comboBox_LLMNR);
            this.tabPage2.Controls.Add(this.label_NBTNS);
            this.tabPage2.Controls.Add(this.comboBox_NBTNS);
            this.tabPage2.Controls.Add(this.label_netFramework);
            this.tabPage2.Controls.Add(this.comboBox_netFramework);
            this.tabPage2.Controls.Add(this.checkBox_WinUpgrade);
            this.tabPage2.Controls.Add(this.checkBox_ChangeComputerName);
            this.tabPage2.Controls.Add(this.textBox_ChangeComputerName);
            this.tabPage2.Controls.Add(this.checkBox_BootLegacy);
            this.tabPage2.Controls.Add(this.checkBox_ConfigTRIM);
            this.tabPage2.Controls.Add(this.label_TimeZone);
            this.tabPage2.Controls.Add(this.checkBox_CreateRestore);
            this.tabPage2.Controls.Add(this.comboBox_TimeZone);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(531, 264);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Initialize";
            // 
            // checkBox_createLogFile
            // 
            this.checkBox_createLogFile.AutoSize = true;
            this.checkBox_createLogFile.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBox_createLogFile.Location = new System.Drawing.Point(4, 4);
            this.checkBox_createLogFile.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox_createLogFile.Name = "checkBox_createLogFile";
            this.checkBox_createLogFile.Size = new System.Drawing.Size(131, 19);
            this.checkBox_createLogFile.TabIndex = 22;
            this.checkBox_createLogFile.Text = "Create Log File";
            this.checkBox_createLogFile.UseVisualStyleBackColor = true;
            // 
            // label_LLMNR
            // 
            this.label_LLMNR.AutoSize = true;
            this.label_LLMNR.Location = new System.Drawing.Point(119, 194);
            this.label_LLMNR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LLMNR.Name = "label_LLMNR";
            this.label_LLMNR.Size = new System.Drawing.Size(48, 17);
            this.label_LLMNR.TabIndex = 21;
            this.label_LLMNR.Text = "LLMNR";
            // 
            // comboBox_LLMNR
            // 
            this.comboBox_LLMNR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LLMNR.FormattingEnabled = true;
            this.comboBox_LLMNR.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.comboBox_LLMNR.Location = new System.Drawing.Point(6, 194);
            this.comboBox_LLMNR.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_LLMNR.Name = "comboBox_LLMNR";
            this.comboBox_LLMNR.Size = new System.Drawing.Size(110, 24);
            this.comboBox_LLMNR.TabIndex = 20;
            // 
            // label_NBTNS
            // 
            this.label_NBTNS.AutoSize = true;
            this.label_NBTNS.Location = new System.Drawing.Point(119, 166);
            this.label_NBTNS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_NBTNS.Name = "label_NBTNS";
            this.label_NBTNS.Size = new System.Drawing.Size(56, 17);
            this.label_NBTNS.TabIndex = 19;
            this.label_NBTNS.Text = "NBT-NS";
            // 
            // comboBox_NBTNS
            // 
            this.comboBox_NBTNS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_NBTNS.FormattingEnabled = true;
            this.comboBox_NBTNS.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.comboBox_NBTNS.Location = new System.Drawing.Point(6, 166);
            this.comboBox_NBTNS.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_NBTNS.Name = "comboBox_NBTNS";
            this.comboBox_NBTNS.Size = new System.Drawing.Size(110, 24);
            this.comboBox_NBTNS.TabIndex = 18;
            // 
            // label_netFramework
            // 
            this.label_netFramework.AutoSize = true;
            this.label_netFramework.Location = new System.Drawing.Point(119, 138);
            this.label_netFramework.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_netFramework.Name = "label_netFramework";
            this.label_netFramework.Size = new System.Drawing.Size(120, 17);
            this.label_netFramework.TabIndex = 17;
            this.label_netFramework.Text = ".Net Framework";
            // 
            // comboBox_netFramework
            // 
            this.comboBox_netFramework.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_netFramework.FormattingEnabled = true;
            this.comboBox_netFramework.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.comboBox_netFramework.Location = new System.Drawing.Point(6, 138);
            this.comboBox_netFramework.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_netFramework.Name = "comboBox_netFramework";
            this.comboBox_netFramework.Size = new System.Drawing.Size(110, 24);
            this.comboBox_netFramework.TabIndex = 16;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.label_DiagnosticsTracking);
            this.tabPage3.Controls.Add(this.comboBox_diagnosticTracking);
            this.tabPage3.Controls.Add(this.label_LocationTracking);
            this.tabPage3.Controls.Add(this.comboBox_locationTracking);
            this.tabPage3.Controls.Add(this.label_DataCollection);
            this.tabPage3.Controls.Add(this.comboBox_dataCollection);
            this.tabPage3.Controls.Add(this.label_wifiSense);
            this.tabPage3.Controls.Add(this.comboBox_wifiSense);
            this.tabPage3.Controls.Add(this.label_cortana);
            this.tabPage3.Controls.Add(this.comboBox_cortana);
            this.tabPage3.Controls.Add(this.label_webSearch);
            this.tabPage3.Controls.Add(this.comboBox_webSearch);
            this.tabPage3.Controls.Add(this.label_anonymousData);
            this.tabPage3.Controls.Add(this.comboBox_anonymousData);
            this.tabPage3.Controls.Add(this.label_ad);
            this.tabPage3.Controls.Add(this.comboBox_ad);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(531, 264);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Privacy";
            // 
            // label_DiagnosticsTracking
            // 
            this.label_DiagnosticsTracking.AutoSize = true;
            this.label_DiagnosticsTracking.Location = new System.Drawing.Point(136, 222);
            this.label_DiagnosticsTracking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DiagnosticsTracking.Name = "label_DiagnosticsTracking";
            this.label_DiagnosticsTracking.Size = new System.Drawing.Size(232, 17);
            this.label_DiagnosticsTracking.TabIndex = 25;
            this.label_DiagnosticsTracking.Text = "Diagnostics Tracking Service";
            // 
            // comboBox_diagnosticTracking
            // 
            this.comboBox_diagnosticTracking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_diagnosticTracking.FormattingEnabled = true;
            this.comboBox_diagnosticTracking.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.comboBox_diagnosticTracking.Location = new System.Drawing.Point(5, 217);
            this.comboBox_diagnosticTracking.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_diagnosticTracking.Name = "comboBox_diagnosticTracking";
            this.comboBox_diagnosticTracking.Size = new System.Drawing.Size(129, 24);
            this.comboBox_diagnosticTracking.TabIndex = 24;
            // 
            // label_LocationTracking
            // 
            this.label_LocationTracking.AutoSize = true;
            this.label_LocationTracking.Location = new System.Drawing.Point(136, 189);
            this.label_LocationTracking.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_LocationTracking.Name = "label_LocationTracking";
            this.label_LocationTracking.Size = new System.Drawing.Size(144, 17);
            this.label_LocationTracking.TabIndex = 23;
            this.label_LocationTracking.Text = "Location Tracking";
            // 
            // comboBox_locationTracking
            // 
            this.comboBox_locationTracking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_locationTracking.FormattingEnabled = true;
            this.comboBox_locationTracking.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.comboBox_locationTracking.Location = new System.Drawing.Point(5, 185);
            this.comboBox_locationTracking.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_locationTracking.Name = "comboBox_locationTracking";
            this.comboBox_locationTracking.Size = new System.Drawing.Size(129, 24);
            this.comboBox_locationTracking.TabIndex = 22;
            // 
            // label_DataCollection
            // 
            this.label_DataCollection.AutoSize = true;
            this.label_DataCollection.Location = new System.Drawing.Point(136, 159);
            this.label_DataCollection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_DataCollection.Name = "label_DataCollection";
            this.label_DataCollection.Size = new System.Drawing.Size(272, 17);
            this.label_DataCollection.TabIndex = 21;
            this.label_DataCollection.Text = "Data Collection via AllowTelemtry";
            // 
            // comboBox_dataCollection
            // 
            this.comboBox_dataCollection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_dataCollection.FormattingEnabled = true;
            this.comboBox_dataCollection.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.comboBox_dataCollection.Location = new System.Drawing.Point(5, 154);
            this.comboBox_dataCollection.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_dataCollection.Name = "comboBox_dataCollection";
            this.comboBox_dataCollection.Size = new System.Drawing.Size(129, 24);
            this.comboBox_dataCollection.TabIndex = 20;
            // 
            // label_wifiSense
            // 
            this.label_wifiSense.AutoSize = true;
            this.label_wifiSense.Location = new System.Drawing.Point(136, 128);
            this.label_wifiSense.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_wifiSense.Name = "label_wifiSense";
            this.label_wifiSense.Size = new System.Drawing.Size(96, 17);
            this.label_wifiSense.TabIndex = 19;
            this.label_wifiSense.Text = "Wi-Fi Sense";
            // 
            // comboBox_wifiSense
            // 
            this.comboBox_wifiSense.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_wifiSense.FormattingEnabled = true;
            this.comboBox_wifiSense.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.comboBox_wifiSense.Location = new System.Drawing.Point(5, 123);
            this.comboBox_wifiSense.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_wifiSense.Name = "comboBox_wifiSense";
            this.comboBox_wifiSense.Size = new System.Drawing.Size(129, 24);
            this.comboBox_wifiSense.TabIndex = 18;
            // 
            // label_cortana
            // 
            this.label_cortana.AutoSize = true;
            this.label_cortana.Location = new System.Drawing.Point(136, 40);
            this.label_cortana.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cortana.Name = "label_cortana";
            this.label_cortana.Size = new System.Drawing.Size(240, 17);
            this.label_cortana.TabIndex = 17;
            this.label_cortana.Text = "Use Cortana in Windows Search";
            // 
            // comboBox_cortana
            // 
            this.comboBox_cortana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_cortana.FormattingEnabled = true;
            this.comboBox_cortana.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.comboBox_cortana.Location = new System.Drawing.Point(5, 35);
            this.comboBox_cortana.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_cortana.Name = "comboBox_cortana";
            this.comboBox_cortana.Size = new System.Drawing.Size(129, 24);
            this.comboBox_cortana.TabIndex = 16;
            // 
            // label_webSearch
            // 
            this.label_webSearch.AutoSize = true;
            this.label_webSearch.Location = new System.Drawing.Point(136, 69);
            this.label_webSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_webSearch.Name = "label_webSearch";
            this.label_webSearch.Size = new System.Drawing.Size(200, 17);
            this.label_webSearch.TabIndex = 15;
            this.label_webSearch.Text = "Web Search in Start Menu";
            // 
            // comboBox_webSearch
            // 
            this.comboBox_webSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_webSearch.FormattingEnabled = true;
            this.comboBox_webSearch.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.comboBox_webSearch.Location = new System.Drawing.Point(5, 64);
            this.comboBox_webSearch.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_webSearch.Name = "comboBox_webSearch";
            this.comboBox_webSearch.Size = new System.Drawing.Size(129, 24);
            this.comboBox_webSearch.TabIndex = 14;
            // 
            // label_anonymousData
            // 
            this.label_anonymousData.AutoSize = true;
            this.label_anonymousData.Location = new System.Drawing.Point(136, 98);
            this.label_anonymousData.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_anonymousData.Name = "label_anonymousData";
            this.label_anonymousData.Size = new System.Drawing.Size(160, 17);
            this.label_anonymousData.TabIndex = 13;
            this.label_anonymousData.Text = "Send Anonymous Data";
            // 
            // comboBox_anonymousData
            // 
            this.comboBox_anonymousData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_anonymousData.FormattingEnabled = true;
            this.comboBox_anonymousData.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.comboBox_anonymousData.Location = new System.Drawing.Point(5, 94);
            this.comboBox_anonymousData.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_anonymousData.Name = "comboBox_anonymousData";
            this.comboBox_anonymousData.Size = new System.Drawing.Size(129, 24);
            this.comboBox_anonymousData.TabIndex = 12;
            // 
            // label_ad
            // 
            this.label_ad.AutoSize = true;
            this.label_ad.Location = new System.Drawing.Point(136, 11);
            this.label_ad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ad.Name = "label_ad";
            this.label_ad.Size = new System.Drawing.Size(224, 17);
            this.label_ad.TabIndex = 9;
            this.label_ad.Text = "Windows Feedback Experience";
            // 
            // comboBox_ad
            // 
            this.comboBox_ad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ad.FormattingEnabled = true;
            this.comboBox_ad.Items.AddRange(new object[] {
            "Enable",
            "Disable"});
            this.comboBox_ad.Location = new System.Drawing.Point(5, 7);
            this.comboBox_ad.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_ad.Name = "comboBox_ad";
            this.comboBox_ad.Size = new System.Drawing.Size(129, 24);
            this.comboBox_ad.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.checkedListBox_debloat);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(531, 264);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Debloat";
            this.tabPage4.Enter += new System.EventHandler(this.load_debloat);
            // 
            // checkedListBox_debloat
            // 
            this.checkedListBox_debloat.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox_debloat.FormattingEnabled = true;
            this.checkedListBox_debloat.Location = new System.Drawing.Point(6, 9);
            this.checkedListBox_debloat.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox_debloat.Name = "checkedListBox_debloat";
            this.checkedListBox_debloat.Size = new System.Drawing.Size(502, 229);
            this.checkedListBox_debloat.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.checkedListBox_register);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(531, 264);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Registry";
            this.tabPage5.Enter += new System.EventHandler(this.load_registery);
            // 
            // checkedListBox_register
            // 
            this.checkedListBox_register.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox_register.FormattingEnabled = true;
            this.checkedListBox_register.Location = new System.Drawing.Point(6, 6);
            this.checkedListBox_register.Name = "checkedListBox_register";
            this.checkedListBox_register.Size = new System.Drawing.Size(519, 244);
            this.checkedListBox_register.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.checkedListBox_tasks);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(531, 264);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Tasks";
            this.tabPage6.Enter += new System.EventHandler(this.load_tasks);
            // 
            // checkedListBox_tasks
            // 
            this.checkedListBox_tasks.FormattingEnabled = true;
            this.checkedListBox_tasks.Location = new System.Drawing.Point(6, 14);
            this.checkedListBox_tasks.Name = "checkedListBox_tasks";
            this.checkedListBox_tasks.Size = new System.Drawing.Size(504, 238);
            this.checkedListBox_tasks.TabIndex = 0;
            // 
            // button_submit
            // 
            this.button_submit.Location = new System.Drawing.Point(468, 394);
            this.button_submit.Margin = new System.Windows.Forms.Padding(2);
            this.button_submit.Name = "button_submit";
            this.button_submit.Size = new System.Drawing.Size(78, 30);
            this.button_submit.TabIndex = 16;
            this.button_submit.Text = "Submit";
            this.button_submit.UseVisualStyleBackColor = true;
            this.button_submit.Click += new System.EventHandler(this.button_submit_Click);
            // 
            // label_form_info
            // 
            this.label_form_info.AutoSize = true;
            this.label_form_info.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label_form_info.Location = new System.Drawing.Point(21, 402);
            this.label_form_info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_form_info.Name = "label_form_info";
            this.label_form_info.Size = new System.Drawing.Size(101, 15);
            this.label_form_info.TabIndex = 17;
            this.label_form_info.Text = "Form Information";
            // 
            // textBox_warning_msg
            // 
            this.textBox_warning_msg.Enabled = false;
            this.textBox_warning_msg.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox_warning_msg.ForeColor = System.Drawing.Color.Red;
            this.textBox_warning_msg.Location = new System.Drawing.Point(8, 34);
            this.textBox_warning_msg.Multiline = true;
            this.textBox_warning_msg.Name = "textBox_warning_msg";
            this.textBox_warning_msg.ReadOnly = true;
            this.textBox_warning_msg.Size = new System.Drawing.Size(702, 67);
            this.textBox_warning_msg.TabIndex = 20;
            this.textBox_warning_msg.Text = "Please note that this script may edit registeries, uninstall apps, and change set" +
    "tings. You are responsible for reviewingt the code before execution. ";
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(469, 429);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(81, 26);
            this.button_cancel.TabIndex = 21;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_run
            // 
            this.button_run.Location = new System.Drawing.Point(556, 429);
            this.button_run.Name = "button_run";
            this.button_run.Size = new System.Drawing.Size(81, 26);
            this.button_run.TabIndex = 22;
            this.button_run.Text = "Run";
            this.button_run.UseVisualStyleBackColor = true;
            this.button_run.Click += new System.EventHandler(this.button_run_Click);
            // 
            // textBox_review_code
            // 
            this.textBox_review_code.Location = new System.Drawing.Point(8, 107);
            this.textBox_review_code.Name = "textBox_review_code";
            this.textBox_review_code.ReadOnly = true;
            this.textBox_review_code.Size = new System.Drawing.Size(696, 282);
            this.textBox_review_code.TabIndex = 24;
            this.textBox_review_code.Text = "";
            // 
            // frm_custom_clean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 464);
            this.Controls.Add(this.textBox_review_code);
            this.Controls.Add(this.button_run);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.textBox_warning_msg);
            this.Controls.Add(this.label_form_info);
            this.Controls.Add(this.button_submit);
            this.Controls.Add(this.tabControl_1);
            this.Controls.Add(this.lbl_title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_custom_clean";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frm_custom_clean_Load);
            this.tabControl_1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_title;
        private Label lbl_feature_list;
        private CheckBox checkBox_WinUpgrade;
        private Label label_TimeZone;
        private ComboBox comboBox_TimeZone;
        private CheckBox checkBox_CreateRestore;
        private CheckBox checkBox_ConfigTRIM;
        private CheckBox checkBox_BootLegacy;
        private TextBox textBox_ChangeComputerName;
        private CheckBox checkBox_ChangeComputerName;
        private TabControl tabControl_1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private CheckBox checkBox_createLogFile;
        private Label label_LLMNR;
        private ComboBox comboBox_LLMNR;
        private Label label_NBTNS;
        private ComboBox comboBox_NBTNS;
        private Label label_netFramework;
        private ComboBox comboBox_netFramework;
        private Label label_ad;
        private ComboBox comboBox_ad;
        private Label label_DiagnosticsTracking;
        private ComboBox comboBox_diagnosticTracking;
        private Label label_LocationTracking;
        private ComboBox comboBox_locationTracking;
        private Label label_DataCollection;
        private ComboBox comboBox_dataCollection;
        private Label label_wifiSense;
        private ComboBox comboBox_wifiSense;
        private Label label_cortana;
        private ComboBox comboBox_cortana;
        private Label label_webSearch;
        private ComboBox comboBox_webSearch;
        private Label label_anonymousData;
        private ComboBox comboBox_anonymousData;
        private Button button_submit;
        private Label label_form_info;
        private CheckedListBox checkedListBox_debloat;
        private TabPage tabPage5;
        private CheckedListBox checkedListBox_register;
        private TabPage tabPage6;
        private CheckedListBox checkedListBox_tasks;
        private TextBox textBox_warning_msg;
        private Button button_cancel;
        private Button button_run;
        private RichTextBox textBox_review_code;
    }
}