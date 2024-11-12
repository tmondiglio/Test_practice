using Classes;

namespace Program{
    public class Program{
        public static void Main(string[] args){
            Classes.LinkedList<int> l = new Classes.LinkedList<int>(1);
            l.add(2);
            l.add(3);
            l.add(4);
            l.printList();
            l.addIn(5, 2);
            Console.WriteLine(" ");
            l.printList();
        }
    }
}