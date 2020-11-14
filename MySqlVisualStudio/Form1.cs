using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient; 

namespace MySqlVisualStudio
{
    public partial class Form1 : Form
    {
        public MySqlConnection conex = new MySqlConnection("server=localhost; user id=root; password=Furipapa86jo");
        public Form1()
        {
            InitializeComponent();
            try
            {
                conex.Open();
                MessageBox.Show("exito");
                conex.Close();
            }catch(Exception e)
            {
                MessageBox.Show("error" + e.Message);
            }
        }
    }
}
