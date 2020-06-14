// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct SPAUDIOSTATUS
    {
        [NativeTypeName("long")]
        public int cbFreeBuffSpace;

        [NativeTypeName("ULONG")]
        public uint cbNonBlockingIO;

        public SPAUDIOSTATE State;

        [NativeTypeName("ULONGLONG")]
        public ulong CurSeekPos;

        [NativeTypeName("ULONGLONG")]
        public ulong CurDevicePos;

        [NativeTypeName("DWORD")]
        public uint dwAudioLevel;

        [NativeTypeName("DWORD")]
        public uint dwReserved2;
    }
}
