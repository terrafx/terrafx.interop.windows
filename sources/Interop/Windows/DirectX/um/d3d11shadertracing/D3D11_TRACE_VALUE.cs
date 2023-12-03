// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_TRACE_VALUE.xml' path='doc/member[@name="D3D11_TRACE_VALUE"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct D3D11_TRACE_VALUE
{
    /// <include file='D3D11_TRACE_VALUE.xml' path='doc/member[@name="D3D11_TRACE_VALUE.Bits"]/*' />
    [NativeTypeName("UINT[4]")]
    public _Bits_e__FixedBuffer Bits;

    /// <include file='D3D11_TRACE_VALUE.xml' path='doc/member[@name="D3D11_TRACE_VALUE.ValidMask"]/*' />
    [NativeTypeName("D3D11_TRACE_COMPONENT_MASK")]
    public byte ValidMask;

    /// <include file='_Bits_e__FixedBuffer.xml' path='doc/member[@name="_Bits_e__FixedBuffer"]/*' />
    [InlineArray(4)]
    public partial struct _Bits_e__FixedBuffer
    {
        public uint e0;
    }
}
