using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        const double Price_Bottlewater = 10;
        const double Price_Fries = 15;
        const double Price_Salad = 20;
        const double Price_Hamburger = 53;
        const double Price_Onionrings = 30;
        const double Price_Chickensalad = 47;
        const double Price_Fishsandwish = 72;
        const double Price_Cheesesandwish = 33;
        const double Price_Chickensandwish = 40;
        const double Price_Hashbrown = 60;
        const double Price_Toestedbagel = 22.5;
        const double Price_Pinapplestick = 23;
        const double Price_Chocolatemuffin = 63;
        const double Price_Pancakessyrup = 32.5;
        const double Price_Tea = 8;
        const double Price_Cola = 10;
        const double Price_Orange = 23;
        const double Price_Vanillacone = 17;
        const double Price_Vanillashake = 32;
        const double Price_Strewberyshake = 34.5;
        const double Price_Chocolatemilkshake = 36.5;
        const double Price_Coffe = 22;
        const double Tax_Rate = 14;


        double iTax, iSubTotal, iTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit =
            MessageBox.Show("Confirm you want to Exit the System", "Fast Food", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        private void RestCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[22];

            itemcost[0] = Convert.ToDouble(textBox1.Text) * Price_Fries;
            itemcost[1] = Convert.ToDouble(textBox7.Text) * Price_Salad;
            itemcost[2] = Convert.ToDouble(textBox6.Text) * Price_Hamburger;
            itemcost[3] = Convert.ToDouble(textBox5.Text) * Price_Onionrings;
            itemcost[4] = Convert.ToDouble(textBox4.Text) * Price_Chickensalad;
            itemcost[5] = Convert.ToDouble(textBox8.Text) * Price_Fishsandwish;
            itemcost[6] = Convert.ToDouble(textBox3.Text) * Price_Cheesesandwish;
            itemcost[7] = Convert.ToDouble(textBox2.Text) * Price_Chickensandwish;
            itemcost[8] = Convert.ToDouble(textBox22.Text) * Price_Hashbrown;
            itemcost[9] = Convert.ToDouble(textBox20.Text) * Price_Toestedbagel;
            itemcost[10] = Convert.ToDouble(textBox21.Text) * Price_Pinapplestick;
            itemcost[11] = Convert.ToDouble(textBox19.Text) * Price_Chocolatemuffin;
            itemcost[12] = Convert.ToDouble(textBox18.Text) * Price_Pancakessyrup;
            itemcost[13] = Convert.ToDouble(textBox13.Text) * Price_Tea;
            itemcost[14] = Convert.ToDouble(textBox11.Text) * Price_Bottlewater;
            itemcost[15] = Convert.ToDouble(textBox9.Text) * Price_Cola;
            itemcost[16] = Convert.ToDouble(textBox12.Text) * Price_Orange;
            itemcost[17] = Convert.ToDouble(textBox17.Text) * Price_Vanillacone;
            itemcost[18] = Convert.ToDouble(textBox15.Text) * Price_Vanillashake;
            itemcost[19] = Convert.ToDouble(textBox16.Text) * Price_Strewberyshake;
            itemcost[20] = Convert.ToDouble(textBox14.Text) * Price_Chocolatemilkshake;
            itemcost[21] = Convert.ToDouble(textBox10.Text) * Price_Coffe;
            double cost ,ichange;
            if (comboBox1.Text == "Cash")
            {

                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] +
                itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12]
               + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] +
                itemcost[19] + itemcost[20] + itemcost[21];


                textBox25.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                textBox27.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                textBox24.Text = Convert.ToString(iTotal);
                ichange = Convert.ToDouble(textBox23.Text);
                cost = ichange - (iTax + iTotal) ;


                textBox26.Text = Convert.ToString(cost);

               //textBox26.Text = String.Format("{0:C}", cost);
               //textBox27.Text = String.Format("{0:C}", iTax);
               //textBox25.Text = String.Format("{0:C}", iSubTotal);
               //textBox24.Text = String.Format("{0:C}", iTotal);


            }
            else
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] +
               itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12]
              + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] +
               itemcost[19] + itemcost[20] + itemcost[21];


                textBox25.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                textBox27.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                textBox24.Text = Convert.ToString(iTotal);
                


                textBox27.Text = String.Format("{0:C}", iTax);
                textBox25.Text = String.Format("{0:C}", iSubTotal);
                textBox24.Text = String.Format("{0:C}", iTotal);
            }
        }


        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {

                textBox4.Enabled = true;
                textBox4.Text = "";
                textBox4.Focus();

            }
            else
            {

                textBox4.Enabled = false;
                textBox4.Text = "0";

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cash")
            {

                textBox23.Enabled = true;
                textBox23.Text = "";
                textBox23.Focus();
            }






            else
            {
                textBox23.Enabled = false;
                textBox23.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(" ");
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Master Card");
            comboBox1.Items.Add("Visa Card");
            comboBox1.Items.Add("Debit Card");
            EnableTextBoxes();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox1.Checked == true)
            {

                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox1.Focus();

            }
            else
            {

                textBox1.Enabled = false;
                textBox1.Text = "0";

            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {

                textBox7.Enabled = true;
                textBox7.Text = "";
                textBox7.Focus();

            }
            else
            {

                textBox7.Enabled = false;
                textBox7.Text = "0";

            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {

                textBox6.Enabled = true;
                textBox6.Text = "";
                textBox6.Focus();

            }
            else
            {

                textBox6.Enabled = false;
                textBox6.Text = "0";

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {

                textBox5.Enabled = true;
                textBox5.Text = "";
                textBox5.Focus();

            }
            else
            {

                textBox5.Enabled = false;
                textBox5.Text = "0";

            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {

                textBox8.Enabled = true;
                textBox8.Text = "";
                textBox8.Focus();

            }
            else
            {

                textBox8.Enabled = false;
                textBox8.Text = "0";

            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {

                textBox3.Enabled = true;
                textBox3.Text = "";
                textBox3.Focus();

            }
            else
            {

                textBox3.Enabled = false;
                textBox3.Text = "0";

            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {

                textBox2.Enabled = true;
                textBox2.Text = "";
                textBox2.Focus();

            }
            else
            {

                textBox2.Enabled = false;
                textBox2.Text = "0";

            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true)
            {

                textBox22.Enabled = true;
                textBox22.Text = "";
                textBox22.Focus();

            }
            else
            {

                textBox22.Enabled = false;
                textBox22.Text = "0";

            }
        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {

                textBox20.Enabled = true;
                textBox20.Text = "";
                textBox20.Focus();

            }
            else
            {

                textBox20.Enabled = false;
                textBox20.Text = "0";

            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {

                textBox21.Enabled = true;
                textBox21.Text = "";
                textBox21.Focus();

            }
            else
            {

                textBox21.Enabled = false;
                textBox21.Text = "0";

            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {

                textBox19.Enabled = true;
                textBox19.Text = "";
                textBox19.Focus();

            }
            else
            {

                textBox19.Enabled = false;
                textBox19.Text = "0";

            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {

                textBox18.Enabled = true;
                textBox18.Text = "";
                textBox18.Focus();

            }
            else
            {

                textBox18.Enabled = false;
                textBox18.Text = "0";

            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {

                textBox13.Enabled = true;
                textBox13.Text = "";
                textBox13.Focus();

            }
            else
            {

                textBox13.Enabled = false;
                textBox13.Text = "0";

            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {

                textBox9.Enabled = true;
                textBox9.Text = "";
                textBox9.Focus();

            }
            else
            {

                textBox9.Enabled = false;
                textBox9.Text = "0";

            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox11.Checked == true)
            {

                textBox10.Enabled = true;
                textBox10.Text = "";
                textBox10.Focus();

            }
            else
            {

                textBox10.Enabled = false;
                textBox10.Text = "0";

            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox10.Checked == true)
            {

                textBox12.Enabled = true;
                textBox12.Text = "";
                textBox12.Focus();

            }
            else
            {

                textBox12.Enabled = false;
                textBox12.Text = "0";

            }
        }

        private void checkBox9_CheckedChanged_1(object sender, EventArgs e)
        {

            if (checkBox9.Checked == true)
            {

                textBox11.Enabled = true;
                textBox11.Text = "";
                textBox11.Focus();

            }
            else
            {

                textBox11.Enabled = false;
                textBox11.Text = "0";

            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox17.Checked == true)
            {

                textBox17.Enabled = true;
                textBox17.Text = "";
                textBox17.Focus();

            }
            else
            {

                textBox17.Enabled = false;
                textBox17.Text = "0";

            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox16.Checked == true)
            {

                textBox15.Enabled = true;
                textBox15.Text = "";
                textBox15.Focus();

            }
            else
            {

                textBox15.Enabled = false;
                textBox15.Text = "0";

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox15.Checked == true)
            {

                textBox16.Enabled = true;
                textBox16.Text = "";
                textBox16.Focus();

            }
            else
            {

                textBox16.Enabled = false;
                textBox16.Text = "0";

            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox14.Checked == true)
            {

                textBox14.Enabled = true;
                textBox14.Text = "";
                textBox14.Focus();

            }
            else
            {

                textBox14.Enabled = false;
                textBox14.Text = "0";

            }
        }

    }
}



