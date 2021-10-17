// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SHELLSTATEW
    {
        public int _bitfield1;

        [NativeTypeName("BOOL : 1")]
        public int fShowAllObjects
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield1 & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~0x1) | (value & 0x1);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fShowExtensions
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 1) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 1)) | ((value & 0x1) << 1);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fNoConfirmRecycle
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 2) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 2)) | ((value & 0x1) << 2);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fShowSysFiles
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 3) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 3)) | ((value & 0x1) << 3);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fShowCompColor
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 4) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 4)) | ((value & 0x1) << 4);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fDoubleClickInWebView
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 5) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 5)) | ((value & 0x1) << 5);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fDesktopHTML
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 6) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 6)) | ((value & 0x1) << 6);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fWin95Classic
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 7) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 7)) | ((value & 0x1) << 7);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fDontPrettyPath
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 8) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 8)) | ((value & 0x1) << 8);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fShowAttribCol
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 9) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 9)) | ((value & 0x1) << 9);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fMapNetDrvBtn
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 10) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 10)) | ((value & 0x1) << 10);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fShowInfoTip
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 11) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 11)) | ((value & 0x1) << 11);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fHideIcons
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 12) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 12)) | ((value & 0x1) << 12);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fWebView
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 13) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 13)) | ((value & 0x1) << 13);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fFilter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 14) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 14)) | ((value & 0x1) << 14);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fShowSuperHidden
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 15) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 15)) | ((value & 0x1) << 15);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fNoNetCrawling
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield1 >> 16) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield1 = (_bitfield1 & ~(0x1 << 16)) | ((value & 0x1) << 16);
            }
        }

        [NativeTypeName("DWORD")]
        public uint dwWin95Unused;

        [NativeTypeName("UINT")]
        public uint uWin95Unused;

        [NativeTypeName("LONG")]
        public int lParamSort;

        public int iSortDirection;

        [NativeTypeName("UINT")]
        public uint version;

        [NativeTypeName("UINT")]
        public uint uNotUsed;

        public int _bitfield2;

        [NativeTypeName("BOOL : 1")]
        public int fSepProcess
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield2 & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~0x1) | (value & 0x1);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fStartPanelOn
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield2 >> 1) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x1 << 1)) | ((value & 0x1) << 1);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fShowStartPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield2 >> 2) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x1 << 2)) | ((value & 0x1) << 2);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fAutoCheckSelect
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield2 >> 3) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x1 << 3)) | ((value & 0x1) << 3);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fIconsOnly
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield2 >> 4) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x1 << 4)) | ((value & 0x1) << 4);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fShowTypeOverlay
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield2 >> 5) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x1 << 5)) | ((value & 0x1) << 5);
            }
        }

        [NativeTypeName("BOOL : 1")]
        public int fShowStatusBar
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield2 >> 6) & 0x1;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield2 = (_bitfield2 & ~(0x1 << 6)) | ((value & 0x1) << 6);
            }
        }

        [NativeTypeName("UINT : 9")]
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
                _bitfield2 = (_bitfield2 & ~(0x1FF << 7)) | (int)((value & 0x1FFu) << 7);
            }
        }
    }
}
