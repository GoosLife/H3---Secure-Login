using H3___Secure_Login.Models;

namespace H3___Secure_Login.Security.Validation
{
    public class LoginValidator : IInputValidator<LoginModel>
    {
        public static bool Validate(LoginModel input)
        {


            return true;
        }
    }
}
