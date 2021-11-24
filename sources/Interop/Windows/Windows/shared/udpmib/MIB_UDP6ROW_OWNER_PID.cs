// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/udpmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct MIB_UDP6ROW_OWNER_PID
{
    [NativeTypeName("UCHAR [16]")]
    public fixed byte ucLocalAddr[16];

    [NativeTypeName("DWORD")]
    public uint dwLocalScopeId;

    [NativeTypeName("DWORD")]
    public uint dwLocalPort;

    [NativeTypeName("DWORD")]
    public uint dwOwningPid;
}
