namespace NumberLibrary
{
    public static class Number
    {
        public static bool IsNumberEven(this int? number)
        {


            if (number == null)
            {
                return false;
            }
            else
            {
                if(number % 2 == 0)
                {
                    return true;
                }
            }


            return false;
        }
    }
}