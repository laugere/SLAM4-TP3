using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MusicAtoutV1
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void Btn_villes_Click(object sender, EventArgs e)
        {
            Form Fa = new FVilles();
            Fa.Show();
        }

        private void FrmAccueil_Load(object sender, EventArgs e)
        {

        }

        private void Btn_salles_Click(object sender, EventArgs e)
        {
            Form Fa = new FSalle();
            Fa.Show();
        }

        private void Btn_batiments_Click(object sender, EventArgs e)
        {
            Form Fa = new FBat();
            Fa.Show();
        }

        private void Btn_oeuvres_Click(object sender, EventArgs e)
        {
            Form Fa = new FOeuvre();
            Fa.Show();
        }
    }
}
