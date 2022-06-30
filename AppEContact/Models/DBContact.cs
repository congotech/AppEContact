using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEContact.Models
{
    public static class DBContact
    {
        public static List<Contact> lsContact;
        //Ajouter un contact à la liste des contacts
        public static int AddContact(Contact c)
        {
            if(lsContact == null)
            {
                lsContact = new List<Contact>();
            }
            c.Id = lsContact.Any() ? lsContact.Max(x => x.Id) + 1 : 100; //Expression lambda
            lsContact.Add(c);
            return c.Id;
        }

        //Récupérer la liste des contacts
        public static List<Contact> GetListContacts()
        {
            return lsContact;   
        }

        //Supprimer un Contact
        public static void DeleteContact(int idContact)
        {
            int index = lsContact.FindIndex(x=>x.Id==idContact);
            lsContact.RemoveAt(index);
        }

        //Modifier un contact
        public static void UpdateContact(Contact c)
        {
            Contact sear = lsContact.FirstOrDefault(x=>x.Id == c.Id);
            sear.NomComplet = c.NomComplet;
            sear.DateNaiss = c.DateNaiss;
            sear.Email = c.Email;
            sear.Genre = c.Genre;
            sear.Photo = c.Photo;
            sear.Tel = c.Tel;
        }

        //Chercher par nom
        public static List<Contact> ResearchContact(string name)
        {
            List<Contact> res = lsContact.Where(x => x.NomComplet.ToLower().Contains(name.ToLower())).ToList();
            return res;
        }
    }
}
