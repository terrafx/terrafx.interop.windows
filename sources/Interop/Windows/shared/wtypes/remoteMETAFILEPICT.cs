// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct remoteMETAFILEPICT
    {
        [NativeTypeName("LONG")]
        public int mm;

        [NativeTypeName("LONG")]
        public int xExt;

        [NativeTypeName("LONG")]
        public int yExt;

        [NativeTypeName("userHMETAFILE *")]
        public userHMETAFILE* hMF;
    }
}
