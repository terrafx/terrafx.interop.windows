// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIEGES
{
    /// <include file='DIEGES.xml' path='doc/member[@name="DIEGES.DIEGES_PLAYING"]/*' />
    [NativeTypeName("#define DIEGES_PLAYING 0x00000001")]
    public const int DIEGES_PLAYING = 0x00000001;

    /// <include file='DIEGES.xml' path='doc/member[@name="DIEGES.DIEGES_EMULATED"]/*' />
    [NativeTypeName("#define DIEGES_EMULATED 0x00000002")]
    public const int DIEGES_EMULATED = 0x00000002;
}
