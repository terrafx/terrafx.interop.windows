// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

[SupportedOSPlatform("windows8.0")]
public partial struct NL_BANDWIDTH_INFORMATION
{
    [NativeTypeName("ULONG64")]
    public ulong Bandwidth;

    [NativeTypeName("ULONG64")]
    public ulong Instability;

    [NativeTypeName("BOOLEAN")]
    public byte BandwidthPeaked;
}
