// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct ENHMETAHEADER3
    {
        [NativeTypeName("DWORD")]
        public uint iType;

        [NativeTypeName("DWORD")]
        public uint nSize;

        public RECTL rclBounds;

        public RECTL rclFrame;

        [NativeTypeName("DWORD")]
        public uint dSignature;

        [NativeTypeName("DWORD")]
        public uint nVersion;

        [NativeTypeName("DWORD")]
        public uint nBytes;

        [NativeTypeName("DWORD")]
        public uint nRecords;

        [NativeTypeName("WORD")]
        public ushort nHandles;

        [NativeTypeName("WORD")]
        public ushort sReserved;

        [NativeTypeName("DWORD")]
        public uint nDescription;

        [NativeTypeName("DWORD")]
        public uint offDescription;

        [NativeTypeName("DWORD")]
        public uint nPalEntries;

        [NativeTypeName("SIZEL")]
        public SIZE szlDevice;

        [NativeTypeName("SIZEL")]
        public SIZE szlMillimeters;
    }
}
