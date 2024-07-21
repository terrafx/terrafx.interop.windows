// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserType.xml' path='doc/member[@name="UserType"]/*' />
public enum UserType
{
    /// <include file='UserType.xml' path='doc/member[@name="UserType.UserType_LocalUser"]/*' />
    UserType_LocalUser = 0,

    /// <include file='UserType.xml' path='doc/member[@name="UserType.UserType_RemoteUser"]/*' />
    UserType_RemoteUser = 1,

    /// <include file='UserType.xml' path='doc/member[@name="UserType.UserType_LocalGuest"]/*' />
    UserType_LocalGuest = 2,

    /// <include file='UserType.xml' path='doc/member[@name="UserType.UserType_RemoteGuest"]/*' />
    UserType_RemoteGuest = 3,

    /// <include file='UserType.xml' path='doc/member[@name="UserType.UserType_SystemManaged"]/*' />
    UserType_SystemManaged = 4,
}
