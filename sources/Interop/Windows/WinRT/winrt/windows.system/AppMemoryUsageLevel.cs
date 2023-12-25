// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppMemoryUsageLevel.xml' path='doc/member[@name="AppMemoryUsageLevel"]/*' />
public enum AppMemoryUsageLevel
{
    /// <include file='AppMemoryUsageLevel.xml' path='doc/member[@name="AppMemoryUsageLevel.AppMemoryUsageLevel_Low"]/*' />
    AppMemoryUsageLevel_Low = 0,

    /// <include file='AppMemoryUsageLevel.xml' path='doc/member[@name="AppMemoryUsageLevel.AppMemoryUsageLevel_Medium"]/*' />
    AppMemoryUsageLevel_Medium = 1,

    /// <include file='AppMemoryUsageLevel.xml' path='doc/member[@name="AppMemoryUsageLevel.AppMemoryUsageLevel_High"]/*' />
    AppMemoryUsageLevel_High = 2,

    /// <include file='AppMemoryUsageLevel.xml' path='doc/member[@name="AppMemoryUsageLevel.AppMemoryUsageLevel_OverLimit"]/*' />
    AppMemoryUsageLevel_OverLimit = 3,
}
