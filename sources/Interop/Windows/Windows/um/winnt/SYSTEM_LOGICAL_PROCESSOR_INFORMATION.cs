// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION"]/*' />
public unsafe partial struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION
{
    /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION.ProcessorMask"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint ProcessorMask;

    /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION.Relationship"]/*' />
    public LOGICAL_PROCESSOR_RELATIONSHIP Relationship;

    /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION.Anonymous"]/*' />
    [NativeTypeName("_SYSTEM_LOGICAL_PROCESSOR_INFORMATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:13582:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ProcessorCore"]/*' />
    public ref _Anonymous_e__Union._ProcessorCore_e__Struct ProcessorCore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ProcessorCore, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumaNode"]/*' />
    public ref _Anonymous_e__Union._NumaNode_e__Struct NumaNode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.NumaNode, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Cache"]/*' />
    public ref CACHE_DESCRIPTOR Cache
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Cache, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Reserved"]/*' />
    public Span<ulong> Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.Reserved[0], 2);
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ProcessorCore"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:13583:9)")]
        public _ProcessorCore_e__Struct ProcessorCore;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumaNode"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:13586:9)")]
        public _NumaNode_e__Struct NumaNode;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Cache"]/*' />
        [FieldOffset(0)]
        public CACHE_DESCRIPTOR Cache;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Reserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONGLONG [2]")]
        public fixed ulong Reserved[2];

        /// <include file='_ProcessorCore_e__Struct.xml' path='doc/member[@name="_ProcessorCore_e__Struct"]/*' />
        public partial struct _ProcessorCore_e__Struct
        {
            /// <include file='_ProcessorCore_e__Struct.xml' path='doc/member[@name="_ProcessorCore_e__Struct.Flags"]/*' />
            public byte Flags;
        }

        /// <include file='_NumaNode_e__Struct.xml' path='doc/member[@name="_NumaNode_e__Struct"]/*' />
        public partial struct _NumaNode_e__Struct
        {
            /// <include file='_NumaNode_e__Struct.xml' path='doc/member[@name="_NumaNode_e__Struct.NodeNumber"]/*' />
            [NativeTypeName("DWORD")]
            public uint NodeNumber;
        }
    }
}
