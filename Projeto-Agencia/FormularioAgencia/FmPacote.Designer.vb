<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmPacote
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumPacote = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbTpPasseio = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDataViagem = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDiarias = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPreco = New System.Windows.Forms.TextBox()
        Me.btnCadPacote = New System.Windows.Forms.Button()
        Me.grdDestinos = New System.Windows.Forms.DataGridView()
        Me.btnNovoPacote = New System.Windows.Forms.Button()
        CType(Me.grdDestinos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número do Pacote"
        '
        'txtNumPacote
        '
        Me.txtNumPacote.Location = New System.Drawing.Point(15, 25)
        Me.txtNumPacote.Name = "txtNumPacote"
        Me.txtNumPacote.Size = New System.Drawing.Size(93, 20)
        Me.txtNumPacote.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo de Passeio"
        '
        'cbTpPasseio
        '
        Me.cbTpPasseio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTpPasseio.FormattingEnabled = True
        Me.cbTpPasseio.Location = New System.Drawing.Point(15, 75)
        Me.cbTpPasseio.Name = "cbTpPasseio"
        Me.cbTpPasseio.Size = New System.Drawing.Size(121, 21)
        Me.cbTpPasseio.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Data Viagem"
        '
        'txtDataViagem
        '
        Me.txtDataViagem.Location = New System.Drawing.Point(15, 125)
        Me.txtDataViagem.Mask = "00/00/0000"
        Me.txtDataViagem.Name = "txtDataViagem"
        Me.txtDataViagem.Size = New System.Drawing.Size(91, 20)
        Me.txtDataViagem.TabIndex = 3
        Me.txtDataViagem.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Diárias"
        '
        'txtDiarias
        '
        Me.txtDiarias.Location = New System.Drawing.Point(15, 173)
        Me.txtDiarias.Name = "txtDiarias"
        Me.txtDiarias.Size = New System.Drawing.Size(83, 20)
        Me.txtDiarias.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 205)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Preço"
        '
        'txtPreco
        '
        Me.txtPreco.Location = New System.Drawing.Point(15, 221)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(104, 20)
        Me.txtPreco.TabIndex = 5
        '
        'btnCadPacote
        '
        Me.btnCadPacote.Location = New System.Drawing.Point(15, 270)
        Me.btnCadPacote.Name = "btnCadPacote"
        Me.btnCadPacote.Size = New System.Drawing.Size(121, 38)
        Me.btnCadPacote.TabIndex = 6
        Me.btnCadPacote.Text = "Cadastrar"
        Me.btnCadPacote.UseVisualStyleBackColor = True
        '
        'grdDestinos
        '
        Me.grdDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDestinos.Location = New System.Drawing.Point(15, 323)
        Me.grdDestinos.Name = "grdDestinos"
        Me.grdDestinos.Size = New System.Drawing.Size(322, 197)
        Me.grdDestinos.TabIndex = 11
        '
        'btnNovoPacote
        '
        Me.btnNovoPacote.Location = New System.Drawing.Point(189, 270)
        Me.btnNovoPacote.Name = "btnNovoPacote"
        Me.btnNovoPacote.Size = New System.Drawing.Size(121, 38)
        Me.btnNovoPacote.TabIndex = 12
        Me.btnNovoPacote.Text = "Novo"
        Me.btnNovoPacote.UseVisualStyleBackColor = True
        '
        'FmPacote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(349, 551)
        Me.Controls.Add(Me.btnNovoPacote)
        Me.Controls.Add(Me.grdDestinos)
        Me.Controls.Add(Me.btnCadPacote)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDiarias)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDataViagem)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbTpPasseio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNumPacote)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FmPacote"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.grdDestinos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumPacote As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbTpPasseio As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDataViagem As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDiarias As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPreco As TextBox
    Friend WithEvents btnCadPacote As Button
    Friend WithEvents grdDestinos As DataGridView
    Friend WithEvents btnNovoPacote As Button
End Class
