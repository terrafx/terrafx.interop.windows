// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo"]/*' />
public partial struct SecPkgContext_CipherInfo
{
    /// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo.dwProtocol"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProtocol;

    /// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo.dwCipherSuite"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCipherSuite;

    /// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo.dwBaseCipherSuite"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwBaseCipherSuite;

    /// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo.szCipherSuite"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _szCipherSuite_e__FixedBuffer szCipherSuite;

    /// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo.szCipher"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _szCipher_e__FixedBuffer szCipher;

    /// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo.dwCipherLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCipherLen;

    /// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo.dwCipherBlockLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCipherBlockLen;

    /// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo.szHash"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _szHash_e__FixedBuffer szHash;

    /// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo.dwHashLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHashLen;

    /// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo.szExchange"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _szExchange_e__FixedBuffer szExchange;

    /// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo.dwMinExchangeLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMinExchangeLen;

    /// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo.dwMaxExchangeLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxExchangeLen;

    /// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo.szCertificate"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _szCertificate_e__FixedBuffer szCertificate;

    /// <include file='SecPkgContext_CipherInfo.xml' path='doc/member[@name="SecPkgContext_CipherInfo.dwKeyType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwKeyType;

    /// <include file='_szCipherSuite_e__FixedBuffer.xml' path='doc/member[@name="_szCipherSuite_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szCipherSuite_e__FixedBuffer
    {
        public char e0;
    }

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

    /// <include file='_szCertificate_e__FixedBuffer.xml' path='doc/member[@name="_szCertificate_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szCertificate_e__FixedBuffer
    {
        public char e0;
    }
}
