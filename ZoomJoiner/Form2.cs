using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZoomJoiner
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            MethodTime();
            label1.Text = "1. Гром.Освiта \n2. Алгебра\n3. Алгебра \n4. Укр.Лит \n5. Захист \n6. Физика \n7. Химия";
            button4.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            MethodTime();
            label1.Text = "1. Захист \n2. Алгебра \n3. Алгебра \n4. Физ-ра \n5. Мистецтво \n6. Право \n7. Физика \n8. Информ";
            button1.Enabled = true;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "1. 8.30 \n2. 9.25 \n3. 10.20\n4. 11.15 \n5. 12.10\n6. 13.05 \n7. 14.00 \n8. 15.00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            MethodTime();
            label1.Text = "1. Зар.Лит \n2. Геометрия \n3. Англ.яз \n4. Физ-ра \n5. История \n6. Укр.мова \n7. Биология";
            button2.Enabled = true;
        }

        void MethodTime()
        {
            var t = Task.Delay(250); // in ms
            t.Wait();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            MethodTime();
            label1.Text = "1. Зар.Лит \n2. Алгебра \n3. История \n4. Англ.яз \n5. География \n6. Геометрия \n7. Физика";
            button3.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            MethodTime();
            label1.Text = "1. Укр.Яз \n2. Физ-ра \n3. Укр.Лит \n4. География \n5. Англ.Яз \n6. Биология \n7. Геометрия";
            button5.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
