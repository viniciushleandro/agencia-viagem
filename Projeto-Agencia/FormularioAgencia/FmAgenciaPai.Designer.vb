<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FmAgenciaPai
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
        Me.components = New System.ComponentModel.Container()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnDestino = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnPacotes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnAgendamentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesquisarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnPesqAgend = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 963)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1264, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.PesquisarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnDestino, Me.mnPacotes, Me.mnCliente, Me.mnAgendamentos})
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'mnDestino
        '
        Me.mnDestino.Name = "mnDestino"
        Me.mnDestino.Size = New System.Drawing.Size(155, 22)
        Me.mnDestino.Text = "Destino"
        '
        'mnPacotes
        '
        Me.mnPacotes.Name = "mnPacotes"
        Me.mnPacotes.Size = New System.Drawing.Size(155, 22)
        Me.mnPacotes.Text = "Pacotes"
        '
        'mnCliente
        '
        Me.mnCliente.Name = "mnCliente"
        Me.mnCliente.Size = New System.Drawing.Size(155, 22)
        Me.mnCliente.Text = "Cliente"
        '
        'mnAgendamentos
        '
        Me.mnAgendamentos.Name = "mnAgendamentos"
        Me.mnAgendamentos.Size = New System.Drawing.Size(155, 22)
        Me.mnAgendamentos.Text = "Agendamentos"
        '
        'PesquisarToolStripMenuItem
        '
        Me.PesquisarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnPesqAgend})
        Me.PesquisarToolStripMenuItem.Name = "PesquisarToolStripMenuItem"
        Me.PesquisarToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.PesquisarToolStripMenuItem.Text = "Pesquisar"
        '
        'mnPesqAgend
        '
        Me.mnPesqAgend.Name = "mnPesqAgend"
        Me.mnPesqAgend.Size = New System.Drawing.Size(155, 22)
        Me.mnPesqAgend.Text = "Agendamentos"
        '
        'FmAgenciaPai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 985)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FmAgenciaPai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MDIParent1"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnPacotes As ToolStripMenuItem
    Friend WithEvents mnAgendamentos As ToolStripMenuItem
    Friend WithEvents mnCliente As ToolStripMenuItem
    Friend WithEvents mnDestino As ToolStripMenuItem
    Friend WithEvents PesquisarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnPesqAgend As ToolStripMenuItem
End Class
