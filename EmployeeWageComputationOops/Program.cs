﻿using System;

namespace EmployeeWageComputationOops
{
	public class Program
	{
		public static void Main(String[] args)
		{
			EmpWageBuilder empWageBuilder = new EmpWageBuilder();
			empWageBuilder.AddCompany("IBM", 1000, 20, 100);
			empWageBuilder.AddCompany("TATA", 800, 20, 100);
			empWageBuilder.AddCompany("Infy", 900, 20, 100);
			empWageBuilder.AddCompany("Google", 10000, 20, 100);
			empWageBuilder.DisplayCompanyWages();
		}
	}
}
