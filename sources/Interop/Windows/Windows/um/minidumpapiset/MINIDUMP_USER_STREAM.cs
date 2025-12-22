// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_USER_STREAM.xml' path='doc/member[@name="MINIDUMP_USER_STREAM"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct MINIDUMP_USER_STREAM
{
    /// <include file='MINIDUMP_USER_STREAM.xml' path='doc/member[@name="MINIDUMP_USER_STREAM.Type"]/*' />
    [NativeTypeName("ULONG32")]
    public uint Type;

    /// <include file='MINIDUMP_USER_STREAM.xml' path='doc/member[@name="MINIDUMP_USER_STREAM.BufferSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint BufferSize;

    /// <include file='MINIDUMP_USER_STREAM.xml' path='doc/member[@name="MINIDUMP_USER_STREAM.Buffer"]/*' />
    [NativeTypeName("PVOID")]
    public void* Buffer;
}
