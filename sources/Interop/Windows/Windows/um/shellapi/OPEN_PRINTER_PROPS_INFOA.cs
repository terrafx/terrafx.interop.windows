// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='OPEN_PRINTER_PROPS_INFOA.xml' path='doc/member[@name="OPEN_PRINTER_PROPS_INFOA"]/*' />
public unsafe partial struct OPEN_PRINTER_PROPS_INFOA
{
    /// <include file='OPEN_PRINTER_PROPS_INFOA.xml' path='doc/member[@name="OPEN_PRINTER_PROPS_INFOA.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='OPEN_PRINTER_PROPS_INFOA.xml' path='doc/member[@name="OPEN_PRINTER_PROPS_INFOA.pszSheetName"]/*' />
    [NativeTypeName("LPSTR")]
    public sbyte* pszSheetName;

    /// <include file='OPEN_PRINTER_PROPS_INFOA.xml' path='doc/member[@name="OPEN_PRINTER_PROPS_INFOA.uSheetIndex"]/*' />
    public uint uSheetIndex;

    /// <include file='OPEN_PRINTER_PROPS_INFOA.xml' path='doc/member[@name="OPEN_PRINTER_PROPS_INFOA.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='OPEN_PRINTER_PROPS_INFOA.xml' path='doc/member[@name="OPEN_PRINTER_PROPS_INFOA.bModal"]/*' />
    public BOOL bModal;
}
