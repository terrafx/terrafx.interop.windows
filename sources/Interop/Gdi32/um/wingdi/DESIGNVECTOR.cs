// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DESIGNVECTOR
    {
        [NativeTypeName("DWORD")]
        public uint dvReserved;

        [NativeTypeName("DWORD")]
        public uint dvNumAxes;

        [NativeTypeName("LONG [16]")]
        public fixed int dvValues[16];
    }
}
