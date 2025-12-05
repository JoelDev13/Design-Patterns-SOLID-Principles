public class UserValidator
{
    public bool IsValid(string name)
    {
        return !string.IsNullOrWhiteSpace(name);
    }
}
