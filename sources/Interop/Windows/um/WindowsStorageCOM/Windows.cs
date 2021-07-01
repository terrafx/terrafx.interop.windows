// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IRandomAccessStreamFileAccessMode = new Guid(0x332E5848, 0x2E15, 0x458E, 0x85, 0xC4, 0xC9, 0x11, 0xC0, 0xC3, 0xD6, 0xF4);

        public static readonly Guid IID_IUnbufferedFileHandleOplockCallback = new Guid(0xD1019A0E, 0x6243, 0x4329, 0x84, 0x97, 0x2E, 0x75, 0x89, 0x4D, 0x77, 0x10);

        public static readonly Guid IID_IUnbufferedFileHandleProvider = new Guid(0xA65C9109, 0x42AB, 0x4B94, 0xA7, 0xB1, 0xDD, 0x2E, 0x4E, 0x68, 0x51, 0x5E);

        public static readonly Guid IID_IOplockBreakingHandler = new Guid(0x826ABE3D, 0x3ACD, 0x47D3, 0x84, 0xF2, 0x88, 0xAA, 0xED, 0xCF, 0x63, 0x04);

        public static readonly Guid IID_IStorageItemHandleAccess = new Guid(0x5CA296B2, 0x2C25, 0x4D22, 0xB7, 0x85, 0xB8, 0x85, 0xC8, 0x20, 0x1E, 0x6A);

        public static readonly Guid IID_IStorageFolderHandleAccess = new Guid(0xDF19938F, 0x5462, 0x48A0, 0xBE, 0x65, 0xD2, 0xA3, 0x27, 0x1A, 0x08, 0xD6);
    }
}
