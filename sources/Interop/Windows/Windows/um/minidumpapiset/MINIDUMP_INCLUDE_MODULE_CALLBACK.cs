// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minidumpapiset.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MINIDUMP_INCLUDE_MODULE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_INCLUDE_MODULE_CALLBACK"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct MINIDUMP_INCLUDE_MODULE_CALLBACK
{
    /// <include file='MINIDUMP_INCLUDE_MODULE_CALLBACK.xml' path='doc/member[@name="MINIDUMP_INCLUDE_MODULE_CALLBACK.BaseOfImage"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong BaseOfImage;
}
