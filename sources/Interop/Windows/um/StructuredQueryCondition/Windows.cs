// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/StructuredQueryCondition.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IRichChunk = new Guid(0x4FDEF69C, 0xDBC9, 0x454E, 0x99, 0x10, 0xB3, 0x4F, 0x3C, 0x64, 0xB5, 0x10);

        public static readonly Guid IID_ICondition = new Guid(0x0FC988D4, 0xC935, 0x4B97, 0xA9, 0x73, 0x46, 0x28, 0x2E, 0xA1, 0x75, 0xC8);

        public static readonly Guid IID_ICondition2 = new Guid(0x0DB8851D, 0x2E5B, 0x47EB, 0x92, 0x08, 0xD2, 0x8C, 0x32, 0x5A, 0x01, 0xD7);
    }
}
