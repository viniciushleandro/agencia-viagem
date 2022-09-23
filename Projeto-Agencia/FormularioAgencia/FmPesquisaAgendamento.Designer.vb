<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmPesquisaAgendamento
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
        Me.txtCpfPesq = New System.Windows.Forms.MaskedTextBox()
        Me.txtDataPesquisarAgendamento = New System.Windows.Forms.MaskedTextBox()
        Me.txtNomeClientePesq = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grdPesquisa = New System.Windows.Forms.DataGridView()
        Me.btnPesquisar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDataNascPesq = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkPagoPesquisa = New System.Windows.Forms.CheckBox()
        CType(Me.grdPesquisa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCpfPesq
        '
        Me.txtCpfPesq.Location = New System.Drawing.Point(342, 77)
        Me.txtCpfPesq.Mask = "000,000,000-00"
        Me.txtCpfPesq.Name = "txtCpfPesq"
        Me.txtCpfPesq.Size = New System.Drawing.Size(102, 20)
        Me.txtCpfPesq.TabIndex = 3
        '
        'txtDataPesquisarAgendamento
        '
        Me.txtDataPesquisarAgendamento.Location = New System.Drawing.Point(12, 23)
        Me.txtDataPesquisarAgendamento.Mask = "00/00/0000"
        Me.txtDataPesquisarAgendamento.Name = "txtDataPesquisarAgendamento"
        Me.txtDataPesquisarAgendamento.Size = New System.Drawing.Size(100, 20)
        Me.txtDataPesquisarAgendamento.TabIndex = 1
        Me.txtDataPesquisarAgendamento.ValidatingType = GetType(Date)
        '
        'txtNomeClientePesq
        '
        Me.txtNomeClientePesq.BackColor = System.Drawing.SystemColors.Menu
        Me.txtNomeClientePesq.Enabled = False
        Me.txtNomeClientePesq.Location = New System.Drawing.Point(12, 77)
        Me.txtNomeClientePesq.Name = "txtNomeClientePesq"
        Me.txtNomeClientePesq.Size = New System.Drawing.Size(293, 20)
        Me.txtNomeClientePesq.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Nome Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Data Viagem (Busca)"
        '
        'grdPesquisa
        '
        Me.grdPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdPesquisa.Location = New System.Drawing.Point(12, 222)
        Me.grdPesquisa.Name = "grdPesquisa"
        Me.grdPesquisa.Size = New System.Drawing.Size(678, 321)
        Me.grdPesquisa.TabIndex = 5
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Location = New System.Drawing.Point(12, 138)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(120, 38)
        Me.btnPesquisar.TabIndex = 4
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(521, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Data Nascimento"
        '
        'txtDataNascPesq
        '
        Me.txtDataNascPesq.BackColor = System.Drawing.SystemColors.Menu
        Me.txtDataNascPesq.Enabled = False
        Me.txtDataNascPesq.Location = New System.Drawing.Point(524, 77)
        Me.txtDataNascPesq.Mask = "00/00/0000"
        Me.txtDataNascPesq.Name = "txtDataNascPesq"
        Me.txtDataNascPesq.Size = New System.Drawing.Size(105, 20)
        Me.txtDataNascPesq.TabIndex = 36
        Me.txtDataNascPesq.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(339, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "CPF"
        '
        'chkPagoPesquisa
        '
        Me.chkPagoPesquisa.AutoSize = True
        Me.chkPagoPesquisa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPagoPesquisa.Location = New System.Drawing.Point(188, 22)
        Me.chkPagoPesquisa.Name = "chkPagoPesquisa"
        Me.chkPagoPesquisa.Size = New System.Drawing.Size(60, 21)
        Me.chkPagoPesquisa.TabIndex = 2
        Me.chkPagoPesquisa.Text = "Pago"
        Me.chkPagoPesquisa.UseVisualStyleBackColor = True
        '
        'FmPesquisaAgendamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 550)
        Me.Controls.Add(Me.chkPagoPesquisa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDataNascPesq)
        Me.Controls.Add(Me.txtCpfPesq)
        Me.Controls.Add(Me.txtDataPesquisarAgendamento)
        Me.Controls.Add(Me.txtNomeClientePesq)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.grdPesquisa)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Name = "FmPesquisaAgendamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.grdPesquisa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCpfPesq As MaskedTextBox
    Friend WithEvents txtDataPesquisarAgendamento As MaskedTextBox
    Friend WithEvents txtNomeClientePesq As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents grdPesquisa As DataGridView
    Friend WithEvents btnPesquisar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDataNascPesq As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents chkPagoPesquisa As CheckBox
End Class
