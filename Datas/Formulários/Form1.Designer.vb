<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    'Inherits System.Windows.Forms.Form
    Inherits MetroFramework.Forms.MetroForm

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
        Me.dtpDtNasc = New MetroFramework.Controls.MetroDateTime()
        Me.panEstilo = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.cboTema = New MetroFramework.Controls.MetroComboBox()
        Me.cboCor = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.dtpDtnow = New MetroFramework.Controls.MetroDateTime()
        Me.lblAnos = New MetroFramework.Controls.MetroLabel()
        Me.MetroTile1 = New MetroFramework.Controls.MetroTile()
        Me.btnCalcular = New MetroFramework.Controls.MetroButton()
        Me.chkEstilo = New MetroFramework.Controls.MetroCheckBox()
        Me.lblMeses = New MetroFramework.Controls.MetroLabel()
        Me.lblDias = New MetroFramework.Controls.MetroLabel()
        Me.lblError = New MetroFramework.Controls.MetroLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.picInformation = New System.Windows.Forms.PictureBox()
        Me.picParabens = New System.Windows.Forms.PictureBox()
        Me.lblParabens = New MetroFramework.Controls.MetroLabel()
        Me.panEstilo.SuspendLayout()
        CType(Me.picInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picParabens, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDtNasc
        '
        Me.dtpDtNasc.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtpDtNasc.FontWeight = MetroFramework.MetroDateTimeWeight.Bold
        Me.dtpDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDtNasc.Location = New System.Drawing.Point(23, 106)
        Me.dtpDtNasc.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtpDtNasc.Name = "dtpDtNasc"
        Me.dtpDtNasc.Size = New System.Drawing.Size(109, 25)
        Me.dtpDtNasc.TabIndex = 0
        '
        'panEstilo
        '
        Me.panEstilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panEstilo.Controls.Add(Me.MetroLabel5)
        Me.panEstilo.Controls.Add(Me.MetroLabel4)
        Me.panEstilo.Controls.Add(Me.cboTema)
        Me.panEstilo.Controls.Add(Me.cboCor)
        Me.panEstilo.HorizontalScrollbarBarColor = True
        Me.panEstilo.HorizontalScrollbarHighlightOnWheel = False
        Me.panEstilo.HorizontalScrollbarSize = 10
        Me.panEstilo.Location = New System.Drawing.Point(23, 274)
        Me.panEstilo.Name = "panEstilo"
        Me.panEstilo.Size = New System.Drawing.Size(262, 64)
        Me.panEstilo.TabIndex = 1
        Me.panEstilo.VerticalScrollbarBarColor = True
        Me.panEstilo.VerticalScrollbarHighlightOnWheel = False
        Me.panEstilo.VerticalScrollbarSize = 10
        Me.panEstilo.Visible = False
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(153, 9)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(35, 15)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Tema"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(14, 9)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(26, 15)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "Cor"
        '
        'cboTema
        '
        Me.cboTema.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cboTema.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.cboTema.FormattingEnabled = True
        Me.cboTema.ItemHeight = 19
        Me.cboTema.Items.AddRange(New Object() {"Default", "Light", "Dark"})
        Me.cboTema.Location = New System.Drawing.Point(153, 25)
        Me.cboTema.Name = "cboTema"
        Me.cboTema.Size = New System.Drawing.Size(94, 25)
        Me.cboTema.TabIndex = 3
        Me.cboTema.UseSelectable = True
        '
        'cboCor
        '
        Me.cboCor.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cboCor.FontWeight = MetroFramework.MetroComboBoxWeight.Bold
        Me.cboCor.FormattingEnabled = True
        Me.cboCor.ItemHeight = 19
        Me.cboCor.Items.AddRange(New Object() {"Default", "Black", "White", "Silver", "Blue", "Green", "Lime", "Teal", "Orange", "Brown", "Pink", "Magenta", "Purple", "Red", "Yellow"})
        Me.cboCor.Location = New System.Drawing.Point(14, 25)
        Me.cboCor.Name = "cboCor"
        Me.cboCor.Size = New System.Drawing.Size(133, 25)
        Me.cboCor.TabIndex = 2
        Me.cboCor.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 90)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(98, 15)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Data Nascimento"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontSize = MetroFramework.MetroLabelSize.Small
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 139)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(62, 15)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Data Atual"
        '
        'dtpDtnow
        '
        Me.dtpDtnow.FontSize = MetroFramework.MetroDateTimeSize.Small
        Me.dtpDtnow.FontWeight = MetroFramework.MetroDateTimeWeight.Bold
        Me.dtpDtnow.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDtnow.Location = New System.Drawing.Point(23, 155)
        Me.dtpDtnow.MinimumSize = New System.Drawing.Size(0, 25)
        Me.dtpDtnow.Name = "dtpDtnow"
        Me.dtpDtnow.Size = New System.Drawing.Size(109, 25)
        Me.dtpDtnow.TabIndex = 3
        '
        'lblAnos
        '
        Me.lblAnos.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblAnos.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblAnos.Location = New System.Drawing.Point(156, 106)
        Me.lblAnos.Name = "lblAnos"
        Me.lblAnos.Size = New System.Drawing.Size(253, 15)
        Me.lblAnos.TabIndex = 5
        Me.lblAnos.Text = "Anos: "
        Me.lblAnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroTile1
        '
        Me.MetroTile1.ActiveControl = Nothing
        Me.MetroTile1.Location = New System.Drawing.Point(147, 90)
        Me.MetroTile1.Name = "MetroTile1"
        Me.MetroTile1.Size = New System.Drawing.Size(1, 150)
        Me.MetroTile1.TabIndex = 6
        Me.MetroTile1.UseSelectable = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Highlight = True
        Me.btnCalcular.Location = New System.Drawing.Point(23, 191)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(109, 40)
        Me.btnCalcular.TabIndex = 7
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseSelectable = True
        '
        'chkEstilo
        '
        Me.chkEstilo.AutoSize = True
        Me.chkEstilo.Location = New System.Drawing.Point(23, 253)
        Me.chkEstilo.Name = "chkEstilo"
        Me.chkEstilo.Size = New System.Drawing.Size(89, 15)
        Me.chkEstilo.TabIndex = 8
        Me.chkEstilo.Text = "Mudar Estilo"
        Me.chkEstilo.UseSelectable = True
        '
        'lblMeses
        '
        Me.lblMeses.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblMeses.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblMeses.Location = New System.Drawing.Point(156, 130)
        Me.lblMeses.Name = "lblMeses"
        Me.lblMeses.Size = New System.Drawing.Size(253, 15)
        Me.lblMeses.TabIndex = 9
        Me.lblMeses.Text = "Meses: "
        Me.lblMeses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDias
        '
        Me.lblDias.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblDias.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblDias.Location = New System.Drawing.Point(156, 154)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(253, 15)
        Me.lblDias.TabIndex = 10
        Me.lblDias.Text = "Dias: "
        Me.lblDias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblError
        '
        Me.lblError.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblError.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(2, 341)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(413, 15)
        Me.lblError.TabIndex = 11
        Me.lblError.Text = "ERROR:"
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblError.UseCustomForeColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'picInformation
        '
        Me.picInformation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picInformation.Image = Global.Datas.My.Resources.Resources.info_16
        Me.picInformation.Location = New System.Drawing.Point(399, 63)
        Me.picInformation.Name = "picInformation"
        Me.picInformation.Size = New System.Drawing.Size(16, 16)
        Me.picInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picInformation.TabIndex = 12
        Me.picInformation.TabStop = False
        '
        'picParabens
        '
        Me.picParabens.Image = Global.Datas.My.Resources.Resources.party_baloons_32
        Me.picParabens.Location = New System.Drawing.Point(156, 199)
        Me.picParabens.Name = "picParabens"
        Me.picParabens.Size = New System.Drawing.Size(32, 32)
        Me.picParabens.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picParabens.TabIndex = 13
        Me.picParabens.TabStop = False
        Me.picParabens.Visible = False
        '
        'lblParabens
        '
        Me.lblParabens.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblParabens.ForeColor = System.Drawing.Color.Red
        Me.lblParabens.Location = New System.Drawing.Point(194, 199)
        Me.lblParabens.Name = "lblParabens"
        Me.lblParabens.Size = New System.Drawing.Size(186, 32)
        Me.lblParabens.TabIndex = 14
        Me.lblParabens.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 357)
        Me.Controls.Add(Me.lblParabens)
        Me.Controls.Add(Me.picParabens)
        Me.Controls.Add(Me.picInformation)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.lblDias)
        Me.Controls.Add(Me.lblMeses)
        Me.Controls.Add(Me.chkEstilo)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.MetroTile1)
        Me.Controls.Add(Me.lblAnos)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.dtpDtnow)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.panEstilo)
        Me.Controls.Add(Me.dtpDtNasc)
        Me.MinimumSize = New System.Drawing.Size(432, 285)
        Me.Name = "Form1"
        Me.Text = "Datas"
        Me.panEstilo.ResumeLayout(False)
        Me.panEstilo.PerformLayout()
        CType(Me.picInformation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picParabens, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDtNasc As MetroFramework.Controls.MetroDateTime
    Friend WithEvents panEstilo As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboTema As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cboCor As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpDtnow As MetroFramework.Controls.MetroDateTime
    Friend WithEvents lblAnos As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTile1 As MetroFramework.Controls.MetroTile
    Friend WithEvents btnCalcular As MetroFramework.Controls.MetroButton
    Friend WithEvents chkEstilo As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lblMeses As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblDias As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblError As MetroFramework.Controls.MetroLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picInformation As PictureBox
    Friend WithEvents picParabens As PictureBox
    Friend WithEvents lblParabens As MetroFramework.Controls.MetroLabel
End Class
