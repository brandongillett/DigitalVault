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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.passwordId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardsTab = new MetroFramework.Controls.MetroTabPage();
            this.updateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.updateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.syncTimer = new System.Windows.Forms.Timer(this.components);
            this.statusMenu = new System.Windows.Forms.StatusStrip();
            this.syncTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lastSyncLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.cardsContainer = new System.Windows.Forms.SplitContainer();
            this.cardSearchContainer = new System.Windows.Forms.Panel();
            this.cardSearchInput = new System.Windows.Forms.TextBox();
            this.cardSearchLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cardGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoLogout = new System.Windows.Forms.Timer(this.components);
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
            this.cardsTab.SuspendLayout();
            this.statusMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardsContainer)).BeginInit();
            this.cardsContainer.Panel1.SuspendLayout();
            this.cardsContainer.Panel2.SuspendLayout();
            this.cardsContainer.SuspendLayout();
            this.cardSearchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardSearchLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // formContainer
            // 
            this.formContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.formContainer.IsSplitterFixed = true;
            this.formContainer.Location = new System.Drawing.Point(0, 0);
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
            this.formContainer.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.formContainer.Size = new System.Drawing.Size(779, 463);
            this.formContainer.SplitterDistance = 57;
            this.formContainer.TabIndex = 10;
            this.formContainer.TabStop = false;
            // 
            // helloLabel
            // 
            this.helloLabel.BackColor = System.Drawing.Color.Transparent;
            this.helloLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.helloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helloLabel.Location = new System.Drawing.Point(615, 0);
            this.helloLabel.Name = "helloLabel";
            this.helloLabel.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.helloLabel.Size = new System.Drawing.Size(164, 57);
            this.helloLabel.TabIndex = 8;
            this.helloLabel.Text = "Hello, User!";
            this.helloLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cloudLogo
            // 
            this.cloudLogo.Image = ((System.Drawing.Image)(resources.GetObject("cloudLogo.Image")));
            this.cloudLogo.Location = new System.Drawing.Point(12, 1);
            this.cloudLogo.Name = "cloudLogo";
            this.cloudLogo.Size = new System.Drawing.Size(51, 54);
            this.cloudLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloudLogo.TabIndex = 7;
            this.cloudLogo.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(69, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(218, 42);
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
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(779, 382);
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
            this.passwordTab.Location = new System.Drawing.Point(4, 35);
            this.passwordTab.Name = "passwordTab";
            this.passwordTab.Padding = new System.Windows.Forms.Padding(3);
            this.passwordTab.Size = new System.Drawing.Size(771, 343);
            this.passwordTab.TabIndex = 0;
            this.passwordTab.Text = "    Passwords    ";
            this.passwordTab.VerticalScrollbar = true;
            this.passwordTab.VerticalScrollbarBarColor = true;
            // 
            // passwordsContainer
            // 
            this.passwordsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordsContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.passwordsContainer.IsSplitterFixed = true;
            this.passwordsContainer.Location = new System.Drawing.Point(3, 3);
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
            this.passwordsContainer.Size = new System.Drawing.Size(765, 337);
            this.passwordsContainer.SplitterDistance = 55;
            this.passwordsContainer.TabIndex = 15;
            // 
            // passwordSearchContainer
            // 
            this.passwordSearchContainer.Controls.Add(this.passwordSearchInput);
            this.passwordSearchContainer.Controls.Add(this.passwordSearchLogo);
            this.passwordSearchContainer.Controls.Add(this.passwordSearchLine);
            this.passwordSearchContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.passwordSearchContainer.Location = new System.Drawing.Point(537, 0);
            this.passwordSearchContainer.Name = "passwordSearchContainer";
            this.passwordSearchContainer.Size = new System.Drawing.Size(228, 55);
            this.passwordSearchContainer.TabIndex = 14;
            // 
            // passwordSearchInput
            // 
            this.passwordSearchInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordSearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordSearchInput.Location = new System.Drawing.Point(60, 18);
            this.passwordSearchInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordSearchInput.Name = "passwordSearchInput";
            this.passwordSearchInput.Size = new System.Drawing.Size(165, 22);
            this.passwordSearchInput.TabIndex = 0;
            this.passwordSearchInput.TextChanged += new System.EventHandler(this.passwordSearchInput_TextChanged);
            // 
            // passwordSearchLogo
            // 
            this.passwordSearchLogo.Image = ((System.Drawing.Image)(resources.GetObject("passwordSearchLogo.Image")));
            this.passwordSearchLogo.Location = new System.Drawing.Point(25, 14);
            this.passwordSearchLogo.Name = "passwordSearchLogo";
            this.passwordSearchLogo.Size = new System.Drawing.Size(28, 28);
            this.passwordSearchLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.passwordSearchLogo.TabIndex = 3;
            this.passwordSearchLogo.TabStop = false;
            // 
            // passwordSearchLine
            // 
            this.passwordSearchLine.BackColor = System.Drawing.Color.Red;
            this.passwordSearchLine.Location = new System.Drawing.Point(25, 48);
            this.passwordSearchLine.Name = "passwordSearchLine";
            this.passwordSearchLine.Size = new System.Drawing.Size(200, 1);
            this.passwordSearchLine.TabIndex = 12;
            // 
            // passwordGrid
            // 
            this.passwordGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.passwordGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.passwordGrid.BackgroundColor = System.Drawing.Color.White;
            this.passwordGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passwordGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.passwordGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.passwordGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.passwordId,
            this.passwordService,
            this.passwordUsername,
            this.passwordPassword,
            this.passwordNotes});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.passwordGrid.DefaultCellStyle = dataGridViewCellStyle18;
            this.passwordGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordGrid.GridColor = System.Drawing.Color.LightGray;
            this.passwordGrid.Location = new System.Drawing.Point(0, 0);
            this.passwordGrid.Name = "passwordGrid";
            this.passwordGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.passwordGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.passwordGrid.RowHeadersWidth = 82;
            this.passwordGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.Padding = new System.Windows.Forms.Padding(5);
            this.passwordGrid.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.passwordGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.passwordGrid.Size = new System.Drawing.Size(765, 278);
            this.passwordGrid.TabIndex = 2;
            this.passwordGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.passwordGrid_CellEndEdit);
            this.passwordGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.passwordGrid_UserDeletingRow);
            // 
            // passwordId
            // 
            this.passwordId.HeaderText = "Id";
            this.passwordId.MinimumWidth = 10;
            this.passwordId.Name = "passwordId";
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
            // cardsTab
            // 
            this.cardsTab.Controls.Add(this.cardsContainer);
            this.cardsTab.HorizontalScrollbarBarColor = true;
            this.cardsTab.Location = new System.Drawing.Point(4, 35);
            this.cardsTab.Name = "cardsTab";
            this.cardsTab.Padding = new System.Windows.Forms.Padding(3);
            this.cardsTab.Size = new System.Drawing.Size(771, 343);
            this.cardsTab.TabIndex = 1;
            this.cardsTab.Text = "    Cards    ";
            this.cardsTab.VerticalScrollbarBarColor = true;
            // 
            // updateTime
            // 
            this.updateTime.Name = "updateTime";
            this.updateTime.Size = new System.Drawing.Size(43, 17);
            this.updateTime.Text = "0:00:00";
            // 
            // updateLabel
            // 
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(56, 17);
            this.updateLabel.Text = "Last Sync";
            // 
            // syncTimer
            // 
            this.syncTimer.Enabled = true;
            this.syncTimer.Interval = 10000;
            this.syncTimer.Tick += new System.EventHandler(this.syncTimer_Tick);
            // 
            // statusMenu
            // 
            this.statusMenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.syncTimeLabel,
            this.lastSyncLabel});
            this.statusMenu.Location = new System.Drawing.Point(0, 441);
            this.statusMenu.Name = "statusMenu";
            this.statusMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusMenu.Size = new System.Drawing.Size(779, 22);
            this.statusMenu.TabIndex = 3;
            // 
            // syncTimeLabel
            // 
            this.syncTimeLabel.Name = "syncTimeLabel";
            this.syncTimeLabel.Size = new System.Drawing.Size(50, 17);
            this.syncTimeLabel.Text = "0:00:00";
            // 
            // lastSyncLabel
            // 
            this.lastSyncLabel.Name = "lastSyncLabel";
            this.lastSyncLabel.Size = new System.Drawing.Size(68, 17);
            this.lastSyncLabel.Text = "Last Sync";
            // 
            // cardsContainer
            // 
            this.cardsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardsContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.cardsContainer.IsSplitterFixed = true;
            this.cardsContainer.Location = new System.Drawing.Point(3, 3);
            this.cardsContainer.Name = "cardsContainer";
            this.cardsContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // cardsContainer.Panel1
            // 
            this.cardsContainer.Panel1.BackColor = System.Drawing.Color.White;
            this.cardsContainer.Panel1.Controls.Add(this.cardSearchContainer);
            // 
            // cardsContainer.Panel2
            // 
            this.cardsContainer.Panel2.Controls.Add(this.cardGrid);
            this.cardsContainer.Size = new System.Drawing.Size(765, 337);
            this.cardsContainer.SplitterDistance = 55;
            this.cardsContainer.TabIndex = 16;
            // 
            // cardSearchContainer
            // 
            this.cardSearchContainer.Controls.Add(this.cardSearchInput);
            this.cardSearchContainer.Controls.Add(this.cardSearchLogo);
            this.cardSearchContainer.Controls.Add(this.panel2);
            this.cardSearchContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.cardSearchContainer.Location = new System.Drawing.Point(537, 0);
            this.cardSearchContainer.Name = "cardSearchContainer";
            this.cardSearchContainer.Size = new System.Drawing.Size(228, 55);
            this.cardSearchContainer.TabIndex = 14;
            // 
            // cardSearchInput
            // 
            this.cardSearchInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cardSearchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardSearchInput.Location = new System.Drawing.Point(60, 18);
            this.cardSearchInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardSearchInput.Name = "cardSearchInput";
            this.cardSearchInput.Size = new System.Drawing.Size(165, 22);
            this.cardSearchInput.TabIndex = 0;
            this.cardSearchInput.TextChanged += new System.EventHandler(this.cardSearchInput_TextChanged);
            // 
            // cardSearchLogo
            // 
            this.cardSearchLogo.Image = ((System.Drawing.Image)(resources.GetObject("cardSearchLogo.Image")));
            this.cardSearchLogo.Location = new System.Drawing.Point(25, 14);
            this.cardSearchLogo.Name = "cardSearchLogo";
            this.cardSearchLogo.Size = new System.Drawing.Size(28, 28);
            this.cardSearchLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cardSearchLogo.TabIndex = 3;
            this.cardSearchLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(25, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 12;
            // 
            // cardGrid
            // 
            this.cardGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cardGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.cardGrid.BackgroundColor = System.Drawing.Color.White;
            this.cardGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cardGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.cardGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.cardGrid.DefaultCellStyle = dataGridViewCellStyle22;
            this.cardGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGrid.GridColor = System.Drawing.Color.LightGray;
            this.cardGrid.Location = new System.Drawing.Point(0, 0);
            this.cardGrid.Name = "cardGrid";
            this.cardGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cardGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.cardGrid.RowHeadersWidth = 82;
            this.cardGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.Padding = new System.Windows.Forms.Padding(5);
            this.cardGrid.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.cardGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cardGrid.Size = new System.Drawing.Size(765, 278);
            this.cardGrid.TabIndex = 2;
            this.cardGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.cardGrid_CellEndEdit);
            this.cardGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.cardGrid_UserDeletingRow);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Type";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Number";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Expiration";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "CVC";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // autoLogout
            // 
            this.autoLogout.Enabled = true;
            this.autoLogout.Interval = 600000;
            this.autoLogout.Tick += new System.EventHandler(this.autoLogout_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 463);
            this.Controls.Add(this.statusMenu);
            this.Controls.Add(this.formContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(795, 502);
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
            this.cardsTab.ResumeLayout(false);
            this.statusMenu.ResumeLayout(false);
            this.statusMenu.PerformLayout();
            this.cardsContainer.Panel1.ResumeLayout(false);
            this.cardsContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cardsContainer)).EndInit();
            this.cardsContainer.ResumeLayout(false);
            this.cardSearchContainer.ResumeLayout(false);
            this.cardSearchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardSearchLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.StatusStrip statusMenu;
        private System.Windows.Forms.ToolStripStatusLabel lastSyncLabel;
        private System.Windows.Forms.ToolStripStatusLabel syncTimeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordId;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordService;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordNotes;
        private System.Windows.Forms.SplitContainer cardsContainer;
        private System.Windows.Forms.Panel cardSearchContainer;
        private System.Windows.Forms.TextBox cardSearchInput;
        private System.Windows.Forms.PictureBox cardSearchLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView cardGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Timer autoLogout;
    }
}