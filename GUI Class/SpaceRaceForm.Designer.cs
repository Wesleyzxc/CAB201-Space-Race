namespace GUI_Class
{
    partial class SpaceRaceForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.playersDataGridView = new System.Windows.Forms.DataGridView();
            this.playerTokenImageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rocketFuelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.singleStepgroupbox = new System.Windows.Forms.GroupBox();
            this.noRadiobutton = new System.Windows.Forms.RadioButton();
            this.yesRadiobutton = new System.Windows.Forms.RadioButton();
            this.resetButton = new System.Windows.Forms.Button();
            this.diceButton = new System.Windows.Forms.Button();
            this.numPlayersinput = new System.Windows.Forms.ComboBox();
            this.playersLabel = new System.Windows.Forms.Label();
            this.numberOfplayerslabel = new System.Windows.Forms.Label();
            this.spaceRacelabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).BeginInit();
            this.singleStepgroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.playersDataGridView);
            this.splitContainer1.Panel2.Controls.Add(this.singleStepgroupbox);
            this.splitContainer1.Panel2.Controls.Add(this.resetButton);
            this.splitContainer1.Panel2.Controls.Add(this.diceButton);
            this.splitContainer1.Panel2.Controls.Add(this.numPlayersinput);
            this.splitContainer1.Panel2.Controls.Add(this.playersLabel);
            this.splitContainer1.Panel2.Controls.Add(this.numberOfplayerslabel);
            this.splitContainer1.Panel2.Controls.Add(this.spaceRacelabel);
            this.splitContainer1.Panel2.Controls.Add(this.exitButton);
            this.splitContainer1.Size = new System.Drawing.Size(884, 661);
            this.splitContainer1.SplitterDistance = 664;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.AutoSize = true;
            this.tableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel.ColumnCount = 8;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(664, 661);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // playersDataGridView
            // 
            this.playersDataGridView.AllowUserToAddRows = false;
            this.playersDataGridView.AllowUserToDeleteRows = false;
            this.playersDataGridView.AutoGenerateColumns = false;
            this.playersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playerTokenImageDataGridViewImageColumn,
            this.nameDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.rocketFuelDataGridViewTextBoxColumn});
            this.playersDataGridView.DataSource = this.playerBindingSource;
            this.playersDataGridView.Location = new System.Drawing.Point(17, 124);
            this.playersDataGridView.Name = "playersDataGridView";
            this.playersDataGridView.RowHeadersVisible = false;
            this.playersDataGridView.Size = new System.Drawing.Size(187, 174);
            this.playersDataGridView.TabIndex = 9;
            // 
            // playerTokenImageDataGridViewImageColumn
            // 
            this.playerTokenImageDataGridViewImageColumn.DataPropertyName = "PlayerTokenImage";
            this.playerTokenImageDataGridViewImageColumn.HeaderText = "";
            this.playerTokenImageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.playerTokenImageDataGridViewImageColumn.Name = "playerTokenImageDataGridViewImageColumn";
            this.playerTokenImageDataGridViewImageColumn.ReadOnly = true;
            this.playerTokenImageDataGridViewImageColumn.Width = 20;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Square";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            this.positionDataGridViewTextBoxColumn.ReadOnly = true;
            this.positionDataGridViewTextBoxColumn.Width = 50;
            // 
            // rocketFuelDataGridViewTextBoxColumn
            // 
            this.rocketFuelDataGridViewTextBoxColumn.DataPropertyName = "RocketFuel";
            this.rocketFuelDataGridViewTextBoxColumn.HeaderText = "Fuel";
            this.rocketFuelDataGridViewTextBoxColumn.Name = "rocketFuelDataGridViewTextBoxColumn";
            this.rocketFuelDataGridViewTextBoxColumn.ReadOnly = true;
            this.rocketFuelDataGridViewTextBoxColumn.Width = 50;
            // 
            // playerBindingSource
            // 
            this.playerBindingSource.DataSource = typeof(Object_Classes.Player);
            // 
            // singleStepgroupbox
            // 
            this.singleStepgroupbox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.singleStepgroupbox.Controls.Add(this.noRadiobutton);
            this.singleStepgroupbox.Controls.Add(this.yesRadiobutton);
            this.singleStepgroupbox.ForeColor = System.Drawing.Color.Black;
            this.singleStepgroupbox.Location = new System.Drawing.Point(40, 322);
            this.singleStepgroupbox.Name = "singleStepgroupbox";
            this.singleStepgroupbox.Size = new System.Drawing.Size(140, 55);
            this.singleStepgroupbox.TabIndex = 8;
            this.singleStepgroupbox.TabStop = false;
            this.singleStepgroupbox.Text = "Single Step?";
            // 
            // noRadiobutton
            // 
            this.noRadiobutton.AutoSize = true;
            this.noRadiobutton.Location = new System.Drawing.Point(71, 26);
            this.noRadiobutton.Name = "noRadiobutton";
            this.noRadiobutton.Size = new System.Drawing.Size(39, 17);
            this.noRadiobutton.TabIndex = 1;
            this.noRadiobutton.TabStop = true;
            this.noRadiobutton.Text = "No";
            this.noRadiobutton.UseVisualStyleBackColor = true;
            this.noRadiobutton.Click += new System.EventHandler(this.noRadiobutton_Click);
            // 
            // yesRadiobutton
            // 
            this.yesRadiobutton.AutoSize = true;
            this.yesRadiobutton.Location = new System.Drawing.Point(21, 26);
            this.yesRadiobutton.Name = "yesRadiobutton";
            this.yesRadiobutton.Size = new System.Drawing.Size(43, 17);
            this.yesRadiobutton.TabIndex = 0;
            this.yesRadiobutton.TabStop = true;
            this.yesRadiobutton.Text = "Yes";
            this.yesRadiobutton.UseVisualStyleBackColor = true;
            this.yesRadiobutton.Click += new System.EventHandler(this.yesRadiobutton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Location = new System.Drawing.Point(17, 626);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Game Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // diceButton
            // 
            this.diceButton.Enabled = false;
            this.diceButton.Location = new System.Drawing.Point(63, 584);
            this.diceButton.Name = "diceButton";
            this.diceButton.Size = new System.Drawing.Size(75, 23);
            this.diceButton.TabIndex = 5;
            this.diceButton.Text = "Roll Dice";
            this.diceButton.UseVisualStyleBackColor = true;
            this.diceButton.Click += new System.EventHandler(this.diceButton_Click);
            // 
            // numPlayersinput
            // 
            this.numPlayersinput.FormattingEnabled = true;
            this.numPlayersinput.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.numPlayersinput.Location = new System.Drawing.Point(148, 39);
            this.numPlayersinput.Name = "numPlayersinput";
            this.numPlayersinput.Size = new System.Drawing.Size(35, 21);
            this.numPlayersinput.TabIndex = 4;
            this.numPlayersinput.Text = "6";
            this.numPlayersinput.SelectedIndexChanged += new System.EventHandler(this.numPlayersinput_SelectedIndexChanged);
            // 
            // playersLabel
            // 
            this.playersLabel.AutoSize = true;
            this.playersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersLabel.Location = new System.Drawing.Point(60, 77);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(91, 25);
            this.playersLabel.TabIndex = 3;
            this.playersLabel.Text = "Players";
            // 
            // numberOfplayerslabel
            // 
            this.numberOfplayerslabel.AutoSize = true;
            this.numberOfplayerslabel.Location = new System.Drawing.Point(48, 43);
            this.numberOfplayerslabel.Name = "numberOfplayerslabel";
            this.numberOfplayerslabel.Size = new System.Drawing.Size(92, 13);
            this.numberOfplayerslabel.TabIndex = 2;
            this.numberOfplayerslabel.Text = "Number of players";
            // 
            // spaceRacelabel
            // 
            this.spaceRacelabel.AutoSize = true;
            this.spaceRacelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spaceRacelabel.Location = new System.Drawing.Point(35, 9);
            this.spaceRacelabel.Name = "spaceRacelabel";
            this.spaceRacelabel.Size = new System.Drawing.Size(139, 25);
            this.spaceRacelabel.TabIndex = 1;
            this.spaceRacelabel.Text = "Space Race";
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(119, 626);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SpaceRaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SpaceRaceForm";
            this.Text = "Space Race";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerBindingSource)).EndInit();
            this.singleStepgroupbox.ResumeLayout(false);
            this.singleStepgroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label playersLabel;
        private System.Windows.Forms.Label numberOfplayerslabel;
        private System.Windows.Forms.Label spaceRacelabel;
        private System.Windows.Forms.GroupBox singleStepgroupbox;
        private System.Windows.Forms.RadioButton noRadiobutton;
        private System.Windows.Forms.RadioButton yesRadiobutton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button diceButton;
        private System.Windows.Forms.ComboBox numPlayersinput;
        private System.Windows.Forms.DataGridView playersDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn playerTokenImageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rocketFuelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource playerBindingSource;
    }
}

