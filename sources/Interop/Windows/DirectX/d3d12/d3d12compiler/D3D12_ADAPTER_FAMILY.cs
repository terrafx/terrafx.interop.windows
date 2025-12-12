// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12compiler.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_ADAPTER_FAMILY.xml' path='doc/member[@name="D3D12_ADAPTER_FAMILY"]/*' />
public partial struct D3D12_ADAPTER_FAMILY
{
    /// <include file='D3D12_ADAPTER_FAMILY.xml' path='doc/member[@name="D3D12_ADAPTER_FAMILY.szAdapterFamily"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _szAdapterFamily_e__FixedBuffer szAdapterFamily;

    /// <include file='_szAdapterFamily_e__FixedBuffer.xml' path='doc/member[@name="_szAdapterFamily_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _szAdapterFamily_e__FixedBuffer
    {
        public char e0;
    }
}
