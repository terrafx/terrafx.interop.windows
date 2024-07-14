// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO"]/*' />
public partial struct MENUBARINFO
{
    /// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO.rcBar"]/*' />
    public RECT rcBar;

    /// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO.hMenu"]/*' />
    public HMENU hMenu;

    /// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO.hwndMenu"]/*' />
    public HWND hwndMenu;

    public BOOL _bitfield;

    /// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO.fBarFocused"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fBarFocused
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (BOOL)((_bitfield << 31) >> 31);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0x1) | ((BOOL)(value) & 0x1);
        }
    }

    /// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO.fFocused"]/*' />
    [NativeTypeName("BOOL : 1")]
    public BOOL fFocused
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (BOOL)((_bitfield << 30) >> 31);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1 << 1)) | (((BOOL)(value) & 0x1) << 1);
        }
    }

    /// <include file='MENUBARINFO.xml' path='doc/member[@name="MENUBARINFO.fUnused"]/*' />
    [NativeTypeName("BOOL : 30")]
    public BOOL fUnused
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (BOOL)((_bitfield << 0) >> 2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x3FFFFFFF << 2)) | (((BOOL)(value) & 0x3FFFFFFF) << 2);
        }
    }
}
