<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DolarListPrice = New System.Windows.Forms.ListBox
        Me.BuyLabel = New System.Windows.Forms.Label
        Me.SellLabel = New System.Windows.Forms.Label
        Me.BuyPriceLabel = New System.Windows.Forms.Label
        Me.SellPriceLabel = New System.Windows.Forms.Label
        Me.UpdateButton = New System.Windows.Forms.Button
        Me.TotalBuyPrice = New System.Windows.Forms.Label
        Me.TotalSellPrice = New System.Windows.Forms.Label
        Me.TotalBuyPriceInput = New System.Windows.Forms.NumericUpDown
        Me.TotalSellPriceInput = New System.Windows.Forms.NumericUpDown
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.TotalBuyPriceInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TotalSellPriceInput, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DolarListPrice
        '
        Me.DolarListPrice.FormattingEnabled = True
        Me.DolarListPrice.Location = New System.Drawing.Point(12, 12)
        Me.DolarListPrice.Name = "DolarListPrice"
        Me.DolarListPrice.Size = New System.Drawing.Size(120, 95)
        Me.DolarListPrice.TabIndex = 0
        '
        'BuyLabel
        '
        Me.BuyLabel.AutoSize = True
        Me.BuyLabel.Location = New System.Drawing.Point(161, 23)
        Me.BuyLabel.Name = "BuyLabel"
        Me.BuyLabel.Size = New System.Drawing.Size(43, 13)
        Me.BuyLabel.TabIndex = 1
        Me.BuyLabel.Text = "Compra"
        '
        'SellLabel
        '
        Me.SellLabel.AutoSize = True
        Me.SellLabel.Location = New System.Drawing.Point(255, 23)
        Me.SellLabel.Name = "SellLabel"
        Me.SellLabel.Size = New System.Drawing.Size(35, 13)
        Me.SellLabel.TabIndex = 2
        Me.SellLabel.Text = "Venta"
        '
        'BuyPriceLabel
        '
        Me.BuyPriceLabel.AutoSize = True
        Me.BuyPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuyPriceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuyPriceLabel.Location = New System.Drawing.Point(163, 50)
        Me.BuyPriceLabel.Name = "BuyPriceLabel"
        Me.BuyPriceLabel.Size = New System.Drawing.Size(29, 20)
        Me.BuyPriceLabel.TabIndex = 3
        Me.BuyPriceLabel.Text = "$0"
        Me.BuyPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SellPriceLabel
        '
        Me.SellPriceLabel.AutoSize = True
        Me.SellPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellPriceLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SellPriceLabel.Location = New System.Drawing.Point(254, 50)
        Me.SellPriceLabel.Name = "SellPriceLabel"
        Me.SellPriceLabel.Size = New System.Drawing.Size(29, 20)
        Me.SellPriceLabel.TabIndex = 4
        Me.SellPriceLabel.Text = "$0"
        Me.SellPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(186, 77)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 5
        Me.UpdateButton.Text = "Actualizar"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'TotalBuyPrice
        '
        Me.TotalBuyPrice.AutoSize = True
        Me.TotalBuyPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalBuyPrice.Location = New System.Drawing.Point(12, 127)
        Me.TotalBuyPrice.Name = "TotalBuyPrice"
        Me.TotalBuyPrice.Size = New System.Drawing.Size(32, 24)
        Me.TotalBuyPrice.TabIndex = 6
        Me.TotalBuyPrice.Text = "$0"
        '
        'TotalSellPrice
        '
        Me.TotalSellPrice.AutoSize = True
        Me.TotalSellPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalSellPrice.Location = New System.Drawing.Point(12, 169)
        Me.TotalSellPrice.Name = "TotalSellPrice"
        Me.TotalSellPrice.Size = New System.Drawing.Size(32, 24)
        Me.TotalSellPrice.TabIndex = 7
        Me.TotalSellPrice.Text = "$0"
        '
        'TotalBuyPriceInput
        '
        Me.TotalBuyPriceInput.Location = New System.Drawing.Point(207, 133)
        Me.TotalBuyPriceInput.Name = "TotalBuyPriceInput"
        Me.TotalBuyPriceInput.Size = New System.Drawing.Size(120, 20)
        Me.TotalBuyPriceInput.TabIndex = 10
        '
        'TotalSellPriceInput
        '
        Me.TotalSellPriceInput.Location = New System.Drawing.Point(207, 167)
        Me.TotalSellPriceInput.Name = "TotalSellPriceInput"
        Me.TotalSellPriceInput.Size = New System.Drawing.Size(120, 20)
        Me.TotalSellPriceInput.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Compra"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Venta"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 199)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TotalSellPriceInput)
        Me.Controls.Add(Me.TotalBuyPriceInput)
        Me.Controls.Add(Me.TotalSellPrice)
        Me.Controls.Add(Me.TotalBuyPrice)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.SellPriceLabel)
        Me.Controls.Add(Me.BuyPriceLabel)
        Me.Controls.Add(Me.SellLabel)
        Me.Controls.Add(Me.BuyLabel)
        Me.Controls.Add(Me.DolarListPrice)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.TotalBuyPriceInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TotalSellPriceInput, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DolarListPrice As System.Windows.Forms.ListBox
    Friend WithEvents BuyLabel As System.Windows.Forms.Label
    Friend WithEvents SellLabel As System.Windows.Forms.Label
    Friend WithEvents BuyPriceLabel As System.Windows.Forms.Label
    Friend WithEvents SellPriceLabel As System.Windows.Forms.Label
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents TotalBuyPrice As System.Windows.Forms.Label
    Friend WithEvents TotalSellPrice As System.Windows.Forms.Label
    Friend WithEvents TotalBuyPriceInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents TotalSellPriceInput As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
