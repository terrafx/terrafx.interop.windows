// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusmem.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("gdiplus", ExactSpelling = true)]
        [return: NativeTypeName("void *")]
        public static extern void* GdipAlloc([NativeTypeName("size_t")] nuint size);

        [DllImport("gdiplus", ExactSpelling = true)]
        public static extern void GdipFree([NativeTypeName("void *")] void* ptr);

        [NativeTypeName("#define GDIPVER 0x0100")]
        public const int GDIPVER = 0x0100;
    }
}
