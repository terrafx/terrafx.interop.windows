// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct HW_PROFILE_INFOA
    {
        [NativeTypeName("DWORD")]
        public uint dwDockInfo;

        [NativeTypeName("CHAR [39]")]
        public fixed sbyte szHwProfileGuid[39];

        [NativeTypeName("CHAR [80]")]
        public fixed sbyte szHwProfileName[80];
    }
}
