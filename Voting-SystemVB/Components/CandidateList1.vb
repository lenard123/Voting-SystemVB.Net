Public Class CandidateList1

    Dim Candidates As List(Of Candidate)

    Enum CandidateType
        Text
        Radio
    End Enum


    Public Sub New(Candidates As List(Of Candidate), Position As String, type As CandidateType)
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Candidates = Candidates
        Me.Guna2GroupBox1.Text = Position




    End Sub
End Class
