// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct COMMCONFIG
    {
        [NativeTypeName("DWORD")]
        public uint dwSize;

        [NativeTypeName("WORD")]
        public ushort wVersion;

        [NativeTypeName("WORD")]
        public ushort wReserved;

        public DCB dcb;

        [NativeTypeName("DWORD")]
        public uint dwProviderSubType;

        [NativeTypeName("DWORD")]
        public uint dwProviderOffset;

        [NativeTypeName("DWORD")]
        public uint dwProviderSize;

        [NativeTypeName("WCHAR [1]")]
        public fixed ushort wcProviderData[1];
    }
}
