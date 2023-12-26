// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaStreamSourceClosedReason.xml' path='doc/member[@name="MediaStreamSourceClosedReason"]/*' />
public enum MediaStreamSourceClosedReason
{
    /// <include file='MediaStreamSourceClosedReason.xml' path='doc/member[@name="MediaStreamSourceClosedReason.MediaStreamSourceClosedReason_Done"]/*' />
    MediaStreamSourceClosedReason_Done = 0,

    /// <include file='MediaStreamSourceClosedReason.xml' path='doc/member[@name="MediaStreamSourceClosedReason.MediaStreamSourceClosedReason_UnknownError"]/*' />
    MediaStreamSourceClosedReason_UnknownError = 1,

    /// <include file='MediaStreamSourceClosedReason.xml' path='doc/member[@name="MediaStreamSourceClosedReason.MediaStreamSourceClosedReason_AppReportedError"]/*' />
    MediaStreamSourceClosedReason_AppReportedError = 2,

    /// <include file='MediaStreamSourceClosedReason.xml' path='doc/member[@name="MediaStreamSourceClosedReason.MediaStreamSourceClosedReason_UnsupportedProtectionSystem"]/*' />
    MediaStreamSourceClosedReason_UnsupportedProtectionSystem = 3,

    /// <include file='MediaStreamSourceClosedReason.xml' path='doc/member[@name="MediaStreamSourceClosedReason.MediaStreamSourceClosedReason_ProtectionSystemFailure"]/*' />
    MediaStreamSourceClosedReason_ProtectionSystemFailure = 4,

    /// <include file='MediaStreamSourceClosedReason.xml' path='doc/member[@name="MediaStreamSourceClosedReason.MediaStreamSourceClosedReason_UnsupportedEncodingFormat"]/*' />
    MediaStreamSourceClosedReason_UnsupportedEncodingFormat = 5,

    /// <include file='MediaStreamSourceClosedReason.xml' path='doc/member[@name="MediaStreamSourceClosedReason.MediaStreamSourceClosedReason_MissingSampleRequestedEventHandler"]/*' />
    MediaStreamSourceClosedReason_MissingSampleRequestedEventHandler = 6,
}
