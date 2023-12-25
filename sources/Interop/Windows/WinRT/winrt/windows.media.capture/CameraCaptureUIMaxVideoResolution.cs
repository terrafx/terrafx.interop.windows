// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='CameraCaptureUIMaxVideoResolution.xml' path='doc/member[@name="CameraCaptureUIMaxVideoResolution"]/*' />
public enum CameraCaptureUIMaxVideoResolution
{
    /// <include file='CameraCaptureUIMaxVideoResolution.xml' path='doc/member[@name="CameraCaptureUIMaxVideoResolution.CameraCaptureUIMaxVideoResolution_HighestAvailable"]/*' />
    CameraCaptureUIMaxVideoResolution_HighestAvailable = 0,

    /// <include file='CameraCaptureUIMaxVideoResolution.xml' path='doc/member[@name="CameraCaptureUIMaxVideoResolution.CameraCaptureUIMaxVideoResolution_LowDefinition"]/*' />
    CameraCaptureUIMaxVideoResolution_LowDefinition = 1,

    /// <include file='CameraCaptureUIMaxVideoResolution.xml' path='doc/member[@name="CameraCaptureUIMaxVideoResolution.CameraCaptureUIMaxVideoResolution_StandardDefinition"]/*' />
    CameraCaptureUIMaxVideoResolution_StandardDefinition = 2,

    /// <include file='CameraCaptureUIMaxVideoResolution.xml' path='doc/member[@name="CameraCaptureUIMaxVideoResolution.CameraCaptureUIMaxVideoResolution_HighDefinition"]/*' />
    CameraCaptureUIMaxVideoResolution_HighDefinition = 3,
}
