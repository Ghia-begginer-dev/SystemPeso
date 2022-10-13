using System.Windows;
using System.Xaml;
using SystemPeso.ChatBot.UserControls;

namespace SystemPeso.ChatBot.Windows
{
    public partial class ChatbotWindow
    {
        public ChatbotWindow()
        {
            InitializeComponent();

            for (int i = 0; i < 50; i++)
            {
                ChatInbox.Items.Add(new UserInbox());
            }

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    ChatMessages.Items.Add(new MessageItemSent());
                }
                else
                {
                    ChatMessages.Items.Add(new MessageItemReceived());
                }
            }
        }
    }
}