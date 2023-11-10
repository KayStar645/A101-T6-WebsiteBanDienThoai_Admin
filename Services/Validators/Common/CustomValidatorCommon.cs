namespace Services.Validators.Common
{
    public class CustomValidatorCommon
    {
        public static bool IsAtLeastNYearsOld(DateTime? dateOfBirth, int year)
        {
            DateTime currentDate = DateTime.Now;
            DateTime minimumBirthDate = currentDate.AddYears(-year);
            return dateOfBirth <= minimumBirthDate;
        }
    }
}
