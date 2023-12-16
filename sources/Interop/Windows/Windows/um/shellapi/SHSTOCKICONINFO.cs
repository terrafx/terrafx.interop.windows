// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SHSTOCKICONINFO.xml' path='doc/member[@name="SHSTOCKICONINFO"]/*' />
public partial struct SHSTOCKICONINFO
{
    /// <include file='SHSTOCKICONINFO.xml' path='doc/member[@name="SHSTOCKICONINFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='SHSTOCKICONINFO.xml' path='doc/member[@name="SHSTOCKICONINFO.hIcon"]/*' />
    public HICON hIcon;

    /// <include file='SHSTOCKICONINFO.xml' path='doc/member[@name="SHSTOCKICONINFO.iSysImageIndex"]/*' />
    public int iSysImageIndex;

    /// <include file='SHSTOCKICONINFO.xml' path='doc/member[@name="SHSTOCKICONINFO.iIcon"]/*' />
    public int iIcon;

    /// <include file='SHSTOCKICONINFO.xml' path='doc/member[@name="SHSTOCKICONINFO.szPath"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szPath_e__FixedBuffer szPath;

    /// <include file='_szPath_e__FixedBuffer.xml' path='doc/member[@name="_szPath_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _szPath_e__FixedBuffer
    {
        public char e0;
    }
}
