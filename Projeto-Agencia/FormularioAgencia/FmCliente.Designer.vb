<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmCliente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.txtDataNascimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNomeCliente = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCadCliente = New System.Windows.Forms.Button()
        Me.btnNovoPacote = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtCpf
        '
        Me.txtCpf.Location = New System.Drawing.Point(12, 86)
        Me.txtCpf.Mask = "000,000,000-00"
        Me.txtCpf.Name = "txtCpf"
        Me.txtCpf.Size = New System.Drawing.Size(107, 20)
        Me.txtCpf.TabIndex = 2
        '
        'txtDataNascimento
        '
        Me.txtDataNascimento.Location = New System.Drawing.Point(12, 143)
        Me.txtDataNascimento.Mask = "00/00/0000"
        Me.txtDataNascimento.Name = "txtDataNascimento"
        Me.txtDataNascimento.Size = New System.Drawing.Size(86, 20)
        Me.txtDataNascimento.TabIndex = 3
        Me.txtDataNascimento.ValidatingType = GetType(Date)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 127)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(89, 13)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Data Nascimento"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(27, 13)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "CPF"
        '
        'txtNomeCliente
        '
        Me.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeCliente.Location = New System.Drawing.Point(12, 30)
        Me.txtNomeCliente.Name = "txtNomeCliente"
        Me.txtNomeCliente.Size = New System.Drawing.Size(291, 20)
        Me.txtNomeCliente.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(70, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Nome Cliente"
        '
        'btnCadCliente
        '
        Me.btnCadCliente.Location = New System.Drawing.Point(12, 197)
        Me.btnCadCliente.Name = "btnCadCliente"
        Me.btnCadCliente.Size = New System.Drawing.Size(114, 37)
        Me.btnCadCliente.TabIndex = 19
        Me.btnCadCliente.Text = "Cadastrar"
        Me.btnCadCliente.UseVisualStyleBackColor = True
        '
        'btnNovoPacote
        '
        Me.btnNovoPacote.Location = New System.Drawing.Point(173, 196)
        Me.btnNovoPacote.Name = "btnNovoPacote"
        Me.btnNovoPacote.Size = New System.Drawing.Size(114, 37)
        Me.btnNovoPacote.TabIndex = 20
        Me.btnNovoPacote.Text = "Novo"
        Me.btnNovoPacote.UseVisualStyleBackColor = True
        '
        'FmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 363)
        Me.Controls.Add(Me.btnNovoPacote)
        Me.Controls.Add(Me.btnCadCliente)
        Me.Controls.Add(Me.txtCpf)
        Me.Controls.Add(Me.txtDataNascimento)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNomeCliente)
        Me.Controls.Add(Me.Label11)
        Me.Name = "FmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCpf As MaskedTextBox
    Friend WithEvents txtDataNascimento As MaskedTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txtNomeCliente As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCadCliente As Button
    Friend WithEvents btnNovoPacote As Button
End Class
