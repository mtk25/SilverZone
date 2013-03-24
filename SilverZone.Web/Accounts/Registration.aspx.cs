using System;
using System.Web.Security;
using SilverZone.Domain;
using SilverZone.Domain.Impl.Users;
using SilverZone.Domain.Users;

namespace SilverZone.Web.Accounts
{
    public partial class Registration : System.Web.UI.Page
    {
        private readonly IUserRepository _userRepository;

        public Registration()
        {
            _userRepository = new UserRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            var user = GetUser();

            // Save user information 
            // TODO replace with Context.Users.Repository.Save
            Result result = _userRepository.Save(user);
            if (!result.HasErrors)
            {
                MembershipCreateStatus createStatus;
                // create user
                Membership.CreateUser(user.Username, Password.Text, user.Email, null, null, true, user.Id,
                                      out createStatus);
                if (createStatus == MembershipCreateStatus.Success)
                {
                    //log user
                    FormsAuthentication.SetAuthCookie(user.Username,true);
                    
                    // redirect
                     Response.Redirect("/Products/");

                }
                else
                {
                    // else delete user and show message
                    Result deleteResult = _userRepository.Delete(user);
                    if (!deleteResult.HasErrors)
                    {
                        ErrorMessage.Text = GetErrorMessage(createStatus);
                    }


                }
            }
            else
            {
                // show message
                ErrorMessage.Text = result.Message;
            }

        }

        private User GetUser()
        {
            User user = new User();
            user.FirstName = FirstName.Text;
            user.LastName = Lastname.Text;
            user.Email = Email.Text;
            user.Username = Username.Text;

            return user;
        }

        public string GetErrorMessage(MembershipCreateStatus status)
        {
            switch (status)
            {
                case MembershipCreateStatus.DuplicateUserName:
                    return "Username already exists. Please enter a different user name.";

                case MembershipCreateStatus.DuplicateEmail:
                    return "A username for that e-mail address already exists. Please enter a different e-mail address.";

                case MembershipCreateStatus.InvalidPassword:
                    return "The password provided is invalid. Please enter a valid password value.";

                case MembershipCreateStatus.InvalidEmail:
                    return "The e-mail address provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidAnswer:
                    return "The password retrieval answer provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidQuestion:
                    return "The password retrieval question provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.InvalidUserName:
                    return "The user name provided is invalid. Please check the value and try again.";

                case MembershipCreateStatus.ProviderError:
                    return
                        "The authentication provider returned an error. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                case MembershipCreateStatus.UserRejected:
                    return
                        "The user creation request has been canceled. Please verify your entry and try again. If the problem persists, please contact your system administrator.";

                default:
                    return
                        "An unknown error occurred. Please verify your entry and try again. If the problem persists, please contact your system administrator.";
            }
        }
    }
}