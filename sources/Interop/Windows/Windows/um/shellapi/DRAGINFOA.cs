// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DRAGINFOA.xml' path='doc/member[@name="DRAGINFOA"]/*' />
public unsafe partial struct DRAGINFOA
{
    /// <include file='DRAGINFOA.xml' path='doc/member[@name="DRAGINFOA.uSize"]/*' />
    public uint uSize;

    /// <include file='DRAGINFOA.xml' path='doc/member[@name="DRAGINFOA.pt"]/*' />
    public POINT pt;

    /// <include file='DRAGINFOA.xml' path='doc/member[@name="DRAGINFOA.fNC"]/*' />
    public BOOL fNC;

    /// <include file='DRAGINFOA.xml' path='doc/member[@name="DRAGINFOA.lpFileList"]/*' />
    [NativeTypeName("PZZSTR")]
    public sbyte* lpFileList;

    /// <include file='DRAGINFOA.xml' path='doc/member[@name="DRAGINFOA.grfKeyState"]/*' />
    [NativeTypeName("DWORD")]
    public uint grfKeyState;
}
