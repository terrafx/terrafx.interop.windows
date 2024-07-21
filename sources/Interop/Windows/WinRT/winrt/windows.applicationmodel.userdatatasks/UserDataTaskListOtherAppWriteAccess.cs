// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserDataTaskListOtherAppWriteAccess.xml' path='doc/member[@name="UserDataTaskListOtherAppWriteAccess"]/*' />
public enum UserDataTaskListOtherAppWriteAccess
{
    /// <include file='UserDataTaskListOtherAppWriteAccess.xml' path='doc/member[@name="UserDataTaskListOtherAppWriteAccess.UserDataTaskListOtherAppWriteAccess_Limited"]/*' />
    UserDataTaskListOtherAppWriteAccess_Limited = 0,

    /// <include file='UserDataTaskListOtherAppWriteAccess.xml' path='doc/member[@name="UserDataTaskListOtherAppWriteAccess.UserDataTaskListOtherAppWriteAccess_None"]/*' />
    UserDataTaskListOtherAppWriteAccess_None = 1,
}
