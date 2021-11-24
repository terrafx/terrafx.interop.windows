// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/tcpmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct MIB_TCP6ROW_OWNER_PID
{
    [NativeTypeName("UCHAR [16]")]
    public fixed byte ucLocalAddr[16];

    [NativeTypeName("DWORD")]
    public uint dwLocalScopeId;

    [NativeTypeName("DWORD")]
    public uint dwLocalPort;

    [NativeTypeName("UCHAR [16]")]
    public fixed byte ucRemoteAddr[16];

    [NativeTypeName("DWORD")]
    public uint dwRemoteScopeId;

    [NativeTypeName("DWORD")]
    public uint dwRemotePort;

    [NativeTypeName("DWORD")]
    public uint dwState;

    [NativeTypeName("DWORD")]
    public uint dwOwningPid;
}
