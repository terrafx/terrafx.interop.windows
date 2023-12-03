// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER"]/*' />
public partial struct FILE_QUERY_ON_DISK_VOL_INFO_BUFFER
{
    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.DirectoryCount"]/*' />
    public LARGE_INTEGER DirectoryCount;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.FileCount"]/*' />
    public LARGE_INTEGER FileCount;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.FsFormatMajVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort FsFormatMajVersion;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.FsFormatMinVersion"]/*' />
    [NativeTypeName("WORD")]
    public ushort FsFormatMinVersion;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.FsFormatName"]/*' />
    [NativeTypeName("WCHAR[12]")]
    public _FsFormatName_e__FixedBuffer FsFormatName;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.FormatTime"]/*' />
    public LARGE_INTEGER FormatTime;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.LastUpdateTime"]/*' />
    public LARGE_INTEGER LastUpdateTime;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.CopyrightInfo"]/*' />
    [NativeTypeName("WCHAR[34]")]
    public _CopyrightInfo_e__FixedBuffer CopyrightInfo;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.AbstractInfo"]/*' />
    [NativeTypeName("WCHAR[34]")]
    public _AbstractInfo_e__FixedBuffer AbstractInfo;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.FormattingImplementationInfo"]/*' />
    [NativeTypeName("WCHAR[34]")]
    public _FormattingImplementationInfo_e__FixedBuffer FormattingImplementationInfo;

    /// <include file='FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.xml' path='doc/member[@name="FILE_QUERY_ON_DISK_VOL_INFO_BUFFER.LastModifyingImplementationInfo"]/*' />
    [NativeTypeName("WCHAR[34]")]
    public _LastModifyingImplementationInfo_e__FixedBuffer LastModifyingImplementationInfo;

    /// <include file='_FsFormatName_e__FixedBuffer.xml' path='doc/member[@name="_FsFormatName_e__FixedBuffer"]/*' />
    [InlineArray(12)]
    public partial struct _FsFormatName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_CopyrightInfo_e__FixedBuffer.xml' path='doc/member[@name="_CopyrightInfo_e__FixedBuffer"]/*' />
    [InlineArray(34)]
    public partial struct _CopyrightInfo_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_AbstractInfo_e__FixedBuffer.xml' path='doc/member[@name="_AbstractInfo_e__FixedBuffer"]/*' />
    [InlineArray(34)]
    public partial struct _AbstractInfo_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_FormattingImplementationInfo_e__FixedBuffer.xml' path='doc/member[@name="_FormattingImplementationInfo_e__FixedBuffer"]/*' />
    [InlineArray(34)]
    public partial struct _FormattingImplementationInfo_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_LastModifyingImplementationInfo_e__FixedBuffer.xml' path='doc/member[@name="_LastModifyingImplementationInfo_e__FixedBuffer"]/*' />
    [InlineArray(34)]
    public partial struct _LastModifyingImplementationInfo_e__FixedBuffer
    {
        public char e0;
    }
}
