public class UserService
{
    private readonly UserValidator _validator = new UserValidator();
    private readonly UserRepository _repository = new UserRepository();
    private readonly Notifier _notifier = new Notifier();

    public void CreateUser(string name)
    {
        if (!_validator.IsValid(name))
        {
            _notifier.Notify("Error: nombre invalido");
            return;
        }

        _repository.Save(name);
        _notifier.Notify("Usuario creado correctamente");
    }
}
