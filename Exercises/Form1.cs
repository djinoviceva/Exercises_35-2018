using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection()) { 

                List<ExerciseResult> list = new List<ExerciseResult>();

            
            connection.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=FacultyDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection.Open();

            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT  *  FROM  ExerciseResults";

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {

                list.Add(new ExerciseResult(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetInt32(3)));
            }

            foreach (ExerciseResult x in list)
            {
                listBoxExerciseResults.Items.Add(x);
            }
            connection.Close();
        }

    }
}
    }

