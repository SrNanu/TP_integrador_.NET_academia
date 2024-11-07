using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class MenuAlumnos : Form
    {
        public MenuAlumnos()
        {
            InitializeComponent();
        }


        private void lknLogOut_Click(object sender, EventArgs e)
        {
            Login formLogin = new Login();

            formLogin.Show();

            formLogin.Activate();

            this.Dispose();
        }


    }
}
