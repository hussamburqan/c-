namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                var std = new Student()
                {
                    FirstName = textBox1.Text,
                    LastName = textBox2.Text
                };
                context.Students.Add(std);

                context.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                dataGridView1.DataSource = context.Students.ToList();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                Student stud = context.Students.Where(s => s.StudentId == Int32.Parse(textBox4.Text)).Single();

                stud.FirstName = textBox3.Text;

                context.SaveChanges();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            using (var context = new SchoolContext())
            {
                Student stud = context.Students.Where(s => s.StudentId == Int32.Parse(textBox5.Text)).Single();
                context.Students.Remove(stud);
                context.SaveChanges();
            }
        }
    }
}
