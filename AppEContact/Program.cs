using AppEContact.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEContact
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DBContact.AddContact(new Contact("Mohamed ali", DateTime.Parse("12/03/2000"), "mohamedali@gmail.com", "@6 54 45 67 00", "M", null));
            DBContact.AddContact(new Contact("Mohamed jahouid", DateTime.Parse("12/01/1984"), "jahoui@gmail.com", "@6 54 45 67 00", "M", null));
            DBContact.AddContact(new Contact("jamila jamal", DateTime.Parse("02/05/1987"), "jamila@gmail.com", "@6 54 45 67 00", "M", null));
            DBContact.AddContact(new Contact("zinab alami", DateTime.Parse("06/02/1984"), "zinab@gmail.com", "@6 54 45 67 00", "M", null));
            DBContact.AddContact(new Contact("khafid jawi", DateTime.Parse("05/03/2000"), "jawi@gmail.com", "@6 54 45 67 00", "M", null));
            DBContact.AddContact(new Contact("Mustapha jamal", DateTime.Parse("13/06/1984"), "jamalmohamedali@gmail.com", "@6 54 45 67 00", "M", null));
            DBContact.AddContact(new Contact("Sanae Iwali", DateTime.Parse("13/12/2000"), "sanae@gmail.com", "@6 54 45 67 00", "M", null));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenu());
        }
    }
}
