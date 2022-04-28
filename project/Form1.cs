namespace project
{
    public partial class Form1 : Form
    {
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
       // private void btnReset_Click(object sender, EventArgs e)
        
            
        


           // private void btnReset_Click(object sender, EventArgs e)
            
                
            




                private void button1_Click(object sender, EventArgs e)
                {

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

                }

                private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
                {

                }
            }
        }

    

