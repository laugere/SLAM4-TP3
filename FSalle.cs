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
    public partial class FSalle : Form
    {
        private connectMusicAtout maConnexion;
        public FSalle()
        {
            InitializeComponent();

            maConnexion = new connectMusicAtout();

            bsSalle.DataSource = maConnexion.SALLE.ToList();
        }

        private void FSalle_Load(object sender, EventArgs e)
        {

        }
    }
}
