namespace H3___Secure_Login.Security.Validation
{
    public interface IInputValidator<T>
    {
        public static abstract bool Validate(T input);
    }
}
