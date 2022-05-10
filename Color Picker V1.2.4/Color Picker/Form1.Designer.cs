namespace Color_Picker
{
    partial class mainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.옵션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.화면모드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.색목록ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.screen_timer = new System.Windows.Forms.Timer(this.components);
            this.xPosition = new System.Windows.Forms.Label();
            this.yPosition = new System.Windows.Forms.Label();
            this.rgb_R = new System.Windows.Forms.Label();
            this.rgb_G = new System.Windows.Forms.Label();
            this.rgb_B = new System.Windows.Forms.Label();
            this.hexcode = new System.Windows.Forms.Label();
            this.color_list = new System.Windows.Forms.ListBox();
            this.selected_B = new System.Windows.Forms.Label();
            this.selected_G = new System.Windows.Forms.Label();
            this.selected_R = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
            this.copy_color = new Guna.UI2.WinForms.Guna2GradientButton();
            this.rScroll = new Guna.UI2.WinForms.Guna2TrackBar();
            this.gScroll = new Guna.UI2.WinForms.Guna2TrackBar();
            this.bScroll = new Guna.UI2.WinForms.Guna2TrackBar();
            this.bordlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.controlPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.exitButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.colorFormatCombo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.selected_hexcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.screen_color = new System.Windows.Forms.PictureBox();
            this.screen = new System.Windows.Forms.PictureBox();
            this.selected_color = new System.Windows.Forms.PictureBox();
            this.menuBar.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screen_color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected_color)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.Control;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.옵션ToolStripMenuItem,
            this.색목록ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(530, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // 옵션ToolStripMenuItem
            // 
            this.옵션ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.화면모드ToolStripMenuItem});
            this.옵션ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.옵션ToolStripMenuItem.Name = "옵션ToolStripMenuItem";
            this.옵션ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.옵션ToolStripMenuItem.Text = "옵션";
            // 
            // 화면모드ToolStripMenuItem
            // 
            this.화면모드ToolStripMenuItem.Name = "화면모드ToolStripMenuItem";
            this.화면모드ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.화면모드ToolStripMenuItem.Text = "다크모드";
            this.화면모드ToolStripMenuItem.Click += new System.EventHandler(this.화면모드ToolStripMenuItem_Click);
            // 
            // 색목록ToolStripMenuItem
            // 
            this.색목록ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.색목록ToolStripMenuItem.Name = "색목록ToolStripMenuItem";
            this.색목록ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.색목록ToolStripMenuItem.Text = "색 목록";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubToolStripMenuItem});
            this.도움말ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.githubToolStripMenuItem.Text = "깃허브";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // screen_timer
            // 
            this.screen_timer.Tick += new System.EventHandler(this.screen_timer_Tick);
            // 
            // xPosition
            // 
            this.xPosition.AutoSize = true;
            this.xPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPosition.ForeColor = System.Drawing.Color.Black;
            this.xPosition.Location = new System.Drawing.Point(116, 90);
            this.xPosition.Name = "xPosition";
            this.xPosition.Size = new System.Drawing.Size(19, 17);
            this.xPosition.TabIndex = 3;
            this.xPosition.Text = "X:";
            // 
            // yPosition
            // 
            this.yPosition.AutoSize = true;
            this.yPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yPosition.ForeColor = System.Drawing.Color.Black;
            this.yPosition.Location = new System.Drawing.Point(117, 107);
            this.yPosition.Name = "yPosition";
            this.yPosition.Size = new System.Drawing.Size(19, 17);
            this.yPosition.TabIndex = 4;
            this.yPosition.Text = "Y:";
            // 
            // rgb_R
            // 
            this.rgb_R.AutoSize = true;
            this.rgb_R.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgb_R.ForeColor = System.Drawing.Color.Black;
            this.rgb_R.Location = new System.Drawing.Point(23, 90);
            this.rgb_R.Name = "rgb_R";
            this.rgb_R.Size = new System.Drawing.Size(19, 17);
            this.rgb_R.TabIndex = 5;
            this.rgb_R.Text = "R:";
            // 
            // rgb_G
            // 
            this.rgb_G.AutoSize = true;
            this.rgb_G.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgb_G.ForeColor = System.Drawing.Color.Black;
            this.rgb_G.Location = new System.Drawing.Point(23, 107);
            this.rgb_G.Name = "rgb_G";
            this.rgb_G.Size = new System.Drawing.Size(20, 17);
            this.rgb_G.TabIndex = 6;
            this.rgb_G.Text = "G:";
            // 
            // rgb_B
            // 
            this.rgb_B.AutoSize = true;
            this.rgb_B.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgb_B.ForeColor = System.Drawing.Color.Black;
            this.rgb_B.Location = new System.Drawing.Point(24, 124);
            this.rgb_B.Name = "rgb_B";
            this.rgb_B.Size = new System.Drawing.Size(19, 17);
            this.rgb_B.TabIndex = 7;
            this.rgb_B.Text = "B:";
            // 
            // hexcode
            // 
            this.hexcode.AutoSize = true;
            this.hexcode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexcode.ForeColor = System.Drawing.Color.Black;
            this.hexcode.Location = new System.Drawing.Point(116, 124);
            this.hexcode.Name = "hexcode";
            this.hexcode.Size = new System.Drawing.Size(36, 17);
            this.hexcode.TabIndex = 8;
            this.hexcode.Text = "HEX:";
            // 
            // color_list
            // 
            this.color_list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.color_list.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.color_list.FormattingEnabled = true;
            this.color_list.ItemHeight = 17;
            this.color_list.Location = new System.Drawing.Point(317, 36);
            this.color_list.Name = "color_list";
            this.color_list.Size = new System.Drawing.Size(201, 104);
            this.color_list.TabIndex = 9;
            this.color_list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_list_MouseClick);
            this.color_list.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.color_list_DrawItem);
            this.color_list.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            // 
            // selected_B
            // 
            this.selected_B.AutoSize = true;
            this.selected_B.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_B.ForeColor = System.Drawing.Color.Black;
            this.selected_B.Location = new System.Drawing.Point(115, 348);
            this.selected_B.Name = "selected_B";
            this.selected_B.Size = new System.Drawing.Size(19, 17);
            this.selected_B.TabIndex = 14;
            this.selected_B.Text = "B:";
            // 
            // selected_G
            // 
            this.selected_G.AutoSize = true;
            this.selected_G.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_G.ForeColor = System.Drawing.Color.Black;
            this.selected_G.Location = new System.Drawing.Point(115, 320);
            this.selected_G.Name = "selected_G";
            this.selected_G.Size = new System.Drawing.Size(20, 17);
            this.selected_G.TabIndex = 13;
            this.selected_G.Text = "G:";
            // 
            // selected_R
            // 
            this.selected_R.AutoSize = true;
            this.selected_R.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_R.ForeColor = System.Drawing.Color.Black;
            this.selected_R.Location = new System.Drawing.Point(116, 288);
            this.selected_R.Name = "selected_R";
            this.selected_R.Size = new System.Drawing.Size(19, 17);
            this.selected_R.TabIndex = 12;
            this.selected_R.Text = "R:";
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.Color.DarkGray;
            this.copyright.Location = new System.Drawing.Point(3, 412);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(99, 17);
            this.copyright.TabIndex = 22;
            this.copyright.Text = "©Gloomn 2022";
            // 
            // copy_color
            // 
            this.copy_color.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.copy_color.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.copy_color.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.copy_color.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.copy_color.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.copy_color.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.copy_color.ForeColor = System.Drawing.Color.White;
            this.copy_color.Location = new System.Drawing.Point(317, 144);
            this.copy_color.Margin = new System.Windows.Forms.Padding(2);
            this.copy_color.Name = "copy_color";
            this.copy_color.Size = new System.Drawing.Size(200, 30);
            this.copy_color.TabIndex = 23;
            this.copy_color.Text = "값 복사";
            this.copy_color.Click += new System.EventHandler(this.copy_color_Click);
            // 
            // rScroll
            // 
            this.rScroll.Location = new System.Drawing.Point(172, 280);
            this.rScroll.Margin = new System.Windows.Forms.Padding(2);
            this.rScroll.Name = "rScroll";
            this.rScroll.Size = new System.Drawing.Size(347, 38);
            this.rScroll.TabIndex = 24;
            this.rScroll.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.rScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.rScroll_Scroll);
            // 
            // gScroll
            // 
            this.gScroll.Location = new System.Drawing.Point(171, 309);
            this.gScroll.Margin = new System.Windows.Forms.Padding(2);
            this.gScroll.Name = "gScroll";
            this.gScroll.Size = new System.Drawing.Size(347, 40);
            this.gScroll.TabIndex = 25;
            this.gScroll.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.gScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gScroll_Scroll);
            // 
            // bScroll
            // 
            this.bScroll.Location = new System.Drawing.Point(172, 340);
            this.bScroll.Margin = new System.Windows.Forms.Padding(2);
            this.bScroll.Name = "bScroll";
            this.bScroll.Size = new System.Drawing.Size(347, 36);
            this.bScroll.TabIndex = 26;
            this.bScroll.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.bScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bScroll_Scroll);
            // 
            // bordlessForm
            // 
            this.bordlessForm.BorderRadius = 8;
            this.bordlessForm.ContainerControl = this;
            this.bordlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.bordlessForm.TransparentWhileDrag = true;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.controlPanel.Controls.Add(this.exitButton);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.controlPanel.Location = new System.Drawing.Point(0, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(530, 20);
            this.controlPanel.TabIndex = 27;
            this.controlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseDown);
            this.controlPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseMove);
            this.controlPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseUp);
            // 
            // exitButton
            // 
            this.exitButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitButton.FillColor = System.Drawing.Color.Transparent;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Image = global::Color_Picker.Properties.Resources.closeWindow2;
            this.exitButton.Location = new System.Drawing.Point(507, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(20, 20);
            this.exitButton.TabIndex = 27;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 27;
            this.label1.Text = "Color Picker";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.colorFormatCombo);
            this.mainPanel.Controls.Add(this.selected_hexcode);
            this.mainPanel.Controls.Add(this.screen_color);
            this.mainPanel.Controls.Add(this.screen);
            this.mainPanel.Controls.Add(this.menuBar);
            this.mainPanel.Controls.Add(this.bScroll);
            this.mainPanel.Controls.Add(this.xPosition);
            this.mainPanel.Controls.Add(this.gScroll);
            this.mainPanel.Controls.Add(this.yPosition);
            this.mainPanel.Controls.Add(this.rScroll);
            this.mainPanel.Controls.Add(this.rgb_R);
            this.mainPanel.Controls.Add(this.copy_color);
            this.mainPanel.Controls.Add(this.rgb_G);
            this.mainPanel.Controls.Add(this.copyright);
            this.mainPanel.Controls.Add(this.rgb_B);
            this.mainPanel.Controls.Add(this.hexcode);
            this.mainPanel.Controls.Add(this.selected_B);
            this.mainPanel.Controls.Add(this.color_list);
            this.mainPanel.Controls.Add(this.selected_G);
            this.mainPanel.Controls.Add(this.selected_color);
            this.mainPanel.Controls.Add(this.selected_R);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 20);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(530, 430);
            this.mainPanel.TabIndex = 28;
            // 
            // colorFormatCombo
            // 
            this.colorFormatCombo.BackColor = System.Drawing.Color.Transparent;
            this.colorFormatCombo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.colorFormatCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorFormatCombo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.colorFormatCombo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.colorFormatCombo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colorFormatCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.colorFormatCombo.ItemHeight = 30;
            this.colorFormatCombo.Location = new System.Drawing.Point(23, 144);
            this.colorFormatCombo.Name = "colorFormatCombo";
            this.colorFormatCombo.Size = new System.Drawing.Size(143, 36);
            this.colorFormatCombo.StartIndex = 0;
            this.colorFormatCombo.TabIndex = 28;
            this.colorFormatCombo.SelectedIndexChanged += new System.EventHandler(this.colorFormatCombo_SelectedIndexChanged);
            // 
            // selected_hexcode
            // 
            this.selected_hexcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.selected_hexcode.DefaultText = "단축기 : C";
            this.selected_hexcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.selected_hexcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.selected_hexcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.selected_hexcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.selected_hexcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.selected_hexcode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selected_hexcode.ForeColor = System.Drawing.Color.Black;
            this.selected_hexcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.selected_hexcode.Location = new System.Drawing.Point(193, 144);
            this.selected_hexcode.Name = "selected_hexcode";
            this.selected_hexcode.PasswordChar = '\0';
            this.selected_hexcode.PlaceholderText = "";
            this.selected_hexcode.SelectedText = "";
            this.selected_hexcode.Size = new System.Drawing.Size(100, 32);
            this.selected_hexcode.TabIndex = 27;
            // 
            // screen_color
            // 
            this.screen_color.Location = new System.Drawing.Point(23, 36);
            this.screen_color.Name = "screen_color";
            this.screen_color.Size = new System.Drawing.Size(143, 50);
            this.screen_color.TabIndex = 2;
            this.screen_color.TabStop = false;
            this.screen_color.Paint += new System.Windows.Forms.PaintEventHandler(this.screen_color_Paint);
            // 
            // screen
            // 
            this.screen.Location = new System.Drawing.Point(193, 36);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(100, 100);
            this.screen.TabIndex = 1;
            this.screen.TabStop = false;
            this.screen.Paint += new System.Windows.Forms.PaintEventHandler(this.screen_Paint);
            // 
            // selected_color
            // 
            this.selected_color.Location = new System.Drawing.Point(14, 288);
            this.selected_color.Name = "selected_color";
            this.selected_color.Size = new System.Drawing.Size(100, 77);
            this.selected_color.TabIndex = 11;
            this.selected_color.TabStop = false;
            this.selected_color.Paint += new System.Windows.Forms.PaintEventHandler(this.selected_color_Paint);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.controlPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "mainForm";
            this.Text = "Color Picker V1.2.4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screen_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected_color)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem 옵션ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 색목록ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.PictureBox screen;
        private System.Windows.Forms.Timer screen_timer;
        private System.Windows.Forms.PictureBox screen_color;
        private System.Windows.Forms.Label xPosition;
        private System.Windows.Forms.Label yPosition;
        private System.Windows.Forms.Label rgb_R;
        private System.Windows.Forms.Label rgb_G;
        private System.Windows.Forms.Label rgb_B;
        private System.Windows.Forms.Label hexcode;
        private System.Windows.Forms.ToolStripMenuItem 화면모드ToolStripMenuItem;
        private System.Windows.Forms.ListBox color_list;
        private System.Windows.Forms.PictureBox selected_color;
        private System.Windows.Forms.Label selected_B;
        private System.Windows.Forms.Label selected_G;
        private System.Windows.Forms.Label selected_R;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.Label copyright;
        private Guna.UI2.WinForms.Guna2GradientButton copy_color;
        private Guna.UI2.WinForms.Guna2TrackBar rScroll;
        private Guna.UI2.WinForms.Guna2TrackBar gScroll;
        private Guna.UI2.WinForms.Guna2TrackBar bScroll;
        private Guna.UI2.WinForms.Guna2BorderlessForm bordlessForm;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel mainPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel controlPanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button exitButton;
        private Guna.UI2.WinForms.Guna2TextBox selected_hexcode;
        private Guna.UI2.WinForms.Guna2ComboBox colorFormatCombo;
    }
}

