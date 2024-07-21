// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppCaptureVideoEncodingBitrateMode.xml' path='doc/member[@name="AppCaptureVideoEncodingBitrateMode"]/*' />
public enum AppCaptureVideoEncodingBitrateMode
{
    /// <include file='AppCaptureVideoEncodingBitrateMode.xml' path='doc/member[@name="AppCaptureVideoEncodingBitrateMode.AppCaptureVideoEncodingBitrateMode_Custom"]/*' />
    AppCaptureVideoEncodingBitrateMode_Custom = 0,

    /// <include file='AppCaptureVideoEncodingBitrateMode.xml' path='doc/member[@name="AppCaptureVideoEncodingBitrateMode.AppCaptureVideoEncodingBitrateMode_High"]/*' />
    AppCaptureVideoEncodingBitrateMode_High = 1,

    /// <include file='AppCaptureVideoEncodingBitrateMode.xml' path='doc/member[@name="AppCaptureVideoEncodingBitrateMode.AppCaptureVideoEncodingBitrateMode_Standard"]/*' />
    AppCaptureVideoEncodingBitrateMode_Standard = 2,
}
