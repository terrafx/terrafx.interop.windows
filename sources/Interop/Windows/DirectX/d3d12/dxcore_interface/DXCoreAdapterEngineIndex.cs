// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreAdapterEngineIndex.xml' path='doc/member[@name="DXCoreAdapterEngineIndex"]/*' />
public partial struct DXCoreAdapterEngineIndex
{
    /// <include file='DXCoreAdapterEngineIndex.xml' path='doc/member[@name="DXCoreAdapterEngineIndex.physicalAdapterIndex"]/*' />
    [NativeTypeName("uint32_t")]
    public uint physicalAdapterIndex;

    /// <include file='DXCoreAdapterEngineIndex.xml' path='doc/member[@name="DXCoreAdapterEngineIndex.engineIndex"]/*' />
    [NativeTypeName("uint32_t")]
    public uint engineIndex;
}
