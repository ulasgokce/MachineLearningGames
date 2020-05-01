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
            this.panel = new System.Windows.Forms.Panel();
            this.btnStartTrain = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblItemCount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDataCount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlList = new System.Windows.Forms.Panel();
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
            this.itemListSurvived = new System.Windows.Forms.ListBox();
            this.pnlSurvived = new System.Windows.Forms.Panel();
            this.pnlNotSurvived = new System.Windows.Forms.Panel();
            this.itemListNotSurvived = new System.Windows.Forms.ListBox();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.pnlSurvived.SuspendLayout();
            this.pnlNotSurvived.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.Controls.Add(this.bunifuDropdown1);
            this.panel.Controls.Add(this.bunifuCustomLabel1);
            this.panel.Controls.Add(this.btnStartTrain);
            this.panel.Controls.Add(this.lblItemCount);
            this.panel.Controls.Add(this.lblDataCount);
            this.panel.Controls.Add(this.btnAdd);
            this.panel.Controls.Add(this.pnlList);
            this.panel.Controls.Add(this.txtTickerFare);
            this.panel.Controls.Add(this.txtAge);
            this.panel.Controls.Add(this.drpEmbarked);
            this.panel.Controls.Add(this.drpGender);
            this.panel.Controls.Add(this.drpTicketClass);
            this.panel.Controls.Add(this.lblEmbarked);
            this.panel.Controls.Add(this.lblTicketFare);
            this.panel.Controls.Add(this.lblParentOrChildren);
            this.panel.Controls.Add(this.txtParentOrChildren);
            this.panel.Controls.Add(this.lblSiblingsOrSpouse);
            this.panel.Controls.Add(this.txtSiblingsOrSpouse);
            this.panel.Controls.Add(this.lblAge);
            this.panel.Controls.Add(this.lblGender);
            this.panel.Controls.Add(this.lblTicketClass);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.ForeColor = System.Drawing.Color.Coral;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(2000, 745);
            this.panel.TabIndex = 0;
            // 
            // btnStartTrain
            // 
            this.btnStartTrain.ActiveBorderThickness = 1;
            this.btnStartTrain.ActiveCornerRadius = 20;
            this.btnStartTrain.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnStartTrain.ActiveForecolor = System.Drawing.Color.White;
            this.btnStartTrain.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnStartTrain.BackColor = System.Drawing.Color.Transparent;
            this.btnStartTrain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartTrain.BackgroundImage")));
            this.btnStartTrain.ButtonText = "EĞİTİMİ BAŞLAT";
            this.btnStartTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTrain.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTrain.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnStartTrain.IdleBorderThickness = 1;
            this.btnStartTrain.IdleCornerRadius = 20;
            this.btnStartTrain.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnStartTrain.IdleForecolor = System.Drawing.Color.Orange;
            this.btnStartTrain.IdleLineColor = System.Drawing.Color.Orange;
            this.btnStartTrain.Location = new System.Drawing.Point(1586, 244);
            this.btnStartTrain.Margin = new System.Windows.Forms.Padding(5);
            this.btnStartTrain.Name = "btnStartTrain";
            this.btnStartTrain.Size = new System.Drawing.Size(319, 67);
            this.btnStartTrain.TabIndex = 9;
            this.btnStartTrain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStartTrain.Click += new System.EventHandler(this.btnStartTrain_Click);
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblItemCount.Location = new System.Drawing.Point(180, 279);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(31, 32);
            this.lblItemCount.TabIndex = 24;
            this.lblItemCount.Text = "0";
            // 
            // lblDataCount
            // 
            this.lblDataCount.AutoSize = true;
            this.lblDataCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDataCount.Location = new System.Drawing.Point(27, 279);
            this.lblDataCount.Name = "lblDataCount";
            this.lblDataCount.Size = new System.Drawing.Size(160, 32);
            this.lblDataCount.TabIndex = 23;
            this.lblDataCount.Text = "Veri sayısı :";
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
            this.btnAdd.Location = new System.Drawing.Point(1586, 167);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(319, 67);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.pnlNotSurvived);
            this.pnlList.Controls.Add(this.pnlSurvived);
            this.pnlList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlList.Location = new System.Drawing.Point(0, 336);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(2000, 409);
            this.pnlList.TabIndex = 21;
            // 
            // txtTickerFare
            // 
            this.txtTickerFare.BackColor = System.Drawing.Color.Silver;
            this.txtTickerFare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTickerFare.BackgroundImage")));
            this.txtTickerFare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtTickerFare.ForeColor = System.Drawing.Color.Black;
            this.txtTickerFare.Icon = ((System.Drawing.Image)(resources.GetObject("txtTickerFare.Icon")));
            this.txtTickerFare.Location = new System.Drawing.Point(1019, 138);
            this.txtTickerFare.Margin = new System.Windows.Forms.Padding(10);
            this.txtTickerFare.Name = "txtTickerFare";
            this.txtTickerFare.Size = new System.Drawing.Size(282, 43);
            this.txtTickerFare.TabIndex = 6;
            this.txtTickerFare.text = "";
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Silver;
            this.txtAge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAge.BackgroundImage")));
            this.txtAge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtAge.ForeColor = System.Drawing.Color.Black;
            this.txtAge.Icon = ((System.Drawing.Image)(resources.GetObject("txtAge.Icon")));
            this.txtAge.Location = new System.Drawing.Point(204, 138);
            this.txtAge.Margin = new System.Windows.Forms.Padding(10);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(282, 43);
            this.txtAge.TabIndex = 3;
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
            this.drpEmbarked.Margin = new System.Windows.Forms.Padding(4);
            this.drpEmbarked.Name = "drpEmbarked";
            this.drpEmbarked.NomalColor = System.Drawing.Color.Silver;
            this.drpEmbarked.onHoverColor = System.Drawing.Color.White;
            this.drpEmbarked.selectedIndex = 0;
            this.drpEmbarked.Size = new System.Drawing.Size(282, 43);
            this.drpEmbarked.TabIndex = 7;
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
            this.drpGender.Margin = new System.Windows.Forms.Padding(4);
            this.drpGender.Name = "drpGender";
            this.drpGender.NomalColor = System.Drawing.Color.Silver;
            this.drpGender.onHoverColor = System.Drawing.Color.White;
            this.drpGender.selectedIndex = 0;
            this.drpGender.Size = new System.Drawing.Size(282, 43);
            this.drpGender.TabIndex = 2;
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
            this.drpTicketClass.Margin = new System.Windows.Forms.Padding(4);
            this.drpTicketClass.Name = "drpTicketClass";
            this.drpTicketClass.NomalColor = System.Drawing.Color.Silver;
            this.drpTicketClass.onHoverColor = System.Drawing.Color.White;
            this.drpTicketClass.selectedIndex = 0;
            this.drpTicketClass.Size = new System.Drawing.Size(282, 43);
            this.drpTicketClass.TabIndex = 1;
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
            this.txtParentOrChildren.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtParentOrChildren.BackgroundImage")));
            this.txtParentOrChildren.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtParentOrChildren.ForeColor = System.Drawing.Color.Black;
            this.txtParentOrChildren.Icon = ((System.Drawing.Image)(resources.GetObject("txtParentOrChildren.Icon")));
            this.txtParentOrChildren.Location = new System.Drawing.Point(1019, 85);
            this.txtParentOrChildren.Margin = new System.Windows.Forms.Padding(10);
            this.txtParentOrChildren.Name = "txtParentOrChildren";
            this.txtParentOrChildren.Size = new System.Drawing.Size(282, 43);
            this.txtParentOrChildren.TabIndex = 5;
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
            this.txtSiblingsOrSpouse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtSiblingsOrSpouse.BackgroundImage")));
            this.txtSiblingsOrSpouse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtSiblingsOrSpouse.ForeColor = System.Drawing.Color.Black;
            this.txtSiblingsOrSpouse.Icon = ((System.Drawing.Image)(resources.GetObject("txtSiblingsOrSpouse.Icon")));
            this.txtSiblingsOrSpouse.Location = new System.Drawing.Point(1019, 34);
            this.txtSiblingsOrSpouse.Margin = new System.Windows.Forms.Padding(10);
            this.txtSiblingsOrSpouse.Name = "txtSiblingsOrSpouse";
            this.txtSiblingsOrSpouse.Size = new System.Drawing.Size(282, 43);
            this.txtSiblingsOrSpouse.TabIndex = 4;
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
            // itemListSurvived
            // 
            this.itemListSurvived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.itemListSurvived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListSurvived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemListSurvived.FormattingEnabled = true;
            this.itemListSurvived.ItemHeight = 18;
            this.itemListSurvived.Location = new System.Drawing.Point(0, 0);
            this.itemListSurvived.Name = "itemListSurvived";
            this.itemListSurvived.Size = new System.Drawing.Size(1000, 409);
            this.itemListSurvived.TabIndex = 0;
            // 
            // pnlSurvived
            // 
            this.pnlSurvived.Controls.Add(this.itemListSurvived);
            this.pnlSurvived.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSurvived.Location = new System.Drawing.Point(0, 0);
            this.pnlSurvived.Name = "pnlSurvived";
            this.pnlSurvived.Size = new System.Drawing.Size(1000, 409);
            this.pnlSurvived.TabIndex = 0;
            // 
            // pnlNotSurvived
            // 
            this.pnlNotSurvived.Controls.Add(this.itemListNotSurvived);
            this.pnlNotSurvived.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlNotSurvived.Location = new System.Drawing.Point(1000, 0);
            this.pnlNotSurvived.Name = "pnlNotSurvived";
            this.pnlNotSurvived.Size = new System.Drawing.Size(1000, 409);
            this.pnlNotSurvived.TabIndex = 1;
            // 
            // itemListNotSurvived
            // 
            this.itemListNotSurvived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.itemListNotSurvived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListNotSurvived.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.itemListNotSurvived.FormattingEnabled = true;
            this.itemListNotSurvived.ItemHeight = 18;
            this.itemListNotSurvived.Location = new System.Drawing.Point(0, 0);
            this.itemListNotSurvived.Name = "itemListNotSurvived";
            this.itemListNotSurvived.Size = new System.Drawing.Size(1000, 409);
            this.itemListNotSurvived.TabIndex = 1;
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDropdown1.Items = new string[] {
        "Hayatta kaldı",
        "Hayatta kalamadı"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(1666, 93);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.Silver;
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.White;
            this.bunifuDropdown1.selectedIndex = 0;
            this.bunifuDropdown1.Size = new System.Drawing.Size(282, 43);
            this.bunifuDropdown1.TabIndex = 25;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(1471, 101);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(192, 29);
            this.bunifuCustomLabel1.TabIndex = 26;
            this.bunifuCustomLabel1.Text = "Gideceğiniz yer :";
            // 
            // TitanicTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Name = "TitanicTrain";
            this.Size = new System.Drawing.Size(2000, 745);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlSurvived.ResumeLayout(false);
            this.pnlNotSurvived.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
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
        private System.Windows.Forms.Panel pnlList;
        private Bunifu.Framework.UI.BunifuTextbox txtTickerFare;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuCustomLabel lblItemCount;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDataCount;
        private Bunifu.Framework.UI.BunifuThinButton2 btnStartTrain;
        private System.Windows.Forms.Panel pnlNotSurvived;
        private System.Windows.Forms.ListBox itemListNotSurvived;
        private System.Windows.Forms.Panel pnlSurvived;
        private System.Windows.Forms.ListBox itemListSurvived;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}
