// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct MINIDUMP_HEADER
    {
        [NativeTypeName("ULONG32")]
        public uint Signature;

        [NativeTypeName("ULONG32")]
        public uint Version;

        [NativeTypeName("ULONG32")]
        public uint NumberOfStreams;

        [NativeTypeName("RVA")]
        public uint StreamDirectoryRva;

        [NativeTypeName("ULONG32")]
        public uint CheckSum;

        [NativeTypeName("_MINIDUMP_HEADER::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/minidumpapiset.h:82:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("ULONG64")]
        public ulong Flags;

        public ref uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Reserved, 1));
            }
        }

        public ref uint TimeDateStamp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.TimeDateStamp, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG32")]
            public uint Reserved;

            [FieldOffset(0)]
            [NativeTypeName("ULONG32")]
            public uint TimeDateStamp;
        }
    }
}
