// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dxcore_interface.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

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

    /// <include file='DXCoreAdapterState.xml' path='doc/member[@name="DXCoreAdapterState.AdapterMemoryUsageBytes"]/*' />
    AdapterMemoryUsageBytes = 2,

    /// <include file='DXCoreAdapterState.xml' path='doc/member[@name="DXCoreAdapterState.AdapterMemoryUsageByProcessBytes"]/*' />
    AdapterMemoryUsageByProcessBytes = 3,

    /// <include file='DXCoreAdapterState.xml' path='doc/member[@name="DXCoreAdapterState.AdapterEngineRunningTimeMicroseconds"]/*' />
    AdapterEngineRunningTimeMicroseconds = 4,

    /// <include file='DXCoreAdapterState.xml' path='doc/member[@name="DXCoreAdapterState.AdapterEngineRunningTimeByProcessMicroseconds"]/*' />
    AdapterEngineRunningTimeByProcessMicroseconds = 5,

    /// <include file='DXCoreAdapterState.xml' path='doc/member[@name="DXCoreAdapterState.AdapterTemperatureCelsius"]/*' />
    AdapterTemperatureCelsius = 6,

    /// <include file='DXCoreAdapterState.xml' path='doc/member[@name="DXCoreAdapterState.AdapterInUseProcessCount"]/*' />
    AdapterInUseProcessCount = 7,

    /// <include file='DXCoreAdapterState.xml' path='doc/member[@name="DXCoreAdapterState.AdapterInUseProcessSet"]/*' />
    AdapterInUseProcessSet = 8,

    /// <include file='DXCoreAdapterState.xml' path='doc/member[@name="DXCoreAdapterState.AdapterEngineFrequencyHertz"]/*' />
    AdapterEngineFrequencyHertz = 9,

    /// <include file='DXCoreAdapterState.xml' path='doc/member[@name="DXCoreAdapterState.AdapterMemoryFrequencyHertz"]/*' />
    AdapterMemoryFrequencyHertz = 10,
}
