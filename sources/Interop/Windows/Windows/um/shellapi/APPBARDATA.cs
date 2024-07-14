// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='APPBARDATA.xml' path='doc/member[@name="APPBARDATA"]/*' />
public partial struct APPBARDATA
{
    /// <include file='APPBARDATA.xml' path='doc/member[@name="APPBARDATA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='APPBARDATA.xml' path='doc/member[@name="APPBARDATA.hWnd"]/*' />
    public HWND hWnd;

    /// <include file='APPBARDATA.xml' path='doc/member[@name="APPBARDATA.uCallbackMessage"]/*' />
    public uint uCallbackMessage;

    /// <include file='APPBARDATA.xml' path='doc/member[@name="APPBARDATA.uEdge"]/*' />
    public uint uEdge;

    /// <include file='APPBARDATA.xml' path='doc/member[@name="APPBARDATA.rc"]/*' />
    public RECT rc;

    /// <include file='APPBARDATA.xml' path='doc/member[@name="APPBARDATA.lParam"]/*' />
    public LPARAM lParam;
}
