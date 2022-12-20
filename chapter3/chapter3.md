## Types, Objects, and Namespaces

#### Classes

Classes are code definitions for objects and it can be used to create many objects as needed.

Classes interacts with each other with the help of three key ingredients:

- Properties: allows you to access an object's data. Some properties may be read-only - cannot be modified, while others can be changed.
- Method: allows you to perform an action on an object.
- Events: provides notifications that something has happened. Example is using a Button object to fire a Click event.

A class must be defined in a class block:

```
vb
Public Class SampleClass
	' Class code goes here
End Class
```

#### Building a Basic Class

A local variable exists only until the current method ends. On the other hand, a member variable (or field) is
declared as part of a class. It's available to all the methods in the class; it's created when the object is created; and it lives as long as the containing object lives.

```
vb
Public Class Product
Private name As String
Private price As Decimal
Private imageUrl As String
End Class
```

#### Assessibility Keywords

| Keyword   | Assessibility                                                                                 |
| --------- | --------------------------------------------------------------------------------------------- |
| Public    | Can be accessed by any class                                                                  |
| Private   | Can be accessed by only members inside the current class                                      |
| Friend    |                                                                                               |
| Protected | Can be accessed by methods in the current class or in any class that inherits from this class |

#### Creating an Object

When creating an object, you need to specify the New keyword.

```
vb
Dim saleProduct As New Product()
' Optionally you could do this in two steps:
' Dim saleProduct As Product
' saleProduct = new Product()
```

#### Adding Propertied to Objects

Accessors usually have two parts. 

* The Get accessor allows your code to retrieve data from the object.
* The Set accessor allows your code to set the object's data.

In some cases, you might omit one of these parts, such as when you want to create a property that can be examined but not modified.

```
vb
Public Class Product
Private _name As String
Private _price As Decimal
Private _imageUrl As String
Public Property Name() As String
Get
Return _name
End Get
Set(ByVal value As String)
_name = value
End Set
End Property
Public Property Price() As Decimal
Get
Return _price
End Get
Set(ByVal value As Decimal)
_price = value
End Set
End Property
Public Property ImageUrl() As String
Get
Return _imageUrl
End Get
Set(ByVal value As String)
_imageUrl = value
End Set
End Property
End Class
```
