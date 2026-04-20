// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DRIVER_INFO_ENTRY.xml' path='doc/member[@name="DRIVER_INFO_ENTRY"]/*' />
public partial struct DRIVER_INFO_ENTRY
{
    /// <include file='DRIVER_INFO_ENTRY.xml' path='doc/member[@name="DRIVER_INFO_ENTRY.InternalName"]/*' />
    [NativeTypeName("CHAR[32]")]
    public _InternalName_e__FixedBuffer InternalName;

    /// <include file='DRIVER_INFO_ENTRY.xml' path='doc/member[@name="DRIVER_INFO_ENTRY.ImageHashAlgorithm"]/*' />
    [NativeTypeName("UINT16")]
    public ushort ImageHashAlgorithm;

    /// <include file='DRIVER_INFO_ENTRY.xml' path='doc/member[@name="DRIVER_INFO_ENTRY.PublisherThumbprintHashAlgorithm"]/*' />
    [NativeTypeName("UINT16")]
    public ushort PublisherThumbprintHashAlgorithm;

    /// <include file='DRIVER_INFO_ENTRY.xml' path='doc/member[@name="DRIVER_INFO_ENTRY.ImageHashOffset"]/*' />
    [NativeTypeName("UINT32")]
    public uint ImageHashOffset;

    /// <include file='DRIVER_INFO_ENTRY.xml' path='doc/member[@name="DRIVER_INFO_ENTRY.PublisherThumbprintOffset"]/*' />
    [NativeTypeName("UINT32")]
    public uint PublisherThumbprintOffset;

    /// <include file='DRIVER_INFO_ENTRY.xml' path='doc/member[@name="DRIVER_INFO_ENTRY.NumberOfLoadingTimes"]/*' />
    [NativeTypeName("UINT16")]
    public ushort NumberOfLoadingTimes;

    /// <include file='DRIVER_INFO_ENTRY.xml' path='doc/member[@name="DRIVER_INFO_ENTRY.OemNameSize"]/*' />
    [NativeTypeName("UINT16")]
    public ushort OemNameSize;

    /// <include file='DRIVER_INFO_ENTRY.xml' path='doc/member[@name="DRIVER_INFO_ENTRY.OemNameOffset"]/*' />
    [NativeTypeName("UINT32")]
    public uint OemNameOffset;

    /// <include file='DRIVER_INFO_ENTRY.xml' path='doc/member[@name="DRIVER_INFO_ENTRY.Flags"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L15222_C5")]
    public _Flags_e__Union Flags;

    /// <include file='DRIVER_INFO_ENTRY.xml' path='doc/member[@name="DRIVER_INFO_ENTRY.Padding"]/*' />
    [NativeTypeName("UINT16")]
    public ushort Padding;

    /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Flags_e__Union
    {
        /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L15223_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.AsUInt16"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UINT16")]
        public ushort AsUInt16;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Unloaded"]/*' />
        public ushort Unloaded
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.Unloaded;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.Unloaded = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.BootDriver"]/*' />
        public ushort BootDriver
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.BootDriver;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.BootDriver = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.HotPatch"]/*' />
        public ushort HotPatch
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.HotPatch;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.HotPatch = value;
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Unloaded"]/*' />
            [NativeTypeName("UINT16 : 1")]
            public ushort Unloaded
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.BootDriver"]/*' />
            [NativeTypeName("UINT16 : 1")]
            public ushort BootDriver
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.HotPatch"]/*' />
            [NativeTypeName("UINT16 : 1")]
            public ushort HotPatch
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

    /// <include file='_InternalName_e__FixedBuffer.xml' path='doc/member[@name="_InternalName_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    public partial struct _InternalName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
