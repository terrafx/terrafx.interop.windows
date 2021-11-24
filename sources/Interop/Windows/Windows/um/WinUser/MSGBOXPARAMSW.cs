// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct MSGBOXPARAMSW
{
    public uint cbSize;

    public HWND hwndOwner;

    public HINSTANCE hInstance;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpszText;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpszCaption;

    [NativeTypeName("DWORD")]
    public uint dwStyle;

    [NativeTypeName("LPCWSTR")]
    public ushort* lpszIcon;

    [NativeTypeName("DWORD_PTR")]
    public nuint dwContextHelpId;

    [NativeTypeName("MSGBOXCALLBACK")]
    public delegate* unmanaged<HELPINFO*, void> lpfnMsgBoxCallback;

    [NativeTypeName("DWORD")]
    public uint dwLanguageId;
}
