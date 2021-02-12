// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ui.xaml.media.dxinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define E_SURFACE_CONTENTS_LOST 0x802b0020")]
        public const uint E_SURFACE_CONTENTS_LOST = 0x802b0020;

        public static readonly Guid IID_ISurfaceImageSourceNative = new Guid(0xF2E9EDC1, 0xD307, 0x4525, 0x98, 0x86, 0x0F, 0xAF, 0xAA, 0x44, 0x16, 0x3C);

        public static readonly Guid IID_IVirtualSurfaceUpdatesCallbackNative = new Guid(0xDBF2E947, 0x8E6C, 0x4254, 0x9E, 0xEE, 0x77, 0x38, 0xF7, 0x13, 0x86, 0xC9);

        public static readonly Guid IID_IVirtualSurfaceImageSourceNative = new Guid(0xE9550983, 0x360B, 0x4F53, 0xB3, 0x91, 0xAF, 0xD6, 0x95, 0x07, 0x86, 0x91);

        public static readonly Guid IID_ISwapChainBackgroundPanelNative = new Guid(0x43BEBD4E, 0xADD5, 0x4035, 0x8F, 0x85, 0x56, 0x08, 0xD0, 0x8E, 0x9D, 0xC9);

        public static readonly Guid IID_ISurfaceImageSourceManagerNative = new Guid(0x4C8798B7, 0x1D88, 0x4A0F, 0xB5, 0x9B, 0xB9, 0x3F, 0x60, 0x0D, 0xE8, 0xC8);

        public static readonly Guid IID_ISurfaceImageSourceNativeWithD2D = new Guid(0x54298223, 0x41E1, 0x4A41, 0x9C, 0x08, 0x02, 0xE8, 0x25, 0x68, 0x64, 0xA1);

        public static readonly Guid IID_ISwapChainPanelNative = new Guid(0xF92F19D2, 0x3ADE, 0x45A6, 0xA2, 0x0C, 0xF6, 0xF1, 0xEA, 0x90, 0x55, 0x4B);

        public static readonly Guid IID_ISwapChainPanelNative2 = new Guid(0xD5A2F60C, 0x37B2, 0x44A2, 0x93, 0x7B, 0x8D, 0x8E, 0xB9, 0x72, 0x68, 0x21);
    }
}
