// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='_SECURITY_ANTITAMPER_POLICY_MODULES.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_POLICY_MODULES"]/*' />
public unsafe partial struct _SECURITY_ANTITAMPER_POLICY_MODULES
{
    /// <include file='_SECURITY_ANTITAMPER_POLICY_MODULES.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_POLICY_MODULES.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L13694_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_SECURITY_ANTITAMPER_POLICY_MODULES.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_POLICY_MODULES.AllowedModuleCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint AllowedModuleCount;

    /// <include file='_SECURITY_ANTITAMPER_POLICY_MODULES.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_POLICY_MODULES.AllowedModules"]/*' />
    [NativeTypeName("PSECURITY_ANTITAMPER_MODULE_IDENTIFIER")]
    public _SECURITY_ANTITAMPER_MODULE_IDENTIFIER* AllowedModules;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Flags"]/*' />
    [UnscopedRef]
    public ref uint Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Flags;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RestrictModules"]/*' />
    public uint RestrictModules
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.RestrictModules;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.RestrictModules = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*' />
    public uint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.Reserved;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.Reserved = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Flags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Flags;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L13696_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.RestrictModules"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint RestrictModules
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
