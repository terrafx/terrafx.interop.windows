// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct ColorLUTParams
    {
        [NativeTypeName("Gdiplus::ColorChannelLUT")]
        public fixed byte lutB[256];

        [NativeTypeName("Gdiplus::ColorChannelLUT")]
        public fixed byte lutG[256];

        [NativeTypeName("Gdiplus::ColorChannelLUT")]
        public fixed byte lutR[256];

        [NativeTypeName("Gdiplus::ColorChannelLUT")]
        public fixed byte lutA[256];
    }
}
