// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DRIVER_RUNTIME_REPORT.xml' path='doc/member[@name="DRIVER_RUNTIME_REPORT"]/*' />
public partial struct DRIVER_RUNTIME_REPORT
{
    /// <include file='DRIVER_RUNTIME_REPORT.xml' path='doc/member[@name="DRIVER_RUNTIME_REPORT.Header"]/*' />
    public RUNTIME_REPORT_HEADER Header;

    /// <include file='DRIVER_RUNTIME_REPORT.xml' path='doc/member[@name="DRIVER_RUNTIME_REPORT.NumberOfDrivers"]/*' />
    [NativeTypeName("UINT16")]
    public ushort NumberOfDrivers;

    /// <include file='DRIVER_RUNTIME_REPORT.xml' path='doc/member[@name="DRIVER_RUNTIME_REPORT.Flags"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L15265_C5")]
    public _Flags_e__Union Flags;

    /// <include file='DRIVER_RUNTIME_REPORT.xml' path='doc/member[@name="DRIVER_RUNTIME_REPORT.DriverEntries"]/*' />
    [NativeTypeName("DRIVER_INFO_ENTRY[1]")]
    public _DriverEntries_e__FixedBuffer DriverEntries;

    /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Flags_e__Union
    {
        /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L15266_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.AsUInt16"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UINT16")]
        public ushort AsUInt16;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReportOverflowed"]/*' />
        public ushort ReportOverflowed
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.ReportOverflowed;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.ReportOverflowed = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.PartialReport"]/*' />
        public ushort PartialReport
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.PartialReport;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.PartialReport = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IncludeBootDrivers"]/*' />
        public ushort IncludeBootDrivers
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.IncludeBootDrivers;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.IncludeBootDrivers = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
        public ushort Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Reserved;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Reserved = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public ushort _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReportOverflowed"]/*' />
            [NativeTypeName("UINT16 : 1")]
            public ushort ReportOverflowed
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.PartialReport"]/*' />
            [NativeTypeName("UINT16 : 1")]
            public ushort PartialReport
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (ushort)((_bitfield >> 1) & 0x1u);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (ushort)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IncludeBootDrivers"]/*' />
            [NativeTypeName("UINT16 : 1")]
            public ushort IncludeBootDrivers
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (ushort)((_bitfield >> 2) & 0x1u);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (ushort)((_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2));
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
            [NativeTypeName("UINT16 : 13")]
            public ushort Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (ushort)((_bitfield >> 3) & 0x1FFFu);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (ushort)((_bitfield & ~(0x1FFFu << 3)) | ((value & 0x1FFFu) << 3));
                }
            }
        }
    }

    /// <include file='_DriverEntries_e__FixedBuffer.xml' path='doc/member[@name="_DriverEntries_e__FixedBuffer"]/*' />
    public partial struct _DriverEntries_e__FixedBuffer
    {
        public DRIVER_INFO_ENTRY e0;

        [UnscopedRef]
        public ref DRIVER_INFO_ENTRY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<DRIVER_INFO_ENTRY> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
