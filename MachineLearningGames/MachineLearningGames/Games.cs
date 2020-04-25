﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineLearningGames.Alihan;

namespace MachineLearningGames
{
    public partial class Games : UserControl
    {
        public Games()
        {
            InitializeComponent();
        }

        public Form main;

        private void btnSnap_Click(object sender, EventArgs e)
        {
            Snap snap = new Snap();
            snap.main = main;
            pnlMain.Controls.Clear();
            snap.Visible = false;
            pnlMain.Controls.Add(snap);
            transitionGames.ShowSync(snap);
        }

        private void btnSchoolLibrary_Click(object sender, EventArgs e)
        {
            SchoolLibrary school_library = new SchoolLibrary();
            school_library.main = main;
            pnlMain.Controls.Clear();
            school_library.Visible = false;
            pnlMain.Controls.Add(school_library);
            transitionGames.ShowSync(school_library);
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            Titanic titanic = new Titanic();
            titanic.main = main;
            pnlMain.Controls.Clear();
            titanic.Visible = false;
            pnlMain.Controls.Add(titanic);
            transitionGames.ShowSync(titanic);

        }
    }
}
