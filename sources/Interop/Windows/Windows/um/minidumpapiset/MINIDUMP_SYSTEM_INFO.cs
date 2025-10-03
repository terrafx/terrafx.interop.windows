// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_SYSTEM_INFO.xml' path='doc/member[@name="MINIDUMP_SYSTEM_INFO"]/*' />
public partial struct MINIDUMP_SYSTEM_INFO
{
    /// <include file='MINIDUMP_SYSTEM_INFO.xml' path='doc/member[@name="MINIDUMP_SYSTEM_INFO.ProcessorArchitecture"]/*' />
    public ushort ProcessorArchitecture;

    /// <include file='MINIDUMP_SYSTEM_INFO.xml' path='doc/member[@name="MINIDUMP_SYSTEM_INFO.ProcessorLevel"]/*' />
    public ushort ProcessorLevel;

    /// <include file='MINIDUMP_SYSTEM_INFO.xml' path='doc/member[@name="MINIDUMP_SYSTEM_INFO.ProcessorRevision"]/*' />
    public ushort ProcessorRevision;

    /// <include file='MINIDUMP_SYSTEM_INFO.xml' path='doc/member[@name="MINIDUMP_SYSTEM_INFO.Anonymous1"]/*' />
    [NativeTypeName("__AnonymousRecord_minidumpapiset_L245_C5")]
    public _Anonymous1_e__Union Anonymous1;

    /// <include file='MINIDUMP_SYSTEM_INFO.xml' path='doc/member[@name="MINIDUMP_SYSTEM_INFO.MajorVersion"]/*' />
    [NativeTypeName("ULONG32")]
    public uint MajorVersion;

    /// <include file='MINIDUMP_SYSTEM_INFO.xml' path='doc/member[@name="MINIDUMP_SYSTEM_INFO.MinorVersion"]/*' />
    [NativeTypeName("ULONG32")]
    public uint MinorVersion;

    /// <include file='MINIDUMP_SYSTEM_INFO.xml' path='doc/member[@name="MINIDUMP_SYSTEM_INFO.BuildNumber"]/*' />
    [NativeTypeName("ULONG32")]
    public uint BuildNumber;

    /// <include file='MINIDUMP_SYSTEM_INFO.xml' path='doc/member[@name="MINIDUMP_SYSTEM_INFO.PlatformId"]/*' />
    [NativeTypeName("ULONG32")]
    public uint PlatformId;

    /// <include file='MINIDUMP_SYSTEM_INFO.xml' path='doc/member[@name="MINIDUMP_SYSTEM_INFO.CSDVersionRva"]/*' />
    [NativeTypeName("RVA")]
    public uint CSDVersionRva;

    /// <include file='MINIDUMP_SYSTEM_INFO.xml' path='doc/member[@name="MINIDUMP_SYSTEM_INFO.Anonymous2"]/*' />
    [NativeTypeName("__AnonymousRecord_minidumpapiset_L270_C5")]
    public _Anonymous2_e__Union Anonymous2;

    /// <include file='MINIDUMP_SYSTEM_INFO.xml' path='doc/member[@name="MINIDUMP_SYSTEM_INFO.Cpu"]/*' />
    public CPU_INFORMATION Cpu;

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Reserved0"]/*' />
    [UnscopedRef]
    public ref ushort Reserved0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Reserved0;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.NumberOfProcessors"]/*' />
    [UnscopedRef]
    public ref byte NumberOfProcessors
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous.NumberOfProcessors;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ProductType"]/*' />
    [UnscopedRef]
    public ref byte ProductType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Anonymous.ProductType;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Reserved1"]/*' />
    [UnscopedRef]
    public ref uint Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Reserved1;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.SuiteMask"]/*' />
    [UnscopedRef]
    public ref ushort SuiteMask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Anonymous.SuiteMask;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved2"]/*' />
    [UnscopedRef]
    public ref ushort Reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Anonymous.Reserved2;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Reserved0"]/*' />
        [FieldOffset(0)]
        public ushort Reserved0;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_minidumpapiset_L247_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.NumberOfProcessors"]/*' />
            [NativeTypeName("UCHAR")]
            public byte NumberOfProcessors;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ProductType"]/*' />
            [NativeTypeName("UCHAR")]
            public byte ProductType;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Reserved1"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("ULONG32")]
        public uint Reserved1;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_minidumpapiset_L272_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.SuiteMask"]/*' />
            public ushort SuiteMask;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved2"]/*' />
            public ushort Reserved2;
        }
    }
}
