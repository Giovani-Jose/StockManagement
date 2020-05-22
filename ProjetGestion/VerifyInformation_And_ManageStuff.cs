using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestion
{
    public class VerifyInformation_And_ManageStuff : ClientUserControl
    {

         public bool IsLoginTextfieldEmpty(string LoginName, string Password)
         {
             if (LoginName== ""|| Password=="")
             {
                 MessageBox.Show("Veuillez remplir les champs", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;

             }


             return true;
         }
         public bool IsAddClientTextfieldEmpty(string FirstName, string LastName,string country, string city, string cellNumber,string address, string mail )
         {
             if (FirstName == "Prenom" || FirstName=="" || LastName == "Nom" || LastName=="" || country=="Pays"|| country=="" || 
                 city=="Ville" ||city=="" || cellNumber=="Telephone" || cellNumber=="" || address=="Adresse"||address==""|| mail=="Email"||mail=="")
             {
                 MessageBox.Show("Veuillez remplir les champs", "Champ vide", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;

             }

             return true;
         }

        public void GetCurrentMenuFormInstance(ref MenuForm CurrentFormOpen)
        {
            CurrentFormOpen.CallDisplayData();
        }



    }
}
