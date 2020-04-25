namespace MachineLearningGames.Alihan
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
            this.btnTest = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnTrain = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnHome = new Bunifu.Framework.UI.BunifuImageButton();
            this.pbGame = new System.Windows.Forms.PictureBox();
            this.lblGameName = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
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
            this.transitionTabs.SetDecoration(this.btnTest, BunifuAnimatorNS.DecorationType.None);
            this.btnTest.Image = ((System.Drawing.Image)(resources.GetObject("btnTest.Image")));
            this.btnTest.ImageActive = null;
            this.btnTest.Location = new System.Drawing.Point(1083, 0);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(133, 123);
            this.btnTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnTest.TabIndex = 5;
            this.btnTest.TabStop = false;
            this.btnTest.Zoom = 10;
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.Transparent;
            this.transitionTabs.SetDecoration(this.btnTrain, BunifuAnimatorNS.DecorationType.None);
            this.btnTrain.Image = ((System.Drawing.Image)(resources.GetObject("btnTrain.Image")));
            this.btnTrain.ImageActive = null;
            this.btnTrain.Location = new System.Drawing.Point(933, 0);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(133, 123);
            this.btnTrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnTrain.TabIndex = 4;
            this.btnTrain.TabStop = false;
            this.btnTrain.Zoom = 10;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.transitionTabs.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageActive = null;
            this.btnHome.Location = new System.Drawing.Point(784, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(133, 123);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnHome.TabIndex = 3;
            this.btnHome.TabStop = false;
            this.btnHome.Zoom = 10;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.btnTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BunifuAnimatorNS.BunifuTransition transitionTabs;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblGameName;
        private System.Windows.Forms.PictureBox pbGame;
        private System.Windows.Forms.Panel pnlBottom;
        private Bunifu.Framework.UI.BunifuImageButton btnTest;
        private Bunifu.Framework.UI.BunifuImageButton btnTrain;
        private Bunifu.Framework.UI.BunifuImageButton btnHome;
    }
}
