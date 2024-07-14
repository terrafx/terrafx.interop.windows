// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='PROCESS_NETWORK_COUNTERS.xml' path='doc/member[@name="PROCESS_NETWORK_COUNTERS"]/*' />
public partial struct PROCESS_NETWORK_COUNTERS
{
    /// <include file='PROCESS_NETWORK_COUNTERS.xml' path='doc/member[@name="PROCESS_NETWORK_COUNTERS.BytesIn"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong BytesIn;

    /// <include file='PROCESS_NETWORK_COUNTERS.xml' path='doc/member[@name="PROCESS_NETWORK_COUNTERS.BytesOut"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong BytesOut;
}
