// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct MULTIKEYHELPW
{
    [NativeTypeName("DWORD")]
    public uint mkSize;

    [NativeTypeName("WCHAR")]
    public ushort mkKeylist;

    [NativeTypeName("WCHAR [1]")]
    public fixed ushort szKeyphrase[1];
}
