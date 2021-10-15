// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct Size
    {
        [NativeTypeName("INT")]
        public int Width;

        [NativeTypeName("INT")]
        public int Height;

        public unsafe Size([NativeTypeName("const Gdiplus::Size &")] Size* size)
        {
            Width = size->Width;
            Height = size->Height;
        }

        public Size([NativeTypeName("INT")] int width, [NativeTypeName("INT")] int height)
        {
            Width = width;
            Height = height;
        }

        [return: NativeTypeName("Gdiplus::Size")]
        public unsafe Size Add([NativeTypeName("const Gdiplus::Size &")] Size* sz)
        {
            return new Size(Width + sz->Width, Height + sz->Height);
        }

        [return: NativeTypeName("Gdiplus::Size")]
        public unsafe Size Subtract([NativeTypeName("const Gdiplus::Size &")] Size* sz)
        {
            return new Size(Width - sz->Width, Height - sz->Height);
        }

        [return: NativeTypeName("BOOL")]
        public unsafe int Equals([NativeTypeName("const Gdiplus::Size &")] Size* sz)
        {
            return ((Width == sz->Width) && (Height == sz->Height)) ? 1 : 0;
        }

        [return: NativeTypeName("BOOL")]
        public int Empty()
        {
            return (Width == 0 && Height == 0) ? 1 : 0;
        }
    }
}
