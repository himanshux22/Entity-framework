using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

  


    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int mobile = int.Parse(textBox3.Text);

            StudentData st1 = new StudentData {

                Name=name,Mobile=mobile
            };

            StudentContext st = new StudentContext();
            st.StuData.Add(st1);
            st.SaveChanges();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int age = int.Parse(textBox2.Text);

            StudentContext st = new StudentContext();

            StudentData st1 = st.StuData.First(i => i.Age == age);
            st.StuData.Remove(st1);
            st.SaveChanges();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            int age = int.Parse(textBox2.Text);


            StudentContext st = new StudentContext();
            StudentData st2 = st.StuData.First(i=>i.Age==age);

            st2.Name = name;
            st.SaveChanges();

        }
    }
    public class StudentData
    {

        public string Name { get; set; }
        [Key]
        public int Age { get; set; }
        public int Mobile { get; set; }

    }

    public class StudentContext : DbContext
    {

        public DbSet<StudentData> StuData { get; set; }

    }
}
