// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct USN_RECORD
{
    [NativeTypeName("DWORD")]
    public uint RecordLength;

    [NativeTypeName("WORD")]
    public ushort MajorVersion;

    [NativeTypeName("WORD")]
    public ushort MinorVersion;

    [NativeTypeName("DWORDLONG")]
    public ulong FileReferenceNumber;

    [NativeTypeName("DWORDLONG")]
    public ulong ParentFileReferenceNumber;

    [NativeTypeName("USN")]
    public long Usn;

    public LARGE_INTEGER TimeStamp;

    [NativeTypeName("DWORD")]
    public uint Reason;

    [NativeTypeName("DWORD")]
    public uint SourceInfo;

    [NativeTypeName("DWORD")]
    public uint SecurityId;

    [NativeTypeName("DWORD")]
    public uint FileAttributes;

    [NativeTypeName("WORD")]
    public ushort FileNameLength;

    [NativeTypeName("WORD")]
    public ushort FileNameOffset;

    [NativeTypeName("WCHAR [1]")]
    public fixed ushort FileName[1];
}
