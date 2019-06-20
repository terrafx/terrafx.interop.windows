// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effects.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>The enumeration of the Histogram effect's top level properties.</summary>
    public enum D2D1_HISTOGRAM_PROP : uint
    {
        /// <summary>Property Name: "NumBins" Property Type: UINT32</summary>
        D2D1_HISTOGRAM_PROP_NUM_BINS = 0,

        /// <summary>Property Name: "ChannelSelect" Property Type: D2D1_CHANNEL_SELECTOR</summary>
        D2D1_HISTOGRAM_PROP_CHANNEL_SELECT = 1,

        /// <summary>Property Name: "HistogramOutput" Property Type: (blob)</summary>
        D2D1_HISTOGRAM_PROP_HISTOGRAM_OUTPUT = 2,

        D2D1_HISTOGRAM_PROP_FORCE_DWORD = 0xFFFFFFFF
    }
}
