using System.Text.RegularExpressions;

namespace H3___Secure_Login.Security.Validation
{
    public class UsernameValidator : IInputValidator<string>
    {
        public static bool Validate(string input)
        {
            if (input.Length < 3 || input.Length > 20)
            {
                return false;
            }
            return true;
        }
    }
}
