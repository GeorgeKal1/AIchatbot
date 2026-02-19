using GenerativeAI;
using GenerativeAI.Clients;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Linq.Expressions;

namespace AIChatBot
{
    public partial class Form1 : Form
    {
        
        
        private string? Prompt = "";
        private string? AIresponse = "";
        private List<ChatMessage> chatMessages = new List<ChatMessage>();
        Form2 DataForm;
        ChatSessionManager ChatSessionManager1 = new ChatSessionManager();


        public Form1()
        {

            InitializeComponent();
            DataForm = new Form2();
            DatabaseHelper.InitializeDatabase();
        }

        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)) return;


            try
            {
                

                richTextBox1.SelectionColor = Color.White;//edw ginetai to keimeno tou xristi
                richTextBox1.AppendText($"\n-> User:\n {textBox1.Text}\n");




                var response = await ChatSessionManager1.AskAI(textBox1.Text);//API call

                chatMessages.Add(new ChatMessage("User", textBox1.Text));
                chatMessages.Add(new ChatMessage("AI", response));

                textBox1.Text = "";
                richTextBox1.ScrollToCaret();
                richTextBox1.AppendText($"\n->AI:\n {response}\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return;


        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void NewChatMenuItem1_Click(object sender, EventArgs e)//clear to chat
        {
            clearPage();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)//exit 
        {
            Close();
        }



        private void SaveChatToolStripMenuItem_Click(object sender, EventArgs e)//kanoume save to chat se txt arxeio
        {
            if (richTextBox1.Text.Length == 0)
            {
                MessageBox.Show("No chat to save!");
                return;
            }

            if (!richTextBox1.Text.Contains("->AI:"))
            {
                MessageBox.Show("No AI response found to name the chat file!");
                return;
            }



            try
            {

                int AIresponsetext = richTextBox1.Text.IndexOf("->AI:") + 6;
                var word = richTextBox1.Text.Substring(AIresponsetext, 5).Trim();
                string path;

                using (FolderBrowserDialog fdb = new FolderBrowserDialog())//edw epilegoume to folder pou theloume na apothikeusoume to arxeio
                {
                    fdb.Description = "Give the folder";
                    if (fdb.ShowDialog() == DialogResult.OK)
                    {
                        path = $"{fdb.SelectedPath}" + $"\\{word}_chat.txt";//to onoma tou arxeiou dineitai apo ta 5 prwta grammata tou AI response


                        System.IO.File.WriteAllText(path, richTextBox1.Text);
                        MessageBox.Show($"Chat saved as {path}");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving chat: {ex.Message}");
                return;


            }
        }

        private void saveChattxtToolStripMenuItem_Click(object sender, EventArgs e)//anoigoume ena txt arxeio kai fortonoume to periexomeno tou sto textbox1
        {
            using (OpenFileDialog openfile = new OpenFileDialog())
            {
                openfile.Filter = "Text Files|*.txt";
                openfile.Title = "Select a Chat Text File";

                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string filecontent = System.IO.File.ReadAllText(openfile.FileName);
                        textBox1.Text = filecontent;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading file: {ex.Message}");
                    }
                }
            }
        }

        private void showInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("AI Chat Bot\nVersion 1.0\nTool: Google Gemini", "About");
        }

        private void termsOfUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terms of Use:\n1. This AI Chat Bot is provided as-is without any warranties.\n2. Users are responsible for their interactions with the AI.\n3. Do not share sensitive or personal information with the AI.\n4. The developers are not liable for any misuse of the application.\nΠαρακαλώ όχι πολλά API requests γιατι θα τελειώσει το free trial😣", "Terms of Use");
        }


        private void saveAnswerToDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Prompt) || string.IsNullOrEmpty(AIresponse))
            {
                MessageBox.Show("No question and answer to save. Please interact with the AI first.\n" +
                    "Right Click the AI response you wish to save");
                return;
            }


            DatabaseHelper.SaveChat(Prompt, AIresponse);
        }


        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)//epilegoume to response tou AI pou theloume na apothikeusoume sti vasi kai to antistoixo question tou user, me right click
        {
            if (e.Button != MouseButtons.Right)
                return;

            var pos = richTextBox1.GetCharIndexFromPosition(e.Location);
            var text = richTextBox1.Text;

            //gia na apofygoume na epileksume user blocks(apo debug proekypse)
            var lastAI = text.LastIndexOf("->AI:", pos);
            var lastUser = text.LastIndexOf("-> User:", pos);
            if (lastAI < lastUser)
                return;

            // vriskoume to teleutaio AI block prin to point pou kanoume right click
            var aiStart = text.LastIndexOf("->AI:", pos);
            if (aiStart < 0) return;


            var nextUser = text.IndexOf("-> User:", aiStart + 1);
            if (nextUser < 0)
                nextUser = text.Length;


            var aiContentStart = aiStart + "->AI:".Length;
            AIresponse = text.Substring(aiContentStart, nextUser - aiContentStart).Trim();

            //vriskoume to antistoixo User block
            var userStart = text.LastIndexOf("-> User:", aiStart);
            if (userStart >= 0)
            {
                var nextAI = text.IndexOf("->AI:", userStart + 1);
                var userContentStart = userStart + "-> User:".Length;
                Prompt = text.Substring(userContentStart, nextAI - userContentStart).Trim();
            }

            MessageBox.Show("AI + Question selected and ready to save!");
        }

        private void loadDBToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DataForm.ShowDialog();
        }

        private void clearPage()
        {
            richTextBox1.Clear();
            textBox1.Clear();
            chatMessages.Clear();
            Prompt = "";
            AIresponse = "";

            ChatSessionManager1.ResetChat();


        }
    }
}