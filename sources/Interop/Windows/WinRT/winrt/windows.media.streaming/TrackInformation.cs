// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='TrackInformation.xml' path='doc/member[@name="TrackInformation"]/*' />
public partial struct TrackInformation
{
    /// <include file='TrackInformation.xml' path='doc/member[@name="TrackInformation.Track"]/*' />
    [NativeTypeName("UINT32")]
    public uint Track;

    /// <include file='TrackInformation.xml' path='doc/member[@name="TrackInformation.TrackId"]/*' />
    [NativeTypeName("UINT32")]
    public uint TrackId;

    /// <include file='TrackInformation.xml' path='doc/member[@name="TrackInformation.TrackDuration"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::TimeSpan")]
    public TimeSpan TrackDuration;
}
