// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct MINIDUMP_SYSTEM_INFO
    {
        public ushort ProcessorArchitecture;

        public ushort ProcessorLevel;

        public ushort ProcessorRevision;

        [NativeTypeName("_MINIDUMP_SYSTEM_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/minidumpapiset.h:245:5)")]
        public _Anonymous1_e__Union Anonymous1;

        [NativeTypeName("ULONG32")]
        public uint MajorVersion;

        [NativeTypeName("ULONG32")]
        public uint MinorVersion;

        [NativeTypeName("ULONG32")]
        public uint BuildNumber;

        [NativeTypeName("ULONG32")]
        public uint PlatformId;

        [NativeTypeName("RVA")]
        public uint CSDVersionRva;

        [NativeTypeName("_MINIDUMP_SYSTEM_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/minidumpapiset.h:270:5)")]
        public _Anonymous2_e__Union Anonymous2;

        public CPU_INFORMATION Cpu;

        public ref ushort Reserved0
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Reserved0, 1));
            }
        }

        public ref byte NumberOfProcessors
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous.NumberOfProcessors, 1));
            }
        }

        public ref byte ProductType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.Anonymous.ProductType, 1));
            }
        }

        public ref uint Reserved1
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.Reserved1, 1));
            }
        }

        public ref ushort SuiteMask
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.Anonymous.SuiteMask, 1));
            }
        }

        public ref ushort Reserved2
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.Anonymous.Reserved2, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous1_e__Union
        {
            [FieldOffset(0)]
            public ushort Reserved0;

            [FieldOffset(0)]
            [NativeTypeName("_MINIDUMP_SYSTEM_INFO::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/minidumpapiset.h:247:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("UCHAR")]
                public byte NumberOfProcessors;

                [NativeTypeName("UCHAR")]
                public byte ProductType;
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous2_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG32")]
            public uint Reserved1;

            [FieldOffset(0)]
            [NativeTypeName("_MINIDUMP_SYSTEM_INFO::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/minidumpapiset.h:272:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                public ushort SuiteMask;

                public ushort Reserved2;
            }
        }
    }
}
