namespace Chess_Programming
{
    partial class frmTrainingOptions
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
            this.chkEndGame = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkMate3 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkMate1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkMate2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.chkRandom = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.btnBegin = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkEndGame
            // 
            this.chkEndGame.AutoSize = true;
            this.chkEndGame.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEndGame.Location = new System.Drawing.Point(0, 245);
            this.chkEndGame.Name = "chkEndGame";
            this.chkEndGame.Size = new System.Drawing.Size(144, 17);
            this.chkEndGame.TabIndex = 0;
            this.chkEndGame.Text = "Tàn Cuộc Luyện Tập";
            this.chkEndGame.Visible = false;
            // 
            // chkMate3
            // 
            this.chkMate3.AutoSize = true;
            this.chkMate3.Checked = true;
            this.chkMate3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMate3.CheckValue = "Y";
            this.chkMate3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMate3.Location = new System.Drawing.Point(35, 66);
            this.chkMate3.Name = "chkMate3";
            this.chkMate3.Size = new System.Drawing.Size(158, 17);
            this.chkMate3.TabIndex = 1;
            this.chkMate3.Text = "Chiếu Bí Trong 3 Nước";
            // 
            // chkMate1
            // 
            this.chkMate1.AutoSize = true;
            this.chkMate1.Checked = true;
            this.chkMate1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMate1.CheckValue = "Y";
            this.chkMate1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMate1.Location = new System.Drawing.Point(35, 12);
            this.chkMate1.Name = "chkMate1";
            this.chkMate1.Size = new System.Drawing.Size(158, 17);
            this.chkMate1.TabIndex = 2;
            this.chkMate1.Text = "Chiếu Bí Trong 1 Nước";
            // 
            // chkMate2
            // 
            this.chkMate2.AutoSize = true;
            this.chkMate2.Checked = true;
            this.chkMate2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMate2.CheckValue = "Y";
            this.chkMate2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMate2.Location = new System.Drawing.Point(35, 39);
            this.chkMate2.Name = "chkMate2";
            this.chkMate2.Size = new System.Drawing.Size(158, 17);
            this.chkMate2.TabIndex = 3;
            this.chkMate2.Text = "Chiếu Bí Trong 2 Nước";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.chkMate1);
            this.groupPanel1.Controls.Add(this.chkMate2);
            this.groupPanel1.Controls.Add(this.chkMate3);
            this.groupPanel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(9, 56);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(241, 129);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 4;
            this.groupPanel1.Text = "Loại Bài Tập";
            // 
            // chkRandom
            // 
            this.chkRandom.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRandom.Location = new System.Drawing.Point(0, 245);
            this.chkRandom.Name = "chkRandom";
            this.chkRandom.Size = new System.Drawing.Size(124, 23);
            this.chkRandom.TabIndex = 5;
            this.chkRandom.Text = "Xáo Trộn Bài Tập";
            this.chkRandom.Visible = false;
            this.chkRandom.CheckedChanged += new System.EventHandler(this.chkRandom_CheckedChanged);
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX4.ForeColor = System.Drawing.Color.Red;
            this.labelX4.Location = new System.Drawing.Point(47, 12);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(154, 26);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "Tùy chọn cờ thế";
            // 
            // btnBegin
            // 
            this.btnBegin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnBegin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnBegin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBegin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBegin.Location = new System.Drawing.Point(97, 207);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 32);
            this.btnBegin.TabIndex = 8;
            this.btnBegin.Text = "Bắt Đầu";
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // frmTrainingOptions
            // 
            this.AcceptButton = this.btnBegin;
            this.ClientSize = new System.Drawing.Size(260, 251);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.chkEndGame);
            this.Controls.Add(this.chkRandom);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.Name = "frmTrainingOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy chọn cờ thế";
            this.Load += new System.EventHandler(this.frmTrainingOptions_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.CheckBoxX chkEndGame;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkMate3;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkMate1;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkMate2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkRandom;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.ButtonX btnBegin;
    }
}