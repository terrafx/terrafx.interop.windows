// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.editing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VideoFramePrecision.xml' path='doc/member[@name="VideoFramePrecision"]/*' />
public enum VideoFramePrecision
{
    /// <include file='VideoFramePrecision.xml' path='doc/member[@name="VideoFramePrecision.VideoFramePrecision_NearestFrame"]/*' />
    VideoFramePrecision_NearestFrame = 0,

    /// <include file='VideoFramePrecision.xml' path='doc/member[@name="VideoFramePrecision.VideoFramePrecision_NearestKeyFrame"]/*' />
    VideoFramePrecision_NearestKeyFrame = 1,
}
