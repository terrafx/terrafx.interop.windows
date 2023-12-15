// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='NMDATETIMEFORMATW.xml' path='doc/member[@name="NMDATETIMEFORMATW"]/*' />
public unsafe partial struct NMDATETIMEFORMATW
{
    /// <include file='NMDATETIMEFORMATW.xml' path='doc/member[@name="NMDATETIMEFORMATW.nmhdr"]/*' />
    public NMHDR nmhdr;

    /// <include file='NMDATETIMEFORMATW.xml' path='doc/member[@name="NMDATETIMEFORMATW.pszFormat"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pszFormat;

    /// <include file='NMDATETIMEFORMATW.xml' path='doc/member[@name="NMDATETIMEFORMATW.st"]/*' />
    public SYSTEMTIME st;

    /// <include file='NMDATETIMEFORMATW.xml' path='doc/member[@name="NMDATETIMEFORMATW.pszDisplay"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* pszDisplay;

    /// <include file='NMDATETIMEFORMATW.xml' path='doc/member[@name="NMDATETIMEFORMATW.szDisplay"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _szDisplay_e__FixedBuffer szDisplay;

    /// <include file='_szDisplay_e__FixedBuffer.xml' path='doc/member[@name="_szDisplay_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szDisplay_e__FixedBuffer
    {
        public char e0;
    }
}
