// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='DataUsageGranularity.xml' path='doc/member[@name="DataUsageGranularity"]/*' />
public enum DataUsageGranularity
{
    /// <include file='DataUsageGranularity.xml' path='doc/member[@name="DataUsageGranularity.DataUsageGranularity_PerMinute"]/*' />
    DataUsageGranularity_PerMinute = 0,

    /// <include file='DataUsageGranularity.xml' path='doc/member[@name="DataUsageGranularity.DataUsageGranularity_PerHour"]/*' />
    DataUsageGranularity_PerHour = 1,

    /// <include file='DataUsageGranularity.xml' path='doc/member[@name="DataUsageGranularity.DataUsageGranularity_PerDay"]/*' />
    DataUsageGranularity_PerDay = 2,

    /// <include file='DataUsageGranularity.xml' path='doc/member[@name="DataUsageGranularity.DataUsageGranularity_Total"]/*' />
    DataUsageGranularity_Total = 3,
}
