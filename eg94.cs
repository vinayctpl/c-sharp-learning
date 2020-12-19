using System;
class FinanceCalculator
{
	public int calculateEligibility(int familyMembers,int income)
	{
		if(familyMembers<0) return -1;
		int loanAmount;
		loanAmount=(income/familyMembers)*15;
		return loanAmount;
	}	
}
class eg93psp
{
	public static void Main(){
		int familyMembers,income,loanAmount;
		income=15000;
		familyMembers=-3;
		FinanceCalculator fc=new FinanceCalculator();
		try
		{
			loanAmount=fc.calculateEligibility(familyMembers,income);
			if(loanAmount==-1) System.Console.WriteLine("Family members cannot be negative");
			else System.Console.WriteLine("Loan Amount "+loanAmount);
		}catch(DivideByZeroException)
		{
			System.Console.WriteLine("Caught DBZE");
		}
	}
}