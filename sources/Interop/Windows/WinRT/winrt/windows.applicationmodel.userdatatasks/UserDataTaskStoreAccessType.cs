// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserDataTaskStoreAccessType.xml' path='doc/member[@name="UserDataTaskStoreAccessType"]/*' />
public enum UserDataTaskStoreAccessType
{
    /// <include file='UserDataTaskStoreAccessType.xml' path='doc/member[@name="UserDataTaskStoreAccessType.UserDataTaskStoreAccessType_AppTasksReadWrite"]/*' />
    UserDataTaskStoreAccessType_AppTasksReadWrite = 0,

    /// <include file='UserDataTaskStoreAccessType.xml' path='doc/member[@name="UserDataTaskStoreAccessType.UserDataTaskStoreAccessType_AllTasksLimitedReadWrite"]/*' />
    UserDataTaskStoreAccessType_AllTasksLimitedReadWrite = 1,
}
