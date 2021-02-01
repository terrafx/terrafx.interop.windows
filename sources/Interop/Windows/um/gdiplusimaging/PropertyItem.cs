// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusimaging.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct PropertyItem
    {
        [NativeTypeName("PROPID")]
        public uint id;

        [NativeTypeName("ULONG")]
        public uint length;

        [NativeTypeName("WORD")]
        public ushort type;

        [NativeTypeName("void *")]
        public void* value;
    }
}
