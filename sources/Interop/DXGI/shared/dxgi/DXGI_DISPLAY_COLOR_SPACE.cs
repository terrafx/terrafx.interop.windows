// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared\dxgi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe struct DXGI_DISPLAY_COLOR_SPACE
    {
        [NativeTypeName("FLOAT[8][2]")]
        public fixed float PrimaryCoordinates[8 * 2];

        [NativeTypeName("FLOAT[16][2]")]
        public fixed float WhitePoints[16 * 2];
    }
}
