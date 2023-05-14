using ShopDAL;

namespace ShopWebAPI.DTO
{
    public class UserResponse
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public UserResponse() { }

        public UserResponse(User user)
        {
            UserId = user.UserId;
            UserName = user.UserName;
            RoleID = user.RoleID;
            RoleName = RoleID==1?"Admin":"User";
        }
        
    }
}
