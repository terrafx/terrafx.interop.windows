// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreAdapterProcessSetQueryInput.xml' path='doc/member[@name="DXCoreAdapterProcessSetQueryInput"]/*' />
public unsafe partial struct DXCoreAdapterProcessSetQueryInput
{
    /// <include file='DXCoreAdapterProcessSetQueryInput.xml' path='doc/member[@name="DXCoreAdapterProcessSetQueryInput.arraySize"]/*' />
    [NativeTypeName("uint32_t")]
    public uint arraySize;

    /// <include file='DXCoreAdapterProcessSetQueryInput.xml' path='doc/member[@name="DXCoreAdapterProcessSetQueryInput.processIds"]/*' />
    [NativeTypeName("uint32_t *")]
    public uint* processIds;
}
