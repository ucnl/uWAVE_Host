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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.commandRawSplit = new System.Windows.Forms.SplitContainer();
            this.commandTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.AMBSetBtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.rcQueryBtn = new System.Windows.Forms.Button();
            this.rcQueryIdCbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rcTargetRxChIDCbx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rcTargetTxChIDCbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ambTxb = new System.Windows.Forms.RichTextBox();
            this.commandModeToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.rawHistoryTxb = new System.Windows.Forms.RichTextBox();
            this.rawModeToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rawCopyBtn = new System.Windows.Forms.ToolStripButton();
            this.rawExportBtn = new System.Windows.Forms.ToolStripButton();
            this.rawClearBtn = new System.Windows.Forms.ToolStripButton();
            this.historyTxb = new System.Windows.Forms.RichTextBox();
            this.historyToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.histCopyBtn = new System.Windows.Forms.ToolStripButton();
            this.histExportBtn = new System.Windows.Forms.ToolStripButton();
            this.histClearBtn = new System.Windows.Forms.ToolStripButton();
            this.isACKOnTXFinishedChb = new System.Windows.Forms.CheckBox();
            this.mainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandRawSplit)).BeginInit();
            this.commandRawSplit.Panel1.SuspendLayout();
            this.commandRawSplit.Panel2.SuspendLayout();
            this.commandRawSplit.SuspendLayout();
            this.commandTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salinityEdit)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AMBUpdatePeriodEdit)).BeginInit();
            this.ambItemsGroup.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.commandModeToolStrip.SuspendLayout();
            this.rawSendTxbContextMnu.SuspendLayout();
            this.rawModeToolStrip.SuspendLayout();
            this.historyToolStrip.SuspendLayout();
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
            this.mainToolStrip.Size = new System.Drawing.Size(835, 25);
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
            this.connectBtn.Size = new System.Drawing.Size(73, 22);
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
            this.settingsBtn.Size = new System.Drawing.Size(72, 22);
            this.settingsBtn.Text = "SETTINGS";
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // commandModeSwitchBtn
            // 
            this.commandModeSwitchBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.commandModeSwitchBtn.Enabled = false;
            this.commandModeSwitchBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commandModeSwitchBtn.Image = ((System.Drawing.Image)(resources.GetObject("commandModeSwitchBtn.Image")));
            this.commandModeSwitchBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.commandModeSwitchBtn.Name = "commandModeSwitchBtn";
            this.commandModeSwitchBtn.Size = new System.Drawing.Size(126, 22);
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
            this.infoBtn.Size = new System.Drawing.Size(43, 22);
            this.infoBtn.Text = "INFO";
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 485);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(835, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.commandRawSplit);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.historyTxb);
            this.splitContainer1.Panel2.Controls.Add(this.historyToolStrip);
            this.splitContainer1.Size = new System.Drawing.Size(835, 460);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 2;
            // 
            // commandRawSplit
            // 
            this.commandRawSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandRawSplit.Location = new System.Drawing.Point(0, 0);
            this.commandRawSplit.Name = "commandRawSplit";
            // 
            // commandRawSplit.Panel1
            // 
            this.commandRawSplit.Panel1.Controls.Add(this.commandTab);
            this.commandRawSplit.Panel1.Controls.Add(this.commandModeToolStrip);
            // 
            // commandRawSplit.Panel2
            // 
            this.commandRawSplit.Panel2.Controls.Add(this.rawSendBtn);
            this.commandRawSplit.Panel2.Controls.Add(this.rawSendTxb);
            this.commandRawSplit.Panel2.Controls.Add(this.rawHistoryTxb);
            this.commandRawSplit.Panel2.Controls.Add(this.rawModeToolStrip);
            this.commandRawSplit.Size = new System.Drawing.Size(835, 307);
            this.commandRawSplit.SplitterDistance = 493;
            this.commandRawSplit.TabIndex = 0;
            // 
            // commandTab
            // 
            this.commandTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandTab.Controls.Add(this.tabPage1);
            this.commandTab.Controls.Add(this.tabPage3);
            this.commandTab.Controls.Add(this.tabPage4);
            this.commandTab.Controls.Add(this.tabPage2);
            this.commandTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commandTab.Location = new System.Drawing.Point(3, 28);
            this.commandTab.Name = "commandTab";
            this.commandTab.SelectedIndex = 0;
            this.commandTab.Size = new System.Drawing.Size(487, 276);
            this.commandTab.TabIndex = 1;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(479, 248);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DEVICE INFO";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // isCommandModeByDefaultChb
            // 
            this.isCommandModeByDefaultChb.AutoSize = true;
            this.isCommandModeByDefaultChb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isCommandModeByDefaultChb.Location = new System.Drawing.Point(127, 186);
            this.isCommandModeByDefaultChb.Name = "isCommandModeByDefaultChb";
            this.isCommandModeByDefaultChb.Size = new System.Drawing.Size(188, 20);
            this.isCommandModeByDefaultChb.TabIndex = 12;
            this.isCommandModeByDefaultChb.Text = "Command mode by default";
            this.isCommandModeByDefaultChb.UseVisualStyleBackColor = true;
            // 
            // devSettingsApplyBtn
            // 
            this.devSettingsApplyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.devSettingsApplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devSettingsApplyBtn.Location = new System.Drawing.Point(398, 211);
            this.devSettingsApplyBtn.Name = "devSettingsApplyBtn";
            this.devSettingsApplyBtn.Size = new System.Drawing.Size(75, 31);
            this.devSettingsApplyBtn.TabIndex = 11;
            this.devSettingsApplyBtn.Text = "APPLY";
            this.devSettingsApplyBtn.UseVisualStyleBackColor = true;
            this.devSettingsApplyBtn.Click += new System.EventHandler(this.devSettingsApplyBtn_Click);
            // 
            // devSettingsQueryBtn
            // 
            this.devSettingsQueryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.devSettingsQueryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devSettingsQueryBtn.Location = new System.Drawing.Point(398, 171);
            this.devSettingsQueryBtn.Name = "devSettingsQueryBtn";
            this.devSettingsQueryBtn.Size = new System.Drawing.Size(75, 31);
            this.devSettingsQueryBtn.TabIndex = 10;
            this.devSettingsQueryBtn.Text = "QUERY";
            this.devSettingsQueryBtn.UseVisualStyleBackColor = true;
            this.devSettingsQueryBtn.Click += new System.EventHandler(this.devSettingsQueryBtn_Click);
            // 
            // salinityEdit
            // 
            this.salinityEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.salinityEdit.DecimalPlaces = 1;
            this.salinityEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salinityEdit.Location = new System.Drawing.Point(127, 154);
            this.salinityEdit.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.salinityEdit.Name = "salinityEdit";
            this.salinityEdit.Size = new System.Drawing.Size(107, 22);
            this.salinityEdit.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(126, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Salinity, PSU";
            // 
            // rxChIDCbx
            // 
            this.rxChIDCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rxChIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rxChIDCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rxChIDCbx.FormattingEnabled = true;
            this.rxChIDCbx.Location = new System.Drawing.Point(6, 205);
            this.rxChIDCbx.Name = "rxChIDCbx";
            this.rxChIDCbx.Size = new System.Drawing.Size(90, 24);
            this.rxChIDCbx.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rx channel ID";
            // 
            // txChIDCbx
            // 
            this.txChIDCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txChIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txChIDCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txChIDCbx.FormattingEnabled = true;
            this.txChIDCbx.Location = new System.Drawing.Point(6, 154);
            this.txChIDCbx.Name = "txChIDCbx";
            this.txChIDCbx.Size = new System.Drawing.Size(89, 24);
            this.txChIDCbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tx channel ID";
            // 
            // deviceInfoTxb
            // 
            this.deviceInfoTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceInfoTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deviceInfoTxb.Location = new System.Drawing.Point(6, 6);
            this.deviceInfoTxb.Name = "deviceInfoTxb";
            this.deviceInfoTxb.ReadOnly = true;
            this.deviceInfoTxb.Size = new System.Drawing.Size(467, 118);
            this.deviceInfoTxb.TabIndex = 0;
            this.deviceInfoTxb.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.AMBUpdatePeriodEdit);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.isAMBSaveSettingsToFlashChb);
            this.tabPage3.Controls.Add(this.ambItemsGroup);
            this.tabPage3.Controls.Add(this.AMBSetBtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(479, 248);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "AMBIENT DATA SETTINGS";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(223, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "1 - after any modem output";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(223, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 16);
            this.label9.TabIndex = 16;
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
            this.AMBUpdatePeriodEdit.Location = new System.Drawing.Point(226, 38);
            this.AMBUpdatePeriodEdit.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.AMBUpdatePeriodEdit.Name = "AMBUpdatePeriodEdit";
            this.AMBUpdatePeriodEdit.Size = new System.Drawing.Size(120, 22);
            this.AMBUpdatePeriodEdit.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(223, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Update period*, ms";
            // 
            // isAMBSaveSettingsToFlashChb
            // 
            this.isAMBSaveSettingsToFlashChb.AutoSize = true;
            this.isAMBSaveSettingsToFlashChb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isAMBSaveSettingsToFlashChb.Location = new System.Drawing.Point(12, 16);
            this.isAMBSaveSettingsToFlashChb.Name = "isAMBSaveSettingsToFlashChb";
            this.isAMBSaveSettingsToFlashChb.Size = new System.Drawing.Size(153, 20);
            this.isAMBSaveSettingsToFlashChb.TabIndex = 13;
            this.isAMBSaveSettingsToFlashChb.Text = "Save settings to flash";
            this.isAMBSaveSettingsToFlashChb.UseVisualStyleBackColor = true;
            // 
            // ambItemsGroup
            // 
            this.ambItemsGroup.Controls.Add(this.isAMBVoltageChb);
            this.ambItemsGroup.Controls.Add(this.isAMBDepthChb);
            this.ambItemsGroup.Controls.Add(this.isAMBTemperatureChb);
            this.ambItemsGroup.Controls.Add(this.isAMBPressureChb);
            this.ambItemsGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ambItemsGroup.Location = new System.Drawing.Point(6, 51);
            this.ambItemsGroup.Name = "ambItemsGroup";
            this.ambItemsGroup.Size = new System.Drawing.Size(183, 144);
            this.ambItemsGroup.TabIndex = 12;
            this.ambItemsGroup.TabStop = false;
            this.ambItemsGroup.Text = "ITEMS TO UPDATE";
            // 
            // isAMBVoltageChb
            // 
            this.isAMBVoltageChb.AutoSize = true;
            this.isAMBVoltageChb.Location = new System.Drawing.Point(6, 111);
            this.isAMBVoltageChb.Name = "isAMBVoltageChb";
            this.isAMBVoltageChb.Size = new System.Drawing.Size(117, 20);
            this.isAMBVoltageChb.TabIndex = 3;
            this.isAMBVoltageChb.Text = "Supply voltage";
            this.isAMBVoltageChb.UseVisualStyleBackColor = true;
            // 
            // isAMBDepthChb
            // 
            this.isAMBDepthChb.AutoSize = true;
            this.isAMBDepthChb.Location = new System.Drawing.Point(6, 85);
            this.isAMBDepthChb.Name = "isAMBDepthChb";
            this.isAMBDepthChb.Size = new System.Drawing.Size(63, 20);
            this.isAMBDepthChb.TabIndex = 2;
            this.isAMBDepthChb.Text = "Depth";
            this.isAMBDepthChb.UseVisualStyleBackColor = true;
            // 
            // isAMBTemperatureChb
            // 
            this.isAMBTemperatureChb.AutoSize = true;
            this.isAMBTemperatureChb.Location = new System.Drawing.Point(6, 59);
            this.isAMBTemperatureChb.Name = "isAMBTemperatureChb";
            this.isAMBTemperatureChb.Size = new System.Drawing.Size(105, 20);
            this.isAMBTemperatureChb.TabIndex = 1;
            this.isAMBTemperatureChb.Text = "Temperature";
            this.isAMBTemperatureChb.UseVisualStyleBackColor = true;
            // 
            // isAMBPressureChb
            // 
            this.isAMBPressureChb.AutoSize = true;
            this.isAMBPressureChb.Location = new System.Drawing.Point(6, 33);
            this.isAMBPressureChb.Name = "isAMBPressureChb";
            this.isAMBPressureChb.Size = new System.Drawing.Size(81, 20);
            this.isAMBPressureChb.TabIndex = 0;
            this.isAMBPressureChb.Text = "Pressure";
            this.isAMBPressureChb.UseVisualStyleBackColor = true;
            // 
            // AMBSetBtn
            // 
            this.AMBSetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AMBSetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AMBSetBtn.Location = new System.Drawing.Point(398, 211);
            this.AMBSetBtn.Name = "AMBSetBtn";
            this.AMBSetBtn.Size = new System.Drawing.Size(75, 31);
            this.AMBSetBtn.TabIndex = 11;
            this.AMBSetBtn.Text = "APPLY";
            this.AMBSetBtn.UseVisualStyleBackColor = true;
            this.AMBSetBtn.Click += new System.EventHandler(this.AMBSetBtn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.rcQueryBtn);
            this.tabPage4.Controls.Add(this.rcQueryIdCbx);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.rcTargetRxChIDCbx);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.rcTargetTxChIDCbx);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(479, 248);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "REMOTE QUERY";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // rcQueryBtn
            // 
            this.rcQueryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rcQueryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rcQueryBtn.Location = new System.Drawing.Point(398, 211);
            this.rcQueryBtn.Name = "rcQueryBtn";
            this.rcQueryBtn.Size = new System.Drawing.Size(75, 31);
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
            this.rcQueryIdCbx.Location = new System.Drawing.Point(9, 155);
            this.rcQueryIdCbx.Name = "rcQueryIdCbx";
            this.rcQueryIdCbx.Size = new System.Drawing.Size(89, 24);
            this.rcQueryIdCbx.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(9, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Query ID";
            // 
            // rcTargetRxChIDCbx
            // 
            this.rcTargetRxChIDCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rcTargetRxChIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rcTargetRxChIDCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rcTargetRxChIDCbx.FormattingEnabled = true;
            this.rcTargetRxChIDCbx.Location = new System.Drawing.Point(9, 95);
            this.rcTargetRxChIDCbx.Name = "rcTargetRxChIDCbx";
            this.rcTargetRxChIDCbx.Size = new System.Drawing.Size(89, 24);
            this.rcTargetRxChIDCbx.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(9, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Target Rx channel ID";
            // 
            // rcTargetTxChIDCbx
            // 
            this.rcTargetTxChIDCbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rcTargetTxChIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rcTargetTxChIDCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rcTargetTxChIDCbx.FormattingEnabled = true;
            this.rcTargetTxChIDCbx.Location = new System.Drawing.Point(9, 36);
            this.rcTargetTxChIDCbx.Name = "rcTargetTxChIDCbx";
            this.rcTargetTxChIDCbx.Size = new System.Drawing.Size(89, 24);
            this.rcTargetTxChIDCbx.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Target Tx channel ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ambTxb);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(479, 248);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "AMBIENT DATA";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ambTxb
            // 
            this.ambTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ambTxb.Location = new System.Drawing.Point(6, 6);
            this.ambTxb.Name = "ambTxb";
            this.ambTxb.ReadOnly = true;
            this.ambTxb.Size = new System.Drawing.Size(467, 236);
            this.ambTxb.TabIndex = 0;
            this.ambTxb.Text = "";
            // 
            // commandModeToolStrip
            // 
            this.commandModeToolStrip.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commandModeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator2});
            this.commandModeToolStrip.Location = new System.Drawing.Point(0, 0);
            this.commandModeToolStrip.Name = "commandModeToolStrip";
            this.commandModeToolStrip.Size = new System.Drawing.Size(493, 25);
            this.commandModeToolStrip.TabIndex = 0;
            this.commandModeToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(119, 22);
            this.toolStripLabel1.Text = "COMMAND MODE";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // rawSendBtn
            // 
            this.rawSendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rawSendBtn.Enabled = false;
            this.rawSendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawSendBtn.Location = new System.Drawing.Point(260, 278);
            this.rawSendBtn.Name = "rawSendBtn";
            this.rawSendBtn.Size = new System.Drawing.Size(66, 23);
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
            this.rawSendTxb.Location = new System.Drawing.Point(11, 280);
            this.rawSendTxb.Name = "rawSendTxb";
            this.rawSendTxb.Size = new System.Drawing.Size(243, 20);
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
            this.random128byteStringToolStripMenuItem});
            this.rawSendTxbContextMnu.Name = "rawSendTxbContextMnu";
            this.rawSendTxbContextMnu.Size = new System.Drawing.Size(210, 142);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(206, 6);
            // 
            // generateDatetimeStringToolStripMenuItem
            // 
            this.generateDatetimeStringToolStripMenuItem.Name = "generateDatetimeStringToolStripMenuItem";
            this.generateDatetimeStringToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.generateDatetimeStringToolStripMenuItem.Text = "Generate date-time string";
            this.generateDatetimeStringToolStripMenuItem.Click += new System.EventHandler(this.generateDatetimeStringToolStripMenuItem_Click);
            // 
            // random8byteStringToolStripMenuItem
            // 
            this.random8byteStringToolStripMenuItem.Name = "random8byteStringToolStripMenuItem";
            this.random8byteStringToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.random8byteStringToolStripMenuItem.Text = "Random 8-byte string";
            this.random8byteStringToolStripMenuItem.Click += new System.EventHandler(this.random8byteStringToolStripMenuItem_Click);
            // 
            // random16byteStringToolStripMenuItem
            // 
            this.random16byteStringToolStripMenuItem.Name = "random16byteStringToolStripMenuItem";
            this.random16byteStringToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.random16byteStringToolStripMenuItem.Text = "Random 16-byte string";
            this.random16byteStringToolStripMenuItem.Click += new System.EventHandler(this.random16byteStringToolStripMenuItem_Click);
            // 
            // random32byteStringToolStripMenuItem
            // 
            this.random32byteStringToolStripMenuItem.Name = "random32byteStringToolStripMenuItem";
            this.random32byteStringToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.random32byteStringToolStripMenuItem.Text = "Random 32-byte string";
            this.random32byteStringToolStripMenuItem.Click += new System.EventHandler(this.random32byteStringToolStripMenuItem_Click);
            // 
            // random64byteStringToolStripMenuItem
            // 
            this.random64byteStringToolStripMenuItem.Name = "random64byteStringToolStripMenuItem";
            this.random64byteStringToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.random64byteStringToolStripMenuItem.Text = "Random 64-byte string";
            this.random64byteStringToolStripMenuItem.Click += new System.EventHandler(this.random64byteStringToolStripMenuItem_Click);
            // 
            // random128byteStringToolStripMenuItem
            // 
            this.random128byteStringToolStripMenuItem.Name = "random128byteStringToolStripMenuItem";
            this.random128byteStringToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.random128byteStringToolStripMenuItem.Text = "Random 128-byte string";
            this.random128byteStringToolStripMenuItem.Click += new System.EventHandler(this.random128byteStringToolStripMenuItem_Click);
            // 
            // rawHistoryTxb
            // 
            this.rawHistoryTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawHistoryTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawHistoryTxb.Location = new System.Drawing.Point(11, 28);
            this.rawHistoryTxb.Name = "rawHistoryTxb";
            this.rawHistoryTxb.ReadOnly = true;
            this.rawHistoryTxb.Size = new System.Drawing.Size(315, 244);
            this.rawHistoryTxb.TabIndex = 1;
            this.rawHistoryTxb.Text = "";
            this.rawHistoryTxb.TextChanged += new System.EventHandler(this.rawHistoryTxb_TextChanged);
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
            this.rawModeToolStrip.Size = new System.Drawing.Size(338, 25);
            this.rawModeToolStrip.TabIndex = 0;
            this.rawModeToolStrip.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(111, 22);
            this.toolStripLabel2.Text = "RAW DATA MODE";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // rawCopyBtn
            // 
            this.rawCopyBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rawCopyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rawCopyBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawCopyBtn.Image = ((System.Drawing.Image)(resources.GetObject("rawCopyBtn.Image")));
            this.rawCopyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rawCopyBtn.Name = "rawCopyBtn";
            this.rawCopyBtn.Size = new System.Drawing.Size(46, 22);
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
            this.rawExportBtn.Size = new System.Drawing.Size(62, 22);
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
            this.rawClearBtn.Size = new System.Drawing.Size(51, 22);
            this.rawClearBtn.Text = "CLEAR";
            this.rawClearBtn.Click += new System.EventHandler(this.rawClearBtn_Click);
            // 
            // historyTxb
            // 
            this.historyTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyTxb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyTxb.Location = new System.Drawing.Point(3, 28);
            this.historyTxb.Name = "historyTxb";
            this.historyTxb.ReadOnly = true;
            this.historyTxb.Size = new System.Drawing.Size(829, 118);
            this.historyTxb.TabIndex = 1;
            this.historyTxb.Text = "";
            this.historyTxb.TextChanged += new System.EventHandler(this.historyTxb_TextChanged);
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
            this.historyToolStrip.Size = new System.Drawing.Size(835, 25);
            this.historyToolStrip.TabIndex = 0;
            this.historyToolStrip.Text = "toolStrip3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(118, 22);
            this.toolStripLabel3.Text = "HISTORY WINDOW";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // histCopyBtn
            // 
            this.histCopyBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.histCopyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.histCopyBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.histCopyBtn.Image = ((System.Drawing.Image)(resources.GetObject("histCopyBtn.Image")));
            this.histCopyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.histCopyBtn.Name = "histCopyBtn";
            this.histCopyBtn.Size = new System.Drawing.Size(46, 22);
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
            this.histExportBtn.Size = new System.Drawing.Size(62, 22);
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
            this.histClearBtn.Size = new System.Drawing.Size(51, 22);
            this.histClearBtn.Text = "CLEAR";
            this.histClearBtn.Click += new System.EventHandler(this.histClearBtn_Click);
            // 
            // isACKOnTXFinishedChb
            // 
            this.isACKOnTXFinishedChb.AutoSize = true;
            this.isACKOnTXFinishedChb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isACKOnTXFinishedChb.Location = new System.Drawing.Point(127, 212);
            this.isACKOnTXFinishedChb.Name = "isACKOnTXFinishedChb";
            this.isACKOnTXFinishedChb.Size = new System.Drawing.Size(140, 20);
            this.isACKOnTXFinishedChb.TabIndex = 13;
            this.isACKOnTXFinishedChb.Text = "ACK on TX finished";
            this.isACKOnTXFinishedChb.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 507);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.commandRawSplit.Panel1.ResumeLayout(false);
            this.commandRawSplit.Panel1.PerformLayout();
            this.commandRawSplit.Panel2.ResumeLayout(false);
            this.commandRawSplit.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.commandRawSplit)).EndInit();
            this.commandRawSplit.ResumeLayout(false);
            this.commandTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salinityEdit)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AMBUpdatePeriodEdit)).EndInit();
            this.ambItemsGroup.ResumeLayout(false);
            this.ambItemsGroup.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.commandModeToolStrip.ResumeLayout(false);
            this.commandModeToolStrip.PerformLayout();
            this.rawSendTxbContextMnu.ResumeLayout(false);
            this.rawModeToolStrip.ResumeLayout(false);
            this.rawModeToolStrip.PerformLayout();
            this.historyToolStrip.ResumeLayout(false);
            this.historyToolStrip.PerformLayout();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer commandRawSplit;
        private System.Windows.Forms.ToolStrip commandModeToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip rawModeToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStrip historyToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton histClearBtn;
        private System.Windows.Forms.ToolStripButton histExportBtn;
        private System.Windows.Forms.ToolStripButton histCopyBtn;
        private System.Windows.Forms.ToolStripButton rawCopyBtn;
        private System.Windows.Forms.ToolStripButton rawExportBtn;
        private System.Windows.Forms.ToolStripButton rawClearBtn;
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
        private System.Windows.Forms.CheckBox isAMBSaveSettingsToFlashChb;
        private System.Windows.Forms.GroupBox ambItemsGroup;
        private System.Windows.Forms.CheckBox isAMBVoltageChb;
        private System.Windows.Forms.CheckBox isAMBDepthChb;
        private System.Windows.Forms.CheckBox isAMBTemperatureChb;
        private System.Windows.Forms.CheckBox isAMBPressureChb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown AMBUpdatePeriodEdit;
        private System.Windows.Forms.Label label8;
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
    }
}

