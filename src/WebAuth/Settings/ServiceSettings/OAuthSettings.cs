﻿using Lykke.SettingsReader.Attributes;

namespace WebAuth.Settings.ServiceSettings
{
    public class OAuthSettings
    {
        public string RegistrationApiUrl { get; set; }
        public string SessionApiUrl { get; set; }
        public DbSettings Db { get; set; }
        public CorsSettings Cors { get; set; } = new CorsSettings();
        [Optional]
        public CspSettings Csp { get; set; } = new CspSettings();
    }
}
