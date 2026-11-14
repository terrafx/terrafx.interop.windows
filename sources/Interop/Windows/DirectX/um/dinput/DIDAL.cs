// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIDAL
{
    /// <include file='DIDAL.xml' path='doc/member[@name="DIDAL.DIDAL_CENTERED"]/*' />
    [NativeTypeName("#define DIDAL_CENTERED 0x00000000")]
    public const int DIDAL_CENTERED = 0x00000000;

    /// <include file='DIDAL.xml' path='doc/member[@name="DIDAL.DIDAL_LEFTALIGNED"]/*' />
    [NativeTypeName("#define DIDAL_LEFTALIGNED 0x00000001")]
    public const int DIDAL_LEFTALIGNED = 0x00000001;

    /// <include file='DIDAL.xml' path='doc/member[@name="DIDAL.DIDAL_RIGHTALIGNED"]/*' />
    [NativeTypeName("#define DIDAL_RIGHTALIGNED 0x00000002")]
    public const int DIDAL_RIGHTALIGNED = 0x00000002;

    /// <include file='DIDAL.xml' path='doc/member[@name="DIDAL.DIDAL_MIDDLE"]/*' />
    [NativeTypeName("#define DIDAL_MIDDLE 0x00000000")]
    public const int DIDAL_MIDDLE = 0x00000000;

    /// <include file='DIDAL.xml' path='doc/member[@name="DIDAL.DIDAL_TOPALIGNED"]/*' />
    [NativeTypeName("#define DIDAL_TOPALIGNED 0x00000004")]
    public const int DIDAL_TOPALIGNED = 0x00000004;

    /// <include file='DIDAL.xml' path='doc/member[@name="DIDAL.DIDAL_BOTTOMALIGNED"]/*' />
    [NativeTypeName("#define DIDAL_BOTTOMALIGNED 0x00000008")]
    public const int DIDAL_BOTTOMALIGNED = 0x00000008;
}
