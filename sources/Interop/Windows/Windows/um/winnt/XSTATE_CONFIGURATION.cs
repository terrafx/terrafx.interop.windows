// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
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

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.Anonymous1"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L14867_C5")]
    public _Anonymous1_e__Union Anonymous1;

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

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.Anonymous2"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L14901_C5")]
    public _Anonymous2_e__Union Anonymous2;

    /// <include file='XSTATE_CONFIGURATION.xml' path='doc/member[@name="XSTATE_CONFIGURATION.Spare"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Spare;

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.ControlFlags"]/*' />
    [UnscopedRef]
    public ref uint ControlFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.ControlFlags;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.OptimizedSave"]/*' />
    public uint OptimizedSave
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous1.Anonymous.OptimizedSave;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous1.Anonymous.OptimizedSave = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.CompactionEnabled"]/*' />
    public uint CompactionEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous1.Anonymous.CompactionEnabled;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous1.Anonymous.CompactionEnabled = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ExtendedFeatureDisable"]/*' />
    public uint ExtendedFeatureDisable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous1.Anonymous.ExtendedFeatureDisable;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous1.Anonymous.ExtendedFeatureDisable = value;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.Amd64Spare1"]/*' />
    [UnscopedRef]
    public Span<uint> Amd64Spare1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous2.Anonymous1.Amd64Spare1;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.MaxSveVectorLength"]/*' />
    [UnscopedRef]
    public ref ushort MaxSveVectorLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Anonymous2.MaxSveVectorLength;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.MaxSmeVectorLength"]/*' />
    [UnscopedRef]
    public ref ushort MaxSmeVectorLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Anonymous2.MaxSmeVectorLength;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.SmeZTRegisterCount"]/*' />
    [UnscopedRef]
    public ref ushort SmeZTRegisterCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Anonymous2.SmeZTRegisterCount;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Arm64Flags"]/*' />
    [UnscopedRef]
    public ref ushort Arm64Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Anonymous2.Anonymous.Arm64Flags;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.SmeFa64"]/*' />
    public ushort SmeFa64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous2.Anonymous2.Anonymous.Anonymous.SmeFa64;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous2.Anonymous2.Anonymous.Anonymous.SmeFa64 = value;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.SupportedSmeVectorLengths"]/*' />
    [UnscopedRef]
    public ref byte SupportedSmeVectorLengths
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Anonymous2.SupportedSmeVectorLengths;
        }
    }

    /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.Arm64Spare"]/*' />
    [UnscopedRef]
    public Span<byte> Arm64Spare
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous2.Anonymous2.Arm64Spare;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.ControlFlags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint ControlFlags;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L14869_C9")]
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

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Anonymous1"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L14903_C9")]
        public _Anonymous1_e__Struct Anonymous1;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Anonymous2"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L14908_C9")]
        public _Anonymous2_e__Struct Anonymous2;

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct"]/*' />
        public partial struct _Anonymous1_e__Struct
        {
            /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.Amd64Spare1"]/*' />
            [NativeTypeName("DWORD[3]")]
            public _Amd64Spare1_e__FixedBuffer Amd64Spare1;

            /// <include file='_Amd64Spare1_e__FixedBuffer.xml' path='doc/member[@name="_Amd64Spare1_e__FixedBuffer"]/*' />
            [InlineArray(3)]
            public partial struct _Amd64Spare1_e__FixedBuffer
            {
                public uint e0;
            }
        }

        /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct"]/*' />
        public partial struct _Anonymous2_e__Struct
        {
            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.MaxSveVectorLength"]/*' />
            [NativeTypeName("WORD")]
            public ushort MaxSveVectorLength;

            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.MaxSmeVectorLength"]/*' />
            [NativeTypeName("WORD")]
            public ushort MaxSmeVectorLength;

            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.SmeZTRegisterCount"]/*' />
            [NativeTypeName("WORD")]
            public ushort SmeZTRegisterCount;

            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.Anonymous"]/*' />
            [NativeTypeName("__AnonymousRecord_winnt_L14920_C13")]
            public _Anonymous_e__Union Anonymous;

            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.SupportedSmeVectorLengths"]/*' />
            public byte SupportedSmeVectorLengths;

            /// <include file='_Anonymous2_e__Struct.xml' path='doc/member[@name="_Anonymous2_e__Struct.Arm64Spare"]/*' />
            [NativeTypeName("BYTE[3]")]
            public _Arm64Spare_e__FixedBuffer Arm64Spare;

            /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
            [StructLayout(LayoutKind.Explicit)]
            public partial struct _Anonymous_e__Union
            {
                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Arm64Flags"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("WORD")]
                public ushort Arm64Flags;

                /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
                [FieldOffset(0)]
                [NativeTypeName("__AnonymousRecord_winnt_L14922_C17")]
                public _Anonymous_e__Struct Anonymous;

                /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
                public partial struct _Anonymous_e__Struct
                {
                    public ushort _bitfield;

                    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.SmeFa64"]/*' />
                    [NativeTypeName("WORD : 1")]
                    public ushort SmeFa64
                    {
                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        readonly get
                        {
                            return (ushort)(_bitfield & 0x1u);
                        }

                        [MethodImpl(MethodImplOptions.AggressiveInlining)]
                        set
                        {
                            _bitfield = (ushort)((_bitfield & ~0x1u) | (value & 0x1u));
                        }
                    }
                }
            }

            /// <include file='_Arm64Spare_e__FixedBuffer.xml' path='doc/member[@name="_Arm64Spare_e__FixedBuffer"]/*' />
            [InlineArray(3)]
            public partial struct _Arm64Spare_e__FixedBuffer
            {
                public byte e0;
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
