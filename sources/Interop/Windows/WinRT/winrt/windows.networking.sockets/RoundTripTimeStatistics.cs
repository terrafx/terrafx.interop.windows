// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='RoundTripTimeStatistics.xml' path='doc/member[@name="RoundTripTimeStatistics"]/*' />
public partial struct RoundTripTimeStatistics
{
    /// <include file='RoundTripTimeStatistics.xml' path='doc/member[@name="RoundTripTimeStatistics.Variance"]/*' />
    [NativeTypeName("UINT32")]
    public uint Variance;

    /// <include file='RoundTripTimeStatistics.xml' path='doc/member[@name="RoundTripTimeStatistics.Max"]/*' />
    [NativeTypeName("UINT32")]
    public uint Max;

    /// <include file='RoundTripTimeStatistics.xml' path='doc/member[@name="RoundTripTimeStatistics.Min"]/*' />
    [NativeTypeName("UINT32")]
    public uint Min;

    /// <include file='RoundTripTimeStatistics.xml' path='doc/member[@name="RoundTripTimeStatistics.Sum"]/*' />
    [NativeTypeName("UINT32")]
    public uint Sum;
}
