using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POE_Part2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ChatBotEngine bot = new ChatBotEngine(); 
        public MainWindow()
        {
            InitializeComponent();
       
        txtAscii.Text = AsciiArt.GetLogo();
          VoiceGreeting.PlayGreeting();
            rtbChat.AppendText("Bot: Welcome to the Cybersecurity Awareness Bot!\n\n");

           }
       private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            string input = txtInput.Text;
            if (string.IsNullOrWhiteSpace(input))
            {
               MessageBox.Show("Please enter text.");
                return;
            }
        rtbChat.AppendText("You: " + input + "\n");
            string response = bot.GetResponse(input);
            rtbChat.AppendText("Bot: " + response + "\n\n");
            txtInput.Clear();

         }
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


    }
}