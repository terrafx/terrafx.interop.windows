// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTTP_FLOWRATE_INFO.xml' path='doc/member[@name="HTTP_FLOWRATE_INFO"]/*' />
public partial struct HTTP_FLOWRATE_INFO
{
    /// <include file='HTTP_FLOWRATE_INFO.xml' path='doc/member[@name="HTTP_FLOWRATE_INFO.Flags"]/*' />
    public HTTP_PROPERTY_FLAGS Flags;

    /// <include file='HTTP_FLOWRATE_INFO.xml' path='doc/member[@name="HTTP_FLOWRATE_INFO.MaxBandwidth"]/*' />
    [NativeTypeName("ULONG")]
    public uint MaxBandwidth;

    /// <include file='HTTP_FLOWRATE_INFO.xml' path='doc/member[@name="HTTP_FLOWRATE_INFO.MaxPeakBandwidth"]/*' />
    [NativeTypeName("ULONG")]
    public uint MaxPeakBandwidth;

    /// <include file='HTTP_FLOWRATE_INFO.xml' path='doc/member[@name="HTTP_FLOWRATE_INFO.BurstSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint BurstSize;
}
