// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='TBS_CONTEXT_PARAMS2.xml' path='doc/member[@name="TBS_CONTEXT_PARAMS2"]/*' />
[SupportedOSPlatform("windows8.0")]
public partial struct TBS_CONTEXT_PARAMS2
{
    /// <include file='TBS_CONTEXT_PARAMS2.xml' path='doc/member[@name="TBS_CONTEXT_PARAMS2.version"]/*' />
    [NativeTypeName("UINT32")]
    public uint version;

    /// <include file='TBS_CONTEXT_PARAMS2.xml' path='doc/member[@name="TBS_CONTEXT_PARAMS2.Anonymous"]/*' />
    [NativeTypeName("tdTBS_CONTEXT_PARAMS2::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/tbs.h:154:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.requestRaw"]/*' />
    public uint requestRaw
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.requestRaw;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.requestRaw = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.includeTpm12"]/*' />
    public uint includeTpm12
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.includeTpm12;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.includeTpm12 = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.includeTpm20"]/*' />
    public uint includeTpm20
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.includeTpm20;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.includeTpm20 = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.asUINT32"]/*' />
    public ref uint asUINT32
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.asUINT32, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("tdTBS_CONTEXT_PARAMS2::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/tbs.h:156:9)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.asUINT32"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint asUINT32;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.requestRaw"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint requestRaw
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.includeTpm12"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint includeTpm12
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 1) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.includeTpm20"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint includeTpm20
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
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
}
