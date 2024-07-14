// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR"]/*' />
public partial struct STORAGE_MINIPORT_DESCRIPTOR
{
    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Portdriver"]/*' />
    public STORAGE_PORT_CODE_SET Portdriver;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.LUNResetSupported"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte LUNResetSupported;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.TargetResetSupported"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte TargetResetSupported;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.IoTimeoutValue"]/*' />
    [NativeTypeName("WORD")]
    public ushort IoTimeoutValue;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.ExtraIoInfoSupported"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte ExtraIoInfoSupported;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Flags"]/*' />
    [NativeTypeName("__AnonymousRecord_winioctl_L1483_C5")]
    public _Flags_e__Union Flags;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Reserved0"]/*' />
    [NativeTypeName("BYTE[2]")]
    public _Reserved0_e__FixedBuffer Reserved0;

    /// <include file='STORAGE_MINIPORT_DESCRIPTOR.xml' path='doc/member[@name="STORAGE_MINIPORT_DESCRIPTOR.Reserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved1;

    /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Flags_e__Union
    {
        /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L1484_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.AsBYTE"]/*' />
        [FieldOffset(0)]
        public byte AsBYTE;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.LogicalPoFxForDisk"]/*' />
        public byte LogicalPoFxForDisk
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.LogicalPoFxForDisk;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.LogicalPoFxForDisk = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ForwardIo"]/*' />
        public byte ForwardIo
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.ForwardIo;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.ForwardIo = value;
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.LogicalPoFxForDisk"]/*' />
            [NativeTypeName("byte : 1")]
            public byte LogicalPoFxForDisk
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ForwardIo"]/*' />
            [NativeTypeName("byte : 1")]
            public byte ForwardIo
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

    /// <include file='_Reserved0_e__FixedBuffer.xml' path='doc/member[@name="_Reserved0_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _Reserved0_e__FixedBuffer
    {
        public byte e0;
    }
}
