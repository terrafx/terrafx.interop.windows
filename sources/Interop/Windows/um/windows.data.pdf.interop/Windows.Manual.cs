// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.data.pdf.interop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const D2D_RECT_F")]
        public static D2D_RECT_F sc_PdfRenderParamsDefaultSrcRect = new D2D_RECT_F(0f, 0f, 0f, 0f);

        [NativeTypeName("const D2D_COLOR_F")]
        public static DXGI_RGBA sc_PdfRenderParamsDefaultBkColor = new DXGI_RGBA(1f, 1f, 1f, 1f);

        public static unsafe PDF_RENDER_PARAMS PdfRenderParams([NativeTypeName("const D2D_RECT_F &")] D2D_RECT_F* srcRect, [NativeTypeName("UINT32")] uint destinationWidth, [NativeTypeName("UINT32")] uint destinationHeight, [NativeTypeName("const D2D_COLOR_F &")] DXGI_RGBA* bkColor, [NativeTypeName("BOOLEAN")] byte ignoreHighContrast)
        {
            PDF_RENDER_PARAMS p = new PDF_RENDER_PARAMS
            {
                SourceRect = &srcRect,
                DestinationWidth = destinationWidth,
                DestinationHeight = destinationHeight,
                BackgroundColor = &bkColor,
                IgnoreHighContrast = ignoreHighContrast,
            };

            return p;
        }

        public static readonly Guid IID_IPdfRendererNative = new Guid(0x7d9dcd91, 0xd277, 0x4947, 0x8527, 0x07, 0xa0, 0xda, 0xed, 0xa9, 0x4a);
    }
}
