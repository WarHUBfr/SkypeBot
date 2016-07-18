Imports SKYPE4COMLib
Imports System.Windows.Forms

Public Class Form1
    Private skype As Skype
    Dim trigger As String = "!" 'This is the trigger mark
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
                result = "SkypeBot" + vbNewLine + "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + vbNewLine + "Welcome to the SkypeBot. This is a BOT so there will not be any human replies. For a list of commands type !commands." 'What the bot will reply with
                Exit Select
            Case Is = "commands"
                result = "SkypeBot" + vbNewLine + "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + vbNewLine + "!help - Will display the help message" + vbNewLine + "!commands - Will display all the commands you can use with this bot."
                Exit Select
            Case Else
                result = "SkypeBot" + vbNewLine + "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + vbNewLine + "Not a valid command"
        End Select

        Return result

    End Function
End Class