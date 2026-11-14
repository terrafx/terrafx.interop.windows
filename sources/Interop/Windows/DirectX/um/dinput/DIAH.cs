// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIAH
{
    /// <include file='DIAH.xml' path='doc/member[@name="DIAH.DIAH_UNMAPPED"]/*' />
    [NativeTypeName("#define DIAH_UNMAPPED 0x00000000")]
    public const int DIAH_UNMAPPED = 0x00000000;

    /// <include file='DIAH.xml' path='doc/member[@name="DIAH.DIAH_USERCONFIG"]/*' />
    [NativeTypeName("#define DIAH_USERCONFIG 0x00000001")]
    public const int DIAH_USERCONFIG = 0x00000001;

    /// <include file='DIAH.xml' path='doc/member[@name="DIAH.DIAH_APPREQUESTED"]/*' />
    [NativeTypeName("#define DIAH_APPREQUESTED 0x00000002")]
    public const int DIAH_APPREQUESTED = 0x00000002;

    /// <include file='DIAH.xml' path='doc/member[@name="DIAH.DIAH_HWAPP"]/*' />
    [NativeTypeName("#define DIAH_HWAPP 0x00000004")]
    public const int DIAH_HWAPP = 0x00000004;

    /// <include file='DIAH.xml' path='doc/member[@name="DIAH.DIAH_HWDEFAULT"]/*' />
    [NativeTypeName("#define DIAH_HWDEFAULT 0x00000008")]
    public const int DIAH_HWDEFAULT = 0x00000008;

    /// <include file='DIAH.xml' path='doc/member[@name="DIAH.DIAH_DEFAULT"]/*' />
    [NativeTypeName("#define DIAH_DEFAULT 0x00000020")]
    public const int DIAH_DEFAULT = 0x00000020;

    /// <include file='DIAH.xml' path='doc/member[@name="DIAH.DIAH_ERROR"]/*' />
    [NativeTypeName("#define DIAH_ERROR 0x80000000")]
    public const uint DIAH_ERROR = 0x80000000;
}
