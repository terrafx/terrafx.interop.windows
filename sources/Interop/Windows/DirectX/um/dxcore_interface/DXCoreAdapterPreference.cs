// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreAdapterPreference.xml' path='doc/member[@name="DXCoreAdapterPreference"]/*' />
[NativeTypeName("uint32_t")]
[SupportedOSPlatform("windows10.0.19041.0")]
public enum DXCoreAdapterPreference : uint
{
    /// <include file='DXCoreAdapterPreference.xml' path='doc/member[@name="DXCoreAdapterPreference.Hardware"]/*' />
    Hardware = 0,

    /// <include file='DXCoreAdapterPreference.xml' path='doc/member[@name="DXCoreAdapterPreference.MinimumPower"]/*' />
    MinimumPower = 1,

    /// <include file='DXCoreAdapterPreference.xml' path='doc/member[@name="DXCoreAdapterPreference.HighPerformance"]/*' />
    HighPerformance = 2,
}
