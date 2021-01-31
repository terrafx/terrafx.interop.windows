// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public partial struct Rect
    {
        [return: NativeTypeName("Gdiplus::Rect *")]
        public unsafe Rect* Clone()
        {
            byte* data = (byte*)_new((nuint)sizeof(Rect));
            Unsafe.CopyBlockUnaligned(ref *data, ref Unsafe.As<Rect, byte>(ref this), (uint)sizeof(Rect));
            return (Rect*)data;
        }

        [return: NativeTypeName("BOOL")]
        public unsafe int Intersect([NativeTypeName("const Gdiplus::Rect &")] Rect* rect)
        {
            fixed (Rect* @this = &this)
            {
                return Intersect(@this, @this, rect);
            }
        }
    }
}
