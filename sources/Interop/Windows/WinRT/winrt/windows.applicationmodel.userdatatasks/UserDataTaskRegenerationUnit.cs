// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserDataTaskRegenerationUnit.xml' path='doc/member[@name="UserDataTaskRegenerationUnit"]/*' />
public enum UserDataTaskRegenerationUnit
{
    /// <include file='UserDataTaskRegenerationUnit.xml' path='doc/member[@name="UserDataTaskRegenerationUnit.UserDataTaskRegenerationUnit_Daily"]/*' />
    UserDataTaskRegenerationUnit_Daily = 0,

    /// <include file='UserDataTaskRegenerationUnit.xml' path='doc/member[@name="UserDataTaskRegenerationUnit.UserDataTaskRegenerationUnit_Weekly"]/*' />
    UserDataTaskRegenerationUnit_Weekly = 1,

    /// <include file='UserDataTaskRegenerationUnit.xml' path='doc/member[@name="UserDataTaskRegenerationUnit.UserDataTaskRegenerationUnit_Monthly"]/*' />
    UserDataTaskRegenerationUnit_Monthly = 2,

    /// <include file='UserDataTaskRegenerationUnit.xml' path='doc/member[@name="UserDataTaskRegenerationUnit.UserDataTaskRegenerationUnit_Yearly"]/*' />
    UserDataTaskRegenerationUnit_Yearly = 4,
}
