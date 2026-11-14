// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DPS20CAPS
{
    /// <include file='D3DPS20CAPS.xml' path='doc/member[@name="D3DPS20CAPS.D3DPS20CAPS_ARBITRARYSWIZZLE"]/*' />
    [NativeTypeName("#define D3DPS20CAPS_ARBITRARYSWIZZLE (1<<0)")]
    public const int D3DPS20CAPS_ARBITRARYSWIZZLE = (1 << 0);

    /// <include file='D3DPS20CAPS.xml' path='doc/member[@name="D3DPS20CAPS.D3DPS20CAPS_GRADIENTINSTRUCTIONS"]/*' />
    [NativeTypeName("#define D3DPS20CAPS_GRADIENTINSTRUCTIONS (1<<1)")]
    public const int D3DPS20CAPS_GRADIENTINSTRUCTIONS = (1 << 1);

    /// <include file='D3DPS20CAPS.xml' path='doc/member[@name="D3DPS20CAPS.D3DPS20CAPS_PREDICATION"]/*' />
    [NativeTypeName("#define D3DPS20CAPS_PREDICATION (1<<2)")]
    public const int D3DPS20CAPS_PREDICATION = (1 << 2);

    /// <include file='D3DPS20CAPS.xml' path='doc/member[@name="D3DPS20CAPS.D3DPS20CAPS_NODEPENDENTREADLIMIT"]/*' />
    [NativeTypeName("#define D3DPS20CAPS_NODEPENDENTREADLIMIT (1<<3)")]
    public const int D3DPS20CAPS_NODEPENDENTREADLIMIT = (1 << 3);

    /// <include file='D3DPS20CAPS.xml' path='doc/member[@name="D3DPS20CAPS.D3DPS20CAPS_NOTEXINSTRUCTIONLIMIT"]/*' />
    [NativeTypeName("#define D3DPS20CAPS_NOTEXINSTRUCTIONLIMIT (1<<4)")]
    public const int D3DPS20CAPS_NOTEXINSTRUCTIONLIMIT = (1 << 4);
}
