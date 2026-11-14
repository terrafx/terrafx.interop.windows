// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class PST
{
    /// <include file='PST.xml' path='doc/member[@name="PST.PST_UNSPECIFIED"]/*' />
    [NativeTypeName("#define PST_UNSPECIFIED ((DWORD)0x00000000)")]
    public const uint PST_UNSPECIFIED = ((uint)(0x00000000));

    /// <include file='PST.xml' path='doc/member[@name="PST.PST_RS232"]/*' />
    [NativeTypeName("#define PST_RS232 ((DWORD)0x00000001)")]
    public const uint PST_RS232 = ((uint)(0x00000001));

    /// <include file='PST.xml' path='doc/member[@name="PST.PST_PARALLELPORT"]/*' />
    [NativeTypeName("#define PST_PARALLELPORT ((DWORD)0x00000002)")]
    public const uint PST_PARALLELPORT = ((uint)(0x00000002));

    /// <include file='PST.xml' path='doc/member[@name="PST.PST_RS422"]/*' />
    [NativeTypeName("#define PST_RS422 ((DWORD)0x00000003)")]
    public const uint PST_RS422 = ((uint)(0x00000003));

    /// <include file='PST.xml' path='doc/member[@name="PST.PST_RS423"]/*' />
    [NativeTypeName("#define PST_RS423 ((DWORD)0x00000004)")]
    public const uint PST_RS423 = ((uint)(0x00000004));

    /// <include file='PST.xml' path='doc/member[@name="PST.PST_RS449"]/*' />
    [NativeTypeName("#define PST_RS449 ((DWORD)0x00000005)")]
    public const uint PST_RS449 = ((uint)(0x00000005));

    /// <include file='PST.xml' path='doc/member[@name="PST.PST_MODEM"]/*' />
    [NativeTypeName("#define PST_MODEM ((DWORD)0x00000006)")]
    public const uint PST_MODEM = ((uint)(0x00000006));

    /// <include file='PST.xml' path='doc/member[@name="PST.PST_FAX"]/*' />
    [NativeTypeName("#define PST_FAX ((DWORD)0x00000021)")]
    public const uint PST_FAX = ((uint)(0x00000021));

    /// <include file='PST.xml' path='doc/member[@name="PST.PST_SCANNER"]/*' />
    [NativeTypeName("#define PST_SCANNER ((DWORD)0x00000022)")]
    public const uint PST_SCANNER = ((uint)(0x00000022));

    /// <include file='PST.xml' path='doc/member[@name="PST.PST_NETWORK_BRIDGE"]/*' />
    [NativeTypeName("#define PST_NETWORK_BRIDGE ((DWORD)0x00000100)")]
    public const uint PST_NETWORK_BRIDGE = ((uint)(0x00000100));

    /// <include file='PST.xml' path='doc/member[@name="PST.PST_LAT"]/*' />
    [NativeTypeName("#define PST_LAT ((DWORD)0x00000101)")]
    public const uint PST_LAT = ((uint)(0x00000101));

    /// <include file='PST.xml' path='doc/member[@name="PST.PST_TCPIP_TELNET"]/*' />
    [NativeTypeName("#define PST_TCPIP_TELNET ((DWORD)0x00000102)")]
    public const uint PST_TCPIP_TELNET = ((uint)(0x00000102));

    /// <include file='PST.xml' path='doc/member[@name="PST.PST_X25"]/*' />
    [NativeTypeName("#define PST_X25 ((DWORD)0x00000103)")]
    public const uint PST_X25 = ((uint)(0x00000103));
}
