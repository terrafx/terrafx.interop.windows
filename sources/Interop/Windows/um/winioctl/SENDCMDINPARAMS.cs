// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct SENDCMDINPARAMS
    {
        [NativeTypeName("DWORD")]
        public uint cBufferSize;

        public IDEREGS irDriveRegs;

        [NativeTypeName("BYTE")]
        public byte bDriveNumber;

        [NativeTypeName("BYTE [3]")]
        public fixed byte bReserved[3];

        [NativeTypeName("DWORD [4]")]
        public fixed uint dwReserved[4];

        [NativeTypeName("BYTE [1]")]
        public fixed byte bBuffer[1];
    }
}
