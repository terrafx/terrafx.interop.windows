// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppCaptureVideoEncodingResolutionMode.xml' path='doc/member[@name="AppCaptureVideoEncodingResolutionMode"]/*' />
public enum AppCaptureVideoEncodingResolutionMode
{
    /// <include file='AppCaptureVideoEncodingResolutionMode.xml' path='doc/member[@name="AppCaptureVideoEncodingResolutionMode.AppCaptureVideoEncodingResolutionMode_Custom"]/*' />
    AppCaptureVideoEncodingResolutionMode_Custom = 0,

    /// <include file='AppCaptureVideoEncodingResolutionMode.xml' path='doc/member[@name="AppCaptureVideoEncodingResolutionMode.AppCaptureVideoEncodingResolutionMode_High"]/*' />
    AppCaptureVideoEncodingResolutionMode_High = 1,

    /// <include file='AppCaptureVideoEncodingResolutionMode.xml' path='doc/member[@name="AppCaptureVideoEncodingResolutionMode.AppCaptureVideoEncodingResolutionMode_Standard"]/*' />
    AppCaptureVideoEncodingResolutionMode_Standard = 2,
}
