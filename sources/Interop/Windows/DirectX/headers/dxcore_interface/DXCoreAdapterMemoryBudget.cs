// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DXCoreAdapterMemoryBudget.xml' path='doc/member[@name="DXCoreAdapterMemoryBudget"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct DXCoreAdapterMemoryBudget
{
    /// <include file='DXCoreAdapterMemoryBudget.xml' path='doc/member[@name="DXCoreAdapterMemoryBudget.budget"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong budget;

    /// <include file='DXCoreAdapterMemoryBudget.xml' path='doc/member[@name="DXCoreAdapterMemoryBudget.currentUsage"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong currentUsage;

    /// <include file='DXCoreAdapterMemoryBudget.xml' path='doc/member[@name="DXCoreAdapterMemoryBudget.availableForReservation"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong availableForReservation;

    /// <include file='DXCoreAdapterMemoryBudget.xml' path='doc/member[@name="DXCoreAdapterMemoryBudget.currentReservation"]/*' />
    [NativeTypeName("uint64_t")]
    public ulong currentReservation;
}
