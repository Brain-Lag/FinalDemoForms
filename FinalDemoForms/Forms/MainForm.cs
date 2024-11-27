using Data.Entities;
using Data.Repositories;
using System.Windows.Forms;

namespace FinalDemoForms
{
    public partial class MainForm : Form
    {
        private BaseRepo<Client> _repo = new();
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = _repo.GetAll();
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBoxName.Text)) || (string.IsNullOrEmpty(textBoxNumber.Text)) || (string.IsNullOrEmpty(textBoxLogin.Text)) || (string.IsNullOrEmpty(textBoxPassword.Text)))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var client = new Client()
            {
                ClientName = textBoxName.Text,
                ClientPhone = textBoxNumber.Text,
                ClientLogin = textBoxLogin.Text,
                ClientPassword = textBoxPassword.Text
            };
            _repo.Create(client);
            dataGridView1 .DataSource = _repo.GetAll();
            MessageBox.Show("Пользователь успешно добавлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            panelCreate.Visible = true;
            panelCreate.Enabled = true;
            panelEdit.Visible = false;
            panelEdit.Enabled = false;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panelCreate.Visible=false;
            panelCreate.Enabled=false;
        }

        private void buttonGetAll_Click(object sender, EventArgs e)
        {
            var clients = _repo.GetAll();
            dataGridView1.DataSource = clients;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentCell != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                int clientID = Convert.ToInt32(selectedRow.Cells["ClientID"].Value);
                _repo.Delete(clientID);
                var clients = _repo.GetAll();
                dataGridView1.DataSource = clients;
                MessageBox.Show("Клиент успешно удален.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else MessageBox.Show("Пожалуйста, выберите строку клиента для удаления","Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = true;
            panelEdit.Enabled = true;
            panelCreate.Visible = false;
            panelCreate.Enabled = false;



            if (dataGridView1.CurrentCell != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                int clientID = Convert.ToInt32(selectedRow.Cells["ClientID"].Value);
                var currentClient = _repo.Read(clientID);

                textBoxNameEdit.Text = currentClient?.ClientName?.ToString();
                textBoxNumberEdit.Text = currentClient?.ClientPhone?.ToString();
                textBoxLoginEdit.Text = currentClient?.ClientLogin?.ToString();
                textBoxPasswordEdit.Text = currentClient?.ClientPassword?.ToString();

            }
            else MessageBox.Show("Пожалуйста, выберите строку клиента для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBoxNameEdit.Text)) || (string.IsNullOrEmpty(textBoxNumberEdit.Text)) || (string.IsNullOrEmpty(textBoxLoginEdit.Text)) || (string.IsNullOrEmpty(textBoxPasswordEdit.Text)))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
            int clientID = Convert.ToInt32(selectedRow.Cells["ClientID"].Value);
            var currentClient = _repo.Read(clientID);


            currentClient.ClientName = textBoxNameEdit.Text;
            currentClient.ClientPhone = textBoxNumberEdit.Text;
            currentClient.ClientLogin = textBoxLoginEdit.Text;
            currentClient.ClientPassword = textBoxPasswordEdit.Text;

            _repo.Update(currentClient);
            dataGridView1.DataSource = _repo.GetAll();
            MessageBox.Show("Данные клиента успешно обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        private void ButtonCancelEdit_Click(object sender, EventArgs e)
        {
            panelEdit.Visible = false;
            panelEdit.Enabled = false;
        }

    }
}
