// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct MIB_IPNETROW_W2K
{
    [NativeTypeName("IF_INDEX")]
    public uint dwIndex;

    [NativeTypeName("DWORD")]
    public uint dwPhysAddrLen;

    [NativeTypeName("UCHAR [8]")]
    public fixed byte bPhysAddr[8];

    [NativeTypeName("DWORD")]
    public uint dwAddr;

    [NativeTypeName("DWORD")]
    public uint dwType;
}
