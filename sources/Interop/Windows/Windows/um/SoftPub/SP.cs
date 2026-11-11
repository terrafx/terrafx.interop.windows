// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SP
{
    /// <include file='SP.xml' path='doc/member[@name="SP.SP_POLICY_PROVIDER_DLL_NAME"]/*' />
    [NativeTypeName("#define SP_POLICY_PROVIDER_DLL_NAME L\"WINTRUST.DLL\"")]
    public const string SP_POLICY_PROVIDER_DLL_NAME = "WINTRUST.DLL";

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_INIT_FUNCTION"]/*' />
    [NativeTypeName("#define SP_INIT_FUNCTION L\"SoftpubInitialize\"")]
    public const string SP_INIT_FUNCTION = "SoftpubInitialize";

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_OBJTRUST_FUNCTION"]/*' />
    [NativeTypeName("#define SP_OBJTRUST_FUNCTION L\"SoftpubLoadMessage\"")]
    public const string SP_OBJTRUST_FUNCTION = "SoftpubLoadMessage";

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_SIGTRUST_FUNCTION"]/*' />
    [NativeTypeName("#define SP_SIGTRUST_FUNCTION L\"SoftpubLoadSignature\"")]
    public const string SP_SIGTRUST_FUNCTION = "SoftpubLoadSignature";

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_CHKCERT_FUNCTION"]/*' />
    [NativeTypeName("#define SP_CHKCERT_FUNCTION L\"SoftpubCheckCert\"")]
    public const string SP_CHKCERT_FUNCTION = "SoftpubCheckCert";

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_FINALPOLICY_FUNCTION"]/*' />
    [NativeTypeName("#define SP_FINALPOLICY_FUNCTION L\"SoftpubAuthenticode\"")]
    public const string SP_FINALPOLICY_FUNCTION = "SoftpubAuthenticode";

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_CLEANUPPOLICY_FUNCTION"]/*' />
    [NativeTypeName("#define SP_CLEANUPPOLICY_FUNCTION L\"SoftpubCleanup\"")]
    public const string SP_CLEANUPPOLICY_FUNCTION = "SoftpubCleanup";

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_TESTDUMPPOLICY_FUNCTION_TEST"]/*' />
    [NativeTypeName("#define SP_TESTDUMPPOLICY_FUNCTION_TEST L\"SoftpubDumpStructure\"")]
    public const string SP_TESTDUMPPOLICY_FUNCTION_TEST = "SoftpubDumpStructure";

    /// <include file='SP.xml' path='doc/member[@name="SP.SP_GENERIC_CERT_INIT_FUNCTION"]/*' />
    [NativeTypeName("#define SP_GENERIC_CERT_INIT_FUNCTION L\"SoftpubDefCertInit\"")]
    public const string SP_GENERIC_CERT_INIT_FUNCTION = "SoftpubDefCertInit";
}
