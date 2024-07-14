// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA"]/*' />
public partial struct NOTIFYICONDATAA
{
    /// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA.hWnd"]/*' />
    public HWND hWnd;

    /// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA.uID"]/*' />
    public uint uID;

    /// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA.uFlags"]/*' />
    public uint uFlags;

    /// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA.uCallbackMessage"]/*' />
    public uint uCallbackMessage;

    /// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA.hIcon"]/*' />
    public HICON hIcon;

    /// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA.szTip"]/*' />
    [NativeTypeName("CHAR[128]")]
    public _szTip_e__FixedBuffer szTip;

    /// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA.dwState"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwState;

    /// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA.dwStateMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStateMask;

    /// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA.szInfo"]/*' />
    [NativeTypeName("CHAR[256]")]
    public _szInfo_e__FixedBuffer szInfo;

    /// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_shellapi_L1027_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA.szInfoTitle"]/*' />
    [NativeTypeName("CHAR[64]")]
    public _szInfoTitle_e__FixedBuffer szInfoTitle;

    /// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA.dwInfoFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInfoFlags;

    /// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA.guidItem"]/*' />
    public Guid guidItem;

    /// <include file='NOTIFYICONDATAA.xml' path='doc/member[@name="NOTIFYICONDATAA.hBalloonIcon"]/*' />
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
        public sbyte e0;
    }

    /// <include file='_szInfo_e__FixedBuffer.xml' path='doc/member[@name="_szInfo_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _szInfo_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_szInfoTitle_e__FixedBuffer.xml' path='doc/member[@name="_szInfoTitle_e__FixedBuffer"]/*' />
    [InlineArray(64)]
    public partial struct _szInfoTitle_e__FixedBuffer
    {
        public sbyte e0;
    }
}
