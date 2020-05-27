// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WIN32_STREAM_ID
    {
        [NativeTypeName("DWORD")]
        public uint dwStreamId;

        [NativeTypeName("DWORD")]
        public uint dwStreamAttributes;

        public LARGE_INTEGER Size;

        [NativeTypeName("DWORD")]
        public uint dwStreamNameSize;

        [NativeTypeName("WCHAR [1]")]
        public fixed ushort cStreamName[1];
    }
}
