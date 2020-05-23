// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SP_BACKUP_QUEUE_PARAMS_V2_W
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort FullInfPath[260];

        [NativeTypeName("INT")]
        public int FilenameOffset;

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort ReinstallInstance[260];
    }
}
