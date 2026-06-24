
namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            listView1.Items.Add("Яблоко");
            listView1.Items.Add("Банан");
            listView1.Items.Add("Апельсин");
            listView1.Items.Add("Груша");
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите элемент!");
                return;
            }

           
            string text = listView1.SelectedItems[0].Text;

           
            if (string.IsNullOrEmpty(label1.Text))
                label1.Text = text;
            else if (string.IsNullOrEmpty(label2.Text))
                label2.Text = text;
            else if (string.IsNullOrEmpty(label3.Text))
                label3.Text = text;
            else
            {
                MessageBox.Show("Все Label заняты!");
                return;
            }

           
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
    }
}