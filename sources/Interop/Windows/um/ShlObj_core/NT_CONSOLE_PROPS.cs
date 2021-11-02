// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
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

        public uint uFontFamily;

        public uint uFontWeight;

        [NativeTypeName("WCHAR [32]")]
        public fixed ushort FaceName[32];

        public uint uCursorSize;

        public BOOL bFullScreen;

        public BOOL bQuickEdit;

        public BOOL bInsertMode;

        public BOOL bAutoPosition;

        public uint uHistoryBufferSize;

        public uint uNumberOfHistoryBuffers;

        public BOOL bHistoryNoDup;

        [NativeTypeName("COLORREF [16]")]
        public _ColorTable_e__FixedBuffer ColorTable;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _ColorTable_e__FixedBuffer
        {
            public COLORREF e0;
            public COLORREF e1;
            public COLORREF e2;
            public COLORREF e3;
            public COLORREF e4;
            public COLORREF e5;
            public COLORREF e6;
            public COLORREF e7;
            public COLORREF e8;
            public COLORREF e9;
            public COLORREF e10;
            public COLORREF e11;
            public COLORREF e12;
            public COLORREF e13;
            public COLORREF e14;
            public COLORREF e15;

            public ref COLORREF this[int index]
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return ref AsSpan()[index];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Span<COLORREF> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
        }
    }
}
