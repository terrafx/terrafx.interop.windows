// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public unsafe partial struct MINIDUMP_USER_STREAM_INFORMATION
    {
        [NativeTypeName("ULONG")]
        public uint UserStreamCount;

        [NativeTypeName("PMINIDUMP_USER_STREAM")]
        public MINIDUMP_USER_STREAM* UserStreamArray;
    }
}
