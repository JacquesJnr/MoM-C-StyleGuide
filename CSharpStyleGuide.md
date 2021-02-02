[![Unity Logo](https://github.com/JacquesJnr/MoM-CSharpStyleGuide/blob/main/GuideUnityIcon.png)](UnityLogo)
# Unity C# Coding Style Guide
***

## Table of Contents

- [Stylization](#stylization)
    + [Commenting](#commenting)
    + [Indentation & White Space](#indentation--white-space)
    + [Braces](#braces)
    + [Language](#language)
- [Declarations](#declarations)
    + [Classes](#classes)
    + [Fields](#fields)
    + [Array vs. List](#array-vs-list)
    + [Properties](#properties)
    + [Access Modifiers](#access-modifiers)
## Stylization: 
### Commenting
Insert a space after the "//" in single line comments, capitalize the first letter, end each with a full-stop/ period.
Insert comments above the relavent code rather than on the same line.
##### Avoid:
```csharp
int x = 0; // This variable is x.
```
##### Prefer:
```csharp
// This variable is x.
int x = 0;
```
### Indentation & White Space
+ Indendation should be done using spaces - not tabs!
+ Lines should not exceed 100 characters, let's avoid wrapping nightmares.
+ No line break between closing brace and else.
+ Braces used even when optional.
+ Space after `if/for/while`, and after commas.
+ No space after an opening parenthesis or before a closing parenthesis.
##### Example

```csharp
for (int i = 0; i < 10; i++)
{ 
    Debug.Log("index=" + i);                        // Use 4 spaces identation for best readability.
}
```
### Brace Styling
Always include braces for conditional statements, put the opening brace on the line below the method, condition or class name.
##### Avoid:

```csharp
 void BracesOnTheSameLine(){
        if (someTest)
            //..
    }
```
##### Prefer:

```csharp
 void BracesOnTheNextLine()
    {
        if (someTest)
        {
            //..
        }else {//..}
    }
```
### Language
Use U.S, English Spelling.
##### Avoid:

```csharp
  string theColourTrap = "Red";
```
##### Prefer:

```csharp
 string color = "Red";
```
*Editor's note - Reminder for others, like me who inherently use colour*  ;]


***
## Declarations:


### Classes 
Classes are written in **PascalCase**. For example:
```csharp
public class CodingStyleGuide()
{
    //..
}
```
### Access Modifiers and You

Unity uses its own serializer to display information inside of the inspector like this:


[![Image from Gyazo](https://i.gyazo.com/543dcc94a4503569f6e740e2d1a9e386.png)](https://gyazo.com/543dcc94a4503569f6e740e2d1a9e386)

`public` access variables can be accessed and modified by any other script AND is accessible by the Unity inspector.
```csharp
public int visibleToUnity;
```
`private` access variables will NOT appear in the Unity inspector, but are accessible in the class and scope they are defined in.
```csharp
private int invisibleToUnity;
```
In order to make a class or a variable private, but visible in the Unity inspector, they have to be explicity tagged as `SerializeField` for variables or `System.Serializable` for classes.
```csharp
[System.Serializable] private class VisiblePrivateClass()
{
    [SerializeField] private int privateButVisible;
}
```
If you need help understanding access modifiers like public, private, protected and static here's are some good resources to learn about it:
**[Microsoft C# Access Modifiers](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers)**
**[Unity C# Serialization](https://docs.unity3d.com/ScriptReference/SerializeField.html )**

### Fields
All non-static variables are written in **camelCase**. For example:
```csharp
    public int publicField;
    int classPrivate;
    private int myPrivate;
    protected int myProtected;
```
Do not declare more than one variable per line, avoid using underscores and Hungarian notation.
##### Avoid:
```csharp
    int _myInt;
    float a, b, c;
```
##### Prefer:
```csharp
    int myInt;
    float a:
    float b:
    float c;
```

### Array vs List
In general, prefer `List<>` over `array[]` for `public` variables, properties and return types.
+ Prefer `List<>` when the size of the container can change.
+ Prefer `array[]` when the size of the container is fixed and known at construction time.
+ Prefer `array[]` for multi-dimentional containers.
+ Note:
    + `array[]` and `List<>` both represent linear, contiguous containers.
    + Similar to C++ `array[]` vs `std::vector`, arrays are of fixed capacity, whereas `List<>` can be added to.
    + In some cases `array[]` are more performant, but in general `List<>` is more flexible.

### Properties
Properties are wrtitten in **PascalCase**. For example:

```csharp
public int PageNumber
    {
        get { return pageNumber; }
        set { pageNumber = value; }
    }
```
### Methods

 Methods are written in  **PascalCase**. Always provide a description for any methods, unless they are Unity Events. For Example:
 ```csharp
    // This method does this.
    void DoesThis(float myParameter)			// Method paramterers are camelCase
    {
    
    }
    
    void OnTriggerEnter2D(collision other)      // Unity Events require no description
    {
        
    }
 ```
 Long method names and argument names should be appropriatly formatted. Try and allignall method arguments with the first and avoid long method names:
 
 ##### Avoid:
```csharp
     // Desciption.
    void AVeryLongFunctionNameThatCausesLineWrappingProblems(int longArgumentName, int longArgumentName2, int longArgumentName3) 
    {
        
    }
```
##### Prefer:
```csharp
     void ShortFunctionName(
     int longArgumentName, int longArgumentName2, int longArgumentName3) 
    {
        
    }
```
***
##### This guide is derived from C# Coding Definitions put in place by Microsoft : 
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/coding-conventions 
##### Formatting from this guide when formatting specifically for Unity C#:
https://github.com/raywenderlich/c-sharp-style-guide
##### And expanded upon by Google's C# Style Guide:
https://google.github.io/styleguide/csharp-style.html

MoM-CSharpStyleGuide
Style increased to 100

