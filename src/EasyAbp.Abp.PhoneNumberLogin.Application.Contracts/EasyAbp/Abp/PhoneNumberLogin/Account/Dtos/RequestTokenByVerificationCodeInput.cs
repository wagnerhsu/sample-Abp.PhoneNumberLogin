﻿using System;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.Identity;
using Volo.Abp.Validation;

namespace EasyAbp.Abp.PhoneNumberLogin.Account.Dtos
{
    [Serializable]
    public class RequestTokenByVerificationCodeInput
    {
        [Required]
        [DynamicStringLength(typeof(IdentityUserConsts), nameof(IdentityUserConsts.MaxPhoneNumberLength))]
        public string PhoneNumber { get; set; }
        
        [Required]
        [DynamicStringLength(typeof(PhoneNumberLoginConsts), nameof(PhoneNumberLoginConsts.MaxVerificationCodeLength))]
        public string VerificationCode { get; set; }
    }
}