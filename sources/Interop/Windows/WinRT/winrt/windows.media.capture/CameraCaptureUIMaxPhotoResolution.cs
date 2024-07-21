// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CameraCaptureUIMaxPhotoResolution.xml' path='doc/member[@name="CameraCaptureUIMaxPhotoResolution"]/*' />
public enum CameraCaptureUIMaxPhotoResolution
{
    /// <include file='CameraCaptureUIMaxPhotoResolution.xml' path='doc/member[@name="CameraCaptureUIMaxPhotoResolution.CameraCaptureUIMaxPhotoResolution_HighestAvailable"]/*' />
    CameraCaptureUIMaxPhotoResolution_HighestAvailable = 0,

    /// <include file='CameraCaptureUIMaxPhotoResolution.xml' path='doc/member[@name="CameraCaptureUIMaxPhotoResolution.CameraCaptureUIMaxPhotoResolution_VerySmallQvga"]/*' />
    CameraCaptureUIMaxPhotoResolution_VerySmallQvga = 1,

    /// <include file='CameraCaptureUIMaxPhotoResolution.xml' path='doc/member[@name="CameraCaptureUIMaxPhotoResolution.CameraCaptureUIMaxPhotoResolution_SmallVga"]/*' />
    CameraCaptureUIMaxPhotoResolution_SmallVga = 2,

    /// <include file='CameraCaptureUIMaxPhotoResolution.xml' path='doc/member[@name="CameraCaptureUIMaxPhotoResolution.CameraCaptureUIMaxPhotoResolution_MediumXga"]/*' />
    CameraCaptureUIMaxPhotoResolution_MediumXga = 3,

    /// <include file='CameraCaptureUIMaxPhotoResolution.xml' path='doc/member[@name="CameraCaptureUIMaxPhotoResolution.CameraCaptureUIMaxPhotoResolution_Large3M"]/*' />
    CameraCaptureUIMaxPhotoResolution_Large3M = 4,

    /// <include file='CameraCaptureUIMaxPhotoResolution.xml' path='doc/member[@name="CameraCaptureUIMaxPhotoResolution.CameraCaptureUIMaxPhotoResolution_VeryLarge5M"]/*' />
    CameraCaptureUIMaxPhotoResolution_VeryLarge5M = 5,
}
