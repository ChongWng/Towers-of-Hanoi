namespace Towers_of_Hanoi
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
            this.txtMoves = new System.Windows.Forms.TextBox();
            this.lblDisk1 = new System.Windows.Forms.Label();
            this.lblDisk2 = new System.Windows.Forms.Label();
            this.lblDisk3 = new System.Windows.Forms.Label();
            this.lblDisk4 = new System.Windows.Forms.Label();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.lblPeg1 = new System.Windows.Forms.Label();
            this.lblPeg2 = new System.Windows.Forms.Label();
            this.lblPeg3 = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem = new System.Windows.Forms.MenuItem();
            this.menuNew = new System.Windows.Forms.MenuItem();
            this.menuOpen = new System.Windows.Forms.MenuItem();
            this.menuSave = new System.Windows.Forms.MenuItem();
            this.menuAnimate = new System.Windows.Forms.MenuItem();
            this.menuSeparatorbar = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.openMovesDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveMovesDlg = new System.Windows.Forms.SaveFileDialog();
            this.tmr = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.tmr)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMoves
            // 
            this.txtMoves.Location = new System.Drawing.Point(635, 72);
            this.txtMoves.Multiline = true;
            this.txtMoves.Name = "txtMoves";
            this.txtMoves.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoves.Size = new System.Drawing.Size(201, 278);
            this.txtMoves.TabIndex = 17;
            // 
            // lblDisk1
            // 
            this.lblDisk1.BackColor = System.Drawing.Color.Lime;
            this.lblDisk1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk1.Location = new System.Drawing.Point(98, 219);
            this.lblDisk1.Name = "lblDisk1";
            this.lblDisk1.Size = new System.Drawing.Size(48, 24);
            this.lblDisk1.TabIndex = 16;
            this.lblDisk1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk_MouseDown);
            // 
            // lblDisk2
            // 
            this.lblDisk2.BackColor = System.Drawing.Color.Lime;
            this.lblDisk2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk2.Location = new System.Drawing.Point(82, 243);
            this.lblDisk2.Name = "lblDisk2";
            this.lblDisk2.Size = new System.Drawing.Size(80, 24);
            this.lblDisk2.TabIndex = 15;
            this.lblDisk2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk_MouseDown);
            // 
            // lblDisk3
            // 
            this.lblDisk3.BackColor = System.Drawing.Color.Lime;
            this.lblDisk3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk3.Location = new System.Drawing.Point(66, 267);
            this.lblDisk3.Name = "lblDisk3";
            this.lblDisk3.Size = new System.Drawing.Size(112, 24);
            this.lblDisk3.TabIndex = 14;
            this.lblDisk3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk_MouseDown);
            // 
            // lblDisk4
            // 
            this.lblDisk4.BackColor = System.Drawing.Color.Lime;
            this.lblDisk4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisk4.Location = new System.Drawing.Point(50, 291);
            this.lblDisk4.Name = "lblDisk4";
            this.lblDisk4.Size = new System.Drawing.Size(144, 24);
            this.lblDisk4.TabIndex = 13;
            this.lblDisk4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Disk_MouseDown);
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlBase.Location = new System.Drawing.Point(13, 315);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(584, 48);
            this.pnlBase.TabIndex = 9;
            // 
            // lblPeg1
            // 
            this.lblPeg1.AllowDrop = true;
            this.lblPeg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg1.Location = new System.Drawing.Point(109, 187);
            this.lblPeg1.Name = "lblPeg1";
            this.lblPeg1.Size = new System.Drawing.Size(24, 144);
            this.lblPeg1.TabIndex = 10;
            this.lblPeg1.DragDrop += new System.Windows.Forms.DragEventHandler(this.Peg_DragDrop);
            this.lblPeg1.DragEnter += new System.Windows.Forms.DragEventHandler(this.Peg_DragEnter);
            // 
            // lblPeg2
            // 
            this.lblPeg2.AllowDrop = true;
            this.lblPeg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg2.Location = new System.Drawing.Point(289, 187);
            this.lblPeg2.Name = "lblPeg2";
            this.lblPeg2.Size = new System.Drawing.Size(24, 144);
            this.lblPeg2.TabIndex = 11;
            this.lblPeg2.DragDrop += new System.Windows.Forms.DragEventHandler(this.Peg_DragDrop);
            this.lblPeg2.DragEnter += new System.Windows.Forms.DragEventHandler(this.Peg_DragEnter);
            // 
            // lblPeg3
            // 
            this.lblPeg3.AllowDrop = true;
            this.lblPeg3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblPeg3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPeg3.Location = new System.Drawing.Point(469, 187);
            this.lblPeg3.Name = "lblPeg3";
            this.lblPeg3.Size = new System.Drawing.Size(24, 144);
            this.lblPeg3.TabIndex = 12;
            this.lblPeg3.DragDrop += new System.Windows.Forms.DragEventHandler(this.Peg_DragDrop);
            this.lblPeg3.DragEnter += new System.Windows.Forms.DragEventHandler(this.Peg_DragEnter);
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem});
            // 
            // menuItem
            // 
            this.menuItem.Index = 0;
            this.menuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuNew,
            this.menuOpen,
            this.menuSave,
            this.menuAnimate,
            this.menuSeparatorbar,
            this.menuExit});
            this.menuItem.Text = "File";
            // 
            // menuNew
            // 
            this.menuNew.Index = 0;
            this.menuNew.Text = "New";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Index = 1;
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // menuSave
            // 
            this.menuSave.Index = 2;
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuAnimate
            // 
            this.menuAnimate.Index = 3;
            this.menuAnimate.Text = "Animate";
            this.menuAnimate.Click += new System.EventHandler(this.menuAnimate_Click);
            // 
            // menuSeparatorbar
            // 
            this.menuSeparatorbar.Index = 4;
            this.menuSeparatorbar.Text = "-";
            // 
            // menuExit
            // 
            this.menuExit.Index = 5;
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // openMovesDlg
            // 
            this.openMovesDlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // saveMovesDlg
            // 
            this.saveMovesDlg.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // tmr
            // 
            this.tmr.Interval = 500D;
            this.tmr.SynchronizingObject = this;
            this.tmr.Elapsed += new System.Timers.ElapsedEventHandler(this.tmr_Elapsed);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 464);
            this.Controls.Add(this.txtMoves);
            this.Controls.Add(this.lblDisk1);
            this.Controls.Add(this.lblDisk2);
            this.Controls.Add(this.lblDisk3);
            this.Controls.Add(this.lblDisk4);
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.lblPeg1);
            this.Controls.Add(this.lblPeg2);
            this.Controls.Add(this.lblPeg3);
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "The Towers of Hanoi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tmr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMoves;
        private System.Windows.Forms.Label lblDisk1;
        private System.Windows.Forms.Label lblDisk2;
        private System.Windows.Forms.Label lblDisk3;
        private System.Windows.Forms.Label lblDisk4;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Label lblPeg1;
        private System.Windows.Forms.Label lblPeg2;
        private System.Windows.Forms.Label lblPeg3;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem menuItem;
        private System.Windows.Forms.MenuItem menuNew;
        private System.Windows.Forms.MenuItem menuOpen;
        private System.Windows.Forms.MenuItem menuSave;
        private System.Windows.Forms.MenuItem menuSeparatorbar;
        private System.Windows.Forms.MenuItem menuExit;
        private System.Windows.Forms.OpenFileDialog openMovesDlg;
        private System.Windows.Forms.SaveFileDialog saveMovesDlg;
        private System.Timers.Timer tmr;
        private System.Windows.Forms.MenuItem menuAnimate;
    }
}

