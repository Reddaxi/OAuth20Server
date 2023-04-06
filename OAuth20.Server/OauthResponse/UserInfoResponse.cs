namespace OAuth20.Server.OauthResponse
{
    public class UserInfoResponse
    {
        public string sub { get; set; }
        public string email { get; set; }
        public string given_name { get; set; }


        public UserInfoResponse(string sub, string email, string given_name)
        {
            this.sub = sub;
            this.email = email;
            this.given_name = given_name;
        }
    }

}
