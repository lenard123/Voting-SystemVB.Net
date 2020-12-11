Imports System.Data.OleDb

Public Class Privilege

    Public Shared Function GetDescription(Id As PrivilegeType) As String
        Select Case Id
            Case PrivilegeType.VOTERS_ADD
                Return "Can add voters"
            Case PrivilegeType.VOTERS_UPDATE
                Return "Can update voters information"
            Case PrivilegeType.CANDIDATE_REGISTER
                Return "Can register candidate"
            Case PrivilegeType.CANDIDATE_UPDATE
                Return "Can update candidate informationo"
            Case PrivilegeType.CANDIDATE_REMOVE
                Return "Can remove Candidate"
            Case PrivilegeType.PARTY_ADD
                Return "Can add Party"
            Case PrivilegeType.PARTY_UPDATE
                Return "Can update Party information"
            Case PrivilegeType.CANDIDATE_REMOVE
                Return "Can remove party"
            Case PrivilegeType.START_ELECTION
                Return "Can Start Election"
            Case Else
                Return "(Invalid id)"
        End Select
    End Function

    Enum PrivilegeType
        ALL = 1
        VOTERS_ADD = 2
        VOTERS_UPDATE = 3
        CANDIDATE_REGISTER = 4
        CANDIDATE_UPDATE = 5
        CANDIDATE_REMOVE = 6
        PARTY_ADD = 7
        PARTY_UPDATE = 8
        PARTY_REMOVE = 9
        START_ELECTION = 10
    End Enum



End Class
