// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class DIENUM
{
    /// <include file='DIENUM.xml' path='doc/member[@name="DIENUM.DIENUM_STOP"]/*' />
    [NativeTypeName("#define DIENUM_STOP 0")]
    public const int DIENUM_STOP = 0;

    /// <include file='DIENUM.xml' path='doc/member[@name="DIENUM.DIENUM_CONTINUE"]/*' />
    [NativeTypeName("#define DIENUM_CONTINUE 1")]
    public const int DIENUM_CONTINUE = 1;
}
