// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreProcessMemoryQueryInput.xml' path='doc/member[@name="DXCoreProcessMemoryQueryInput"]/*' />
public partial struct DXCoreProcessMemoryQueryInput
{
    /// <include file='DXCoreProcessMemoryQueryInput.xml' path='doc/member[@name="DXCoreProcessMemoryQueryInput.physicalAdapterIndex"]/*' />
    [NativeTypeName("uint32_t")]
    public uint physicalAdapterIndex;

    /// <include file='DXCoreProcessMemoryQueryInput.xml' path='doc/member[@name="DXCoreProcessMemoryQueryInput.memoryType"]/*' />
    public DXCoreMemoryType memoryType;

    /// <include file='DXCoreProcessMemoryQueryInput.xml' path='doc/member[@name="DXCoreProcessMemoryQueryInput.processId"]/*' />
    [NativeTypeName("uint32_t")]
    public uint processId;
}
