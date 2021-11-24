// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct THUMBBUTTON
{
    public THUMBBUTTONMASK dwMask;

    public uint iId;

    public uint iBitmap;

    public HICON hIcon;

    [NativeTypeName("WCHAR [260]")]
    public fixed ushort szTip[260];

    public THUMBBUTTONFLAGS dwFlags;
}
