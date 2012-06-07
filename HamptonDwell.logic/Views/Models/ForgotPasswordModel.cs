using System.Collections.Generic;

namespace HamptonDwell.Web.Logic.Views.Models
{
    public class ForgotPasswordModel
    {
        public IList<string> ErrorMessages { get; set; }
        public long ShopId { get; set; }
        public string Username { get; set; }
        public string SecretAnswer { get; set; }
        public string SecretQuestion { get; set; }
        public bool PasswordResetSuccessful { get; set; }

        public ForgotPasswordModel()
        {
            ErrorMessages = new List<string>();
        }
    }
}
