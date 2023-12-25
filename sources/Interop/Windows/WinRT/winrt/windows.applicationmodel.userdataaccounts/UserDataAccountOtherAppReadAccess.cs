// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdataaccounts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserDataAccountOtherAppReadAccess.xml' path='doc/member[@name="UserDataAccountOtherAppReadAccess"]/*' />
public enum UserDataAccountOtherAppReadAccess
{
    /// <include file='UserDataAccountOtherAppReadAccess.xml' path='doc/member[@name="UserDataAccountOtherAppReadAccess.UserDataAccountOtherAppReadAccess_SystemOnly"]/*' />
    UserDataAccountOtherAppReadAccess_SystemOnly = 0,

    /// <include file='UserDataAccountOtherAppReadAccess.xml' path='doc/member[@name="UserDataAccountOtherAppReadAccess.UserDataAccountOtherAppReadAccess_Full"]/*' />
    UserDataAccountOtherAppReadAccess_Full = 1,

    /// <include file='UserDataAccountOtherAppReadAccess.xml' path='doc/member[@name="UserDataAccountOtherAppReadAccess.UserDataAccountOtherAppReadAccess_None"]/*' />
    UserDataAccountOtherAppReadAccess_None = 2,
}
