// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MIXERCONTROLDETAILS_LISTTEXTW
    {
        [NativeTypeName("DWORD")]
        public uint dwParam1;

        [NativeTypeName("DWORD")]
        public uint dwParam2;

        [NativeTypeName("WCHAR [64]")]
        public fixed ushort szName[64];
    }
}
