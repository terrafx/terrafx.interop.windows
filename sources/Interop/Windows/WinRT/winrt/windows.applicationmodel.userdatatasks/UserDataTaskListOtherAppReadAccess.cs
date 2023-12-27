// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserDataTaskListOtherAppReadAccess.xml' path='doc/member[@name="UserDataTaskListOtherAppReadAccess"]/*' />
public enum UserDataTaskListOtherAppReadAccess
{
    /// <include file='UserDataTaskListOtherAppReadAccess.xml' path='doc/member[@name="UserDataTaskListOtherAppReadAccess.UserDataTaskListOtherAppReadAccess_Full"]/*' />
    UserDataTaskListOtherAppReadAccess_Full = 0,

    /// <include file='UserDataTaskListOtherAppReadAccess.xml' path='doc/member[@name="UserDataTaskListOtherAppReadAccess.UserDataTaskListOtherAppReadAccess_SystemOnly"]/*' />
    UserDataTaskListOtherAppReadAccess_SystemOnly = 1,

    /// <include file='UserDataTaskListOtherAppReadAccess.xml' path='doc/member[@name="UserDataTaskListOtherAppReadAccess.UserDataTaskListOtherAppReadAccess_None"]/*' />
    UserDataTaskListOtherAppReadAccess_None = 2,
}
