Imports SKYPE4COMLib

Public Class Form1
    Private skype As Skype
    Public trigger As String = "!" 'This is the trigger mark
    Public motd As String = "DefaultString"
    Public url As String = "http://example.com"
    Public chkFR As Object
    Public welcome As Object = "Welcome to WelpeBot. This is a BOT so there will not be any human replies. For a list of commands type !commands."
    Public chatUrl As String

    'This is the URL Queue for music playback
    Public nowplaying As String
    Public queue1 As String
    Public queue2 As String
    Public queue3 As String
    Public queue4 As String
    Public queue5 As String
    Public queue6 As String
    Public queue7 As String
    Public queue8 As String
    Public queue9 As String
    Public queue10 As String
    Public queue11 As String
    Public queue12 As String
    Public queue13 As String
    Public queue14 As String
    Public queue15 As String
    Public queue16 As String
    Public queue17 As String
    Public queue18 As String
    Public queue19 As String
    Public queue20 As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        skype = New Skype
        skype.Attach(7, False) 'Attaches the program to Skype. Will need to be allowed through Skype itself. 
        AddHandler skype.MessageStatus, AddressOf skype_stat
    End Sub
    Public Sub skype_stat(ByVal msg As ChatMessage, ByVal status As TChatMessageStatus)
        If msg.Body.Contains(trigger) Then '! Is the trigger here. If the ! is detected then the trigger will be deteced
            Dim sendme As String = msg.Body.Replace(trigger, "") 'removes the trigger from the message. for example if the message was "!hello", the it would be "hello"
            skype.SendMessage(msg.Sender.Handle, cases(sendme)) 'sends message.
        ElseIf msg.Body.Contains("http") Then

            NowPlayingWeb.Navigate("http://www.google.com")
        End If

    End Sub
    Public Function cases(ByVal sent As String)
        Dim result As String
        Select Case sent
            Case Is = "info" 'What the user will need to type. 
                result = "]|[ WELPEBOT ]|[" + vbNewLine + "Welcome to WelpeBot. This is a BOT so there will not be any human replies. For a list of commands type !commands." 'What the bot will reply with
                Exit Select
            Case Is = "help"
                result = "]|[ WELPEBOT ]|[" + vbNewLine + "!info - Will display the help message" + vbNewLine + "!help - Will display all the commands you can use with this bot." + vbNewLine + "!motd - Will Show the active Message Of The Day" + vbNewLine + "!playmusic - Will Play 'Sia - Cheap Thrills'." + vbNewLine + "!stopmusic - Will Stop the Audio Playback."
                Exit Select
            Case Is = "motd"
                result = "]|[ WELPEBOT ]|[" + vbNewLine + "}{|}---MOTD---{|}{" + vbNewLine + txtMotd.Text
                Exit Select
            Case Is = "playmusic"
                result = "]|[ WELPEBOT ]|[" + vbNewLine + "Playing song For you..."

                Exit Select
            Case Else
                result = "]|[ WELPEBOT ]|[" + vbNewLine + "I don't understand what you typed"
        End Select
        Return result
    End Function

    Private Sub btnprechange_Click(sender As Object, e As EventArgs)
        trigger = txtPrefix.Text
    End Sub

    Private Sub btnmotdchange_Click(sender As Object, e As EventArgs)
        motd = txtMotd.Text
    End Sub

    Private Sub btnopenurl_Click(sender As Object, e As EventArgs)
        url = txtUrl.Text
        Process.Start(url)
    End Sub

    Private Sub btnwelmeschange_Click(sender As Object, e As EventArgs) Handles btnopenurl.Click
        welcome = txtWelcome.Text
    End Sub

    Private Sub ISkype_unauthorizedrequestreceived(User As User)
        If chkFR.Checked = True And User.IsAuthorized = False Then
            User.IsAuthorized = True
            welcome = txtWelcome.Text

        End If
    End Sub
End Class