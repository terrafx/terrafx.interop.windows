// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct LOCALESIGNATURE
    {
        [NativeTypeName("DWORD [4]")]
        public fixed uint lsUsb[4];

        [NativeTypeName("DWORD [2]")]
        public fixed uint lsCsbDefault[2];

        [NativeTypeName("DWORD [2]")]
        public fixed uint lsCsbSupported[2];
    }
}
