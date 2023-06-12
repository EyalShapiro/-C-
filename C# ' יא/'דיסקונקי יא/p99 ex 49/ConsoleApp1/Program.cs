using System;

namespace ConsoleApp1
{
    class Program
    {
        public static Node<char> List(Node<Manhous> nod)
        {
            Node<char> Eyal=null;
            Node<char> pointer = Eyal;
           
            for (int i = 0; i < nod.Getvalue().GetNum(); i++)
            {
                nod = nod.GetNext();
                Eyal.GetNext().Setvalue(nod.Getvalue().GetTav());    
            }

            Eyal = pointer;
            return Eyal;
        }
        static void Main(string[] args)
        {
         
        }
    }
}
