
namespace PikachuWinformCs
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pgrLoading = new System.Windows.Forms.ProgressBar();
            this.btbStart = new System.Windows.Forms.Button();
            this.mns_Menu = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.map16x14ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.map10x10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.map5x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.mns_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 26);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(484, 426);
            this.pnlChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(499, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 261);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 254);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pgrLoading);
            this.panel3.Controls.Add(this.btbStart);
            this.panel3.Location = new System.Drawing.Point(499, 294);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(299, 158);
            this.panel3.TabIndex = 2;
            // 
            // pgrLoading
            // 
            this.pgrLoading.Location = new System.Drawing.Point(3, 18);
            this.pgrLoading.Maximum = 300;
            this.pgrLoading.Name = "pgrLoading";
            this.pgrLoading.Size = new System.Drawing.Size(293, 51);
            this.pgrLoading.Step = 1;
            this.pgrLoading.TabIndex = 1;
            this.pgrLoading.Value = 300;
            // 
            // btbStart
            // 
            this.btbStart.BackColor = System.Drawing.SystemColors.Control;
            this.btbStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btbStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbStart.Location = new System.Drawing.Point(96, 86);
            this.btbStart.Name = "btbStart";
            this.btbStart.Size = new System.Drawing.Size(110, 37);
            this.btbStart.TabIndex = 0;
            this.btbStart.Text = "Start";
            this.btbStart.UseVisualStyleBackColor = false;
            this.btbStart.Click += new System.EventHandler(this.btbStart_Click);
            // 
            // mns_Menu
            // 
            this.mns_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
            this.mns_Menu.Location = new System.Drawing.Point(0, 0);
            this.mns_Menu.Name = "mns_Menu";
            this.mns_Menu.Size = new System.Drawing.Size(813, 24);
            this.mns_Menu.TabIndex = 3;
            this.mns_Menu.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.settingToolStripMenuItem1,
            this.quitToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.newGameToolStripMenuItem.Text = "File";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingToolStripMenuItem.Text = "New Game";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem1
            // 
            this.settingToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.map16x14ToolStripMenuItem,
            this.map10x10ToolStripMenuItem,
            this.map5x5ToolStripMenuItem});
            this.settingToolStripMenuItem1.Name = "settingToolStripMenuItem1";
            this.settingToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.settingToolStripMenuItem1.Text = "Setting";
            // 
            // map16x14ToolStripMenuItem
            // 
            this.map16x14ToolStripMenuItem.Name = "map16x14ToolStripMenuItem";
            this.map16x14ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.map16x14ToolStripMenuItem.Text = "Map 16x14";
            this.map16x14ToolStripMenuItem.Click += new System.EventHandler(this.map16x14ToolStripMenuItem_Click);
            // 
            // map10x10ToolStripMenuItem
            // 
            this.map10x10ToolStripMenuItem.Name = "map10x10ToolStripMenuItem";
            this.map10x10ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.map10x10ToolStripMenuItem.Text = "Map 10x10";
            this.map10x10ToolStripMenuItem.Click += new System.EventHandler(this.map10x10ToolStripMenuItem_Click);
            // 
            // map5x5ToolStripMenuItem
            // 
            this.map5x5ToolStripMenuItem.Name = "map5x5ToolStripMenuItem";
            this.map5x5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.map5x5ToolStripMenuItem.Text = "Map  6x6";
            this.map5x5ToolStripMenuItem.Click += new System.EventHandler(this.map6x6ToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 464);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlChessBoard);
            this.Controls.Add(this.mns_Menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mns_Menu;
            this.Name = "Form1";
            this.Text = "Pikachu Game";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.mns_Menu.ResumeLayout(false);
            this.mns_Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ProgressBar pgrLoading;
        private System.Windows.Forms.Button btbStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip mns_Menu;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem map16x14ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem map10x10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem map5x5ToolStripMenuItem;
    }
}

