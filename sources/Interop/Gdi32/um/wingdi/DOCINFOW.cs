// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DOCINFOW
    {
        public int cbSize;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpszDocName;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpszOutput;

        [NativeTypeName("LPCWSTR")]
        public ushort* lpszDatatype;

        [NativeTypeName("DWORD")]
        public uint fwType;
    }
}
