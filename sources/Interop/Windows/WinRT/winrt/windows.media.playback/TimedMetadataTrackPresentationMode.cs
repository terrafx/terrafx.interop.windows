// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.playback.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TimedMetadataTrackPresentationMode.xml' path='doc/member[@name="TimedMetadataTrackPresentationMode"]/*' />
public enum TimedMetadataTrackPresentationMode
{
    /// <include file='TimedMetadataTrackPresentationMode.xml' path='doc/member[@name="TimedMetadataTrackPresentationMode.TimedMetadataTrackPresentationMode_Disabled"]/*' />
    TimedMetadataTrackPresentationMode_Disabled = 0,

    /// <include file='TimedMetadataTrackPresentationMode.xml' path='doc/member[@name="TimedMetadataTrackPresentationMode.TimedMetadataTrackPresentationMode_Hidden"]/*' />
    TimedMetadataTrackPresentationMode_Hidden = 1,

    /// <include file='TimedMetadataTrackPresentationMode.xml' path='doc/member[@name="TimedMetadataTrackPresentationMode.TimedMetadataTrackPresentationMode_ApplicationPresented"]/*' />
    TimedMetadataTrackPresentationMode_ApplicationPresented = 2,

    /// <include file='TimedMetadataTrackPresentationMode.xml' path='doc/member[@name="TimedMetadataTrackPresentationMode.TimedMetadataTrackPresentationMode_PlatformPresented"]/*' />
    TimedMetadataTrackPresentationMode_PlatformPresented = 3,
}
