// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SHELLHOOKINFO.xml' path='doc/member[@name="SHELLHOOKINFO"]/*' />
public partial struct SHELLHOOKINFO
{
    /// <include file='SHELLHOOKINFO.xml' path='doc/member[@name="SHELLHOOKINFO.hwnd"]/*' />
    public HWND hwnd;

    /// <include file='SHELLHOOKINFO.xml' path='doc/member[@name="SHELLHOOKINFO.rc"]/*' />
    public RECT rc;
}
