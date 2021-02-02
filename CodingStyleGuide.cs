
/*
 This guide is derrived from C# Coding Definitions put in place by Microsoft : 
    https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions 
 
 And slightly tweaked to fit this guide when formatting specifically for Unity C#:
    https://github.com/raywenderlich/c-sharp-style-guide

 And expanded upon by Google's C# Style Guide:
    https://google.github.io/styleguide/csharp-style.html
 
 */

// COMMENTS:
// Insert a space after the "//" in single line comments, capitalize the first letter, end each comment with a period /full-stop.
// Insert comments above the relavent code rather than on the same line (Ignore the fact I did that here).


// INDENTATION & SPACING
// Indendation should be done using spaces - not tabs! 

// Lines should be no longer than 100 Characters.


for (int i = 0; i < 10; i++)
{   
    Debug.Log("index=" + i);                        // Use 4 spaces for best readability.
}

// BRACE STYLE:
class MyClass                                       // Always include braces for conditional statements
{                                                   // put the opening brace on the line below the method, condition or class name.

    void DoSomething()
    {
        if (someTest)
        {
            
        }
        else
        {
           
        }

        for (int i = 0; i < 10; i++)
        {

        }

        switch (whichNumber)                       // If default statments are not met in a switch, remove them.
        {
            case 0:
                break;
            case 1:
                break;
            default:
                break
        }
    }
}


// CLASSES:
public class CodingStyleGuide						// Classes are PascalCase.
{

    // ACCESS MODIFIERS:
    public int publicInt;                           // Public access will appear inside the Unity inspector and is inherintly serialized.
    private int privateInt;                         // Private access variables will NOT appear in the Unity inspector, but are accessible only in the class.
    [SerializeField] private int serializedInt;    // Serialized private variables will appear in the inspector, I'd reccomend you'd do this for
                                                    // any variables you want accessible in the inspector! 

                                                    // If you need help with access modifiers like public, private, protected and static here's a good resource to learn about it:
                                                        https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers

    // FIELDS:
    public int publicField;							// All non-static fields are camelCase.
    int classPrivate;
    private int myPrivate;
    protected int myProtected;

    static int MyStatic;                            // Static fields are PascalCase.

    int _myInt;										// Avoid using underscores in declarations where possible.
    float a, b, c;                                  // Avoid multiple declarations on one line, prefer single declarations per line.


 // PROPERTIES:
    public int PageNumber                           // Properties are PascalCase
    {
        get { return pageNumber; }
        set { pageNumber = value; }
    }

// METHODS:
    // Description.
    void SomeMethod()								// Methods are PascalCase, always provide a description for methods that are not Unity Events 
                                                    // e.g. Start(), Update(), FixedUpdate() or OnTriggerEnter().
    {

    }

    // Description.
    void AnotherMethod(float myParameter)			// Method paramterers/ arguments are camelCase
    {

    }

    // Desciption.
    void AVeryLongFunctionNameThatCausesLineWrappingProblems(int longArgumentName,			// Avoid long method names, try and allign arugemnts witrh the first
                                                            int p1, int p2 int p3) 
    {
        
    }

    // Desciption.
    void AVeryLongFunctionNameThatCausesLineWrappingProblems(int longArgumentName,			// Avoid long method names, try and allign arugemnts witrh the first
                                                            int p1, int p2 int p3)
    {

    }

    // Description.
    void AnotherLongFunctionNameThatCausesLineWrappingProblems(								// If alligning the arguments is a bit difficult, feel free to put them on a new line like so
        int longArgumentName, int longArgumentName2, int longArgumentName3)
    {

    }
}