// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public unsafe partial struct DDDEVICEIDENTIFIER2
{
    [NativeTypeName("char [512]")]
    public fixed sbyte szDriver[512];

    [NativeTypeName("char [512]")]
    public fixed sbyte szDescription[512];

    public LARGE_INTEGER liDriverVersion;

    [NativeTypeName("DWORD")]
    public uint dwVendorId;

    [NativeTypeName("DWORD")]
    public uint dwDeviceId;

    [NativeTypeName("DWORD")]
    public uint dwSubSysId;

    [NativeTypeName("DWORD")]
    public uint dwRevision;

    public Guid guidDeviceIdentifier;

    [NativeTypeName("DWORD")]
    public uint dwWHQLLevel;
}
