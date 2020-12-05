
Imports System.Windows.Forms

Public Class Main
    Inherits Form

    Public Shared Instance As Main
    Private Shared ActiveChild As UserControl
    Private Shared WithEvents TimerFade As New Timer
    Private Shared AnimationState As MainFormAnimationState

    Enum MainFormAnimationState
        FADE_START
        FADING_IN
    End Enum

    Public Sub New()

        Instance = Me

        Me.MaximumSize = Screen.FromControl(Me).WorkingArea.Size
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint, True)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        TimerFade.Interval = 1

        LoadControl(New LoadingScreen())
    End Sub

    Public Shared Sub LoadControl(Child As UserControl)
        ActiveChild = Child
        Child.Dock = DockStyle.Fill
        Instance.Controls.Clear()
        Instance.Size = Child.Size
        Instance.Controls.Add(Child)
        Instance.CenterToScreen()
        AnimationState = MainFormAnimationState.FADE_START
        TimerFade.Start()
    End Sub

    Private Shared Sub TimerFade_Tick(sender As Object, e As EventArgs) Handles TimerFade.Tick
        Select Case AnimationState
            Case MainFormAnimationState.FADE_START
                Instance.Opacity = 0
                AnimationState = MainFormAnimationState.FADING_IN
            Case MainFormAnimationState.FADING_IN
                Instance.Opacity += (1 / (1000 * 2)) * 100
                If Instance.Opacity >= 1 Then
                    If TypeOf ActiveChild Is MainControl Then
                        DirectCast(ActiveChild, MainControl).RefreshControl()
                    End If
                    TimerFade.Stop()
                End If
        End Select
    End Sub



End Class
