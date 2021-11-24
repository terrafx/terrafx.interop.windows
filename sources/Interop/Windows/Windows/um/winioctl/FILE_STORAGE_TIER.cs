// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public unsafe partial struct FILE_STORAGE_TIER
{
    public Guid Id;

    [NativeTypeName("WCHAR [256]")]
    public fixed ushort Name[256];

    [NativeTypeName("WCHAR [256]")]
    public fixed ushort Description[256];

    [NativeTypeName("DWORDLONG")]
    public ulong Flags;

    [NativeTypeName("DWORDLONG")]
    public ulong ProvisionedCapacity;

    public FILE_STORAGE_TIER_MEDIA_TYPE MediaType;

    public FILE_STORAGE_TIER_CLASS Class;
}
