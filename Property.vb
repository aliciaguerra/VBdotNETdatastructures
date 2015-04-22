' A property method provides the ability to both set and retrieve the value of a data member within the same
' method definition. This is accomplished using the get set clause.
Public Property Xval() As Integer
Get
Return x
End Get
Set(ByVal Value As Integer)
x=Value
End Set
End Property

Public Property Yval() As Integer
Get
Return y
End Get
Set (ByVal Value as Integer)
y=Value
End Set
End Property
