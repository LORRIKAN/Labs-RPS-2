﻿using System.Windows.Forms;

namespace Lab4.View.MessageService
{
    class MessageService : IMessageService
    {
        public void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult ShowOkCancel(string message)
        {
            return MessageBox.Show(message, "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}