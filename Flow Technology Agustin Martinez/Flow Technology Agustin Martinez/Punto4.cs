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

namespace Flow_Technology_Agustin_Martinez
{
    public partial class Punto4 : Form
    {
        private SqlConnection conexion = new SqlConnection("Data Source=Agustin; Initial Catalog=PruebaFlowTechnology; Integrated Security= true");
        public Punto4()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterData( (int) numericUpDown1.Value);
        }

        public void FilterData(int n)
        {
            conexion.Open();
            string sql = "select * from personas where edad>@edad order by edad";
            SqlCommand comando = new SqlCommand(sql, conexion);
            comando.Parameters.Add("@edad", SqlDbType.Int).Value = n;
            SqlDataReader registros = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            while (registros.Read())
            {
                dataGridView1.Rows.Add(registros["id"].ToString(), registros["nombre"].ToString(), registros["apellido"].ToString(), registros["edad"].ToString());
            }
            conexion.Close();
        }
    }
}
