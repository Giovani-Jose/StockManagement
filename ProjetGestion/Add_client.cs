using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProjetGestion
{
    public partial class Add_client : UserControl
    {
        public Add_client()
        {
            InitializeComponent();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (Nom.Text == "Nom")
            {
                Nom.Text = "";
                Nom.ForeColor = Color.White;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (Adresse.Text == "Adresse")
            {
                Adresse.Text = "";
                Adresse.ForeColor = Color.White;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (Pays.Text == "Pays")
            {
                Pays.Text = "";
                Pays.ForeColor = Color.White;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (Prenom.Text == "Prenom")
            {
                Prenom.Text = "";
                Prenom.ForeColor = Color.White;
            }
        }

    
        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (Telephone.Text == "Telephone")
            {
                Telephone.Text = "";
                Telephone.ForeColor = Color.White;
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (Mail.Text == "Email")
            {
                Mail.Text = "";
                Mail.ForeColor = Color.White;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (Ville.Text == "Ville")
            {
                Ville.Text = "";
                Ville.ForeColor = Color.White;
            }
        }

        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
            DataAccess InsertDatatoBdd = new DataAccess();
          
            VerifyInformation_And_ManageStuff Ifempty = new VerifyInformation_And_ManageStuff();
            string prenom = "", nom = "", pays = "", ville = "", adresse = "", mail = "", telephone = "";



            prenom = Prenom.Text;
            nom = Nom.Text;
            pays = Pays.Text;
            ville = Ville.Text;
            telephone = Telephone.Text;
            adresse = Adresse.Text;
            mail = Mail.Text;

            if (!Ifempty.IsAddClientTextfieldEmpty(prenom,nom,pays,ville,Telephone.Text,adresse,mail))
            {
                return;
            }
            else
            {

               InsertDatatoBdd.AddClientToBdd(ref prenom, ref nom, ref pays, ref ville, ref telephone, ref adresse, ref mail);
                MessageBox.Show("Enregistrement reussi", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                this.Hide();

              ResetTextboxContains();
            
            }


        }

        private void Telephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void ResetTextboxContains()
        {
            int i = 0;
            i += 1;
            Prenom.Text = "Prenom";
            Prenom.ForeColor = Color.DarkGray;
            Nom.Text = "Nom";
            Nom.ForeColor = Color.DarkGray;

            Pays.Text = "Pays";
            Pays.ForeColor = Color.DarkGray;

            Ville.Text = "Ville";
           Ville.ForeColor = Color.DarkGray;

            Telephone.Text = "Telephone";
            Telephone.ForeColor = Color.DarkGray;

            Adresse.Text = "Adresse";
            Adresse.ForeColor = Color.DarkGray;

            Mail.Text = "Email";
            Mail.ForeColor = Color.DarkGray;
        }

    }
}
