// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='MediaCaptureOptimization.xml' path='doc/member[@name="MediaCaptureOptimization"]/*' />
public enum MediaCaptureOptimization
{
    /// <include file='MediaCaptureOptimization.xml' path='doc/member[@name="MediaCaptureOptimization.MediaCaptureOptimization_Default"]/*' />
    MediaCaptureOptimization_Default = 0,

    /// <include file='MediaCaptureOptimization.xml' path='doc/member[@name="MediaCaptureOptimization.MediaCaptureOptimization_Quality"]/*' />
    MediaCaptureOptimization_Quality = 1,

    /// <include file='MediaCaptureOptimization.xml' path='doc/member[@name="MediaCaptureOptimization.MediaCaptureOptimization_Latency"]/*' />
    MediaCaptureOptimization_Latency = 2,

    /// <include file='MediaCaptureOptimization.xml' path='doc/member[@name="MediaCaptureOptimization.MediaCaptureOptimization_Power"]/*' />
    MediaCaptureOptimization_Power = 3,

    /// <include file='MediaCaptureOptimization.xml' path='doc/member[@name="MediaCaptureOptimization.MediaCaptureOptimization_LatencyThenQuality"]/*' />
    MediaCaptureOptimization_LatencyThenQuality = 4,

    /// <include file='MediaCaptureOptimization.xml' path='doc/member[@name="MediaCaptureOptimization.MediaCaptureOptimization_LatencyThenPower"]/*' />
    MediaCaptureOptimization_LatencyThenPower = 5,

    /// <include file='MediaCaptureOptimization.xml' path='doc/member[@name="MediaCaptureOptimization.MediaCaptureOptimization_PowerAndQuality"]/*' />
    MediaCaptureOptimization_PowerAndQuality = 6,
}
