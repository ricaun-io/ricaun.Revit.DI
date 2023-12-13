namespace ricaun.Revit.DI.Example.Services
{
    public class MessageService : IMessageService
    {
        public void Show(string message)
        {
            System.Windows.MessageBox.Show(message);
        }

        public void Show(string title, string message)
        {
            System.Windows.MessageBox.Show(message, title);
        }
    }

    public interface IMessageService
    {
        public void Show(string message);

        public void Show(string title, string message);
    }
}
