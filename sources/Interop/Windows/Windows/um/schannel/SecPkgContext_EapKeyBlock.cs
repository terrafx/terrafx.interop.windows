// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct SecPkgContext_EapKeyBlock
    {
        [NativeTypeName("BYTE [128]")]
        public fixed byte rgbKeys[128];

        [NativeTypeName("BYTE [64]")]
        public fixed byte rgbIVs[64];
    }
}
