// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.618.5
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreHardwareTypeFilterFlags.xml' path='doc/member[@name="DXCoreHardwareTypeFilterFlags"]/*' />
[NativeTypeName("uint32_t")]
public enum DXCoreHardwareTypeFilterFlags : uint
{
    /// <include file='DXCoreHardwareTypeFilterFlags.xml' path='doc/member[@name="DXCoreHardwareTypeFilterFlags.None"]/*' />
    None = 0x0,

    /// <include file='DXCoreHardwareTypeFilterFlags.xml' path='doc/member[@name="DXCoreHardwareTypeFilterFlags.GPU"]/*' />
    GPU = 0x1,

    /// <include file='DXCoreHardwareTypeFilterFlags.xml' path='doc/member[@name="DXCoreHardwareTypeFilterFlags.ComputeAccelerator"]/*' />
    ComputeAccelerator = 0x2,

    /// <include file='DXCoreHardwareTypeFilterFlags.xml' path='doc/member[@name="DXCoreHardwareTypeFilterFlags.NPU"]/*' />
    NPU = 0x4,

    /// <include file='DXCoreHardwareTypeFilterFlags.xml' path='doc/member[@name="DXCoreHardwareTypeFilterFlags.MediaAccelerator"]/*' />
    MediaAccelerator = 0x8,
}
