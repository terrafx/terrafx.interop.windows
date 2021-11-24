// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct CABINET_INFO64_W
{
    [NativeTypeName("PCWSTR")]
    public ushort* CabinetPath;

    [NativeTypeName("PCWSTR")]
    public ushort* CabinetFile;

    [NativeTypeName("PCWSTR")]
    public ushort* DiskName;

    [NativeTypeName("USHORT")]
    public ushort SetId;

    [NativeTypeName("USHORT")]
    public ushort CabinetNumber;
}
