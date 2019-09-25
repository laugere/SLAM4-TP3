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
    public partial class FVilles : Form
    {
        private connectMusicAtout maConnexion;
        public FVilles()
        {
            InitializeComponent();

            maConnexion = new connectMusicAtout();

            bsVille.DataSource = maConnexion.VILLE.ToList();
        }

        private void FVilles_Load(object sender, EventArgs e)
        {

        }
    }
}
