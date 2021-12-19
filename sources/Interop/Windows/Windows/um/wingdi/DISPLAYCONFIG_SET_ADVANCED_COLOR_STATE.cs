// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DISPLAYCONFIG_SET_ADVANCED_COLOR_STATE.xml' path='doc/member[@name="DISPLAYCONFIG_SET_ADVANCED_COLOR_STATE"]/*' />
public partial struct DISPLAYCONFIG_SET_ADVANCED_COLOR_STATE
{
    /// <include file='DISPLAYCONFIG_SET_ADVANCED_COLOR_STATE.xml' path='doc/member[@name="DISPLAYCONFIG_SET_ADVANCED_COLOR_STATE.header"]/*' />
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

    /// <include file='DISPLAYCONFIG_SET_ADVANCED_COLOR_STATE.xml' path='doc/member[@name="DISPLAYCONFIG_SET_ADVANCED_COLOR_STATE.Anonymous"]/*' />
    [NativeTypeName("_DISPLAYCONFIG_SET_ADVANCED_COLOR_STATE::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/wingdi.h:3180:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.enableAdvancedColor"]/*' />
    public uint enableAdvancedColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.enableAdvancedColor;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.enableAdvancedColor = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved"]/*' />
    public uint reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
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
    public ref uint value
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.value, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("_DISPLAYCONFIG_SET_ADVANCED_COLOR_STATE::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/wingdi.h:3182:9)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.value"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint value;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.enableAdvancedColor"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint enableAdvancedColor
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved"]/*' />
            [NativeTypeName("UINT32 : 31")]
            public uint reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 1) & 0x7FFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
                }
            }
        }
    }
}
