// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct GROUP_POLICY_OBJECTW
{
    [NativeTypeName("DWORD")]
    public uint dwOptions;

    [NativeTypeName("DWORD")]
    public uint dwVersion;

    [NativeTypeName("LPWSTR")]
    public ushort* lpDSPath;

    [NativeTypeName("LPWSTR")]
    public ushort* lpFileSysPath;

    [NativeTypeName("LPWSTR")]
    public ushort* lpDisplayName;

    [NativeTypeName("WCHAR [50]")]
    public fixed ushort szGPOName[50];

    public GPO_LINK GPOLink;

    public LPARAM lParam;

    [NativeTypeName("struct _GROUP_POLICY_OBJECTW *")]
    public GROUP_POLICY_OBJECTW* pNext;

    [NativeTypeName("struct _GROUP_POLICY_OBJECTW *")]
    public GROUP_POLICY_OBJECTW* pPrev;

    [NativeTypeName("LPWSTR")]
    public ushort* lpExtensions;

    public LPARAM lParam2;

    [NativeTypeName("LPWSTR")]
    public ushort* lpLink;
}
