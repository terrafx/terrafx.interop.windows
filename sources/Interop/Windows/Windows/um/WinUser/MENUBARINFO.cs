// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

public partial struct MENUBARINFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    public RECT rcBar;

    public HMENU hMenu;

    public HWND hwndMenu;

    public BOOL _bitfield;

    [NativeTypeName("BOOL : 1")]
    public BOOL fBarFocused
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)(_bitfield & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0x1) | ((BOOL)(value) & 0x1);
        }
    }

    [NativeTypeName("BOOL : 1")]
    public BOOL fFocused
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 1) & 0x1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 1)) | (((BOOL)(value) & 0x1) << 1);
        }
    }

    [NativeTypeName("BOOL : 30")]
    public BOOL fUnused
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (BOOL)((_bitfield >> 2) & 0x3FFFFFFF);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x3FFFFFFF << 2)) | (((BOOL)(value) & 0x3FFFFFFF) << 2);
        }
    }
}
