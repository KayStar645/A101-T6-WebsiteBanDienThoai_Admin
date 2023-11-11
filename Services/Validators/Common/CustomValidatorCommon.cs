namespace Services.Validators.Common
{
    public class CustomValidatorCommon
    {
        public static bool IsAtLeastNYearsOld(DateTime? pDateOfBirth, int pYear)
        {
            DateTime currentDate = DateTime.Now;
            DateTime minimumBirthDate = currentDate.AddYears(-pYear);
            return pDateOfBirth <= minimumBirthDate;
        }

        public static bool IsEqualOrAfterDay(DateTime? time, DateTime day)
        {
            return time >= day;
        }


        public static bool IsAfterDay(DateTime? time, DateTime day)
        {
            return time > day;
        }
    }
}
