// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define SP_POLICY_PROVIDER_DLL_NAME L\"WINTRUST.DLL\"")]
        public const string SP_POLICY_PROVIDER_DLL_NAME = "WINTRUST.DLL";

        [NativeTypeName("#define SP_INIT_FUNCTION L\"SoftpubInitialize\"")]
        public const string SP_INIT_FUNCTION = "SoftpubInitialize";

        [NativeTypeName("#define SP_OBJTRUST_FUNCTION L\"SoftpubLoadMessage\"")]
        public const string SP_OBJTRUST_FUNCTION = "SoftpubLoadMessage";

        [NativeTypeName("#define SP_SIGTRUST_FUNCTION L\"SoftpubLoadSignature\"")]
        public const string SP_SIGTRUST_FUNCTION = "SoftpubLoadSignature";

        [NativeTypeName("#define SP_CHKCERT_FUNCTION L\"SoftpubCheckCert\"")]
        public const string SP_CHKCERT_FUNCTION = "SoftpubCheckCert";

        [NativeTypeName("#define SP_FINALPOLICY_FUNCTION L\"SoftpubAuthenticode\"")]
        public const string SP_FINALPOLICY_FUNCTION = "SoftpubAuthenticode";

        [NativeTypeName("#define SP_CLEANUPPOLICY_FUNCTION L\"SoftpubCleanup\"")]
        public const string SP_CLEANUPPOLICY_FUNCTION = "SoftpubCleanup";

        [NativeTypeName("#define SP_TESTDUMPPOLICY_FUNCTION_TEST L\"SoftpubDumpStructure\"")]
        public const string SP_TESTDUMPPOLICY_FUNCTION_TEST = "SoftpubDumpStructure";

        [NativeTypeName("#define SP_GENERIC_CERT_INIT_FUNCTION L\"SoftpubDefCertInit\"")]
        public const string SP_GENERIC_CERT_INIT_FUNCTION = "SoftpubDefCertInit";

        [NativeTypeName("#define GENERIC_CHAIN_FINALPOLICY_FUNCTION L\"GenericChainFinalProv\"")]
        public const string GENERIC_CHAIN_FINALPOLICY_FUNCTION = "GenericChainFinalProv";

        [NativeTypeName("#define GENERIC_CHAIN_CERTTRUST_FUNCTION L\"GenericChainCertificateTrust\"")]
        public const string GENERIC_CHAIN_CERTTRUST_FUNCTION = "GenericChainCertificateTrust";

        [NativeTypeName("#define HTTPS_FINALPOLICY_FUNCTION L\"HTTPSFinalProv\"")]
        public const string HTTPS_FINALPOLICY_FUNCTION = "HTTPSFinalProv";

        [NativeTypeName("#define HTTPS_CHKCERT_FUNCTION L\"HTTPSCheckCertProv\"")]
        public const string HTTPS_CHKCERT_FUNCTION = "HTTPSCheckCertProv";

        [NativeTypeName("#define HTTPS_CERTTRUST_FUNCTION L\"HTTPSCertificateTrust\"")]
        public const string HTTPS_CERTTRUST_FUNCTION = "HTTPSCertificateTrust";

        [NativeTypeName("#define OFFICE_POLICY_PROVIDER_DLL_NAME SP_POLICY_PROVIDER_DLL_NAME")]
        public const string OFFICE_POLICY_PROVIDER_DLL_NAME = "WINTRUST.DLL";

        [NativeTypeName("#define OFFICE_INITPROV_FUNCTION L\"OfficeInitializePolicy\"")]
        public const string OFFICE_INITPROV_FUNCTION = "OfficeInitializePolicy";

        [NativeTypeName("#define OFFICE_CLEANUPPOLICY_FUNCTION L\"OfficeCleanupPolicy\"")]
        public const string OFFICE_CLEANUPPOLICY_FUNCTION = "OfficeCleanupPolicy";

        [NativeTypeName("#define DRIVER_INITPROV_FUNCTION L\"DriverInitializePolicy\"")]
        public const string DRIVER_INITPROV_FUNCTION = "DriverInitializePolicy";

        [NativeTypeName("#define DRIVER_FINALPOLPROV_FUNCTION L\"DriverFinalPolicy\"")]
        public const string DRIVER_FINALPOLPROV_FUNCTION = "DriverFinalPolicy";

        [NativeTypeName("#define DRIVER_CLEANUPPOLICY_FUNCTION L\"DriverCleanupPolicy\"")]
        public const string DRIVER_CLEANUPPOLICY_FUNCTION = "DriverCleanupPolicy";

        [NativeTypeName("#define CCPI_RESULT_ALLOW 1")]
        public const int CCPI_RESULT_ALLOW = 1;

        [NativeTypeName("#define CCPI_RESULT_DENY 2")]
        public const int CCPI_RESULT_DENY = 2;

        [NativeTypeName("#define CCPI_RESULT_AUDIT 3")]
        public const int CCPI_RESULT_AUDIT = 3;
    }
}
