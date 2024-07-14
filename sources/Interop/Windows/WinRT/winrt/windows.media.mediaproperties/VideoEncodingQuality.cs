// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VideoEncodingQuality.xml' path='doc/member[@name="VideoEncodingQuality"]/*' />
public enum VideoEncodingQuality
{
    /// <include file='VideoEncodingQuality.xml' path='doc/member[@name="VideoEncodingQuality.VideoEncodingQuality_Auto"]/*' />
    VideoEncodingQuality_Auto = 0,

    /// <include file='VideoEncodingQuality.xml' path='doc/member[@name="VideoEncodingQuality.VideoEncodingQuality_HD1080p"]/*' />
    VideoEncodingQuality_HD1080p = 1,

    /// <include file='VideoEncodingQuality.xml' path='doc/member[@name="VideoEncodingQuality.VideoEncodingQuality_HD720p"]/*' />
    VideoEncodingQuality_HD720p = 2,

    /// <include file='VideoEncodingQuality.xml' path='doc/member[@name="VideoEncodingQuality.VideoEncodingQuality_Wvga"]/*' />
    VideoEncodingQuality_Wvga = 3,

    /// <include file='VideoEncodingQuality.xml' path='doc/member[@name="VideoEncodingQuality.VideoEncodingQuality_Ntsc"]/*' />
    VideoEncodingQuality_Ntsc = 4,

    /// <include file='VideoEncodingQuality.xml' path='doc/member[@name="VideoEncodingQuality.VideoEncodingQuality_Pal"]/*' />
    VideoEncodingQuality_Pal = 5,

    /// <include file='VideoEncodingQuality.xml' path='doc/member[@name="VideoEncodingQuality.VideoEncodingQuality_Vga"]/*' />
    VideoEncodingQuality_Vga = 6,

    /// <include file='VideoEncodingQuality.xml' path='doc/member[@name="VideoEncodingQuality.VideoEncodingQuality_Qvga"]/*' />
    VideoEncodingQuality_Qvga = 7,

    /// <include file='VideoEncodingQuality.xml' path='doc/member[@name="VideoEncodingQuality.VideoEncodingQuality_Uhd2160p"]/*' />
    VideoEncodingQuality_Uhd2160p = 8,

    /// <include file='VideoEncodingQuality.xml' path='doc/member[@name="VideoEncodingQuality.VideoEncodingQuality_Uhd4320p"]/*' />
    VideoEncodingQuality_Uhd4320p = 9,
}
