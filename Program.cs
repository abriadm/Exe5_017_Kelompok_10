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
            Node newnode = new Node();
            Console.WriteLine("Masukan Nama: ");
            nm = Console.ReadLine();
            newnode.name = nm;
            newnode.next = null;
            if (abriansyah == null)
            {
                abriansyah = newnode;
                adam = newnode;
                return;
            }
            adam.next = newnode;
            adam = newnode;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}