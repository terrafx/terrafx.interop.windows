// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DLOCK
{
    /// <include file='D3DLOCK.xml' path='doc/member[@name="D3DLOCK.D3DLOCK_READONLY"]/*' />
    [NativeTypeName("#define D3DLOCK_READONLY 0x00000010L")]
    public const int D3DLOCK_READONLY = 0x00000010;

    /// <include file='D3DLOCK.xml' path='doc/member[@name="D3DLOCK.D3DLOCK_DISCARD"]/*' />
    [NativeTypeName("#define D3DLOCK_DISCARD 0x00002000L")]
    public const int D3DLOCK_DISCARD = 0x00002000;

    /// <include file='D3DLOCK.xml' path='doc/member[@name="D3DLOCK.D3DLOCK_NOOVERWRITE"]/*' />
    [NativeTypeName("#define D3DLOCK_NOOVERWRITE 0x00001000L")]
    public const int D3DLOCK_NOOVERWRITE = 0x00001000;

    /// <include file='D3DLOCK.xml' path='doc/member[@name="D3DLOCK.D3DLOCK_NOSYSLOCK"]/*' />
    [NativeTypeName("#define D3DLOCK_NOSYSLOCK 0x00000800L")]
    public const int D3DLOCK_NOSYSLOCK = 0x00000800;

    /// <include file='D3DLOCK.xml' path='doc/member[@name="D3DLOCK.D3DLOCK_DONOTWAIT"]/*' />
    [NativeTypeName("#define D3DLOCK_DONOTWAIT 0x00004000L")]
    public const int D3DLOCK_DONOTWAIT = 0x00004000;

    /// <include file='D3DLOCK.xml' path='doc/member[@name="D3DLOCK.D3DLOCK_NO_DIRTY_UPDATE"]/*' />
    [NativeTypeName("#define D3DLOCK_NO_DIRTY_UPDATE 0x00008000L")]
    public const int D3DLOCK_NO_DIRTY_UPDATE = 0x00008000;
}
