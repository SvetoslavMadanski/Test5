using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studenti
{
    public partial class Form1 : Form
    {
        List<Person> Spisuk = new List<Person>();

        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                checkBox1.Checked = false;
                textBox6.Enabled = false;
                textBox7.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string birthDate = textBox3.Text;
            int years = 0;
            try { years = Int32.Parse(textBox4.Text); } catch { MessageBox.Show("Годината трябва да е число"); }

            string egn = textBox5.Text;
            string gender1 = comboBox1.Text;
            string faculty;
            string subject;

            if (checkBox1.CheckState == CheckState.Checked)
            {
                faculty = textBox6.Text;
                Spisuk.Add(new Student(firstName, lastName, birthDate, years, egn, gender1, faculty));
            }
                if (checkBox2.CheckState == CheckState.Checked)
            {
                subject = textBox7.Text;
                Spisuk.Add(new Teacher(firstName, lastName, birthDate, years, egn, gender1, subject));
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

            // za izchistvane na textBox

        }

        private void Ученик_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                checkBox2.Checked = false;
                textBox7.Enabled = false;
                textBox6.Enabled = true;
            }

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked) // ako e uchenik
            {
                foreach (Student Student in Spisuk)
                {
                    textBox8.Text = textBox8.Text + $"\n Име: {Student.firstName} Фамилия: {Student.lastName} Дата на раждане: {Student.birthDate} Години: {Student.years} ЕГН: {Student.egn} Фак. № {Student.faculty}";
                }
            }

            else if (checkBox2.CheckState == CheckState.Checked) // ako e uchitel
            {
                foreach (Teacher Teacher in Spisuk)
                {
                    textBox8.Text = textBox8.Text + $"\n Име: {Teacher.firstName} Фамилия: {Teacher.lastName} Дата на раждане: {Teacher.birthDate} Години: {Teacher.years} ЕГН: {Teacher.egn} Предмет: {Teacher.subject}";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Spisuk.Clear();
            textBox8.Text = "";

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    } 

}
