Imports System
Imports System.Reflection
Imports System.Text.RegularExpressions
Imports System.Globalization

Public Class JsonModel
    Dim stringResponseList As String

    Public Sub SetPropertyValue(ByVal propertyName As String, ByVal value As Object)
        Dim AttrType = CallByName(Me, propertyName, CallType.Get)
        CallByName(Me, propertyName, CallType.Set, value)

    End Sub

    Public Sub deserializeModel(ByVal stringResponse As String)
        Dim jsonString = stringResponse.Trim("{"c, "}"c).Trim()
        Dim keyValuePairs As String() = jsonString.Split(New String() {","}, StringSplitOptions.None)
        For Each pair As String In keyValuePairs
            Dim parts As String() = pair.Split(New String() {":"}, StringSplitOptions.None)
            If parts.Length = 2 Then
                Dim key As String = parts(0).Trim().Trim("""")
                Dim value As String = parts(1).Trim().Trim("""")

                Me.SetPropertyValue(key, value)

            End If
        Next
    End Sub

    Public Function DeserializeList(Of T)(ByVal stringResponse As String)
        ' Limpia la cadena y divide los objetos JSON individuales
        Dim cleanedJsonString As String = stringResponse.Replace(vbCrLf, String.Empty).Replace(vbLf, String.Empty).Replace(vbTab, String.Empty).Trim("["c, "]"c)
        cleanedJsonString = cleanedJsonString.Replace(vbCrLf, String.Empty).Replace(vbLf, String.Empty).Replace(vbTab, String.Empty).Trim()
        Dim pattern As String = "\{[^{}]*\}"
        Dim matches = Regex.Matches(cleanedJsonString, pattern)
        Dim listDolars As List(Of T) = New List(Of T)()
        For i As Integer = 0 To matches.Count - 1
            Dim currentValue = matches(i).Value
            Dim newInstance = Activator.CreateInstance(Me.GetType())
            newInstance.deserializeModel(currentValue)

            listDolars.Add(newInstance)
        Next
        Return listDolars
    End Function
End Class
Public Class Dolar
    Inherits JsonModel

    Public moneda As String = ""
    Public casa As String = ""
    Public nombre As String = ""

    Public compra As Decimal = 0.0
    Public venta As Decimal = 0.0

End Class
