using Project2;

namespace Project1;

class Program {
    static void Main() {

        Methods.printTripleNumberConsole();

        var myClass1 = new Class1(10, 20, 30, 40, 50) {
            publicField = 60,
            InternalProperty = 70,
        };
        // myClass1.privateField = 10; // Error: privateField is not accessible outside of Class1
        // myClass1.protectedField = 20; // Error: protectedField is not accessible outside of Class1 or derived classes
        myClass1.internalField = 35;
        myClass1.protectedInternalField = 45;
        // myClass1.privateProtectedField = 50; // Error: privateProtectedField is not accessible
        myClass1.publicField = 65;
        myClass1.InternalProperty = 75;
        myClass1.DisplayFieldsAndProperties();
        var myClass2 = new Class2(110, 120, 130, 140, 150) {
            publicField = 160,
            InternalProperty = 170,
        };
        myClass2.AccessFields();
        var myClass3 = new Class3(210, 220, 230, 240, 250) {
            publicField = 260,
            InternalProperty = 270, // Constructor is still accessible because belongs to the same assembly: Class3 inherits from Class1
        };
        // myClass3.InnternalProperty = 275; // Error: Program.cs is in a different assembly
        myClass3.AccessFields();
    }

    class Methods {

        private static int _NumberParsed;

        private static bool askForNumber() {

            Console.WriteLine("Enter a number:");
            var input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input) && int.TryParse(input, out _)) {
                _NumberParsed = int.Parse(input);
                return true;
            } else {
                Console.WriteLine("Please enter a number.");
                return false;
            }
        }


        private static void printTripleNumber() {
            
            var triple = _NumberParsed * 3;
            Console.WriteLine(triple);
        }

        public static void printTripleNumberConsole() {

            Console.WriteLine("# 1: Print triple of a number from console input.");
            while (!askForNumber()) {
                askForNumber();
                break;
            }
            printTripleNumber();
        }
    }
}