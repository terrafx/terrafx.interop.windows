// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PROV
{
    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_RSA_FULL"]/*' />
    [NativeTypeName("#define PROV_RSA_FULL 1")]
    public const int PROV_RSA_FULL = 1;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_RSA_SIG"]/*' />
    [NativeTypeName("#define PROV_RSA_SIG 2")]
    public const int PROV_RSA_SIG = 2;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_DSS"]/*' />
    [NativeTypeName("#define PROV_DSS 3")]
    public const int PROV_DSS = 3;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_FORTEZZA"]/*' />
    [NativeTypeName("#define PROV_FORTEZZA 4")]
    public const int PROV_FORTEZZA = 4;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_MS_EXCHANGE"]/*' />
    [NativeTypeName("#define PROV_MS_EXCHANGE 5")]
    public const int PROV_MS_EXCHANGE = 5;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_SSL"]/*' />
    [NativeTypeName("#define PROV_SSL 6")]
    public const int PROV_SSL = 6;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_RSA_SCHANNEL"]/*' />
    [NativeTypeName("#define PROV_RSA_SCHANNEL 12")]
    public const int PROV_RSA_SCHANNEL = 12;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_DSS_DH"]/*' />
    [NativeTypeName("#define PROV_DSS_DH 13")]
    public const int PROV_DSS_DH = 13;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_EC_ECDSA_SIG"]/*' />
    [NativeTypeName("#define PROV_EC_ECDSA_SIG 14")]
    public const int PROV_EC_ECDSA_SIG = 14;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_EC_ECNRA_SIG"]/*' />
    [NativeTypeName("#define PROV_EC_ECNRA_SIG 15")]
    public const int PROV_EC_ECNRA_SIG = 15;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_EC_ECDSA_FULL"]/*' />
    [NativeTypeName("#define PROV_EC_ECDSA_FULL 16")]
    public const int PROV_EC_ECDSA_FULL = 16;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_EC_ECNRA_FULL"]/*' />
    [NativeTypeName("#define PROV_EC_ECNRA_FULL 17")]
    public const int PROV_EC_ECNRA_FULL = 17;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_DH_SCHANNEL"]/*' />
    [NativeTypeName("#define PROV_DH_SCHANNEL 18")]
    public const int PROV_DH_SCHANNEL = 18;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_SPYRUS_LYNKS"]/*' />
    [NativeTypeName("#define PROV_SPYRUS_LYNKS 20")]
    public const int PROV_SPYRUS_LYNKS = 20;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_RNG"]/*' />
    [NativeTypeName("#define PROV_RNG 21")]
    public const int PROV_RNG = 21;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_INTEL_SEC"]/*' />
    [NativeTypeName("#define PROV_INTEL_SEC 22")]
    public const int PROV_INTEL_SEC = 22;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_REPLACE_OWF"]/*' />
    [NativeTypeName("#define PROV_REPLACE_OWF 23")]
    public const int PROV_REPLACE_OWF = 23;

    /// <include file='PROV.xml' path='doc/member[@name="PROV.PROV_RSA_AES"]/*' />
    [NativeTypeName("#define PROV_RSA_AES 24")]
    public const int PROV_RSA_AES = 24;
}
