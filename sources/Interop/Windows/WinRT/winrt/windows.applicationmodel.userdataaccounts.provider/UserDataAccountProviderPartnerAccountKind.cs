// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.userdataaccounts.provider.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='UserDataAccountProviderPartnerAccountKind.xml' path='doc/member[@name="UserDataAccountProviderPartnerAccountKind"]/*' />
public enum UserDataAccountProviderPartnerAccountKind
{
    /// <include file='UserDataAccountProviderPartnerAccountKind.xml' path='doc/member[@name="UserDataAccountProviderPartnerAccountKind.UserDataAccountProviderPartnerAccountKind_Exchange"]/*' />
    UserDataAccountProviderPartnerAccountKind_Exchange = 0,

    /// <include file='UserDataAccountProviderPartnerAccountKind.xml' path='doc/member[@name="UserDataAccountProviderPartnerAccountKind.UserDataAccountProviderPartnerAccountKind_PopOrImap"]/*' />
    UserDataAccountProviderPartnerAccountKind_PopOrImap = 1,
}
