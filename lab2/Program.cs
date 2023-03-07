namespace a2
{
    class Program
    {
        static void Main(string[] args)
        {
            Message m1 = new Message("+380967894321", "+380987654321", "fhdsfgsfdhsfhsfghsdfhsdgfhs" +
                "dfhdsgfjsgfshfsgyreuyghdsgfshxvvghxgvhgdhfgshfgsyffsygdfgfushavsdhvd213132");
            Message m2 = new Message("+380732141098", "+380501234958", "aaaaaaaaaaaaaaaaaaaaaaabbbbbbbbbbbbbbbbbbbbbbcccccccccccccccccceeeeeeeeeeeeeeeeeee" +
                "fffffffffffffffffffffgggggggggggggggggggggghhhhhhhhhhhhhhhhhhh");
            Message m3 = new Message("+380980416677", "+380112201298", "ghjkdsbghdbgjnkjkhguwrhonfkeh23k4h23nemnfkjxnvoidpo;klsua8yfw");
            Message m4 = new Message("+380632258371", "+380664780102", "zxczcsdfdsfk;ovkxlvmdklfhuebfjsfhsdgfhdsbfhsvdfhsdfshdfj" +
                "gwrwirhuwehriowqrhwrnwerbwbfhjjygwerrrrrrrrrrrrrrrrrdfffffffffffffffasasfasfsfs");
            Message m5 = new Message("+380735141168", "+380730985060", "haplfsdhbdihggsklmewqlojro823ehirdnfxb vbyusdjs sbghsehkwajnfvjgsakkhnf vsdfgakej");
            int n = 5;
            Message[] messages = new Message[n];
            messages[0] = m1;
            messages[1] = m2;
            messages[2] = m3;
            messages[3] = m4;
            messages[4] = m5;
            Console.Write("Add new message? (yes or no): ");
            string choice = Console.ReadLine();
            if (choice == "yes")
            {
                Message m6 = new Message();
                Console.Write("Enter sender phone number: ");
                m6.SenderNumber = Console.ReadLine();
                Console.Write("Enter receiver phone number: ");
                m6.ReceiverNumber = Console.ReadLine();
                Console.Write("Enter Text: ");
                m6.Text = Console.ReadLine();
                //Console.WriteLine(m6);
                Array.Resize(ref messages, n + 1);
                messages[messages.Length - 1] = m6;
            }
            Console.WriteLine("All messages:\n");
            for (int i = 0; i < messages.Length; ++i)
            {
                Console.WriteLine(messages[i]);
            }
            Array.Sort(messages);
            Console.WriteLine($"The longest message:\n{messages[messages.Length - 1]}");
            for (int i = 0; i < 3; ++i)
            {
                Console.WriteLine($"{i + 1} longest message:\n{messages[messages.Length - i]}");
            }
            for (int i = 0; i < messages.Length; ++i)
            {
                messages[i] += " Happy New Year!";
                Console.WriteLine(messages[i]);
            }
        }
    }

}