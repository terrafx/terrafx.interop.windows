// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class NI
{
    /// <include file='NI.xml' path='doc/member[@name="NI.NI_NOFQDN"]/*' />
    [NativeTypeName("#define NI_NOFQDN 0x01")]
    public const int NI_NOFQDN = 0x01;

    /// <include file='NI.xml' path='doc/member[@name="NI.NI_NUMERICHOST"]/*' />
    [NativeTypeName("#define NI_NUMERICHOST 0x02")]
    public const int NI_NUMERICHOST = 0x02;

    /// <include file='NI.xml' path='doc/member[@name="NI.NI_NAMEREQD"]/*' />
    [NativeTypeName("#define NI_NAMEREQD 0x04")]
    public const int NI_NAMEREQD = 0x04;

    /// <include file='NI.xml' path='doc/member[@name="NI.NI_NUMERICSERV"]/*' />
    [NativeTypeName("#define NI_NUMERICSERV 0x08")]
    public const int NI_NUMERICSERV = 0x08;

    /// <include file='NI.xml' path='doc/member[@name="NI.NI_DGRAM"]/*' />
    [NativeTypeName("#define NI_DGRAM 0x10")]
    public const int NI_DGRAM = 0x10;

    /// <include file='NI.xml' path='doc/member[@name="NI.NI_MAXHOST"]/*' />
    [NativeTypeName("#define NI_MAXHOST 1025")]
    public const int NI_MAXHOST = 1025;

    /// <include file='NI.xml' path='doc/member[@name="NI.NI_MAXSERV"]/*' />
    [NativeTypeName("#define NI_MAXSERV 32")]
    public const int NI_MAXSERV = 32;
}
