// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='FILE_STAT_INFORMATION.xml' path='doc/member[@name="FILE_STAT_INFORMATION"]/*' />
public partial struct FILE_STAT_INFORMATION
{
    /// <include file='FILE_STAT_INFORMATION.xml' path='doc/member[@name="FILE_STAT_INFORMATION.FileId"]/*' />
    public LARGE_INTEGER FileId;

    /// <include file='FILE_STAT_INFORMATION.xml' path='doc/member[@name="FILE_STAT_INFORMATION.CreationTime"]/*' />
    public LARGE_INTEGER CreationTime;

    /// <include file='FILE_STAT_INFORMATION.xml' path='doc/member[@name="FILE_STAT_INFORMATION.LastAccessTime"]/*' />
    public LARGE_INTEGER LastAccessTime;

    /// <include file='FILE_STAT_INFORMATION.xml' path='doc/member[@name="FILE_STAT_INFORMATION.LastWriteTime"]/*' />
    public LARGE_INTEGER LastWriteTime;

    /// <include file='FILE_STAT_INFORMATION.xml' path='doc/member[@name="FILE_STAT_INFORMATION.ChangeTime"]/*' />
    public LARGE_INTEGER ChangeTime;

    /// <include file='FILE_STAT_INFORMATION.xml' path='doc/member[@name="FILE_STAT_INFORMATION.AllocationSize"]/*' />
    public LARGE_INTEGER AllocationSize;

    /// <include file='FILE_STAT_INFORMATION.xml' path='doc/member[@name="FILE_STAT_INFORMATION.EndOfFile"]/*' />
    public LARGE_INTEGER EndOfFile;

    /// <include file='FILE_STAT_INFORMATION.xml' path='doc/member[@name="FILE_STAT_INFORMATION.FileAttributes"]/*' />
    [NativeTypeName("DWORD")]
    public uint FileAttributes;

    /// <include file='FILE_STAT_INFORMATION.xml' path='doc/member[@name="FILE_STAT_INFORMATION.ReparseTag"]/*' />
    [NativeTypeName("DWORD")]
    public uint ReparseTag;

    /// <include file='FILE_STAT_INFORMATION.xml' path='doc/member[@name="FILE_STAT_INFORMATION.NumberOfLinks"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfLinks;

    /// <include file='FILE_STAT_INFORMATION.xml' path='doc/member[@name="FILE_STAT_INFORMATION.EffectiveAccess"]/*' />
    [NativeTypeName("ACCESS_MASK")]
    public uint EffectiveAccess;
}
