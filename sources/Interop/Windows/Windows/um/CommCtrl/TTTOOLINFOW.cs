// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct TTTOOLINFOW
{
    public uint cbSize;

    public uint uFlags;

    public HWND hwnd;

    [NativeTypeName("UINT_PTR")]
    public nuint uId;

    public RECT rect;

    public HINSTANCE hinst;

    [NativeTypeName("LPWSTR")]
    public ushort* lpszText;

    public LPARAM lParam;

    public void* lpReserved;
}
