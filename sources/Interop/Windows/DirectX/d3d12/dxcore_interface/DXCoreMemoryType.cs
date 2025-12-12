// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreMemoryType.xml' path='doc/member[@name="DXCoreMemoryType"]/*' />
[NativeTypeName("uint32_t")]
public enum DXCoreMemoryType : uint
{
    /// <include file='DXCoreMemoryType.xml' path='doc/member[@name="DXCoreMemoryType.Dedicated"]/*' />
    Dedicated = 0,

    /// <include file='DXCoreMemoryType.xml' path='doc/member[@name="DXCoreMemoryType.Shared"]/*' />
    Shared = 1,
}
