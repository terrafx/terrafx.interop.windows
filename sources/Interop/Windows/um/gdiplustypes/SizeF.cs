// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SizeF
    {
        [NativeTypeName("Gdiplus::REAL")]
        public float Width;

        [NativeTypeName("Gdiplus::REAL")]
        public float Height;

        public unsafe SizeF([NativeTypeName("const Gdiplus::SizeF &")] SizeF* size)
        {
            Width = size->Width;
            Height = size->Height;
        }

        public SizeF([NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height)
        {
            Width = width;
            Height = height;
        }

        public unsafe SizeF Add([NativeTypeName("const Gdiplus::SizeF &")] SizeF* sz)
        {
            return new SizeF(Width + sz->Width, Height + sz->Height);
        }

        public unsafe SizeF Subtract([NativeTypeName("const Gdiplus::SizeF &")] SizeF* sz)
        {
            return new SizeF(Width - sz->Width, Height - sz->Height);
        }

        [return: NativeTypeName("BOOL")]
        public unsafe int Equals([NativeTypeName("const Gdiplus::SizeF &")] SizeF* sz)
        {
            return ((Width == sz->Width) && (Height == sz->Height)) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public int Empty()
        {
            return (Width == 0.0f && Height == 0.0f) ? 1 : 0;
        }
    }
}
