// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct NT_CONSOLE_PROPS
    {
        public DATABLOCK_HEADER dbh;

        [NativeTypeName("WORD")]
        public ushort wFillAttribute;

        [NativeTypeName("WORD")]
        public ushort wPopupFillAttribute;

        public COORD dwScreenBufferSize;

        public COORD dwWindowSize;

        public COORD dwWindowOrigin;

        [NativeTypeName("DWORD")]
        public uint nFont;

        [NativeTypeName("DWORD")]
        public uint nInputBufferSize;

        public COORD dwFontSize;

        [NativeTypeName("UINT")]
        public uint uFontFamily;

        [NativeTypeName("UINT")]
        public uint uFontWeight;

        [NativeTypeName("WCHAR [32]")]
        public fixed ushort FaceName[32];

        [NativeTypeName("UINT")]
        public uint uCursorSize;

        public BOOL bFullScreen;

        public BOOL bQuickEdit;

        public BOOL bInsertMode;

        public BOOL bAutoPosition;

        [NativeTypeName("UINT")]
        public uint uHistoryBufferSize;

        [NativeTypeName("UINT")]
        public uint uNumberOfHistoryBuffers;

        public BOOL bHistoryNoDup;

        [NativeTypeName("COLORREF [16]")]
        public fixed uint ColorTable[16];
    }
}
