using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MahnoorFinalvpl
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Adhesive Bandages")
            { txtprice.Text = "5"; }
            else if (comboBox1.SelectedItem.ToString() == "Crepe Bandages")
            { txtprice.Text = "30"; }
            else if (comboBox1.SelectedItem.ToString() == "Scissors")
            { txtprice.Text = "150"; }
            else if (comboBox1.SelectedItem.ToString() == "Safety Pin Box")
            { txtprice.Text = "10"; }
            else if (comboBox1.SelectedItem.ToString() == "Alcohol Swabs")
            { txtprice.Text = "15"; }
            else if (comboBox1.SelectedItem.ToString() == "Sticky Tape")
            { txtprice.Text = "35"; }
            else if (comboBox1.SelectedItem.ToString() == "Saline Solution")
            { txtprice.Text = "100"; }
            else if (comboBox1.SelectedItem.ToString() == "Thermometer")
            { txtprice.Text = "130"; }
            else if (comboBox1.SelectedItem.ToString() == "Tweezers")
            { txtprice.Text = "90"; }
            //vitamins
            else if (comboBox1.SelectedItem.ToString() == "Vitamin A")
            { txtprice.Text = "200"; }
            else if (comboBox1.SelectedItem.ToString() == "Vitamin B")
            { txtprice.Text = "300"; }
            else if (comboBox1.SelectedItem.ToString() == "Vitamin C")
            { txtprice.Text = "999"; }
            else if (comboBox1.SelectedItem.ToString() == "Vitamin D")
            { txtprice.Text = "700"; }
            else if (comboBox1.SelectedItem.ToString() == "Vitamin E")
            { txtprice.Text = "70"; }
            else if (comboBox1.SelectedItem.ToString() == "Multivitamins")
            { txtprice.Text = "500"; }
            //protein
            else if (comboBox1.SelectedItem.ToString() == "Whey Protein Powder")
            { txtprice.Text = "1300"; }
            else if (comboBox1.SelectedItem.ToString() == "Casein Protein Powder")
            { txtprice.Text = "2000"; }
            else if (comboBox1.SelectedItem.ToString() == "Vegan Protein Powder")
            { txtprice.Text = "3000"; }
            else if (comboBox1.SelectedItem.ToString() == "Refreshing Protein Shake")
            { txtprice.Text = "4000"; }
            // diapers
            else if (comboBox1.SelectedItem.ToString() == "Kids Diaper Small")
            { txtprice.Text = "20"; }
            else if (comboBox1.SelectedItem.ToString() == "Kids Diaper Medium")
            { txtprice.Text = "40"; }
            else if (comboBox1.SelectedItem.ToString() == "Kids Diaper Large")
            { txtprice.Text = "50"; }
            else if (comboBox1.SelectedItem.ToString() == "Adult Diaper")
            { txtprice.Text = "60"; }
            //medical devices
            else if (comboBox1.SelectedItem.ToString() == "Stethoscope")
            { txtprice.Text = "2220"; }
            else if (comboBox1.SelectedItem.ToString() == "Nebulizer")
            { txtprice.Text = "4000"; }
            else if (comboBox1.SelectedItem.ToString() == "Blood Pressure Monitor")
            { txtprice.Text = "7000"; }
            else if (comboBox1.SelectedItem.ToString() == "Blood Glucose Monitor")
            { txtprice.Text = "5000"; }
            //hair care
            else if (comboBox1.SelectedItem.ToString() == "Hair Oil")
            { txtprice.Text = "200"; }
            else if (comboBox1.SelectedItem.ToString() == "Dry Shampoo")
            { txtprice.Text = "900"; }
            else if (comboBox1.SelectedItem.ToString() == "Shampoo")
            { txtprice.Text = "550"; }
            // nail
            else if (comboBox1.SelectedItem.ToString() == "Cuticle Oil")
            { txtprice.Text = "700"; }
            else if (comboBox1.SelectedItem.ToString() == "Nail Paint Remover")
            { txtprice.Text = "80"; }
            //skin
            else if (comboBox1.SelectedItem.ToString() == "Body Moisturizer")
            { txtprice.Text = "750"; }
            else if (comboBox1.SelectedItem.ToString() == "Sanitizer")
            { txtprice.Text = "300"; }
            else if (comboBox1.SelectedItem.ToString() == "Sunblock")
            { txtprice.Text = "1700"; }
            else if (comboBox1.SelectedItem.ToString() == "Soap")
            { txtprice.Text = "80"; }
            else if (comboBox1.SelectedItem.ToString() == "Body Wash")
            { txtprice.Text = "850"; }
            //cold
            else if (comboBox1.SelectedItem.ToString() == "Cold Medicine")
            { txtprice.Text = "90"; }
            else if (comboBox1.SelectedItem.ToString() == "Cough Medicine")
            { txtprice.Text = "180"; }
            else if (comboBox1.SelectedItem.ToString() == "Fever Medicine")
            { txtprice.Text = "240"; }
            else if (comboBox1.SelectedItem.ToString() == "Anti Allergy")
            { txtprice.Text = "480"; }
            //oral
            else if (comboBox1.SelectedItem.ToString() == "Toothpaste")
            { txtprice.Text = "170"; }
            else if (comboBox1.SelectedItem.ToString() == "Dental Floss")
            { txtprice.Text = "50"; }
            else if (comboBox1.SelectedItem.ToString() == "Mouth Wash")
            { txtprice.Text = "400"; }
            else if (comboBox1.SelectedItem.ToString() == "Tooth Brush")
            { txtprice.Text = "85"; }
            else { txtprice.Text = "0"; }
            txtquantity.Text = "";
            txttotal.Text = "";
        }

        private void rbtfirstaid_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Adhesive Bandages");
            comboBox1.Items.Add("Crepe Bandages");
            comboBox1.Items.Add("Scissors");
            comboBox1.Items.Add("Safety Pin Box");
            comboBox1.Items.Add("Alcohol Swabs");
            comboBox1.Items.Add("Sticky Tape");
            comboBox1.Items.Add("Saline Solution");
            comboBox1.Items.Add("Thermometer");
            comboBox1.Items.Add("Tweezers");
        }

        private void rbtvitamins_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Vitamin A");
            comboBox1.Items.Add("Vitamin B");
            comboBox1.Items.Add("Vitamin C");
            comboBox1.Items.Add("Vitamin D");
            comboBox1.Items.Add("Vitamin E");
            comboBox1.Items.Add("Multivitamins");
        }

        private void rbtproteins_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Whey Protein Powder");
            comboBox1.Items.Add("Casein Protein Powder");
            comboBox1.Items.Add("Vegan Protein Powder");
            comboBox1.Items.Add("Refreshing Protein Shake");
        }

        private void rbtdevices_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Stethoscope");
            comboBox1.Items.Add("Nebulizer");
            comboBox1.Items.Add("Blood Pressure Monitor");
            comboBox1.Items.Add("Blood Glucose Monitor");
        }

        private void rbtdiapers_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Kids Diaper Small");
            comboBox1.Items.Add("Kids Diaper Medium");
            comboBox1.Items.Add("Kids Diaper Large");
            comboBox1.Items.Add("Adult Diaper");
        }

        private void rbtcold_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Cold Medicine");
            comboBox1.Items.Add("Cough Medicine");
            comboBox1.Items.Add("Fever Medicine");
            comboBox1.Items.Add("Anti Allergy");
        }

        private void rbtskin_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Body Moisturizer");
            comboBox1.Items.Add("Sunblock");
            comboBox1.Items.Add("Sanitizer");
            comboBox1.Items.Add("Soap");
            comboBox1.Items.Add("Body Wash");
        }

        private void rbthair_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Hair Oil");
            comboBox1.Items.Add("Dry Shampoo");
            comboBox1.Items.Add("Shampoo");
        }

        private void rbtnail_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Cuticle Oil");
            comboBox1.Items.Add("Nail Paint Remover");
        }

        private void rbtoral_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Toothpaste");
            comboBox1.Items.Add("Mouth Wash");
            comboBox1.Items.Add("Tooth Brush");
            comboBox1.Items.Add("Dental Floss");
        }

        private void txtquantity_TextChanged(object sender, EventArgs e)
        {
            if (txtquantity.TextLength > 0)
            {
                txttotal.Text = (Convert.ToInt16(txtprice.Text) * Convert.ToInt16(txtquantity.Text)).ToString();
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            arr[0] = comboBox1.SelectedItem.ToString();
            arr[1] = txtprice.Text;
            arr[2] = txtquantity.Text;
            arr[3] = txttotal.Text;
            ListViewItem l = new ListViewItem(arr);
            listView1.Items.Add(l);

            txtsubtotal.Text = (Convert.ToInt16(txtsubtotal.Text) + Convert.ToInt16(txttotal.Text)).ToString();

        }

        private void btcheck_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }
    }
}
