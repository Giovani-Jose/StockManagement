using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetGestion
{
    public partial class ClientUserControl : UserControl
    {
        public ClientUserControl()
        {
            InitializeComponent();
            add_client1.Hide();

        }

        private void SearchText_Enter(object sender, EventArgs e)
        {
            if (SearchText.Text == "Recherche")
            {
                SearchText.Text = "";
            }
        }

        private void AddClientBtn_Click(object sender, EventArgs e)
        {
            add_client1.Show();

            

        }

        public void DisplayData()

        {
           
            DataAccess ShowData = new DataAccess();
            List<string> GetData = new List<string>();

            // GetData use to Get data from bdd to display it in the datagridview
            ShowData.GetClientInformation(GetData);
            // GetUserId to pass it into the row number in datagridview, the next line after that just convert this string value to int to pass it 
            var GetUserId= GetData.ElementAt(0);
            int userId = Int32.Parse(GetUserId);

            ClientData.Rows.Add();
           // According to the bdd the number of cells data is 6.
            for (int j = 0; j <= 6; j++)
            {
                try
                {
                    // userId - 1 cause the row begin with 0, though Id in bdd begin with 1 so we have decrement this value
                    //J+1 cause Cell only begin with 1
                    ClientData.Rows[userId-1].Cells[j+1].Value = GetData.ElementAt(j+1);
                   Console.WriteLine(GetData.ElementAt(6));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                    return;
                }
            }
            

            
            
            
           

            
            /*for (int i = 1; i <= count; i++)
             {
                 Console.WriteLine(i);
     

             }*/

        }

       
    }
}
