// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreMemoryUsage.xml' path='doc/member[@name="DXCoreMemoryUsage"]/*' />
public partial struct DXCoreMemoryUsage
{
    /// <include file='DXCoreMemoryUsage.xml' path='doc/member[@name="DXCoreMemoryUsage.committed"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong committed;

    /// <include file='DXCoreMemoryUsage.xml' path='doc/member[@name="DXCoreMemoryUsage.resident"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong resident;
}
