// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX
    {
        public LOGICAL_PROCESSOR_RELATIONSHIP Relationship;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("_SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:12473:5)")]
        public _Anonymous_e__Union Anonymous;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public PROCESSOR_RELATIONSHIP Processor;

            [FieldOffset(0)]
            public NUMA_NODE_RELATIONSHIP NumaNode;

            [FieldOffset(0)]
            public CACHE_RELATIONSHIP Cache;

            [FieldOffset(0)]
            public GROUP_RELATIONSHIP Group;
        }
    }
}
