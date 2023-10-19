using Souccar.Debugging;

namespace Souccar
{
    public class SouccarConsts
    {
        public const string LocalizationSourceName = "Souccar";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "81c84e0608ce490496adf2beaed30bc3";
    }
}
