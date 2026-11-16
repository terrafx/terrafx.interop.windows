// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.GENERIC_CHAIN_FINALPOLICY_FUNCTION"]/*' />
    [NativeTypeName("#define GENERIC_CHAIN_FINALPOLICY_FUNCTION L\"GenericChainFinalProv\"")]
    public const string GENERIC_CHAIN_FINALPOLICY_FUNCTION = "GenericChainFinalProv";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.GENERIC_CHAIN_CERTTRUST_FUNCTION"]/*' />
    [NativeTypeName("#define GENERIC_CHAIN_CERTTRUST_FUNCTION L\"GenericChainCertificateTrust\"")]
    public const string GENERIC_CHAIN_CERTTRUST_FUNCTION = "GenericChainCertificateTrust";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HTTPS_FINALPOLICY_FUNCTION"]/*' />
    [NativeTypeName("#define HTTPS_FINALPOLICY_FUNCTION L\"HTTPSFinalProv\"")]
    public const string HTTPS_FINALPOLICY_FUNCTION = "HTTPSFinalProv";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HTTPS_CHKCERT_FUNCTION"]/*' />
    [NativeTypeName("#define HTTPS_CHKCERT_FUNCTION L\"HTTPSCheckCertProv\"")]
    public const string HTTPS_CHKCERT_FUNCTION = "HTTPSCheckCertProv";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.HTTPS_CERTTRUST_FUNCTION"]/*' />
    [NativeTypeName("#define HTTPS_CERTTRUST_FUNCTION L\"HTTPSCertificateTrust\"")]
    public const string HTTPS_CERTTRUST_FUNCTION = "HTTPSCertificateTrust";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OFFICE_POLICY_PROVIDER_DLL_NAME"]/*' />
    [NativeTypeName("#define OFFICE_POLICY_PROVIDER_DLL_NAME SP_POLICY_PROVIDER_DLL_NAME")]
    public const string OFFICE_POLICY_PROVIDER_DLL_NAME = "WINTRUST.DLL";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OFFICE_INITPROV_FUNCTION"]/*' />
    [NativeTypeName("#define OFFICE_INITPROV_FUNCTION L\"OfficeInitializePolicy\"")]
    public const string OFFICE_INITPROV_FUNCTION = "OfficeInitializePolicy";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.OFFICE_CLEANUPPOLICY_FUNCTION"]/*' />
    [NativeTypeName("#define OFFICE_CLEANUPPOLICY_FUNCTION L\"OfficeCleanupPolicy\"")]
    public const string OFFICE_CLEANUPPOLICY_FUNCTION = "OfficeCleanupPolicy";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DRIVER_INITPROV_FUNCTION"]/*' />
    [NativeTypeName("#define DRIVER_INITPROV_FUNCTION L\"DriverInitializePolicy\"")]
    public const string DRIVER_INITPROV_FUNCTION = "DriverInitializePolicy";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DRIVER_FINALPOLPROV_FUNCTION"]/*' />
    [NativeTypeName("#define DRIVER_FINALPOLPROV_FUNCTION L\"DriverFinalPolicy\"")]
    public const string DRIVER_FINALPOLPROV_FUNCTION = "DriverFinalPolicy";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.DRIVER_CLEANUPPOLICY_FUNCTION"]/*' />
    [NativeTypeName("#define DRIVER_CLEANUPPOLICY_FUNCTION L\"DriverCleanupPolicy\"")]
    public const string DRIVER_CLEANUPPOLICY_FUNCTION = "DriverCleanupPolicy";

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CCPI_RESULT_ALLOW"]/*' />
    [NativeTypeName("#define CCPI_RESULT_ALLOW 1")]
    public const int CCPI_RESULT_ALLOW = 1;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CCPI_RESULT_DENY"]/*' />
    [NativeTypeName("#define CCPI_RESULT_DENY 2")]
    public const int CCPI_RESULT_DENY = 2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.CCPI_RESULT_AUDIT"]/*' />
    [NativeTypeName("#define CCPI_RESULT_AUDIT 3")]
    public const int CCPI_RESULT_AUDIT = 3;
}
