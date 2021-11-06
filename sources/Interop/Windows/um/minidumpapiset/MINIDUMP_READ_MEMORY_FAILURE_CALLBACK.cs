// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct MINIDUMP_READ_MEMORY_FAILURE_CALLBACK
    {
        [NativeTypeName("ULONG64")]
        public ulong Offset;

        [NativeTypeName("ULONG")]
        public uint Bytes;

        public HRESULT FailureStatus;
    }
}
