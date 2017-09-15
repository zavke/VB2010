Public Class Form1
    Dim op As String = ""
    Dim tmp As Double = 0
    Dim tmp2 As Double = 0



    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub btnc_Click(sender As Object, e As EventArgs) Handles btnc.Click
        op = ""
        tmp = 0
        tmp2 = 0
        Label1.Text = "0"
    End Sub

    Private Sub num1_Click(sender As Object, e As EventArgs) Handles num1.Click
        If Label1.Text = "0" Then
            Label1.Text = ""
            Label1.Text += num1.Text
        Else
            Label1.Text += num1.Text
        End If

    End Sub

    Private Sub plus_Click(sender As Object, e As EventArgs) Handles plus.Click
        If op <> "+" Then

            Select Case op
                Case "-"
                    tmp2 -= CDbl(Label1.Text)
                Case "*"
                    tmp2 *= CDbl(Label1.Text)
                Case "/"
                    tmp2 /= CDbl(Label1.Text)
                Case ""
                    tmp = CDbl(Label1.Text)
                    tmp2 = tmp + tmp2
            End Select
            op = "+"
            Label1.Text = ""

        ElseIf Label1.Text = "" Then
            Exit Sub
        Else
            op = "+"
            tmp = CDbl(Label1.Text)
            tmp2 = tmp2 + tmp
            Label1.Text = ""
        End If
    End Sub

    Private Sub equ_Click(sender As Object, e As EventArgs) Handles equ.Click
        If Label1.Text = "" Then
            Exit Sub
        Else
            Select Case op
                Case "+"
                    Label1.Text = tmp2 + CDbl(Label1.Text)
                Case "-"
                    Label1.Text = tmp2 - CDbl(Label1.Text)
                Case "*"
                    Label1.Text = tmp2 * CDbl(Label1.Text)
                Case "/"
                    Label1.Text = tmp2 / CDbl(Label1.Text)
                Case Else
                    Label1.Text = Label1.Text
            End Select
            op = ""
            tmp = 0
            tmp2 = 0
        End If
    End Sub

    Private Sub num7_Click(sender As Object, e As EventArgs) Handles num7.Click
        If Label1.Text = "0" Then
            Label1.Text = ""
            Label1.Text += num7.Text
        Else
            Label1.Text += num7.Text
        End If
    End Sub

    Private Sub num3_Click(sender As Object, e As EventArgs) Handles num3.Click
        If Label1.Text = "0" Then
            Label1.Text = ""
            Label1.Text += num3.Text
        Else
            Label1.Text += num3.Text
        End If
    End Sub

    Private Sub num2_Click(sender As Object, e As EventArgs) Handles num2.Click
        If Label1.Text = "0" Then
            Label1.Text = ""
            Label1.Text += num2.Text
        Else
            Label1.Text += num2.Text
        End If
    End Sub

    Private Sub num4_Click(sender As Object, e As EventArgs) Handles num4.Click
        If Label1.Text = "0" Then
            Label1.Text = ""
            Label1.Text += num4.Text
        Else
            Label1.Text += num4.Text
        End If
    End Sub

    Private Sub num5_Click(sender As Object, e As EventArgs) Handles num5.Click
        If Label1.Text = "0" Then
            Label1.Text = ""
            Label1.Text += num5.Text
        Else
            Label1.Text += num5.Text
        End If
    End Sub

    Private Sub num9_Click(sender As Object, e As EventArgs) Handles num9.Click
        If Label1.Text = "0" Then
            Label1.Text = ""
            Label1.Text += num9.Text
        Else
            Label1.Text += num9.Text
        End If
    End Sub

    Private Sub num8_Click(sender As Object, e As EventArgs) Handles num8.Click
        If Label1.Text = "0" Then
            Label1.Text = ""
            Label1.Text += num8.Text
        Else
            Label1.Text += num8.Text
        End If
    End Sub

    Private Sub num6_Click(sender As Object, e As EventArgs) Handles num6.Click
        If Label1.Text = "0" Then
            Label1.Text = ""
            Label1.Text += num6.Text
        Else
            Label1.Text += num6.Text
        End If
    End Sub

    Private Sub num0_Click(sender As Object, e As EventArgs) Handles num0.Click
        If Label1.Text = "0" Then
            Label1.Text = ""
            Label1.Text += num0.Text
        Else
            Label1.Text += num0.Text
        End If
    End Sub

    Private Sub mul_Click(sender As Object, e As EventArgs) Handles mul.Click
        If op <> "*" Then

            Select Case op
                Case "-"
                    tmp2 -= CDbl(Label1.Text)
                Case "+"
                    tmp2 += CDbl(Label1.Text)
                Case "/"
                    tmp2 /= CDbl(Label1.Text)
                Case ""
                    tmp = CDbl(Label1.Text)
                    tmp2 = tmp * 1
            End Select
            op = "*"
            Label1.Text = ""
        ElseIf Label1.Text = "" Then
            Exit Sub
        Else
            op = "*"
            tmp = CDbl(Label1.Text)
            tmp2 = tmp2 * tmp
            Label1.Text = ""
        End If
    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        If op <> "/" Then

            Select Case op
                Case "-"
                    tmp2 -= CDbl(Label1.Text)
                Case "+"
                    tmp2 += CDbl(Label1.Text)
                Case "*"
                    tmp2 *= CDbl(Label1.Text)
                Case ""
                    tmp = CDbl(Label1.Text)
                    tmp2 = tmp / 1
            End Select
            op = "/"
            Label1.Text = ""
        ElseIf Label1.Text = "" Then
            Exit Sub
        Else
            op = "/"
            tmp = CDbl(Label1.Text)
            tmp2 = tmp2 / tmp
            Label1.Text = ""
        End If
    End Sub

    Private Sub min_Click(sender As Object, e As EventArgs) Handles min.Click
        If op <> "-" Then

            Select Case op
                Case "+"
                    tmp2 += CDbl(Label1.Text)
                Case "*"
                    tmp2 *= CDbl(Label1.Text)
                Case "/"
                    tmp2 /= CDbl(Label1.Text)
                Case ""
                    tmp = CDbl(Label1.Text)
                    tmp2 = tmp - tmp2
            End Select
            op = "-"
            Label1.Text = ""
        ElseIf Label1.Text = "" Then
            Exit Sub
        Else
            op = "-"
            tmp = CDbl(Label1.Text)
            tmp2 = tmp2 - tmp
            Label1.Text = ""
        End If
    End Sub

    Private Sub btnpoint_Click(sender As Object, e As EventArgs) Handles btnpoint.Click

        If InStr(Label1.Text, ".") > 0 Then
            Exit Sub
        Else
            Label1.Text += "."
        End If


    End Sub
End Class
