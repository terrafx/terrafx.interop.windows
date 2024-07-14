// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdataaccounts.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserDataAccountProviderOperationKind.xml' path='doc/member[@name="UserDataAccountProviderOperationKind"]/*' />
public enum UserDataAccountProviderOperationKind
{
    /// <include file='UserDataAccountProviderOperationKind.xml' path='doc/member[@name="UserDataAccountProviderOperationKind.UserDataAccountProviderOperationKind_AddAccount"]/*' />
    UserDataAccountProviderOperationKind_AddAccount = 0,

    /// <include file='UserDataAccountProviderOperationKind.xml' path='doc/member[@name="UserDataAccountProviderOperationKind.UserDataAccountProviderOperationKind_Settings"]/*' />
    UserDataAccountProviderOperationKind_Settings = 1,

    /// <include file='UserDataAccountProviderOperationKind.xml' path='doc/member[@name="UserDataAccountProviderOperationKind.UserDataAccountProviderOperationKind_ResolveErrors"]/*' />
    UserDataAccountProviderOperationKind_ResolveErrors = 2,
}
