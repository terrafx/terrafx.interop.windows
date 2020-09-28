// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/useractivityinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IUserActivityInterop = new Guid(0x1ADE314D, 0x0E0A, 0x40D9, 0x82, 0x4C, 0x9A, 0x08, 0x8A, 0x50, 0x05, 0x9F);

        public static readonly Guid IID_IUserActivitySourceHostInterop = new Guid(0xC15DF8BC, 0x8844, 0x487A, 0xB8, 0x5B, 0x75, 0x78, 0xE0, 0xF6, 0x14, 0x19);

        public static readonly Guid IID_IUserActivityRequestManagerInterop = new Guid(0xDD69F876, 0x9699, 0x4715, 0x90, 0x95, 0xE3, 0x7E, 0xA3, 0x0D, 0xFA, 0x1B);
    }
}
