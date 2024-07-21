// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINHTTP_FAST_FORWARDING_STATE.xml' path='doc/member[@name="WINHTTP_FAST_FORWARDING_STATE"]/*' />
public enum WINHTTP_FAST_FORWARDING_STATE
{
    /// <include file='WINHTTP_FAST_FORWARDING_STATE.xml' path='doc/member[@name="WINHTTP_FAST_FORWARDING_STATE.WinHttpFastForwardingStateInProgress"]/*' />
    WinHttpFastForwardingStateInProgress = 0,

    /// <include file='WINHTTP_FAST_FORWARDING_STATE.xml' path='doc/member[@name="WINHTTP_FAST_FORWARDING_STATE.WinHttpFastForwardingStateSucceeded"]/*' />
    WinHttpFastForwardingStateSucceeded = 1,

    /// <include file='WINHTTP_FAST_FORWARDING_STATE.xml' path='doc/member[@name="WINHTTP_FAST_FORWARDING_STATE.WinHttpFastForwardingStateClientSideFailed"]/*' />
    WinHttpFastForwardingStateClientSideFailed = 2,

    /// <include file='WINHTTP_FAST_FORWARDING_STATE.xml' path='doc/member[@name="WINHTTP_FAST_FORWARDING_STATE.WinHttpFastForwardingStateServerSideFailed"]/*' />
    WinHttpFastForwardingStateServerSideFailed = 3,
}
