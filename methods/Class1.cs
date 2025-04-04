namespace Project1;

public class Class1 {

    // private: The member is accessible only within the type (class, struct, etc.) that contains it.
    //      Default accessability for memebers of classes and structs.
    private static int privateField;

    // protected: The member is accessible within the type that contains it and by derived types, 
    //      regardless of whether they are in the same project.
    protected int protectedField;

    // internal: The member is accessible only within the same project. This means that other types 
    //      within the same project can access the member, but types in other projects cannot.
    internal int internalField;

    // protected internal: The member is accessible within the same project and by derived types, 
    //      even if they are in different projects.
    protected internal int protectedInternalField;

    // private protected: The member is accessible within the same project and by derived types within the same project.
    private protected int privateProtectedField;

    // public: The member is accessible from any other code.
    //      Default accessability for memebers of interfaces and enums.
    public int publicField;

    internal int InternalProperty { get; set; }

    public Class1(
        int privateFieldParam,
        int protectedField,
        int internalField,
        int protectedInternalField,
        int privateProtectedField) {
            privateField = privateFieldParam;
            this.protectedField = protectedField;  // this is required when the parameter name is the same as the field name
            this.internalField = internalField;
            this.protectedInternalField = protectedInternalField;
            this.privateProtectedField = privateProtectedField;
    }

    public void DisplayFieldsAndProperties() {
        Console.WriteLine($"Class 1 privateField: {privateField}");
        Console.WriteLine($"Class 1 protectedField: {protectedField}");
        Console.WriteLine($"Class 1 internalField: {internalField}");
        Console.WriteLine($"Class 1 protectedInternalField: {protectedInternalField}");
        Console.WriteLine($"Class 1 privateProtectedField: {privateProtectedField}");
        Console.WriteLine($"Class 1 publicField: {publicField}");
        Console.WriteLine($"Class 1 InnternalProperty: {InternalProperty}");
    }
}