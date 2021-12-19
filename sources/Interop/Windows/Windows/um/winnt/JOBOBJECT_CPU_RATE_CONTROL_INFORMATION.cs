// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='JOBOBJECT_CPU_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION"]/*' />
[SupportedOSPlatform("windows8.0")]
public partial struct JOBOBJECT_CPU_RATE_CONTROL_INFORMATION
{
    /// <include file='JOBOBJECT_CPU_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION.ControlFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint ControlFlags;

    /// <include file='JOBOBJECT_CPU_RATE_CONTROL_INFORMATION.xml' path='doc/member[@name="JOBOBJECT_CPU_RATE_CONTROL_INFORMATION.Anonymous"]/*' />
    [NativeTypeName("_JOBOBJECT_CPU_RATE_CONTROL_INFORMATION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winnt.h:13215:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CpuRate"]/*' />
    public ref uint CpuRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.CpuRate, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Weight"]/*' />
    public ref uint Weight
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Weight, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MinRate"]/*' />
    public ref ushort MinRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.MinRate, 1));
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MaxRate"]/*' />
    public ref ushort MaxRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Anonymous.MaxRate, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.CpuRate"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint CpuRate;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Weight"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Weight;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("_JOBOBJECT_CPU_RATE_CONTROL_INFORMATION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/winnt.h:13218:9)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MinRate"]/*' />
            [NativeTypeName("WORD")]
            public ushort MinRate;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MaxRate"]/*' />
            [NativeTypeName("WORD")]
            public ushort MaxRate;
        }
    }
}
