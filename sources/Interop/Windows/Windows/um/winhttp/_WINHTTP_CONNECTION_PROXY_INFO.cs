// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='_WINHTTP_CONNECTION_PROXY_INFO.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO"]/*' />
public unsafe partial struct _WINHTTP_CONNECTION_PROXY_INFO
{
    /// <include file='_WINHTTP_CONNECTION_PROXY_INFO.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='_WINHTTP_CONNECTION_PROXY_INFO.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO.pwszFriendlyName"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pwszFriendlyName;

    /// <include file='_WINHTTP_CONNECTION_PROXY_INFO.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='_WINHTTP_CONNECTION_PROXY_INFO.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO.Switch"]/*' />
    [NativeTypeName("WINHTTP_CONNECTION_PROXY_INFO_SWITCH")]
    public _WINHTTP_CONNECTION_PROXY_INFO_SWITCH Switch;

    /// <include file='_WINHTTP_CONNECTION_PROXY_INFO.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winhttp_L2350_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Config"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._WINHTTP_CONNECTION_PROXY_INFO_CONFIG Config
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Config;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Script"]/*' />
    [UnscopedRef]
    public ref _Anonymous_e__Union._WINHTTP_CONNECTION_PROXY_INFO_SCRIPT Script
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Script;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Config"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct _WINHTTP_CONNECTION_PROXY_INFO_CONFIG")]
        public _WINHTTP_CONNECTION_PROXY_INFO_CONFIG Config;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Script"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct _WINHTTP_CONNECTION_PROXY_INFO_SCRIPT")]
        public _WINHTTP_CONNECTION_PROXY_INFO_SCRIPT Script;

        /// <include file='_WINHTTP_CONNECTION_PROXY_INFO_CONFIG.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO_CONFIG"]/*' />
        public unsafe partial struct _WINHTTP_CONNECTION_PROXY_INFO_CONFIG
        {
            /// <include file='_WINHTTP_CONNECTION_PROXY_INFO_CONFIG.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO_CONFIG.pwszServer"]/*' />
            [NativeTypeName("WCHAR *")]
            public char* pwszServer;

            /// <include file='_WINHTTP_CONNECTION_PROXY_INFO_CONFIG.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO_CONFIG.pwszUsername"]/*' />
            [NativeTypeName("WCHAR *")]
            public char* pwszUsername;

            /// <include file='_WINHTTP_CONNECTION_PROXY_INFO_CONFIG.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO_CONFIG.pwszPassword"]/*' />
            [NativeTypeName("WCHAR *")]
            public char* pwszPassword;

            /// <include file='_WINHTTP_CONNECTION_PROXY_INFO_CONFIG.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO_CONFIG.pwszException"]/*' />
            [NativeTypeName("WCHAR *")]
            public char* pwszException;

            /// <include file='_WINHTTP_CONNECTION_PROXY_INFO_CONFIG.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO_CONFIG.pwszExtraInfo"]/*' />
            [NativeTypeName("WCHAR *")]
            public char* pwszExtraInfo;

            /// <include file='_WINHTTP_CONNECTION_PROXY_INFO_CONFIG.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO_CONFIG.Port"]/*' />
            [NativeTypeName("WORD")]
            public ushort Port;
        }

        /// <include file='_WINHTTP_CONNECTION_PROXY_INFO_SCRIPT.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO_SCRIPT"]/*' />
        public unsafe partial struct _WINHTTP_CONNECTION_PROXY_INFO_SCRIPT
        {
            /// <include file='_WINHTTP_CONNECTION_PROXY_INFO_SCRIPT.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO_SCRIPT.pwszScript"]/*' />
            [NativeTypeName("WCHAR *")]
            public char* pwszScript;

            /// <include file='_WINHTTP_CONNECTION_PROXY_INFO_SCRIPT.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO_SCRIPT.pwszUsername"]/*' />
            [NativeTypeName("WCHAR *")]
            public char* pwszUsername;

            /// <include file='_WINHTTP_CONNECTION_PROXY_INFO_SCRIPT.xml' path='doc/member[@name="_WINHTTP_CONNECTION_PROXY_INFO_SCRIPT.pwszPassword"]/*' />
            [NativeTypeName("WCHAR *")]
            public char* pwszPassword;
        }
    }
}
