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
            this.screen = new System.Windows.Forms.PictureBox();
            this.screen_timer = new System.Windows.Forms.Timer(this.components);
            this.screen_color = new System.Windows.Forms.PictureBox();
            this.xPosition = new System.Windows.Forms.Label();
            this.yPosition = new System.Windows.Forms.Label();
            this.rgb_R = new System.Windows.Forms.Label();
            this.rgb_G = new System.Windows.Forms.Label();
            this.rgb_B = new System.Windows.Forms.Label();
            this.hexcode = new System.Windows.Forms.Label();
            this.color_list = new System.Windows.Forms.ListBox();
            this.selected_color = new System.Windows.Forms.PictureBox();
            this.selected_B = new System.Windows.Forms.Label();
            this.selected_G = new System.Windows.Forms.Label();
            this.selected_R = new System.Windows.Forms.Label();
            this.selected_hexcode = new System.Windows.Forms.TextBox();
            this.copy_color = new System.Windows.Forms.Button();
            this.rScroll = new System.Windows.Forms.HScrollBar();
            this.gScroll = new System.Windows.Forms.HScrollBar();
            this.bScroll = new System.Windows.Forms.HScrollBar();
            this.copyright = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen_color)).BeginInit();
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
            this.menuBar.Size = new System.Drawing.Size(434, 24);
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
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.githubToolStripMenuItem.Text = "깃허브";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.githubToolStripMenuItem_Click);
            // 
            // screen
            // 
            this.screen.Location = new System.Drawing.Point(134, 27);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(100, 100);
            this.screen.TabIndex = 1;
            this.screen.TabStop = false;
            this.screen.Paint += new System.Windows.Forms.PaintEventHandler(this.screen_Paint);
            // 
            // screen_timer
            // 
            this.screen_timer.Tick += new System.EventHandler(this.screen_timer_Tick);
            // 
            // screen_color
            // 
            this.screen_color.Location = new System.Drawing.Point(12, 27);
            this.screen_color.Name = "screen_color";
            this.screen_color.Size = new System.Drawing.Size(100, 50);
            this.screen_color.TabIndex = 2;
            this.screen_color.TabStop = false;
            this.screen_color.Paint += new System.Windows.Forms.PaintEventHandler(this.screen_color_Paint);
            // 
            // xPosition
            // 
            this.xPosition.AutoSize = true;
            this.xPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xPosition.ForeColor = System.Drawing.Color.Black;
            this.xPosition.Location = new System.Drawing.Point(54, 81);
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
            this.yPosition.Location = new System.Drawing.Point(55, 98);
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
            this.rgb_R.Location = new System.Drawing.Point(12, 81);
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
            this.rgb_G.Location = new System.Drawing.Point(12, 98);
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
            this.rgb_B.Location = new System.Drawing.Point(13, 115);
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
            this.hexcode.Location = new System.Drawing.Point(54, 115);
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
            this.color_list.Location = new System.Drawing.Point(254, 27);
            this.color_list.Name = "color_list";
            this.color_list.Size = new System.Drawing.Size(168, 104);
            this.color_list.TabIndex = 9;
            this.color_list.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_list_MouseClick);
            this.color_list.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.color_list_DrawItem);
            this.color_list.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            // 
            // selected_color
            // 
            this.selected_color.Location = new System.Drawing.Point(12, 172);
            this.selected_color.Name = "selected_color";
            this.selected_color.Size = new System.Drawing.Size(100, 50);
            this.selected_color.TabIndex = 11;
            this.selected_color.TabStop = false;
            this.selected_color.Paint += new System.Windows.Forms.PaintEventHandler(this.selected_color_Paint);
            // 
            // selected_B
            // 
            this.selected_B.AutoSize = true;
            this.selected_B.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_B.ForeColor = System.Drawing.Color.Black;
            this.selected_B.Location = new System.Drawing.Point(103, 225);
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
            this.selected_G.Location = new System.Drawing.Point(54, 225);
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
            this.selected_R.Location = new System.Drawing.Point(12, 225);
            this.selected_R.Name = "selected_R";
            this.selected_R.Size = new System.Drawing.Size(19, 17);
            this.selected_R.TabIndex = 12;
            this.selected_R.Text = "R:";
            // 
            // selected_hexcode
            // 
            this.selected_hexcode.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_hexcode.Location = new System.Drawing.Point(134, 144);
            this.selected_hexcode.Name = "selected_hexcode";
            this.selected_hexcode.Size = new System.Drawing.Size(100, 23);
            this.selected_hexcode.TabIndex = 15;
            this.selected_hexcode.Text = "단축기: C";
            // 
            // copy_color
            // 
            this.copy_color.Location = new System.Drawing.Point(254, 142);
            this.copy_color.Name = "copy_color";
            this.copy_color.Size = new System.Drawing.Size(168, 23);
            this.copy_color.TabIndex = 17;
            this.copy_color.Text = "값 복사";
            this.copy_color.UseVisualStyleBackColor = true;
            this.copy_color.Click += new System.EventHandler(this.copy_color_Click);
            // 
            // rScroll
            // 
            this.rScroll.Location = new System.Drawing.Point(118, 172);
            this.rScroll.Name = "rScroll";
            this.rScroll.Size = new System.Drawing.Size(307, 17);
            this.rScroll.TabIndex = 19;
            this.rScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.rScroll_Scroll);
            // 
            // gScroll
            // 
            this.gScroll.Location = new System.Drawing.Point(118, 189);
            this.gScroll.Name = "gScroll";
            this.gScroll.Size = new System.Drawing.Size(307, 17);
            this.gScroll.TabIndex = 20;
            this.gScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.gScroll_Scroll);
            // 
            // bScroll
            // 
            this.bScroll.Location = new System.Drawing.Point(118, 206);
            this.bScroll.Name = "bScroll";
            this.bScroll.Size = new System.Drawing.Size(307, 17);
            this.bScroll.TabIndex = 21;
            this.bScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.bScroll_Scroll);
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.Color.DarkGray;
            this.copyright.Location = new System.Drawing.Point(9, 254);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(99, 17);
            this.copyright.TabIndex = 22;
            this.copyright.Text = "©Gloomn 2022";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 270);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.bScroll);
            this.Controls.Add(this.gScroll);
            this.Controls.Add(this.rScroll);
            this.Controls.Add(this.copy_color);
            this.Controls.Add(this.selected_hexcode);
            this.Controls.Add(this.selected_B);
            this.Controls.Add(this.selected_G);
            this.Controls.Add(this.selected_R);
            this.Controls.Add(this.selected_color);
            this.Controls.Add(this.color_list);
            this.Controls.Add(this.hexcode);
            this.Controls.Add(this.rgb_B);
            this.Controls.Add(this.rgb_G);
            this.Controls.Add(this.rgb_R);
            this.Controls.Add(this.yPosition);
            this.Controls.Add(this.xPosition);
            this.Controls.Add(this.screen_color);
            this.Controls.Add(this.screen);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "mainForm";
            this.Text = "Color Picker V1.0.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.screen_color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selected_color)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox selected_hexcode;
        private System.Windows.Forms.Button copy_color;
        private System.Windows.Forms.HScrollBar rScroll;
        private System.Windows.Forms.HScrollBar gScroll;
        private System.Windows.Forms.HScrollBar bScroll;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.Label copyright;
    }
}

