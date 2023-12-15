// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx"]/*' />
public partial struct SecPkgContext_ConnectionInfoEx
{
    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.dwProtocol"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProtocol;

    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.szCipher"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _szCipher_e__FixedBuffer szCipher;

    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.dwCipherStrength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCipherStrength;

    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.szHash"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _szHash_e__FixedBuffer szHash;

    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.dwHashStrength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHashStrength;

    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.szExchange"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _szExchange_e__FixedBuffer szExchange;

    /// <include file='SecPkgContext_ConnectionInfoEx.xml' path='doc/member[@name="SecPkgContext_ConnectionInfoEx.dwExchStrength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwExchStrength;

    /// <include file='_szCipher_e__FixedBuffer.xml' path='doc/member[@name="_szCipher_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szCipher_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szHash_e__FixedBuffer.xml' path='doc/member[@name="_szHash_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szHash_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szExchange_e__FixedBuffer.xml' path='doc/member[@name="_szExchange_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szExchange_e__FixedBuffer
    {
        public char e0;
    }
}
