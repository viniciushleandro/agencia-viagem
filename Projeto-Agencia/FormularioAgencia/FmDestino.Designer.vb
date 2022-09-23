<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmDestino
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCadDestino = New System.Windows.Forms.Button()
        Me.txtUf = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtCodDestino = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btnNovoPacote = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCadDestino
        '
        Me.btnCadDestino.Location = New System.Drawing.Point(15, 211)
        Me.btnCadDestino.Name = "btnCadDestino"
        Me.btnCadDestino.Size = New System.Drawing.Size(119, 41)
        Me.btnCadDestino.TabIndex = 28
        Me.btnCadDestino.Text = "Cadastrar"
        Me.btnCadDestino.UseVisualStyleBackColor = True
        '
        'txtUf
        '
        Me.txtUf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUf.Location = New System.Drawing.Point(15, 147)
        Me.txtUf.Name = "txtUf"
        Me.txtUf.Size = New System.Drawing.Size(74, 20)
        Me.txtUf.TabIndex = 24
        '
        'txtCidade
        '
        Me.txtCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCidade.Location = New System.Drawing.Point(15, 88)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(186, 20)
        Me.txtCidade.TabIndex = 23
        '
        'txtCodDestino
        '
        Me.txtCodDestino.Location = New System.Drawing.Point(15, 25)
        Me.txtCodDestino.Name = "txtCodDestino"
        Me.txtCodDestino.Size = New System.Drawing.Size(93, 20)
        Me.txtCodDestino.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "UF"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Cidade"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Código"
        '
        'btnNovoPacote
        '
        Me.btnNovoPacote.Location = New System.Drawing.Point(195, 214)
        Me.btnNovoPacote.Name = "btnNovoPacote"
        Me.btnNovoPacote.Size = New System.Drawing.Size(119, 41)
        Me.btnNovoPacote.TabIndex = 29
        Me.btnNovoPacote.Text = "Novo"
        Me.btnNovoPacote.UseVisualStyleBackColor = True
        '
        'FmDestino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(353, 365)
        Me.Controls.Add(Me.btnNovoPacote)
        Me.Controls.Add(Me.btnCadDestino)
        Me.Controls.Add(Me.txtUf)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.txtCodDestino)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Name = "FmDestino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCadDestino As Button
    Friend WithEvents txtUf As TextBox
    Friend WithEvents txtCidade As TextBox
    Friend WithEvents txtCodDestino As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnNovoPacote As Button
End Class
