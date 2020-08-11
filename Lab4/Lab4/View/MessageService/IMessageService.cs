using System.Windows.Forms;

namespace Lab4.View.MessageService
{
    public interface IMessageService
    {
        void ShowMessage(string message);
        void ShowExclamation(string exclamation);
        void ShowError(string error);
        DialogResult ShowOkCancel(string message);
    }
}