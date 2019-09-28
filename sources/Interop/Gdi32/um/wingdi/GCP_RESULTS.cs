// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\wingdi.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct GCP_RESULTS
    {
        [NativeTypeName("DWORD")]
        public uint lStructSize;

        [NativeTypeName("LPWSTR")]
        public ushort* lpOutString;

        [NativeTypeName("UINT *")]
        public uint* lpOrder;

        [NativeTypeName("int *")]
        public int* lpDx;

        [NativeTypeName("int *")]
        public int* lpCaretPos;

        [NativeTypeName("LPSTR")]
        public sbyte* lpClass;

        [NativeTypeName("LPWSTR")]
        public ushort* lpGlyphs;

        [NativeTypeName("UINT")]
        public uint nGlyphs;

        public int nMaxFit;
    }
}
