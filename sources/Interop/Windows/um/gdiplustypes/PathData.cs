// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PathData
    {
        [NativeTypeName("INT")]
        public int Count;

        [NativeTypeName("Gdiplus::PointF *")]
        public PointF* Points;

        [NativeTypeName("BYTE *")]
        public byte* Types;
    }
}
