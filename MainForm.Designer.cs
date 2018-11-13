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
            this.infoBtn = new System.Windows.Forms.ToolStripButton();
            this.isRawModeOnlyBtn = new System.Windows.Forms.ToolStripButton();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.connectionStateLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.actionLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.rawModePanel = new System.Windows.Forms.Panel();
            this.rawDataSendBtn = new System.Windows.Forms.Button();
            this.rawDataInputTxb = new System.Windows.Forms.TextBox();
            this.rawDataInputContextMnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.generateDatetimeStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomString16BytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomString32BytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomString64BytesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.rawModeHistoryTxb = new System.Windows.Forms.RichTextBox();
            this.rawModeToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.rawHistoryClearBtn = new System.Windows.Forms.ToolStripButton();
            this.rawHistoryExportBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.rawHistoryExportToPlainTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawHistoryCopyToClipboardBtn = new System.Windows.Forms.ToolStripButton();
            this.commandPanel = new System.Windows.Forms.Panel();
            this.commandTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.devInfoGetLbl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.settingsRxIDCbx = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.settingsTxIDCbx = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.settingsApplyLbl = new System.Windows.Forms.LinkLabel();
            this.systemLbl = new System.Windows.Forms.Label();
            this.coreLbl = new System.Windows.Forms.Label();
            this.acBaudrateLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.totalChannelsLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.queryIDCbx = new System.Windows.Forms.ComboBox();
            this.remoteQueryLbl = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.targetRxIDCbx = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.salinityEdit = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.isIPTSLbl = new System.Windows.Forms.Label();
            this.miscSettingsBtn = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.cmdModeCbx = new System.Windows.Forms.ComboBox();
            this.commandToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.historyTxb = new System.Windows.Forms.RichTextBox();
            this.historyToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.historyClearBtn = new System.Windows.Forms.ToolStripButton();
            this.historyExportBtn = new System.Windows.Forms.ToolStripDropDownButton();
            this.historyExportToPlainTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyCopyToClipboardBtn = new System.Windows.Forms.ToolStripButton();
            this.label15 = new System.Windows.Forms.Label();
            this.targetTxIDCbx = new System.Windows.Forms.ComboBox();
            this.mainToolStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.rawModePanel.SuspendLayout();
            this.rawDataInputContextMnu.SuspendLayout();
            this.rawModeToolStrip.SuspendLayout();
            this.commandPanel.SuspendLayout();
            this.commandTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salinityEdit)).BeginInit();
            this.commandToolStrip.SuspendLayout();
            this.historyToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectBtn,
            this.settingsBtn,
            this.toolStripSeparator1,
            this.infoBtn,
            this.isRawModeOnlyBtn});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(905, 27);
            this.mainToolStrip.TabIndex = 0;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // connectBtn
            // 
            this.connectBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.connectBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectBtn.Image = ((System.Drawing.Image)(resources.GetObject("connectBtn.Image")));
            this.connectBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(83, 24);
            this.connectBtn.Text = "CONNECT";
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // settingsBtn
            // 
            this.settingsBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingsBtn.Image")));
            this.settingsBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(83, 24);
            this.settingsBtn.Text = "SETTINGS";
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // infoBtn
            // 
            this.infoBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.infoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.infoBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoBtn.Image = ((System.Drawing.Image)(resources.GetObject("infoBtn.Image")));
            this.infoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(49, 24);
            this.infoBtn.Text = "INFO";
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // isRawModeOnlyBtn
            // 
            this.isRawModeOnlyBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.isRawModeOnlyBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isRawModeOnlyBtn.Image = ((System.Drawing.Image)(resources.GetObject("isRawModeOnlyBtn.Image")));
            this.isRawModeOnlyBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.isRawModeOnlyBtn.Name = "isRawModeOnlyBtn";
            this.isRawModeOnlyBtn.Size = new System.Drawing.Size(97, 24);
            this.isRawModeOnlyBtn.Text = "RAW MODE";
            this.isRawModeOnlyBtn.Click += new System.EventHandler(this.isRawModeOnlyBtn_Click);
            // 
            // mainStatusStrip
            // 
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.connectionStateLbl,
            this.toolStripStatusLabel2,
            this.actionLbl});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 570);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.mainStatusStrip.Size = new System.Drawing.Size(905, 25);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(105, 20);
            this.toolStripStatusLabel1.Text = "CONNECTION:";
            // 
            // connectionStateLbl
            // 
            this.connectionStateLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectionStateLbl.Name = "connectionStateLbl";
            this.connectionStateLbl.Size = new System.Drawing.Size(64, 20);
            this.connectionStateLbl.Text = "CLOSED";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(65, 20);
            this.toolStripStatusLabel2.Text = "ACTION:";
            // 
            // actionLbl
            // 
            this.actionLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actionLbl.Name = "actionLbl";
            this.actionLbl.Size = new System.Drawing.Size(41, 20);
            this.actionLbl.Text = "IDLE";
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 27);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainSplitContainer.Name = "mainSplitContainer";
            this.mainSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.rawModePanel);
            this.mainSplitContainer.Panel1.Controls.Add(this.commandPanel);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.historyTxb);
            this.mainSplitContainer.Panel2.Controls.Add(this.historyToolStrip);
            this.mainSplitContainer.Size = new System.Drawing.Size(905, 543);
            this.mainSplitContainer.SplitterDistance = 413;
            this.mainSplitContainer.TabIndex = 2;
            // 
            // rawModePanel
            // 
            this.rawModePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawModePanel.Controls.Add(this.rawDataSendBtn);
            this.rawModePanel.Controls.Add(this.rawDataInputTxb);
            this.rawModePanel.Controls.Add(this.rawModeHistoryTxb);
            this.rawModePanel.Controls.Add(this.rawModeToolStrip);
            this.rawModePanel.Location = new System.Drawing.Point(363, 2);
            this.rawModePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rawModePanel.Name = "rawModePanel";
            this.rawModePanel.Size = new System.Drawing.Size(539, 408);
            this.rawModePanel.TabIndex = 1;
            // 
            // rawDataSendBtn
            // 
            this.rawDataSendBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rawDataSendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawDataSendBtn.Location = new System.Drawing.Point(461, 381);
            this.rawDataSendBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rawDataSendBtn.Name = "rawDataSendBtn";
            this.rawDataSendBtn.Size = new System.Drawing.Size(75, 25);
            this.rawDataSendBtn.TabIndex = 3;
            this.rawDataSendBtn.Text = "SEND";
            this.rawDataSendBtn.UseVisualStyleBackColor = true;
            this.rawDataSendBtn.Click += new System.EventHandler(this.rawDataSendBtn_Click);
            // 
            // rawDataInputTxb
            // 
            this.rawDataInputTxb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawDataInputTxb.ContextMenuStrip = this.rawDataInputContextMnu;
            this.rawDataInputTxb.Location = new System.Drawing.Point(3, 381);
            this.rawDataInputTxb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rawDataInputTxb.MaxLength = 128;
            this.rawDataInputTxb.Name = "rawDataInputTxb";
            this.rawDataInputTxb.Size = new System.Drawing.Size(451, 22);
            this.rawDataInputTxb.TabIndex = 2;
            this.rawDataInputTxb.TextChanged += new System.EventHandler(this.rawDataInputTxb_TextChanged);
            // 
            // rawDataInputContextMnu
            // 
            this.rawDataInputContextMnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateDatetimeStringToolStripMenuItem,
            this.randomString16BytesToolStripMenuItem,
            this.randomString32BytesToolStripMenuItem,
            this.randomString64BytesToolStripMenuItem,
            this.toolStripSeparator5});
            this.rawDataInputContextMnu.Name = "rawDataInputContextMnu";
            this.rawDataInputContextMnu.Size = new System.Drawing.Size(250, 106);
            // 
            // generateDatetimeStringToolStripMenuItem
            // 
            this.generateDatetimeStringToolStripMenuItem.Name = "generateDatetimeStringToolStripMenuItem";
            this.generateDatetimeStringToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.generateDatetimeStringToolStripMenuItem.Text = "Generate date-time string";
            this.generateDatetimeStringToolStripMenuItem.Click += new System.EventHandler(this.generateDatetimeStringToolStripMenuItem_Click);
            // 
            // randomString16BytesToolStripMenuItem
            // 
            this.randomString16BytesToolStripMenuItem.Name = "randomString16BytesToolStripMenuItem";
            this.randomString16BytesToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.randomString16BytesToolStripMenuItem.Text = "Random string 16 bytes";
            this.randomString16BytesToolStripMenuItem.Click += new System.EventHandler(this.randomString16BytesToolStripMenuItem_Click);
            // 
            // randomString32BytesToolStripMenuItem
            // 
            this.randomString32BytesToolStripMenuItem.Name = "randomString32BytesToolStripMenuItem";
            this.randomString32BytesToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.randomString32BytesToolStripMenuItem.Text = "Random string 32 bytes";
            this.randomString32BytesToolStripMenuItem.Click += new System.EventHandler(this.randomString32BytesToolStripMenuItem_Click);
            // 
            // randomString64BytesToolStripMenuItem
            // 
            this.randomString64BytesToolStripMenuItem.Name = "randomString64BytesToolStripMenuItem";
            this.randomString64BytesToolStripMenuItem.Size = new System.Drawing.Size(249, 24);
            this.randomString64BytesToolStripMenuItem.Text = "Random string 64 bytes";
            this.randomString64BytesToolStripMenuItem.Click += new System.EventHandler(this.randomString64BytesToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(246, 6);
            // 
            // rawModeHistoryTxb
            // 
            this.rawModeHistoryTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rawModeHistoryTxb.Location = new System.Drawing.Point(3, 28);
            this.rawModeHistoryTxb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rawModeHistoryTxb.Name = "rawModeHistoryTxb";
            this.rawModeHistoryTxb.ReadOnly = true;
            this.rawModeHistoryTxb.Size = new System.Drawing.Size(533, 348);
            this.rawModeHistoryTxb.TabIndex = 1;
            this.rawModeHistoryTxb.Text = "";
            this.rawModeHistoryTxb.TextChanged += new System.EventHandler(this.rawModeHistoryTxb_TextChanged);
            // 
            // rawModeToolStrip
            // 
            this.rawModeToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.toolStripSeparator4,
            this.rawHistoryClearBtn,
            this.rawHistoryExportBtn,
            this.rawHistoryCopyToClipboardBtn});
            this.rawModeToolStrip.Location = new System.Drawing.Point(0, 0);
            this.rawModeToolStrip.Name = "rawModeToolStrip";
            this.rawModeToolStrip.Size = new System.Drawing.Size(539, 27);
            this.rawModeToolStrip.TabIndex = 0;
            this.rawModeToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(129, 24);
            this.toolStripLabel3.Text = "RAW DATA MODE";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // rawHistoryClearBtn
            // 
            this.rawHistoryClearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rawHistoryClearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rawHistoryClearBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawHistoryClearBtn.Image = ((System.Drawing.Image)(resources.GetObject("rawHistoryClearBtn.Image")));
            this.rawHistoryClearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rawHistoryClearBtn.Name = "rawHistoryClearBtn";
            this.rawHistoryClearBtn.Size = new System.Drawing.Size(59, 24);
            this.rawHistoryClearBtn.Text = "CLEAR";
            this.rawHistoryClearBtn.Click += new System.EventHandler(this.rawHistoryClearBtn_Click);
            // 
            // rawHistoryExportBtn
            // 
            this.rawHistoryExportBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rawHistoryExportBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rawHistoryExportBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rawHistoryExportToPlainTextToolStripMenuItem});
            this.rawHistoryExportBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawHistoryExportBtn.Image = ((System.Drawing.Image)(resources.GetObject("rawHistoryExportBtn.Image")));
            this.rawHistoryExportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rawHistoryExportBtn.Name = "rawHistoryExportBtn";
            this.rawHistoryExportBtn.Size = new System.Drawing.Size(79, 24);
            this.rawHistoryExportBtn.Text = "EXPORT";
            // 
            // rawHistoryExportToPlainTextToolStripMenuItem
            // 
            this.rawHistoryExportToPlainTextToolStripMenuItem.Name = "rawHistoryExportToPlainTextToolStripMenuItem";
            this.rawHistoryExportToPlainTextToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.rawHistoryExportToPlainTextToolStripMenuItem.Text = "TO PLAIN TEXT...";
            this.rawHistoryExportToPlainTextToolStripMenuItem.Click += new System.EventHandler(this.rawHistoryExportToPlainTextToolStripMenuItem_Click);
            // 
            // rawHistoryCopyToClipboardBtn
            // 
            this.rawHistoryCopyToClipboardBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.rawHistoryCopyToClipboardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rawHistoryCopyToClipboardBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawHistoryCopyToClipboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("rawHistoryCopyToClipboardBtn.Image")));
            this.rawHistoryCopyToClipboardBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rawHistoryCopyToClipboardBtn.Name = "rawHistoryCopyToClipboardBtn";
            this.rawHistoryCopyToClipboardBtn.Size = new System.Drawing.Size(51, 24);
            this.rawHistoryCopyToClipboardBtn.Text = "COPY";
            this.rawHistoryCopyToClipboardBtn.Click += new System.EventHandler(this.rawHistoryCopyToClipboardBtn_Click);
            // 
            // commandPanel
            // 
            this.commandPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.commandPanel.Controls.Add(this.commandTableLayout);
            this.commandPanel.Controls.Add(this.commandToolStrip);
            this.commandPanel.Location = new System.Drawing.Point(3, 2);
            this.commandPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commandPanel.Name = "commandPanel";
            this.commandPanel.Size = new System.Drawing.Size(355, 408);
            this.commandPanel.TabIndex = 0;
            // 
            // commandTableLayout
            // 
            this.commandTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandTableLayout.ColumnCount = 3;
            this.commandTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.commandTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.commandTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.commandTableLayout.Controls.Add(this.label2, 0, 1);
            this.commandTableLayout.Controls.Add(this.label3, 0, 2);
            this.commandTableLayout.Controls.Add(this.label5, 0, 3);
            this.commandTableLayout.Controls.Add(this.devInfoGetLbl, 2, 0);
            this.commandTableLayout.Controls.Add(this.label1, 1, 0);
            this.commandTableLayout.Controls.Add(this.settingsRxIDCbx, 1, 8);
            this.commandTableLayout.Controls.Add(this.label7, 0, 8);
            this.commandTableLayout.Controls.Add(this.label6, 0, 7);
            this.commandTableLayout.Controls.Add(this.settingsTxIDCbx, 1, 7);
            this.commandTableLayout.Controls.Add(this.label9, 1, 6);
            this.commandTableLayout.Controls.Add(this.settingsApplyLbl, 2, 6);
            this.commandTableLayout.Controls.Add(this.systemLbl, 1, 1);
            this.commandTableLayout.Controls.Add(this.coreLbl, 1, 2);
            this.commandTableLayout.Controls.Add(this.acBaudrateLbl, 1, 3);
            this.commandTableLayout.Controls.Add(this.label4, 0, 5);
            this.commandTableLayout.Controls.Add(this.totalChannelsLbl, 1, 5);
            this.commandTableLayout.Controls.Add(this.label11, 0, 13);
            this.commandTableLayout.Controls.Add(this.label10, 0, 12);
            this.commandTableLayout.Controls.Add(this.remoteQueryLbl, 2, 11);
            this.commandTableLayout.Controls.Add(this.label12, 0, 9);
            this.commandTableLayout.Controls.Add(this.targetRxIDCbx, 1, 12);
            this.commandTableLayout.Controls.Add(this.label8, 1, 11);
            this.commandTableLayout.Controls.Add(this.salinityEdit, 1, 9);
            this.commandTableLayout.Controls.Add(this.label13, 0, 4);
            this.commandTableLayout.Controls.Add(this.isIPTSLbl, 1, 4);
            this.commandTableLayout.Controls.Add(this.label14, 0, 10);
            this.commandTableLayout.Controls.Add(this.cmdModeCbx, 1, 10);
            this.commandTableLayout.Controls.Add(this.label15, 0, 14);
            this.commandTableLayout.Controls.Add(this.miscSettingsBtn, 2, 15);
            this.commandTableLayout.Controls.Add(this.queryIDCbx, 1, 14);
            this.commandTableLayout.Controls.Add(this.targetTxIDCbx, 1, 13);
            this.commandTableLayout.Location = new System.Drawing.Point(3, 28);
            this.commandTableLayout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.commandTableLayout.Name = "commandTableLayout";
            this.commandTableLayout.RowCount = 16;
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.commandTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.commandTableLayout.Size = new System.Drawing.Size(348, 376);
            this.commandTableLayout.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Core";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Acoustic baudrate";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // devInfoGetLbl
            // 
            this.devInfoGetLbl.AutoSize = true;
            this.devInfoGetLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devInfoGetLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devInfoGetLbl.Location = new System.Drawing.Point(283, 0);
            this.devInfoGetLbl.Name = "devInfoGetLbl";
            this.devInfoGetLbl.Size = new System.Drawing.Size(103, 17);
            this.devInfoGetLbl.TabIndex = 9;
            this.devInfoGetLbl.TabStop = true;
            this.devInfoGetLbl.Text = "GET";
            this.devInfoGetLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.devInfoGetLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.devInfoGetLbl_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(131, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DEVICE INFO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsRxIDCbx
            // 
            this.settingsRxIDCbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsRxIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsRxIDCbx.FormattingEnabled = true;
            this.settingsRxIDCbx.Location = new System.Drawing.Point(131, 149);
            this.settingsRxIDCbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsRxIDCbx.Name = "settingsRxIDCbx";
            this.settingsRxIDCbx.Size = new System.Drawing.Size(146, 24);
            this.settingsRxIDCbx.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 28);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rx ID";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tx ID";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // settingsTxIDCbx
            // 
            this.settingsTxIDCbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsTxIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.settingsTxIDCbx.FormattingEnabled = true;
            this.settingsTxIDCbx.Location = new System.Drawing.Point(131, 121);
            this.settingsTxIDCbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.settingsTxIDCbx.Name = "settingsTxIDCbx";
            this.settingsTxIDCbx.Size = new System.Drawing.Size(146, 24);
            this.settingsTxIDCbx.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(131, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "SETTINGS";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsApplyLbl
            // 
            this.settingsApplyLbl.AutoSize = true;
            this.settingsApplyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsApplyLbl.Location = new System.Drawing.Point(283, 102);
            this.settingsApplyLbl.Name = "settingsApplyLbl";
            this.settingsApplyLbl.Size = new System.Drawing.Size(57, 17);
            this.settingsApplyLbl.TabIndex = 10;
            this.settingsApplyLbl.TabStop = true;
            this.settingsApplyLbl.Text = "APPLY";
            this.settingsApplyLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settingsApplyLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.settingsApplyLbl_LinkClicked);
            // 
            // systemLbl
            // 
            this.systemLbl.AutoSize = true;
            this.systemLbl.Location = new System.Drawing.Point(131, 17);
            this.systemLbl.Name = "systemLbl";
            this.systemLbl.Size = new System.Drawing.Size(56, 17);
            this.systemLbl.TabIndex = 19;
            this.systemLbl.Text = "no data";
            // 
            // coreLbl
            // 
            this.coreLbl.AutoSize = true;
            this.coreLbl.Location = new System.Drawing.Point(131, 34);
            this.coreLbl.Name = "coreLbl";
            this.coreLbl.Size = new System.Drawing.Size(56, 17);
            this.coreLbl.TabIndex = 20;
            this.coreLbl.Text = "no data";
            // 
            // acBaudrateLbl
            // 
            this.acBaudrateLbl.AutoSize = true;
            this.acBaudrateLbl.Location = new System.Drawing.Point(131, 51);
            this.acBaudrateLbl.Name = "acBaudrateLbl";
            this.acBaudrateLbl.Size = new System.Drawing.Size(56, 17);
            this.acBaudrateLbl.TabIndex = 21;
            this.acBaudrateLbl.Text = "no data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Total channels";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalChannelsLbl
            // 
            this.totalChannelsLbl.AutoSize = true;
            this.totalChannelsLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.totalChannelsLbl.Location = new System.Drawing.Point(131, 85);
            this.totalChannelsLbl.Name = "totalChannelsLbl";
            this.totalChannelsLbl.Size = new System.Drawing.Size(146, 17);
            this.totalChannelsLbl.TabIndex = 23;
            this.totalChannelsLbl.Text = "no data";
            this.totalChannelsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Location = new System.Drawing.Point(3, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 30);
            this.label11.TabIndex = 16;
            this.label11.Text = "Target Tx ID";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(3, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 28);
            this.label10.TabIndex = 15;
            this.label10.Text = "Target Rx ID";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // queryIDCbx
            // 
            this.queryIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queryIDCbx.FormattingEnabled = true;
            this.queryIDCbx.Location = new System.Drawing.Point(131, 310);
            this.queryIDCbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryIDCbx.Name = "queryIDCbx";
            this.queryIDCbx.Size = new System.Drawing.Size(146, 24);
            this.queryIDCbx.TabIndex = 18;
            // 
            // remoteQueryLbl
            // 
            this.remoteQueryLbl.AutoSize = true;
            this.remoteQueryLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remoteQueryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remoteQueryLbl.Location = new System.Drawing.Point(283, 233);
            this.remoteQueryLbl.Name = "remoteQueryLbl";
            this.remoteQueryLbl.Size = new System.Drawing.Size(103, 17);
            this.remoteQueryLbl.TabIndex = 14;
            this.remoteQueryLbl.TabStop = true;
            this.remoteQueryLbl.Text = "QUERY";
            this.remoteQueryLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.remoteQueryLbl_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 28);
            this.label12.TabIndex = 24;
            this.label12.Text = "Salinity, PSU";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // targetRxIDCbx
            // 
            this.targetRxIDCbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetRxIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetRxIDCbx.FormattingEnabled = true;
            this.targetRxIDCbx.Location = new System.Drawing.Point(131, 252);
            this.targetRxIDCbx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.targetRxIDCbx.Name = "targetRxIDCbx";
            this.targetRxIDCbx.Size = new System.Drawing.Size(146, 24);
            this.targetRxIDCbx.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(131, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "QUERY REMOTE";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salinityEdit
            // 
            this.salinityEdit.DecimalPlaces = 1;
            this.salinityEdit.Location = new System.Drawing.Point(131, 178);
            this.salinityEdit.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.salinityEdit.Name = "salinityEdit";
            this.salinityEdit.Size = new System.Drawing.Size(146, 22);
            this.salinityEdit.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Location = new System.Drawing.Point(3, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "IPTS";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isIPTSLbl
            // 
            this.isIPTSLbl.AutoSize = true;
            this.isIPTSLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.isIPTSLbl.Location = new System.Drawing.Point(131, 68);
            this.isIPTSLbl.Name = "isIPTSLbl";
            this.isIPTSLbl.Size = new System.Drawing.Size(146, 17);
            this.isIPTSLbl.TabIndex = 27;
            this.isIPTSLbl.Text = "no data";
            this.isIPTSLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // miscSettingsBtn
            // 
            this.miscSettingsBtn.AutoSize = true;
            this.miscSettingsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.miscSettingsBtn.Location = new System.Drawing.Point(283, 336);
            this.miscSettingsBtn.Name = "miscSettingsBtn";
            this.miscSettingsBtn.Size = new System.Drawing.Size(49, 17);
            this.miscSettingsBtn.TabIndex = 28;
            this.miscSettingsBtn.TabStop = true;
            this.miscSettingsBtn.Text = "MISC.";
            this.miscSettingsBtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.miscSettingsBtn_LinkClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Location = new System.Drawing.Point(3, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 30);
            this.label14.TabIndex = 29;
            this.label14.Text = "Command mode";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdModeCbx
            // 
            this.cmdModeCbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmdModeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdModeCbx.FormattingEnabled = true;
            this.cmdModeCbx.Items.AddRange(new object[] {
            "By pin",
            "By default"});
            this.cmdModeCbx.Location = new System.Drawing.Point(131, 206);
            this.cmdModeCbx.Name = "cmdModeCbx";
            this.cmdModeCbx.Size = new System.Drawing.Size(146, 24);
            this.cmdModeCbx.TabIndex = 30;
            // 
            // commandToolStrip
            // 
            this.commandToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripSeparator3});
            this.commandToolStrip.Location = new System.Drawing.Point(0, 0);
            this.commandToolStrip.Name = "commandToolStrip";
            this.commandToolStrip.Size = new System.Drawing.Size(355, 25);
            this.commandToolStrip.TabIndex = 0;
            this.commandToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(134, 22);
            this.toolStripLabel2.Text = "COMMAND MODE";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // historyTxb
            // 
            this.historyTxb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historyTxb.Location = new System.Drawing.Point(3, 28);
            this.historyTxb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.historyTxb.MaxLength = 65536;
            this.historyTxb.Name = "historyTxb";
            this.historyTxb.ReadOnly = true;
            this.historyTxb.Size = new System.Drawing.Size(899, 101);
            this.historyTxb.TabIndex = 1;
            this.historyTxb.Text = "";
            this.historyTxb.TextChanged += new System.EventHandler(this.historyTxb_TextChanged);
            // 
            // historyToolStrip
            // 
            this.historyToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.historyClearBtn,
            this.historyExportBtn,
            this.historyCopyToClipboardBtn});
            this.historyToolStrip.Location = new System.Drawing.Point(0, 0);
            this.historyToolStrip.Name = "historyToolStrip";
            this.historyToolStrip.Size = new System.Drawing.Size(905, 27);
            this.historyToolStrip.TabIndex = 0;
            this.historyToolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(136, 24);
            this.toolStripLabel1.Text = "HISTORY WINDOW";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // historyClearBtn
            // 
            this.historyClearBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.historyClearBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.historyClearBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyClearBtn.Image = ((System.Drawing.Image)(resources.GetObject("historyClearBtn.Image")));
            this.historyClearBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.historyClearBtn.Name = "historyClearBtn";
            this.historyClearBtn.Size = new System.Drawing.Size(59, 24);
            this.historyClearBtn.Text = "CLEAR";
            this.historyClearBtn.Click += new System.EventHandler(this.historyClearBtn_Click);
            // 
            // historyExportBtn
            // 
            this.historyExportBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.historyExportBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.historyExportBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyExportToPlainTextToolStripMenuItem});
            this.historyExportBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyExportBtn.Image = ((System.Drawing.Image)(resources.GetObject("historyExportBtn.Image")));
            this.historyExportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.historyExportBtn.Name = "historyExportBtn";
            this.historyExportBtn.Size = new System.Drawing.Size(79, 24);
            this.historyExportBtn.Text = "EXPORT";
            // 
            // historyExportToPlainTextToolStripMenuItem
            // 
            this.historyExportToPlainTextToolStripMenuItem.Name = "historyExportToPlainTextToolStripMenuItem";
            this.historyExportToPlainTextToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.historyExportToPlainTextToolStripMenuItem.Text = "TO PLAIN TEXT...";
            this.historyExportToPlainTextToolStripMenuItem.Click += new System.EventHandler(this.toPlainTextToolStripMenuItem_Click);
            // 
            // historyCopyToClipboardBtn
            // 
            this.historyCopyToClipboardBtn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.historyCopyToClipboardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.historyCopyToClipboardBtn.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyCopyToClipboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("historyCopyToClipboardBtn.Image")));
            this.historyCopyToClipboardBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.historyCopyToClipboardBtn.Name = "historyCopyToClipboardBtn";
            this.historyCopyToClipboardBtn.Size = new System.Drawing.Size(51, 24);
            this.historyCopyToClipboardBtn.Text = "COPY";
            this.historyCopyToClipboardBtn.Click += new System.EventHandler(this.historyCopyToClipboardBtn_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(3, 308);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 28);
            this.label15.TabIndex = 31;
            this.label15.Text = "Query ID";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // targetTxIDCbx
            // 
            this.targetTxIDCbx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetTxIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.targetTxIDCbx.FormattingEnabled = true;
            this.targetTxIDCbx.Location = new System.Drawing.Point(131, 281);
            this.targetTxIDCbx.Name = "targetTxIDCbx";
            this.targetTxIDCbx.Size = new System.Drawing.Size(146, 24);
            this.targetTxIDCbx.TabIndex = 32;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 595);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainToolStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "uWAVE Host";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            this.mainSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.rawModePanel.ResumeLayout(false);
            this.rawModePanel.PerformLayout();
            this.rawDataInputContextMnu.ResumeLayout(false);
            this.rawModeToolStrip.ResumeLayout(false);
            this.rawModeToolStrip.PerformLayout();
            this.commandPanel.ResumeLayout(false);
            this.commandPanel.PerformLayout();
            this.commandTableLayout.ResumeLayout(false);
            this.commandTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salinityEdit)).EndInit();
            this.commandToolStrip.ResumeLayout(false);
            this.commandToolStrip.PerformLayout();
            this.historyToolStrip.ResumeLayout(false);
            this.historyToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.ToolStripButton connectBtn;
        private System.Windows.Forms.ToolStripButton settingsBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton infoBtn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel connectionStateLbl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel actionLbl;
        private System.Windows.Forms.RichTextBox historyTxb;
        private System.Windows.Forms.ToolStrip historyToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton historyClearBtn;
        private System.Windows.Forms.ToolStripDropDownButton historyExportBtn;
        private System.Windows.Forms.ToolStripMenuItem historyExportToPlainTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton historyCopyToClipboardBtn;
        private System.Windows.Forms.ToolStripButton isRawModeOnlyBtn;
        private System.Windows.Forms.Panel rawModePanel;
        private System.Windows.Forms.ToolStrip rawModeToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel commandPanel;
        private System.Windows.Forms.ToolStrip commandToolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Button rawDataSendBtn;
        private System.Windows.Forms.TextBox rawDataInputTxb;
        private System.Windows.Forms.RichTextBox rawModeHistoryTxb;
        private System.Windows.Forms.TableLayoutPanel commandTableLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox settingsTxIDCbx;
        private System.Windows.Forms.ComboBox settingsRxIDCbx;
        private System.Windows.Forms.LinkLabel devInfoGetLbl;
        private System.Windows.Forms.LinkLabel settingsApplyLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel remoteQueryLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox targetRxIDCbx;
        private System.Windows.Forms.ComboBox queryIDCbx;
        private System.Windows.Forms.Label systemLbl;
        private System.Windows.Forms.Label coreLbl;
        private System.Windows.Forms.Label acBaudrateLbl;
        private System.Windows.Forms.ToolStripButton rawHistoryClearBtn;
        private System.Windows.Forms.ToolStripDropDownButton rawHistoryExportBtn;
        private System.Windows.Forms.ToolStripButton rawHistoryCopyToClipboardBtn;
        private System.Windows.Forms.ToolStripMenuItem rawHistoryExportToPlainTextToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip rawDataInputContextMnu;
        private System.Windows.Forms.ToolStripMenuItem generateDatetimeStringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomString16BytesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomString32BytesToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label totalChannelsLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown salinityEdit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label isIPTSLbl;
        private System.Windows.Forms.ToolStripMenuItem randomString64BytesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.LinkLabel miscSettingsBtn;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmdModeCbx;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox targetTxIDCbx;
    }
}

