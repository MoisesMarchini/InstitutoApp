using InstitutoApp.Forms;
using InstitutoApp.Forms.Menus;
using InstitutoApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoApp
{
    public partial class MainForm : Form
    {
        public static MenusEnum menusEnum;
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void ClickBtn(object btnSender)
        {
            foreach (Control item in MenuPanel.Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    if (item != btnSender)
                    {
                        item.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                        item.BackColor = Color.FromArgb(51, 51, 76);
                    }
                    else
                    {
                        item.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular, GraphicsUnit.Point);
                        item.BackColor = HeaderPanel.BackColor;
                    }
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ClickBtn(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(childForm);
            ContentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblHeader.Text = childForm.Text;
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                OpenChildForm(new Menu1(), sender);
                menusEnum = MenusEnum.Btn1;
                return;
            }
            if (sender == button2)
            {
                OpenChildForm(new Menu2(), sender);
                menusEnum = MenusEnum.Btn2;
                return;
            }
            if (sender == button3)
            {
                OpenChildForm(new Menu3(), sender);
                menusEnum = MenusEnum.Btn3;
                return;
            }
            if (sender == button4)
            {
                OpenChildForm(new Menu4(), sender);
                menusEnum = MenusEnum.Btn4;
                return;
            }
            if (sender == button5)
            {
                MessageBox.Show("Texto do botão5");
                return;
            }
        }
    }
}
