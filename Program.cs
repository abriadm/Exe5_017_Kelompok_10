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
            Console.WriteLine("Masukan Nama: ");
            nm = Console.ReadLine();
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
    }
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}