using Patterns;
using static System.Console;

namespace Patterns
{
    internal class Patterns
    {
        static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 300);
            drink.Consume();

            WriteLine("\r\n");

            ICar car = new CarProxy(new Driver(12));
            car.Drive();

            WriteLine("\r\n");

            var ba = new BankAccount(100);
            var m1 = ba.Deposit(50); // 150
            var m2 = ba.Deposit(25); // 175
            WriteLine(ba);

            // restore to m1
            ba.Restore(m1);
            WriteLine(ba);

            ba.Restore(m2);
            WriteLine(ba);


        }
    }
}
