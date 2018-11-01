﻿using System;
using Common.PasswordTools;
using Core.Exceptions;
using MessagePack;

namespace Core.Registration
{
    [MessagePackObject(keyAsPropertyName: true)]
    public class RegistrationModel : IPasswordKeeping
    {
        public string RegistrationId { get; }
        public string Hash { get; set; }
        public string Salt { get; set; }
        public string Email { get; }
        public string ClientId { get; private set; }
        public RegistrationStep RegistrationStep { get; private set; }
        public RegistrationModel(string email)
        {
            Email = email;
            RegistrationId = GenerateRegistrationId();
        }

        [SerializationConstructor]
        public RegistrationModel(string registrationId, string email, string clientId, string hash, string salt, RegistrationStep registrationStep)
        {
            RegistrationId = registrationId;
            Email = email;
            ClientId = clientId;
            Hash = hash;
            Salt = salt;
            RegistrationStep = registrationStep;
        }

        private string GenerateRegistrationId()
        {
            var guid = Guid.NewGuid();
            var enc = Convert.ToBase64String(guid.ToByteArray());
            enc = enc.Replace("/", "_");
            enc = enc.Replace("+", "-");
            return enc.Substring(0, 22);
        }

        public void SetInitialInfo(RegistrationDto registrationDto)
        {
            if (registrationDto.Email != Email)
                throw new ArgumentException("Email doesn't match to verified one.");
            if (IsPasswordPwnd())
                throw new PasswordIsPwndException();
            ClientId = registrationDto.ClientId;
            this.SetPassword(registrationDto.Password);
            RegistrationStep = RegistrationStep.AccountInformation;
        }

        private bool IsPasswordPwnd()
        {
            //todo: use verification service
            return false;
        }
    }
}