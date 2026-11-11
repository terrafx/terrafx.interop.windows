// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class CERT
{
    /// <include file='CERT.xml' path='doc/member[@name="CERT.CERT_CONFIDENCE_SIG"]/*' />
    [NativeTypeName("#define CERT_CONFIDENCE_SIG 0x10000000")]
    public const int CERT_CONFIDENCE_SIG = 0x10000000;

    /// <include file='CERT.xml' path='doc/member[@name="CERT.CERT_CONFIDENCE_TIME"]/*' />
    [NativeTypeName("#define CERT_CONFIDENCE_TIME 0x01000000")]
    public const int CERT_CONFIDENCE_TIME = 0x01000000;

    /// <include file='CERT.xml' path='doc/member[@name="CERT.CERT_CONFIDENCE_TIMENEST"]/*' />
    [NativeTypeName("#define CERT_CONFIDENCE_TIMENEST 0x00100000")]
    public const int CERT_CONFIDENCE_TIMENEST = 0x00100000;

    /// <include file='CERT.xml' path='doc/member[@name="CERT.CERT_CONFIDENCE_AUTHIDEXT"]/*' />
    [NativeTypeName("#define CERT_CONFIDENCE_AUTHIDEXT 0x00010000")]
    public const int CERT_CONFIDENCE_AUTHIDEXT = 0x00010000;

    /// <include file='CERT.xml' path='doc/member[@name="CERT.CERT_CONFIDENCE_HYGIENE"]/*' />
    [NativeTypeName("#define CERT_CONFIDENCE_HYGIENE 0x00001000")]
    public const int CERT_CONFIDENCE_HYGIENE = 0x00001000;

    /// <include file='CERT.xml' path='doc/member[@name="CERT.CERT_CONFIDENCE_HIGHEST"]/*' />
    [NativeTypeName("#define CERT_CONFIDENCE_HIGHEST 0x11111000")]
    public const int CERT_CONFIDENCE_HIGHEST = 0x11111000;
}
