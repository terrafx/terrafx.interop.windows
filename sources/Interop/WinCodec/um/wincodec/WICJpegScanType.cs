// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WICJpegScanType
    {
        WICJpegScanTypeInterleaved = 0,
        WICJpegScanTypePlanarComponents = 0x1,
        WICJpegScanTypeProgressive = 0x2,
        WICJpegScanType_FORCE_DWORD = 0x7FFFFFFF,
    }
}
