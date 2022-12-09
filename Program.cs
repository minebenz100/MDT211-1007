using System;

class Program
{
    static void Add1(CircularLinkedList<char> garland)
    {
        {
            if(garland.Get(-2) == 'J')
            {
                Console.WriteLine("Invalid pattern.");
                return;
            }
        }
        garland.Add('(');
    }

    static void Add2(CircularLinkedList<char> garland)
    {
        {
            if(garland.Get(-2) == 'G')
            {
                Console.WriteLine("Invalid pattern.");
                return;
            }
        }

        if(garland.GetLength() > 2)
        {
            if(garland.Get(-1) == 'G' && garland.Get(-2) == 'G' && garland.Get(-3) == 'G')
            {
                Console.WriteLine("Invalid pattern.");
                return;
            }
            else if(garland.Get(0) == 'G' && garland.Get(1) == 'G' && garland.Get(2) == 'G')
            {
                Console.WriteLine("Invalid pattern.");
                return;
            }
        }
        
        garland.Add(')');
    }

   
    static void Input(CircularLinkedList<char> garland)
    {
        char flower = char.Parse(Console.ReadLine());
        switch(flower)
        {
            case '(':
                Add2(garland);
                Input(garland);
                break;
            case ')':
                Add1(garland);
                Input(garland);
                break;
            default:
                break;
        }
    }

    static void Main(string[] args)
    {
        CircularLinkedList<char> garland = new CircularLinkedList<char>();
        Input(garland);
        for(int i=0; i<garland.GetLength(); i++)
        {
            Console.Write(garland.Get(i));
        }
    }
}