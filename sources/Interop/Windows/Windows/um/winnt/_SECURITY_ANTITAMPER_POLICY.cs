// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='_SECURITY_ANTITAMPER_POLICY.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_POLICY"]/*' />
public partial struct _SECURITY_ANTITAMPER_POLICY
{
    /// <include file='_SECURITY_ANTITAMPER_POLICY.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_POLICY.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L13812_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_SECURITY_ANTITAMPER_POLICY.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_POLICY.PolicyPresent"]/*' />
    [NativeTypeName("DWORD")]
    public uint PolicyPresent;

    /// <include file='_SECURITY_ANTITAMPER_POLICY.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_POLICY.Identity"]/*' />
    [NativeTypeName("SECURITY_ANTITAMPER_IDENTITY")]
    public _SECURITY_ANTITAMPER_IDENTITY Identity;

    /// <include file='_SECURITY_ANTITAMPER_POLICY.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_POLICY.GeneralPolicy"]/*' />
    [NativeTypeName("SECURITY_ANTITAMPER_POLICY_GENERAL")]
    public _SECURITY_ISOLATION_CONFIGURATION_GENERAL GeneralPolicy;

    /// <include file='_SECURITY_ANTITAMPER_POLICY.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_POLICY.DebugPolicy"]/*' />
    [NativeTypeName("SECURITY_ANTITAMPER_POLICY_DEBUG")]
    public _SECURITY_ANTITAMPER_POLICY_DEBUG DebugPolicy;

    /// <include file='_SECURITY_ANTITAMPER_POLICY.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_POLICY.UiPolicy"]/*' />
    [NativeTypeName("SECURITY_ANTITAMPER_POLICY_UI")]
    public _SECURITY_ISOLATION_CONFIGURATION_UI UiPolicy;

    /// <include file='_SECURITY_ANTITAMPER_POLICY.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_POLICY.ProcessPolicy"]/*' />
    [NativeTypeName("SECURITY_ANTITAMPER_POLICY_PROCESS")]
    public _SECURITY_ANTITAMPER_POLICY_PROCESS ProcessPolicy;

    /// <include file='_SECURITY_ANTITAMPER_POLICY.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_POLICY.SigningPolicy"]/*' />
    [NativeTypeName("SECURITY_ANTITAMPER_POLICY_SIGNING")]
    public _SECURITY_ANTITAMPER_POLICY_SIGNING SigningPolicy;

    /// <include file='_SECURITY_ANTITAMPER_POLICY.xml' path='doc/member[@name="_SECURITY_ANTITAMPER_POLICY.ModulePolicy"]/*' />
    [NativeTypeName("SECURITY_ANTITAMPER_POLICY_MODULES")]
    public _SECURITY_ANTITAMPER_POLICY_MODULES ModulePolicy;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Version"]/*' />
    [UnscopedRef]
    public ref uint Version
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Version;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MinorVersion"]/*' />
    public uint MinorVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.MinorVersion;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.MinorVersion = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MajorVersion"]/*' />
    public uint MajorVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return Anonymous.Anonymous.MajorVersion;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.MajorVersion = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Version"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Version;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L13814_C9")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MinorVersion"]/*' />
            [NativeTypeName("DWORD : 20")]
            public uint MinorVersion
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return _bitfield & 0xFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0xFFFFFu) | (value & 0xFFFFFu);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.MajorVersion"]/*' />
            [NativeTypeName("DWORD : 12")]
            public uint MajorVersion
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get
                {
                    return (_bitfield >> 20) & 0xFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0xFFFu << 20)) | ((value & 0xFFFu) << 20);
                }
            }
        }
    }
}
