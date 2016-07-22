Imports SKYPE4COMLib

Public Class Form1
    Private skype As Skype
    Public trigger As String = "!" 'This is the trigger mark
    Public motd As String = "Default"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        skype = New Skype
        skype.Attach() 'Attaches the program to Skype. Will need to be allowed through Skype itself. 
        AddHandler skype.MessageStatus, AddressOf skype_stat
    End Sub
    Public Sub skype_stat(ByVal msg As ChatMessage, ByVal status As TChatMessageStatus)
        If msg.Body.Contains(trigger) Then '! Is the trigger here. If the ! is detected then the trigger will be deteced
            Dim sendme As String = msg.Body.Replace(trigger, "") 'removes the trigger from the message. for example if the message was "!hello", the it would be "hello"
            skype.SendMessage(msg.Sender.Handle, cases(sendme)) 'sends message.
        End If

    End Sub
    Public Function cases(ByVal sent As String)
        Dim result As String
        Select Case sent
            Case Is = "help" 'What the user will need to type. 
                result = "[- Zoki Bot -]" + vbNewLine + "Welcome to Zoki Bot. This is a BOT so there will not be any human replies. For a list of commands type !commands." 'What the bot will reply with
                Exit Select
            Case Is = "commands"
                result = "[- Zoki Bot -]" + vbNewLine + "!help - Will display the help message" + vbNewLine + "!commands - Will display all the commands you can use with this bot." + vbNewLine + "!motd - Will Show the active Message Of The Day"
                Exit Select
            Case Is = "motd"
                result = "[- Zoki Bot -]" + vbNewLine + "[---Message Of The Day---]" + vbNewLine + motd
                Exit Select
            Case Else
                result = "[- Zoki Bot -]" + vbNewLine + "Not a valid command"
        End Select
        Return result
    End Function

    Private Sub btnprechange_Click(sender As Object, e As EventArgs) Handles btnprechange.Click
        trigger = txtPrefix.Text
    End Sub

    Private Sub btnmotdchange_Click(sender As Object, e As EventArgs) Handles btnmotdchange.Click
        motd = txtMotd.Text
    End Sub
End Class