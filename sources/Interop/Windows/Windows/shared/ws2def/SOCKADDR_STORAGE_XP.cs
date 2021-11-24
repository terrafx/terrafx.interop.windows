// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct SOCKADDR_STORAGE_XP
{
    public short ss_family;

    [NativeTypeName("CHAR [6]")]
    public fixed sbyte __ss_pad1[6];

    [NativeTypeName("long long")]
    public long __ss_align;

    [NativeTypeName("CHAR [112]")]
    public fixed sbyte __ss_pad2[112];
}
