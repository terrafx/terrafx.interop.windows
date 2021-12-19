// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreAdapterState.xml' path='doc/member[@name="DXCoreAdapterState"]/*' />
[NativeTypeName("uint32_t")]
[SupportedOSPlatform("windows10.0.19041.0")]
public enum DXCoreAdapterState : uint
{
    /// <include file='DXCoreAdapterState.xml' path='doc/member[@name="DXCoreAdapterState.IsDriverUpdateInProgress"]/*' />
    IsDriverUpdateInProgress = 0,

    /// <include file='DXCoreAdapterState.xml' path='doc/member[@name="DXCoreAdapterState.AdapterMemoryBudget"]/*' />
    AdapterMemoryBudget = 1,
}
