// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='StreamingCaptureMode.xml' path='doc/member[@name="StreamingCaptureMode"]/*' />
public enum StreamingCaptureMode
{
    /// <include file='StreamingCaptureMode.xml' path='doc/member[@name="StreamingCaptureMode.StreamingCaptureMode_AudioAndVideo"]/*' />
    StreamingCaptureMode_AudioAndVideo = 0,

    /// <include file='StreamingCaptureMode.xml' path='doc/member[@name="StreamingCaptureMode.StreamingCaptureMode_Audio"]/*' />
    StreamingCaptureMode_Audio = 1,

    /// <include file='StreamingCaptureMode.xml' path='doc/member[@name="StreamingCaptureMode.StreamingCaptureMode_Video"]/*' />
    StreamingCaptureMode_Video = 2,
}
