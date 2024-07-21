// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='VideoRotation.xml' path='doc/member[@name="VideoRotation"]/*' />
public enum VideoRotation
{
    /// <include file='VideoRotation.xml' path='doc/member[@name="VideoRotation.VideoRotation_None"]/*' />
    VideoRotation_None = 0,

    /// <include file='VideoRotation.xml' path='doc/member[@name="VideoRotation.VideoRotation_Clockwise90Degrees"]/*' />
    VideoRotation_Clockwise90Degrees = 1,

    /// <include file='VideoRotation.xml' path='doc/member[@name="VideoRotation.VideoRotation_Clockwise180Degrees"]/*' />
    VideoRotation_Clockwise180Degrees = 2,

    /// <include file='VideoRotation.xml' path='doc/member[@name="VideoRotation.VideoRotation_Clockwise270Degrees"]/*' />
    VideoRotation_Clockwise270Degrees = 3,
}
