// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/MemoryBuffer.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IMemoryBufferByteAccess = new Guid(0x5B0D3235, 0x4DBA, 0x4D44, 0x86, 0x5E, 0x8F, 0x1D, 0x0E, 0x4F, 0xD0, 0x4D);
    }
}
