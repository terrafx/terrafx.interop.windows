// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TransportStatus.xml' path='doc/member[@name="TransportStatus"]/*' />
public enum TransportStatus
{
    /// <include file='TransportStatus.xml' path='doc/member[@name="TransportStatus.TransportStatus_Unknown"]/*' />
    TransportStatus_Unknown = 0,

    /// <include file='TransportStatus.xml' path='doc/member[@name="TransportStatus.TransportStatus_Ok"]/*' />
    TransportStatus_Ok = 1,

    /// <include file='TransportStatus.xml' path='doc/member[@name="TransportStatus.TransportStatus_ErrorOccurred"]/*' />
    TransportStatus_ErrorOccurred = 2,

    /// <include file='TransportStatus.xml' path='doc/member[@name="TransportStatus.TransportStatus_Last"]/*' />
    TransportStatus_Last = 3,
}
