﻿namespace BlazorAuthGoogle.Authentications
{
    public class AppUser
    {
         public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
