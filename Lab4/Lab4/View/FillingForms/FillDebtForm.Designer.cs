namespace Lab4.View.FillingForms
{
    partial class FillDebtForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FillDebtForm));
            this.LimitDateErrorLbl = new System.Windows.Forms.Label();
            this.TakenDateErrorLbl = new System.Windows.Forms.Label();
            this.LimitDate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelBut = new System.Windows.Forms.Button();
            this.okBut = new System.Windows.Forms.Button();
            this.Sum = new System.Windows.Forms.TextBox();
            this.SumErrorLbl = new System.Windows.Forms.Label();
            this.TakenDate = new System.Windows.Forms.MaskedTextBox();
            this.Status = new System.Windows.Forms.ComboBox();
            this.PaidDateErrorLbl = new System.Windows.Forms.Label();
            this.PaidDate = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LimitDateErrorLbl
            // 
            this.LimitDateErrorLbl.AutoSize = true;
            this.LimitDateErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.LimitDateErrorLbl.Location = new System.Drawing.Point(436, 100);
            this.LimitDateErrorLbl.Name = "LimitDateErrorLbl";
            this.LimitDateErrorLbl.Size = new System.Drawing.Size(165, 20);
            this.LimitDateErrorLbl.TabIndex = 40;
            this.LimitDateErrorLbl.Text = "Обязательное поле!";
            this.LimitDateErrorLbl.Visible = false;
            // 
            // TakenDateErrorLbl
            // 
            this.TakenDateErrorLbl.AutoSize = true;
            this.TakenDateErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.TakenDateErrorLbl.Location = new System.Drawing.Point(436, 58);
            this.TakenDateErrorLbl.Name = "TakenDateErrorLbl";
            this.TakenDateErrorLbl.Size = new System.Drawing.Size(165, 20);
            this.TakenDateErrorLbl.TabIndex = 39;
            this.TakenDateErrorLbl.Text = "Обязательное поле!";
            this.TakenDateErrorLbl.Visible = false;
            // 
            // LimitDate
            // 
            this.LimitDate.Location = new System.Drawing.Point(192, 97);
            this.LimitDate.Mask = "00\\/00\\/0000";
            this.LimitDate.Name = "LimitDate";
            this.LimitDate.Size = new System.Drawing.Size(227, 26);
            this.LimitDate.TabIndex = 3;
            this.LimitDate.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Статус*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Должен оплатить до*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Дата взятия*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "Сумма*";
            // 
            // cancelBut
            // 
            this.cancelBut.Location = new System.Drawing.Point(657, 226);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(96, 39);
            this.cancelBut.TabIndex = 7;
            this.cancelBut.Text = "Отмена";
            this.cancelBut.UseVisualStyleBackColor = true;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // okBut
            // 
            this.okBut.Location = new System.Drawing.Point(549, 226);
            this.okBut.Name = "okBut";
            this.okBut.Size = new System.Drawing.Size(94, 39);
            this.okBut.TabIndex = 6;
            this.okBut.Text = "ОК";
            this.okBut.UseVisualStyleBackColor = true;
            this.okBut.Click += new System.EventHandler(this.okBut_Click);
            // 
            // Sum
            // 
            this.Sum.Location = new System.Drawing.Point(192, 9);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(227, 26);
            this.Sum.TabIndex = 1;
            // 
            // SumErrorLbl
            // 
            this.SumErrorLbl.AutoSize = true;
            this.SumErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.SumErrorLbl.Location = new System.Drawing.Point(433, 12);
            this.SumErrorLbl.Name = "SumErrorLbl";
            this.SumErrorLbl.Size = new System.Drawing.Size(336, 20);
            this.SumErrorLbl.TabIndex = 47;
            this.SumErrorLbl.Text = "Неверный формат или поле не заполнено!";
            this.SumErrorLbl.Visible = false;
            // 
            // TakenDate
            // 
            this.TakenDate.Location = new System.Drawing.Point(192, 55);
            this.TakenDate.Mask = "00\\/00\\/0000";
            this.TakenDate.Name = "TakenDate";
            this.TakenDate.Size = new System.Drawing.Size(227, 26);
            this.TakenDate.TabIndex = 2;
            this.TakenDate.ValidatingType = typeof(System.DateTime);
            // 
            // Status
            // 
            this.Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status.FormattingEnabled = true;
            this.Status.Items.AddRange(new object[] {
            "Не оплачен",
            "Продлён",
            "Просрочен",
            "Оплачен"});
            this.Status.Location = new System.Drawing.Point(192, 136);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(227, 28);
            this.Status.TabIndex = 4;
            // 
            // PaidDateErrorLbl
            // 
            this.PaidDateErrorLbl.AutoSize = true;
            this.PaidDateErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.PaidDateErrorLbl.Location = new System.Drawing.Point(433, 186);
            this.PaidDateErrorLbl.Name = "PaidDateErrorLbl";
            this.PaidDateErrorLbl.Size = new System.Drawing.Size(210, 20);
            this.PaidDateErrorLbl.TabIndex = 51;
            this.PaidDateErrorLbl.Text = "Заполните поле до конца!";
            this.PaidDateErrorLbl.Visible = false;
            // 
            // PaidDate
            // 
            this.PaidDate.Location = new System.Drawing.Point(192, 180);
            this.PaidDate.Mask = "00\\/00\\/0000";
            this.PaidDate.Name = "PaidDate";
            this.PaidDate.Size = new System.Drawing.Size(227, 26);
            this.PaidDate.TabIndex = 5;
            this.PaidDate.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 50;
            this.label6.Text = "Дата оплаты";
            // 
            // FillDebtForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 280);
            this.Controls.Add(this.PaidDateErrorLbl);
            this.Controls.Add(this.PaidDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.TakenDate);
            this.Controls.Add(this.SumErrorLbl);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.LimitDateErrorLbl);
            this.Controls.Add(this.TakenDateErrorLbl);
            this.Controls.Add(this.LimitDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.okBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FillDebtForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Название формы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LimitDateErrorLbl;
        private System.Windows.Forms.Label TakenDateErrorLbl;
        private System.Windows.Forms.MaskedTextBox LimitDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelBut;
        private System.Windows.Forms.Button okBut;
        private System.Windows.Forms.TextBox Sum;
        private System.Windows.Forms.Label SumErrorLbl;
        private System.Windows.Forms.MaskedTextBox TakenDate;
        private System.Windows.Forms.ComboBox Status;
        private System.Windows.Forms.Label PaidDateErrorLbl;
        private System.Windows.Forms.MaskedTextBox PaidDate;
        private System.Windows.Forms.Label label6;
    }
}