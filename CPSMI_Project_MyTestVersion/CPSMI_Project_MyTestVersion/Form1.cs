using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPSMI_Project_MyTestVersion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void organizationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.organizationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cPSMI_Project_DatabaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cPSMI_Project_DatabaseDataSet.Education". При необходимости она может быть перемещена или удалена.
            this.educationTableAdapter.Fill(this.cPSMI_Project_DatabaseDataSet.Education);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cPSMI_Project_DatabaseDataSet.Education". При необходимости она может быть перемещена или удалена.
            this.educationTableAdapter.Fill(this.cPSMI_Project_DatabaseDataSet.Education);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cPSMI_Project_DatabaseDataSet.Languages". При необходимости она может быть перемещена или удалена.
            this.languagesTableAdapter.Fill(this.cPSMI_Project_DatabaseDataSet.Languages);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cPSMI_Project_DatabaseDataSet.Languages". При необходимости она может быть перемещена или удалена.
            this.languagesTableAdapter.Fill(this.cPSMI_Project_DatabaseDataSet.Languages);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cPSMI_Project_DatabaseDataSet.Work". При необходимости она может быть перемещена или удалена.
            this.workTableAdapter.Fill(this.cPSMI_Project_DatabaseDataSet.Work);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cPSMI_Project_DatabaseDataSet.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this.cPSMI_Project_DatabaseDataSet.Personal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cPSMI_Project_DatabaseDataSet.Organization". При необходимости она может быть перемещена или удалена.
            this.organizationTableAdapter.Fill(this.cPSMI_Project_DatabaseDataSet.Organization);

        }
    }
}
