// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPExport.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public unsafe partial struct IP_UNIDIRECTIONAL_ADAPTER_ADDRESS
{
    [NativeTypeName("ULONG")]
    public uint NumAdapters;

    [NativeTypeName("IPAddr [1]")]
    public fixed uint Address[1];
}
