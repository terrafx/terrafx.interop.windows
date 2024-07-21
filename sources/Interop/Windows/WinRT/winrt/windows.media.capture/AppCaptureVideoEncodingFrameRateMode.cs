// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppCaptureVideoEncodingFrameRateMode.xml' path='doc/member[@name="AppCaptureVideoEncodingFrameRateMode"]/*' />
public enum AppCaptureVideoEncodingFrameRateMode
{
    /// <include file='AppCaptureVideoEncodingFrameRateMode.xml' path='doc/member[@name="AppCaptureVideoEncodingFrameRateMode.AppCaptureVideoEncodingFrameRateMode_Standard"]/*' />
    AppCaptureVideoEncodingFrameRateMode_Standard = 0,

    /// <include file='AppCaptureVideoEncodingFrameRateMode.xml' path='doc/member[@name="AppCaptureVideoEncodingFrameRateMode.AppCaptureVideoEncodingFrameRateMode_High"]/*' />
    AppCaptureVideoEncodingFrameRateMode_High = 1,
}
