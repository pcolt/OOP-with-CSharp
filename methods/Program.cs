
class Program {
    static void Main() {

        Methods.printTripleNumberConsole();
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