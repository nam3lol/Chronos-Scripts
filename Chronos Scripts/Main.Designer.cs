namespace Chronos_Scripts
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MiniBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.CloseBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.Scripts = new System.Windows.Forms.ListBox();
            this.siticoneSeparator1 = new Siticone.UI.WinForms.SiticoneSeparator();
            this.CopyBtn = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.Search = new Siticone.UI.WinForms.SiticoneTextBox();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.siticonePanel1.Controls.Add(this.pictureBox1);
            this.siticonePanel1.Controls.Add(this.MiniBtn);
            this.siticonePanel1.Controls.Add(this.CloseBtn);
            this.siticonePanel1.Location = new System.Drawing.Point(-1, -1);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(317, 44);
            this.siticonePanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chronos_Scripts.Properties.Resources.Chronos;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MiniBtn
            // 
            this.MiniBtn.CheckedState.Parent = this.MiniBtn;
            this.MiniBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MiniBtn.CustomImages.Parent = this.MiniBtn;
            this.MiniBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MiniBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiniBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MiniBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.MiniBtn.HoveredState.ForeColor = System.Drawing.Color.White;
            this.MiniBtn.HoveredState.Parent = this.MiniBtn;
            this.MiniBtn.Image = global::Chronos_Scripts.Properties.Resources.sheets_96px;
            this.MiniBtn.ImageSize = new System.Drawing.Size(30, 26);
            this.MiniBtn.Location = new System.Drawing.Point(209, 0);
            this.MiniBtn.Name = "MiniBtn";
            this.MiniBtn.ShadowDecoration.Parent = this.MiniBtn;
            this.MiniBtn.Size = new System.Drawing.Size(49, 44);
            this.MiniBtn.TabIndex = 20;
            this.MiniBtn.TextOffset = new System.Drawing.Point(0, 1);
            this.MiniBtn.Click += new System.EventHandler(this.MiniBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.CheckedState.Parent = this.CloseBtn;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.CustomImages.Parent = this.CloseBtn;
            this.CloseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CloseBtn.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CloseBtn.HoveredState.FillColor = System.Drawing.Color.Red;
            this.CloseBtn.HoveredState.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.HoveredState.Parent = this.CloseBtn;
            this.CloseBtn.Image = global::Chronos_Scripts.Properties.Resources.close_96px;
            this.CloseBtn.ImageOffset = new System.Drawing.Point(1, 0);
            this.CloseBtn.ImageSize = new System.Drawing.Size(28, 26);
            this.CloseBtn.Location = new System.Drawing.Point(258, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(49, 44);
            this.CloseBtn.TabIndex = 19;
            this.CloseBtn.TextOffset = new System.Drawing.Point(0, 1);
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Scripts
            // 
            this.Scripts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Scripts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Scripts.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scripts.ForeColor = System.Drawing.Color.White;
            this.Scripts.FormattingEnabled = true;
            this.Scripts.ItemHeight = 19;
            this.Scripts.Location = new System.Drawing.Point(12, 49);
            this.Scripts.Name = "Scripts";
            this.Scripts.Size = new System.Drawing.Size(283, 323);
            this.Scripts.TabIndex = 2;
            // 
            // siticoneSeparator1
            // 
            this.siticoneSeparator1.Location = new System.Drawing.Point(12, 378);
            this.siticoneSeparator1.Name = "siticoneSeparator1";
            this.siticoneSeparator1.Size = new System.Drawing.Size(283, 10);
            this.siticoneSeparator1.TabIndex = 3;
            // 
            // CopyBtn
            // 
            this.CopyBtn.BorderRadius = 4;
            this.CopyBtn.CheckedState.Parent = this.CopyBtn;
            this.CopyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyBtn.CustomImages.Parent = this.CopyBtn;
            this.CopyBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CopyBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CopyBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CopyBtn.HoveredState.ForeColor = System.Drawing.Color.White;
            this.CopyBtn.HoveredState.Parent = this.CopyBtn;
            this.CopyBtn.ImageSize = new System.Drawing.Size(36, 28);
            this.CopyBtn.Location = new System.Drawing.Point(12, 393);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.ShadowDecoration.Parent = this.CopyBtn;
            this.CopyBtn.Size = new System.Drawing.Size(86, 34);
            this.CopyBtn.TabIndex = 17;
            this.CopyBtn.Text = "Copy";
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.siticonePanel1;
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 20;
            this.siticoneElipse1.TargetControl = this;
            // 
            // Search
            // 
            this.Search.BorderColor = System.Drawing.Color.Empty;
            this.Search.BorderRadius = 4;
            this.Search.BorderThickness = 0;
            this.Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search.DefaultText = "";
            this.Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search.DisabledState.Parent = this.Search;
            this.Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Search.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Search.FocusedState.ForeColor = System.Drawing.Color.White;
            this.Search.FocusedState.Parent = this.Search;
            this.Search.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Search.HoveredState.ForeColor = System.Drawing.Color.White;
            this.Search.HoveredState.Parent = this.Search;
            this.Search.IconLeft = global::Chronos_Scripts.Properties.Resources.search_96px;
            this.Search.Location = new System.Drawing.Point(104, 394);
            this.Search.Name = "Search";
            this.Search.PasswordChar = '\0';
            this.Search.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.Search.PlaceholderText = "Search For Scripts";
            this.Search.SelectedText = "";
            this.Search.ShadowDecoration.Parent = this.Search;
            this.Search.Size = new System.Drawing.Size(191, 33);
            this.Search.TabIndex = 18;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(307, 436);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.siticoneSeparator1);
            this.Controls.Add(this.Scripts);
            this.Controls.Add(this.siticonePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Chronos Scripts";
            this.Load += new System.EventHandler(this.Main_Load);
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private System.Windows.Forms.ListBox Scripts;
        private Siticone.UI.WinForms.SiticoneSeparator siticoneSeparator1;
        private Siticone.UI.WinForms.SiticoneButton CopyBtn;
        private Siticone.UI.WinForms.SiticoneTextBox Search;
        private Siticone.UI.WinForms.SiticoneButton MiniBtn;
        private Siticone.UI.WinForms.SiticoneButton CloseBtn;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

