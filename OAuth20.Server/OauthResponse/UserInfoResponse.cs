namespace OAuth20.Server.OauthResponse
{
    public class UserInfoResponse
    {
        public string sub { get; set; }
        public string email { get; set; }
        public string given_name { get; set; }
        public string amr { get; set; }
        public string nonce { get; }
        public int exp { get; set; }
        public string iss { get; set; }
        public string aud { get; set; }

        public UserInfoResponse(string sub, string email, string given_name, string amr, string nonce, int exp, string iss, string aud)
        {
            this.sub = sub;
            this.email = email;
            this.given_name = given_name;
            this.amr = amr;
            this.nonce = nonce;
            this.exp = exp;
            this.iss = iss;
            this.aud = aud;
        }
    }

}
