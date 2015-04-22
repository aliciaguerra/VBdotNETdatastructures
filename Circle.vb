Public Class Circle
Inherits Point
Private radius as Single
Private Sub setRadius(ByVal r As Single)
If(r>0) Then
radius=r
Else
radius=0.0
End If
End Sub

Public Sub New(ByVal r As Single, ByVal x As - Integer, ByVal y as Integer)
MyBase.new(x,y)
setRadius(r)
End Sub

Public Sub New()
set radius(0)
End Sub

Public Sub New()
setRadius(0)
End Sub

Public ReadOnly Property getRadius() As Single
Get
Return radius
End Get
End Property

Public Function Area() As Single
Return Math.PI*radius*radius
End Function

Public Overrides Function.ToString() As String
Return "Center=" & Me.xval & "," & Me.Yval & -
End Function
End Class
