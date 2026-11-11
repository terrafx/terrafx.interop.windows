// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DISSUE
{
    /// <include file='D3DISSUE.xml' path='doc/member[@name="D3DISSUE.D3DISSUE_END"]/*' />
    [NativeTypeName("#define D3DISSUE_END (1 << 0)")]
    public const int D3DISSUE_END = (1 << 0);

    /// <include file='D3DISSUE.xml' path='doc/member[@name="D3DISSUE.D3DISSUE_BEGIN"]/*' />
    [NativeTypeName("#define D3DISSUE_BEGIN (1 << 1)")]
    public const int D3DISSUE_BEGIN = (1 << 1);
}
