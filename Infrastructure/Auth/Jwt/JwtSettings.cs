﻿namespace Infrastructure.Auth.Jwt
{
    public class JwtSettings
    {
        public string Key { get; set; }
        public int DurationInMinutes { get; set; }
    }
}
