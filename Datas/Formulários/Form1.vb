Imports MetroFramework

Public Class Form1

#Region " Declarações "
    Dim idcor As Integer
    Dim idtema As Integer
    Dim bErro As Boolean = False
#End Region

#Region " Form "
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Geral.EstiloForm(Me, sender)
        idcor = Geral.Cor_ID
        idtema = Geral.Tema_ID
        Me.cboCor.SelectedIndex = idcor
        Me.cboTema.SelectedIndex = idtema
        Estilo(sender)
        ModelaForm()
        LimpaCampos()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If bErro Then
            Me.lblError.Text = ""
            bErro = False
            Timer1.Stop()
        End If
    End Sub
#End Region

#Region " Controles "
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        CalculaDatas()
    End Sub

    Private Sub chkEstilo_Click(sender As Object, e As EventArgs) Handles chkEstilo.Click
        ModelaForm()
    End Sub

    Private Sub cboTema_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTema.SelectedIndexChanged
        Estilo(sender)
    End Sub

    Private Sub cboCor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCor.SelectedIndexChanged
        Estilo(sender)
    End Sub

    Private Sub picInformation_Click(sender As Object, e As EventArgs) Handles picInformation.Click
        MetroMessageBox.Show(Me, "Criado e Desenvolvido por Danilo C. Soares", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information, 150)
    End Sub
#End Region

#Region " Funções "
    Private Sub LimpaCampos()
        Me.lblAnos.Text = ""
        Me.lblDias.Text = ""
        Me.lblMeses.Text = ""
        Me.lblError.Text = ""
    End Sub
    Private Sub CalculaDatas()
        Dim dtnow As Date = dtpDtnow.Value
        Dim dtnasc As Date = dtpDtNasc.Value
        Dim dias As String = ""
        Dim anos As String = ""
        Dim meses As String = ""
        Dim _dia As String = ""
        Dim _diasRestantes As String = ""
        Dim _diaAtual As String = ""
        Dim msgAnos As String = ""
        Dim msgMeses As String = ""
        Dim msgDias As String = ""
        Dim aniv As Date = DateSerial(Now.Year, dtnasc.Month, dtnasc.Day)

        anos = (DateDiff(DateInterval.Year, dtnasc, dtnow)).ToString
        dias = (dtnow.Day - dtnasc.Day).ToString
        _dia = DatePart(DateInterval.Day, dtpDtNasc.Value)
        _diaAtual = DatePart(DateInterval.Day, dtpDtnow.Value)
        meses = (dtnasc.Month - dtnow.Month).ToString
        _diasRestantes = DateDiff(DateInterval.Day, aniv, dtnow)

        If dtnasc.Month = dtnow.Month Then
            If dtnasc.Day = dtnow.Day Then
                Me.picParabens.Visible = True
                Me.lblParabens.Text = "PARABÉNS !!"
            Else
                Me.picParabens.Visible = False
                Me.lblParabens.Text = ""
            End If
        Else
            Me.picParabens.Visible = False
            Me.lblParabens.Text = ""
        End If

        If dtnow.Month > 6 Then
            If DatePart(DateInterval.Month, dtnasc) >= dtnow.Month Then
                If dtnow.Month < dtnasc.Month Then
                    anos = (Val(anos) - 1).ToString
                Else
                    If Val(_diaAtual) < Val(_dia) Then anos = (Val(anos) - 1).ToString
                End If
            End If
        Else
            If DatePart(DateInterval.Month, dtnow) <= dtnasc.Month Then
                If dtnow.Month < dtnasc.Month Then
                    anos = (Val(anos) - 1).ToString
                Else
                    If Val(_diaAtual) < Val(_dia) Then anos = (Val(anos) - 1).ToString
                End If
            End If
        End If

        If anos.IndexOf("-") Then
            msgAnos = If(Val(anos) > 0, "Você tem " & Val(anos).ToString.Replace("-", "") & " Anos", "")
        End If

        If meses.IndexOf("-") Then
            meses = meses.Replace("-", "")
            msgMeses = If(Val(meses) > 0, If(Val(meses) = 1, "Falta", "Faltam") & " pouco menos de " & meses & If(Val(meses) = 1, " mes", " meses"), "")
        End If

        If dias.IndexOf("-") = 0 Then
            If dtnow.Month = dtnasc.Month Then
                msgDias = If(Val(dias) < 0, If(Val(dias.Replace("-", "")) = 1, "Falta ", "Faltam ") & dias.Replace("-", "") & If(Val(dias.Replace("-", "")) = 1, " dia", " dias") & " para o seu aniversário", "")
            ElseIf dtnow.Month > dtnasc.Month Then
                msgDias = If(Val(_diasRestantes) > 0, "Já se passaram " & _diasRestantes.Replace("-", "") & " dias do seu aniversário", "")
            Else
                _diasRestantes = Val(_diasRestantes) - 1
                msgDias = If(Val(_diasRestantes) < 0, "Faltam " & _diasRestantes.Replace("-", "") & " dias para o seu aniversário", "")
            End If
        Else
            If dtnow.Month >= dtnasc.Month Then
                msgDias = If(Val(_diasRestantes) > 0, If(_diasRestantes = 1, "Já se passou ", "Já se passaram ") & _diasRestantes.Replace("-", "") & If(_diasRestantes = 1, " dia", " dias") & " do seu aniversário", "")
            ElseIf dtnow.Month < dtnasc.Month Then
                _diasRestantes = Val(_diasRestantes) - 1
                msgDias = If(Val(_diasRestantes) < 0, "Faltam " & _diasRestantes.Replace("-", "") & " dias para o seu aniversário", "")
            Else
                msgDias = If(Val(_diasRestantes) > 0, "Já se passaram " & _diasRestantes.Replace("-", "") & " dias do seu aniversário", "")
            End If
        End If

        Me.lblAnos.Text = msgAnos
        Me.lblMeses.Text = msgMeses
        Me.lblDias.Text = msgDias
    End Sub

    Private Sub ModelaForm()
        If Me.chkEstilo.Checked = False Then
            Me.chkEstilo.Checked = False
            panEstilo.Height = 0
            panEstilo.Visible = False
            Me.Height = 285
            Me.Width = 432
        Else
            Me.chkEstilo.Checked = True
            panEstilo.Height = 64
            panEstilo.Visible = True
            Me.Height = 357
            Me.Width = 432
        End If
    End Sub

    Private Sub Estilo(sender As Object)
        Dim idcorSelected As Integer = Me.cboCor.SelectedIndex
        Dim idtemaSelected As Integer = Me.cboTema.SelectedIndex

        If idcorSelected = 1 AndAlso idtemaSelected = 2 Then
            idcorSelected = 0
            Me.lblError.Text = "DESCUPE NÃO É POSSÍVEL UTILIZAR A COR PRETA COM TEMA DARK"
            bErro = True
            Me.Timer1.Start()
        End If

        If idcorSelected = 2 AndAlso idtemaSelected = 1 Then
            idcorSelected = 0
            Me.lblError.Text = "DESCUPE NÃO É POSSÍVEL UTILIZAR A COR BRANCA COM TEMA LIGHT"
            bErro = True
            Me.Timer1.Start()
        End If

        Try
            Me.Style = Geral.SelecionaCor(idcorSelected)
            Me.Theme = Geral.SelecionaTema(idtemaSelected)

            AlteraTema(Me, Me.Theme)
            AlteraCores(Me, Me.Style)
            Geral.EstiloXMLSalvar(idcorSelected, idtemaSelected)
        Catch ex As Exception

        End Try

        Me.cboCor.SelectedIndex = idcorSelected
    End Sub
#End Region

#Region " Tema & Cor "
    Private Sub AlteraTema(sender As Object, theme As MetroFramework.MetroThemeStyle)
        'Função recursiva
        For Each obj As Object In sender.Controls
            Try
                obj.Theme = theme
                obj.Refresh()
            Catch ex As Exception

            End Try

            If TipoObjeto(obj) Then
                AlteraTema(obj, theme)
            End If
        Next
    End Sub

    Private Sub AlteraCores(sender As Object, cor As MetroFramework.MetroColorStyle)
        'Função recursiva
        For Each obj As Object In sender.Controls
            Try
                obj.Style = cor
                Me.Style = cor
                obj.Refresh()
            Catch ex As Exception

            End Try

            If TipoObjeto(obj) Then
                AlteraCores(obj, cor)
            End If
        Next

        Me.Refresh()
    End Sub

    Private Function TipoObjeto(ByRef controle As Object) As Boolean
        Dim b As Boolean = False

        If TypeOf controle Is MetroFramework.Controls.MetroButton Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroCheckBox Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroComboBox Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroContextMenu Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroDataGridHelper Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroDateTime Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroGrid Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroLabel Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroLink Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroListView Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroPanel Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroProgressBar Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroProgressSpinner Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroRadioButton Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroScrollBar Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroTabControl Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroTabPage Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroTextBox Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroTile Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroToggle Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroTrackBar Then b = True
        If TypeOf controle Is MetroFramework.Controls.MetroUserControl Then b = True

        Return b
    End Function
#End Region

End Class
