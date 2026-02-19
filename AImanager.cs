using GenerativeAI;
using GenerativeAI.Clients;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AIChatBot
{
    public class ChatSessionManager
    {
        private static ChatSession? _chatSession;
        private static readonly string apiKey =
            "AIzaSyCBqOfk8xjC8fHOTRDF0Z4V_snEOfAGQUI";
        private static readonly string modelName = "gemini-2.5-flash-lite";

        public async Task<string> AskAI(string prompt)
        {
            if (_chatSession == null)
            {
                var adapter = new GoogleAIPlatformAdapter(apiKey);
                var model = new GenerativeModel(adapter, modelName);
                _chatSession = model.StartChat();
            }

            var modelClient = new GenerativeModel(apiKey, modelName);
            var response = await modelClient.GenerateContentAsync(prompt);
            return response.Text;
        }

        public void ResetChat()
        {
            _chatSession = null;
        }
    }
}
