// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION
    {
        [NativeTypeName("ULONG_PTR")]
        public nuint ProcessorMask;

        public LOGICAL_PROCESSOR_RELATIONSHIP Relationship;

        [NativeTypeName("_SYSTEM_LOGICAL_PROCESSOR_INFORMATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12420:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12421:9)")]
            public _ProcessorCore_e__Union ProcessorCore;

            [FieldOffset(0)]
            [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12424:9)")]
            public _NumaNode_e__Union NumaNode;

            [FieldOffset(0)]
            public CACHE_DESCRIPTOR Cache;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG [2]")]
            public fixed ulong Reserved[2];

            public partial struct _ProcessorCore_e__Union
            {
                [NativeTypeName("BYTE")]
                public byte Flags;
            }

            public partial struct _NumaNode_e__Union
            {
                [NativeTypeName("DWORD")]
                public uint NodeNumber;
            }
        }
    }
}
