// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InkPresenterDesktop.h and um/InkPresenterDesktop_i.c in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const IID")]
        public static readonly Guid IID_IInkCommitRequestHandler = new Guid(0xfabea3fc, 0xb108, 0x45b6, 0xa9, 0xfc, 0x8d, 0x08, 0xfa, 0x9f, 0x85, 0xcf);

        [NativeTypeName("const IID")]
        public static readonly Guid IID_IInkPresenterDesktop = new Guid(0x73f3c0d9, 0x2e8b, 0x48f3, 0x89, 0x5e, 0x20, 0xcb, 0xd2, 0x7b, 0x72, 0x3b);

        [NativeTypeName("const IID")]
        public static readonly Guid IID_IInkHostWorkItem = new Guid(0xccda0a9a, 0x1b78, 0x4632, 0xbb, 0x96, 0x97, 0x80, 0x06, 0x62, 0xe2, 0x6c);

        [NativeTypeName("const IID")]
        public static readonly Guid IID_IInkDesktopHost = new Guid(0x4ce7d875, 0xa981, 0x4140, 0xa1, 0xff, 0xad, 0x93, 0x25, 0x8e, 0x8d, 0x59);

        [NativeTypeName("const IID")]
        public static readonly Guid LIBID_InkDesktopHostLib = new Guid(0x2aef0967, 0xc833, 0x4f38, 0x91, 0xf3, 0x16, 0xe6, 0x7d, 0x55, 0xd7, 0x17);

        [NativeTypeName("const CLSID")]
        public static readonly Guid CLSID_InkDesktopHost = new Guid(0x062584a6, 0xf830, 0x4bdc, 0xa4, 0xd2, 0x0a, 0x10, 0xab, 0x06, 0x2b, 0x1d);
    }
}
