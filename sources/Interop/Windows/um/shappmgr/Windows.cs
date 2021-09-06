// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IShellApp = new Guid(0xA3E14960, 0x935F, 0x11D1, 0xB8, 0xB8, 0x00, 0x60, 0x08, 0x05, 0x93, 0x82);

        public static readonly Guid IID_IPublishedApp = new Guid(0x1BC752E0, 0x9046, 0x11D1, 0xB8, 0xB3, 0x00, 0x60, 0x08, 0x05, 0x93, 0x82);

        public static readonly Guid IID_IPublishedApp2 = new Guid(0x12B81347, 0x1B3A, 0x4A04, 0xAA, 0x61, 0x3F, 0x76, 0x8B, 0x67, 0xFD, 0x7E);

        public static readonly Guid IID_IEnumPublishedApps = new Guid(0x0B124F8C, 0x91F0, 0x11D1, 0xB8, 0xB5, 0x00, 0x60, 0x08, 0x05, 0x93, 0x82);

        public static readonly Guid IID_IAppPublisher = new Guid(0x07250A10, 0x9CF9, 0x11D1, 0x90, 0x76, 0x00, 0x60, 0x08, 0x05, 0x93, 0x82);
    }
}
