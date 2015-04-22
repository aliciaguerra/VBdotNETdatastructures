Sub DisplayNums(ByVal arr() As Integer)
Dim index As Integer
For index=0 To arr.GetUpperBound(0)
Console.Write(arr.(index))
Next
End Sub

Dim startTime As DateTime
Dim endTime As TimeSpan
startTime=DateTime.Now
DisplayNums(nums)
endTime=DateTime.Now.Subtract(startTime)
