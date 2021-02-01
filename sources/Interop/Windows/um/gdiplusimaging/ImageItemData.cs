// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct ImageItemData
    {
        [NativeTypeName("UINT")]
        public uint Size;

        [NativeTypeName("UINT")]
        public uint Position;

        [NativeTypeName("void *")]
        public void* Desc;

        [NativeTypeName("UINT")]
        public uint DescSize;

        [NativeTypeName("void *")]
        public void* Data;

        [NativeTypeName("UINT")]
        public uint DataSize;

        [NativeTypeName("UINT")]
        public uint Cookie;
    }
}
