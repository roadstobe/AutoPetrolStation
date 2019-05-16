using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AZS
{
    public partial class MainForm : Form
    {
        List<Petrol> petrols = new List<Petrol>();
        List<Bill> bills = new List<Bill>();
        public MainForm()
        {
            InitializeComponent();
        }
        public MainForm(List<Petrol>petrol)
        {
            petrols = petrol;
            InitializeComponent();
            comboBoxPetrol.DataSource = this.petrols;
            comboBoxPetrol.DisplayMember = "Name";
            comboBoxPetrol.ValueMember = "Price";
            comboBoxPetrol.SelectedIndex = 1;
            radioButtonCount.Checked = true;
            //FillPetrolList();
            //comboBoxPetrol.Sorted = true;
        }
        void FillPetrolList()
        {
            foreach (var item in petrols)
            {
                comboBoxPetrol.Items.Add(item);
            }
        }

        private void ComboBoxPetrol_SelectedIndexChanged(object sender, EventArgs e)
        {
            pricePetrol.Text = $"{comboBoxPetrol.SelectedValue}";
        }

        private void RadioButtonCount_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCount.Checked == true)
            {
                priceCount.Enabled = true;
                priceAmoung.Enabled = false;
            }
            else
            {
                priceCount.Enabled = false;
                priceAmoung.Enabled = true;
            }
            if (priceAmoung.Enabled == false)
            {
                priceAmoung.Text = "";
                labelLiters.Text = "";
                labelLiter.Text = "";
            }
            else
            {
                priceCount.Text = "";
                labelLiters.Text = "";
                labelLiter.Text = "";
            }
        }

        private void PriceCount_TextChanged(object sender, EventArgs e)
        {
            double count;
            double.TryParse(priceCount.Text, out count);
            double price;
            double.TryParse(pricePetrol.Text, out price);
            double amount = count * price;
            labelBill.Text = $"{amount}";
        }

        private void PriceAmoung_TextChanged(object sender, EventArgs e)
        {
            double count;
            double.TryParse(priceAmoung.Text, out count);
            double price;
            double.TryParse(pricePetrol.Text, out price);
            double amount = count / price;
            amount = System.Math.Round(amount, 3);
            labelLiters.Text = amount.ToString();
            labelLiter.Text = "Літрів:";
            labelBill.Text = $"{count}";
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (sender as CheckBox);
            if (check.Checked == true)
            {
                priceHotDoc.Enabled = true;
            }
            else
            {
                priceHotDoc.Enabled = false;
                priceHotDoc.Text = "";
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (sender as CheckBox);
            if (check.Checked == true)
                priceGamburger.Enabled = true;
            else
            {
                priceGamburger.Enabled = false;
                priceGamburger.Text = "";
            }
                
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (sender as CheckBox);
            if (check.Checked == true)
                pricePotato.Enabled = true;
            else
            {
                pricePotato.Enabled = false;
                pricePotato.Text = "";
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox check = (sender as CheckBox);
            if (check.Checked == true)
                priceCocaCola.Enabled = true;
            else
            {
                priceCocaCola.Text = "";
                priceCocaCola.Enabled = false;
            }
        }

        private void PriceHotDoc_TextChanged(object sender, EventArgs e)
        {
            double tmp;
            double.TryParse(priceHotDoc.Text, out tmp);
            double price = double.Parse(HotDocPrice.Text);
            double tmpBill = tmp * price;
            AmountHotDog.Text = $"{tmpBill}";
        }

        private void PriceGamburger_TextChanged(object sender, EventArgs e)
        {
            double tmp;
            double.TryParse(priceGamburger.Text, out tmp);
            double price = double.Parse(Gamburger.Text);
            double tmpBill = tmp * price;
            AnountHambur.Text = $"{tmpBill}";
        }

        private void PricePotato_TextChanged(object sender, EventArgs e)
        {
            double tmp;
            double.TryParse(pricePotato.Text, out tmp);
            double price = double.Parse(Potato.Text);
            double tmpBill = tmp * price;
            AmountPotato.Text = $"{tmpBill}";
        }

        private void PriceCocaCola_TextChanged(object sender, EventArgs e)
        {
            double tmp;
            double.TryParse(priceCocaCola.Text, out tmp);
            double price = double.Parse(CocaCola.Text);
            double tmpBill = tmp * price;
            AmountCocaCola.Text = $"{tmpBill}";
        }
        private void Amount(object sender, EventArgs e)
        {
            double bill = 0;
            double hotdoc, hamb, potat, coca;
            double hotdoc1 = 0, hamb1, potato1, coca1;
            double.TryParse(priceHotDoc.Text, out hotdoc);
            double.TryParse(HotDocPrice.Text, out hotdoc1);
            double.TryParse(priceGamburger.Text, out hamb);
            double.TryParse(Gamburger.Text, out hamb1);
            double.TryParse(pricePotato.Text, out potat);
            double.TryParse(Potato.Text, out potato1);
            double.TryParse(priceCocaCola.Text, out coca);
            double.TryParse(CocaCola.Text, out coca1);
            bill = (hotdoc * hotdoc1) + (hamb * hamb1) + (potat * potato1) + (coca * coca1);
            labelBillCafe.Text = $"{bill}";
        }

        private void LabelBill_TextChanged(object sender, EventArgs e)
        {
            double cafe, petrol;
            double.TryParse(labelBillCafe.Text, out cafe);
            double.TryParse(labelBill.Text, out petrol);
            double bill = cafe + petrol;
            Bill.Text = $"{bill}";
        }

    }
    
}
