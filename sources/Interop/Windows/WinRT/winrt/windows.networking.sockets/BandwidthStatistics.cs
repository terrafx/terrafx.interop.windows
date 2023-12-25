// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BandwidthStatistics.xml' path='doc/member[@name="BandwidthStatistics"]/*' />
public partial struct BandwidthStatistics
{
    /// <include file='BandwidthStatistics.xml' path='doc/member[@name="BandwidthStatistics.OutboundBitsPerSecond"]/*' />
    [NativeTypeName("UINT64")]
    public ulong OutboundBitsPerSecond;

    /// <include file='BandwidthStatistics.xml' path='doc/member[@name="BandwidthStatistics.InboundBitsPerSecond"]/*' />
    [NativeTypeName("UINT64")]
    public ulong InboundBitsPerSecond;

    /// <include file='BandwidthStatistics.xml' path='doc/member[@name="BandwidthStatistics.OutboundBitsPerSecondInstability"]/*' />
    [NativeTypeName("UINT64")]
    public ulong OutboundBitsPerSecondInstability;

    /// <include file='BandwidthStatistics.xml' path='doc/member[@name="BandwidthStatistics.InboundBitsPerSecondInstability"]/*' />
    [NativeTypeName("UINT64")]
    public ulong InboundBitsPerSecondInstability;

    /// <include file='BandwidthStatistics.xml' path='doc/member[@name="BandwidthStatistics.OutboundBandwidthPeaked"]/*' />
    [NativeTypeName("boolean")]
    public byte OutboundBandwidthPeaked;

    /// <include file='BandwidthStatistics.xml' path='doc/member[@name="BandwidthStatistics.InboundBandwidthPeaked"]/*' />
    [NativeTypeName("boolean")]
    public byte InboundBandwidthPeaked;
}
