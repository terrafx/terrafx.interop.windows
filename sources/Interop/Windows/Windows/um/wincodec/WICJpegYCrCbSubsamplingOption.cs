// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum WICJpegYCrCbSubsamplingOption
    {
        WICJpegYCrCbSubsamplingDefault = 0,
        WICJpegYCrCbSubsampling420 = 0x1,
        WICJpegYCrCbSubsampling422 = 0x2,
        WICJpegYCrCbSubsampling444 = 0x3,
        WICJpegYCrCbSubsampling440 = 0x4,
        WICJPEGYCRCBSUBSAMPLING_FORCE_DWORD = 0x7fffffff,
    }
}
