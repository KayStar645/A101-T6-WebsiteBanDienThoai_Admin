using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Validators
{
	public class CommonCustomValidator
	{
		public static bool IsAtLeastNYearsOld(DateTime? dateOfBirth, int year)
		{
			DateTime currentDate = DateTime.Now;
			DateTime minimumBirthDate = currentDate.AddYears(-year);
			return dateOfBirth <= minimumBirthDate;
		}
	}
}
