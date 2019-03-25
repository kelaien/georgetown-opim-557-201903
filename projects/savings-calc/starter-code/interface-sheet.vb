'
' SAVINGS CALCULATOR PROJECT > STARTER CODE > INTERFACE SHEET (SIMPLE CELLS INTERFACE)
'
' Author: Prof. Rossetti <prof.mj.rossetti@gmail.com>
' Source: https://github.com/prof-rossetti/georgetown-opim-557-201810/blob/master/projects/savings-calc/starter-code/interface-sheet.vb
' License: Students, feel free but not obligated to use this module in your project as long as you retain this attribution section. If you wrote something like this on your own, no need to attribute. If this code inspired you to write your own code, please still consider providing an attribution link to this file's GitHub URL.
'

Option Explicit

Private Sub CommandButton1_Click()
  Dim Age
  Dim RetirementAge
  Dim SavingsBalance
  Dim AnnualContribution
  Dim AnnualInterestRate

  '
  ' CAPTURE USER INPUTS (VIA CELL VALUES)
  '

  Age = Range("E9").Value
  RetirementAge = Range("E11").Value
  SavingsBalance = Range("E13").Value
  AnnualContribution = Range("E15").Value
  AnnualInterestRate = Range("E17").Value

  '
  ' VALIDATE USER INPUTS
  '

  ' TODO: validate inputs

  '
  ' DISPLAY USER INPUTS
  '

  Call LogUserInputs(Age, RetirementAge, SavingsBalance, AnnualContribution, AnnualInterestRate)

  '
  ' CALCULATE OUTPUTS
  '

  Dim TotalContribution As Double
  Dim TotalInterest As Double

  TotalContribution = SavingsBalance ' count initial savings balance toward total contribution

  ' TODO: calculate final outputs

  '
  ' DISPLAY FINAL OUTPUTS
  '

  Call LogFinalOutputs(SavingsBalance, TotalContribution, TotalInterest)
End Sub
