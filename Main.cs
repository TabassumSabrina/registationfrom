using System;
using System.Collections.Generic
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginR
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name, dob, gender, email, address, courses, payment;
            long phone;
            name = textBox1.Text;
            dob = textBox2.Text;
            email = textBox3.Text;
            address = richTextBox1.Text;
            paymode = domainUpDown1.SelectedItem.ToString();
            if (radioButton1.Checked == true)
                gender = radioButton1.Text;
            else if (radioButton2.Checked == true)
                gender = radioButton2.Text;
            if (checkBox1.Checked == true)
                courses = checkBox1.Text;
            else if (checkBox2.Checked == true)
                courses = checkBox2.Text;
            else if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
                courses = "Bangla and English";
            else if ((checkBox1.Checked == true) && (checkBox3.Checked == true))
                courses = "Bangla and Math";           
            else if ((checkBox2.Checked == true) && (checkBox3.Checked == true))
                courses = "English and Math are selected";
            else
                courses = checkBox3.Text;
            phone=long.Parse(textBox3.Text);
            MessageBox.Show("Name:"+name"\nDOB:"+dob+"\nGender:"+gender"\nEmail Id:"+email+"address:"+address+"\nCourses selected:"+courses+"\nPobile:"+phone+"\nPayment selected:"+payment);                                                                                                                                                                                                                          
                                                                                                                                                                                                                                                                                                  
        

        }
    }
}
