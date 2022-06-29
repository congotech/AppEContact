using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEContact.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string NomComplet { get; set; }
        public DateTime DateNaiss { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Genre { get; set; }
        public string UrlPhoto { get; set; }

        public Contact(string nomComplet, DateTime dateNaiss, string email, string tel, string genre, string urlPhoto)
        {
            NomComplet = nomComplet;
            DateNaiss = dateNaiss;
            Email = email;
            Tel = tel;
            Genre = genre;
            UrlPhoto = urlPhoto;
        }

        //COnstructor default
        public Contact()
        {

        }
    }
}
