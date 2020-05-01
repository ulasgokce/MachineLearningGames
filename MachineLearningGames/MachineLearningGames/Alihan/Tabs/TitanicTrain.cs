﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.Alihan.Entity;
using MachineLearningGames.Alihan.Utilities;
using MachineLearningGames.Alihan.Validation.FluentValidation;

namespace MachineLearningGames.Alihan.Tabs
{
    public partial class TitanicTrain : UserControl
    {
        public TitanicTrain()
        {
            InitializeComponent();
        }

        private int itemCount = 0;

        private void btnStartTrain_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer
                {
                    Age = Convert.ToInt32(txtAge.text),
                    Embarked = drpEmbarked.selectedValue,
                    Gender = drpGender.selectedValue,
                    ParentOrChildren = Convert.ToInt32(txtParentOrChildren.text),
                    SiblingsOrSpouse = Convert.ToInt32(txtSiblingsOrSpouse.text),
                    TicketClass = Convert.ToInt32(drpTicketClass.selectedValue),
                    TicketFare = Convert.ToInt32(txtTickerFare.text)
                };
                ValidationTool.Validate(new DataValidator(), customer);

                itemList.Items.Add("Bilet Sınıfı : " + drpTicketClass.selectedValue +
                                   "  Cinsiyet : " + drpGender.selectedValue +
                                   "  Yaş : " + txtAge.text +
                                   "  Kardeş ya da eş sayısı : " + txtSiblingsOrSpouse.text +
                                   "  Ebeveyn ya da çocuk sayısı : " + txtParentOrChildren.text +
                                   "  Bilet ücreti : " + txtTickerFare.text +
                                   "  Gideceğiniz yer : " + drpEmbarked.selectedValue);
                itemList.Items.Add(
                    "----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                itemCount++;
                lblItemCount.Text = itemCount.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
          
        }


    }
}