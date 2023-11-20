using Microsoft.AspNetCore.Identity;

namespace MyVaccine.WebApi.Dtos
{
    public class AuthResponseDto
    {
        public  string Token { get; set; }
        public DateTime Expiration { get; set; }
        public bool IsSucces {  get; set; }
        //public string[] IsErrors { get; set; }
        public string[] Errors { get; set; }
    }

}
