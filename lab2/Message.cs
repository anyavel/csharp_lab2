using System;

namespace a2
{
    class Message : IComparable
    {
        private string senderNumber;
        private string receiverNumber;
        private string text;
        private uint price;
        public Message()
        {
            senderNumber = "+3800000000";
            receiverNumber = "+3800000000";
            text = "";
            price = 0;
        }
        public Message(string sNum, string rNum, string txt)
        {
            senderNumber = sNum;
            receiverNumber = rNum;
            text = txt;
            calculatePrice();
        }
        public void calculatePrice()
        {
            price = (uint)text.Length / 40 + 1;
        }
        public override string ToString()
        {
            return $"Receiver: {receiverNumber}. Sender: {senderNumber}\nText: {text}\nPrice:{price} hrn.";
        }
        public int CompareTo(object obj)
        {
            Message msg = obj as Message;
            int res = this.text.Length - msg.text.Length;
            if (res == 0)
            {
                return 0;
            }
            else if (res > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public static bool operator >(Message first, Message second)
        {
            return first.CompareTo(second) > 0;
        }
        public static bool operator <(Message first, Message second)
        {
            return first.CompareTo(second) < 0;
        }
        public override bool Equals(object obj)
        {
            Message msg = obj as Message;
            return this.senderNumber == msg.senderNumber && this.receiverNumber == msg.receiverNumber && this.text == msg.text;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator ==(Message first, Message second)
        {
            return first.Equals(second);
        }
        public static bool operator !=(Message first, Message second)
        {
            return !first.Equals(second);
        }
        public static Message operator +(Message msg, string newText)
        {
            return new Message(msg.senderNumber, msg.receiverNumber, msg.text + newText);
        }
        public string SenderNumber
        {
            get
            {
                return senderNumber;
            }
            set
            {
                senderNumber = value.Length == 10 || value.Length == 13 ? value : senderNumber;
            }
        }
        public string ReceiverNumber
        {
            get
            {
                return receiverNumber;
            }
            set
            {
                receiverNumber = value.Length == 10 || value.Length == 13 ? value : receiverNumber;
            }
        }
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value.GetType().ToString() == "System.String" ? value : text;
                calculatePrice();
            }
        }
    }
}