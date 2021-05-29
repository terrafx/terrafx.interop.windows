// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX
    {
        public LOGICAL_PROCESSOR_RELATIONSHIP Relationship;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("_SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:13645:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref PROCESSOR_RELATIONSHIP Processor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Processor, 1));
            }
        }

        public ref NUMA_NODE_RELATIONSHIP NumaNode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.NumaNode, 1));
            }
        }

        public ref CACHE_RELATIONSHIP Cache
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Cache, 1));
            }
        }

        public ref GROUP_RELATIONSHIP Group
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Group, 1));
            }
        }

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
