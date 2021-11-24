// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct OSVERSIONINFOEXW
{
    [NativeTypeName("DWORD")]
    public uint dwOSVersionInfoSize;

    [NativeTypeName("DWORD")]
    public uint dwMajorVersion;

    [NativeTypeName("DWORD")]
    public uint dwMinorVersion;

    [NativeTypeName("DWORD")]
    public uint dwBuildNumber;

    [NativeTypeName("DWORD")]
    public uint dwPlatformId;

    [NativeTypeName("WCHAR [128]")]
    public fixed ushort szCSDVersion[128];

    [NativeTypeName("WORD")]
    public ushort wServicePackMajor;

    [NativeTypeName("WORD")]
    public ushort wServicePackMinor;

    [NativeTypeName("WORD")]
    public ushort wSuiteMask;

    public byte wProductType;

    public byte wReserved;
}
