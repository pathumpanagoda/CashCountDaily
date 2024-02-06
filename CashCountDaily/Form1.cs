using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashCountDaily
{
    
    public partial class Form1 : Form
    {
        private int total = 0;

        public object Applicaton { get; private set; }

        public Form1()
        {
           /* InitializeComponent();

            // Set TabStop and TabIndex for TextBoxes in Form1.Designer.cs or in Form1_Load method
            textBox1.TabStop = true;
            textBox1.TabIndex = 1;

            textBox2.TabStop = true;
            textBox2.TabIndex = 2;

            // ... Repeat for other textboxes

            textBox8.TabStop = true;
            textBox8.TabIndex = 8;

            textBox9.TabStop = true;
            textBox9.TabIndex = 9;

            // ... Repeat for other textboxes

            textBox18.TabStop = true;
            textBox18.TabIndex = 18;  */

           // textBoxInput.TabStop = false; // Assuming textBoxInput is the last control you want to tab through


        }


        public void gTot()
        {
            int currentValue1 = int.Parse(totLbl1.Text);
            int currentValue2 = int.Parse(totLbl2.Text);
            int currentValue3 = int.Parse(totLbl3.Text);

            total = currentValue1 + currentValue2 + currentValue3;

            gTotal.Text = total.ToString() + ".00";
        }
        public void updateLabel1()
        {
            var val20 = 20 * int.Parse(textBox1.Text) ;
            var val50 = 50 * int.Parse(string.IsNullOrEmpty(textBox2.Text) ? "0" : textBox2.Text);
            var val100 = 100 * int.Parse(string.IsNullOrEmpty(textBox5.Text) ? "0" : textBox5.Text);
            var val500 = 500 * int.Parse(string.IsNullOrEmpty(textBox6.Text) ? "0" : textBox6.Text);
            var val1000 = 1000 * int.Parse(string.IsNullOrEmpty(textBox7.Text) ? "0" : textBox7.Text);
            var val5000 = 5000 * int.Parse(string.IsNullOrEmpty(textBox8.Text) ? "0" : textBox8.Text);

            label68.Text = "" + val20;
            label69.Text = "" + val50;
            label70.Text = "" + val100;
            label71.Text = "" + val500;
            label72.Text = "" + val1000;
            label73.Text = ""+ val5000;

            var tot1 = val20 + val50 + val100 + val500 + val1000 + val5000;
            totLbl1.Text = tot1.ToString();
             
            gTot(); // Update grand total
        }

        public void updateLabel2()
        {
            var vall20 = 20 * int.Parse(string.IsNullOrEmpty(textBox12.Text) ? "0" : textBox12.Text);
            var vall50 = 50 * int.Parse(string.IsNullOrEmpty(textBox11.Text) ? "0" : textBox11.Text);
            var vall100 = 100 * int.Parse(string.IsNullOrEmpty(textBox10.Text) ? "0" : textBox10.Text);
            var vall500 = 500 * int.Parse(string.IsNullOrEmpty(textBox9.Text) ? "0" : textBox9.Text);
            var vall1000 = 1000 * int.Parse(string.IsNullOrEmpty(textBox4.Text) ? "0" : textBox4.Text);
            var vall5000 = 5000 * int.Parse(string.IsNullOrEmpty(textBox3.Text) ? "0" : textBox3.Text);

            label30.Text = "" + vall20;
            label29.Text = "" + vall50;
            label28.Text = "" + vall100;
            label27.Text = "" + vall500;
            label26.Text = "" + vall1000;
            label25.Text = "" + vall5000;

            var tot2 = vall20 + vall50 + vall100 + vall500 + vall1000 + vall5000;
            totLbl2.Text = tot2.ToString();

            gTot(); // Update grand total

        }

        public void updateLabel3()
        {
            var valll20 = 20 * int.Parse(string.IsNullOrEmpty(textBox18.Text) ? "0" : textBox18.Text);
            var valll50 = 50 * int.Parse(string.IsNullOrEmpty(textBox17.Text) ? "0" : textBox17.Text);
            var valll100 = 100 * int.Parse(string.IsNullOrEmpty(textBox16.Text) ? "0" : textBox16.Text);
            var valll500 = 500 * int.Parse(string.IsNullOrEmpty(textBox15.Text) ? "0" : textBox15.Text);
            var valll1000 = 1000 * int.Parse(string.IsNullOrEmpty(textBox14.Text) ? "0" : textBox14.Text);
            var valll5000 = 5000 * int.Parse(string.IsNullOrEmpty(textBox13.Text) ? "0" : textBox13.Text);

            label59.Text = "" + valll20;
            label58.Text = "" + valll50;
            label57.Text = "" + valll100;
            label56.Text = "" + valll500;
            label55.Text = "" + valll1000;
            label54.Text = "" + valll5000;

            var tot3 = valll20 + valll50 + valll100 + valll500 + valll1000 + valll5000;
            totLbl3.Text = tot3.ToString();

            gTot(); // Update grand total

        }


        public void diffCal()
        {

        }
        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                updateLabel1();
                updateLabel2();
                updateLabel3();

            }
        }

        private void textBoxInput_Leave(object sender, EventArgs e)
        {
            updateLabel1();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            updateLabel1();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label68_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {
            updateLabel1();
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            updateLabel1();
        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {
            updateLabel1();
        }

        private void textBox7_TextChanged_1(object sender, EventArgs e)
        {
            updateLabel1();
        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            updateLabel1();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            updateLabel2();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            updateLabel2();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            updateLabel2();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            updateLabel2();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            updateLabel2();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            updateLabel2();
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            updateLabel3();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            updateLabel3();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            updateLabel3();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            updateLabel3();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            updateLabel3();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            updateLabel3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox12.Text = string.Empty;
            textBox11.Text = string.Empty;
            textBox10.Text = string.Empty;
            textBox9.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox18.Text = string.Empty;
            textBox17.Text = string.Empty;
            textBox16.Text = string.Empty;
            textBox15.Text = string.Empty;
            textBox14.Text = string.Empty;
            textBox13.Text = string.Empty;
        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void gTotal_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void sysAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //StreamWriter sw = new StreamWriter(@"C:\\cashcount\\Mytext.txt");

            string path = @"C:\\cashcount\\Mytext.txt";
            //File.Create(path);

            File.WriteAllText(path,  dateTimePicker1.Text + "\nTotal : "+ gTotal.Text + "\nSystem Total: " + sysAmount.Text + "\nDifferent : " + Diff.Text); 

            Console.ReadLine();
     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int SysTot = int.Parse(string.IsNullOrEmpty(sysAmount.Text) ? "0" : sysAmount.Text);

            int cred = int.Parse(string.IsNullOrEmpty(credit.Text) ? "0" : credit.Text);
            int oth = int.Parse(string.IsNullOrEmpty(other.Text) ? "0" : other.Text);

            int Diferent = (total - SysTot) - (cred+oth);
            Diff.Text = Diferent.ToString();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
