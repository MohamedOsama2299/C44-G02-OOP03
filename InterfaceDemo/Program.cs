using InterfaceDemo.Tom_And_Jerry;

namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICartoonCharacter tom = new Tom();
            ICartoonCharacter jerry = new Jerry();
            ICartoonCharacter spike = new Spike();
            tom.ShowTalent();
            Console.WriteLine();
            jerry.ShowTalent();
            Console.WriteLine();
            spike.ShowTalent();


        }
    }
}
