<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.num7 = New System.Windows.Forms.Button()
        Me.num8 = New System.Windows.Forms.Button()
        Me.num9 = New System.Windows.Forms.Button()
        Me.num4 = New System.Windows.Forms.Button()
        Me.num5 = New System.Windows.Forms.Button()
        Me.num6 = New System.Windows.Forms.Button()
        Me.num1 = New System.Windows.Forms.Button()
        Me.num2 = New System.Windows.Forms.Button()
        Me.num3 = New System.Windows.Forms.Button()
        Me.btnpoint = New System.Windows.Forms.Button()
        Me.num0 = New System.Windows.Forms.Button()
        Me.equ = New System.Windows.Forms.Button()
        Me.div = New System.Windows.Forms.Button()
        Me.min = New System.Windows.Forms.Button()
        Me.mul = New System.Windows.Forms.Button()
        Me.plus = New System.Windows.Forms.Button()
        Me.btnc = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(324, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "0"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'num7
        '
        Me.num7.Location = New System.Drawing.Point(12, 67)
        Me.num7.Name = "num7"
        Me.num7.Size = New System.Drawing.Size(60, 60)
        Me.num7.TabIndex = 1
        Me.num7.Text = "7"
        Me.num7.UseVisualStyleBackColor = True
        '
        'num8
        '
        Me.num8.Location = New System.Drawing.Point(78, 67)
        Me.num8.Name = "num8"
        Me.num8.Size = New System.Drawing.Size(60, 60)
        Me.num8.TabIndex = 2
        Me.num8.Text = "8"
        Me.num8.UseVisualStyleBackColor = True
        '
        'num9
        '
        Me.num9.Location = New System.Drawing.Point(144, 67)
        Me.num9.Name = "num9"
        Me.num9.Size = New System.Drawing.Size(60, 60)
        Me.num9.TabIndex = 3
        Me.num9.Text = "9"
        Me.num9.UseVisualStyleBackColor = True
        '
        'num4
        '
        Me.num4.Location = New System.Drawing.Point(12, 127)
        Me.num4.Name = "num4"
        Me.num4.Size = New System.Drawing.Size(60, 60)
        Me.num4.TabIndex = 4
        Me.num4.Text = "4"
        Me.num4.UseVisualStyleBackColor = True
        '
        'num5
        '
        Me.num5.Location = New System.Drawing.Point(78, 127)
        Me.num5.Name = "num5"
        Me.num5.Size = New System.Drawing.Size(60, 60)
        Me.num5.TabIndex = 5
        Me.num5.Text = "5"
        Me.num5.UseVisualStyleBackColor = True
        '
        'num6
        '
        Me.num6.Location = New System.Drawing.Point(144, 127)
        Me.num6.Name = "num6"
        Me.num6.Size = New System.Drawing.Size(60, 60)
        Me.num6.TabIndex = 6
        Me.num6.Text = "6"
        Me.num6.UseVisualStyleBackColor = True
        '
        'num1
        '
        Me.num1.Location = New System.Drawing.Point(12, 187)
        Me.num1.Name = "num1"
        Me.num1.Size = New System.Drawing.Size(60, 60)
        Me.num1.TabIndex = 7
        Me.num1.Text = "1"
        Me.num1.UseVisualStyleBackColor = True
        '
        'num2
        '
        Me.num2.Location = New System.Drawing.Point(78, 187)
        Me.num2.Name = "num2"
        Me.num2.Size = New System.Drawing.Size(60, 60)
        Me.num2.TabIndex = 8
        Me.num2.Text = "2"
        Me.num2.UseVisualStyleBackColor = True
        '
        'num3
        '
        Me.num3.Location = New System.Drawing.Point(144, 187)
        Me.num3.Name = "num3"
        Me.num3.Size = New System.Drawing.Size(60, 60)
        Me.num3.TabIndex = 9
        Me.num3.Text = "3"
        Me.num3.UseVisualStyleBackColor = True
        '
        'btnpoint
        '
        Me.btnpoint.Location = New System.Drawing.Point(12, 247)
        Me.btnpoint.Name = "btnpoint"
        Me.btnpoint.Size = New System.Drawing.Size(60, 60)
        Me.btnpoint.TabIndex = 10
        Me.btnpoint.Text = "."
        Me.btnpoint.UseVisualStyleBackColor = True
        '
        'num0
        '
        Me.num0.Location = New System.Drawing.Point(78, 247)
        Me.num0.Name = "num0"
        Me.num0.Size = New System.Drawing.Size(60, 60)
        Me.num0.TabIndex = 11
        Me.num0.Text = "0"
        Me.num0.UseVisualStyleBackColor = True
        '
        'equ
        '
        Me.equ.Location = New System.Drawing.Point(144, 247)
        Me.equ.Name = "equ"
        Me.equ.Size = New System.Drawing.Size(60, 60)
        Me.equ.TabIndex = 12
        Me.equ.Text = "="
        Me.equ.UseVisualStyleBackColor = True
        '
        'div
        '
        Me.div.Location = New System.Drawing.Point(276, 127)
        Me.div.Name = "div"
        Me.div.Size = New System.Drawing.Size(60, 60)
        Me.div.TabIndex = 16
        Me.div.Text = "/"
        Me.div.UseVisualStyleBackColor = True
        '
        'min
        '
        Me.min.Location = New System.Drawing.Point(276, 67)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(60, 60)
        Me.min.TabIndex = 15
        Me.min.Text = "-"
        Me.min.UseVisualStyleBackColor = True
        '
        'mul
        '
        Me.mul.Location = New System.Drawing.Point(210, 127)
        Me.mul.Name = "mul"
        Me.mul.Size = New System.Drawing.Size(60, 60)
        Me.mul.TabIndex = 14
        Me.mul.Text = "*"
        Me.mul.UseVisualStyleBackColor = True
        '
        'plus
        '
        Me.plus.Location = New System.Drawing.Point(210, 67)
        Me.plus.Name = "plus"
        Me.plus.Size = New System.Drawing.Size(60, 60)
        Me.plus.TabIndex = 13
        Me.plus.Text = "+"
        Me.plus.UseVisualStyleBackColor = True
        '
        'btnc
        '
        Me.btnc.Location = New System.Drawing.Point(210, 193)
        Me.btnc.Name = "btnc"
        Me.btnc.Size = New System.Drawing.Size(126, 54)
        Me.btnc.TabIndex = 17
        Me.btnc.Text = "C"
        Me.btnc.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Location = New System.Drawing.Point(210, 253)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(126, 54)
        Me.btnexit.TabIndex = 18
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 332)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnc)
        Me.Controls.Add(Me.div)
        Me.Controls.Add(Me.min)
        Me.Controls.Add(Me.mul)
        Me.Controls.Add(Me.plus)
        Me.Controls.Add(Me.equ)
        Me.Controls.Add(Me.num0)
        Me.Controls.Add(Me.btnpoint)
        Me.Controls.Add(Me.num3)
        Me.Controls.Add(Me.num2)
        Me.Controls.Add(Me.num1)
        Me.Controls.Add(Me.num6)
        Me.Controls.Add(Me.num5)
        Me.Controls.Add(Me.num4)
        Me.Controls.Add(Me.num9)
        Me.Controls.Add(Me.num8)
        Me.Controls.Add(Me.num7)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents num7 As System.Windows.Forms.Button
    Friend WithEvents num8 As System.Windows.Forms.Button
    Friend WithEvents num9 As System.Windows.Forms.Button
    Friend WithEvents num4 As System.Windows.Forms.Button
    Friend WithEvents num5 As System.Windows.Forms.Button
    Friend WithEvents num6 As System.Windows.Forms.Button
    Friend WithEvents num1 As System.Windows.Forms.Button
    Friend WithEvents num2 As System.Windows.Forms.Button
    Friend WithEvents num3 As System.Windows.Forms.Button
    Friend WithEvents btnpoint As System.Windows.Forms.Button
    Friend WithEvents num0 As System.Windows.Forms.Button
    Friend WithEvents equ As System.Windows.Forms.Button
    Friend WithEvents div As System.Windows.Forms.Button
    Friend WithEvents min As System.Windows.Forms.Button
    Friend WithEvents mul As System.Windows.Forms.Button
    Friend WithEvents plus As System.Windows.Forms.Button
    Friend WithEvents btnc As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button

End Class
