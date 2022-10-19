﻿namespace Core.Security.Interfaces.IOtpAuthenticator
{
    public interface IOtpAuthenticatorHelper
    {
        public Task<byte[]> GenerateSecretKey();
        public Task<string> ConvertSecretKeyToString(byte[] secretKey);
        public Task<bool> VerifyCode(byte[] secretKey, string code);
    }
}