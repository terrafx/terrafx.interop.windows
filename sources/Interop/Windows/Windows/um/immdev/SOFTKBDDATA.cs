// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SOFTKBDDATA
    {
        public uint uCount;

        [NativeTypeName("WORD [1][256]")]
        public fixed ushort wCode[1 * 256];
    }
}
