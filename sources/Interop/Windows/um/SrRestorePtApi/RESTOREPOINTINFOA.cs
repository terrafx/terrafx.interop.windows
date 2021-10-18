// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SrRestorePtApi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct RESTOREPOINTINFOA
    {
        [NativeTypeName("DWORD")]
        public uint dwEventType;

        [NativeTypeName("DWORD")]
        public uint dwRestorePtType;

        [NativeTypeName("INT64")]
        public long llSequenceNumber;

        [NativeTypeName("CHAR [64]")]
        public fixed sbyte szDescription[64];
    }
}
