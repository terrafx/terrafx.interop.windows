// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct ZONEATTRIBUTES
{
    [NativeTypeName("ULONG")]
    public uint cbSize;

    [NativeTypeName("WCHAR [260]")]
    public fixed ushort szDisplayName[260];

    [NativeTypeName("WCHAR [200]")]
    public fixed ushort szDescription[200];

    [NativeTypeName("WCHAR [260]")]
    public fixed ushort szIconPath[260];

    [NativeTypeName("DWORD")]
    public uint dwTemplateMinLevel;

    [NativeTypeName("DWORD")]
    public uint dwTemplateRecommended;

    [NativeTypeName("DWORD")]
    public uint dwTemplateCurrentLevel;

    [NativeTypeName("DWORD")]
    public uint dwFlags;
}
