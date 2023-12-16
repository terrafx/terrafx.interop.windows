// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DRAGINFOW.xml' path='doc/member[@name="DRAGINFOW"]/*' />
public unsafe partial struct DRAGINFOW
{
    /// <include file='DRAGINFOW.xml' path='doc/member[@name="DRAGINFOW.uSize"]/*' />
    public uint uSize;

    /// <include file='DRAGINFOW.xml' path='doc/member[@name="DRAGINFOW.pt"]/*' />
    public POINT pt;

    /// <include file='DRAGINFOW.xml' path='doc/member[@name="DRAGINFOW.fNC"]/*' />
    public BOOL fNC;

    /// <include file='DRAGINFOW.xml' path='doc/member[@name="DRAGINFOW.lpFileList"]/*' />
    [NativeTypeName("PZZWSTR")]
    public char* lpFileList;

    /// <include file='DRAGINFOW.xml' path='doc/member[@name="DRAGINFOW.grfKeyState"]/*' />
    [NativeTypeName("DWORD")]
    public uint grfKeyState;
}
