using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEContact
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnListContact_Click(object sender, EventArgs e)
        {
            //Effacer l'affichage du panel
            pContent.Controls.Clear();
            //instanciation de l'objet 
            frmListContact frmlstc =new frmListContact();
            //Position ou dimension de l'affichage(plein écran)
            frmlstc.Dock = DockStyle.Fill;
            //Ajout du panel ave l'objet 
            pContent.Controls.Add(frmlstc);
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            pContent.Controls.Clear();
            frmAddContact frmAdd = new frmAddContact();
            frmAdd.Dock = DockStyle.Fill;
            pContent.Controls.Add(frmAdd);
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            btnListContact_Click(sender, e);
        }
    }
}
