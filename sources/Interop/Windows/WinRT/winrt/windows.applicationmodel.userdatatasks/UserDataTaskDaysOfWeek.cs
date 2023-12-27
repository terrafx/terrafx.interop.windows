// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserDataTaskDaysOfWeek.xml' path='doc/member[@name="UserDataTaskDaysOfWeek"]/*' />
[NativeTypeName("unsigned int")]
public enum UserDataTaskDaysOfWeek : uint
{
    /// <include file='UserDataTaskDaysOfWeek.xml' path='doc/member[@name="UserDataTaskDaysOfWeek.UserDataTaskDaysOfWeek_None"]/*' />
    UserDataTaskDaysOfWeek_None = 0,

    /// <include file='UserDataTaskDaysOfWeek.xml' path='doc/member[@name="UserDataTaskDaysOfWeek.UserDataTaskDaysOfWeek_Sunday"]/*' />
    UserDataTaskDaysOfWeek_Sunday = 0x1,

    /// <include file='UserDataTaskDaysOfWeek.xml' path='doc/member[@name="UserDataTaskDaysOfWeek.UserDataTaskDaysOfWeek_Monday"]/*' />
    UserDataTaskDaysOfWeek_Monday = 0x2,

    /// <include file='UserDataTaskDaysOfWeek.xml' path='doc/member[@name="UserDataTaskDaysOfWeek.UserDataTaskDaysOfWeek_Tuesday"]/*' />
    UserDataTaskDaysOfWeek_Tuesday = 0x4,

    /// <include file='UserDataTaskDaysOfWeek.xml' path='doc/member[@name="UserDataTaskDaysOfWeek.UserDataTaskDaysOfWeek_Wednesday"]/*' />
    UserDataTaskDaysOfWeek_Wednesday = 0x8,

    /// <include file='UserDataTaskDaysOfWeek.xml' path='doc/member[@name="UserDataTaskDaysOfWeek.UserDataTaskDaysOfWeek_Thursday"]/*' />
    UserDataTaskDaysOfWeek_Thursday = 0x10,

    /// <include file='UserDataTaskDaysOfWeek.xml' path='doc/member[@name="UserDataTaskDaysOfWeek.UserDataTaskDaysOfWeek_Friday"]/*' />
    UserDataTaskDaysOfWeek_Friday = 0x20,

    /// <include file='UserDataTaskDaysOfWeek.xml' path='doc/member[@name="UserDataTaskDaysOfWeek.UserDataTaskDaysOfWeek_Saturday"]/*' />
    UserDataTaskDaysOfWeek_Saturday = 0x40,
}
