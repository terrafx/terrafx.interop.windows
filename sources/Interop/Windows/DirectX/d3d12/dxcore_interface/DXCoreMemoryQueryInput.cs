// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreMemoryQueryInput.xml' path='doc/member[@name="DXCoreMemoryQueryInput"]/*' />
public partial struct DXCoreMemoryQueryInput
{
    /// <include file='DXCoreMemoryQueryInput.xml' path='doc/member[@name="DXCoreMemoryQueryInput.physicalAdapterIndex"]/*' />
    [NativeTypeName("uint32_t")]
    public uint physicalAdapterIndex;

    /// <include file='DXCoreMemoryQueryInput.xml' path='doc/member[@name="DXCoreMemoryQueryInput.memoryType"]/*' />
    public DXCoreMemoryType memoryType;
}
