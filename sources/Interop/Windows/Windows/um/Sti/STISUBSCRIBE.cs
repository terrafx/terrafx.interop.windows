// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Sti.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='STISUBSCRIBE.xml' path='doc/member[@name="STISUBSCRIBE"]/*' />
public partial struct STISUBSCRIBE
{
    /// <include file='STISUBSCRIBE.xml' path='doc/member[@name="STISUBSCRIBE.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='STISUBSCRIBE.xml' path='doc/member[@name="STISUBSCRIBE.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='STISUBSCRIBE.xml' path='doc/member[@name="STISUBSCRIBE.dwFilter"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFilter;

    /// <include file='STISUBSCRIBE.xml' path='doc/member[@name="STISUBSCRIBE.hWndNotify"]/*' />
    public HWND hWndNotify;

    /// <include file='STISUBSCRIBE.xml' path='doc/member[@name="STISUBSCRIBE.hEvent"]/*' />
    public HANDLE hEvent;

    /// <include file='STISUBSCRIBE.xml' path='doc/member[@name="STISUBSCRIBE.uiNotificationMessage"]/*' />
    public uint uiNotificationMessage;
}
