// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct SE_ACCESS_REPLY
{
    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint ResultListCount;

    [NativeTypeName("PACCESS_MASK")]
    public uint* GrantedAccess;

    [NativeTypeName("PDWORD")]
    public uint* AccessStatus;

    [NativeTypeName("PACCESS_REASONS")]
    public ACCESS_REASONS* AccessReason;

    [NativeTypeName("PPRIVILEGE_SET *")]
    public PRIVILEGE_SET** Privileges;
}
