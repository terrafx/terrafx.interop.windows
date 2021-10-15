// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusinit.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("gdiplus", ExactSpelling = true)]
        [return: NativeTypeName("Gdiplus::Status")]
        public static extern Status GdiplusStartup([NativeTypeName("ULONG_PTR *")] nuint* token, [NativeTypeName("const Gdiplus::GdiplusStartupInput *")] GdiplusStartupInput* input, [NativeTypeName("Gdiplus::GdiplusStartupOutput *")] GdiplusStartupOutput* output);

        [DllImport("gdiplus", ExactSpelling = true)]
        public static extern void GdiplusShutdown([NativeTypeName("ULONG_PTR")] nuint token);
    }
}
