
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

        DoubleBuffered = True

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

    Private Sub Main_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Not IsNothing(ActiveChild) Then
            If Me.WindowState = FormWindowState.Normal And Me.Width <> ActiveChild.MinimumSize.Width And Me.Height <> ActiveChild.MinimumSize.Height Then
                Me.Size = ActiveChild.MinimumSize
                Me.CenterToScreen()
            End If
        End If
    End Sub
End Class
