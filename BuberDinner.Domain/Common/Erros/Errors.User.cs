using ErrorOr;

namespace BuberDinner.Domain.Common.Erros;

public static partial class Errors
{
    public static class User
    {
        public static Error DuplicateEmail => Error.Validation(
            code: "User.DuplicateEmail",
            description: "Email is already in use"
        );
    }
}