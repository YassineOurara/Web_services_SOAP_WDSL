using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BanqueGraphInter


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ServiceReference1.BanqueServiceClient stub = new ServiceReference1.BanqueServiceClient();
        private void btnConversion_Click(object sender, EventArgs e)
        {
            double Montant = double.Parse(textBoxMT.Text);
            textBoxRes.Text = stub.Convert(Montant).ToString();
        }

        private void btnComptes_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            List<ServiceReference1.compte> cptes = stub.listComptes().ToList();

            var comptesList = new BindingList<ServiceReference1.compte>(cptes);

            dataGridView1.DataSource = comptesList;
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}






