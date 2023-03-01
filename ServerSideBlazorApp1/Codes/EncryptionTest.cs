using Microsoft.AspNetCore.DataProtection;

namespace ServerSideBlazorApp1.Codes
{
    public class EncryptionTest
    {
        private readonly IDataProtector _dataProtector;
        public EncryptionTest(IDataProtectionProvider dataProtector)
        {
            _dataProtector = dataProtector.CreateProtector("BlazoreServerApp1.codes.EncryptionTest.Oliver");
        }

        public string Protect(string valueToEncrypt) => _dataProtector.Protect(valueToEncrypt);
        public string UnProtect(string valueToDecrypt) => _dataProtector.Unprotect(valueToDecrypt);
    }
}
