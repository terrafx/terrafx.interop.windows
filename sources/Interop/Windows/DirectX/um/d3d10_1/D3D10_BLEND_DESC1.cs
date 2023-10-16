// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_BLEND_DESC1.xml' path='doc/member[@name="D3D10_BLEND_DESC1"]/*' />
public partial struct D3D10_BLEND_DESC1
{
    /// <include file='D3D10_BLEND_DESC1.xml' path='doc/member[@name="D3D10_BLEND_DESC1.AlphaToCoverageEnable"]/*' />
    public BOOL AlphaToCoverageEnable;

    /// <include file='D3D10_BLEND_DESC1.xml' path='doc/member[@name="D3D10_BLEND_DESC1.IndependentBlendEnable"]/*' />
    public BOOL IndependentBlendEnable;

    /// <include file='D3D10_BLEND_DESC1.xml' path='doc/member[@name="D3D10_BLEND_DESC1.RenderTarget"]/*' />
    [NativeTypeName("D3D10_RENDER_TARGET_BLEND_DESC1[8]")]
    public _RenderTarget_e__FixedBuffer RenderTarget;

    /// <include file='_RenderTarget_e__FixedBuffer.xml' path='doc/member[@name="_RenderTarget_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    public partial struct _RenderTarget_e__FixedBuffer
    {
        public D3D10_RENDER_TARGET_BLEND_DESC1 e0;
    }
}
