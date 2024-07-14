// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2.xml' path='doc/member[@name="DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2"]/*' />
public partial struct DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2
{
    /// <include file='DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2.xml' path='doc/member[@name="DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2.header"]/*' />
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

    /// <include file='DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2.xml' path='doc/member[@name="DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_wingdi_L3215_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2.xml' path='doc/member[@name="DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2.colorEncoding"]/*' />
    public DISPLAYCONFIG_COLOR_ENCODING colorEncoding;

    /// <include file='DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2.xml' path='doc/member[@name="DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2.bitsPerColorChannel"]/*' />
    [NativeTypeName("UINT32")]
    public uint bitsPerColorChannel;

    /// <include file='DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2.xml' path='doc/member[@name="DISPLAYCONFIG_GET_ADVANCED_COLOR_INFO_2.activeColorMode"]/*' />
    public DISPLAYCONFIG_ADVANCED_COLOR_MODE activeColorMode;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.advancedColorSupported"]/*' />
    public uint advancedColorSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.advancedColorSupported;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.advancedColorSupported = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.advancedColorActive"]/*' />
    public uint advancedColorActive
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.advancedColorActive;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.advancedColorActive = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved1"]/*' />
    public uint reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.reserved1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.reserved1 = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.advancedColorLimitedByPolicy"]/*' />
    public uint advancedColorLimitedByPolicy
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.advancedColorLimitedByPolicy;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.advancedColorLimitedByPolicy = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.highDynamicRangeSupported"]/*' />
    public uint highDynamicRangeSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.highDynamicRangeSupported;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.highDynamicRangeSupported = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.highDynamicRangeUserEnabled"]/*' />
    public uint highDynamicRangeUserEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.highDynamicRangeUserEnabled;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.highDynamicRangeUserEnabled = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wideColorSupported"]/*' />
    public uint wideColorSupported
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.wideColorSupported;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.wideColorSupported = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wideColorUserEnabled"]/*' />
    public uint wideColorUserEnabled
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.wideColorUserEnabled;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.wideColorUserEnabled = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved"]/*' />
    public uint reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.reserved;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.reserved = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.value"]/*' />
    [UnscopedRef]
    public ref uint value
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wingdi_L3217_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.value"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint value;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.advancedColorSupported"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint advancedColorSupported
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.advancedColorActive"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint advancedColorActive
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved1"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint reserved1
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.advancedColorLimitedByPolicy"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint advancedColorLimitedByPolicy
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 3) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.highDynamicRangeSupported"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint highDynamicRangeSupported
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 4) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.highDynamicRangeUserEnabled"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint highDynamicRangeUserEnabled
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 5) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wideColorSupported"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint wideColorSupported
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 6) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.wideColorUserEnabled"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint wideColorUserEnabled
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 7) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved"]/*' />
            [NativeTypeName("UINT32 : 24")]
            public uint reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 8) & 0xFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0xFFFFFFu << 8)) | ((value & 0xFFFFFFu) << 8);
                }
            }
        }
    }
}
