// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdataaccounts.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserDataAccountStoreAccessType.xml' path='doc/member[@name="UserDataAccountStoreAccessType"]/*' />
public enum UserDataAccountStoreAccessType
{
    /// <include file='UserDataAccountStoreAccessType.xml' path='doc/member[@name="UserDataAccountStoreAccessType.UserDataAccountStoreAccessType_AllAccountsReadOnly"]/*' />
    UserDataAccountStoreAccessType_AllAccountsReadOnly = 0,

    /// <include file='UserDataAccountStoreAccessType.xml' path='doc/member[@name="UserDataAccountStoreAccessType.UserDataAccountStoreAccessType_AppAccountsReadWrite"]/*' />
    UserDataAccountStoreAccessType_AppAccountsReadWrite = 1,
}
