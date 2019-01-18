﻿using System.ComponentModel.DataAnnotations;
using Core.Registration;
using Lykke.Service.OAuth.Attributes;

namespace Lykke.Service.OAuth.Models.Registration
{
    /// <summary>
    /// Account information registration step details
    /// </summary>
    public class AccountInfoRequestModel
    {
        /// <summary>
        /// Gets or sets first name
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets last name
        /// </summary>
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets country code in iso2 format
        /// </summary>
        [Required]
        [MaxLength(2)]
        public string CountryCodeIso2{ get; set; }

        /// <summary>
        /// Gets or sets phone number
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The Id of registration. Obtained while email verification
        /// </summary>
        [ValidateRegistrationId]
        public string RegistrationId { get; set; }
        
        /// <summary>
        /// Client id from GA
        /// </summary>
        public string Cid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public AccountInfoDto ToDto()
        {
            return new AccountInfoDto
            {
                PhoneNumber = PhoneNumber,
                FirstName = FirstName,
                LastName = LastName,
                CountryCodeIso2 = CountryCodeIso2,
                RegistrationId = RegistrationId
            };
        }
    }
}