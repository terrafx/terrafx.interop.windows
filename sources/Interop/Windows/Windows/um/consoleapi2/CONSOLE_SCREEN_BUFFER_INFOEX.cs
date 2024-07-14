// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX"]/*' />
public partial struct CONSOLE_SCREEN_BUFFER_INFOEX
{
    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.cbSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSize;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.dwSize"]/*' />
    public COORD dwSize;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.dwCursorPosition"]/*' />
    public COORD dwCursorPosition;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.wAttributes"]/*' />
    [NativeTypeName("WORD")]
    public ushort wAttributes;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.srWindow"]/*' />
    public SMALL_RECT srWindow;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.dwMaximumWindowSize"]/*' />
    public COORD dwMaximumWindowSize;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.wPopupAttributes"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPopupAttributes;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.bFullscreenSupported"]/*' />
    public BOOL bFullscreenSupported;

    /// <include file='CONSOLE_SCREEN_BUFFER_INFOEX.xml' path='doc/member[@name="CONSOLE_SCREEN_BUFFER_INFOEX.ColorTable"]/*' />
    [NativeTypeName("COLORREF[16]")]
    public _ColorTable_e__FixedBuffer ColorTable;

    /// <include file='_ColorTable_e__FixedBuffer.xml' path='doc/member[@name="_ColorTable_e__FixedBuffer"]/*' />
    [InlineArray(16)]
    public partial struct _ColorTable_e__FixedBuffer
    {
        public COLORREF e0;
    }
}
