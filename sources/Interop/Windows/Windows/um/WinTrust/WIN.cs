// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class WIN
{
    /// <include file='WIN.xml' path='doc/member[@name="WIN.WIN_CERT_REVISION_1_0"]/*' />
    [NativeTypeName("#define WIN_CERT_REVISION_1_0 (0x0100)")]
    public const int WIN_CERT_REVISION_1_0 = (0x0100);

    /// <include file='WIN.xml' path='doc/member[@name="WIN.WIN_CERT_REVISION_2_0"]/*' />
    [NativeTypeName("#define WIN_CERT_REVISION_2_0 (0x0200)")]
    public const int WIN_CERT_REVISION_2_0 = (0x0200);

    /// <include file='WIN.xml' path='doc/member[@name="WIN.WIN_CERT_TYPE_X509"]/*' />
    [NativeTypeName("#define WIN_CERT_TYPE_X509 (0x0001)")]
    public const int WIN_CERT_TYPE_X509 = (0x0001);

    /// <include file='WIN.xml' path='doc/member[@name="WIN.WIN_CERT_TYPE_PKCS_SIGNED_DATA"]/*' />
    [NativeTypeName("#define WIN_CERT_TYPE_PKCS_SIGNED_DATA (0x0002)")]
    public const int WIN_CERT_TYPE_PKCS_SIGNED_DATA = (0x0002);

    /// <include file='WIN.xml' path='doc/member[@name="WIN.WIN_CERT_TYPE_RESERVED_1"]/*' />
    [NativeTypeName("#define WIN_CERT_TYPE_RESERVED_1 (0x0003)")]
    public const int WIN_CERT_TYPE_RESERVED_1 = (0x0003);

    /// <include file='WIN.xml' path='doc/member[@name="WIN.WIN_CERT_TYPE_TS_STACK_SIGNED"]/*' />
    [NativeTypeName("#define WIN_CERT_TYPE_TS_STACK_SIGNED (0x0004)")]
    public const int WIN_CERT_TYPE_TS_STACK_SIGNED = (0x0004);
}
