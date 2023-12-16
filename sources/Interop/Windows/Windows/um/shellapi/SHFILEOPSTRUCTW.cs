// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SHFILEOPSTRUCTW.xml' path='doc/member[@name="SHFILEOPSTRUCTW"]/*' />
public unsafe partial struct SHFILEOPSTRUCTW
{
    /// <include file='SHFILEOPSTRUCTW.xml' path='doc/member[@name="SHFILEOPSTRUCTW.hwnd"]/*' />
    public HWND hwnd;

    /// <include file='SHFILEOPSTRUCTW.xml' path='doc/member[@name="SHFILEOPSTRUCTW.wFunc"]/*' />
    public uint wFunc;

    /// <include file='SHFILEOPSTRUCTW.xml' path='doc/member[@name="SHFILEOPSTRUCTW.pFrom"]/*' />
    [NativeTypeName("PCZZWSTR")]
    public char* pFrom;

    /// <include file='SHFILEOPSTRUCTW.xml' path='doc/member[@name="SHFILEOPSTRUCTW.pTo"]/*' />
    [NativeTypeName("PCZZWSTR")]
    public char* pTo;

    /// <include file='SHFILEOPSTRUCTW.xml' path='doc/member[@name="SHFILEOPSTRUCTW.fFlags"]/*' />
    [NativeTypeName("FILEOP_FLAGS")]
    public ushort fFlags;

    /// <include file='SHFILEOPSTRUCTW.xml' path='doc/member[@name="SHFILEOPSTRUCTW.fAnyOperationsAborted"]/*' />
    public BOOL fAnyOperationsAborted;

    /// <include file='SHFILEOPSTRUCTW.xml' path='doc/member[@name="SHFILEOPSTRUCTW.hNameMappings"]/*' />
    [NativeTypeName("LPVOID")]
    public void* hNameMappings;

    /// <include file='SHFILEOPSTRUCTW.xml' path='doc/member[@name="SHFILEOPSTRUCTW.lpszProgressTitle"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* lpszProgressTitle;
}
