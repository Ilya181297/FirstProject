using Bloggers;
using Bloggers.Models;
using DAL;

namespace BloggersClient
{
    public partial class fmMain : Form
    {
        private IDataManager _dataManager = new DataManager();
        private bool _isEdit = false;

        private Blogger? _selectedBlogger => dgvBloggers.SelectedRows.Count > 0
            ? dgvBloggers.SelectedRows[0].DataBoundItem as Blogger : null;

        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            RefreshDataSource();
        }

        private void ClearFields()
        {
            textBoxId.Text = null;
            textBoxName.Text = null;
            textBoxPost.Text = null;
        }

        private void RefreshDataSource()
        {
            dgvBloggers.DataSource = _dataManager.GetBloggers();
        }

        private void btnNewBlogger_Click(object sender, EventArgs e)
        {
            ClearFields();
            _isEdit = false;
            btnDelete.Enabled = false;
            btnSave.Enabled = true;
        }

        private void DeleteBlogger_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить блогера?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return;

            _dataManager.DeleteBlogger(_selectedBlogger.Id);
            RefreshDataSource();
            // ClearFields();
        }

        private void textBoxes_Changed(object sender, EventArgs e)
        {
            var selectedBlogger = _selectedBlogger;
            if (selectedBlogger is null)
                return;

            if (selectedBlogger.Name != textBoxName.Text
                || selectedBlogger.Post != textBoxPost.Text)
            {
                btnSave.Enabled = true;
                return;
            }

            btnSave.Enabled = false;
        }

        private void dgvBloggers_SelectionChanged(object sender, EventArgs e)
        {
            var selectedBlogger = _selectedBlogger;
            if (selectedBlogger is null)
            {
                ClearFields();
                btnDelete.Enabled = false;
                return;
            }

            _isEdit = true;
            btnDelete.Enabled = true;

            textBoxId.Text = selectedBlogger.Id.ToString();
            textBoxName.Text = selectedBlogger.Name;
            textBoxPost.Text = selectedBlogger.Post;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckFields())
            {
                MessageBox.Show("Заполните обязательные поля, Сэр", "Валидация", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Сохранить данные?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            if (_isEdit)
                _dataManager.UpdateBlogger(Convert.ToInt32(textBoxId.Text), textBoxName.Text, textBoxPost.Text);
            else
                _dataManager.InsertBlogger(textBoxName.Text, textBoxPost.Text);

            RefreshDataSource();
        }

        private bool CheckFields()
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text)
                || string.IsNullOrWhiteSpace(textBoxPost.Text))
                return default;

            return true;
        }
    }
}