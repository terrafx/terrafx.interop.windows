// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct DEVICEDUMP_SECTION_HEADER
{
    public Guid guidDeviceDataId;

    [NativeTypeName("BYTE [16]")]
    public fixed byte sOrganizationID[16];

    [NativeTypeName("DWORD")]
    public uint dwFirmwareRevision;

    [NativeTypeName("BYTE [32]")]
    public fixed byte sModelNumber[32];

    [NativeTypeName("BYTE [32]")]
    public fixed byte szDeviceManufacturingID[32];

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    [NativeTypeName("DWORD")]
    public uint bRestrictedPrivateDataVersion;

    [NativeTypeName("DWORD")]
    public uint dwFirmwareIssueId;

    [NativeTypeName("BYTE [132]")]
    public fixed byte szIssueDescriptionString[132];
}
