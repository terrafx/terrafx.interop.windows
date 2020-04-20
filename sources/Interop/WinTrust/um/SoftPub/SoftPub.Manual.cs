using System;

namespace TerraFX.Interop.um.SoftPub
{
    public static class SoftPub
    {
        public const string SP_POLICY_PROVIDER_DLL_NAME = "WINTRUST.DLL";

        public const string SP_INIT_FUNCTION = "SoftpubInitialize";

        public const string SP_OBJTRUST_FUNCTION = "SoftpubLoadMessage";

        public const string SP_SIGTRUST_FUNCTION = "SoftpubLoadSignature";

        public const string SP_CHKCERT_FUNCTION = "SoftpubCheckCert";

        public const string SP_FINALPOLICY_FUNCTION = "SoftpubAuthenticode";

        public const string SP_CLEANUPPOLICY_FUNCTION = "SoftpubCleanup";

        public const string SP_TESTDUMPPOLICY_FUNCTION_TEST = "SoftpubDumpStructure";

        public const string SP_GENERIC_CERT_INIT_FUNCTION = "SoftpubDefCertInit";

        public const string GENERIC_CHAIN_FINALPOLICY_FUNCTION = "GenericChainFinalProv";

        public const string GENERIC_CHAIN_CERTTRUST_FUNCTION = "GenericChainCertificateTrust";

        public const string HTTPS_FINALPOLICY_FUNCTION = "HTTPSFinalProv";

        public const string HTTPS_CHKCERT_FUNCTION = "HTTPSCheckCertProv";

        public const string HTTPS_CERTTRUST_FUNCTION = "HTTPSCertificateTrust";

        public const string OFFICE_INITPROV_FUNCTION = "OfficeInitializePolicy";

        public const string OFFICE_CLEANUPPOLICY_FUNCTION = "OfficeCleanupPolicy";

        public const string DRIVER_INITPROV_FUNCTION = "DriverInitializePolicy";

        public const string DRIVER_FINALPOLPROV_FUNCTION = "DriverFinalPolicy";

        public const string DRIVER_CLEANUPPOLICY_FUNCTION = "DriverCleanupPolicy";

        public static readonly Guid WINTRUST_ACTION_GENERIC_VERIFY_V2 = new Guid(0xAAC56B, 0xCD44, 0x11D0, 0x8C, 0xC2, 0x0, 0xC0, 0x4F, 0xC2, 0x95, 0xEE);

        public static readonly Guid WINTRUST_ACTION_TRUSTPROVIDER_TEST = new Guid(0x573E31F8, 0xDDBA, 0x11D0, 0x8C, 0xCB, 0x0, 0xC0, 0x4F, 0xC2, 0x95, 0xEE);

        public static readonly Guid WINTRUST_ACTION_GENERIC_CHAIN_VERIFY = new Guid(0xFC451C16, 0xAC75, 0x11D1, 0xB4, 0xB8, 0x00, 0xC0, 0x4F, 0xB6, 0x6E, 0xA0);

        public static readonly Guid HTTPSPROV_ACTION = new Guid(0x573E31F8, 0xAABA, 0x11D0, 0x8C, 0xCB, 0x0, 0xC0, 0x4F, 0xC2, 0x95, 0xEE);

        public static readonly Guid OFFICESIGN_ACTION_VERIFY = new Guid(0x5555C2CD, 0x17FB, 0x11D1, 0x85, 0xC4, 0x0, 0xC0, 0x4F, 0xC2, 0x95, 0xEE);

        public const string OFFICE_POLICY_PROVIDER_DLL_NAME = SP_POLICY_PROVIDER_DLL_NAME;

        public static readonly Guid DRIVER_ACTION_VERIFY = new Guid(0xF750E6C3, 0x38EE, 0x11D1, 0x85, 0xE5, 0x0, 0xC0, 0x4F, 0xC2, 0x95, 0xEE);

        public static readonly Guid CONFIG_CI_ACTION_VERIFY = new Guid(0x6078065B, 0x8F22, 0x4B13, 0xBD, 0x9B, 0x5B, 0x76, 0x27, 0x76, 0xF3, 0x86);
    }
}
