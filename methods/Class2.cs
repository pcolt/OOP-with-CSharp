namespace Project1;

public class Class2 : Class1 {
    public Class2 (
        int privateField,
        int protectedField,
        int internalField,
        int protectedInternalField,
        int privateProtectedField) : base(
            privateField,
            protectedField,
            internalField,
            protectedInternalField,
            privateProtectedField) {
        }
    public void AccessFields() {
        // Console.WriteLine(privateField); // Error: privateField is not accessible outside of Class1
        Console.WriteLine(protectedField); // Accessible because Class2 is derived from Class1
        Console.WriteLine(internalField);   // Accessible because Class2 is in the same project as Class1
        Console.WriteLine(protectedInternalField);
        Console.WriteLine(privateProtectedField);
        Console.WriteLine(publicField);
        Console.WriteLine(InternalProperty);
    }
}