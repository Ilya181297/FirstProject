using Bloggers;
using Bloggers.Models;

namespace BloggersClient
{
    public partial class fmMain : Form
    {
        private bool _isEdit = false;
        private Blogger _selectedBlogger => dataGridView1.SelectedRows.Count > 0
            ? dataGridView1.SelectedRows[0].DataBoundItem as Blogger : null;
        private DataManager _dataManager = new DataManager();

        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            Refresh();
        }
        private void ClearFields()
        {
            textBoxId.Text = null;
            textBoxName.Text = null;
            textBoxPost.Text = null;
        }
        private void Refresh()
        {
            dataGridView1.DataSource = _dataManager.GetBloggers();

        }

        private void InsertBlogger_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            string? name = textBoxName.Text;
            string? post = textBoxPost.Text;

            if (!_isEdit)
            {
                bool rezult = false;
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
                    return;
                }

                if (!rezult && string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(post))
                {
                    MessageBox.Show("Заполните все данные");
                    return;
                }

                    _dataManager.InsertBlogger(id, name, post);
                    Refresh();
                    ClearFields();
                return;
            }

            _dataManager.UpdateBlogger(id, name, post);
            Refresh();

            InsertBlogger.Text = "Добавить";
            button1.Visible = false;
            _isEdit = false;
            ClearFields();
        }
        private void DeleteBlogger_Click(object sender, EventArgs e)
        {
            var deleteBloger = _selectedBlogger;
            if (deleteBloger is null)
            {
                MessageBox.Show("Выберите блога сэр");
                return;
            }
            var rezult = MessageBox.Show("Вы действительно хотите удалить блогера?", "Подтверждение", MessageBoxButtons.YesNo);
            if (rezult != DialogResult.Yes)
                return;
            _dataManager.DeleteBlogger(deleteBloger.Id);
            Refresh();
            ClearFields();
        }

        private void textBoxId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',')
            {
                return;
            }
            textBoxId.Text = null;
            e.Handled = true;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBoxId.Text = Convert.ToString(_selectedBlogger.Id);
            textBoxName.Text = Convert.ToString(_selectedBlogger.Name);
            textBoxPost.Text = Convert.ToString(_selectedBlogger.Post);
        }

        private void textBoxId_TextChanged_1(object sender, EventArgs e)
        {
            if (textBoxId.Text != Convert.ToString(_selectedBlogger.Id))
            {
                return;
            }
            if ((textBoxId.Text == Convert.ToString(_selectedBlogger.Id)) 
                && (textBoxName.Text == Convert.ToString(_selectedBlogger.Name))
                  && (textBoxPost.Text == Convert.ToString(_selectedBlogger.Post)))
            {
                _isEdit = false;
                button1.Visible = false;
                InsertBlogger.Text = "Добавить";
                return;
            }
            _isEdit = true;
            button1.Visible = true;
            InsertBlogger.Text = "Сохранить";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearFields();
            button1.Visible = false;
            InsertBlogger.Text = "Добавить";
        }
    }
}