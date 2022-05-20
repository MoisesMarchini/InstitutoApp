using InstitutoApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoApp.Forms.Menus
{
    public partial class Servicos : Form
    {
        private Service service;
        private Doctor doctor;
        public Servicos()
        {
            InitializeComponent();
        }

        private void Servicos_Load(object sender, EventArgs e)
        {
            service = new Service();
            doctor = new Doctor();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
