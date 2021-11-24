// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public partial struct COMBOBOXINFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    public RECT rcItem;

    public RECT rcButton;

    [NativeTypeName("DWORD")]
    public uint stateButton;

    public HWND hwndCombo;

    public HWND hwndItem;

    public HWND hwndList;
}
