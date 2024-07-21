// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.graphics.imaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='JpegSubsamplingMode.xml' path='doc/member[@name="JpegSubsamplingMode"]/*' />
public enum JpegSubsamplingMode
{
    /// <include file='JpegSubsamplingMode.xml' path='doc/member[@name="JpegSubsamplingMode.JpegSubsamplingMode_Default"]/*' />
    JpegSubsamplingMode_Default = 0,

    /// <include file='JpegSubsamplingMode.xml' path='doc/member[@name="JpegSubsamplingMode.JpegSubsamplingMode_Y4Cb2Cr0"]/*' />
    JpegSubsamplingMode_Y4Cb2Cr0 = 1,

    /// <include file='JpegSubsamplingMode.xml' path='doc/member[@name="JpegSubsamplingMode.JpegSubsamplingMode_Y4Cb2Cr2"]/*' />
    JpegSubsamplingMode_Y4Cb2Cr2 = 2,

    /// <include file='JpegSubsamplingMode.xml' path='doc/member[@name="JpegSubsamplingMode.JpegSubsamplingMode_Y4Cb4Cr4"]/*' />
    JpegSubsamplingMode_Y4Cb4Cr4 = 3,
}
