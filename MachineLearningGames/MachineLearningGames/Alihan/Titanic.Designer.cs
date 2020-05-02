﻿namespace MachineLearningGames.Alihan
{
    partial class Titanic
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Titanic));
            this.transitionTabs = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnTest = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTrain = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuTileButton();
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).BeginInit();
            this.SuspendLayout();
            // 
            // transitionTabs
            // 
            this.transitionTabs.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.transitionTabs.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.transitionTabs.DefaultAnimation = animation1;
            this.transitionTabs.MaxAnimationTime = 1000;
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMain.BackgroundImage")));
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Controls.Add(this.pbGame);
            this.pnlMain.Controls.Add(this.lblGameName);
            this.transitionTabs.SetDecoration(this.pnlMain, BunifuAnimatorNS.DecorationType.None);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(2000, 868);
            this.pnlMain.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.pnlBottom.Controls.Add(this.btnTest);
            this.pnlBottom.Controls.Add(this.btnTrain);
            this.pnlBottom.Controls.Add(this.btnHome);
            this.transitionTabs.SetDecoration(this.pnlBottom, BunifuAnimatorNS.DecorationType.None);
            this.pnlBottom.Location = new System.Drawing.Point(0, 745);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(2000, 123);
            this.pnlBottom.TabIndex = 7;
            // 
            // btnTest
            // 
            this.btnTest.BackColor = System.Drawing.Color.Transparent;
            this.btnTest.color = System.Drawing.Color.Transparent;
            this.btnTest.colorActive = System.Drawing.Color.Transparent;
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionTabs.SetDecoration(this.btnTest, BunifuAnimatorNS.DecorationType.None);
            this.btnTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnTest.ForeColor = System.Drawing.Color.White;
            this.btnTest.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.Image")));
            this.btnTest.ImagePosition = 16;
            this.btnTest.ImageZoom = 50;
            this.btnTest.LabelPosition = 33;
            this.btnTest.LabelText = "";
            this.btnTest.Location = new System.Drawing.Point(1083, 0);
            this.btnTest.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(116, 111);
            this.btnTest.TabIndex = 2;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            this.btnTest.MouseLeave += new System.EventHandler(this.btnTest_MouseLeave);
            this.btnTest.MouseHover += new System.EventHandler(this.btnTest_MouseHover);
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.Transparent;
            this.btnTrain.color = System.Drawing.Color.Transparent;
            this.btnTrain.colorActive = System.Drawing.Color.Transparent;
            this.btnTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionTabs.SetDecoration(this.btnTrain, BunifuAnimatorNS.DecorationType.None);
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.Image = ((System.Drawing.Image)(resources.GetObject("btnTrain.Image")));
            this.btnTrain.ImagePosition = 16;
            this.btnTrain.ImageZoom = 50;
            this.btnTrain.LabelPosition = 33;
            this.btnTrain.LabelText = "";
            this.btnTrain.Location = new System.Drawing.Point(933, 0);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(116, 111);
            this.btnTrain.TabIndex = 1;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            this.btnTrain.MouseLeave += new System.EventHandler(this.btnTrain_MouseLeave);
            this.btnTrain.MouseHover += new System.EventHandler(this.btnTrain_MouseHover);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.color = System.Drawing.Color.Transparent;
            this.btnHome.colorActive = System.Drawing.Color.Transparent;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transitionTabs.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImagePosition = 16;
            this.btnHome.ImageZoom = 50;
            this.btnHome.LabelPosition = 33;
            this.btnHome.LabelText = "";
            this.btnHome.Location = new System.Drawing.Point(784, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(133, 123);
            this.btnHome.TabIndex = 0;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.MouseLeave += new System.EventHandler(this.btnHome_MouseLeave);
            this.btnHome.MouseHover += new System.EventHandler(this.btnHome_MouseHover);
            // 
            // pbGame
            // 
            this.pbGame.BackColor = System.Drawing.Color.Transparent;
            this.transitionTabs.SetDecoration(this.pbGame, BunifuAnimatorNS.DecorationType.None);
            this.pbGame.Image = ((System.Drawing.Image)(resources.GetObject("pbGame.Image")));
            this.pbGame.Location = new System.Drawing.Point(609, 146);
            this.pbGame.Name = "pbGame";
            this.pbGame.Size = new System.Drawing.Size(783, 375);
            this.pbGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGame.TabIndex = 6;
            this.pbGame.TabStop = false;
            // 
            // lblGameName
            // 
            this.lblGameName.AutoSize = true;
            this.lblGameName.BackColor = System.Drawing.Color.Transparent;
            this.transitionTabs.SetDecoration(this.lblGameName, BunifuAnimatorNS.DecorationType.None);
            this.lblGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGameName.ForeColor = System.Drawing.Color.White;
            this.lblGameName.Location = new System.Drawing.Point(716, 551);
            this.lblGameName.Name = "lblGameName";
            this.lblGameName.Size = new System.Drawing.Size(654, 46);
            this.lblGameName.TabIndex = 4;
            this.lblGameName.Text = "TİTANİC! - Machine Learning Game";
            // 
            // Titanic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.transitionTabs.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "Titanic";
            this.Size = new System.Drawing.Size(2000, 868);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition transitionTabs;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.PictureBox pbGame;
        private System.Windows.Forms.Panel pnlBottom;
        private Bunifu.Framework.UI.BunifuTileButton btnTest;
        private Bunifu.Framework.UI.BunifuTileButton btnTrain;
        private Bunifu.Framework.UI.BunifuTileButton btnHome;
    }
}
