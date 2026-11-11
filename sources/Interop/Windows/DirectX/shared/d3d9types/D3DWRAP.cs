// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

public static partial class D3DWRAP
{
    /// <include file='D3DWRAP.xml' path='doc/member[@name="D3DWRAP.D3DWRAP_U"]/*' />
    [NativeTypeName("#define D3DWRAP_U 0x00000001L")]
    public const int D3DWRAP_U = 0x00000001;

    /// <include file='D3DWRAP.xml' path='doc/member[@name="D3DWRAP.D3DWRAP_V"]/*' />
    [NativeTypeName("#define D3DWRAP_V 0x00000002L")]
    public const int D3DWRAP_V = 0x00000002;

    /// <include file='D3DWRAP.xml' path='doc/member[@name="D3DWRAP.D3DWRAP_W"]/*' />
    [NativeTypeName("#define D3DWRAP_W 0x00000004L")]
    public const int D3DWRAP_W = 0x00000004;
}
