namespace Lab4.View.FillingForms
{
    partial class FillDebtorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FillDebtorForm));
            this.okBut = new System.Windows.Forms.Button();
            this.cancelBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Category = new System.Windows.Forms.ComboBox();
            this.DebtorName = new System.Windows.Forms.TextBox();
            this.INN = new System.Windows.Forms.MaskedTextBox();
            this.Adress = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.MaskedTextBox();
            this.EmailErrorLbl = new System.Windows.Forms.Label();
            this.PhoneErrorLbl = new System.Windows.Forms.Label();
            this.AdressErrorLbl = new System.Windows.Forms.Label();
            this.OGRNErrorLbl = new System.Windows.Forms.Label();
            this.INNErrorLbl = new System.Windows.Forms.Label();
            this.NameErrorLbl = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.OGRN = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // okBut
            // 
            this.okBut.Location = new System.Drawing.Point(540, 313);
            this.okBut.Name = "okBut";
            this.okBut.Size = new System.Drawing.Size(94, 39);
            this.okBut.TabIndex = 0;
            this.okBut.Text = "ОК";
            this.okBut.UseVisualStyleBackColor = true;
            this.okBut.Click += new System.EventHandler(this.okBut_Click);
            // 
            // cancelBut
            // 
            this.cancelBut.Location = new System.Drawing.Point(652, 313);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(96, 39);
            this.cancelBut.TabIndex = 1;
            this.cancelBut.Text = "Отмена";
            this.cancelBut.UseVisualStyleBackColor = true;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Категория*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Наименование*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ИНН*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "ОГРН";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Адрес*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Телефон*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Электронная почта";
            // 
            // Category
            // 
            this.Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Category.FormattingEnabled = true;
            this.Category.Items.AddRange(new object[] {
            "Физическое лицо",
            "Юридическое лицо"});
            this.Category.Location = new System.Drawing.Point(181, 13);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(227, 28);
            this.Category.TabIndex = 9;
            // 
            // DebtorName
            // 
            this.DebtorName.Location = new System.Drawing.Point(181, 56);
            this.DebtorName.Name = "DebtorName";
            this.DebtorName.Size = new System.Drawing.Size(227, 26);
            this.DebtorName.TabIndex = 10;
            // 
            // INN
            // 
            this.INN.Location = new System.Drawing.Point(181, 98);
            this.INN.Mask = "0000-00000-0";
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(227, 26);
            this.INN.TabIndex = 11;
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(181, 181);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(227, 26);
            this.Adress.TabIndex = 13;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(181, 225);
            this.Phone.Mask = "+0(000)-000-00-00";
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(227, 26);
            this.Phone.TabIndex = 14;
            // 
            // EmailErrorLbl
            // 
            this.EmailErrorLbl.AutoSize = true;
            this.EmailErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.EmailErrorLbl.Location = new System.Drawing.Point(425, 272);
            this.EmailErrorLbl.Name = "EmailErrorLbl";
            this.EmailErrorLbl.Size = new System.Drawing.Size(156, 20);
            this.EmailErrorLbl.TabIndex = 22;
            this.EmailErrorLbl.Text = "Неверный формат!";
            this.EmailErrorLbl.Visible = false;
            // 
            // PhoneErrorLbl
            // 
            this.PhoneErrorLbl.AutoSize = true;
            this.PhoneErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.PhoneErrorLbl.Location = new System.Drawing.Point(424, 228);
            this.PhoneErrorLbl.Name = "PhoneErrorLbl";
            this.PhoneErrorLbl.Size = new System.Drawing.Size(203, 20);
            this.PhoneErrorLbl.TabIndex = 21;
            this.PhoneErrorLbl.Text = "Недостаточно символов!";
            this.PhoneErrorLbl.Visible = false;
            // 
            // AdressErrorLbl
            // 
            this.AdressErrorLbl.AutoSize = true;
            this.AdressErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.AdressErrorLbl.Location = new System.Drawing.Point(424, 184);
            this.AdressErrorLbl.Name = "AdressErrorLbl";
            this.AdressErrorLbl.Size = new System.Drawing.Size(325, 20);
            this.AdressErrorLbl.TabIndex = 20;
            this.AdressErrorLbl.Text = "Должен содержать не менее 5 символов!";
            this.AdressErrorLbl.Visible = false;
            // 
            // OGRNErrorLbl
            // 
            this.OGRNErrorLbl.AutoSize = true;
            this.OGRNErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.OGRNErrorLbl.Location = new System.Drawing.Point(425, 143);
            this.OGRNErrorLbl.Name = "OGRNErrorLbl";
            this.OGRNErrorLbl.Size = new System.Drawing.Size(203, 20);
            this.OGRNErrorLbl.TabIndex = 19;
            this.OGRNErrorLbl.Text = "Недостаточно символов!";
            this.OGRNErrorLbl.Visible = false;
            // 
            // INNErrorLbl
            // 
            this.INNErrorLbl.AutoSize = true;
            this.INNErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.INNErrorLbl.Location = new System.Drawing.Point(425, 104);
            this.INNErrorLbl.Name = "INNErrorLbl";
            this.INNErrorLbl.Size = new System.Drawing.Size(203, 20);
            this.INNErrorLbl.TabIndex = 18;
            this.INNErrorLbl.Text = "Недостаточно символов!";
            this.INNErrorLbl.Visible = false;
            // 
            // NameErrorLbl
            // 
            this.NameErrorLbl.AutoSize = true;
            this.NameErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.NameErrorLbl.Location = new System.Drawing.Point(425, 62);
            this.NameErrorLbl.Name = "NameErrorLbl";
            this.NameErrorLbl.Size = new System.Drawing.Size(325, 20);
            this.NameErrorLbl.TabIndex = 17;
            this.NameErrorLbl.Text = "Должно содержать не менее 3 символов!";
            this.NameErrorLbl.Visible = false;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(181, 269);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(227, 26);
            this.Email.TabIndex = 23;
            // 
            // OGRN
            // 
            this.OGRN.Location = new System.Drawing.Point(181, 137);
            this.OGRN.Mask = "0-00-00-00-00000-0";
            this.OGRN.Name = "OGRN";
            this.OGRN.Size = new System.Drawing.Size(227, 26);
            this.OGRN.TabIndex = 12;
            // 
            // FillDebtorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 362);
            this.Controls.Add(this.OGRN);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.EmailErrorLbl);
            this.Controls.Add(this.PhoneErrorLbl);
            this.Controls.Add(this.AdressErrorLbl);
            this.Controls.Add(this.OGRNErrorLbl);
            this.Controls.Add(this.INNErrorLbl);
            this.Controls.Add(this.NameErrorLbl);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.INN);
            this.Controls.Add(this.DebtorName);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.okBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FillDebtorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Название формы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okBut;
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Category;
        private System.Windows.Forms.TextBox DebtorName;
        private System.Windows.Forms.MaskedTextBox INN;
        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.MaskedTextBox Phone;
        private System.Windows.Forms.Label EmailErrorLbl;
        private System.Windows.Forms.Label PhoneErrorLbl;
        private System.Windows.Forms.Label AdressErrorLbl;
        private System.Windows.Forms.Label OGRNErrorLbl;
        private System.Windows.Forms.Label INNErrorLbl;
        private System.Windows.Forms.Label NameErrorLbl;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.MaskedTextBox OGRN;
    }
}