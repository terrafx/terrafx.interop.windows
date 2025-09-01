// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION"]/*' />
public partial struct XSTATE_CONFIGURATION
{
    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.EnabledFeatures"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong EnabledFeatures;

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.EnabledVolatileFeatures"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong EnabledVolatileFeatures;

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L14456_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.Features"]/*' />
    [NativeTypeName("XSTATE_FEATURE[64]")]
    public _Features_e__FixedBuffer Features;

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.EnabledSupervisorFeatures"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong EnabledSupervisorFeatures;

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.AlignedFeatures"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong AlignedFeatures;

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.AllFeatureSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint AllFeatureSize;

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.AllFeatures"]/*' />
    [NativeTypeName("DWORD[64]")]
    public _AllFeatures_e__FixedBuffer AllFeatures;

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.EnabledUserVisibleSupervisorFeatures"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong EnabledUserVisibleSupervisorFeatures;

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.ExtendedFeatureDisableFeatures"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong ExtendedFeatureDisableFeatures;

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.AllNonLargeFeatureSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint AllNonLargeFeatureSize;

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.MaxSveVectorLength"]/*' />
    [NativeTypeName("WORD")]
    public ushort MaxSveVectorLength;

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.Spare1"]/*' />
    [NativeTypeName("WORD")]
    public ushort Spare1;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ControlFlags"]/*' />
    [UnscopedRef]
    public ref uint ControlFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ControlFlags;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.OptimizedSave"]/*' />
    public uint OptimizedSave
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.OptimizedSave;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.OptimizedSave = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.CompactionEnabled"]/*' />
    public uint CompactionEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.CompactionEnabled;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.CompactionEnabled = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ExtendedFeatureDisable"]/*' />
    public uint ExtendedFeatureDisable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.ExtendedFeatureDisable;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.ExtendedFeatureDisable = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ControlFlags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint ControlFlags;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L14458_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.OptimizedSave"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint OptimizedSave
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return _bitfield & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.CompactionEnabled"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint CompactionEnabled
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 1) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ExtendedFeatureDisable"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint ExtendedFeatureDisable
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 2) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
                }
            }
        }
    }

    /// <include file='_Features_e__FixedBuffer.xml' path='doc/member[@name="_Features_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _Features_e__FixedBuffer
    {
        public XSTATE_FEATURE e0;
    }

    /// <include file='_AllFeatures_e__FixedBuffer.xml' path='doc/member[@name="_AllFeatures_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _AllFeatures_e__FixedBuffer
    {
        public uint e0;
    }
}
