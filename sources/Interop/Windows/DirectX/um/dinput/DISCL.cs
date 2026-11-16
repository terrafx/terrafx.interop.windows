// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DISCL
{
    /// <include file='DISCL.xml' path='doc/member[@name="DISCL.DISCL_EXCLUSIVE"]/*' />
    [NativeTypeName("#define DISCL_EXCLUSIVE 0x00000001")]
    public const int DISCL_EXCLUSIVE = 0x00000001;

    /// <include file='DISCL.xml' path='doc/member[@name="DISCL.DISCL_NONEXCLUSIVE"]/*' />
    [NativeTypeName("#define DISCL_NONEXCLUSIVE 0x00000002")]
    public const int DISCL_NONEXCLUSIVE = 0x00000002;

    /// <include file='DISCL.xml' path='doc/member[@name="DISCL.DISCL_FOREGROUND"]/*' />
    [NativeTypeName("#define DISCL_FOREGROUND 0x00000004")]
    public const int DISCL_FOREGROUND = 0x00000004;

    /// <include file='DISCL.xml' path='doc/member[@name="DISCL.DISCL_BACKGROUND"]/*' />
    [NativeTypeName("#define DISCL_BACKGROUND 0x00000008")]
    public const int DISCL_BACKGROUND = 0x00000008;

    /// <include file='DISCL.xml' path='doc/member[@name="DISCL.DISCL_NOWINKEY"]/*' />
    [NativeTypeName("#define DISCL_NOWINKEY 0x00000010")]
    public const int DISCL_NOWINKEY = 0x00000010;
}
