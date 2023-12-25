// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='AppCaptureMetadataPriority.xml' path='doc/member[@name="AppCaptureMetadataPriority"]/*' />
public enum AppCaptureMetadataPriority
{
    /// <include file='AppCaptureMetadataPriority.xml' path='doc/member[@name="AppCaptureMetadataPriority.AppCaptureMetadataPriority_Informational"]/*' />
    AppCaptureMetadataPriority_Informational = 0,

    /// <include file='AppCaptureMetadataPriority.xml' path='doc/member[@name="AppCaptureMetadataPriority.AppCaptureMetadataPriority_Important"]/*' />
    AppCaptureMetadataPriority_Important = 1,
}
