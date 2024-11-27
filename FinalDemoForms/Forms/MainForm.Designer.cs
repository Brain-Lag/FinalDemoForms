namespace FinalDemoForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            ClientsPage = new TabPage();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonGetAll = new Button();
            buttonCreate = new Button();
            dataGridView1 = new DataGridView();
            OrdersPage = new TabPage();
            panelCreate = new Panel();
            buttonCancel = new Button();
            buttonApply = new Button();
            textBoxPassword = new TextBox();
            label5 = new Label();
            textBoxLogin = new TextBox();
            label4 = new Label();
            textBoxNumber = new TextBox();
            label3 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panelEdit = new Panel();
            buttonCancelEdit = new Button();
            buttonSave = new Button();
            textBoxPasswordEdit = new TextBox();
            textBoxLoginEdit = new TextBox();
            textBoxNumberEdit = new TextBox();
            textBoxNameEdit = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            tabControl1.SuspendLayout();
            ClientsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelCreate.SuspendLayout();
            panelEdit.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ClientsPage);
            tabControl1.Controls.Add(OrdersPage);
            tabControl1.Location = new Point(2, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(797, 453);
            tabControl1.TabIndex = 0;
            // 
            // ClientsPage
            // 
            ClientsPage.Controls.Add(buttonEdit);
            ClientsPage.Controls.Add(buttonDelete);
            ClientsPage.Controls.Add(buttonGetAll);
            ClientsPage.Controls.Add(buttonCreate);
            ClientsPage.Controls.Add(dataGridView1);
            ClientsPage.Location = new Point(4, 29);
            ClientsPage.Name = "ClientsPage";
            ClientsPage.Padding = new Padding(3);
            ClientsPage.Size = new Size(789, 420);
            ClientsPage.TabIndex = 0;
            ClientsPage.Text = "Клиенты";
            ClientsPage.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(255, 224, 192);
            buttonEdit.Location = new Point(6, 60);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(133, 29);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.IndianRed;
            buttonDelete.Location = new Point(6, 108);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonGetAll
            // 
            buttonGetAll.Location = new Point(0, 272);
            buttonGetAll.Name = "buttonGetAll";
            buttonGetAll.Size = new Size(115, 29);
            buttonGetAll.TabIndex = 2;
            buttonGetAll.Text = "Вывести всех";
            buttonGetAll.UseVisualStyleBackColor = true;
            buttonGetAll.Click += buttonGetAll_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.BackColor = Color.FromArgb(192, 255, 192);
            buttonCreate.Location = new Point(6, 12);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(94, 29);
            buttonCreate.TabIndex = 1;
            buttonCreate.Text = "Добавить";
            buttonCreate.UseVisualStyleBackColor = false;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(264, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(522, 339);
            dataGridView1.TabIndex = 0;
            // 
            // OrdersPage
            // 
            OrdersPage.Location = new Point(4, 29);
            OrdersPage.Name = "OrdersPage";
            OrdersPage.Padding = new Padding(3);
            OrdersPage.Size = new Size(789, 420);
            OrdersPage.TabIndex = 1;
            OrdersPage.Text = "Заказы";
            OrdersPage.UseVisualStyleBackColor = true;
            // 
            // panelCreate
            // 
            panelCreate.BackColor = SystemColors.ActiveCaption;
            panelCreate.Controls.Add(buttonCancel);
            panelCreate.Controls.Add(buttonApply);
            panelCreate.Controls.Add(textBoxPassword);
            panelCreate.Controls.Add(label5);
            panelCreate.Controls.Add(textBoxLogin);
            panelCreate.Controls.Add(label4);
            panelCreate.Controls.Add(textBoxNumber);
            panelCreate.Controls.Add(label3);
            panelCreate.Controls.Add(textBoxName);
            panelCreate.Controls.Add(label2);
            panelCreate.Controls.Add(label1);
            panelCreate.Enabled = false;
            panelCreate.Location = new Point(807, 31);
            panelCreate.Name = "panelCreate";
            panelCreate.Size = new Size(250, 375);
            panelCreate.TabIndex = 1;
            panelCreate.Visible = false;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(255, 192, 192);
            buttonCancel.Location = new Point(18, 309);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonApply
            // 
            buttonApply.BackColor = Color.FromArgb(192, 255, 192);
            buttonApply.Location = new Point(142, 309);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(94, 29);
            buttonApply.TabIndex = 9;
            buttonApply.Text = "Добавить";
            buttonApply.UseVisualStyleBackColor = false;
            buttonApply.Click += buttonApply_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(66, 247);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(170, 27);
            textBoxPassword.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 247);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 7;
            label5.Text = "Пароль";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(66, 189);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(170, 27);
            textBoxLogin.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 189);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 5;
            label4.Text = "Логин";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(66, 128);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(170, 27);
            textBoxNumber.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 128);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 3;
            label3.Text = "Номер";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(66, 67);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(170, 27);
            textBoxName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 67);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 1;
            label2.Text = "Имя";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(77, 19);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Добавление";
            // 
            // panelEdit
            // 
            panelEdit.BackColor = Color.FromArgb(192, 192, 255);
            panelEdit.Controls.Add(buttonCancelEdit);
            panelEdit.Controls.Add(buttonSave);
            panelEdit.Controls.Add(textBoxPasswordEdit);
            panelEdit.Controls.Add(textBoxLoginEdit);
            panelEdit.Controls.Add(textBoxNumberEdit);
            panelEdit.Controls.Add(textBoxNameEdit);
            panelEdit.Controls.Add(label10);
            panelEdit.Controls.Add(label9);
            panelEdit.Controls.Add(label8);
            panelEdit.Controls.Add(label7);
            panelEdit.Controls.Add(label6);
            panelEdit.Enabled = false;
            panelEdit.Location = new Point(807, 29);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(250, 374);
            panelEdit.TabIndex = 5;
            panelEdit.Visible = false;
            // 
            // buttonCancelEdit
            // 
            buttonCancelEdit.BackColor = Color.FromArgb(255, 192, 192);
            buttonCancelEdit.Location = new Point(18, 317);
            buttonCancelEdit.Name = "buttonCancelEdit";
            buttonCancelEdit.Size = new Size(94, 29);
            buttonCancelEdit.TabIndex = 10;
            buttonCancelEdit.Text = "Отменить";
            buttonCancelEdit.UseVisualStyleBackColor = false;
            buttonCancelEdit.Click += ButtonCancelEdit_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(192, 255, 192);
            buttonSave.Location = new Point(135, 317);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += ButtonSave_Click;
            // 
            // textBoxPasswordEdit
            // 
            textBoxPasswordEdit.Location = new Point(72, 240);
            textBoxPasswordEdit.Name = "textBoxPasswordEdit";
            textBoxPasswordEdit.Size = new Size(157, 27);
            textBoxPasswordEdit.TabIndex = 8;
            // 
            // textBoxLoginEdit
            // 
            textBoxLoginEdit.Location = new Point(72, 182);
            textBoxLoginEdit.Name = "textBoxLoginEdit";
            textBoxLoginEdit.Size = new Size(157, 27);
            textBoxLoginEdit.TabIndex = 7;
            // 
            // textBoxNumberEdit
            // 
            textBoxNumberEdit.Location = new Point(72, 121);
            textBoxNumberEdit.Name = "textBoxNumberEdit";
            textBoxNumberEdit.Size = new Size(157, 27);
            textBoxNumberEdit.TabIndex = 6;
            // 
            // textBoxNameEdit
            // 
            textBoxNameEdit.Location = new Point(72, 60);
            textBoxNameEdit.Name = "textBoxNameEdit";
            textBoxNameEdit.Size = new Size(157, 27);
            textBoxNameEdit.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 243);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 4;
            label10.Text = "Пароль";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(4, 185);
            label9.Name = "label9";
            label9.Size = new Size(52, 20);
            label9.TabIndex = 3;
            label9.Text = "Логин";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 124);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 2;
            label8.Text = "Номер";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 63);
            label7.Name = "label7";
            label7.Size = new Size(39, 20);
            label7.TabIndex = 1;
            label7.Text = "Имя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 15);
            label6.Name = "label6";
            label6.Size = new Size(123, 20);
            label6.TabIndex = 0;
            label6.Text = "Редактирование";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 450);
            Controls.Add(panelEdit);
            Controls.Add(panelCreate);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Основное окно";
            tabControl1.ResumeLayout(false);
            ClientsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelCreate.ResumeLayout(false);
            panelCreate.PerformLayout();
            panelEdit.ResumeLayout(false);
            panelEdit.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ClientsPage;
        private Button buttonCreate;
        private DataGridView dataGridView1;
        private TabPage OrdersPage;
        private Panel panelCreate;
        private Label label4;
        private TextBox textBoxNumber;
        private Label label3;
        private TextBox textBoxName;
        private Label label2;
        private Label label1;
        private Button buttonApply;
        private TextBox textBoxPassword;
        private Label label5;
        private TextBox textBoxLogin;
        private Button buttonCancel;
        private Button buttonGetAll;
        private Button buttonDelete;
        private Button buttonEdit;
        private Panel panelEdit;
        private TextBox textBoxNameEdit;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox textBoxPasswordEdit;
        private TextBox textBoxLoginEdit;
        private TextBox textBoxNumberEdit;
        private Button buttonCancelEdit;
        private Button buttonSave;
    }
}
