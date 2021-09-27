// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define TF_FLOATINGLANGBAR_WNDTITLEW L\"TF_FloatingLangBar_WndTitle\"")]
        public const string TF_FLOATINGLANGBAR_WNDTITLEW = "TF_FloatingLangBar_WndTitle";

        [NativeTypeName("#define TF_FLOATINGLANGBAR_WNDTITLEA \"TF_FloatingLangBar_WndTitle\"")]
        public static ReadOnlySpan<byte> TF_FLOATINGLANGBAR_WNDTITLEA => new byte[] { 0x54, 0x46, 0x5F, 0x46, 0x6C, 0x6F, 0x61, 0x74, 0x69, 0x6E, 0x67, 0x4C, 0x61, 0x6E, 0x67, 0x42, 0x61, 0x72, 0x5F, 0x57, 0x6E, 0x64, 0x54, 0x69, 0x74, 0x6C, 0x65, 0x00 };

        [NativeTypeName("#define TF_FLOATINGLANGBAR_WNDTITLE TF_FLOATINGLANGBAR_WNDTITLEW")]
        public const string TF_FLOATINGLANGBAR_WNDTITLE = "TF_FloatingLangBar_WndTitle";

        [NativeTypeName("#define TF_LBI_ICON 0x00000001")]
        public const int TF_LBI_ICON = 0x00000001;

        [NativeTypeName("#define TF_LBI_TEXT 0x00000002")]
        public const int TF_LBI_TEXT = 0x00000002;

        [NativeTypeName("#define TF_LBI_TOOLTIP 0x00000004")]
        public const int TF_LBI_TOOLTIP = 0x00000004;

        [NativeTypeName("#define TF_LBI_BITMAP 0x00000008")]
        public const int TF_LBI_BITMAP = 0x00000008;

        [NativeTypeName("#define TF_LBI_BALLOON 0x00000010")]
        public const int TF_LBI_BALLOON = 0x00000010;

        [NativeTypeName("#define TF_LBI_CUSTOMUI 0x00000020")]
        public const int TF_LBI_CUSTOMUI = 0x00000020;

        [NativeTypeName("#define TF_LBI_BTNALL (TF_LBI_ICON | TF_LBI_TEXT | TF_LBI_TOOLTIP)")]
        public const int TF_LBI_BTNALL = (0x00000001 | 0x00000002 | 0x00000004);

        [NativeTypeName("#define TF_LBI_BMPBTNALL (TF_LBI_BITMAP | TF_LBI_TEXT | TF_LBI_TOOLTIP)")]
        public const int TF_LBI_BMPBTNALL = (0x00000008 | 0x00000002 | 0x00000004);

        [NativeTypeName("#define TF_LBI_BMPALL (TF_LBI_BITMAP | TF_LBI_TOOLTIP)")]
        public const int TF_LBI_BMPALL = (0x00000008 | 0x00000004);

        [NativeTypeName("#define TF_LBI_STATUS 0x00010000")]
        public const int TF_LBI_STATUS = 0x00010000;

        [NativeTypeName("#define TF_LBI_STYLE_HIDDENSTATUSCONTROL 0x00000001")]
        public const int TF_LBI_STYLE_HIDDENSTATUSCONTROL = 0x00000001;

        [NativeTypeName("#define TF_LBI_STYLE_SHOWNINTRAY 0x00000002")]
        public const int TF_LBI_STYLE_SHOWNINTRAY = 0x00000002;

        [NativeTypeName("#define TF_LBI_STYLE_HIDEONNOOTHERITEMS 0x00000004")]
        public const int TF_LBI_STYLE_HIDEONNOOTHERITEMS = 0x00000004;

        [NativeTypeName("#define TF_LBI_STYLE_SHOWNINTRAYONLY 0x00000008")]
        public const int TF_LBI_STYLE_SHOWNINTRAYONLY = 0x00000008;

        [NativeTypeName("#define TF_LBI_STYLE_HIDDENBYDEFAULT 0x00000010")]
        public const int TF_LBI_STYLE_HIDDENBYDEFAULT = 0x00000010;

        [NativeTypeName("#define TF_LBI_STYLE_TEXTCOLORICON 0x00000020")]
        public const int TF_LBI_STYLE_TEXTCOLORICON = 0x00000020;

        [NativeTypeName("#define TF_LBI_STYLE_BTN_BUTTON 0x00010000")]
        public const int TF_LBI_STYLE_BTN_BUTTON = 0x00010000;

        [NativeTypeName("#define TF_LBI_STYLE_BTN_MENU 0x00020000")]
        public const int TF_LBI_STYLE_BTN_MENU = 0x00020000;

        [NativeTypeName("#define TF_LBI_STYLE_BTN_TOGGLE 0x00040000")]
        public const int TF_LBI_STYLE_BTN_TOGGLE = 0x00040000;

        [NativeTypeName("#define TF_LBI_STATUS_HIDDEN 0x00000001")]
        public const int TF_LBI_STATUS_HIDDEN = 0x00000001;

        [NativeTypeName("#define TF_LBI_STATUS_DISABLED 0x00000002")]
        public const int TF_LBI_STATUS_DISABLED = 0x00000002;

        [NativeTypeName("#define TF_LBI_STATUS_BTN_TOGGLED 0x00010000")]
        public const int TF_LBI_STATUS_BTN_TOGGLED = 0x00010000;

        [NativeTypeName("#define TF_LBI_BMPF_VERTICAL 0x00000001")]
        public const int TF_LBI_BMPF_VERTICAL = 0x00000001;

        [NativeTypeName("#define TF_SFT_SHOWNORMAL 0x00000001")]
        public const int TF_SFT_SHOWNORMAL = 0x00000001;

        [NativeTypeName("#define TF_SFT_DOCK 0x00000002")]
        public const int TF_SFT_DOCK = 0x00000002;

        [NativeTypeName("#define TF_SFT_MINIMIZED 0x00000004")]
        public const int TF_SFT_MINIMIZED = 0x00000004;

        [NativeTypeName("#define TF_SFT_HIDDEN 0x00000008")]
        public const int TF_SFT_HIDDEN = 0x00000008;

        [NativeTypeName("#define TF_SFT_NOTRANSPARENCY 0x00000010")]
        public const int TF_SFT_NOTRANSPARENCY = 0x00000010;

        [NativeTypeName("#define TF_SFT_LOWTRANSPARENCY 0x00000020")]
        public const int TF_SFT_LOWTRANSPARENCY = 0x00000020;

        [NativeTypeName("#define TF_SFT_HIGHTRANSPARENCY 0x00000040")]
        public const int TF_SFT_HIGHTRANSPARENCY = 0x00000040;

        [NativeTypeName("#define TF_SFT_LABELS 0x00000080")]
        public const int TF_SFT_LABELS = 0x00000080;

        [NativeTypeName("#define TF_SFT_NOLABELS 0x00000100")]
        public const int TF_SFT_NOLABELS = 0x00000100;

        [NativeTypeName("#define TF_SFT_EXTRAICONSONMINIMIZED 0x00000200")]
        public const int TF_SFT_EXTRAICONSONMINIMIZED = 0x00000200;

        [NativeTypeName("#define TF_SFT_NOEXTRAICONSONMINIMIZED 0x00000400")]
        public const int TF_SFT_NOEXTRAICONSONMINIMIZED = 0x00000400;

        [NativeTypeName("#define TF_SFT_DESKBAND 0x00000800")]
        public const int TF_SFT_DESKBAND = 0x00000800;

        [NativeTypeName("#define TF_INVALIDMENUITEM (UINT)(-1)")]
        public const uint TF_INVALIDMENUITEM = unchecked((uint)(-1));

        [NativeTypeName("#define TF_DTLBI_USEPROFILEICON 0x00000001")]
        public const int TF_DTLBI_USEPROFILEICON = 0x00000001;

        [NativeTypeName("#define TF_LBI_DESC_MAXLEN ( 32 )")]
        public const int TF_LBI_DESC_MAXLEN = (32);

        [NativeTypeName("#define TF_LBMENUF_CHECKED ( 0x1 )")]
        public const int TF_LBMENUF_CHECKED = (0x1);

        [NativeTypeName("#define TF_LBMENUF_SUBMENU ( 0x2 )")]
        public const int TF_LBMENUF_SUBMENU = (0x2);

        [NativeTypeName("#define TF_LBMENUF_SEPARATOR ( 0x4 )")]
        public const int TF_LBMENUF_SEPARATOR = (0x4);

        [NativeTypeName("#define TF_LBMENUF_RADIOCHECKED ( 0x8 )")]
        public const int TF_LBMENUF_RADIOCHECKED = (0x8);

        [NativeTypeName("#define TF_LBMENUF_GRAYED ( 0x10 )")]
        public const int TF_LBMENUF_GRAYED = (0x10);

        public static ref readonly Guid IID_ITfLangBarMgr
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x90, 0x56, 0x95, 0x87,
                    0x27, 0xE6,
                    0xD2, 0x11,
                    0x8D,
                    0xDB,
                    0x00,
                    0x10,
                    0x5A,
                    0x27,
                    0x99,
                    0xB5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITfLangBarEventSink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x00, 0xE9, 0xA4, 0x18,
                    0xAE, 0xE0,
                    0xD2, 0x11,
                    0xAF,
                    0xDD,
                    0x00,
                    0x10,
                    0x5A,
                    0x27,
                    0x99,
                    0xB5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITfLangBarItemSink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA0, 0xE1, 0xDB, 0x57,
                    0x25, 0xDE,
                    0xD2, 0x11,
                    0xAF,
                    0xDD,
                    0x00,
                    0x10,
                    0x5A,
                    0x27,
                    0x99,
                    0xB5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IEnumTfLangBarItems
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD0, 0x34, 0x3F, 0x58,
                    0x25, 0xDE,
                    0xD2, 0x11,
                    0xAF,
                    0xDD,
                    0x00,
                    0x10,
                    0x5A,
                    0x27,
                    0x99,
                    0xB5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITfLangBarItemMgr
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x55, 0x8C, 0x46, 0xBA,
                    0x56, 0x99,
                    0xB1, 0x4F,
                    0xA5,
                    0x9D,
                    0x52,
                    0xA7,
                    0xDD,
                    0x7C,
                    0xC6,
                    0xAA
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITfLangBarItem
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x69, 0x0D, 0x54, 0x73,
                    0xEB, 0xED,
                    0xE9, 0x4E,
                    0x96,
                    0xC9,
                    0x23,
                    0xAA,
                    0x30,
                    0xB2,
                    0x59,
                    0x16
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITfSystemLangBarItemSink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAB, 0xD9, 0x49, 0x14,
                    0xCF, 0x13,
                    0x87, 0x46,
                    0xAA,
                    0x3E,
                    0x8D,
                    0x8B,
                    0x18,
                    0x57,
                    0x43,
                    0x96
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITfSystemLangBarItem
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xEC, 0xE9, 0x13, 0x1E,
                    0x33, 0x6B,
                    0x4A, 0x4D,
                    0xB5,
                    0xEB,
                    0x8A,
                    0x92,
                    0xF0,
                    0x29,
                    0xF3,
                    0x56
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITfSystemLangBarItemText
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE5, 0xE0, 0x4C, 0x5C,
                    0x49, 0xBA,
                    0x52, 0x4B,
                    0xAC,
                    0x6B,
                    0x3B,
                    0x39,
                    0x7B,
                    0x4F,
                    0x70,
                    0x1F
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITfSystemDeviceTypeLangBarItem
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB9, 0x2E, 0x67, 0x45,
                    0x59, 0x90,
                    0xA2, 0x46,
                    0x83,
                    0x8D,
                    0x45,
                    0x30,
                    0x35,
                    0x5F,
                    0x6A,
                    0x77
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITfLangBarItemButton
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD0, 0xF1, 0xC7, 0x28,
                    0x25, 0xDE,
                    0xD2, 0x11,
                    0xAF,
                    0xDD,
                    0x00,
                    0x10,
                    0x5A,
                    0x27,
                    0x99,
                    0xB5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITfLangBarItemBitmapButton
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x25, 0x05, 0x6A, 0xA2,
                    0xAE, 0x3F,
                    0xA0, 0x4F,
                    0x89,
                    0xEE,
                    0x88,
                    0xA9,
                    0x64,
                    0xF9,
                    0xF1,
                    0xB5
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITfLangBarItemBitmap
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0x03, 0x83, 0x73,
                    0x22, 0xD7,
                    0x79, 0x41,
                    0xAD,
                    0xA5,
                    0xF0,
                    0x45,
                    0xC9,
                    0x8D,
                    0xF3,
                    0x55
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITfLangBarItemBalloon
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x85, 0xD2, 0xC2, 0x01,
                    0xC7, 0xD3,
                    0x7B, 0x4B,
                    0xB5,
                    0xB5,
                    0xD9,
                    0x74,
                    0x11,
                    0xD0,
                    0xC2,
                    0x83
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ITfMenu
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE4, 0x98, 0x8A, 0x6F,
                    0xA0, 0xAA,
                    0x15, 0x4F,
                    0x8C,
                    0x5B,
                    0x07,
                    0xE0,
                    0xDF,
                    0x0A,
                    0x3D,
                    0xD8
                };

                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
