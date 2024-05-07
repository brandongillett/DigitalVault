namespace DigitalVault
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formContainer = new System.Windows.Forms.SplitContainer();
            this.helloLabel = new System.Windows.Forms.Label();
            this.cloudLogo = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.passwordTab = new MetroFramework.Controls.MetroTabPage();
            this.passwordsContainer = new System.Windows.Forms.SplitContainer();
            this.passwordSearchContainer = new System.Windows.Forms.Panel();
            this.passwordSearchInput = new System.Windows.Forms.TextBox();
            this.passwordSearchLogo = new System.Windows.Forms.PictureBox();
            this.passwordSearchLine = new System.Windows.Forms.Panel();
            this.passwordGrid = new System.Windows.Forms.DataGridView();
            this.cardsTab = new MetroFramework.Controls.MetroTabPage();
            this.updateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.updateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.syncTimer = new System.Windows.Forms.Timer(this.components);
            this.passwordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.formContainer)).BeginInit();
            this.formContainer.Panel1.SuspendLayout();
            this.formContainer.Panel2.SuspendLayout();
            this.formContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cloudLogo)).BeginInit();
            this.tabControl.SuspendLayout();
            this.passwordTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsContainer)).BeginInit();
            this.passwordsContainer.Panel1.SuspendLayout();
            this.passwordsContainer.Panel2.SuspendLayout();
            this.passwordsContainer.SuspendLayout();
            this.passwordSearchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordSearchLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // formContainer
            // 
            this.formContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.formContainer.IsSplitterFixed = true;
            this.formContainer.Location = new System.Drawing.Point(0, 0);
            this.formContainer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.formContainer.Name = "formContainer";
            this.formContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // formContainer.Panel1
            // 
            this.formContainer.Panel1.Controls.Add(this.helloLabel);
            this.formContainer.Panel1.Controls.Add(this.cloudLogo);
            this.formContainer.Panel1.Controls.Add(this.titleLabel);
            // 
            // formContainer.Panel2
            // 
            this.formContainer.Panel2.Controls.Add(this.tabControl);
            this.formContainer.Size = new System.Drawing.Size(1570, 848);
            this.formContainer.SplitterDistance = 57;
            this.formContainer.SplitterWidth = 8;
            this.formContainer.TabIndex = 10;
            this.formContainer.TabStop = false;
            // 
            // helloLabel
            // 
            this.helloLabel.BackColor = System.Drawing.Color.Transparent;
            this.helloLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloLabel.Location = new System.Drawing.Point(1242, 0);
            this.helloLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Padding = new System.Windows.Forms.Padding(0, 0, 40, 0);
            this.helloLabel.Size = new System.Drawing.Size(328, 57);
            this.helloLabel.TabIndex = 8;
            this.helloLabel.Text = "Hello, User!";
            this.helloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cloudLogo
            // 
            this.cloudLogo.Image = ((System.Drawing.Image)(resources.GetObject("cloudLogo.Image")));
            this.cloudLogo.Location = new System.Drawing.Point(24, 2);
            this.cloudLogo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cloudLogo.Name = "cloudLogo";
            this.cloudLogo.Size = new System.Drawing.Size(102, 104);
            this.cloudLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloudLogo.TabIndex = 7;
            this.cloudLogo.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(138, 13);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(425, 85);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "DigitalVault";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.passwordTab);
            this.tabControl.Controls.Add(this.cardsTab);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.tabControl.ItemSize = new System.Drawing.Size(84, 31);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1570, 783);
            this.tabControl.Style = MetroFramework.MetroColorStyle.Red;
            this.tabControl.TabIndex = 10;
            // 
            // passwordTab
            // 
            this.passwordTab.BackColor = System.Drawing.Color.White;
            this.passwordTab.Controls.Add(this.passwordsContainer);
            this.passwordTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTab.HorizontalScrollbar = true;
            this.passwordTab.HorizontalScrollbarBarColor = true;
            this.passwordTab.HorizontalScrollbarSize = 19;
            this.passwordTab.Location = new System.Drawing.Point(8, 39);
            this.passwordTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordTab.Name = "passwordTab";
            this.passwordTab.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordTab.Size = new System.Drawing.Size(1554, 736);
            this.passwordTab.TabIndex = 0;
            this.passwordTab.Text = "    Passwords    ";
            this.passwordTab.VerticalScrollbar = true;
            this.passwordTab.VerticalScrollbarBarColor = true;
            this.passwordTab.VerticalScrollbarSize = 20;
            // 
            // passwordsContainer
            // 
            this.passwordsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordsContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.passwordsContainer.IsSplitterFixed = true;
            this.passwordsContainer.Location = new System.Drawing.Point(6, 6);
            this.passwordsContainer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordsContainer.Name = "passwordsContainer";
            this.passwordsContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // passwordsContainer.Panel1
            // 
            this.passwordsContainer.Panel1.Controls.Add(this.passwordSearchContainer);
            // 
            // passwordsContainer.Panel2
            // 
            this.passwordsContainer.Panel2.Controls.Add(this.passwordGrid);
            this.passwordsContainer.Size = new System.Drawing.Size(1542, 724);
            this.passwordsContainer.SplitterDistance = 55;
            this.passwordsContainer.SplitterWidth = 8;
            this.passwordsContainer.TabIndex = 15;
            // 
            // passwordSearchContainer
            // 
            this.passwordSearchContainer.Controls.Add(this.passwordSearchInput);
            this.passwordSearchContainer.Controls.Add(this.passwordSearchLogo);
            this.passwordSearchContainer.Controls.Add(this.passwordSearchLine);
            this.passwordSearchContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.passwordSearchContainer.Location = new System.Drawing.Point(1086, 0);
            this.passwordSearchContainer.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordSearchContainer.Name = "passwordSearchContainer";
            this.passwordSearchContainer.Size = new System.Drawing.Size(456, 55);
            this.passwordSearchContainer.TabIndex = 14;
            // 
            // passwordSearchInput
            // 
            this.passwordSearchInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordSearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordSearchInput.Location = new System.Drawing.Point(120, 35);
            this.passwordSearchInput.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.passwordSearchInput.Name = "passwordSearchInput";
            this.passwordSearchInput.Size = new System.Drawing.Size(330, 44);
            this.passwordSearchInput.TabIndex = 0;
            // 
            // passwordSearchLogo
            // 
            this.passwordSearchLogo.Image = ((System.Drawing.Image)(resources.GetObject("passwordSearchLogo.Image")));
            this.passwordSearchLogo.Location = new System.Drawing.Point(50, 27);
            this.passwordSearchLogo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordSearchLogo.Name = "passwordSearchLogo";
            this.passwordSearchLogo.Size = new System.Drawing.Size(56, 54);
            this.passwordSearchLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordSearchLogo.TabIndex = 3;
            this.passwordSearchLogo.TabStop = false;
            // 
            // passwordSearchLine
            // 
            this.passwordSearchLine.BackColor = System.Drawing.Color.Red;
            this.passwordSearchLine.Location = new System.Drawing.Point(50, 92);
            this.passwordSearchLine.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordSearchLine.Name = "passwordSearchLine";
            this.passwordSearchLine.Size = new System.Drawing.Size(400, 2);
            this.passwordSearchLine.TabIndex = 12;
            // 
            // passwordGrid
            // 
            this.passwordGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.passwordGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.passwordGrid.BackgroundColor = System.Drawing.Color.White;
            this.passwordGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passwordGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.passwordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passwordGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.passwordId,
            this.passwordService,
            this.passwordUsername,
            this.passwordPassword,
            this.passwordNotes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passwordGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.passwordGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordGrid.GridColor = System.Drawing.Color.LightGray;
            this.passwordGrid.Location = new System.Drawing.Point(0, 0);
            this.passwordGrid.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.passwordGrid.Name = "passwordGrid";
            this.passwordGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passwordGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.passwordGrid.RowHeadersWidth = 82;
            this.passwordGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            this.passwordGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.passwordGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.passwordGrid.Size = new System.Drawing.Size(1542, 661);
            this.passwordGrid.TabIndex = 2;
            this.passwordGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.passwordGrid_CellEndEdit);
            this.passwordGrid.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.passwordGrid_UserAddedRow);
            this.passwordGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.passwordGrid_UserDeletingRow);
            // 
            // cardsTab
            // 
            this.cardsTab.HorizontalScrollbarBarColor = true;
            this.cardsTab.HorizontalScrollbarSize = 19;
            this.cardsTab.Location = new System.Drawing.Point(8, 39);
            this.cardsTab.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cardsTab.Name = "cardsTab";
            this.cardsTab.Size = new System.Drawing.Size(1554, 684);
            this.cardsTab.TabIndex = 1;
            this.cardsTab.Text = "    Cards    ";
            this.cardsTab.VerticalScrollbarBarColor = true;
            this.cardsTab.VerticalScrollbarSize = 20;
            // 
            // updateTime
            // 
            this.updateTime.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.updateTime.Name = "updateTime";
            this.updateTime.Size = new System.Drawing.Size(43, 17);
            this.updateTime.Text = "0:00:00";
            // 
            // updateLabel
            // 
            this.updateLabel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(56, 17);
            this.updateLabel.Text = "Last Sync";
            // 
            // syncTimer
            // 
            this.syncTimer.Enabled = true;
            this.syncTimer.Interval = 120000;
            this.syncTimer.Tick += new System.EventHandler(this.syncTimer_Tick);
            // 
            // passwordId
            // 
            this.passwordId.HeaderText = "Id";
            this.passwordId.MinimumWidth = 10;
            this.passwordId.Name = "passwordId";
            this.passwordId.ReadOnly = true;
            this.passwordId.Visible = false;
            // 
            // passwordService
            // 
            this.passwordService.HeaderText = "Service";
            this.passwordService.MinimumWidth = 10;
            this.passwordService.Name = "passwordService";
            // 
            // passwordUsername
            // 
            this.passwordUsername.HeaderText = "Username";
            this.passwordUsername.MinimumWidth = 10;
            this.passwordUsername.Name = "passwordUsername";
            // 
            // passwordPassword
            // 
            this.passwordPassword.HeaderText = "Password";
            this.passwordPassword.MinimumWidth = 10;
            this.passwordPassword.Name = "passwordPassword";
            // 
            // passwordNotes
            // 
            this.passwordNotes.HeaderText = "Notes";
            this.passwordNotes.MinimumWidth = 10;
            this.passwordNotes.Name = "passwordNotes";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1570, 848);
            this.Controls.Add(this.formContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(1576, 858);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DigitalVault";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.formContainer.Panel1.ResumeLayout(false);
            this.formContainer.Panel1.PerformLayout();
            this.formContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formContainer)).EndInit();
            this.formContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cloudLogo)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.passwordTab.ResumeLayout(false);
            this.passwordsContainer.Panel1.ResumeLayout(false);
            this.passwordsContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passwordsContainer)).EndInit();
            this.passwordsContainer.ResumeLayout(false);
            this.passwordSearchContainer.ResumeLayout(false);
            this.passwordSearchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordSearchLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer formContainer;
        private System.Windows.Forms.PictureBox cloudLogo;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label helloLabel;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage passwordTab;
        private System.Windows.Forms.DataGridView passwordGrid;
        private MetroFramework.Controls.MetroTabPage cardsTab;
        private System.Windows.Forms.PictureBox passwordSearchLogo;
        private System.Windows.Forms.Panel passwordSearchLine;
        private System.Windows.Forms.TextBox passwordSearchInput;
        private System.Windows.Forms.Panel passwordSearchContainer;
        private System.Windows.Forms.SplitContainer passwordsContainer;
        private System.Windows.Forms.ToolStripStatusLabel updateTime;
        private System.Windows.Forms.ToolStripStatusLabel updateLabel;
        private System.Windows.Forms.Timer syncTimer;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordId;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordService;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordNotes;
    }
}