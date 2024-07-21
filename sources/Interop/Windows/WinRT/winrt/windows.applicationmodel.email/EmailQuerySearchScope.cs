// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='EmailQuerySearchScope.xml' path='doc/member[@name="EmailQuerySearchScope"]/*' />
public enum EmailQuerySearchScope
{
    /// <include file='EmailQuerySearchScope.xml' path='doc/member[@name="EmailQuerySearchScope.EmailQuerySearchScope_Local"]/*' />
    EmailQuerySearchScope_Local = 0,

    /// <include file='EmailQuerySearchScope.xml' path='doc/member[@name="EmailQuerySearchScope.EmailQuerySearchScope_Server"]/*' />
    EmailQuerySearchScope_Server = 1,
}
