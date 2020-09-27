// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/efswrtinterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_IProtectionPolicyManagerInterop = new Guid(0x4652651D, 0xC1FE, 0x4BA1, 0x9F, 0x0A, 0xC0, 0xF5, 0x65, 0x96, 0xF7, 0x21);

        public static readonly Guid IID_IProtectionPolicyManagerInterop2 = new Guid(0x157CFBE4, 0xA78D, 0x4156, 0xB3, 0x84, 0x61, 0xFD, 0xAC, 0x41, 0xE6, 0x86);

        public static readonly Guid IID_IProtectionPolicyManagerInterop3 = new Guid(0xC1C03933, 0xB398, 0x4D93, 0xB0, 0xFD, 0x29, 0x72, 0xAD, 0xF8, 0x02, 0xC2);
    }
}
