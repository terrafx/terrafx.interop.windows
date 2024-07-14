// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserDataTaskRecurrenceUnit.xml' path='doc/member[@name="UserDataTaskRecurrenceUnit"]/*' />
public enum UserDataTaskRecurrenceUnit
{
    /// <include file='UserDataTaskRecurrenceUnit.xml' path='doc/member[@name="UserDataTaskRecurrenceUnit.UserDataTaskRecurrenceUnit_Daily"]/*' />
    UserDataTaskRecurrenceUnit_Daily = 0,

    /// <include file='UserDataTaskRecurrenceUnit.xml' path='doc/member[@name="UserDataTaskRecurrenceUnit.UserDataTaskRecurrenceUnit_Weekly"]/*' />
    UserDataTaskRecurrenceUnit_Weekly = 1,

    /// <include file='UserDataTaskRecurrenceUnit.xml' path='doc/member[@name="UserDataTaskRecurrenceUnit.UserDataTaskRecurrenceUnit_Monthly"]/*' />
    UserDataTaskRecurrenceUnit_Monthly = 2,

    /// <include file='UserDataTaskRecurrenceUnit.xml' path='doc/member[@name="UserDataTaskRecurrenceUnit.UserDataTaskRecurrenceUnit_MonthlyOnDay"]/*' />
    UserDataTaskRecurrenceUnit_MonthlyOnDay = 3,

    /// <include file='UserDataTaskRecurrenceUnit.xml' path='doc/member[@name="UserDataTaskRecurrenceUnit.UserDataTaskRecurrenceUnit_Yearly"]/*' />
    UserDataTaskRecurrenceUnit_Yearly = 4,

    /// <include file='UserDataTaskRecurrenceUnit.xml' path='doc/member[@name="UserDataTaskRecurrenceUnit.UserDataTaskRecurrenceUnit_YearlyOnDay"]/*' />
    UserDataTaskRecurrenceUnit_YearlyOnDay = 5,
}
