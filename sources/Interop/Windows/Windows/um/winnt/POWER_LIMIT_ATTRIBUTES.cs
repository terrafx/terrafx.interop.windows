// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='POWER_LIMIT_ATTRIBUTES.xml' path='doc/member[@name="POWER_LIMIT_ATTRIBUTES"]/*' />
public partial struct POWER_LIMIT_ATTRIBUTES
{
    /// <include file='POWER_LIMIT_ATTRIBUTES.xml' path='doc/member[@name="POWER_LIMIT_ATTRIBUTES.Type"]/*' />
    public POWER_LIMIT_TYPES Type;

    /// <include file='POWER_LIMIT_ATTRIBUTES.xml' path='doc/member[@name="POWER_LIMIT_ATTRIBUTES.DomainId"]/*' />
    [NativeTypeName("DWORD")]
    public uint DomainId;

    /// <include file='POWER_LIMIT_ATTRIBUTES.xml' path='doc/member[@name="POWER_LIMIT_ATTRIBUTES.MaxValue"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxValue;

    /// <include file='POWER_LIMIT_ATTRIBUTES.xml' path='doc/member[@name="POWER_LIMIT_ATTRIBUTES.MinValue"]/*' />
    [NativeTypeName("DWORD")]
    public uint MinValue;

    /// <include file='POWER_LIMIT_ATTRIBUTES.xml' path='doc/member[@name="POWER_LIMIT_ATTRIBUTES.MinTimeParameter"]/*' />
    [NativeTypeName("DWORD")]
    public uint MinTimeParameter;

    /// <include file='POWER_LIMIT_ATTRIBUTES.xml' path='doc/member[@name="POWER_LIMIT_ATTRIBUTES.MaxTimeParameter"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxTimeParameter;

    /// <include file='POWER_LIMIT_ATTRIBUTES.xml' path='doc/member[@name="POWER_LIMIT_ATTRIBUTES.DefaultACValue"]/*' />
    [NativeTypeName("DWORD")]
    public uint DefaultACValue;

    /// <include file='POWER_LIMIT_ATTRIBUTES.xml' path='doc/member[@name="POWER_LIMIT_ATTRIBUTES.DefaultDCValue"]/*' />
    [NativeTypeName("DWORD")]
    public uint DefaultDCValue;

    /// <include file='POWER_LIMIT_ATTRIBUTES.xml' path='doc/member[@name="POWER_LIMIT_ATTRIBUTES.Flags"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L18435_C5")]
    public _Flags_e__Union Flags;

    /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Flags_e__Union
    {
        /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L18436_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Flags_e__Union.xml' path='doc/member[@name="_Flags_e__Union.AsUlong"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint AsUlong;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.SupportTimeParameter"]/*' />
        public uint SupportTimeParameter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get
            {
                return Anonymous.SupportTimeParameter;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                Anonymous.SupportTimeParameter = value;
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
        public uint Reserved
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
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.SupportTimeParameter"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint SupportTimeParameter
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
            [NativeTypeName("DWORD : 31")]
            public uint Reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
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
