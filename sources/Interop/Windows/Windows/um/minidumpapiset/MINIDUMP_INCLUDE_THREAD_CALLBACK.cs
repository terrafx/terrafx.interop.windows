// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_INCLUDE_THREAD_CALLBACK.xml' path='doc/member[@name="MINIDUMP_INCLUDE_THREAD_CALLBACK"]/*' />
public partial struct MINIDUMP_INCLUDE_THREAD_CALLBACK
{
    /// <include file='MINIDUMP_INCLUDE_THREAD_CALLBACK.xml' path='doc/member[@name="MINIDUMP_INCLUDE_THREAD_CALLBACK.ThreadId"]/*' />
    [NativeTypeName("ULONG")]
    public uint ThreadId;
}
