// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct WmfPlaceableFileHeader
    {
        [NativeTypeName("UINT32")]
        public uint Key;

        [NativeTypeName("INT16")]
        public short Hmf;

        [NativeTypeName("Gdiplus::PWMFRect16")]
        public PWMFRect16 BoundingBox;

        [NativeTypeName("INT16")]
        public short Inch;

        [NativeTypeName("UINT32")]
        public uint Reserved;

        [NativeTypeName("INT16")]
        public short Checksum;
    }
}
