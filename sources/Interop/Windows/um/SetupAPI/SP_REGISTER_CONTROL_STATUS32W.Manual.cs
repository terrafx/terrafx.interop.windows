// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct SP_REGISTER_CONTROL_STATUS32W
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("PCWSTR")]
        public ushort* FileName;

        [NativeTypeName("DWORD")]
        public uint Win32Error;

        [NativeTypeName("DWORD")]
        public uint FailureCode;
    }
}
