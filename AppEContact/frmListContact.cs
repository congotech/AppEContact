using AppEContact.Models;
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
    public partial class frmListContact : UserControl
    {
        public frmListContact()
        {
            InitializeComponent();
        }

        private void frmListContact_Load(object sender, EventArgs e)
        {
            BindingList<Contact> lst = new BindingList<Contact>(DBContact.GetListContacts());
            dtgContact.DataSource = lst;
            dtgContact.AutoResizeColumns();
            dtgContact.AllowUserToResizeColumns = true;
            dtgContact.AllowUserToResizeRows = true;
        }
    }
}
