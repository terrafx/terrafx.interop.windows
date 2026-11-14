// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class SCS
{
    /// <include file='SCS.xml' path='doc/member[@name="SCS.SCS_CAP_COMPSTR"]/*' />
    [NativeTypeName("#define SCS_CAP_COMPSTR 0x00000001")]
    public const int SCS_CAP_COMPSTR = 0x00000001;

    /// <include file='SCS.xml' path='doc/member[@name="SCS.SCS_CAP_MAKEREAD"]/*' />
    [NativeTypeName("#define SCS_CAP_MAKEREAD 0x00000002")]
    public const int SCS_CAP_MAKEREAD = 0x00000002;

    /// <include file='SCS.xml' path='doc/member[@name="SCS.SCS_CAP_SETRECONVERTSTRING"]/*' />
    [NativeTypeName("#define SCS_CAP_SETRECONVERTSTRING 0x00000004")]
    public const int SCS_CAP_SETRECONVERTSTRING = 0x00000004;

    /// <include file='SCS.xml' path='doc/member[@name="SCS.SCS_SETSTR"]/*' />
    [NativeTypeName("#define SCS_SETSTR (GCS_COMPREADSTR|GCS_COMPSTR)")]
    public const int SCS_SETSTR = (0x0001 | 0x0008);

    /// <include file='SCS.xml' path='doc/member[@name="SCS.SCS_CHANGEATTR"]/*' />
    [NativeTypeName("#define SCS_CHANGEATTR (GCS_COMPREADATTR|GCS_COMPATTR)")]
    public const int SCS_CHANGEATTR = (0x0002 | 0x0010);

    /// <include file='SCS.xml' path='doc/member[@name="SCS.SCS_CHANGECLAUSE"]/*' />
    [NativeTypeName("#define SCS_CHANGECLAUSE (GCS_COMPREADCLAUSE|GCS_COMPCLAUSE)")]
    public const int SCS_CHANGECLAUSE = (0x0004 | 0x0020);

    /// <include file='SCS.xml' path='doc/member[@name="SCS.SCS_SETRECONVERTSTRING"]/*' />
    [NativeTypeName("#define SCS_SETRECONVERTSTRING 0x00010000")]
    public const int SCS_SETRECONVERTSTRING = 0x00010000;

    /// <include file='SCS.xml' path='doc/member[@name="SCS.SCS_QUERYRECONVERTSTRING"]/*' />
    [NativeTypeName("#define SCS_QUERYRECONVERTSTRING 0x00020000")]
    public const int SCS_QUERYRECONVERTSTRING = 0x00020000;
}
