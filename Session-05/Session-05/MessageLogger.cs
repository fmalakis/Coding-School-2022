using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class MessageLogger
    {
        private int messageIndex;
        public Message[] Messages { get; }
        public MessageLogger(int storageSize)
        {
            messageIndex = 0;
            Messages = new Message[storageSize];
        }

        public void ReadAll()
        {
            for (int i = 0; i < messageIndex; i++)
                Console.WriteLine($"{i+1}) ID: {Messages[i].ID}, TimeStamp: {Messages[i].TimeStamp}, Body: {Messages[i].MessageBody}");
        }

        public void Clear()
        {
            Array.Clear(Messages, 0, Messages.Length);
            messageIndex = 0;
        }
        
        public bool Write(Message newMessage)
        {
            if (newMessage == null)
                return false;

            if (messageIndex >= Messages.Length)
                return false;

            Messages[messageIndex++] = newMessage;

            return true;
        }

    }
}
