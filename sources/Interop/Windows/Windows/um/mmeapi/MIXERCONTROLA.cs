// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIXERCONTROLA
{
    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.dwControlID"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwControlID;

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.dwControlType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwControlType;

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.fdwControl"]/*' />
    [NativeTypeName("DWORD")]
    public uint fdwControl;

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.cMultipleItems"]/*' />
    [NativeTypeName("DWORD")]
    public uint cMultipleItems;

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.szShortName"]/*' />
    [NativeTypeName("CHAR[16]")]
    public fixed sbyte szShortName[16];

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.szName"]/*' />
    [NativeTypeName("CHAR[64]")]
    public fixed sbyte szName[64];

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.Bounds"]/*' />
    [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/mmeapi.h:2056:5)")]
    public _Bounds_e__Union Bounds;

    /// <include file='MIXERCONTROLA.xml' path='doc/member[@name="MIXERCONTROLA.Metrics"]/*' />
    [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/mmeapi.h:2067:5)")]
    public _Metrics_e__Union Metrics;

    /// <include file='_Bounds_e__Union.xml' path='doc/member[@name="_Bounds_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public unsafe partial struct _Bounds_e__Union
    {
        /// <include file='_Bounds_e__Union.xml' path='doc/member[@name="_Bounds_e__Union.Anonymous1"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("tagMIXERCONTROLA::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/mmeapi.h:2057:9)")]
        public _Anonymous1_e__Struct Anonymous1;

        /// <include file='_Bounds_e__Union.xml' path='doc/member[@name="_Bounds_e__Union.Anonymous2"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("tagMIXERCONTROLA::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/mmeapi.h:2061:9)")]
        public _Anonymous2_e__Struct Anonymous2;

        /// <include file='_Bounds_e__Union.xml' path='doc/member[@name="_Bounds_e__Union.dwReserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD[6]")]
        public fixed uint dwReserved[6];

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.lMinimum"]/*' />
        public ref int lMinimum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.lMinimum, 1));
            }
        }

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.lMaximum"]/*' />
        public ref int lMaximum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous1.lMaximum, 1));
            }
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dwMinimum"]/*' />
        public ref uint dwMinimum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwMinimum, 1));
            }
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dwMaximum"]/*' />
        public ref uint dwMaximum
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous2.dwMaximum, 1));
            }
        }

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _Anonymous1_e__Struct
        {
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.lMinimum"]/*' />
            [NativeTypeName("LONG")]
            public int lMinimum;

            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.lMaximum"]/*' />
            [NativeTypeName("LONG")]
            public int lMaximum;
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _Anonymous2_e__Struct
        {
            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dwMinimum"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwMinimum;

            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.dwMaximum"]/*' />
            [NativeTypeName("DWORD")]
            public uint dwMaximum;
        }
    }

    /// <include file='_Metrics_e__Union.xml' path='doc/member[@name="_Metrics_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public unsafe partial struct _Metrics_e__Union
    {
        /// <include file='_Metrics_e__Union.xml' path='doc/member[@name="_Metrics_e__Union.cSteps"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cSteps;

        /// <include file='_Metrics_e__Union.xml' path='doc/member[@name="_Metrics_e__Union.cbCustomData"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cbCustomData;

        /// <include file='_Metrics_e__Union.xml' path='doc/member[@name="_Metrics_e__Union.dwReserved"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD[6]")]
        public fixed uint dwReserved[6];
    }
}
