// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_INF_SIGNER_INFO_V2_W.xml' path='doc/member[@name="SP_INF_SIGNER_INFO_V2_W"]/*' />
public partial struct SP_INF_SIGNER_INFO_V2_W
{
    /// <include file='SP_INF_SIGNER_INFO_V2_W.xml' path='doc/member[@name="SP_INF_SIGNER_INFO_V2_W.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_INF_SIGNER_INFO_V2_W.xml' path='doc/member[@name="SP_INF_SIGNER_INFO_V2_W.CatalogFile"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _CatalogFile_e__FixedBuffer CatalogFile;

    /// <include file='SP_INF_SIGNER_INFO_V2_W.xml' path='doc/member[@name="SP_INF_SIGNER_INFO_V2_W.DigitalSigner"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _DigitalSigner_e__FixedBuffer DigitalSigner;

    /// <include file='SP_INF_SIGNER_INFO_V2_W.xml' path='doc/member[@name="SP_INF_SIGNER_INFO_V2_W.DigitalSignerVersion"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _DigitalSignerVersion_e__FixedBuffer DigitalSignerVersion;

    /// <include file='SP_INF_SIGNER_INFO_V2_W.xml' path='doc/member[@name="SP_INF_SIGNER_INFO_V2_W.SignerScore"]/*' />
    [NativeTypeName("DWORD")]
    public uint SignerScore;

    /// <include file='_CatalogFile_e__FixedBuffer.xml' path='doc/member[@name="_CatalogFile_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _CatalogFile_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_DigitalSigner_e__FixedBuffer.xml' path='doc/member[@name="_DigitalSigner_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _DigitalSigner_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_DigitalSignerVersion_e__FixedBuffer.xml' path='doc/member[@name="_DigitalSignerVersion_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _DigitalSignerVersion_e__FixedBuffer
    {
        public char e0;
    }
}
