Imports MetroFramework
Imports MetroFramework.Controls

Public Class Geral
    Public Shared Tema_ID As Integer = 0
    Public Shared Cor_ID As Integer = 0

    Public Shared IDEstilo As Integer = 0
    Public Shared IdTema As Integer = 0
    Public Shared IdCor As Integer = 0
    Public Shared Opacidade As Double = 0
    Public Shared _Theme As MetroThemeStyle = MetroThemeStyle.Default
    Public Shared _StyleColor As MetroColorStyle = MetroColorStyle.Default

    Public Shared Sub EstiloForm(ByRef form As MetroFramework.Forms.MetroForm, Optional sender As Object = Nothing)
        form.Icon = My.Resources.planner
        form.StartPosition = FormStartPosition.CenterScreen
        form.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        form.BorderStyle = Forms.MetroFormBorderStyle.FixedSingle

        EstiloLeituraCor()
        EstiloLeituraTema()
        form.Style = SelecionaCor(Cor_ID)
        form.Theme = SelecionaTema(Tema_ID)
        Cor(sender, SelecionaCor(Cor_ID))
        Tema(sender, SelecionaTema(Tema_ID))

        form.Refresh()
        sender.Refresh()
    End Sub
    Public Shared Sub Cor(ByRef sender As Object, style As MetroColorStyle, Optional colorfont As Boolean = False)
        'Função recursiva para Estilo
        For Each obj As Object In sender.Controls
            Try
                obj.Style = style
                obj.Theme = _Theme
                obj.UseStyleColors = colorfont
                obj.UseCustomBackColor = False
                obj.Style = style
                _StyleColor = style
                obj.Refresh()

                If TipoObjeto(obj) Then
                    Cor(obj, style)
                End If
            Catch ex As Exception

            End Try
            obj.Refresh()
        Next
    End Sub

    Public Shared Sub Tema(ByRef sender As Object, theme As MetroThemeStyle)
        'Função recursiva para Tema
        For Each obj As Object In sender.Controls
            If Not TypeOf sender Is MetroPanel Then
                Try
                    obj.Theme = theme
                    obj.UseCustomBackColor = False
                    _Theme = theme
                    obj.Refresh()

                    If TipoObjeto(obj) Then
                        Tema(obj, theme)
                        Cor(obj, SelecionaCor(IdCor))
                    End If
                Catch ex As Exception

                End Try
            End If

            obj.Refresh()
        Next
    End Sub

    Public Shared Function SelecionaTema(idtema As Integer) As MetroFramework.MetroThemeStyle
        'Retorna o tema indicado
        Dim theme As MetroThemeStyle = MetroThemeStyle.Default

        Select Case idtema
            Case 0
                theme = MetroThemeStyle.Default
            Case 1
                theme = MetroThemeStyle.Light
            Case 2
                theme = MetroThemeStyle.Dark
        End Select

        Return theme
    End Function

    Public Shared Function SelecionaCor(idcor As Integer) As MetroColorStyle
        'Retorna a cor indicada
        Dim Style As MetroColorStyle = MetroColorStyle.Default

        Select Case idcor
            Case 0
                Style = MetroColorStyle.Default
            Case 1
                Style = MetroColorStyle.Black
            Case 2
                Style = MetroColorStyle.White
            Case 3
                Style = MetroColorStyle.Silver
            Case 4
                Style = MetroColorStyle.Blue
            Case 5
                Style = MetroColorStyle.Green
            Case 6
                Style = MetroColorStyle.Lime
            Case 7
                Style = MetroColorStyle.Teal
            Case 8
                Style = MetroColorStyle.Orange
            Case 9
                Style = MetroColorStyle.Brown
            Case 10
                Style = MetroColorStyle.Pink
            Case 11
                Style = MetroColorStyle.Magenta
            Case 12
                Style = MetroColorStyle.Purple
            Case 13
                Style = MetroColorStyle.Red
            Case 14
                Style = MetroColorStyle.Yellow
        End Select

        Return Style
    End Function

    Private Shared Function TipoObjeto(ByRef controle As Object) As Boolean
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

#Region " Tema & Cor - Gravação e leitura de arquivo XML "
    Public Shared Sub EstiloXMLSalvar(idcor As Integer, idtema As Integer)
        'Salva o id da imagem de fundo das janelas
        Dim arq As String = Application.StartupPath & "\estilo.xml"

        Try
            Dim xml As XElement = XElement.Parse("<?xml version=""1.0"" encoding=""utf-8""?><lotofacil><cor>" & idcor.ToString & "</cor><tema>" & idtema.ToString & "</tema></lotofacil>")

            xml.Save(arq)

            xml = Nothing

        Catch ex As Exception

        End Try

        Tema_ID = idtema
        Cor_ID = idcor
    End Sub

    Public Shared Function EstiloLeituraCor() As Integer
        'Obtem o id da cor dos componentes das janelas
        Dim idcor As Integer = 0
        Dim arq As String = Application.StartupPath & "\estilo.xml"

        If System.IO.File.Exists(arq) Then
            Try
                Dim xml As XElement = XElement.Load(arq)

                idcor = Val(xml...<cor>.Value.ToString)

                xml = Nothing
            Catch ex As Exception

            End Try
        End If

        Cor_ID = idcor

        Return idcor
    End Function

    Public Shared Function EstiloLeituraTema() As Integer
        'Obtem o id do tema das janelas
        Dim idtema As Integer = 0
        Dim arq As String = Application.StartupPath & "\estilo.xml"

        If System.IO.File.Exists(arq) Then
            Try
                Dim xml As XElement = XElement.Load(arq)

                idtema = Val(xml...<tema>.Value.ToString)

                xml = Nothing
            Catch ex As Exception

            End Try
        End If

        Tema_ID = idtema

        Return idtema
    End Function

#End Region
End Class
