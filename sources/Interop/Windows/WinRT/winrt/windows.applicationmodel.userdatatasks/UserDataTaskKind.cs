// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserDataTaskKind.xml' path='doc/member[@name="UserDataTaskKind"]/*' />
public enum UserDataTaskKind
{
    /// <include file='UserDataTaskKind.xml' path='doc/member[@name="UserDataTaskKind.UserDataTaskKind_Single"]/*' />
    UserDataTaskKind_Single = 0,

    /// <include file='UserDataTaskKind.xml' path='doc/member[@name="UserDataTaskKind.UserDataTaskKind_Recurring"]/*' />
    UserDataTaskKind_Recurring = 1,

    /// <include file='UserDataTaskKind.xml' path='doc/member[@name="UserDataTaskKind.UserDataTaskKind_Regenerating"]/*' />
    UserDataTaskKind_Regenerating = 2,
}
