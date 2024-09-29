// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_READ_MEMORY_FAILURE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_READ_MEMORY_FAILURE_CALLBACK"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_READ_MEMORY_FAILURE_CALLBACK
{
    /// <include file='MINIDUMP_READ_MEMORY_FAILURE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_READ_MEMORY_FAILURE_CALLBACK.Offset"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Offset;

    /// <include file='MINIDUMP_READ_MEMORY_FAILURE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_READ_MEMORY_FAILURE_CALLBACK.Bytes"]/*' />
    [NativeTypeName("ULONG")]
    public uint Bytes;

    /// <include file='MINIDUMP_READ_MEMORY_FAILURE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_READ_MEMORY_FAILURE_CALLBACK.FailureStatus"]/*' />
    public HRESULT FailureStatus;
}
