using JobTo.Win.Forms.Register;
using System;
using System.Windows.Forms;

namespace JobTo.Win.Forms.Main
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void clientsMenu_Click(object sender, EventArgs e)
        {
            var page = new TabPage();
            page.Text = "Cadastro de clientes";
            page.Name = "tabRegisterClient";
            page.Tag = "tab_register_client";

            page.Controls.Add(new ControlRegisterClient());

            GoToPage(page);
        }

        private void menuEmployers_Click(object sender, EventArgs e)
        {
            var page = new TabPage
            {
                Text = "Cadastro de funcionários",
                Tag = "tab_register_employee",
                Name = "tabRegisterEmployee"
            };
            page.Controls.Add(new ControlRegisterEmployee());

            GoToPage(page);
        }

        private void GoToPage(TabPage page)
        {
            if (!tabMain.TabPages.ContainsKey(page.Name))
                tabMain.TabPages.Add(page);

            tabMain.SelectTab(page.Name);
        }
    }
}
