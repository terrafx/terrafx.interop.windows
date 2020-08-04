// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct JOBOBJECT_CPU_RATE_CONTROL_INFORMATION
    {
        [NativeTypeName("DWORD")]
        public uint ControlFlags;

        [NativeTypeName("_JOBOBJECT_CPU_RATE_CONTROL_INFORMATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12098:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint CpuRate => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.CpuRate, 1));

        public ref uint Weight => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Weight, 1));

        public ref ushort MinRate => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.MinRate, 1));

        public ref ushort MaxRate => ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.MaxRate, 1));

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint CpuRate;

            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint Weight;

            [FieldOffset(0)]
            [NativeTypeName("_JOBOBJECT_CPU_RATE_CONTROL_INFORMATION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12101:9)")]
            public _Anonymous_e__Struct Anonymous;

            public partial struct _Anonymous_e__Struct
            {
                [NativeTypeName("WORD")]
                public ushort MinRate;

                [NativeTypeName("WORD")]
                public ushort MaxRate;
            }
        }
    }
}
