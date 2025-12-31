namespace WRMapOverlay;

partial class Form1
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
        label2 = new Label();
        panel1 = new Panel();
        tableLayoutPanel1 = new TableLayoutPanel();
        BrowseSaveButton = new Button();
        GameSavePathTextBox = new ComboBox();
        label3 = new Label();
        label1 = new Label();
        GameExecutablePathTextBox = new TextBox();
        BrowseGameButton = new Button();
        OverlaySettingsPanel = new TableLayoutPanel();
        RemoveOverlayButton = new Button();
        SetOverlayButton = new Button();
        OverlayBox = new PictureBox();
        label5 = new Label();
        label4 = new Label();
        TerrainDepthWarning = new TableLayoutPanel();
        pictureBox1 = new PictureBox();
        label6 = new Label();
        panel1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        OverlaySettingsPanel.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)OverlayBox).BeginInit();
        TerrainDepthWarning.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Dock = DockStyle.Fill;
        label2.Font = new Font("Segoe UI", 14F);
        label2.Location = new Point(8, 8);
        label2.Name = "label2";
        label2.Size = new Size(193, 32);
        label2.TabIndex = 3;
        label2.Text = "WR Map Overlay";
        // 
        // panel1
        // 
        panel1.AutoSize = true;
        panel1.BackColor = SystemColors.ControlLight;
        panel1.Controls.Add(label2);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Padding = new Padding(8);
        panel1.Size = new Size(482, 48);
        panel1.TabIndex = 4;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.AutoSize = true;
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
        tableLayoutPanel1.Controls.Add(BrowseSaveButton, 2, 1);
        tableLayoutPanel1.Controls.Add(GameSavePathTextBox, 1, 1);
        tableLayoutPanel1.Controls.Add(label3, 0, 1);
        tableLayoutPanel1.Controls.Add(label1, 0, 0);
        tableLayoutPanel1.Controls.Add(GameExecutablePathTextBox, 1, 0);
        tableLayoutPanel1.Controls.Add(BrowseGameButton, 2, 0);
        tableLayoutPanel1.Dock = DockStyle.Top;
        tableLayoutPanel1.Location = new Point(0, 92);
        tableLayoutPanel1.Margin = new Padding(0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.Padding = new Padding(8, 4, 8, 4);
        tableLayoutPanel1.RowCount = 2;
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle());
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new Size(482, 78);
        tableLayoutPanel1.TabIndex = 5;
        // 
        // BrowseSaveButton
        // 
        BrowseSaveButton.Location = new Point(377, 42);
        BrowseSaveButton.Name = "BrowseSaveButton";
        BrowseSaveButton.Size = new Size(94, 29);
        BrowseSaveButton.TabIndex = 2;
        BrowseSaveButton.Text = "Browse...";
        BrowseSaveButton.UseVisualStyleBackColor = true;
        BrowseSaveButton.Click += BrowseSaveButton_Click;
        // 
        // GameSavePathTextBox
        // 
        GameSavePathTextBox.DisplayMember = "Name";
        GameSavePathTextBox.Dock = DockStyle.Fill;
        GameSavePathTextBox.DropDownStyle = ComboBoxStyle.DropDownList;
        GameSavePathTextBox.FormattingEnabled = true;
        GameSavePathTextBox.Location = new Point(131, 42);
        GameSavePathTextBox.Name = "GameSavePathTextBox";
        GameSavePathTextBox.Size = new Size(240, 28);
        GameSavePathTextBox.TabIndex = 1;
        GameSavePathTextBox.ValueMember = "Path";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Dock = DockStyle.Left;
        label3.Location = new Point(11, 39);
        label3.Name = "label3";
        label3.Size = new Size(43, 35);
        label3.TabIndex = 0;
        label3.Text = "Save:";
        label3.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Dock = DockStyle.Left;
        label1.Location = new Point(11, 4);
        label1.Name = "label1";
        label1.Size = new Size(109, 35);
        label1.TabIndex = 0;
        label1.Text = "Game location:";
        label1.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // GameExecutablePathTextBox
        // 
        GameExecutablePathTextBox.Dock = DockStyle.Top;
        GameExecutablePathTextBox.Location = new Point(131, 7);
        GameExecutablePathTextBox.Name = "GameExecutablePathTextBox";
        GameExecutablePathTextBox.Size = new Size(240, 27);
        GameExecutablePathTextBox.TabIndex = 1;
        // 
        // BrowseGameButton
        // 
        BrowseGameButton.Location = new Point(377, 7);
        BrowseGameButton.Name = "BrowseGameButton";
        BrowseGameButton.Size = new Size(94, 29);
        BrowseGameButton.TabIndex = 2;
        BrowseGameButton.Text = "Browse...";
        BrowseGameButton.UseVisualStyleBackColor = true;
        BrowseGameButton.Click += BrowseGameLocation_Click;
        // 
        // OverlaySettingsPanel
        // 
        OverlaySettingsPanel.AutoSize = true;
        OverlaySettingsPanel.ColumnCount = 2;
        OverlaySettingsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 300F));
        OverlaySettingsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        OverlaySettingsPanel.Controls.Add(RemoveOverlayButton, 1, 1);
        OverlaySettingsPanel.Controls.Add(SetOverlayButton, 1, 0);
        OverlaySettingsPanel.Controls.Add(OverlayBox, 0, 0);
        OverlaySettingsPanel.Dock = DockStyle.Top;
        OverlaySettingsPanel.Enabled = false;
        OverlaySettingsPanel.Location = new Point(0, 242);
        OverlaySettingsPanel.Name = "OverlaySettingsPanel";
        OverlaySettingsPanel.Padding = new Padding(8, 4, 8, 8);
        OverlaySettingsPanel.RowCount = 2;
        OverlaySettingsPanel.RowStyles.Add(new RowStyle());
        OverlaySettingsPanel.RowStyles.Add(new RowStyle());
        OverlaySettingsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        OverlaySettingsPanel.Size = new Size(482, 318);
        OverlaySettingsPanel.TabIndex = 6;
        // 
        // RemoveOverlayButton
        // 
        RemoveOverlayButton.Dock = DockStyle.Top;
        RemoveOverlayButton.Location = new Point(311, 42);
        RemoveOverlayButton.Name = "RemoveOverlayButton";
        RemoveOverlayButton.Size = new Size(160, 29);
        RemoveOverlayButton.TabIndex = 2;
        RemoveOverlayButton.Text = "Remove overlay";
        RemoveOverlayButton.UseVisualStyleBackColor = true;
        RemoveOverlayButton.Click += RemoveOverlayButton_Click;
        // 
        // SetOverlayButton
        // 
        SetOverlayButton.Dock = DockStyle.Fill;
        SetOverlayButton.Location = new Point(311, 7);
        SetOverlayButton.Name = "SetOverlayButton";
        SetOverlayButton.Size = new Size(160, 29);
        SetOverlayButton.TabIndex = 1;
        SetOverlayButton.Text = "Set overlay";
        SetOverlayButton.UseVisualStyleBackColor = true;
        SetOverlayButton.Click += SetOverlayButton_Click;
        // 
        // OverlayBox
        // 
        OverlayBox.BorderStyle = BorderStyle.FixedSingle;
        OverlayBox.Location = new Point(11, 7);
        OverlayBox.Name = "OverlayBox";
        OverlaySettingsPanel.SetRowSpan(OverlayBox, 2);
        OverlayBox.Size = new Size(294, 300);
        OverlayBox.SizeMode = PictureBoxSizeMode.StretchImage;
        OverlayBox.TabIndex = 3;
        OverlayBox.TabStop = false;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Dock = DockStyle.Top;
        label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label5.Location = new Point(0, 206);
        label5.Name = "label5";
        label5.Padding = new Padding(8);
        label5.Size = new Size(142, 36);
        label5.TabIndex = 7;
        label5.Text = "Overlay settings:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Dock = DockStyle.Top;
        label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        label4.Location = new Point(0, 48);
        label4.Name = "label4";
        label4.Padding = new Padding(8, 16, 8, 8);
        label4.Size = new Size(143, 44);
        label4.TabIndex = 8;
        label4.Text = "General settings:";
        // 
        // TerrainDepthWarning
        // 
        TerrainDepthWarning.AutoSize = true;
        TerrainDepthWarning.ColumnCount = 2;
        TerrainDepthWarning.ColumnStyles.Add(new ColumnStyle());
        TerrainDepthWarning.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        TerrainDepthWarning.Controls.Add(pictureBox1, 0, 0);
        TerrainDepthWarning.Controls.Add(label6, 1, 0);
        TerrainDepthWarning.Dock = DockStyle.Top;
        TerrainDepthWarning.Location = new Point(0, 170);
        TerrainDepthWarning.Name = "TerrainDepthWarning";
        TerrainDepthWarning.Padding = new Padding(8, 4, 8, 4);
        TerrainDepthWarning.RowCount = 1;
        TerrainDepthWarning.RowStyles.Add(new RowStyle());
        TerrainDepthWarning.Size = new Size(482, 36);
        TerrainDepthWarning.TabIndex = 9;
        TerrainDepthWarning.Visible = false;
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.warning;
        pictureBox1.Location = new Point(16, 8);
        pictureBox1.Margin = new Padding(8, 4, 4, 4);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(20, 20);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Dock = DockStyle.Left;
        label6.Location = new Point(43, 4);
        label6.Name = "label6";
        label6.Size = new Size(399, 28);
        label6.TabIndex = 1;
        label6.Text = "Set terrain depth to \"normal\" (lowest) in the game settings.";
        label6.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSize = true;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        ClientSize = new Size(482, 621);
        Controls.Add(OverlaySettingsPanel);
        Controls.Add(label5);
        Controls.Add(TerrainDepthWarning);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(label4);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimumSize = new Size(500, 0);
        Name = "Form1";
        ShowIcon = false;
        SizeGripStyle = SizeGripStyle.Hide;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "WR Map Overlay";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        OverlaySettingsPanel.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)OverlayBox).EndInit();
        TerrainDepthWarning.ResumeLayout(false);
        TerrainDepthWarning.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label label2;
    private Panel panel1;
    private TableLayoutPanel tableLayoutPanel1;
    private Label label1;
    private TextBox GameExecutablePathTextBox;
    private Button BrowseGameButton;
    private TableLayoutPanel OverlaySettingsPanel;
    private Label label3;
    private ComboBox GameSavePathTextBox;
    private Button BrowseSaveButton;
    private Label label5;
    private Button SetOverlayButton;
    private Button RemoveOverlayButton;
    private PictureBox OverlayBox;
    private Label label4;
    private TableLayoutPanel TerrainDepthWarning;
    private PictureBox pictureBox1;
    private Label label6;
}
