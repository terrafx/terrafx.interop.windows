// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW"]/*' />
public partial struct WIN32_FIND_DATAW
{
    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.dwFileAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFileAttributes;

    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.ftCreationTime"]/*' />
    public FILETIME ftCreationTime;

    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.ftLastAccessTime"]/*' />
    public FILETIME ftLastAccessTime;

    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.ftLastWriteTime"]/*' />
    public FILETIME ftLastWriteTime;

    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.nFileSizeHigh"]/*' />
    [NativeTypeName("DWORD")]
    public uint nFileSizeHigh;

    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.nFileSizeLow"]/*' />
    [NativeTypeName("DWORD")]
    public uint nFileSizeLow;

    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.dwReserved0"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved0;

    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.dwReserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved1;

    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.cFileName"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _cFileName_e__FixedBuffer cFileName;

    /// <include file='WIN32_FIND_DATAW.xml' path='doc/member[@name="WIN32_FIND_DATAW.cAlternateFileName"]/*' />
    [NativeTypeName("WCHAR[14]")]
    public _cAlternateFileName_e__FixedBuffer cAlternateFileName;

    /// <include file='_cFileName_e__FixedBuffer.xml' path='doc/member[@name="_cFileName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _cFileName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_cAlternateFileName_e__FixedBuffer.xml' path='doc/member[@name="_cAlternateFileName_e__FixedBuffer"]/*' />
    [InlineArray(14)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _cAlternateFileName_e__FixedBuffer
    {
        public char e0;
    }
}
