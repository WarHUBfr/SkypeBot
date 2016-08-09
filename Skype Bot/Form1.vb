Imports SKYPE4COMLib
Imports System.Windows.Forms

Public Class Form1
    Dim WithEvents skype As New Skype
    Dim trigger As String = "!" 'This is the trigger mark
    
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pSkype.Attach(7, True) 'Attaches the program to Skype. Will need to be allowed through Skype itself. 
    End Sub
Private Sub pSkype_MessageStatus(pMessage As ChatMessage, Status As TChatMessageStatus) Handles pSkype.MessageStatus
        If Status = TChatMessageStatus.cmsReceived Or Status = TChatMessageStatus.cmsSent Then
            Dim msg As String = pMessage.Body
            Dim sb As Chat = pMessage.Chat
            Dim params As String() = msg.Split(" ")
            Dim start As String = "/me :"
            If msg.StartsWith(trigger) Then


                msg = msg.Remove(0, 1)

                System.Threading.Thread.Sleep(500) ' Fix some bug
                If msg = "help" Then
                sb.SendMessage(start + vbNewLine +"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + vbNewLine + "Welcome to the SkypeBot. This is a BOT so there will not be any human replies. For a list of commands type !commands.") 'What the bot will reply with
            Elseif msg = "commands" Then
                sb.SendMessage(start + vbNewLine + "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + vbNewLine + "!help - Will display the help message" + vbNewLine + "!commands - Will display all the commands you can use with this bot.")
              Elseif msg.StartsWith("input") Then
              
              if params(1) = "" Then
              sb.SendMessage(start + vbNewLine + "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + vbNewLine + "No Input, type : !input test")
              Else
                sb.SendMessage(start + vbNewLine + "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + vbNewLine + "I recieved : " + params(1))
              end if
              Else
                 sb.SendMessage(start + vbNewLine +"~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~" + vbNewLine + "Not a valid command")
                 End if
 End Sub
End Class
