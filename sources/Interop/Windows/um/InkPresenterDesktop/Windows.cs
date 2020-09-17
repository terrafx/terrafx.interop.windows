// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InkPresenterDesktop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IInkCommitRequestHandler = new Guid(0xFABEA3FC, 0xB108, 0x45B6, 0xA9, 0xFC, 0x8D, 0x08, 0xFA, 0x9F, 0x85, 0xCF);

        public static readonly Guid IID_IInkPresenterDesktop = new Guid(0x73F3C0D9, 0x2E8B, 0x48F3, 0x89, 0x5E, 0x20, 0xCB, 0xD2, 0x7B, 0x72, 0x3B);

        public static readonly Guid IID_IInkHostWorkItem = new Guid(0xCCDA0A9A, 0x1B78, 0x4632, 0xBB, 0x96, 0x97, 0x80, 0x06, 0x62, 0xE2, 0x6C);

        public static readonly Guid IID_IInkDesktopHost = new Guid(0x4CE7D875, 0xA981, 0x4140, 0xA1, 0xFF, 0xAD, 0x93, 0x25, 0x8E, 0x8D, 0x59);

        public static readonly Guid CLSID_InkDesktopHost = new Guid(0x062584A6, 0xF830, 0x4BDC, 0xA4, 0xD2, 0x0A, 0x10, 0xAB, 0x06, 0x2B, 0x1D);
    }
}
