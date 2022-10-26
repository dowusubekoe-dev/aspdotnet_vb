# The Visual Basic Language

#### Variables

A variable is declared by giving it a name and specifying the type. To declare a local variable, the Dim statement is used.

```
vb
' Declare an integer variable named ErrorCode.
Dim ErrorCode As Integer

' Declare a string variable named MyName.
Dim MyName As String
```

##### Assignment and Initializers

```
vb
Dim ErrorCode As Integer = 10
Dim MyName As String = "Derek"
```

Number are automatically initialized to 0 (zero) and strings are initialized to an empty string (" ")

```
vb
Dim Number As Integer
Number = Number + 1
```

#### Arrays

Arrays allow you to store a series of values that have the same data types.

```
vb
' Create an array with four strings (form index 0 to index 3).
Dim StringArray(3) As String
' Create a 2 x 4 grid array (with a total fo eight integers).
Dim IntArray(1, 3) As Integer

' Create an array with four strings, one for each number from 1 to 4.
Dim StringArray() As String = {"1", "2", "3", "4"}


' Create a 4 x 2 array (a grid with four rows and two columns).
Dim IntArray(,) As Integer = {{1, 2}, {3, 4}, {5, 6}, {7, 8}}
```

##### Assessing element in an Array

To access an element in an array, you specify the corresponding index number in parentheses. Array
indices are always zero-based. That means that MyArray(0) accesses the first value in a one-dimensional array,
MyArray(1) accesses the second value, and so on.

```
vb
Dim IntArray() As Integer = {1, 2, 3, 4}
Dim Element As Integer
Element = IntArray(2)

In a two-dimensional array, you need two index numbers:
Dim IntArray(,) As Integer = {{1, 2}, {3, 4}, {5, 6}, {7, 8}}
' Access the value in row 0 (first row), column 1 (second column).
Dim Element As Integer
Element = IntArray(0, 1)
```

Any array can be resized. To resize an array, you need to use the ReDim keyword.

```
vb
Dim MyArray(10, 10) As Integer
ReDim MyArray(20, 20)
```

To preserve the contents, you can use the optional Preserve keyword when redimensioning the array.

```
vb
Dim MyArray(10, 10) As Integer
ReDim Preserve MyArray(10, 20) ' Allowed, and the contents will remain.
ReDim Preserve MyArray(20, 20) ' Not allowed. A runtime error will occur.
```

##### Variable Operations

When working with numbers, you can use various math symbols. VB follows the conventional order of operations - PEDMAS

```
vb
Dim Number As Integer
Number = 4 + 2 * 3	' Number will be 10.

Number = (4 + 2) * 3	' Number will be 18.
```

##### Object-Based Manipulation

```
vb
Dim MyString As String
Dim MyInteger As Integer = 100
' Convert a number to a string. MyString will have the contents "100".
MyString = MyInteger.ToString()
```

##### The DateTime and TimeSpan Types

The DateTime and TimeSpan data types also have built-in methods and properties.

This block of code creates a DateTime object, sets it to the current date and
time, and adds a number of days.

```
vb
Dim MyDate As DateTime = DateTime.Now
MyDate = MyDate.AddDays(100)
Dim DateString As String = MyDate.Year.ToString()
```

This block of code shows how to use a TimeSpan object to find the total number of minutes between two DateTime objects.


```Dim
vb
Dim MyDate2 As Date = DateTime.Now.AddHours(3000)
Dim Difference As TimeSpan
Difference = MyDate2.Subtract(MyDate1)
Dim NumberOfMinutes As Double
NumberOfMinutes = Difference.TotalMinutes
```

##### Conditional Logic & Loops


##### Methods

Methods are the most basic building block you can use to organize your code.

##### Delegates

Delegates allow you to create a variable that “points” to a method. You can use this variable at any time to invoke
the method.

```
vb
' Create a delegate variable.
Dim FunctionReference As StringFunction

' Store a reference to a matching method in the delegate.
FunctionReference = AddressOf TranslateEnglishToFrench

' Run the method that FunctionReference points to.
' In this case, it will be TranslateEnglishToFrench().
Dim FrenchString As String
FrenchString = FunctionReference("Hello")
```
