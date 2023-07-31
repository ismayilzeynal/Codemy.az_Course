using Microsoft.AspNetCore.Identity;

namespace Codemy.Helpers
{
    public class CustomIdentityErrorDescriber : IdentityErrorDescriber
    {
        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateUserName),
                Description = $"'{userName}' artiq movcuddur..."
            };
        }
    }
}
