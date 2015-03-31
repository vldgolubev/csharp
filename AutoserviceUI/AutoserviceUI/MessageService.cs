using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoserviceUI
{
    public interface IMessageService
    {
        DialogResult ConfimDeleteWorker(string lastname, string firstname, string fathname);
        DialogResult ConfimDeleteWorkCategory(string categoryName);
        DialogResult ConfimDeleteModel(string modelName);
        DialogResult ConfirmDeleteMessageAdmin(string login);
        void ShowMessage(string message);
        void ShowExclamation(string exclamation);
        void ShowError(string error);
    }
    class MessageService : IMessageService
    {
        public DialogResult ConfimDeleteWorker(string lastname, string firstname, string fathname)
        {
            DialogResult result = MessageBox.Show(string.Format("Вы действительно хотите удалить рабочего {0} {1} {2}?",lastname,firstname,fathname), "Удаление", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            return result;
        }
        public DialogResult ConfimDeleteWork(string workName)
        {
            DialogResult result = MessageBox.Show(string.Format("Вы действительно хотите удалить работу с названием {0}?", workName), "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result;
        }
        public DialogResult ConfimDeleteWorkCategory(string categoryName)
        {
            DialogResult result = MessageBox.Show(string.Format("Вы действительно хотите удалить категорию с названием {0}?",categoryName), "Удаление", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            return result;
        }
        public DialogResult ConfimDeleteModel(string modelName)
        {
            DialogResult result = MessageBox.Show(string.Format("Вы действительно хотите удалить модель автомобиля с названием {0}?",modelName), "Удаление", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            return result;
        }
        public DialogResult ConfimDeleteTypeModel(string model)
        {
            DialogResult result = MessageBox.Show(string.Format("Вы действительно хотите удалить тип кузова с названием {0}?", model), "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result;
        }
        public DialogResult ConfirmDeleteMark(string mark)
        {
            DialogResult result = MessageBox.Show(string.Format("Вы действительно хотите удалить марку с названием {0}?", mark), "Удаление", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            return result;
        }
        public DialogResult ConfirmDeleteMessageAdmin(string login)
        {
            DialogResult result = MessageBox.Show(string.Format("Вы действительно хотите удалить пользователя с именем {0}?", login),"Удаление",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            return result;
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void ShowExclamation(string exclamation)
        {
            MessageBox.Show(exclamation, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
