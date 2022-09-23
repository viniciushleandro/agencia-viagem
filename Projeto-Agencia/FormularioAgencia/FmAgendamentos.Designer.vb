<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FmAgendamentos
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDataNascAgendamento = New System.Windows.Forms.MaskedTextBox()
        Me.lblNomeCliente = New System.Windows.Forms.Label()
        Me.txtCpfAgendar = New System.Windows.Forms.MaskedTextBox()
        Me.grdPacotes = New System.Windows.Forms.DataGridView()
        Me.btnCadAgendamento = New System.Windows.Forms.Button()
        Me.txtDataViagem = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNovoPacote = New System.Windows.Forms.Button()
        Me.txtDataAgendamento = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodAgendamento = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkPago = New System.Windows.Forms.CheckBox()
        CType(Me.grdPacotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(504, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Data Nascimento"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(346, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "CPF"
        '
        'txtDataNascAgendamento
        '
        Me.txtDataNascAgendamento.BackColor = System.Drawing.SystemColors.Menu
        Me.txtDataNascAgendamento.Enabled = False
        Me.txtDataNascAgendamento.Location = New System.Drawing.Point(507, 79)
        Me.txtDataNascAgendamento.Mask = "00/00/0000"
        Me.txtDataNascAgendamento.Name = "txtDataNascAgendamento"
        Me.txtDataNascAgendamento.Size = New System.Drawing.Size(105, 20)
        Me.txtDataNascAgendamento.TabIndex = 91
        Me.txtDataNascAgendamento.ValidatingType = GetType(Date)
        '
        'lblNomeCliente
        '
        Me.lblNomeCliente.BackColor = System.Drawing.SystemColors.Menu
        Me.lblNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNomeCliente.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.lblNomeCliente.Enabled = False
        Me.lblNomeCliente.Location = New System.Drawing.Point(15, 79)
        Me.lblNomeCliente.Name = "lblNomeCliente"
        Me.lblNomeCliente.Size = New System.Drawing.Size(288, 20)
        Me.lblNomeCliente.TabIndex = 90
        '
        'txtCpfAgendar
        '
        Me.txtCpfAgendar.Location = New System.Drawing.Point(349, 79)
        Me.txtCpfAgendar.Mask = "000,000,000-00"
        Me.txtCpfAgendar.Name = "txtCpfAgendar"
        Me.txtCpfAgendar.Size = New System.Drawing.Size(102, 20)
        Me.txtCpfAgendar.TabIndex = 4
        '
        'grdPacotes
        '
        Me.grdPacotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPacotes.Location = New System.Drawing.Point(11, 230)
        Me.grdPacotes.Name = "grdPacotes"
        Me.grdPacotes.Size = New System.Drawing.Size(641, 321)
        Me.grdPacotes.TabIndex = 7
        '
        'btnCadAgendamento
        '
        Me.btnCadAgendamento.Location = New System.Drawing.Point(15, 135)
        Me.btnCadAgendamento.Name = "btnCadAgendamento"
        Me.btnCadAgendamento.Size = New System.Drawing.Size(147, 53)
        Me.btnCadAgendamento.TabIndex = 5
        Me.btnCadAgendamento.Text = "Agendar"
        Me.btnCadAgendamento.UseVisualStyleBackColor = True
        '
        'txtDataViagem
        '
        Me.txtDataViagem.Location = New System.Drawing.Point(203, 25)
        Me.txtDataViagem.Mask = "00/00/0000"
        Me.txtDataViagem.Name = "txtDataViagem"
        Me.txtDataViagem.Size = New System.Drawing.Size(100, 20)
        Me.txtDataViagem.TabIndex = 2
        Me.txtDataViagem.ValidatingType = GetType(Date)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Nome Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(200, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Data Viagem (Busca)"
        '
        'btnNovoPacote
        '
        Me.btnNovoPacote.Location = New System.Drawing.Point(213, 135)
        Me.btnNovoPacote.Name = "btnNovoPacote"
        Me.btnNovoPacote.Size = New System.Drawing.Size(147, 53)
        Me.btnNovoPacote.TabIndex = 6
        Me.btnNovoPacote.Text = "Novo"
        Me.btnNovoPacote.UseVisualStyleBackColor = True
        '
        'txtDataAgendamento
        '
        Me.txtDataAgendamento.BackColor = System.Drawing.SystemColors.Menu
        Me.txtDataAgendamento.Enabled = False
        Me.txtDataAgendamento.Location = New System.Drawing.Point(379, 25)
        Me.txtDataAgendamento.Mask = "00/00/0000"
        Me.txtDataAgendamento.Name = "txtDataAgendamento"
        Me.txtDataAgendamento.Size = New System.Drawing.Size(100, 20)
        Me.txtDataAgendamento.TabIndex = 100
        Me.txtDataAgendamento.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(376, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Data Agendamento"
        '
        'txtCodAgendamento
        '
        Me.txtCodAgendamento.Location = New System.Drawing.Point(15, 24)
        Me.txtCodAgendamento.Name = "txtCodAgendamento"
        Me.txtCodAgendamento.Size = New System.Drawing.Size(100, 20)
        Me.txtCodAgendamento.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Código"
        '
        'chkPago
        '
        Me.chkPago.AutoSize = True
        Me.chkPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPago.Location = New System.Drawing.Point(552, 23)
        Me.chkPago.Name = "chkPago"
        Me.chkPago.Size = New System.Drawing.Size(60, 21)
        Me.chkPago.TabIndex = 3
        Me.chkPago.Text = "Pago"
        Me.chkPago.UseVisualStyleBackColor = True
        '
        'FmAgendamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 564)
        Me.Controls.Add(Me.chkPago)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCodAgendamento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDataAgendamento)
        Me.Controls.Add(Me.btnNovoPacote)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDataNascAgendamento)
        Me.Controls.Add(Me.lblNomeCliente)
        Me.Controls.Add(Me.txtCpfAgendar)
        Me.Controls.Add(Me.grdPacotes)
        Me.Controls.Add(Me.btnCadAgendamento)
        Me.Controls.Add(Me.txtDataViagem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(100000000, 603)
        Me.MinimumSize = New System.Drawing.Size(678, 603)
        Me.Name = "FmAgendamentos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.grdPacotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDataNascAgendamento As MaskedTextBox
    Friend WithEvents lblNomeCliente As Label
    Friend WithEvents txtCpfAgendar As MaskedTextBox
    Friend WithEvents grdPacotes As DataGridView
    Friend WithEvents btnCadAgendamento As Button
    Friend WithEvents txtDataViagem As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNovoPacote As Button
    Friend WithEvents txtDataAgendamento As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCodAgendamento As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkPago As CheckBox
End Class
