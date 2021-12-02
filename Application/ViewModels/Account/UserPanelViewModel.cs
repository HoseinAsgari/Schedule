namespace Application.ViewModels.Account
{
    public class UserPanelViewModel
    {
        public string Email { get; set; }
        public string SignInDate { get; set; }
        public string UserAddress { get; set; }
        public bool ActiveEmail { get; set; }
        public ChangePasswordViewModel ChangePasswordViewModel { get; set; }
    }
}
