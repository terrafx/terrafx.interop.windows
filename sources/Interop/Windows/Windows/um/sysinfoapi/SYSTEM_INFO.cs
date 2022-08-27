// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sysinfoapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SYSTEM_INFO.xml' path='doc/member[@name="SYSTEM_INFO"]/*' />
public unsafe partial struct SYSTEM_INFO
{
    /// <include file='SYSTEM_INFO.xml' path='doc/member[@name="SYSTEM_INFO.Anonymous"]/*' />
    [NativeTypeName("_SYSTEM_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/sysinfoapi.h:48:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='SYSTEM_INFO.xml' path='doc/member[@name="SYSTEM_INFO.dwPageSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPageSize;

    /// <include file='SYSTEM_INFO.xml' path='doc/member[@name="SYSTEM_INFO.lpMinimumApplicationAddress"]/*' />
    [NativeTypeName("LPVOID")]
    public void* lpMinimumApplicationAddress;

    /// <include file='SYSTEM_INFO.xml' path='doc/member[@name="SYSTEM_INFO.lpMaximumApplicationAddress"]/*' />
    [NativeTypeName("LPVOID")]
    public void* lpMaximumApplicationAddress;

    /// <include file='SYSTEM_INFO.xml' path='doc/member[@name="SYSTEM_INFO.dwActiveProcessorMask"]/*' />
    [NativeTypeName("DWORD_PTR")]
    public nuint dwActiveProcessorMask;

    /// <include file='SYSTEM_INFO.xml' path='doc/member[@name="SYSTEM_INFO.dwNumberOfProcessors"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwNumberOfProcessors;

    /// <include file='SYSTEM_INFO.xml' path='doc/member[@name="SYSTEM_INFO.dwProcessorType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProcessorType;

    /// <include file='SYSTEM_INFO.xml' path='doc/member[@name="SYSTEM_INFO.dwAllocationGranularity"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAllocationGranularity;

    /// <include file='SYSTEM_INFO.xml' path='doc/member[@name="SYSTEM_INFO.wProcessorLevel"]/*' />
    [NativeTypeName("WORD")]
    public ushort wProcessorLevel;

    /// <include file='SYSTEM_INFO.xml' path='doc/member[@name="SYSTEM_INFO.wProcessorRevision"]/*' />
    [NativeTypeName("WORD")]
    public ushort wProcessorRevision;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwOemId"]/*' />
    [UnscopedRef]
    public ref uint dwOemId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwOemId;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wProcessorArchitecture"]/*' />
    [UnscopedRef]
    public ref ushort wProcessorArchitecture
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.wProcessorArchitecture;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved"]/*' />
    [UnscopedRef]
    public ref ushort wReserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Anonymous.wReserved;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwOemId"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwOemId;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("_SYSTEM_INFO::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/sysinfoapi.h:50:9)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wProcessorArchitecture"]/*' />
            [NativeTypeName("WORD")]
            public ushort wProcessorArchitecture;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wReserved"]/*' />
            [NativeTypeName("WORD")]
            public ushort wReserved;
        }
    }
}
