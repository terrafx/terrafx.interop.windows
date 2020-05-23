// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct RemHGLOBAL
    {
        [NativeTypeName("LONG")]
        public int fNullHGlobal;

        [NativeTypeName("ULONG")]
        public uint cbData;

        [NativeTypeName("byte [1]")]
        public fixed byte data[1];
    }
}
