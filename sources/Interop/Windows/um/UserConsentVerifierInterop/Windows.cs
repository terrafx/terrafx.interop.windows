// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserConsentVerifierInterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IUserConsentVerifierInterop = new Guid(0x39E050C3, 0x4E74, 0x441A, 0x8D, 0xC0, 0xB8, 0x11, 0x04, 0xDF, 0x94, 0x9C);
    }
}
