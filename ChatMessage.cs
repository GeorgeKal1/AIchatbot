using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIChatBot
{
    internal class ChatMessage
    {
        public string Role { get; set; }
        public string Content { get; set; }
        public ChatMessage(string role, string content)
        {
            this.Role = role;
            this.Content = content;
        }
    }
}
