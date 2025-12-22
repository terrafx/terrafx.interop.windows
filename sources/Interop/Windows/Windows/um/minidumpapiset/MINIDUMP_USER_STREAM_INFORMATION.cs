// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_USER_STREAM_INFORMATION.xml' path='doc/member[@name="MINIDUMP_USER_STREAM_INFORMATION"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public unsafe partial struct MINIDUMP_USER_STREAM_INFORMATION
{
    /// <include file='MINIDUMP_USER_STREAM_INFORMATION.xml' path='doc/member[@name="MINIDUMP_USER_STREAM_INFORMATION.UserStreamCount"]/*' />
    [NativeTypeName("ULONG")]
    public uint UserStreamCount;

    /// <include file='MINIDUMP_USER_STREAM_INFORMATION.xml' path='doc/member[@name="MINIDUMP_USER_STREAM_INFORMATION.UserStreamArray"]/*' />
    [NativeTypeName("PMINIDUMP_USER_STREAM")]
    public MINIDUMP_USER_STREAM* UserStreamArray;
}
