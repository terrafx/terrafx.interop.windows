// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.directx.direct3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='Direct3DBindings.xml' path='doc/member[@name="Direct3DBindings"]/*' />
[NativeTypeName("unsigned int")]
public enum Direct3DBindings : uint
{
    /// <include file='Direct3DBindings.xml' path='doc/member[@name="Direct3DBindings.Direct3DBindings_VertexBuffer"]/*' />
    Direct3DBindings_VertexBuffer = 0x1,

    /// <include file='Direct3DBindings.xml' path='doc/member[@name="Direct3DBindings.Direct3DBindings_IndexBuffer"]/*' />
    Direct3DBindings_IndexBuffer = 0x2,

    /// <include file='Direct3DBindings.xml' path='doc/member[@name="Direct3DBindings.Direct3DBindings_ConstantBuffer"]/*' />
    Direct3DBindings_ConstantBuffer = 0x4,

    /// <include file='Direct3DBindings.xml' path='doc/member[@name="Direct3DBindings.Direct3DBindings_ShaderResource"]/*' />
    Direct3DBindings_ShaderResource = 0x8,

    /// <include file='Direct3DBindings.xml' path='doc/member[@name="Direct3DBindings.Direct3DBindings_StreamOutput"]/*' />
    Direct3DBindings_StreamOutput = 0x10,

    /// <include file='Direct3DBindings.xml' path='doc/member[@name="Direct3DBindings.Direct3DBindings_RenderTarget"]/*' />
    Direct3DBindings_RenderTarget = 0x20,

    /// <include file='Direct3DBindings.xml' path='doc/member[@name="Direct3DBindings.Direct3DBindings_DepthStencil"]/*' />
    Direct3DBindings_DepthStencil = 0x40,

    /// <include file='Direct3DBindings.xml' path='doc/member[@name="Direct3DBindings.Direct3DBindings_UnorderedAccess"]/*' />
    Direct3DBindings_UnorderedAccess = 0x80,

    /// <include file='Direct3DBindings.xml' path='doc/member[@name="Direct3DBindings.Direct3DBindings_Decoder"]/*' />
    Direct3DBindings_Decoder = 0x200,

    /// <include file='Direct3DBindings.xml' path='doc/member[@name="Direct3DBindings.Direct3DBindings_VideoEncoder"]/*' />
    Direct3DBindings_VideoEncoder = 0x400,
}
