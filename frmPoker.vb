Public Class frmPoker
  Dim aryintPoker(3, 12) As Integer  'Setting class variables (4 columns, 12 checkboxes)
  Dim intSelected As Integer = 0
  Dim arychkPoker(52) As CheckBox

  Private Sub DoOnce()
    arychkPoker(1) = chkClubAce    'Clubs Suite of Cards
    arychkPoker(2) = chkClubTwo
    arychkPoker(3) = chkClubThree
    arychkPoker(4) = chkClubFour
    arychkPoker(5) = chkClubFive
    arychkPoker(6) = chkClubSix
    arychkPoker(7) = chkClubSeven
    arychkPoker(8) = chkClubEight
    arychkPoker(9) = chkClubNine
    arychkPoker(10) = chkClubTen
    arychkPoker(11) = chkClubJack
    arychkPoker(12) = chkClubQueen
    arychkPoker(13) = chkClubKing
    arychkPoker(14) = chkDiamAce   'Dimaonds Suite of Cards
    arychkPoker(15) = chkDiamTwo
    arychkPoker(16) = chkDiamThree
    arychkPoker(17) = chkDiamFour
    arychkPoker(18) = chkDiamFive
    arychkPoker(19) = chkDiamSix
    arychkPoker(20) = chkDiamSeven
    arychkPoker(21) = chkDiamEight
    arychkPoker(22) = chkDiamNine
    arychkPoker(23) = chkDiamTen
    arychkPoker(24) = chkDiamJack
    arychkPoker(25) = chkDiamQueen
    arychkPoker(26) = chkDiamKing
    arychkPoker(27) = chkHeartAce   'Hearts Suite of Cards
    arychkPoker(28) = chkHeartTwo
    arychkPoker(29) = chkHeartThree
    arychkPoker(30) = chkHeartFour
    arychkPoker(31) = chkHeartFive
    arychkPoker(32) = chkHeartSix
    arychkPoker(33) = chkHeartSeven
    arychkPoker(34) = chkHeartEight
    arychkPoker(35) = chkHeartNine
    arychkPoker(36) = chkHeartTen
    arychkPoker(37) = chkHeartJack
    arychkPoker(38) = chkHeartQueen
    arychkPoker(39) = chkHeartKing
    arychkPoker(40) = chkSpadeAce   'Spades Suite of Cards
    arychkPoker(41) = chkSpadeTwo
    arychkPoker(42) = chkSpadeThree
    arychkPoker(43) = chkSpadeFour
    arychkPoker(44) = chkSpadeFive
    arychkPoker(45) = chkSpadeSix
    arychkPoker(46) = chkSpadeSeven
    arychkPoker(47) = chkSpadeEight
    arychkPoker(48) = chkSpadeNine
    arychkPoker(49) = chkSpadeTen
    arychkPoker(50) = chkSpadeJack
    arychkPoker(51) = chkSpadeQueen
    arychkPoker(52) = chkSpadeKing
  End Sub

  Dim i As Integer
  Dim strReturn As String


  Private Sub DoTotals()
    Dim i, j As Integer 'Sets value for variable
    For i = 0 To 3
      For j = 0 To 12
        aryintPoker(i, 0) += aryintPoker(i, j)
      Next
    Next

    For j = 0 To 3
      For i = 0 To 12
        aryintPoker(0, j) += aryintPoker(i, j)
      Next
    Next

    For i = 0 To 3
      aryintPoker(i, 12) = aryintPoker(i, 3)
    Next
  End Sub

  Private Function checkFlush()
    Dim i As Integer 'Sets value to variable
    Dim strRet As String = ""

    For i = 0 To 3
      If aryintPoker(i, 0) = 4 Then
        strRet = "You Have a Flush"
        Return strRet
      End If
    Next
  End Function

  Private Sub btnPoker_Click(sender As Object, e As EventArgs) Handles btnPoker.Click
    'Pressing button checks cards selected
    Dim strRet As String 'Shows poker hand

    If intSelected <> 5 Then
      MsgBox("Please select 5 cards")
    End If

    Call DoTotals()

    strRet = checkFlush()
    If strRet <> "" Then
      MsgBox(strRet)
    End If

  End Sub

  Private Sub Reset()
    Dim i As Integer 'Sets value to variable
    For i = 1 To arychkPoker.Count - 1   'Loop to reset
      arychkPoker(i).Checked = False
    Next
    ReDim aryintPoker(3, 12)
    intSelected = 0
  End Sub

  Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
    'Pressing Reset button resets form
    Call Reset()
  End Sub

  Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
    'Pressing Close button closes form
    Me.Close()
  End Sub
End Class
