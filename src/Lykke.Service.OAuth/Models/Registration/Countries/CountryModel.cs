﻿using Core.Countries;

namespace Lykke.Service.OAuth.Models.Registration.Countries
{
    /// <summary>
    ///     Country model
    /// </summary>
    public class CountryModel
    {
        /// <summary>
        ///     Iso2 country code
        /// </summary>
        public string Iso2 { get; }

        /// <summary>
        ///     Country display name
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     Phone prefix
        /// </summary>
        public string PhonePrefix { get; }

        public CountryModel(CountryInfo countryInfo)
        {
            Iso2 = countryInfo.Iso2;
            Name = countryInfo.Name;
            PhonePrefix = countryInfo.PhonePrefix;
        }
    }
}