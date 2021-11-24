// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct IMAGE_ARCHIVE_MEMBER_HEADER
{
    [NativeTypeName("BYTE [16]")]
    public fixed byte Name[16];

    [NativeTypeName("BYTE [12]")]
    public fixed byte Date[12];

    [NativeTypeName("BYTE [6]")]
    public fixed byte UserID[6];

    [NativeTypeName("BYTE [6]")]
    public fixed byte GroupID[6];

    [NativeTypeName("BYTE [8]")]
    public fixed byte Mode[8];

    [NativeTypeName("BYTE [10]")]
    public fixed byte Size[10];

    [NativeTypeName("BYTE [2]")]
    public fixed byte EndHeader[2];
}
