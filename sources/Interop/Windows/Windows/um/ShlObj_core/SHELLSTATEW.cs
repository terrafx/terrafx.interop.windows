// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHELLSTATEW
{
    public BOOL _bitfield1;

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowAllObjects
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)(_bitfield1 & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~0x1) | ((BOOL)(value) & 0x1);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowExtensions
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 1) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 1)) | (((BOOL)(value) & 0x1) << 1);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fNoConfirmRecycle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 2) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 2)) | (((BOOL)(value) & 0x1) << 2);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowSysFiles
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 3) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 3)) | (((BOOL)(value) & 0x1) << 3);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowCompColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 4) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 4)) | (((BOOL)(value) & 0x1) << 4);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fDoubleClickInWebView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 5) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 5)) | (((BOOL)(value) & 0x1) << 5);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fDesktopHTML
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 6) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 6)) | (((BOOL)(value) & 0x1) << 6);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fWin95Classic
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 7) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 7)) | (((BOOL)(value) & 0x1) << 7);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fDontPrettyPath
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 8) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 8)) | (((BOOL)(value) & 0x1) << 8);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowAttribCol
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 9) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 9)) | (((BOOL)(value) & 0x1) << 9);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fMapNetDrvBtn
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 10) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 10)) | (((BOOL)(value) & 0x1) << 10);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowInfoTip
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 11) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 11)) | (((BOOL)(value) & 0x1) << 11);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fHideIcons
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 12) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 12)) | (((BOOL)(value) & 0x1) << 12);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fWebView
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 13) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 13)) | (((BOOL)(value) & 0x1) << 13);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fFilter
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 14) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 14)) | (((BOOL)(value) & 0x1) << 14);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowSuperHidden
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 15) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 15)) | (((BOOL)(value) & 0x1) << 15);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fNoNetCrawling
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield1 >> 16) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield1 = (_bitfield1 & ~(0x1 << 16)) | (((BOOL)(value) & 0x1) << 16);
        }
    }

    [NativeTypeName("DWORD")]
    public uint dwWin95Unused;

    public uint uWin95Unused;

    [NativeTypeName("LONG")]
    public int lParamSort;

    public int iSortDirection;

    public uint version;

    public uint uNotUsed;

    public BOOL _bitfield2;

    [NativeTypeName("BOOL : 1")]
    public BOOL fSepProcess
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)(_bitfield2 & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~0x1) | ((BOOL)(value) & 0x1);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fStartPanelOn
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield2 >> 1) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 1)) | (((BOOL)(value) & 0x1) << 1);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowStartPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield2 >> 2) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 2)) | (((BOOL)(value) & 0x1) << 2);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fAutoCheckSelect
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield2 >> 3) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 3)) | (((BOOL)(value) & 0x1) << 3);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fIconsOnly
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield2 >> 4) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 4)) | (((BOOL)(value) & 0x1) << 4);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowTypeOverlay
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield2 >> 5) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 5)) | (((BOOL)(value) & 0x1) << 5);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fShowStatusBar
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield2 >> 6) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1 << 6)) | (((BOOL)(value) & 0x1) << 6);
        }
    }

    [NativeTypeName("uint : 9")]
    public uint fSpareFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (uint)((_bitfield2 >> 7) & 0x1FF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield2 = (_bitfield2 & ~(0x1FF << 7)) | (BOOL)((value & 0x1FFu) << 7);
        }
    }
}
