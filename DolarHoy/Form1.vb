Imports System.Globalization

Public Class Form1
    Dim webClient As System.Net.WebClient

    Dim listDolar As List(Of Dolar) = New List(Of Dolar)()
    Dim isSelectedDolar As Boolean = False
    Dim SelectedDolar As Dolar

    Private Sub Update_Prices()
        If listDolar.LongCount().CompareTo(0) Then
            listDolar.RemoveRange(0, listDolar.LongCount() - 1)
            DolarListPrice.Items.Clear()
        End If

        Dim response = Me.webClient.DownloadString("https://dolarapi.com/v1/dolares")
        Me.listDolar = New Dolar().DeserializeList(Of Dolar)(response)

        For Each dolar As Dolar In Me.listDolar
            DolarListPrice.Items.Add(dolar.casa)
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim webClient As New System.Net.WebClient
        Me.webClient = webClient
        Me.Update_Prices()


    End Sub

    Private Sub UpdateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateButton.Click
        Me.Update_Prices()
    End Sub

    Private Sub DolarListPrice_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DolarListPrice.SelectedIndexChanged
        Dim FilterdDolar = listDolar.First(Function(dolar As Dolar) dolar.casa Is DolarListPrice.SelectedItem)
        Me.SelectedDolar = FilterdDolar
        Me.isSelectedDolar = True

        BuyPriceLabel.Text = "$" + Me.SelectedDolar.compra.ToString()
        SellPriceLabel.Text = "$" + Me.SelectedDolar.venta.ToString()
    End Sub

    Private Sub TotalButPriceInput_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalBuyPriceInput.ValueChanged
        Dim value = TotalBuyPriceInput.Value
        TotalBuyPrice.Text = "$" + (value * Me.SelectedDolar.compra).ToString()
    End Sub

    Private Sub TotalSellPriceInput_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TotalSellPriceInput.ValueChanged
        Dim value = TotalSellPriceInput.Value
        TotalSellPrice.Text = "$" + (value * Me.SelectedDolar.venta).ToString()
    End Sub

End Class
