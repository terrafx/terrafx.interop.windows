// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SP_ORIGINAL_FILE_INFO_W.xml' path='doc/member[@name="SP_ORIGINAL_FILE_INFO_W"]/*' />
public partial struct SP_ORIGINAL_FILE_INFO_W
{
    /// <include file='SP_ORIGINAL_FILE_INFO_W.xml' path='doc/member[@name="SP_ORIGINAL_FILE_INFO_W.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SP_ORIGINAL_FILE_INFO_W.xml' path='doc/member[@name="SP_ORIGINAL_FILE_INFO_W.OriginalInfName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _OriginalInfName_e__FixedBuffer OriginalInfName;

    /// <include file='SP_ORIGINAL_FILE_INFO_W.xml' path='doc/member[@name="SP_ORIGINAL_FILE_INFO_W.OriginalCatalogName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _OriginalCatalogName_e__FixedBuffer OriginalCatalogName;

    /// <include file='_OriginalInfName_e__FixedBuffer.xml' path='doc/member[@name="_OriginalInfName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _OriginalInfName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_OriginalCatalogName_e__FixedBuffer.xml' path='doc/member[@name="_OriginalCatalogName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _OriginalCatalogName_e__FixedBuffer
    {
        public char e0;
    }
}
