// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CameraCaptureUIMode.xml' path='doc/member[@name="CameraCaptureUIMode"]/*' />
public enum CameraCaptureUIMode
{
    /// <include file='CameraCaptureUIMode.xml' path='doc/member[@name="CameraCaptureUIMode.CameraCaptureUIMode_PhotoOrVideo"]/*' />
    CameraCaptureUIMode_PhotoOrVideo = 0,

    /// <include file='CameraCaptureUIMode.xml' path='doc/member[@name="CameraCaptureUIMode.CameraCaptureUIMode_Photo"]/*' />
    CameraCaptureUIMode_Photo = 1,

    /// <include file='CameraCaptureUIMode.xml' path='doc/member[@name="CameraCaptureUIMode.CameraCaptureUIMode_Video"]/*' />
    CameraCaptureUIMode_Video = 2,
}
