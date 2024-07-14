// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TransportState.xml' path='doc/member[@name="TransportState"]/*' />
public enum TransportState
{
    /// <include file='TransportState.xml' path='doc/member[@name="TransportState.TransportState_Unknown"]/*' />
    TransportState_Unknown = 0,

    /// <include file='TransportState.xml' path='doc/member[@name="TransportState.TransportState_Stopped"]/*' />
    TransportState_Stopped = 1,

    /// <include file='TransportState.xml' path='doc/member[@name="TransportState.TransportState_Playing"]/*' />
    TransportState_Playing = 2,

    /// <include file='TransportState.xml' path='doc/member[@name="TransportState.TransportState_Transitioning"]/*' />
    TransportState_Transitioning = 3,

    /// <include file='TransportState.xml' path='doc/member[@name="TransportState.TransportState_Paused"]/*' />
    TransportState_Paused = 4,

    /// <include file='TransportState.xml' path='doc/member[@name="TransportState.TransportState_Recording"]/*' />
    TransportState_Recording = 5,

    /// <include file='TransportState.xml' path='doc/member[@name="TransportState.TransportState_NoMediaPresent"]/*' />
    TransportState_NoMediaPresent = 6,

    /// <include file='TransportState.xml' path='doc/member[@name="TransportState.TransportState_Last"]/*' />
    TransportState_Last = 7,
}
