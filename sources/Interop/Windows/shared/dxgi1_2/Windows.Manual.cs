// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public const uint DXGI_ENUM_MODES_STEREO = 4;

        public const uint DXGI_ENUM_MODES_DISABLED_STEREO = 8;

        public const uint DXGI_SHARED_RESOURCE_READ = 0x80000000;

        public const uint DXGI_SHARED_RESOURCE_WRITE = 1;
    }
}
