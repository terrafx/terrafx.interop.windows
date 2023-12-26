// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CameraCaptureUIPhotoFormat.xml' path='doc/member[@name="CameraCaptureUIPhotoFormat"]/*' />
public enum CameraCaptureUIPhotoFormat
{
    /// <include file='CameraCaptureUIPhotoFormat.xml' path='doc/member[@name="CameraCaptureUIPhotoFormat.CameraCaptureUIPhotoFormat_Jpeg"]/*' />
    CameraCaptureUIPhotoFormat_Jpeg = 0,

    /// <include file='CameraCaptureUIPhotoFormat.xml' path='doc/member[@name="CameraCaptureUIPhotoFormat.CameraCaptureUIPhotoFormat_Png"]/*' />
    CameraCaptureUIPhotoFormat_Png = 1,

    /// <include file='CameraCaptureUIPhotoFormat.xml' path='doc/member[@name="CameraCaptureUIPhotoFormat.CameraCaptureUIPhotoFormat_JpegXR"]/*' />
    CameraCaptureUIPhotoFormat_JpegXR = 2,
}
