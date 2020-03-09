using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReznikProgram
{
    public partial class MainForm : Form
    {
        DataBase data;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            data.closeConnection();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            data = new DataBase();
            string result = data.openConnection();
            if (result == null)
                MessageBox.Show("Подключение к базе успешно");
            else
            {
                MessageBox.Show(result);
                this.Close();
            }
        }
    }
}
