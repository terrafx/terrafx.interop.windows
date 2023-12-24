// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA"]/*' />
public partial struct WIN32_FIND_DATAA
{
    /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.dwFileAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFileAttributes;

    /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.ftCreationTime"]/*' />
    public FILETIME ftCreationTime;

    /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.ftLastAccessTime"]/*' />
    public FILETIME ftLastAccessTime;

    /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.ftLastWriteTime"]/*' />
    public FILETIME ftLastWriteTime;

    /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.nFileSizeHigh"]/*' />
    [NativeTypeName("DWORD")]
    public uint nFileSizeHigh;

    /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.nFileSizeLow"]/*' />
    [NativeTypeName("DWORD")]
    public uint nFileSizeLow;

    /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.dwReserved0"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved0;

    /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.dwReserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwReserved1;

    /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.cFileName"]/*' />
    [NativeTypeName("CHAR[260]")]
    public _cFileName_e__FixedBuffer cFileName;

    /// <include file='WIN32_FIND_DATAA.xml' path='doc/member[@name="WIN32_FIND_DATAA.cAlternateFileName"]/*' />
    [NativeTypeName("CHAR[14]")]
    public _cAlternateFileName_e__FixedBuffer cAlternateFileName;

    /// <include file='_cFileName_e__FixedBuffer.xml' path='doc/member[@name="_cFileName_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _cFileName_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_cAlternateFileName_e__FixedBuffer.xml' path='doc/member[@name="_cAlternateFileName_e__FixedBuffer"]/*' />
    [InlineArray(14)]
    public partial struct _cAlternateFileName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
