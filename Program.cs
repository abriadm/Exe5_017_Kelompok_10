namespace single_linked_list
{
    class Node
    {
        public string name;
        public Node next;
    }

    class Queue
    {
        Node abriansyah, adam; // Untuk abriansyah menggunakan nama depan dan adam menggunakan nama belakang.
        public Queue()
        {
            abriansyah = null;
            adam = null;
        }
        public void Insert()
        {
            string nm;
            Node temp = new Node();
            Console.Write("Masukan Nama: ");
            nm = Console.ReadLine();
            Console.WriteLine();
            temp.name = nm;
            temp.next = null;
            if (abriansyah == null)
            {
                abriansyah = temp;
                adam = temp;
                return;
            }
            adam.next = temp;
            adam = temp;
        }
        public void Remove()
        {
            if (abriansyah == null)
            {
                Console.WriteLine("Queue is Empty!!");
                return;
            }
            abriansyah = abriansyah.next;
            if (abriansyah == null)
            {
                adam = null;
            }
        }
        public void Display()
        {
            if (abriansyah == null)
            {
                Console.WriteLine("Queue is Empty!!");
                Console.WriteLine();
                return;
            }
            Node display;
            for (display = abriansyah; display != null; display = display.next)
            {
                Console.WriteLine("> " + display.name);
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Queue obj = new Queue();
            while (true)
            {
                try
                {
                    Console.WriteLine("-----Menu-----");
                    Console.WriteLine("1. Insert Name");
                    Console.WriteLine("2. Delete Name");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice: ");
                    char ch;
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            obj.Insert();
                            break;
                        case '2':
                            obj.Remove();
                            break;
                        case '3':
                            obj.Display();
                            break;
                        case '4':
                            return;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered.");
                }
            }
        }
    }
}