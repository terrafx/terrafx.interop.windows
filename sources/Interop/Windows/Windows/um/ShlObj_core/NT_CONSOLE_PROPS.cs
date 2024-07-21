// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct NT_CONSOLE_PROPS
{
    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.dbh"]/*' />
    public DATABLOCK_HEADER dbh;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.wFillAttribute"]/*' />
    [NativeTypeName("WORD")]
    public ushort wFillAttribute;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.wPopupFillAttribute"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPopupFillAttribute;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.dwScreenBufferSize"]/*' />
    public COORD dwScreenBufferSize;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.dwWindowSize"]/*' />
    public COORD dwWindowSize;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.dwWindowOrigin"]/*' />
    public COORD dwWindowOrigin;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.nFont"]/*' />
    [NativeTypeName("DWORD")]
    public uint nFont;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.nInputBufferSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint nInputBufferSize;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.dwFontSize"]/*' />
    public COORD dwFontSize;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.uFontFamily"]/*' />
    public uint uFontFamily;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.uFontWeight"]/*' />
    public uint uFontWeight;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.FaceName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _FaceName_e__FixedBuffer FaceName;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.uCursorSize"]/*' />
    public uint uCursorSize;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.bFullScreen"]/*' />
    public BOOL bFullScreen;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.bQuickEdit"]/*' />
    public BOOL bQuickEdit;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.bInsertMode"]/*' />
    public BOOL bInsertMode;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.bAutoPosition"]/*' />
    public BOOL bAutoPosition;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.uHistoryBufferSize"]/*' />
    public uint uHistoryBufferSize;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.uNumberOfHistoryBuffers"]/*' />
    public uint uNumberOfHistoryBuffers;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.bHistoryNoDup"]/*' />
    public BOOL bHistoryNoDup;

    /// <include file='NT_CONSOLE_PROPS.xml' path='doc/member[@name="NT_CONSOLE_PROPS.ColorTable"]/*' />
    [NativeTypeName("COLORREF[16]")]
    public _ColorTable_e__FixedBuffer ColorTable;

    /// <include file='_FaceName_e__FixedBuffer.xml' path='doc/member[@name="_FaceName_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _FaceName_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_ColorTable_e__FixedBuffer.xml' path='doc/member[@name="_ColorTable_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(16)]
    public partial struct _ColorTable_e__FixedBuffer
    {
        public COLORREF e0;
    }
}
