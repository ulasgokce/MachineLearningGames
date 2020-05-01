using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineLearningGames.Alihan.Tabs
{
    public partial class TitanicTrain : UserControl
    {
        public TitanicTrain()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            itemList.Items.Add("Bilet Sınıfı : " + drpTicketClass.selectedValue +
                               "  Cinsiyet : " + drpGender.selectedValue +
                               "  Yaş : " + txtAge.text +
                               "  Kardeş ya da eş sayısı : " + txtSiblingsOrSpouse.text +
                               "  Ebeveyn ya da çocuk sayısı : " + txtParentOrChildren.text +
                               "  Bilet ücreti : " + txtTickerFare.text +
                               "  Gideceğiniz yer : " + drpEmbarked.selectedValue);
        }
    }
}
