using System;
using System.Data.Common;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class AbstractFactoryExample : Form
    {
        public AbstractFactoryExample()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database database;
            if (oleDBDatabase.Checked)
            {
                database = new SqlServerDatabase();
            }
            else
            {
                database = new OleDBDatabase();
            }

            DbCommand command = database.Command;

            //command.CommandType = Text;
            //command.CommandText = "Select * from Employes";
            //command.Connection.Open();
            //DbDataReader reader = command.ExecuteReader();

            //reader.Close();
            //command.Connection.Close();

        }
    }
}
