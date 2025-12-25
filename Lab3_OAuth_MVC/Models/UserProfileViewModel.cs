namespace Lab3_OAuth_MVC.Models
{
    public class UserProfileViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}