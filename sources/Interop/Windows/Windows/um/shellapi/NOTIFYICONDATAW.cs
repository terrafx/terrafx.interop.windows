// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW"]/*' />
public partial struct NOTIFYICONDATAW
{
    /// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW.hWnd"]/*' />
    public HWND hWnd;

    /// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW.uID"]/*' />
    public uint uID;

    /// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW.uFlags"]/*' />
    public uint uFlags;

    /// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW.uCallbackMessage"]/*' />
    public uint uCallbackMessage;

    /// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW.hIcon"]/*' />
    public HICON hIcon;

    /// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW.szTip"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public _szTip_e__FixedBuffer szTip;

    /// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW.dwState"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwState;

    /// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW.dwStateMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStateMask;

    /// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW.szInfo"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _szInfo_e__FixedBuffer szInfo;

    /// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_shellapi_L1057_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW.szInfoTitle"]/*' />
    [NativeTypeName("WCHAR[64]")]
    public _szInfoTitle_e__FixedBuffer szInfoTitle;

    /// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW.dwInfoFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInfoFlags;

    /// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW.guidItem"]/*' />
    public Guid guidItem;

    /// <include file='NOTIFYICONDATAW.xml' path='doc/member[@name="NOTIFYICONDATAW.hBalloonIcon"]/*' />
    public HICON hBalloonIcon;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uTimeout"]/*' />
    [UnscopedRef]
    public ref uint uTimeout
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.uTimeout;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uVersion"]/*' />
    [UnscopedRef]
    public ref uint uVersion
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.uVersion;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uTimeout"]/*' />
        [FieldOffset(0)]
        public uint uTimeout;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.uVersion"]/*' />
        [FieldOffset(0)]
        public uint uVersion;
    }

    /// <include file='_szTip_e__FixedBuffer.xml' path='doc/member[@name="_szTip_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _szTip_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szInfo_e__FixedBuffer.xml' path='doc/member[@name="_szInfo_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _szInfo_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szInfoTitle_e__FixedBuffer.xml' path='doc/member[@name="_szInfoTitle_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _szInfoTitle_e__FixedBuffer
    {
        public char e0;
    }
}
