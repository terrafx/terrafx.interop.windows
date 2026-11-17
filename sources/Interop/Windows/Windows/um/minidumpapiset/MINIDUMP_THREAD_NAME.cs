// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_THREAD_NAME.xml' path='doc/member[@name="MINIDUMP_THREAD_NAME"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_THREAD_NAME
{
    /// <include file='MINIDUMP_THREAD_NAME.xml' path='doc/member[@name="MINIDUMP_THREAD_NAME.ThreadId"]/*' />
    [NativeTypeName("ULONG")]
    public uint ThreadId;

    /// <include file='MINIDUMP_THREAD_NAME.xml' path='doc/member[@name="MINIDUMP_THREAD_NAME.RvaOfThreadName"]/*' />
    [NativeTypeName("RVA64")]
    public ulong RvaOfThreadName;
}
