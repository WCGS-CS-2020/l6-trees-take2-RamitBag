using System;

/*
     * Tasks:
     * 1) Complete the implementation of the Node methods
     * 2) Print out the tree using the different tree traversal metods
     * 3) Test findNote() and deleteNode()
     *
     *
     */
class Node
{
    // Attributes
    private Node left;
    private Node right;
    private int item;

    //Methods
    public Node(int i) 
    {
        item = i;
        left = null;
        right = null;
    }

    public void addNode(int i) 
    {
        if (i < this.item)
        {
            if (left == null)
            {
                left = new Node(item);
            }
            else
            {
                left.addNode(item);
            }
        }
        else if (i > this.item)
        {
            if (right == null)
            {
                right = new Node(item);
            }
            else
            {
                right.addNode(item);
            }
        }
    }

    public Boolean findNode(int i) 
    {
        bool holder;
        if (i == this.item)
        {
            return (true);
        }
        else if (i< this.item)
        {
            holder = left.findNode(item);
            return (holder);
        }
        else if (i > this.item)
        {
            holder = right.findNode(item);
            return (holder);
        }
        else
        {
            return false;
        }
    }

    public void deleteNote(int i) 
    {
        if (findNode(i) == true)
        {
            if (i > this.item)
            {
                right = null;
            }
            else if (i < this.item)
            {
                left = null;
            }
            Console.WriteLine("The item has been deleted");
        }
        else
        {
            Console.WriteLine("The item is not in the tree");
        }
    }

    public void printTree() 
    {

    }
}

class Program
{
    static void Main(string[] args)
    {
        Node root = null;

        string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        //Since it is easier to compare int to int than string to string, the data is stored as inetgers
        int [] Month_Number = {1,2,3,4,5,6,7,8,9,10,11,12};


        // process all the nodes on the array
        //
        foreach (var mon in Month_Number)
        {
            if (root == null)
                root = new Node(mon);

            else
                root.addNode(mon);

        }

        Console.WriteLine("Please select what you'd like to do : 1. Find item \n2.Delete item \n3.Print item");
        int option = Int32.Parse(Console.ReadLine());
        switch (option)
        {
            case 1:
                Console.WriteLine("Please enter what the month like to search for");
                string month = Console.ReadLine();
                int monthint = -1;

                //checks if the string entered is in the array of months
                for (int i = 0; i < months.Length; i++)
                {
                    if (months[i] == month)
                    {
                        monthint = i + 1;
                    }
                }

                if (monthint == -1)
                {
                    Console.WriteLine("the item you entered is not a month");
                }
                else
                {
                    if (root.findNode(monthint) == true)
                    {
                        Console.WriteLine("The item is in the tree");
                    }
                    else
                    {
                        Console.WriteLine("The item is not in the tree");
                    }
                }
                break;
            case 2:

                Console.WriteLine("Please enter what the month like to search for");
                month = Console.ReadLine();
                monthint = -1;

                //checks if the string entered is in the array of months
                for (int i = 0; i < months.Length; i++)
                {
                    if (months[i] == month)
                    {
                        monthint = i + 1;
                    }
                }

                if (monthint == -1)
                {
                    Console.WriteLine("the item you entered is not a month");
                }
                else
                {
                    root.deleteNote(monthint);
                }
                break;

            case 3:
                root.printTree();
                break;


            default:
                break;
        }

        // print out the tree using different traversal methods
        //

        // Test the findNote() and deleteNode()
    }
}
