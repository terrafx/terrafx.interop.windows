// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct AM_DVDCOPY_CHLGKEY
    {
        [NativeTypeName("BYTE [10]")]
        public fixed byte ChlgKey[10];

        [NativeTypeName("BYTE [2]")]
        public fixed byte Reserved[2];
    }
}
