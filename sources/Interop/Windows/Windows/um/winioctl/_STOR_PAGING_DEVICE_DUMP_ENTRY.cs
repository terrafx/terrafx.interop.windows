// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='_STOR_PAGING_DEVICE_DUMP_ENTRY.xml' path='doc/member[@name="_STOR_PAGING_DEVICE_DUMP_ENTRY"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct _STOR_PAGING_DEVICE_DUMP_ENTRY
{
    /// <include file='_STOR_PAGING_DEVICE_DUMP_ENTRY.xml' path='doc/member[@name="_STOR_PAGING_DEVICE_DUMP_ENTRY.MiniportName"]/*' />
    [NativeTypeName("CHAR[33]")]
    public _MiniportName_e__FixedBuffer MiniportName;

    /// <include file='_STOR_PAGING_DEVICE_DUMP_ENTRY.xml' path='doc/member[@name="_STOR_PAGING_DEVICE_DUMP_ENTRY.ModelName"]/*' />
    [NativeTypeName("CHAR[65]")]
    public _ModelName_e__FixedBuffer ModelName;

    /// <include file='_STOR_PAGING_DEVICE_DUMP_ENTRY.xml' path='doc/member[@name="_STOR_PAGING_DEVICE_DUMP_ENTRY.FirmwareRevision"]/*' />
    [NativeTypeName("CHAR[17]")]
    public _FirmwareRevision_e__FixedBuffer FirmwareRevision;

    /// <include file='_STOR_PAGING_DEVICE_DUMP_ENTRY.xml' path='doc/member[@name="_STOR_PAGING_DEVICE_DUMP_ENTRY.PagingPathCount"]/*' />
    [NativeTypeName("WORD")]
    public ushort PagingPathCount;

    /// <include file='_STOR_PAGING_DEVICE_DUMP_ENTRY.xml' path='doc/member[@name="_STOR_PAGING_DEVICE_DUMP_ENTRY.Flags"]/*' />
    [NativeTypeName("__AnonymousRecord_winioctl_L6690_C5")]
    public _Flags_e__Union Flags;

    /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Flags_e__Union
    {
        /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L6691_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.AsUchar"]/*' />
        [FieldOffset(0)]
        public byte AsUchar;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IsBootDevice"]/*' />
        public byte IsBootDevice
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.IsBootDevice;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.IsBootDevice = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IsNativeNVMe"]/*' />
        public byte IsNativeNVMe
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.IsNativeNVMe;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.IsNativeNVMe = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
        public byte Reserved
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
            public byte _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IsBootDevice"]/*' />
            [NativeTypeName("byte : 1")]
            public byte IsBootDevice
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (byte)(_bitfield & 0x1u);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (byte)((_bitfield & ~0x1u) | (value & 0x1u));
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.IsNativeNVMe"]/*' />
            [NativeTypeName("byte : 1")]
            public byte IsNativeNVMe
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (byte)((_bitfield >> 1) & 0x1u);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (byte)((_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1));
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
            [NativeTypeName("byte : 6")]
            public byte Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (byte)((_bitfield >> 2) & 0x3Fu);
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (byte)((_bitfield & ~(0x3Fu << 2)) | ((value & 0x3Fu) << 2));
                }
            }
        }
    }

    /// <include file='_MiniportName_e__FixedBuffer.xml' path='doc/member[@name="_MiniportName_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(33)]
    public partial struct _MiniportName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_ModelName_e__FixedBuffer.xml' path='doc/member[@name="_ModelName_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(65)]
    public partial struct _ModelName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_FirmwareRevision_e__FixedBuffer.xml' path='doc/member[@name="_FirmwareRevision_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(17)]
    public partial struct _FirmwareRevision_e__FixedBuffer
    {
        public sbyte e0;
    }
}
