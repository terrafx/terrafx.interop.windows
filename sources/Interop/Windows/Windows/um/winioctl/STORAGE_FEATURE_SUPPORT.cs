// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='STORAGE_FEATURE_SUPPORT.xml' path='doc/member[@name="STORAGE_FEATURE_SUPPORT"]/*' />
public partial struct STORAGE_FEATURE_SUPPORT
{
    /// <include file='STORAGE_FEATURE_SUPPORT.xml' path='doc/member[@name="STORAGE_FEATURE_SUPPORT.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='STORAGE_FEATURE_SUPPORT.xml' path='doc/member[@name="STORAGE_FEATURE_SUPPORT.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='STORAGE_FEATURE_SUPPORT.xml' path='doc/member[@name="STORAGE_FEATURE_SUPPORT.Flags"]/*' />
    [NativeTypeName("__AnonymousRecord_winioctl_L586_C5")]
    public _Flags_e__Union Flags;

    /// <include file='STORAGE_FEATURE_SUPPORT.xml' path='doc/member[@name="STORAGE_FEATURE_SUPPORT.Reserved"]/*' />
    [NativeTypeName("DWORDLONG[6]")]
    public _Reserved_e__FixedBuffer Reserved;

    /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Flags_e__Union
    {
        /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winioctl_L588_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.AsUlonglong"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORDLONG")]
        public ulong AsUlonglong;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.StorMQMiniportsSupported"]/*' />
        public ulong StorMQMiniportsSupported
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.StorMQMiniportsSupported;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.StorMQMiniportsSupported = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
        public ulong Reserved
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
            public ulong _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.StorMQMiniportsSupported"]/*' />
            [NativeTypeName("DWORDLONG : 1")]
            public ulong StorMQMiniportsSupported
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return _bitfield & 0x1UL;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0x1UL) | (value & 0x1UL);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
            [NativeTypeName("DWORDLONG : 63")]
            public ulong Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 1) & 0x7FFFFFFFUL;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x7FFFFFFFUL << 1)) | ((value & 0x7FFFFFFFUL) << 1);
                }
            }
        }
    }

    /// <include file='_Reserved_e__FixedBuffer.xml' path='doc/member[@name="_Reserved_e__FixedBuffer"]/*' />
    [InlineArray(6)]
    public partial struct _Reserved_e__FixedBuffer
    {
        public ulong e0;
    }
}
