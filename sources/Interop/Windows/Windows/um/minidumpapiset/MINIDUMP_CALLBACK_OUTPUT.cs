// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_CALLBACK_OUTPUT.xml' path='doc/member[@name="MINIDUMP_CALLBACK_OUTPUT"]/*' />
public partial struct MINIDUMP_CALLBACK_OUTPUT
{
    /// <include file='MINIDUMP_CALLBACK_OUTPUT.xml' path='doc/member[@name="MINIDUMP_CALLBACK_OUTPUT.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_minidumpapiset_L1258_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ModuleWriteFlags"]/*' />
    [UnscopedRef]
    public ref uint ModuleWriteFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ModuleWriteFlags;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ThreadWriteFlags"]/*' />
    [UnscopedRef]
    public ref uint ThreadWriteFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ThreadWriteFlags;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SecondaryFlags"]/*' />
    [UnscopedRef]
    public ref uint SecondaryFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.SecondaryFlags;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.MemoryBase"]/*' />
    [UnscopedRef]
    public ref ulong MemoryBase
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous1.MemoryBase;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.MemorySize"]/*' />
    [UnscopedRef]
    public ref uint MemorySize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous1.MemorySize;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.CheckCancel"]/*' />
    [UnscopedRef]
    public ref BOOL CheckCancel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous2.CheckCancel;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.Cancel"]/*' />
    [UnscopedRef]
    public ref BOOL Cancel
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous2.Cancel;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Handle"]/*' />
    [UnscopedRef]
    public ref HANDLE Handle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Handle;
        }
    }

    /// <include file='_Anonymous3_e__Struct.xml' path='doc/member[@name="_Anonymous3_e__Struct.VmRegion"]/*' />
    [UnscopedRef]
    public ref MINIDUMP_MEMORY_INFO VmRegion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous3.VmRegion;
        }
    }

    /// <include file='_Anonymous3_e__Struct.xml' path='doc/member[@name="_Anonymous3_e__Struct.Continue"]/*' />
    [UnscopedRef]
    public ref BOOL Continue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous3.Continue;
        }
    }

    /// <include file='_Anonymous4_e__Struct.xml' path='doc/member[@name="_Anonymous4_e__Struct.VmQueryStatus"]/*' />
    [UnscopedRef]
    public ref HRESULT VmQueryStatus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous4.VmQueryStatus;
        }
    }

    /// <include file='_Anonymous4_e__Struct.xml' path='doc/member[@name="_Anonymous4_e__Struct.VmQueryResult"]/*' />
    [UnscopedRef]
    public ref MINIDUMP_MEMORY_INFO VmQueryResult
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous4.VmQueryResult;
        }
    }

    /// <include file='_Anonymous5_e__Struct.xml' path='doc/member[@name="_Anonymous5_e__Struct.VmReadStatus"]/*' />
    [UnscopedRef]
    public ref HRESULT VmReadStatus
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous5.VmReadStatus;
        }
    }

    /// <include file='_Anonymous5_e__Struct.xml' path='doc/member[@name="_Anonymous5_e__Struct.VmReadBytesCompleted"]/*' />
    [UnscopedRef]
    public ref uint VmReadBytesCompleted
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous5.VmReadBytesCompleted;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Status"]/*' />
    [UnscopedRef]
    public ref HRESULT Status
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Status;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit, Pack = 4)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ModuleWriteFlags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint ModuleWriteFlags;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ThreadWriteFlags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint ThreadWriteFlags;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.SecondaryFlags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint SecondaryFlags;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous1"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_minidumpapiset_L1262_C9")]
        public _Anonymous1_e__Struct Anonymous1;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous2"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_minidumpapiset_L1266_C9")]
        public _Anonymous2_e__Struct Anonymous2;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Handle"]/*' />
        [FieldOffset(0)]
        public HANDLE Handle;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous3"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_minidumpapiset_L1271_C9")]
        public _Anonymous3_e__Struct Anonymous3;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous4"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_minidumpapiset_L1275_C9")]
        public _Anonymous4_e__Struct Anonymous4;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous5"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_minidumpapiset_L1279_C9")]
        public _Anonymous5_e__Struct Anonymous5;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Status"]/*' />
        [FieldOffset(0)]
        public HRESULT Status;

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        public partial struct _Anonymous1_e__Struct
        {
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.MemoryBase"]/*' />
            [NativeTypeName("ULONG64")]
            public ulong MemoryBase;

            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.MemorySize"]/*' />
            [NativeTypeName("ULONG")]
            public uint MemorySize;
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct"]/*' />
        public partial struct _Anonymous2_e__Struct
        {
            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.CheckCancel"]/*' />
            public BOOL CheckCancel;

            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.Cancel"]/*' />
            public BOOL Cancel;
        }

        /// <include file='_Anonymous3_e__Struct.xml' path='doc/member[@name="_Anonymous3_e__Struct"]/*' />
        public partial struct _Anonymous3_e__Struct
        {
            /// <include file='_Anonymous3_e__Struct.xml' path='doc/member[@name="_Anonymous3_e__Struct.VmRegion"]/*' />
            public MINIDUMP_MEMORY_INFO VmRegion;

            /// <include file='_Anonymous3_e__Struct.xml' path='doc/member[@name="_Anonymous3_e__Struct.Continue"]/*' />
            public BOOL Continue;
        }

        /// <include file='_Anonymous4_e__Struct.xml' path='doc/member[@name="_Anonymous4_e__Struct"]/*' />
        public partial struct _Anonymous4_e__Struct
        {
            /// <include file='_Anonymous4_e__Struct.xml' path='doc/member[@name="_Anonymous4_e__Struct.VmQueryStatus"]/*' />
            public HRESULT VmQueryStatus;

            /// <include file='_Anonymous4_e__Struct.xml' path='doc/member[@name="_Anonymous4_e__Struct.VmQueryResult"]/*' />
            public MINIDUMP_MEMORY_INFO VmQueryResult;
        }

        /// <include file='_Anonymous5_e__Struct.xml' path='doc/member[@name="_Anonymous5_e__Struct"]/*' />
        public partial struct _Anonymous5_e__Struct
        {
            /// <include file='_Anonymous5_e__Struct.xml' path='doc/member[@name="_Anonymous5_e__Struct.VmReadStatus"]/*' />
            public HRESULT VmReadStatus;

            /// <include file='_Anonymous5_e__Struct.xml' path='doc/member[@name="_Anonymous5_e__Struct.VmReadBytesCompleted"]/*' />
            [NativeTypeName("ULONG")]
            public uint VmReadBytesCompleted;
        }
    }
}
