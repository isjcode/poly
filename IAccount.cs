namespace ConsoleApp1;

public interface IAccount
{
    public static bool PasswordChecker(string password)
    {
        bool upper_flag = false;
        bool lower_flag = false;
        bool digit_flag = false;
        
        if (password.Length >= 8)
        {
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    upper_flag = true;
                }
                else if (char.IsLower(c))
                {
                    lower_flag = true;
                }
                else if (char.IsDigit(c))
                {
                    digit_flag = true;
                }
            }     
        }

        else
        {
            return false;
        }

        if (upper_flag && lower_flag && digit_flag)
        {
            return true;
        }

        return false;
    }    
}