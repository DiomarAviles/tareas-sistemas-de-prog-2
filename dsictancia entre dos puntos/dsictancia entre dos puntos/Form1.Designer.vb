<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtx1 = New System.Windows.Forms.TextBox()
        Me.btn_calc = New System.Windows.Forms.Button()
        Me.txt_y1 = New System.Windows.Forms.TextBox()
        Me.txt_x2 = New System.Windows.Forms.TextBox()
        Me.txt_y2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_resultados = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(138, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(498, 54)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Distancia Entre Dos Puntos"
        '
        'txtx1
        '
        Me.txtx1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtx1.Location = New System.Drawing.Point(93, 170)
        Me.txtx1.Name = "txtx1"
        Me.txtx1.Size = New System.Drawing.Size(178, 43)
        Me.txtx1.TabIndex = 1
        '
        'btn_calc
        '
        Me.btn_calc.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_calc.Location = New System.Drawing.Point(327, 170)
        Me.btn_calc.Name = "btn_calc"
        Me.btn_calc.Size = New System.Drawing.Size(136, 43)
        Me.btn_calc.TabIndex = 5
        Me.btn_calc.Text = "Calcular"
        Me.btn_calc.UseVisualStyleBackColor = True
        '
        'txt_y1
        '
        Me.txt_y1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_y1.Location = New System.Drawing.Point(93, 257)
        Me.txt_y1.Name = "txt_y1"
        Me.txt_y1.Size = New System.Drawing.Size(178, 43)
        Me.txt_y1.TabIndex = 6
        '
        'txt_x2
        '
        Me.txt_x2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_x2.Location = New System.Drawing.Point(500, 170)
        Me.txt_x2.Name = "txt_x2"
        Me.txt_x2.Size = New System.Drawing.Size(179, 43)
        Me.txt_x2.TabIndex = 7
        '
        'txt_y2
        '
        Me.txt_y2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_y2.Location = New System.Drawing.Point(500, 257)
        Me.txt_y2.Name = "txt_y2"
        Me.txt_y2.Size = New System.Drawing.Size(179, 43)
        Me.txt_y2.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(327, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 43)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txt_resultados
        '
        Me.txt_resultados.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_resultados.Location = New System.Drawing.Point(393, 360)
        Me.txt_resultados.Name = "txt_resultados"
        Me.txt_resultados.Size = New System.Drawing.Size(192, 43)
        Me.txt_resultados.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(93, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 37)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "X1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(93, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 37)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Y1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(500, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 37)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "X2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(500, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 37)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Y2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(253, 360)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 37)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 552)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_resultados)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_y2)
        Me.Controls.Add(Me.txt_x2)
        Me.Controls.Add(Me.txt_y1)
        Me.Controls.Add(Me.btn_calc)
        Me.Controls.Add(Me.txtx1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtx1 As TextBox
    Friend WithEvents btn_calc As Button
    Friend WithEvents txt_y1 As TextBox
    Friend WithEvents txt_x2 As TextBox
    Friend WithEvents txt_y2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txt_resultados As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
