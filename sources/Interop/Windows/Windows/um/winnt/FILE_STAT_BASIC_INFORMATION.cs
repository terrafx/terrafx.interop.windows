// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION"]/*' />
public partial struct FILE_STAT_BASIC_INFORMATION
{
    /// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION.FileId"]/*' />
    public LARGE_INTEGER FileId;

    /// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION.CreationTime"]/*' />
    public LARGE_INTEGER CreationTime;

    /// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION.LastAccessTime"]/*' />
    public LARGE_INTEGER LastAccessTime;

    /// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION.LastWriteTime"]/*' />
    public LARGE_INTEGER LastWriteTime;

    /// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION.ChangeTime"]/*' />
    public LARGE_INTEGER ChangeTime;

    /// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION.AllocationSize"]/*' />
    public LARGE_INTEGER AllocationSize;

    /// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION.EndOfFile"]/*' />
    public LARGE_INTEGER EndOfFile;

    /// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION.FileAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint FileAttributes;

    /// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION.ReparseTag"]/*' />
    [NativeTypeName("DWORD")]
    public uint ReparseTag;

    /// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION.NumberOfLinks"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfLinks;

    /// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION.DeviceType"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeviceType;

    /// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION.DeviceCharacteristics"]/*' />
    [NativeTypeName("DWORD")]
    public uint DeviceCharacteristics;

    /// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION.Reserved"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved;

    /// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION.VolumeSerialNumber"]/*' />
    public LARGE_INTEGER VolumeSerialNumber;

    /// <include file='FILE_STAT_BASIC_INFORMATION.xml' path='doc/member[@name="FILE_STAT_BASIC_INFORMATION.FileId128"]/*' />
    public FILE_ID_128 FileId128;
}
