using Bloggers;

namespace BloggersClient
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();

        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            var dataManager = new DataManager();
            var bloggers = dataManager.GetBloggers();
            dataGridView1.DataSource = bloggers;
        }

        private void InsertBlogger_Click(object sender, EventArgs e)
        {
            bool rezult = false;
            var dataManager = new DataManager();
            int id = Convert.ToInt32(textBoxId.Text);
            string? name = Convert.ToString(textBoxName.Text);
            string? post = Convert.ToString(textBoxPost.Text);

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBoxId.Text)
                {
                    rezult = true;
                    break;
                }
            }
            if (rezult)
            {
                MessageBox.Show("Такой номер уже существует");
                textBoxId.Text = null;
            }

            else if (!rezult && String.IsNullOrEmpty(name) || String.IsNullOrEmpty(post))
            {
                MessageBox.Show("Заполните все данные");
            }

            else
            {
                dataManager.InsertBlogger(id, name, post);
                var bloggers = dataManager.GetBloggers();
                dataGridView1.DataSource = bloggers;
                textBoxId.Text = null;
                textBoxName.Text = null;
                textBoxPost.Text = null;
            }
        }
        private void DeleteBlogger_Click(object sender, EventArgs e)
        {
            bool rezult = false;
            var dataManager = new DataManager();
            int id = Convert.ToInt32(textBoxId.Text);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBoxId.Text)
                {
                    rezult = true;
                    break;
                }
            }
            if (rezult)
            {
                dataManager.DeleteBlogger(id);
                var bloggers = dataManager.GetBloggers();
                dataGridView1.DataSource = bloggers;
                textBoxId.Text = null;
            }
            else
            {
                MessageBox.Show("Такого номера не существует");
                textBoxId.Text = null;
            }
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            {
                return;
            }
            textBoxId.Text = null;
            e.Handled = true;
        }
    }


}