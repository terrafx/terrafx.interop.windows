// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluscolormatrix.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct ColorMatrix
    {
        [NativeTypeName("Gdiplus::REAL [5][5]")]
        public fixed float m[5 * 5];
    }
}
