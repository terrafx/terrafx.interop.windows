// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public partial struct AUDIO_STREAM_CONFIG_CAPS
{
    public Guid guid;

    [NativeTypeName("ULONG")]
    public uint MinimumChannels;

    [NativeTypeName("ULONG")]
    public uint MaximumChannels;

    [NativeTypeName("ULONG")]
    public uint ChannelsGranularity;

    [NativeTypeName("ULONG")]
    public uint MinimumBitsPerSample;

    [NativeTypeName("ULONG")]
    public uint MaximumBitsPerSample;

    [NativeTypeName("ULONG")]
    public uint BitsPerSampleGranularity;

    [NativeTypeName("ULONG")]
    public uint MinimumSampleFrequency;

    [NativeTypeName("ULONG")]
    public uint MaximumSampleFrequency;

    [NativeTypeName("ULONG")]
    public uint SampleFrequencyGranularity;
}
