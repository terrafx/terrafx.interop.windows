// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PCF
{
    /// <include file='PCF.xml' path='doc/member[@name="PCF.PCF_DTRDSR"]/*' />
    [NativeTypeName("#define PCF_DTRDSR ((DWORD)0x0001)")]
    public const uint PCF_DTRDSR = ((uint)(0x0001));

    /// <include file='PCF.xml' path='doc/member[@name="PCF.PCF_RTSCTS"]/*' />
    [NativeTypeName("#define PCF_RTSCTS ((DWORD)0x0002)")]
    public const uint PCF_RTSCTS = ((uint)(0x0002));

    /// <include file='PCF.xml' path='doc/member[@name="PCF.PCF_RLSD"]/*' />
    [NativeTypeName("#define PCF_RLSD ((DWORD)0x0004)")]
    public const uint PCF_RLSD = ((uint)(0x0004));

    /// <include file='PCF.xml' path='doc/member[@name="PCF.PCF_PARITY_CHECK"]/*' />
    [NativeTypeName("#define PCF_PARITY_CHECK ((DWORD)0x0008)")]
    public const uint PCF_PARITY_CHECK = ((uint)(0x0008));

    /// <include file='PCF.xml' path='doc/member[@name="PCF.PCF_XONXOFF"]/*' />
    [NativeTypeName("#define PCF_XONXOFF ((DWORD)0x0010)")]
    public const uint PCF_XONXOFF = ((uint)(0x0010));

    /// <include file='PCF.xml' path='doc/member[@name="PCF.PCF_SETXCHAR"]/*' />
    [NativeTypeName("#define PCF_SETXCHAR ((DWORD)0x0020)")]
    public const uint PCF_SETXCHAR = ((uint)(0x0020));

    /// <include file='PCF.xml' path='doc/member[@name="PCF.PCF_TOTALTIMEOUTS"]/*' />
    [NativeTypeName("#define PCF_TOTALTIMEOUTS ((DWORD)0x0040)")]
    public const uint PCF_TOTALTIMEOUTS = ((uint)(0x0040));

    /// <include file='PCF.xml' path='doc/member[@name="PCF.PCF_INTTIMEOUTS"]/*' />
    [NativeTypeName("#define PCF_INTTIMEOUTS ((DWORD)0x0080)")]
    public const uint PCF_INTTIMEOUTS = ((uint)(0x0080));

    /// <include file='PCF.xml' path='doc/member[@name="PCF.PCF_SPECIALCHARS"]/*' />
    [NativeTypeName("#define PCF_SPECIALCHARS ((DWORD)0x0100)")]
    public const uint PCF_SPECIALCHARS = ((uint)(0x0100));

    /// <include file='PCF.xml' path='doc/member[@name="PCF.PCF_16BITMODE"]/*' />
    [NativeTypeName("#define PCF_16BITMODE ((DWORD)0x0200)")]
    public const uint PCF_16BITMODE = ((uint)(0x0200));
}
