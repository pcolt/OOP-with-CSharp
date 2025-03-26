using Project1;

namespace Project2;

public class Class3 : Project1.Class1 {

    public Class3(
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
        // Console.WriteLine(privateField); // Error: privateField is never accessible outside of the class
        Console.WriteLine(protectedField);  // Accessible because Class3 is derived from Class1
        // Console.WriteLine(internalField); // Error: internalField is not accessible in another project
        Console.WriteLine(protectedInternalField);  // Accessible because Class3 is derived from Class1 although in another project
        // Console.WriteLine(privateProtectedField); // Error: privateProtectedField is not accessible in another project
        Console.WriteLine(publicField);  // Accessible in any other code because public
        Console.WriteLine(InternalProperty);
    }
}
