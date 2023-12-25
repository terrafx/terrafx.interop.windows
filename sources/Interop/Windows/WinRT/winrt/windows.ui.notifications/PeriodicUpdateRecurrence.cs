// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.notifications.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PeriodicUpdateRecurrence.xml' path='doc/member[@name="PeriodicUpdateRecurrence"]/*' />
public enum PeriodicUpdateRecurrence
{
    /// <include file='PeriodicUpdateRecurrence.xml' path='doc/member[@name="PeriodicUpdateRecurrence.PeriodicUpdateRecurrence_HalfHour"]/*' />
    PeriodicUpdateRecurrence_HalfHour = 0,

    /// <include file='PeriodicUpdateRecurrence.xml' path='doc/member[@name="PeriodicUpdateRecurrence.PeriodicUpdateRecurrence_Hour"]/*' />
    PeriodicUpdateRecurrence_Hour = 1,

    /// <include file='PeriodicUpdateRecurrence.xml' path='doc/member[@name="PeriodicUpdateRecurrence.PeriodicUpdateRecurrence_SixHours"]/*' />
    PeriodicUpdateRecurrence_SixHours = 2,

    /// <include file='PeriodicUpdateRecurrence.xml' path='doc/member[@name="PeriodicUpdateRecurrence.PeriodicUpdateRecurrence_TwelveHours"]/*' />
    PeriodicUpdateRecurrence_TwelveHours = 3,

    /// <include file='PeriodicUpdateRecurrence.xml' path='doc/member[@name="PeriodicUpdateRecurrence.PeriodicUpdateRecurrence_Daily"]/*' />
    PeriodicUpdateRecurrence_Daily = 4,
}
