// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='NOTIFYICONIDENTIFIER.xml' path='doc/member[@name="NOTIFYICONIDENTIFIER"]/*' />
public partial struct NOTIFYICONIDENTIFIER
{
    /// <include file='NOTIFYICONIDENTIFIER.xml' path='doc/member[@name="NOTIFYICONIDENTIFIER.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='NOTIFYICONIDENTIFIER.xml' path='doc/member[@name="NOTIFYICONIDENTIFIER.hWnd"]/*' />
    public HWND hWnd;

    /// <include file='NOTIFYICONIDENTIFIER.xml' path='doc/member[@name="NOTIFYICONIDENTIFIER.uID"]/*' />
    public uint uID;

    /// <include file='NOTIFYICONIDENTIFIER.xml' path='doc/member[@name="NOTIFYICONIDENTIFIER.guidItem"]/*' />
    public Guid guidItem;
}
