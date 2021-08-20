namespace uWAVE_Host
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.connectBtn = new System.Windows.Forms.ToolStripButton();
            this.settingsBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.commandModeSwitchBtn = new System.Windows.Forms.ToolStripButton();
            this.infoBtn = new System.Windows.Forms.ToolStripButton();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.commandTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gravityAccEdit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.isACKOnTXFinishedChb = new System.Windows.Forms.CheckBox();
            this.isCommandModeByDefaultChb = new System.Windows.Forms.CheckBox();
            this.devSettingsApplyBtn = new System.Windows.Forms.Button();
            this.devSettingsQueryBtn = new System.Windows.Forms.Button();
            this.salinityEdit = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.rxChIDCbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txChIDCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deviceInfoTxb = new System.Windows.Forms.RichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rcClearStatsBtn = new System.Windows.Forms.Button();
            this.rcTxb = new System.Windows.Forms.RichTextBox();
            this.rcAutoChb = new System.Windows.Forms.CheckBox();
            this.rcQueryBtn = new System.Windows.Forms.Button();
            this.rcQueryIdCbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rcTargetRxChIDCbx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rcTargetTxChIDCbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.AMBSetBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ambTxb = new System.Windows.Forms.RichTextBox();
            this.packetModeTab = new System.Windows.Forms.TabPage();
            this.ptTriesEdit = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.isPtModeChb = new System.Windows.Forms.CheckBox();
            this.ptQuerySettingsBtn = new System.Windows.Forms.Button();
            this.ptApplySettingsBtn = new System.Windows.Forms.Button();
            this.ptIsSaveToFlashChb = new System.Windows.Forms.CheckBox();
            this.ptLocalAddressEdit = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ptTargetAddressEdit = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.ptSendBtn = new System.Windows.Forms.Button();
            this.ptToSendTxb = new System.Windows.Forms.TextBox();
            this.ptSendTxbCtx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ptSend8ByteStrBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ptSend16ByteStrBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ptSend32ByteStrBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ptSendClearBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.ptHistoryTxb = new System.Windows.Forms.RichTextBox();
            this.ptHistoryCtx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ptClearTxbBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.packetRequestsTab = new System.Windows.Forms.TabPage();
            this.ptQueryHistoryClearBtn = new System.Windows.Forms.Button();
            this.ptQueryHistoryTxb = new System.Windows.Forms.RichTextBox();
            this.ptQueryBtn = new System.Windows.Forms.Button();
            this.ptQueryDataIDCbx = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ptQueryAddressEdit = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.rawSendBtn = new System.Windows.Forms.Button();
            this.rawSendTxb = new System.Windows.Forms.TextBox();
            this.rawSendTxbContextMnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.generateDatetimeStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.random8byteStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.random16byteStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.random32byteStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.random64byteStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.random128byteStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawHistoryTxb = new System.Windows.Forms.RichTextBox();
            this.historyTxb = new System.Windows.Forms.RichTextBox();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.historyToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.histCopyBtn = new System.Windows.Forms.ToolStripButton();
            this.histExportBtn = new System.Windows.Forms.ToolStripButton();
            this.histClearBtn = new System.Windows.Forms.ToolStripButton();
            this.cmdModePnl = new System.Windows.Forms.Panel();
            this.commandModeToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rawModePnl = new System.Windows.Forms.Panel();
            this.rawModeToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rawCopyBtn = new System.Windows.Forms.ToolStripButton();
            this.rawExportBtn = new System.Windows.Forms.ToolStripButton();
            this.rawClearBtn = new System.Windows.Forms.ToolStripButton();
            this.stdSetGroup = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AMBUpdatePeriodEdit = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.isAMBSaveSettingsToFlashChb = new System.Windows.Forms.CheckBox();
            this.ambItemsGroup = new System.Windows.Forms.GroupBox();
            this.isAMBVoltageChb = new System.Windows.Forms.CheckBox();
            this.isAMBDepthChb = new System.Windows.Forms.CheckBox();
            this.isAMBTemperatureChb = new System.Windows.Forms.CheckBox();
            this.isAMBPressureChb = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.ptcRolSetBtn = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.PtcRolUpdatePeriodEdit = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.isPtcRolSaveToFlashChb = new System.Windows.Forms.CheckBox();
            this.ptcRolTxb = new System.Windows.Forms.RichTextBox();
            this.mainToolStrip.SuspendLayout();
            this.commandTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gravityAccEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salinityEdit)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.packetModeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptTriesEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLocalAddressEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptTargetAddressEdit)).BeginInit();
            this.ptSendTxbCtx.SuspendLayout();
            this.ptHistoryCtx.SuspendLayout();
            this.packetRequestsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptQueryAddressEdit)).BeginInit();
            this.rawSendTxbContextMnu.SuspendLayout();
            this.btnPanel.SuspendLayout();
            this.historyToolStrip.SuspendLayout();
            this.cmdModePnl.SuspendLayout();
            this.commandModeToolStrip.SuspendLayout();
            this.rawModePnl.SuspendLayout();
            this.rawModeToolStrip.SuspendLayout();
            this.stdSetGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AMBUpdatePeriodEdit)).BeginInit();
            this.ambItemsGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtcRolUpdatePeriodEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectBtn,
            this.settingsBtn,
            this.toolStripSeparator1,
            this.commandModeSwitchBtn,
            this.infoBtn});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(1216, 30);
            this.mainToolStrip.TabIndex = 0;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // connectBtn
            // 
            this.connectBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.connectBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectBtn.Image = ((System.Drawing.Image)(resources.GetObject("connectBtn.Image")));
            this.connectBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(94, 27);
            this.connectBtn.Text = "CONNECT";
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(93, 27);
            this.settingsBtn.Text = "SETTINGS";
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 30);
            // 
            // commandModeSwitchBtn
            // 
            this.commandModeSwitchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.commandModeSwitchBtn.Enabled = false;
            this.commandModeSwitchBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commandModeSwitchBtn.Image = ((System.Drawing.Image)(resources.GetObject("commandModeSwitchBtn.Image")));
            this.commandModeSwitchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.commandModeSwitchBtn.Name = "commandModeSwitchBtn";
            this.commandModeSwitchBtn.Size = new System.Drawing.Size(164, 27);
            this.commandModeSwitchBtn.Text = "COMMAND MODE";
            this.commandModeSwitchBtn.Click += new System.EventHandler(this.commandModeSwitchBtn_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.infoBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBtn.Image = ((System.Drawing.Image)(resources.GetObject("infoBtn.Image")));
            this.infoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(54, 27);
            this.infoBtn.Text = "INFO";
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 602);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.mainStatusStrip.Size = new System.Drawing.Size(1216, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // commandTab
            // 
            this.commandTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandTab.Controls.Add(this.tabPage1);
            this.commandTab.Controls.Add(this.tabPage4);
            this.commandTab.Controls.Add(this.tabPage3);
            this.commandTab.Controls.Add(this.tabPage2);
            this.commandTab.Controls.Add(this.packetModeTab);
            this.commandTab.Controls.Add(this.packetRequestsTab);
            this.commandTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commandTab.Location = new System.Drawing.Point(4, 36);
            this.commandTab.Margin = new System.Windows.Forms.Padding(4);
            this.commandTab.Name = "commandTab";
            this.commandTab.SelectedIndex = 0;
            this.commandTab.Size = new System.Drawing.Size(717, 335);
            this.commandTab.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gravityAccEdit);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.isACKOnTXFinishedChb);
            this.tabPage1.Controls.Add(this.isCommandModeByDefaultChb);
            this.tabPage1.Controls.Add(this.devSettingsApplyBtn);
            this.tabPage1.Controls.Add(this.devSettingsQueryBtn);
            this.tabPage1.Controls.Add(this.salinityEdit);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.rxChIDCbx);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txChIDCbx);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.deviceInfoTxb);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(709, 304);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DEVICE INFO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gravityAccEdit
            // 
            this.gravityAccEdit.DecimalPlaces = 4;
            this.gravityAccEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gravityAccEdit.Location = new System.Drawing.Point(346, 189);
            this.gravityAccEdit.Margin = new System.Windows.Forms.Padding(4);
            this.gravityAccEdit.Maximum = new decimal(new int[] {
            984,
            0,
            0,
            131072});
            this.gravityAccEdit.Minimum = new decimal(new int[] {
            977,
            0,
            0,
            131072});
            this.gravityAccEdit.Name = "gravityAccEdit";
            this.gravityAccEdit.Size = new System.Drawing.Size(143, 26);
            this.gravityAccEdit.TabIndex = 15;
            this.gravityAccEdit.Value = new decimal(new int[] {
            98067,
            0,
            0,
            262144});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(345, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Gravity acc., m/s²";
            // 
            // isACKOnTXFinishedChb
            // 
            this.isACKOnTXFinishedChb.AutoSize = true;
            this.isACKOnTXFinishedChb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isACKOnTXFinishedChb.Location = new System.Drawing.Point(169, 273);
            this.isACKOnTXFinishedChb.Margin = new System.Windows.Forms.Padding(4);
            this.isACKOnTXFinishedChb.Name = "isACKOnTXFinishedChb";
            this.isACKOnTXFinishedChb.Size = new System.Drawing.Size(177, 24);
            this.isACKOnTXFinishedChb.TabIndex = 13;
            this.isACKOnTXFinishedChb.Text = "ACK on TX finished";
            this.isACKOnTXFinishedChb.UseVisualStyleBackColor = true;
            // 
            // isCommandModeByDefaultChb
            // 
            this.isCommandModeByDefaultChb.AutoSize = true;
            this.isCommandModeByDefaultChb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isCommandModeByDefaultChb.Location = new System.Drawing.Point(169, 241);
            this.isCommandModeByDefaultChb.Margin = new System.Windows.Forms.Padding(4);
            this.isCommandModeByDefaultChb.Name = "isCommandModeByDefaultChb";
            this.isCommandModeByDefaultChb.Size = new System.Drawing.Size(230, 24);
            this.isCommandModeByDefaultChb.TabIndex = 12;
            this.isCommandModeByDefaultChb.Text = "Command mode by default";
            this.isCommandModeByDefaultChb.UseVisualStyleBackColor = true;
            // 
            // devSettingsApplyBtn
            // 
            this.devSettingsApplyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.devSettingsApplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devSettingsApplyBtn.Location = new System.Drawing.Point(601, 259);
            this.devSettingsApplyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.devSettingsApplyBtn.Name = "devSettingsApplyBtn";
            this.devSettingsApplyBtn.Size = new System.Drawing.Size(100, 38);
            this.devSettingsApplyBtn.TabIndex = 11;
            this.devSettingsApplyBtn.Text = "APPLY";
            this.devSettingsApplyBtn.UseVisualStyleBackColor = true;
            this.devSettingsApplyBtn.Click += new System.EventHandler(this.devSettingsApplyBtn_Click);
            // 
            // devSettingsQueryBtn
            // 
            this.devSettingsQueryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.devSettingsQueryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devSettingsQueryBtn.Location = new System.Drawing.Point(601, 210);
            this.devSettingsQueryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.devSettingsQueryBtn.Name = "devSettingsQueryBtn";
            this.devSettingsQueryBtn.Size = new System.Drawing.Size(100, 38);
            this.devSettingsQueryBtn.TabIndex = 10;
            this.devSettingsQueryBtn.Text = "QUERY";
            this.devSettingsQueryBtn.UseVisualStyleBackColor = true;
            this.devSettingsQueryBtn.Click += new System.EventHandler(this.devSettingsQueryBtn_Click);
            // 
            // salinityEdit
            // 
            this.salinityEdit.DecimalPlaces = 1;
            this.salinityEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salinityEdit.Location = new System.Drawing.Point(169, 189);
            this.salinityEdit.Margin = new System.Windows.Forms.Padding(4);
            this.salinityEdit.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.salinityEdit.Name = "salinityEdit";
            this.salinityEdit.Size = new System.Drawing.Size(143, 26);
            this.salinityEdit.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(168, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Salinity, PSU";
            // 
            // rxChIDCbx
            // 
            this.rxChIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rxChIDCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rxChIDCbx.FormattingEnabled = true;
            this.rxChIDCbx.Location = new System.Drawing.Point(8, 252);
            this.rxChIDCbx.Margin = new System.Windows.Forms.Padding(4);
            this.rxChIDCbx.Name = "rxChIDCbx";
            this.rxChIDCbx.Size = new System.Drawing.Size(119, 28);
            this.rxChIDCbx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rx channel ID";
            // 
            // txChIDCbx
            // 
            this.txChIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txChIDCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txChIDCbx.FormattingEnabled = true;
            this.txChIDCbx.Location = new System.Drawing.Point(8, 189);
            this.txChIDCbx.Margin = new System.Windows.Forms.Padding(4);
            this.txChIDCbx.Name = "txChIDCbx";
            this.txChIDCbx.Size = new System.Drawing.Size(117, 28);
            this.txChIDCbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tx channel ID";
            // 
            // deviceInfoTxb
            // 
            this.deviceInfoTxb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceInfoTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceInfoTxb.Location = new System.Drawing.Point(8, 7);
            this.deviceInfoTxb.Margin = new System.Windows.Forms.Padding(4);
            this.deviceInfoTxb.Name = "deviceInfoTxb";
            this.deviceInfoTxb.ReadOnly = true;
            this.deviceInfoTxb.Size = new System.Drawing.Size(693, 135);
            this.deviceInfoTxb.TabIndex = 0;
            this.deviceInfoTxb.Text = "";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rcClearStatsBtn);
            this.tabPage4.Controls.Add(this.rcTxb);
            this.tabPage4.Controls.Add(this.rcAutoChb);
            this.tabPage4.Controls.Add(this.rcQueryBtn);
            this.tabPage4.Controls.Add(this.rcQueryIdCbx);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.rcTargetRxChIDCbx);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.rcTargetTxChIDCbx);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(709, 304);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "REMOTE QUERY";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rcClearStatsBtn
            // 
            this.rcClearStatsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rcClearStatsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rcClearStatsBtn.Location = new System.Drawing.Point(601, 258);
            this.rcClearStatsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rcClearStatsBtn.Name = "rcClearStatsBtn";
            this.rcClearStatsBtn.Size = new System.Drawing.Size(100, 38);
            this.rcClearStatsBtn.TabIndex = 15;
            this.rcClearStatsBtn.Text = "CLEAR";
            this.rcClearStatsBtn.UseVisualStyleBackColor = true;
            this.rcClearStatsBtn.Click += new System.EventHandler(this.rcClearStatsBtn_Click);
            // 
            // rcTxb
            // 
            this.rcTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rcTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rcTxb.Location = new System.Drawing.Point(242, 7);
            this.rcTxb.Margin = new System.Windows.Forms.Padding(4);
            this.rcTxb.Name = "rcTxb";
            this.rcTxb.ReadOnly = true;
            this.rcTxb.Size = new System.Drawing.Size(459, 243);
            this.rcTxb.TabIndex = 14;
            this.rcTxb.Text = "";
            this.rcTxb.TextChanged += new System.EventHandler(this.richTxb_TextChanged);
            // 
            // rcAutoChb
            // 
            this.rcAutoChb.AutoSize = true;
            this.rcAutoChb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rcAutoChb.Location = new System.Drawing.Point(16, 244);
            this.rcAutoChb.Name = "rcAutoChb";
            this.rcAutoChb.Size = new System.Drawing.Size(110, 22);
            this.rcAutoChb.TabIndex = 13;
            this.rcAutoChb.Text = "Auto query";
            this.rcAutoChb.UseVisualStyleBackColor = true;
            this.rcAutoChb.CheckedChanged += new System.EventHandler(this.rcAutoChb_CheckedChanged);
            // 
            // rcQueryBtn
            // 
            this.rcQueryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rcQueryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rcQueryBtn.Location = new System.Drawing.Point(242, 258);
            this.rcQueryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rcQueryBtn.Name = "rcQueryBtn";
            this.rcQueryBtn.Size = new System.Drawing.Size(100, 38);
            this.rcQueryBtn.TabIndex = 12;
            this.rcQueryBtn.Text = "QUERY";
            this.rcQueryBtn.UseVisualStyleBackColor = true;
            this.rcQueryBtn.Click += new System.EventHandler(this.rcQueryBtn_Click);
            // 
            // rcQueryIdCbx
            // 
            this.rcQueryIdCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rcQueryIdCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rcQueryIdCbx.DropDownWidth = 200;
            this.rcQueryIdCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rcQueryIdCbx.FormattingEnabled = true;
            this.rcQueryIdCbx.Location = new System.Drawing.Point(12, 182);
            this.rcQueryIdCbx.Margin = new System.Windows.Forms.Padding(4);
            this.rcQueryIdCbx.Name = "rcQueryIdCbx";
            this.rcQueryIdCbx.Size = new System.Drawing.Size(208, 28);
            this.rcQueryIdCbx.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Query ID";
            // 
            // rcTargetRxChIDCbx
            // 
            this.rcTargetRxChIDCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rcTargetRxChIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rcTargetRxChIDCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rcTargetRxChIDCbx.FormattingEnabled = true;
            this.rcTargetRxChIDCbx.Location = new System.Drawing.Point(12, 108);
            this.rcTargetRxChIDCbx.Margin = new System.Windows.Forms.Padding(4);
            this.rcTargetRxChIDCbx.Name = "rcTargetRxChIDCbx";
            this.rcTargetRxChIDCbx.Size = new System.Drawing.Size(117, 28);
            this.rcTargetRxChIDCbx.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Target Rx channel ID";
            // 
            // rcTargetTxChIDCbx
            // 
            this.rcTargetTxChIDCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rcTargetTxChIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rcTargetTxChIDCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rcTargetTxChIDCbx.FormattingEnabled = true;
            this.rcTargetTxChIDCbx.Location = new System.Drawing.Point(12, 36);
            this.rcTargetTxChIDCbx.Margin = new System.Windows.Forms.Padding(4);
            this.rcTargetTxChIDCbx.Name = "rcTargetTxChIDCbx";
            this.rcTargetTxChIDCbx.Size = new System.Drawing.Size(117, 28);
            this.rcTargetTxChIDCbx.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Target Tx channel ID";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.stdSetGroup);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(709, 304);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AMBIENT DATA SETTINGS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // AMBSetBtn
            // 
            this.AMBSetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AMBSetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AMBSetBtn.Location = new System.Drawing.Point(324, 244);
            this.AMBSetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.AMBSetBtn.Name = "AMBSetBtn";
            this.AMBSetBtn.Size = new System.Drawing.Size(100, 38);
            this.AMBSetBtn.TabIndex = 11;
            this.AMBSetBtn.Text = "APPLY";
            this.AMBSetBtn.UseVisualStyleBackColor = true;
            this.AMBSetBtn.Click += new System.EventHandler(this.AMBSetBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ptcRolTxb);
            this.tabPage2.Controls.Add(this.ambTxb);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(709, 304);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "AMBIENT DATA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ambTxb
            // 
            this.ambTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ambTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ambTxb.Location = new System.Drawing.Point(8, 7);
            this.ambTxb.Margin = new System.Windows.Forms.Padding(4);
            this.ambTxb.Name = "ambTxb";
            this.ambTxb.ReadOnly = true;
            this.ambTxb.Size = new System.Drawing.Size(464, 290);
            this.ambTxb.TabIndex = 0;
            this.ambTxb.Text = "";
            // 
            // packetModeTab
            // 
            this.packetModeTab.Controls.Add(this.ptTriesEdit);
            this.packetModeTab.Controls.Add(this.label14);
            this.packetModeTab.Controls.Add(this.isPtModeChb);
            this.packetModeTab.Controls.Add(this.ptQuerySettingsBtn);
            this.packetModeTab.Controls.Add(this.ptApplySettingsBtn);
            this.packetModeTab.Controls.Add(this.ptIsSaveToFlashChb);
            this.packetModeTab.Controls.Add(this.ptLocalAddressEdit);
            this.packetModeTab.Controls.Add(this.label13);
            this.packetModeTab.Controls.Add(this.label12);
            this.packetModeTab.Controls.Add(this.ptTargetAddressEdit);
            this.packetModeTab.Controls.Add(this.label11);
            this.packetModeTab.Controls.Add(this.ptSendBtn);
            this.packetModeTab.Controls.Add(this.ptToSendTxb);
            this.packetModeTab.Controls.Add(this.ptHistoryTxb);
            this.packetModeTab.Location = new System.Drawing.Point(4, 27);
            this.packetModeTab.Name = "packetModeTab";
            this.packetModeTab.Padding = new System.Windows.Forms.Padding(3);
            this.packetModeTab.Size = new System.Drawing.Size(709, 304);
            this.packetModeTab.TabIndex = 5;
            this.packetModeTab.Text = "PACKET MODE";
            this.packetModeTab.UseVisualStyleBackColor = true;
            // 
            // ptTriesEdit
            // 
            this.ptTriesEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ptTriesEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptTriesEdit.Location = new System.Drawing.Point(221, 275);
            this.ptTriesEdit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ptTriesEdit.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ptTriesEdit.Name = "ptTriesEdit";
            this.ptTriesEdit.Size = new System.Drawing.Size(56, 24);
            this.ptTriesEdit.TabIndex = 17;
            this.ptTriesEdit.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label14.Location = new System.Drawing.Point(163, 277);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 20);
            this.label14.TabIndex = 16;
            this.label14.Text = "Tries:";
            // 
            // isPtModeChb
            // 
            this.isPtModeChb.AutoSize = true;
            this.isPtModeChb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.isPtModeChb.Location = new System.Drawing.Point(6, 16);
            this.isPtModeChb.Name = "isPtModeChb";
            this.isPtModeChb.Size = new System.Drawing.Size(115, 24);
            this.isPtModeChb.TabIndex = 15;
            this.isPtModeChb.Text = "PT enabled";
            this.isPtModeChb.UseVisualStyleBackColor = true;
            this.isPtModeChb.CheckedChanged += new System.EventHandler(this.isPtModeChb_CheckedChanged);
            // 
            // ptQuerySettingsBtn
            // 
            this.ptQuerySettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptQuerySettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptQuerySettingsBtn.Location = new System.Drawing.Point(498, 13);
            this.ptQuerySettingsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ptQuerySettingsBtn.Name = "ptQuerySettingsBtn";
            this.ptQuerySettingsBtn.Size = new System.Drawing.Size(98, 28);
            this.ptQuerySettingsBtn.TabIndex = 14;
            this.ptQuerySettingsBtn.Text = "QUERY";
            this.ptQuerySettingsBtn.UseVisualStyleBackColor = true;
            this.ptQuerySettingsBtn.Click += new System.EventHandler(this.ptQuerySettingsBtn_Click);
            // 
            // ptApplySettingsBtn
            // 
            this.ptApplySettingsBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptApplySettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptApplySettingsBtn.Location = new System.Drawing.Point(604, 13);
            this.ptApplySettingsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ptApplySettingsBtn.Name = "ptApplySettingsBtn";
            this.ptApplySettingsBtn.Size = new System.Drawing.Size(88, 28);
            this.ptApplySettingsBtn.TabIndex = 13;
            this.ptApplySettingsBtn.Text = "APPLY";
            this.ptApplySettingsBtn.UseVisualStyleBackColor = true;
            this.ptApplySettingsBtn.Click += new System.EventHandler(this.ptApplySettingsBtn_Click);
            // 
            // ptIsSaveToFlashChb
            // 
            this.ptIsSaveToFlashChb.AutoSize = true;
            this.ptIsSaveToFlashChb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.ptIsSaveToFlashChb.Location = new System.Drawing.Point(350, 17);
            this.ptIsSaveToFlashChb.Name = "ptIsSaveToFlashChb";
            this.ptIsSaveToFlashChb.Size = new System.Drawing.Size(128, 24);
            this.ptIsSaveToFlashChb.TabIndex = 12;
            this.ptIsSaveToFlashChb.Text = "Save to flash";
            this.ptIsSaveToFlashChb.UseVisualStyleBackColor = true;
            // 
            // ptLocalAddressEdit
            // 
            this.ptLocalAddressEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptLocalAddressEdit.Location = new System.Drawing.Point(253, 16);
            this.ptLocalAddressEdit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ptLocalAddressEdit.Name = "ptLocalAddressEdit";
            this.ptLocalAddressEdit.Size = new System.Drawing.Size(74, 24);
            this.ptLocalAddressEdit.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label13.Location = new System.Drawing.Point(127, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 20);
            this.label13.TabIndex = 10;
            this.label13.Text = "Local address:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label12.Location = new System.Drawing.Point(304, 277);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Packet:";
            // 
            // ptTargetAddressEdit
            // 
            this.ptTargetAddressEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ptTargetAddressEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptTargetAddressEdit.Location = new System.Drawing.Point(74, 275);
            this.ptTargetAddressEdit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ptTargetAddressEdit.Name = "ptTargetAddressEdit";
            this.ptTargetAddressEdit.Size = new System.Drawing.Size(57, 24);
            this.ptTargetAddressEdit.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label11.Location = new System.Drawing.Point(6, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Target:";
            // 
            // ptSendBtn
            // 
            this.ptSendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ptSendBtn.Enabled = false;
            this.ptSendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptSendBtn.Location = new System.Drawing.Point(604, 272);
            this.ptSendBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ptSendBtn.Name = "ptSendBtn";
            this.ptSendBtn.Size = new System.Drawing.Size(88, 28);
            this.ptSendBtn.TabIndex = 6;
            this.ptSendBtn.Text = "SEND";
            this.ptSendBtn.UseVisualStyleBackColor = true;
            this.ptSendBtn.Click += new System.EventHandler(this.ptSendBtn_Click);
            // 
            // ptToSendTxb
            // 
            this.ptToSendTxb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptToSendTxb.ContextMenuStrip = this.ptSendTxbCtx;
            this.ptToSendTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptToSendTxb.Location = new System.Drawing.Point(376, 274);
            this.ptToSendTxb.Margin = new System.Windows.Forms.Padding(4);
            this.ptToSendTxb.MaxLength = 64;
            this.ptToSendTxb.Name = "ptToSendTxb";
            this.ptToSendTxb.Size = new System.Drawing.Size(220, 24);
            this.ptToSendTxb.TabIndex = 5;
            // 
            // ptSendTxbCtx
            // 
            this.ptSendTxbCtx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ptSend8ByteStrBtn,
            this.ptSend16ByteStrBtn,
            this.ptSend32ByteStrBtn,
            this.toolStripSeparator6,
            this.ptSendClearBtn});
            this.ptSendTxbCtx.Name = "ptSendTxbCtx";
            this.ptSendTxbCtx.Size = new System.Drawing.Size(231, 106);
            // 
            // ptSend8ByteStrBtn
            // 
            this.ptSend8ByteStrBtn.Name = "ptSend8ByteStrBtn";
            this.ptSend8ByteStrBtn.Size = new System.Drawing.Size(230, 24);
            this.ptSend8ByteStrBtn.Text = "Random 8-byte string";
            this.ptSend8ByteStrBtn.Click += new System.EventHandler(this.ptSend8ByteStrBtn_Click);
            // 
            // ptSend16ByteStrBtn
            // 
            this.ptSend16ByteStrBtn.Name = "ptSend16ByteStrBtn";
            this.ptSend16ByteStrBtn.Size = new System.Drawing.Size(230, 24);
            this.ptSend16ByteStrBtn.Text = "Random 16-byte string";
            this.ptSend16ByteStrBtn.Click += new System.EventHandler(this.ptSend16ByteStrBtn_Click);
            // 
            // ptSend32ByteStrBtn
            // 
            this.ptSend32ByteStrBtn.Name = "ptSend32ByteStrBtn";
            this.ptSend32ByteStrBtn.Size = new System.Drawing.Size(230, 24);
            this.ptSend32ByteStrBtn.Text = "Random 32-byte string";
            this.ptSend32ByteStrBtn.Click += new System.EventHandler(this.ptSend32ByteStrBtn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(227, 6);
            // 
            // ptSendClearBtn
            // 
            this.ptSendClearBtn.Name = "ptSendClearBtn";
            this.ptSendClearBtn.Size = new System.Drawing.Size(230, 24);
            this.ptSendClearBtn.Text = "Clear";
            this.ptSendClearBtn.Click += new System.EventHandler(this.ptSendClearBtn_Click);
            // 
            // ptHistoryTxb
            // 
            this.ptHistoryTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptHistoryTxb.ContextMenuStrip = this.ptHistoryCtx;
            this.ptHistoryTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptHistoryTxb.Location = new System.Drawing.Point(7, 49);
            this.ptHistoryTxb.Margin = new System.Windows.Forms.Padding(4);
            this.ptHistoryTxb.Name = "ptHistoryTxb";
            this.ptHistoryTxb.ReadOnly = true;
            this.ptHistoryTxb.Size = new System.Drawing.Size(685, 212);
            this.ptHistoryTxb.TabIndex = 4;
            this.ptHistoryTxb.Text = "";
            this.ptHistoryTxb.TextChanged += new System.EventHandler(this.richTxb_TextChanged);
            // 
            // ptHistoryCtx
            // 
            this.ptHistoryCtx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ptClearTxbBtn});
            this.ptHistoryCtx.Name = "ptHistoryCtx";
            this.ptHistoryCtx.Size = new System.Drawing.Size(122, 28);
            // 
            // ptClearTxbBtn
            // 
            this.ptClearTxbBtn.Name = "ptClearTxbBtn";
            this.ptClearTxbBtn.Size = new System.Drawing.Size(121, 24);
            this.ptClearTxbBtn.Text = "CLEAR";
            this.ptClearTxbBtn.Click += new System.EventHandler(this.ptClearTxbBtn_Click);
            // 
            // packetRequestsTab
            // 
            this.packetRequestsTab.Controls.Add(this.ptQueryHistoryClearBtn);
            this.packetRequestsTab.Controls.Add(this.ptQueryHistoryTxb);
            this.packetRequestsTab.Controls.Add(this.ptQueryBtn);
            this.packetRequestsTab.Controls.Add(this.ptQueryDataIDCbx);
            this.packetRequestsTab.Controls.Add(this.label16);
            this.packetRequestsTab.Controls.Add(this.ptQueryAddressEdit);
            this.packetRequestsTab.Controls.Add(this.label15);
            this.packetRequestsTab.Location = new System.Drawing.Point(4, 27);
            this.packetRequestsTab.Name = "packetRequestsTab";
            this.packetRequestsTab.Padding = new System.Windows.Forms.Padding(3);
            this.packetRequestsTab.Size = new System.Drawing.Size(709, 304);
            this.packetRequestsTab.TabIndex = 6;
            this.packetRequestsTab.Text = "PACKET REQUESTS";
            this.packetRequestsTab.UseVisualStyleBackColor = true;
            // 
            // ptQueryHistoryClearBtn
            // 
            this.ptQueryHistoryClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ptQueryHistoryClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptQueryHistoryClearBtn.Location = new System.Drawing.Point(602, 258);
            this.ptQueryHistoryClearBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ptQueryHistoryClearBtn.Name = "ptQueryHistoryClearBtn";
            this.ptQueryHistoryClearBtn.Size = new System.Drawing.Size(100, 38);
            this.ptQueryHistoryClearBtn.TabIndex = 21;
            this.ptQueryHistoryClearBtn.Text = "CLEAR";
            this.ptQueryHistoryClearBtn.UseVisualStyleBackColor = true;
            this.ptQueryHistoryClearBtn.Click += new System.EventHandler(this.ptQueryHistoryClearBtn_Click);
            // 
            // ptQueryHistoryTxb
            // 
            this.ptQueryHistoryTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptQueryHistoryTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptQueryHistoryTxb.Location = new System.Drawing.Point(153, 7);
            this.ptQueryHistoryTxb.Margin = new System.Windows.Forms.Padding(4);
            this.ptQueryHistoryTxb.Name = "ptQueryHistoryTxb";
            this.ptQueryHistoryTxb.ReadOnly = true;
            this.ptQueryHistoryTxb.Size = new System.Drawing.Size(549, 243);
            this.ptQueryHistoryTxb.TabIndex = 20;
            this.ptQueryHistoryTxb.Text = "";
            this.ptQueryHistoryTxb.TextChanged += new System.EventHandler(this.richTxb_TextChanged);
            // 
            // ptQueryBtn
            // 
            this.ptQueryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ptQueryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptQueryBtn.Location = new System.Drawing.Point(153, 258);
            this.ptQueryBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ptQueryBtn.Name = "ptQueryBtn";
            this.ptQueryBtn.Size = new System.Drawing.Size(100, 38);
            this.ptQueryBtn.TabIndex = 19;
            this.ptQueryBtn.Text = "QUERY";
            this.ptQueryBtn.UseVisualStyleBackColor = true;
            this.ptQueryBtn.Click += new System.EventHandler(this.ptQueryBtn_Click);
            // 
            // ptQueryDataIDCbx
            // 
            this.ptQueryDataIDCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ptQueryDataIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ptQueryDataIDCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptQueryDataIDCbx.FormattingEnabled = true;
            this.ptQueryDataIDCbx.Location = new System.Drawing.Point(7, 117);
            this.ptQueryDataIDCbx.Margin = new System.Windows.Forms.Padding(4);
            this.ptQueryDataIDCbx.Name = "ptQueryDataIDCbx";
            this.ptQueryDataIDCbx.Size = new System.Drawing.Size(117, 28);
            this.ptQueryDataIDCbx.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(9, 93);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 20);
            this.label16.TabIndex = 17;
            this.label16.Text = "Data ID";
            // 
            // ptQueryAddressEdit
            // 
            this.ptQueryAddressEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptQueryAddressEdit.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ptQueryAddressEdit.Location = new System.Drawing.Point(7, 44);
            this.ptQueryAddressEdit.Margin = new System.Windows.Forms.Padding(4);
            this.ptQueryAddressEdit.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ptQueryAddressEdit.Name = "ptQueryAddressEdit";
            this.ptQueryAddressEdit.Size = new System.Drawing.Size(119, 26);
            this.ptQueryAddressEdit.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(4, 20);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 20);
            this.label15.TabIndex = 5;
            this.label15.Text = "Target address";
            // 
            // rawSendBtn
            // 
            this.rawSendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rawSendBtn.Enabled = false;
            this.rawSendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawSendBtn.Location = new System.Drawing.Point(374, 345);
            this.rawSendBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rawSendBtn.Name = "rawSendBtn";
            this.rawSendBtn.Size = new System.Drawing.Size(88, 28);
            this.rawSendBtn.TabIndex = 3;
            this.rawSendBtn.Text = "SEND";
            this.rawSendBtn.UseVisualStyleBackColor = true;
            this.rawSendBtn.Click += new System.EventHandler(this.rawSendBtn_Click);
            // 
            // rawSendTxb
            // 
            this.rawSendTxb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawSendTxb.ContextMenuStrip = this.rawSendTxbContextMnu;
            this.rawSendTxb.Location = new System.Drawing.Point(4, 348);
            this.rawSendTxb.Margin = new System.Windows.Forms.Padding(4);
            this.rawSendTxb.Name = "rawSendTxb";
            this.rawSendTxb.Size = new System.Drawing.Size(362, 22);
            this.rawSendTxb.TabIndex = 2;
            this.rawSendTxb.TextChanged += new System.EventHandler(this.rawSendTxb_TextChanged);
            // 
            // rawSendTxbContextMnu
            // 
            this.rawSendTxbContextMnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.generateDatetimeStringToolStripMenuItem,
            this.random8byteStringToolStripMenuItem,
            this.random16byteStringToolStripMenuItem,
            this.random32byteStringToolStripMenuItem,
            this.random64byteStringToolStripMenuItem,
            this.random128byteStringToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.rawSendTxbContextMnu.Name = "rawSendTxbContextMnu";
            this.rawSendTxbContextMnu.Size = new System.Drawing.Size(250, 178);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(246, 6);
            // 
            // generateDatetimeStringToolStripMenuItem
            // 
            this.generateDatetimeStringToolStripMenuItem.Name = "generateDatetimeStringToolStripMenuItem";
            this.generateDatetimeStringToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.generateDatetimeStringToolStripMenuItem.Text = "Generate date-time string";
            this.generateDatetimeStringToolStripMenuItem.Click += new System.EventHandler(this.generateDatetimeStringToolStripMenuItem_Click);
            // 
            // random8byteStringToolStripMenuItem
            // 
            this.random8byteStringToolStripMenuItem.Name = "random8byteStringToolStripMenuItem";
            this.random8byteStringToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.random8byteStringToolStripMenuItem.Text = "Random 8-byte string";
            this.random8byteStringToolStripMenuItem.Click += new System.EventHandler(this.random8byteStringToolStripMenuItem_Click);
            // 
            // random16byteStringToolStripMenuItem
            // 
            this.random16byteStringToolStripMenuItem.Name = "random16byteStringToolStripMenuItem";
            this.random16byteStringToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.random16byteStringToolStripMenuItem.Text = "Random 16-byte string";
            this.random16byteStringToolStripMenuItem.Click += new System.EventHandler(this.random16byteStringToolStripMenuItem_Click);
            // 
            // random32byteStringToolStripMenuItem
            // 
            this.random32byteStringToolStripMenuItem.Name = "random32byteStringToolStripMenuItem";
            this.random32byteStringToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.random32byteStringToolStripMenuItem.Text = "Random 32-byte string";
            this.random32byteStringToolStripMenuItem.Click += new System.EventHandler(this.random32byteStringToolStripMenuItem_Click);
            // 
            // random64byteStringToolStripMenuItem
            // 
            this.random64byteStringToolStripMenuItem.Name = "random64byteStringToolStripMenuItem";
            this.random64byteStringToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.random64byteStringToolStripMenuItem.Text = "Random 64-byte string";
            this.random64byteStringToolStripMenuItem.Click += new System.EventHandler(this.random64byteStringToolStripMenuItem_Click);
            // 
            // random128byteStringToolStripMenuItem
            // 
            this.random128byteStringToolStripMenuItem.Name = "random128byteStringToolStripMenuItem";
            this.random128byteStringToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.random128byteStringToolStripMenuItem.Text = "Random 128-byte string";
            this.random128byteStringToolStripMenuItem.Click += new System.EventHandler(this.random128byteStringToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // rawHistoryTxb
            // 
            this.rawHistoryTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawHistoryTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawHistoryTxb.Location = new System.Drawing.Point(8, 39);
            this.rawHistoryTxb.Margin = new System.Windows.Forms.Padding(4);
            this.rawHistoryTxb.Name = "rawHistoryTxb";
            this.rawHistoryTxb.ReadOnly = true;
            this.rawHistoryTxb.Size = new System.Drawing.Size(458, 298);
            this.rawHistoryTxb.TabIndex = 1;
            this.rawHistoryTxb.Text = "";
            this.rawHistoryTxb.TextChanged += new System.EventHandler(this.rawHistoryTxb_TextChanged);
            // 
            // historyTxb
            // 
            this.historyTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyTxb.Location = new System.Drawing.Point(4, 34);
            this.historyTxb.Margin = new System.Windows.Forms.Padding(4);
            this.historyTxb.Name = "historyTxb";
            this.historyTxb.ReadOnly = true;
            this.historyTxb.Size = new System.Drawing.Size(1189, 145);
            this.historyTxb.TabIndex = 1;
            this.historyTxb.Text = "";
            this.historyTxb.TextChanged += new System.EventHandler(this.historyTxb_TextChanged);
            // 
            // btnPanel
            // 
            this.btnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPanel.Controls.Add(this.historyTxb);
            this.btnPanel.Controls.Add(this.historyToolStrip);
            this.btnPanel.Location = new System.Drawing.Point(12, 419);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(1197, 183);
            this.btnPanel.TabIndex = 3;
            // 
            // historyToolStrip
            // 
            this.historyToolStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripSeparator4,
            this.histCopyBtn,
            this.histExportBtn,
            this.histClearBtn});
            this.historyToolStrip.Location = new System.Drawing.Point(0, 0);
            this.historyToolStrip.Name = "historyToolStrip";
            this.historyToolStrip.Size = new System.Drawing.Size(1197, 30);
            this.historyToolStrip.TabIndex = 1;
            this.historyToolStrip.Text = "toolStrip3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(156, 27);
            this.toolStripLabel3.Text = "HISTORY WINDOW";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 30);
            // 
            // histCopyBtn
            // 
            this.histCopyBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.histCopyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.histCopyBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.histCopyBtn.Image = ((System.Drawing.Image)(resources.GetObject("histCopyBtn.Image")));
            this.histCopyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.histCopyBtn.Name = "histCopyBtn";
            this.histCopyBtn.Size = new System.Drawing.Size(58, 27);
            this.histCopyBtn.Text = "COPY";
            this.histCopyBtn.Click += new System.EventHandler(this.histCopyBtn_Click);
            // 
            // histExportBtn
            // 
            this.histExportBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.histExportBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.histExportBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.histExportBtn.Image = ((System.Drawing.Image)(resources.GetObject("histExportBtn.Image")));
            this.histExportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.histExportBtn.Name = "histExportBtn";
            this.histExportBtn.Size = new System.Drawing.Size(78, 27);
            this.histExportBtn.Text = "EXPORT";
            this.histExportBtn.Click += new System.EventHandler(this.histExportBtn_Click);
            // 
            // histClearBtn
            // 
            this.histClearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.histClearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.histClearBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.histClearBtn.Image = ((System.Drawing.Image)(resources.GetObject("histClearBtn.Image")));
            this.histClearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.histClearBtn.Name = "histClearBtn";
            this.histClearBtn.Size = new System.Drawing.Size(66, 27);
            this.histClearBtn.Text = "CLEAR";
            this.histClearBtn.Click += new System.EventHandler(this.histClearBtn_Click);
            // 
            // cmdModePnl
            // 
            this.cmdModePnl.Controls.Add(this.commandTab);
            this.cmdModePnl.Controls.Add(this.commandModeToolStrip);
            this.cmdModePnl.Location = new System.Drawing.Point(12, 33);
            this.cmdModePnl.Name = "cmdModePnl";
            this.cmdModePnl.Size = new System.Drawing.Size(725, 377);
            this.cmdModePnl.TabIndex = 4;
            // 
            // commandModeToolStrip
            // 
            this.commandModeToolStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commandModeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator2});
            this.commandModeToolStrip.Location = new System.Drawing.Point(0, 0);
            this.commandModeToolStrip.Name = "commandModeToolStrip";
            this.commandModeToolStrip.Size = new System.Drawing.Size(725, 26);
            this.commandModeToolStrip.TabIndex = 1;
            this.commandModeToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(154, 23);
            this.toolStripLabel1.Text = "COMMAND MODE";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
            // 
            // rawModePnl
            // 
            this.rawModePnl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawModePnl.Controls.Add(this.rawSendBtn);
            this.rawModePnl.Controls.Add(this.rawModeToolStrip);
            this.rawModePnl.Controls.Add(this.rawSendTxb);
            this.rawModePnl.Controls.Add(this.rawHistoryTxb);
            this.rawModePnl.Location = new System.Drawing.Point(743, 36);
            this.rawModePnl.Name = "rawModePnl";
            this.rawModePnl.Size = new System.Drawing.Size(466, 374);
            this.rawModePnl.TabIndex = 5;
            // 
            // rawModeToolStrip
            // 
            this.rawModeToolStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawModeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripSeparator3,
            this.rawCopyBtn,
            this.rawExportBtn,
            this.rawClearBtn});
            this.rawModeToolStrip.Location = new System.Drawing.Point(0, 0);
            this.rawModeToolStrip.Name = "rawModeToolStrip";
            this.rawModeToolStrip.Size = new System.Drawing.Size(466, 30);
            this.rawModeToolStrip.TabIndex = 1;
            this.rawModeToolStrip.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(146, 27);
            this.toolStripLabel2.Text = "RAW DATA MODE";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 30);
            // 
            // rawCopyBtn
            // 
            this.rawCopyBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rawCopyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rawCopyBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawCopyBtn.Image = ((System.Drawing.Image)(resources.GetObject("rawCopyBtn.Image")));
            this.rawCopyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rawCopyBtn.Name = "rawCopyBtn";
            this.rawCopyBtn.Size = new System.Drawing.Size(58, 27);
            this.rawCopyBtn.Text = "COPY";
            this.rawCopyBtn.Click += new System.EventHandler(this.rawCopyBtn_Click);
            // 
            // rawExportBtn
            // 
            this.rawExportBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rawExportBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rawExportBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawExportBtn.Image = ((System.Drawing.Image)(resources.GetObject("rawExportBtn.Image")));
            this.rawExportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rawExportBtn.Name = "rawExportBtn";
            this.rawExportBtn.Size = new System.Drawing.Size(78, 27);
            this.rawExportBtn.Text = "EXPORT";
            this.rawExportBtn.Click += new System.EventHandler(this.rawExportBtn_Click);
            // 
            // rawClearBtn
            // 
            this.rawClearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rawClearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rawClearBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawClearBtn.Image = ((System.Drawing.Image)(resources.GetObject("rawClearBtn.Image")));
            this.rawClearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rawClearBtn.Name = "rawClearBtn";
            this.rawClearBtn.Size = new System.Drawing.Size(66, 27);
            this.rawClearBtn.Text = "CLEAR";
            this.rawClearBtn.Click += new System.EventHandler(this.rawClearBtn_Click);
            // 
            // stdSetGroup
            // 
            this.stdSetGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stdSetGroup.Controls.Add(this.label10);
            this.stdSetGroup.Controls.Add(this.AMBSetBtn);
            this.stdSetGroup.Controls.Add(this.label9);
            this.stdSetGroup.Controls.Add(this.AMBUpdatePeriodEdit);
            this.stdSetGroup.Controls.Add(this.label8);
            this.stdSetGroup.Controls.Add(this.isAMBSaveSettingsToFlashChb);
            this.stdSetGroup.Controls.Add(this.ambItemsGroup);
            this.stdSetGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.stdSetGroup.Location = new System.Drawing.Point(7, 7);
            this.stdSetGroup.Name = "stdSetGroup";
            this.stdSetGroup.Size = new System.Drawing.Size(431, 289);
            this.stdSetGroup.TabIndex = 18;
            this.stdSetGroup.TabStop = false;
            this.stdSetGroup.Text = "Standard set";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(7, 160);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 20);
            this.label10.TabIndex = 23;
            this.label10.Text = "1 - after any modem output";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(7, 136);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "*0 - never";
            // 
            // AMBUpdatePeriodEdit
            // 
            this.AMBUpdatePeriodEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AMBUpdatePeriodEdit.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.AMBUpdatePeriodEdit.Location = new System.Drawing.Point(7, 94);
            this.AMBUpdatePeriodEdit.Margin = new System.Windows.Forms.Padding(4);
            this.AMBUpdatePeriodEdit.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.AMBUpdatePeriodEdit.Name = "AMBUpdatePeriodEdit";
            this.AMBUpdatePeriodEdit.Size = new System.Drawing.Size(147, 26);
            this.AMBUpdatePeriodEdit.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Update period*, ms";
            // 
            // isAMBSaveSettingsToFlashChb
            // 
            this.isAMBSaveSettingsToFlashChb.AutoSize = true;
            this.isAMBSaveSettingsToFlashChb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isAMBSaveSettingsToFlashChb.Location = new System.Drawing.Point(7, 27);
            this.isAMBSaveSettingsToFlashChb.Margin = new System.Windows.Forms.Padding(4);
            this.isAMBSaveSettingsToFlashChb.Name = "isAMBSaveSettingsToFlashChb";
            this.isAMBSaveSettingsToFlashChb.Size = new System.Drawing.Size(128, 24);
            this.isAMBSaveSettingsToFlashChb.TabIndex = 19;
            this.isAMBSaveSettingsToFlashChb.Text = "Save to flash";
            this.isAMBSaveSettingsToFlashChb.UseVisualStyleBackColor = true;
            // 
            // ambItemsGroup
            // 
            this.ambItemsGroup.Controls.Add(this.isAMBVoltageChb);
            this.ambItemsGroup.Controls.Add(this.isAMBDepthChb);
            this.ambItemsGroup.Controls.Add(this.isAMBTemperatureChb);
            this.ambItemsGroup.Controls.Add(this.isAMBPressureChb);
            this.ambItemsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ambItemsGroup.Location = new System.Drawing.Point(225, 26);
            this.ambItemsGroup.Margin = new System.Windows.Forms.Padding(4);
            this.ambItemsGroup.Name = "ambItemsGroup";
            this.ambItemsGroup.Padding = new System.Windows.Forms.Padding(4);
            this.ambItemsGroup.Size = new System.Drawing.Size(199, 177);
            this.ambItemsGroup.TabIndex = 18;
            this.ambItemsGroup.TabStop = false;
            this.ambItemsGroup.Text = "ITEMS TO UPDATE";
            // 
            // isAMBVoltageChb
            // 
            this.isAMBVoltageChb.AutoSize = true;
            this.isAMBVoltageChb.Location = new System.Drawing.Point(8, 137);
            this.isAMBVoltageChb.Margin = new System.Windows.Forms.Padding(4);
            this.isAMBVoltageChb.Name = "isAMBVoltageChb";
            this.isAMBVoltageChb.Size = new System.Drawing.Size(139, 24);
            this.isAMBVoltageChb.TabIndex = 3;
            this.isAMBVoltageChb.Text = "Supply voltage";
            this.isAMBVoltageChb.UseVisualStyleBackColor = true;
            // 
            // isAMBDepthChb
            // 
            this.isAMBDepthChb.AutoSize = true;
            this.isAMBDepthChb.Location = new System.Drawing.Point(8, 105);
            this.isAMBDepthChb.Margin = new System.Windows.Forms.Padding(4);
            this.isAMBDepthChb.Name = "isAMBDepthChb";
            this.isAMBDepthChb.Size = new System.Drawing.Size(76, 24);
            this.isAMBDepthChb.TabIndex = 2;
            this.isAMBDepthChb.Text = "Depth";
            this.isAMBDepthChb.UseVisualStyleBackColor = true;
            // 
            // isAMBTemperatureChb
            // 
            this.isAMBTemperatureChb.AutoSize = true;
            this.isAMBTemperatureChb.Location = new System.Drawing.Point(8, 73);
            this.isAMBTemperatureChb.Margin = new System.Windows.Forms.Padding(4);
            this.isAMBTemperatureChb.Name = "isAMBTemperatureChb";
            this.isAMBTemperatureChb.Size = new System.Drawing.Size(126, 24);
            this.isAMBTemperatureChb.TabIndex = 1;
            this.isAMBTemperatureChb.Text = "Temperature";
            this.isAMBTemperatureChb.UseVisualStyleBackColor = true;
            // 
            // isAMBPressureChb
            // 
            this.isAMBPressureChb.AutoSize = true;
            this.isAMBPressureChb.Location = new System.Drawing.Point(8, 41);
            this.isAMBPressureChb.Margin = new System.Windows.Forms.Padding(4);
            this.isAMBPressureChb.Name = "isAMBPressureChb";
            this.isAMBPressureChb.Size = new System.Drawing.Size(99, 24);
            this.isAMBPressureChb.TabIndex = 0;
            this.isAMBPressureChb.Text = "Pressure";
            this.isAMBPressureChb.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.ptcRolSetBtn);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.PtcRolUpdatePeriodEdit);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.isPtcRolSaveToFlashChb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(444, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 289);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pitch/Roll";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(7, 159);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(210, 20);
            this.label17.TabIndex = 23;
            this.label17.Text = "1 - after any modem output";
            // 
            // ptcRolSetBtn
            // 
            this.ptcRolSetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ptcRolSetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptcRolSetBtn.Location = new System.Drawing.Point(151, 244);
            this.ptcRolSetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ptcRolSetBtn.Name = "ptcRolSetBtn";
            this.ptcRolSetBtn.Size = new System.Drawing.Size(100, 38);
            this.ptcRolSetBtn.TabIndex = 11;
            this.ptcRolSetBtn.Text = "APPLY";
            this.ptcRolSetBtn.UseVisualStyleBackColor = true;
            this.ptcRolSetBtn.Click += new System.EventHandler(this.ptcRolSetBtn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(7, 135);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 20);
            this.label18.TabIndex = 22;
            this.label18.Text = "*0 - never";
            // 
            // PtcRolUpdatePeriodEdit
            // 
            this.PtcRolUpdatePeriodEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PtcRolUpdatePeriodEdit.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.PtcRolUpdatePeriodEdit.Location = new System.Drawing.Point(7, 95);
            this.PtcRolUpdatePeriodEdit.Margin = new System.Windows.Forms.Padding(4);
            this.PtcRolUpdatePeriodEdit.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.PtcRolUpdatePeriodEdit.Name = "PtcRolUpdatePeriodEdit";
            this.PtcRolUpdatePeriodEdit.Size = new System.Drawing.Size(147, 26);
            this.PtcRolUpdatePeriodEdit.TabIndex = 21;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(7, 69);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 20);
            this.label19.TabIndex = 20;
            this.label19.Text = "Update period*, ms";
            // 
            // isPtcRolSaveToFlashChb
            // 
            this.isPtcRolSaveToFlashChb.AutoSize = true;
            this.isPtcRolSaveToFlashChb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isPtcRolSaveToFlashChb.Location = new System.Drawing.Point(7, 26);
            this.isPtcRolSaveToFlashChb.Margin = new System.Windows.Forms.Padding(4);
            this.isPtcRolSaveToFlashChb.Name = "isPtcRolSaveToFlashChb";
            this.isPtcRolSaveToFlashChb.Size = new System.Drawing.Size(128, 24);
            this.isPtcRolSaveToFlashChb.TabIndex = 19;
            this.isPtcRolSaveToFlashChb.Text = "Save to flash";
            this.isPtcRolSaveToFlashChb.UseVisualStyleBackColor = true;
            // 
            // ptcRolTxb
            // 
            this.ptcRolTxb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptcRolTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ptcRolTxb.Location = new System.Drawing.Point(480, 6);
            this.ptcRolTxb.Margin = new System.Windows.Forms.Padding(4);
            this.ptcRolTxb.Name = "ptcRolTxb";
            this.ptcRolTxb.ReadOnly = true;
            this.ptcRolTxb.Size = new System.Drawing.Size(221, 290);
            this.ptcRolTxb.TabIndex = 1;
            this.ptcRolTxb.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 624);
            this.Controls.Add(this.rawModePnl);
            this.Controls.Add(this.cmdModePnl);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.commandTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gravityAccEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salinityEdit)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.packetModeTab.ResumeLayout(false);
            this.packetModeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptTriesEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptLocalAddressEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptTargetAddressEdit)).EndInit();
            this.ptSendTxbCtx.ResumeLayout(false);
            this.ptHistoryCtx.ResumeLayout(false);
            this.packetRequestsTab.ResumeLayout(false);
            this.packetRequestsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptQueryAddressEdit)).EndInit();
            this.rawSendTxbContextMnu.ResumeLayout(false);
            this.btnPanel.ResumeLayout(false);
            this.btnPanel.PerformLayout();
            this.historyToolStrip.ResumeLayout(false);
            this.historyToolStrip.PerformLayout();
            this.cmdModePnl.ResumeLayout(false);
            this.cmdModePnl.PerformLayout();
            this.commandModeToolStrip.ResumeLayout(false);
            this.commandModeToolStrip.PerformLayout();
            this.rawModePnl.ResumeLayout(false);
            this.rawModePnl.PerformLayout();
            this.rawModeToolStrip.ResumeLayout(false);
            this.rawModeToolStrip.PerformLayout();
            this.stdSetGroup.ResumeLayout(false);
            this.stdSetGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AMBUpdatePeriodEdit)).EndInit();
            this.ambItemsGroup.ResumeLayout(false);
            this.ambItemsGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PtcRolUpdatePeriodEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton connectBtn;
        private System.Windows.Forms.ToolStripButton settingsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton commandModeSwitchBtn;
        private System.Windows.Forms.ToolStripButton infoBtn;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.RichTextBox historyTxb;
        private System.Windows.Forms.TabControl commandTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button rawSendBtn;
        private System.Windows.Forms.TextBox rawSendTxb;
        private System.Windows.Forms.RichTextBox rawHistoryTxb;
        private System.Windows.Forms.RichTextBox deviceInfoTxb;
        private System.Windows.Forms.ComboBox txChIDCbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox rxChIDCbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown salinityEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button devSettingsApplyBtn;
        private System.Windows.Forms.Button devSettingsQueryBtn;
        private System.Windows.Forms.Button AMBSetBtn;
        private System.Windows.Forms.Button rcQueryBtn;
        private System.Windows.Forms.ComboBox rcQueryIdCbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox rcTargetRxChIDCbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox rcTargetTxChIDCbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox isCommandModeByDefaultChb;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ContextMenuStrip rawSendTxbContextMnu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem generateDatetimeStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem random8byteStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem random16byteStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem random32byteStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem random64byteStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem random128byteStringToolStripMenuItem;
        private System.Windows.Forms.RichTextBox ambTxb;
        private System.Windows.Forms.CheckBox isACKOnTXFinishedChb;
        private System.Windows.Forms.NumericUpDown gravityAccEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.ToolStrip historyToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton histCopyBtn;
        private System.Windows.Forms.ToolStripButton histExportBtn;
        private System.Windows.Forms.ToolStripButton histClearBtn;
        private System.Windows.Forms.Panel cmdModePnl;
        private System.Windows.Forms.ToolStrip commandModeToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel rawModePnl;
        private System.Windows.Forms.ToolStrip rawModeToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton rawCopyBtn;
        private System.Windows.Forms.ToolStripButton rawExportBtn;
        private System.Windows.Forms.ToolStripButton rawClearBtn;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.TabPage packetModeTab;
        private System.Windows.Forms.Button ptSendBtn;
        private System.Windows.Forms.TextBox ptToSendTxb;
        private System.Windows.Forms.RichTextBox ptHistoryTxb;
        private System.Windows.Forms.NumericUpDown ptLocalAddressEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown ptTargetAddressEdit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ptApplySettingsBtn;
        private System.Windows.Forms.CheckBox ptIsSaveToFlashChb;
        private System.Windows.Forms.Button ptQuerySettingsBtn;
        private System.Windows.Forms.CheckBox isPtModeChb;
        private System.Windows.Forms.NumericUpDown ptTriesEdit;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ContextMenuStrip ptHistoryCtx;
        private System.Windows.Forms.ToolStripMenuItem ptClearTxbBtn;
        private System.Windows.Forms.ContextMenuStrip ptSendTxbCtx;
        private System.Windows.Forms.ToolStripMenuItem ptSend8ByteStrBtn;
        private System.Windows.Forms.ToolStripMenuItem ptSend16ByteStrBtn;
        private System.Windows.Forms.ToolStripMenuItem ptSend32ByteStrBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem ptSendClearBtn;
        private System.Windows.Forms.CheckBox rcAutoChb;
        private System.Windows.Forms.RichTextBox rcTxb;
        private System.Windows.Forms.Button rcClearStatsBtn;
        private System.Windows.Forms.TabPage packetRequestsTab;
        private System.Windows.Forms.NumericUpDown ptQueryAddressEdit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button ptQueryHistoryClearBtn;
        private System.Windows.Forms.RichTextBox ptQueryHistoryTxb;
        private System.Windows.Forms.Button ptQueryBtn;
        private System.Windows.Forms.ComboBox ptQueryDataIDCbx;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button ptcRolSetBtn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown PtcRolUpdatePeriodEdit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox isPtcRolSaveToFlashChb;
        private System.Windows.Forms.GroupBox stdSetGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown AMBUpdatePeriodEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox isAMBSaveSettingsToFlashChb;
        private System.Windows.Forms.GroupBox ambItemsGroup;
        private System.Windows.Forms.CheckBox isAMBVoltageChb;
        private System.Windows.Forms.CheckBox isAMBDepthChb;
        private System.Windows.Forms.CheckBox isAMBTemperatureChb;
        private System.Windows.Forms.CheckBox isAMBPressureChb;
        private System.Windows.Forms.RichTextBox ptcRolTxb;
    }
}

