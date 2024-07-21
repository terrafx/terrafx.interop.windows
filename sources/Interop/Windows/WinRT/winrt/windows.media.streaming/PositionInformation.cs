// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.WinRT;

/// <include file='PositionInformation.xml' path='doc/member[@name="PositionInformation"]/*' />
public partial struct PositionInformation
{
    /// <include file='PositionInformation.xml' path='doc/member[@name="PositionInformation.trackInformation"]/*' />
    [NativeTypeName("ABI::Windows::Media::Streaming::TrackInformation")]
    public TrackInformation trackInformation;

    /// <include file='PositionInformation.xml' path='doc/member[@name="PositionInformation.relativeTime"]/*' />
    [NativeTypeName("ABI::Windows::Foundation::TimeSpan")]
    public TimeSpan relativeTime;
}
