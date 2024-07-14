// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneCallDirection.xml' path='doc/member[@name="PhoneCallDirection"]/*' />
public enum PhoneCallDirection
{
    /// <include file='PhoneCallDirection.xml' path='doc/member[@name="PhoneCallDirection.PhoneCallDirection_Unknown"]/*' />
    PhoneCallDirection_Unknown = 0,

    /// <include file='PhoneCallDirection.xml' path='doc/member[@name="PhoneCallDirection.PhoneCallDirection_Incoming"]/*' />
    PhoneCallDirection_Incoming = 1,

    /// <include file='PhoneCallDirection.xml' path='doc/member[@name="PhoneCallDirection.PhoneCallDirection_Outgoing"]/*' />
    PhoneCallDirection_Outgoing = 2,
}
