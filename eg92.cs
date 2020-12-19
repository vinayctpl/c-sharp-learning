using System;
class FinanceCalculator
{
	public int calculateEligibility(int familyMember,int income)
	{
		int loanAmount;
		loanAmount=(income/familyMember)*15;
		return loanAmount;
	}
}
class eg92psp
{
	public static void Main()
	{
		int familyMembers,income,loanAmount;
		income=15000;
		familyMembers=0;
		FinanceCalculator fc=new FinanceCalculator();
		try
		{
			loanAmount=fc.calculateEligibility(familyMembers,income);
			System.Console.WriteLine("Loan Amount"+loanAmount);
		}catch(DivideByZeroException)
		{
			System.Console.WriteLine("Caught DBZE");
		}
	}
}