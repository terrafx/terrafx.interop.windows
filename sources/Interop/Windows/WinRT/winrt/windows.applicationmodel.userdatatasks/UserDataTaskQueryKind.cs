// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserDataTaskQueryKind.xml' path='doc/member[@name="UserDataTaskQueryKind"]/*' />
public enum UserDataTaskQueryKind
{
    /// <include file='UserDataTaskQueryKind.xml' path='doc/member[@name="UserDataTaskQueryKind.UserDataTaskQueryKind_All"]/*' />
    UserDataTaskQueryKind_All = 0,

    /// <include file='UserDataTaskQueryKind.xml' path='doc/member[@name="UserDataTaskQueryKind.UserDataTaskQueryKind_Incomplete"]/*' />
    UserDataTaskQueryKind_Incomplete = 1,

    /// <include file='UserDataTaskQueryKind.xml' path='doc/member[@name="UserDataTaskQueryKind.UserDataTaskQueryKind_Complete"]/*' />
    UserDataTaskQueryKind_Complete = 2,
}
