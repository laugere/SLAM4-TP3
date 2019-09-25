using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicAtoutV1
{
    public partial class FBat : Form
    {
        private connectMusicAtout maConnexion;
        public FBat()
        {
            InitializeComponent();

            maConnexion = new connectMusicAtout();

            bsBat.DataSource = maConnexion.BATIMENT.ToList();
        }

        private void FBat_Load(object sender, EventArgs e)
        {

        }
    }
}
