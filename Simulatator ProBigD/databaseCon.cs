using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

namespace Simulatator_ProBigD
{
    class databaseCon
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-9PI6981;Initial Catalog=SimulatatorData;Integrated Security=True");

        public void ManageTable(string command)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(command, con);
            int i = cmd.ExecuteNonQuery();
            if (i != 1)
            {
                DatabaseError de = new DatabaseError();
                de.ShowDialog();
            }
        }

    }
}
