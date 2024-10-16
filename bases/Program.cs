class Program {
    static void Main() {
        Console.WriteLine("# 6: Find the sum of all numbers from 1 to 20.");
        Console.WriteLine(Bases.sumFromOneToTwenty());

        Console.WriteLine("# 10: Find if a number is prime with a for loop.");
        Console.WriteLine(Bases.findIfNumberIsPrimeForLoop(11));

        Console.WriteLine("# 10: Find if a number is prime with a while loop.");
        Console.WriteLine(Bases.findIfNumberIsPrimeWhile(11));
    }
    
    static class Bases {
        public static int sumFromOneToTwenty() {
            var sum = 0;
            for (int i = 1; i <= 20; i++) {
                sum += i;
            }
            return sum;
        }

        public static bool findIfNumberIsPrimeForLoop(int number) {
            if (number < 2) {
                return false;
            } else if (number == 2) {
                return true;
            }
            for (int i = 2; i < number; i++) {
                if (number % i == 0) {
                    return false;
                }
            }
            return true;
        }

        public static bool findIfNumberIsPrimeWhile(int number) {
            var i = 2;
            if (number < 2) {
                return false;
            } else if (number == 2) {
                return true;
            }
            while (i < number) {
                if (number % i == 0) {
                    return false;
                }
                i++;
            } 
            return true;
        }
    }
}