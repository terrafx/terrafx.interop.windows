// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.calls.background.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='PhoneIncomingCallDismissedReason.xml' path='doc/member[@name="PhoneIncomingCallDismissedReason"]/*' />
[Obsolete("PhoneIncomingCallDismissedReason is deprecated and might not work for all platforms. For more info, see MSDN.")]
public enum PhoneIncomingCallDismissedReason
{
    /// <include file='PhoneIncomingCallDismissedReason.xml' path='doc/member[@name="PhoneIncomingCallDismissedReason.PhoneIncomingCallDismissedReason_Unknown"]/*' />
    PhoneIncomingCallDismissedReason_Unknown = 0,

    /// <include file='PhoneIncomingCallDismissedReason.xml' path='doc/member[@name="PhoneIncomingCallDismissedReason.PhoneIncomingCallDismissedReason_CallRejected"]/*' />
    PhoneIncomingCallDismissedReason_CallRejected = 1,

    /// <include file='PhoneIncomingCallDismissedReason.xml' path='doc/member[@name="PhoneIncomingCallDismissedReason.PhoneIncomingCallDismissedReason_TextReply"]/*' />
    PhoneIncomingCallDismissedReason_TextReply = 2,

    /// <include file='PhoneIncomingCallDismissedReason.xml' path='doc/member[@name="PhoneIncomingCallDismissedReason.PhoneIncomingCallDismissedReason_ConnectionLost"]/*' />
    PhoneIncomingCallDismissedReason_ConnectionLost = 3,
}
