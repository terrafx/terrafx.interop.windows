// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.0")]
public unsafe partial struct POINTER_DEVICE_INFO
{
    [NativeTypeName("DWORD")]
    public uint displayOrientation;

    public HANDLE device;

    public POINTER_DEVICE_TYPE pointerDeviceType;

    public HMONITOR monitor;

    [NativeTypeName("ULONG")]
    public uint startingCursorId;

    public ushort maxActiveContacts;

    [NativeTypeName("WCHAR [520]")]
    public fixed ushort productString[520];
}
