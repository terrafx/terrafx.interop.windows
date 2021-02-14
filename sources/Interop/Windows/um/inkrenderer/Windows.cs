// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inkrenderer.h and um/inkrenderer_i.c in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const IID")]
        public static readonly Guid IID_IInkD2DRenderer = new Guid(0x407fb1de, 0xf85a, 0x4150, 0x97, 0xcf, 0xb7, 0xfb, 0x27, 0x4f, 0xb4, 0xf8);

        [NativeTypeName("const IID")]
        public static readonly Guid IID_IInkD2DRenderer2 = new Guid(0x0a95dcd9, 0x4578, 0x4b71, 0xb2, 0x0b, 0xbf, 0x66, 0x4d, 0x4b, 0xfe, 0xee);

        [NativeTypeName("const IID")]
        public static readonly Guid LIBID_InkD2DRendererLib = new Guid(0x390d0ab0, 0x19e2, 0x46bb, 0x86, 0x2e, 0xb0, 0x9f, 0x3c, 0xdc, 0xf8, 0xb9);

        [NativeTypeName("const CLSID")]
        public static readonly Guid CLSID_InkD2DRenderer = new Guid(0x4044e60c, 0x7b01, 0x4671, 0xa9, 0x7c, 0x04, 0xe0, 0x21, 0x0a, 0x07, 0xa5);
    }
}
