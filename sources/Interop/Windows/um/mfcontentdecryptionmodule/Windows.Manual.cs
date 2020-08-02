// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        public static readonly Guid IID_IMFContentDecryptionModuleSession = new Guid(0x4E233EFD, 0x1DD2, 0x49E8, 0xB5, 0x77, 0xD6, 0x3E, 0xEE, 0x4C, 0x0D, 0x33);

        public static readonly Guid IID_IMFContentDecryptionModuleSessionCallbacks = new Guid(0x3F96EE40, 0xAD81, 0x4096, 0x84, 0x70, 0x59, 0xA4, 0xB7, 0x70, 0xF8, 0x9A);

        public static readonly Guid IID_IMFContentDecryptionModule = new Guid(0x87BE986C, 0x10BE, 0x4943, 0xBF, 0x48, 0x4B, 0x54, 0xCE, 0x19, 0x83, 0xA2);

        public static readonly Guid IID_IMFContentDecryptionModuleAccess = new Guid(0xA853D1F4, 0xE2A0, 0x4303, 0x9E, 0xDC, 0xF1, 0xA6, 0x8E, 0xE4, 0x31, 0x36);

        public static readonly Guid IID_IMFContentDecryptionModuleFactory = new Guid(0x7D5ABF16, 0x4CBB, 0x4E08, 0xB9, 0x77, 0x9B, 0xA5, 0x90, 0x49, 0x94, 0x3E);
    }
}
