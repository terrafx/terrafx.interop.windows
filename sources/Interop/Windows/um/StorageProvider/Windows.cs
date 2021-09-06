// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/StorageProvider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IStorageProviderPropertyHandler = new Guid(0x301DFBE5, 0x524C, 0x4B0F, 0x8B, 0x2D, 0x21, 0xC4, 0x0B, 0x3A, 0x29, 0x88);

        public static readonly Guid IID_IStorageProviderHandler = new Guid(0x162C6FB5, 0x44D3, 0x435B, 0x90, 0x3D, 0xE6, 0x13, 0xFA, 0x09, 0x3F, 0xB5);
    }
}
