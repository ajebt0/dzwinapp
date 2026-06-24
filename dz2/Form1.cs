
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
       
        private HashSet<string> removedItems = new HashSet<string>();

        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Введите текст!");
                return;
            }

            
            if (removedItems.Contains(text))
            {
                MessageBox.Show("Этот элемент был удалён и повторно добавить нельзя!");
                return;
            }

            listBox1.Items.Add(text);
            textBox1.Clear();
        }

        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите элемент для удаления!");
                return;
            }

            string selected = listBox1.SelectedItem.ToString();

            listBox1.Items.Remove(selected);

            removedItems.Add(selected);
        }

       
    }
}