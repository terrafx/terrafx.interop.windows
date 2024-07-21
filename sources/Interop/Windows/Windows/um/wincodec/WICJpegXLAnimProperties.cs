// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WICJpegXLAnimProperties.xml' path='doc/member[@name="WICJpegXLAnimProperties"]/*' />
public enum WICJpegXLAnimProperties
{
    /// <include file='WICJpegXLAnimProperties.xml' path='doc/member[@name="WICJpegXLAnimProperties.WICJpegXLAnimLoopCount"]/*' />
    WICJpegXLAnimLoopCount = 0x1,

    /// <include file='WICJpegXLAnimProperties.xml' path='doc/member[@name="WICJpegXLAnimProperties.WICJpegXLAnimFrameTicksPerSecondNumerator"]/*' />
    WICJpegXLAnimFrameTicksPerSecondNumerator = 0x2,

    /// <include file='WICJpegXLAnimProperties.xml' path='doc/member[@name="WICJpegXLAnimProperties.WICJpegXLAnimFrameTicksPerSecondDenominator"]/*' />
    WICJpegXLAnimFrameTicksPerSecondDenominator = 0x3,

    /// <include file='WICJpegXLAnimProperties.xml' path='doc/member[@name="WICJpegXLAnimProperties.WICJpegXLAnimProperties_FORCE_DWORD"]/*' />
    WICJpegXLAnimProperties_FORCE_DWORD = 0x7fffffff,
}
