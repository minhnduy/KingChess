namespace Chess_Programming
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanel1 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar4 = new DevComponents.DotNetBar.RibbonBar();
            this.btnUndo = new DevComponents.DotNetBar.ButtonItem();
            this.btnHint = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar3 = new DevComponents.DotNetBar.RibbonBar();
            this.btnSaveGame = new DevComponents.DotNetBar.ButtonItem();
            this.btnLoadGame = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonBar1 = new DevComponents.DotNetBar.RibbonBar();
            this.btnNewGame = new DevComponents.DotNetBar.ButtonItem();
            this.btnTraining = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonTabItem2 = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonPanel2 = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBar2 = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonTabItem1 = new DevComponents.DotNetBar.RibbonTabItem();
            this.qatCustomizeItem1 = new DevComponents.DotNetBar.QatCustomizeItem();
            this.btnOptions = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.btnTrainingDatabase = new DevComponents.DotNetBar.ButtonItem();
            this.ribbonClientPanel1 = new DevComponents.DotNetBar.Ribbon.RibbonClientPanel();
            this.pnlPlayer1 = new System.Windows.Forms.Panel();
            this.pnlTimer1 = new System.Windows.Forms.Panel();
            this.pnlPlayer2 = new System.Windows.Forms.Panel();
            this.pnlTimer2 = new System.Windows.Forms.Panel();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.pnlCapturedPiece2 = new System.Windows.Forms.Panel();
            this.pnlCapturedPiece1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ribbonControl1.SuspendLayout();
            this.ribbonPanel1.SuspendLayout();
            this.ribbonPanel2.SuspendLayout();
            this.ribbonClientPanel1.SuspendLayout();
            this.pnlPlayer1.SuspendLayout();
            this.pnlPlayer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionVisible = true;
            this.ribbonControl1.Controls.Add(this.ribbonPanel1);
            this.ribbonControl1.Controls.Add(this.ribbonPanel2);
            this.ribbonControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem1});
            this.ribbonControl1.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl1.Location = new System.Drawing.Point(4, 1);
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Office2007ColorTable = DevComponents.DotNetBar.Rendering.eOffice2007ColorScheme.VistaGlass;
            this.ribbonControl1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl1.QuickToolbarItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.qatCustomizeItem1});
            this.ribbonControl1.Size = new System.Drawing.Size(837, 151);
            this.ribbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonControl1.TabGroupHeight = 14;
            this.ribbonControl1.TabIndex = 0;
            this.ribbonControl1.Text = "ribbonControl1";
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel1.Controls.Add(this.ribbonBar4);
            this.ribbonPanel1.Controls.Add(this.ribbonBar3);
            this.ribbonPanel1.Controls.Add(this.ribbonBar1);
            this.ribbonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel1.Location = new System.Drawing.Point(0, 55);
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 1);
            this.ribbonPanel1.Size = new System.Drawing.Size(837, 94);
            this.ribbonPanel1.TabIndex = 1;
            // 
            // ribbonBar4
            // 
            this.ribbonBar4.AutoOverflowEnabled = true;
            this.ribbonBar4.ContainerControlProcessDialogKey = true;
            this.ribbonBar4.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar4.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnUndo,
            this.btnHint});
            this.ribbonBar4.Location = new System.Drawing.Point(279, 0);
            this.ribbonBar4.Name = "ribbonBar4";
            this.ribbonBar4.Size = new System.Drawing.Size(126, 93);
            this.ribbonBar4.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar4.TabIndex = 6;
            // 
            // btnUndo
            // 
            this.btnUndo.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnUndo.Enabled = false;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnUndo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.RibbonWordWrap = false;
            this.btnUndo.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlZ);
            this.btnUndo.SubItemsExpandWidth = 14;
            this.btnUndo.Text = "Quay Lại";
            this.btnUndo.Tooltip = "Ctrl + Z";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnHint
            // 
            this.btnHint.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnHint.Enabled = false;
            this.btnHint.Image = ((System.Drawing.Image)(resources.GetObject("btnHint.Image")));
            this.btnHint.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnHint.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnHint.Name = "btnHint";
            this.btnHint.RibbonWordWrap = false;
            this.btnHint.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlH);
            this.btnHint.SubItemsExpandWidth = 14;
            this.btnHint.Text = "Gợi Ý";
            this.btnHint.Tooltip = "Ctrl + H";
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // ribbonBar3
            // 
            this.ribbonBar3.AutoOverflowEnabled = true;
            this.ribbonBar3.ContainerControlProcessDialogKey = true;
            this.ribbonBar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonBar3.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSaveGame,
            this.btnLoadGame});
            this.ribbonBar3.Location = new System.Drawing.Point(152, 0);
            this.ribbonBar3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.ribbonBar3.Name = "ribbonBar3";
            this.ribbonBar3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonBar3.Size = new System.Drawing.Size(127, 93);
            this.ribbonBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar3.TabIndex = 1;
            // 
            // btnSaveGame
            // 
            this.btnSaveGame.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnSaveGame.Enabled = false;
            this.btnSaveGame.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveGame.Image")));
            this.btnSaveGame.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnSaveGame.ImagePaddingHorizontal = 6;
            this.btnSaveGame.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnSaveGame.Name = "btnSaveGame";
            this.btnSaveGame.RibbonWordWrap = false;
            this.btnSaveGame.Stretch = true;
            this.btnSaveGame.SubItemsExpandWidth = 14;
            this.btnSaveGame.Text = "Lưu ";
            this.btnSaveGame.Click += new System.EventHandler(this.btnSaveGame_Click);
            // 
            // btnLoadGame
            // 
            this.btnLoadGame.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnLoadGame.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadGame.Image")));
            this.btnLoadGame.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnLoadGame.ImagePaddingHorizontal = 6;
            this.btnLoadGame.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnLoadGame.Name = "btnLoadGame";
            this.btnLoadGame.RibbonWordWrap = false;
            this.btnLoadGame.SubItemsExpandWidth = 14;
            this.btnLoadGame.Text = "Bản ghi";
            this.btnLoadGame.Click += new System.EventHandler(this.btnLoadGame_Click);
            // 
            // ribbonBar1
            // 
            this.ribbonBar1.AutoOverflowEnabled = true;
            this.ribbonBar1.ContainerControlProcessDialogKey = true;
            this.ribbonBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnNewGame,
            this.btnTraining});
            this.ribbonBar1.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar1.Name = "ribbonBar1";
            this.ribbonBar1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ribbonBar1.Size = new System.Drawing.Size(149, 93);
            this.ribbonBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar1.TabIndex = 0;
            // 
            // btnNewGame
            // 
            this.btnNewGame.AutoCollapseOnClick = false;
            this.btnNewGame.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnNewGame.Image = ((System.Drawing.Image)(resources.GetObject("btnNewGame.Image")));
            this.btnNewGame.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnNewGame.ImagePaddingHorizontal = 6;
            this.btnNewGame.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnNewGame.ItemAlignment = DevComponents.DotNetBar.eItemAlignment.Far;
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.RibbonWordWrap = false;
            this.btnNewGame.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlN);
            this.btnNewGame.SubItemsExpandWidth = 14;
            this.btnNewGame.Text = "Chơi mới";
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnTraining
            // 
            this.btnTraining.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.btnTraining.Image = global::Chess_Programming.Properties.Resources.physical_education_256;
            this.btnTraining.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.btnTraining.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.RibbonWordWrap = false;
            this.btnTraining.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItem2});
            this.btnTraining.SubItemsExpandWidth = 14;
            this.btnTraining.Text = "Cờ thế";
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // ribbonTabItem2
            // 
            this.ribbonTabItem2.Name = "ribbonTabItem2";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonPanel2.Controls.Add(this.ribbonBar2);
            this.ribbonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanel2.Location = new System.Drawing.Point(0, 0);
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanel2.Size = new System.Drawing.Size(837, 149);
            this.ribbonPanel2.TabIndex = 2;
            this.ribbonPanel2.Visible = false;
            // 
            // ribbonBar2
            // 
            this.ribbonBar2.AutoOverflowEnabled = true;
            this.ribbonBar2.ContainerControlProcessDialogKey = true;
            this.ribbonBar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBar2.Location = new System.Drawing.Point(3, 0);
            this.ribbonBar2.Name = "ribbonBar2";
            this.ribbonBar2.Size = new System.Drawing.Size(126, 146);
            this.ribbonBar2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ribbonBar2.TabIndex = 0;
            // 
            // ribbonTabItem1
            // 
            this.ribbonTabItem1.Checked = true;
            this.ribbonTabItem1.Name = "ribbonTabItem1";
            this.ribbonTabItem1.Panel = this.ribbonPanel1;
            this.ribbonTabItem1.Text = "Trang Chủ";
            // 
            // qatCustomizeItem1
            // 
            this.qatCustomizeItem1.Name = "qatCustomizeItem1";
            // 
            // btnOptions
            // 
            this.btnOptions.Name = "btnOptions";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            // 
            // btnTrainingDatabase
            // 
            this.btnTrainingDatabase.Name = "btnTrainingDatabase";
            // 
            // ribbonClientPanel1
            // 
            this.ribbonClientPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.ribbonClientPanel1.Controls.Add(this.pnlPlayer1);
            this.ribbonClientPanel1.Controls.Add(this.pnlPlayer2);
            this.ribbonClientPanel1.Controls.Add(this.pnlHistory);
            this.ribbonClientPanel1.Controls.Add(this.pnlCapturedPiece2);
            this.ribbonClientPanel1.Controls.Add(this.pnlCapturedPiece1);
            this.ribbonClientPanel1.Controls.Add(this.panel1);
            this.ribbonClientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonClientPanel1.Location = new System.Drawing.Point(4, 152);
            this.ribbonClientPanel1.Name = "ribbonClientPanel1";
            this.ribbonClientPanel1.Size = new System.Drawing.Size(837, 607);
            // 
            // 
            // 
            this.ribbonClientPanel1.Style.Class = "RibbonClientPanel";
            this.ribbonClientPanel1.TabIndex = 1;
            this.ribbonClientPanel1.Text = "ribbonClientPanel1";
            this.ribbonClientPanel1.Click += new System.EventHandler(this.ribbonClientPanel1_Click);
            // 
            // pnlPlayer1
            // 
            this.pnlPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayer1.Controls.Add(this.pnlTimer1);
            this.pnlPlayer1.Location = new System.Drawing.Point(498, 16);
            this.pnlPlayer1.Name = "pnlPlayer1";
            this.pnlPlayer1.Size = new System.Drawing.Size(163, 247);
            this.pnlPlayer1.TabIndex = 9;
            this.pnlPlayer1.Visible = false;
            // 
            // pnlTimer1
            // 
            this.pnlTimer1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTimer1.BackgroundImage")));
            this.pnlTimer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTimer1.Location = new System.Drawing.Point(18, 12);
            this.pnlTimer1.Name = "pnlTimer1";
            this.pnlTimer1.Size = new System.Drawing.Size(130, 45);
            this.pnlTimer1.TabIndex = 4;
            this.pnlTimer1.Visible = false;
            // 
            // pnlPlayer2
            // 
            this.pnlPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.pnlPlayer2.Controls.Add(this.pnlTimer2);
            this.pnlPlayer2.Location = new System.Drawing.Point(498, 280);
            this.pnlPlayer2.Name = "pnlPlayer2";
            this.pnlPlayer2.Size = new System.Drawing.Size(163, 247);
            this.pnlPlayer2.TabIndex = 8;
            this.pnlPlayer2.Visible = false;
            // 
            // pnlTimer2
            // 
            this.pnlTimer2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTimer2.BackgroundImage")));
            this.pnlTimer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTimer2.Location = new System.Drawing.Point(18, 11);
            this.pnlTimer2.Name = "pnlTimer2";
            this.pnlTimer2.Size = new System.Drawing.Size(130, 50);
            this.pnlTimer2.TabIndex = 5;
            this.pnlTimer2.Visible = false;
            // 
            // pnlHistory
            // 
            this.pnlHistory.Location = new System.Drawing.Point(646, 3);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(173, 294);
            this.pnlHistory.TabIndex = 3;
            this.pnlHistory.Visible = false;
            // 
            // pnlCapturedPiece2
            // 
            this.pnlCapturedPiece2.BackColor = System.Drawing.Color.White;
            this.pnlCapturedPiece2.Location = new System.Drawing.Point(446, 212);
            this.pnlCapturedPiece2.Name = "pnlCapturedPiece2";
            this.pnlCapturedPiece2.Size = new System.Drawing.Size(46, 190);
            this.pnlCapturedPiece2.TabIndex = 2;
            this.pnlCapturedPiece2.Visible = false;
            // 
            // pnlCapturedPiece1
            // 
            this.pnlCapturedPiece1.BackColor = System.Drawing.Color.White;
            this.pnlCapturedPiece1.Location = new System.Drawing.Point(446, 3);
            this.pnlCapturedPiece1.Name = "pnlCapturedPiece1";
            this.pnlCapturedPiece1.Size = new System.Drawing.Size(46, 190);
            this.pnlCapturedPiece1.TabIndex = 1;
            this.pnlCapturedPiece1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 402);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // frmMain
            // 
            this.BottomLeftCornerSize = 0;
            this.BottomRightCornerSize = 0;
            this.ClientSize = new System.Drawing.Size(845, 761);
            this.Controls.Add(this.ribbonClientPanel1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "frmMain";
            this.Text = "King Chess";
            this.TopLeftCornerSize = 0;
            this.TopRightCornerSize = 0;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ribbonControl1.ResumeLayout(false);
            this.ribbonControl1.PerformLayout();
            this.ribbonPanel1.ResumeLayout(false);
            this.ribbonPanel2.ResumeLayout(false);
            this.ribbonClientPanel1.ResumeLayout(false);
            this.pnlPlayer1.ResumeLayout(false);
            this.pnlPlayer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl1;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar1;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem1;
        private DevComponents.DotNetBar.QatCustomizeItem qatCustomizeItem1;
        private DevComponents.DotNetBar.Ribbon.RibbonClientPanel ribbonClientPanel1;
        private DevComponents.DotNetBar.RibbonBar ribbonBar3;
        private DevComponents.DotNetBar.ButtonItem btnSaveGame;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.ButtonItem btnOptions;
        //private DevComponents.DotNetBar.ButtonItem btnUndo;
        private System.Windows.Forms.Panel pnlCapturedPiece2;
        private System.Windows.Forms.Panel pnlCapturedPiece1;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Panel pnlTimer1;
        private System.Windows.Forms.Panel pnlTimer2;
        private System.Windows.Forms.Panel pnlPlayer2;
        private System.Windows.Forms.Panel pnlPlayer1;
        private DevComponents.DotNetBar.ButtonItem btnNewGame;
        private DevComponents.DotNetBar.ButtonItem btnTraining;
        private DevComponents.DotNetBar.ButtonItem btnLoadGame;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem btnTrainingDatabase;
        //private DevComponents.DotNetBar.ButtonItem btnHint;
        //private DevComponents.DotNetBar.ButtonItem btnAbout;
        //private DevComponents.DotNetBar.ButtonItem btnChessRule;
        //private DevComponents.DotNetBar.ButtonItem btnContact;
        private DevComponents.DotNetBar.RibbonBar ribbonBar4;
        private DevComponents.DotNetBar.ButtonItem btnUndo;
        private DevComponents.DotNetBar.ButtonItem btnHint;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItem2;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanel2;
        private DevComponents.DotNetBar.RibbonBar ribbonBar2;
    }
}