using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace myBudget.DataAccess
{
    class DAL
    {

        public string serverConnectionString = Properties.Settings.Default.ServermyBudgetConnectionString;
        public string clientConnectionString = Properties.Settings.Default.ClientmyBudgetConnectionString;

        public bool canConnectToLiveDB()
        {

            using (SqlConnection cnn = new SqlConnection(serverConnectionString))
            {

                try
                {
                    cnn.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
                finally
                {
                    cnn.Close();
                }

            }
        }

    }
}
