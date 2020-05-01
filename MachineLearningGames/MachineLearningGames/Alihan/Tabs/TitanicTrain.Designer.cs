namespace MachineLearningGames.Alihan.Tabs
{
    partial class TitanicTrain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitanicTrain));
            this.pnlList = new System.Windows.Forms.Panel();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTickerFare = new Bunifu.Framework.UI.BunifuTextbox();
            this.txtAge = new Bunifu.Framework.UI.BunifuTextbox();
            this.drpEmbarked = new Bunifu.Framework.UI.BunifuDropdown();
            this.drpGender = new Bunifu.Framework.UI.BunifuDropdown();
            this.drpTicketClass = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblEmbarked = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTicketFare = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblParentOrChildren = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtParentOrChildren = new Bunifu.Framework.UI.BunifuTextbox();
            this.lblSiblingsOrSpouse = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSiblingsOrSpouse = new Bunifu.Framework.UI.BunifuTextbox();
            this.lblAge = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblGender = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTicketClass = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.itemList = new System.Windows.Forms.ListBox();
            this.pnlList.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.BackColor = System.Drawing.Color.Transparent;
            this.pnlList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlList.BackgroundImage")));
            this.pnlList.Controls.Add(this.btnAdd);
            this.pnlList.Controls.Add(this.panel2);
            this.pnlList.Controls.Add(this.txtTickerFare);
            this.pnlList.Controls.Add(this.txtAge);
            this.pnlList.Controls.Add(this.drpEmbarked);
            this.pnlList.Controls.Add(this.drpGender);
            this.pnlList.Controls.Add(this.drpTicketClass);
            this.pnlList.Controls.Add(this.lblEmbarked);
            this.pnlList.Controls.Add(this.lblTicketFare);
            this.pnlList.Controls.Add(this.lblParentOrChildren);
            this.pnlList.Controls.Add(this.txtParentOrChildren);
            this.pnlList.Controls.Add(this.lblSiblingsOrSpouse);
            this.pnlList.Controls.Add(this.txtSiblingsOrSpouse);
            this.pnlList.Controls.Add(this.lblAge);
            this.pnlList.Controls.Add(this.lblGender);
            this.pnlList.Controls.Add(this.lblTicketClass);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlList.ForeColor = System.Drawing.Color.Coral;
            this.pnlList.Location = new System.Drawing.Point(0, 0);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(2000, 745);
            this.pnlList.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "EKLE";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnAdd.IdleForecolor = System.Drawing.Color.Orange;
            this.btnAdd.IdleLineColor = System.Drawing.Color.Orange;
            this.btnAdd.Location = new System.Drawing.Point(1560, 114);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(319, 67);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.itemList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2000, 451);
            this.panel2.TabIndex = 21;
            // 
            // txtTickerFare
            // 
            this.txtTickerFare.BackColor = System.Drawing.Color.Silver;
            this.txtTickerFare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtTickerFare.ForeColor = System.Drawing.Color.Black;
            this.txtTickerFare.Icon = ((System.Drawing.Image)(resources.GetObject("txtTickerFare.Icon")));
            this.txtTickerFare.Location = new System.Drawing.Point(1019, 138);
            this.txtTickerFare.Margin = new System.Windows.Forms.Padding(10);
            this.txtTickerFare.Name = "txtTickerFare";
            this.txtTickerFare.Size = new System.Drawing.Size(282, 43);
            this.txtTickerFare.TabIndex = 20;
            this.txtTickerFare.text = "";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Silver;
            this.txtAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.Icon = ((System.Drawing.Image)(resources.GetObject("txtAge.Icon")));
            this.txtAge.Location = new System.Drawing.Point(204, 138);
            this.txtAge.Margin = new System.Windows.Forms.Padding(10);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(282, 43);
            this.txtAge.TabIndex = 19;
            this.txtAge.text = "";
            // 
            // drpEmbarked
            // 
            this.drpEmbarked.BackColor = System.Drawing.Color.Transparent;
            this.drpEmbarked.BorderRadius = 3;
            this.drpEmbarked.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drpEmbarked.DisabledColor = System.Drawing.Color.Gray;
            this.drpEmbarked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drpEmbarked.ForeColor = System.Drawing.Color.Black;
            this.drpEmbarked.Items = new string[] {
        "Cherbourg (France)",
        "Southampton (England)",
        "Queenstown (Ireland)"};
            this.drpEmbarked.Location = new System.Drawing.Point(1666, 42);
            this.drpEmbarked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drpEmbarked.Name = "drpEmbarked";
            this.drpEmbarked.NomalColor = System.Drawing.Color.Silver;
            this.drpEmbarked.onHoverColor = System.Drawing.Color.White;
            this.drpEmbarked.selectedIndex = -1;
            this.drpEmbarked.Size = new System.Drawing.Size(282, 43);
            this.drpEmbarked.TabIndex = 18;
            // 
            // drpGender
            // 
            this.drpGender.BackColor = System.Drawing.Color.Transparent;
            this.drpGender.BorderRadius = 3;
            this.drpGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drpGender.DisabledColor = System.Drawing.Color.Gray;
            this.drpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drpGender.ForeColor = System.Drawing.Color.Black;
            this.drpGender.Items = new string[] {
        "Erkek",
        "Kadın"};
            this.drpGender.Location = new System.Drawing.Point(204, 87);
            this.drpGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drpGender.Name = "drpGender";
            this.drpGender.NomalColor = System.Drawing.Color.Silver;
            this.drpGender.onHoverColor = System.Drawing.Color.White;
            this.drpGender.selectedIndex = -1;
            this.drpGender.Size = new System.Drawing.Size(282, 43);
            this.drpGender.TabIndex = 17;
            // 
            // drpTicketClass
            // 
            this.drpTicketClass.BackColor = System.Drawing.Color.Transparent;
            this.drpTicketClass.BorderRadius = 3;
            this.drpTicketClass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.drpTicketClass.DisabledColor = System.Drawing.Color.Gray;
            this.drpTicketClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.drpTicketClass.ForeColor = System.Drawing.Color.Black;
            this.drpTicketClass.Items = new string[] {
        "1",
        "2",
        "3"};
            this.drpTicketClass.Location = new System.Drawing.Point(204, 36);
            this.drpTicketClass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.drpTicketClass.Name = "drpTicketClass";
            this.drpTicketClass.NomalColor = System.Drawing.Color.Silver;
            this.drpTicketClass.onHoverColor = System.Drawing.Color.White;
            this.drpTicketClass.selectedIndex = -1;
            this.drpTicketClass.Size = new System.Drawing.Size(282, 43);
            this.drpTicketClass.TabIndex = 16;
            // 
            // lblEmbarked
            // 
            this.lblEmbarked.AutoSize = true;
            this.lblEmbarked.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmbarked.Location = new System.Drawing.Point(1471, 50);
            this.lblEmbarked.Name = "lblEmbarked";
            this.lblEmbarked.Size = new System.Drawing.Size(192, 29);
            this.lblEmbarked.TabIndex = 13;
            this.lblEmbarked.Text = "Gideceğiniz yer :";
            // 
            // lblTicketFare
            // 
            this.lblTicketFare.AutoSize = true;
            this.lblTicketFare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketFare.Location = new System.Drawing.Point(868, 138);
            this.lblTicketFare.Name = "lblTicketFare";
            this.lblTicketFare.Size = new System.Drawing.Size(138, 29);
            this.lblTicketFare.TabIndex = 11;
            this.lblTicketFare.Text = "Bilet ücreti :";
            // 
            // lblParentOrChildren
            // 
            this.lblParentOrChildren.AutoSize = true;
            this.lblParentOrChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParentOrChildren.Location = new System.Drawing.Point(690, 87);
            this.lblParentOrChildren.Name = "lblParentOrChildren";
            this.lblParentOrChildren.Size = new System.Drawing.Size(316, 29);
            this.lblParentOrChildren.TabIndex = 9;
            this.lblParentOrChildren.Text = "Ebeveyn ya da çocuk sayısı :";
            // 
            // txtParentOrChildren
            // 
            this.txtParentOrChildren.BackColor = System.Drawing.Color.Silver;
            this.txtParentOrChildren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtParentOrChildren.ForeColor = System.Drawing.Color.Black;
            this.txtParentOrChildren.Icon = ((System.Drawing.Image)(resources.GetObject("txtParentOrChildren.Icon")));
            this.txtParentOrChildren.Location = new System.Drawing.Point(1019, 85);
            this.txtParentOrChildren.Margin = new System.Windows.Forms.Padding(10);
            this.txtParentOrChildren.Name = "txtParentOrChildren";
            this.txtParentOrChildren.Size = new System.Drawing.Size(282, 43);
            this.txtParentOrChildren.TabIndex = 8;
            this.txtParentOrChildren.text = "";
            // 
            // lblSiblingsOrSpouse
            // 
            this.lblSiblingsOrSpouse.AutoSize = true;
            this.lblSiblingsOrSpouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiblingsOrSpouse.Location = new System.Drawing.Point(749, 36);
            this.lblSiblingsOrSpouse.Name = "lblSiblingsOrSpouse";
            this.lblSiblingsOrSpouse.Size = new System.Drawing.Size(257, 29);
            this.lblSiblingsOrSpouse.TabIndex = 7;
            this.lblSiblingsOrSpouse.Text = "Kardeş ya da eş sayısı:";
            // 
            // txtSiblingsOrSpouse
            // 
            this.txtSiblingsOrSpouse.BackColor = System.Drawing.Color.Silver;
            this.txtSiblingsOrSpouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSiblingsOrSpouse.ForeColor = System.Drawing.Color.Black;
            this.txtSiblingsOrSpouse.Icon = ((System.Drawing.Image)(resources.GetObject("txtSiblingsOrSpouse.Icon")));
            this.txtSiblingsOrSpouse.Location = new System.Drawing.Point(1019, 34);
            this.txtSiblingsOrSpouse.Margin = new System.Windows.Forms.Padding(10);
            this.txtSiblingsOrSpouse.Name = "txtSiblingsOrSpouse";
            this.txtSiblingsOrSpouse.Size = new System.Drawing.Size(282, 43);
            this.txtSiblingsOrSpouse.TabIndex = 6;
            this.txtSiblingsOrSpouse.text = "";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAge.Location = new System.Drawing.Point(131, 138);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(66, 29);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Yaş :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGender.Location = new System.Drawing.Point(87, 87);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(110, 29);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Cinsiyet :";
            // 
            // lblTicketClass
            // 
            this.lblTicketClass.AutoSize = true;
            this.lblTicketClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTicketClass.Location = new System.Drawing.Point(65, 36);
            this.lblTicketClass.Name = "lblTicketClass";
            this.lblTicketClass.Size = new System.Drawing.Size(132, 29);
            this.lblTicketClass.TabIndex = 1;
            this.lblTicketClass.Text = "Bilet Sınıfı :";
            // 
            // itemList
            // 
            this.itemList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.itemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemList.FormattingEnabled = true;
            this.itemList.ItemHeight = 29;
            this.itemList.Location = new System.Drawing.Point(0, 0);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(2000, 451);
            this.itemList.TabIndex = 0;
            // 
            // TitanicTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlList);
            this.Name = "TitanicTrain";
            this.Size = new System.Drawing.Size(2000, 745);
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAge;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGender;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTicketClass;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmbarked;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTicketFare;
        private Bunifu.Framework.UI.BunifuCustomLabel lblParentOrChildren;
        private Bunifu.Framework.UI.BunifuTextbox txtParentOrChildren;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSiblingsOrSpouse;
        private Bunifu.Framework.UI.BunifuTextbox txtSiblingsOrSpouse;
        private Bunifu.Framework.UI.BunifuDropdown drpEmbarked;
        private Bunifu.Framework.UI.BunifuDropdown drpGender;
        private Bunifu.Framework.UI.BunifuDropdown drpTicketClass;
        private Bunifu.Framework.UI.BunifuTextbox txtAge;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTextbox txtTickerFare;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private System.Windows.Forms.ListBox itemList;
    }
}
