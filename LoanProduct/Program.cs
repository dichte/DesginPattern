// See https://aka.ms/new-console-template for more information
using LoanProduct;

HomeLoan homeLoan = new();
Console.WriteLine($"Home Loan Payment Amout: {homeLoan.PaymentAmount()} | Home Loan Payment Frequency: {homeLoan.PaymentFrequency()}");

PersonalLoan personalLoan = new();
Console.WriteLine($"Personal Loan Payment Amout: {personalLoan.PaymentAmount()} | Personal Loan Payment Frequency: {personalLoan.PaymentFrequency()}");

