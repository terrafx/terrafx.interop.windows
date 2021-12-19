// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct OPEN_PRINTER_PROPS_INFO64A
{
    [NativeTypeName("DWORD")]
    public uint dwSize;

    [NativeTypeName("LPSTR")]
    public sbyte* pszSheetName;

    public uint uSheetIndex;

    [NativeTypeName("DWORD")]
    public uint dwFlags;

    public BOOL bModal;
}
