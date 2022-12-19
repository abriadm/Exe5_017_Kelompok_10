namespace Exercise
{
    class Queue
    {
        int FRONT, REAR;
        List<int> n_List = new List<int>();

        public void insert(int element)
        {
            if ((FRONT == 0 && REAR == n_List.Capacity) || (FRONT == REAR + 1))
            {
                Console.WriteLine();
                return;
            }
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                if (REAR == n_List.Count)
                {
                    REAR = 0;
                }
                else
                {
                    REAR = REAR + 1;
                }
            }
            n_List.Add(element);
        }
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            /*Chceks if the queue  is empty.*/
            if (FRONT == -1)
            {
                Console.WriteLine("queue is empty\n");
                return;
            }
            else
            {
                Console.WriteLine("\nElements in the queue are ......................\n");
                /* tranverses the queue till the last element present in an array. */
                while (FRONT_position <= n_List.Capacity)
                {
                    Console.Write(n_List.Capacity + " ");
                    FRONT_position++;
                }
                /* set the FRONT position to the first element of the array. */
                FRONT_position = 0;
                /* traverse the array till the last element present in the queue. */
                while (FRONT_position < REAR_position)
                {
                    Console.Write(n_List.Capacity + " ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                Queue q = new Queue();
                char choice;
                while (true)
                {


                    Console.WriteLine("Menu");
                    Console.WriteLine("A. Insert");
                    Console.WriteLine("B. Display");
                    Console.WriteLine("C.");
                    Console.WriteLine("D.");
                    Console.WriteLine("Enter your choice (A-D): ");
                    choice = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter a number");
                            int num = Convert.ToInt32(Console.ReadLine());
                            q.insert(num);
                            break;
                        case 'B':
                            Console.WriteLine("Display");
                            q.display();
                            break;
                        default:
                            {
                                Console.WriteLine();
                            }
                            break;
                    }
                }
            }
        }
    }
}

