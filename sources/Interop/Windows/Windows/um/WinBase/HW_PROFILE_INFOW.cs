// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct HW_PROFILE_INFOW
{
    [NativeTypeName("DWORD")]
    public uint dwDockInfo;

    [NativeTypeName("WCHAR [39]")]
    public fixed ushort szHwProfileGuid[39];

    [NativeTypeName("WCHAR [80]")]
    public fixed ushort szHwProfileName[80];
}
