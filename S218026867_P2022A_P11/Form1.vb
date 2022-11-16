Option Strict On
Option Explicit On
Option Infer Off
Public Class frm_bwdestination
    ' PANANA R
    'Q1
    '1.1 Activity record structure
    Private Structure ActivityRec
        Public Name As String
        Public NumVisitors As Integer
        Public NumPhotos() As Integer 'nS
        Public Total As Integer
        Public Ratio As Double

    End Structure
    '1.2 Destination record structure
    Private Structure DestinationRec
        Public Name As String
        Public Activities() As ActivityRec 'nA
        Public Index As Integer
        Public Rating As String
    End Structure
    'declaring variables
    Private nD As Integer
    Private nA As Integer
    Private nS As Integer
    Private Photos() As DestinationRec   'nD
    'setting up ujgrid
    Private Sub PT(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grd_destination.Row = r
        grd_destination.Col = c
        grd_destination.Text = t
    End Sub
    'labelling ujgrid
    Private Sub Setup()
        nD = CInt(InputBox("Enter number of destinations"))
        nA = CInt(InputBox("Enter number of activities"))
        nS = CInt(InputBox("Enter number of social media sites"))
        ReDim Photos(nD)
        For i As Integer = 1 To nD
            ReDim Photos(i).Activities(nA)
            For x As Integer = 1 To nA
                ReDim Photos(i).Activities(x).NumPhotos(nS)
            Next x
            grd_destination.Rows = nD + 1
            grd_destination.Cols = nA + 1 + 2
        Next i
        For d As Integer = 1 To nD
            For a As Integer = 1 To nA
                PT(d, 0, "Destination # " & CStr(d))
                PT(0, a, "Activity # " & CStr(a))
            Next a

        Next d

        PT(0, nA + 1, " Highest Ratio")
        PT(0, nA + 2, "Rating")

    End Sub

    Private Sub btn_setup_Click(sender As Object, e As EventArgs) Handles btn_setup.Click
        Setup()
    End Sub
    'prompting the user to input information of each destinatin including activity
    Private Sub btn_input_Click(sender As Object, e As EventArgs) Handles btn_input.Click
        For d As Integer = 1 To nD
            Photos(d).Name = InputBox("Enter Name of destination" & CStr(d))
            For a As Integer = 1 To nA
                Photos(d).Activities(a).Name = InputBox("Enter name of  Activity" & CStr(a))
                Photos(d).Activities(a).NumVisitors = CInt(InputBox("Enter number of visitors"))
                For s As Integer = 1 To nS
                    Photos(d).Activities(a).NumPhotos(s) = CInt(InputBox("Enter number of photos taken"))
                Next s
            Next a
        Next d
    End Sub
    'Calculating  Total Photographs per Activity per Destination
    Private Sub btn_total_Click(sender As Object, e As EventArgs) Handles btn_total.Click

        For d As Integer = 1 To nD
            For a As Integer = 1 To nA
                Photos(d).Activities(a).Total = 0
                For s As Integer = 1 To nS
                    Photos(d).Activities(a).Total = Photos(d).Activities(a).Total + Photos(d).Activities(a).NumPhotos(s)
                    PT(d, a, ((CStr(Photos(d).Activities(a).NumPhotos(s)))))
                Next s

            Next a
        Next d
    End Sub
    'creating a subroutine called CalcRatio which will return a double
    Private Sub CalcRatio(ByVal a As Integer, ByVal b As Integer, ByRef answer As Double)
        answer = a / b

    End Sub
    'Calculating  Photos-Visitors ratio per Activity per Destination using CalcRatio subroutine
    Private Sub btn_ratio_Click(sender As Object, e As EventArgs) Handles btn_ratio.Click
        Dim total As Integer
        For d As Integer = 1 To nD
            total = 0
            For a As Integer = 1 To nA
                total = total + Photos(d).Activities(a).Total
                CalcRatio(total, Photos(d).Activities(a).NumVisitors, Photos(d).Activities(a).Ratio)
                'displaying the ratio on the uj grid
                PT(d, a, (Format((Photos(d).Activities(a).Ratio), "0.00")))
            Next a

        Next d
    End Sub
    'Calculating Index of Activity with highest Photos-Visitors Ratio per Destination
    Private Sub btn_highest_Click(sender As Object, e As EventArgs) Handles btn_highest.Click

        Dim max As Double = 0
        Dim Index As Integer = 0
        For d As Integer = 1 To nD
            For a As Integer = 1 To nA
                If Photos(d).Activities(a).Ratio > max Then
                    max = Photos(d).Activities(a).Ratio
                    Index = a
                End If
                'Display Index of Activity with highest Photos-Visitors Ratio per Destination on the uj grid
                PT(d, nA + 1, (CStr(Index)))
            Next a


        Next d
    End Sub
    'Calculate Tourism Rating for each Destination
    Private Sub btn_rating_Click(sender As Object, e As EventArgs) Handles btn_rating.Click
        Dim response As String
        For d As Integer = 1 To nD
            For a As Integer = 1 To nA
                Dim Value As Double = Photos(d).Activities(a).Ratio Mod 2
                Select Case Value
                    Case Is = 0
                        response = "A"
                    Case Else
                        response = "B"
                End Select
                PT(d, nA + 2, response)
            Next a

        Next d

    End Sub
End Class
