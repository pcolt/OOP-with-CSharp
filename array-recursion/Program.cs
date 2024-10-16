class Program {
    static void Main() {
        Console.WriteLine("Values in between 1 and 1 included:");
        var result1 = ArrayRecursion.valuesInBetween(1, 1);
        foreach (var item in result1) {
            Console.WriteLine(item);
        }

        Console.WriteLine("Values in between 1 and 2 included:");
        var result2 = ArrayRecursion.valuesInBetween(1, 2);
        foreach (var item in result2) {
            Console.WriteLine(item);
        }

        Console.WriteLine("Values in between 3 and 6 included:");
        var result3 = ArrayRecursion.valuesInBetween(3, 6);
        foreach (var item in result3) {
            Console.WriteLine(item);
        }

        Console.WriteLine("Is 'pablo' a palindrome?");
        Console.WriteLine(ArrayRecursion.isPalindromeRecursive("pablo"));

        Console.WriteLine("Is 'anna' a palindrome?");
        Console.WriteLine(ArrayRecursion.isPalindromeRecursive("anna"));
    }

    struct ArrayRecursion {
        public static int[] valuesInBetween(int start, int end) {
            if (start == end) {
                return [start];
            } else {
                int[] result = new int[end - start + 1];
                var n = 0;
                for (int i = start; i <= end; i++) {
                    result[n] = i;
                    n++;
                }
                return result;
            }
        }

        public static bool isPalindromeRecursive(string word) {
            if (word.Length <= 1) {
                return true;
            } else { 
                if (word[0] == word[word.Length - 1]) {
                    return isPalindromeRecursive(word.Substring(1, word.Length - 2));
                } else {
                    return false;
                }
            }
        }
    }
}