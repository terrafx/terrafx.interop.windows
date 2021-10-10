// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define CODECAPI_AVEncStatBandwidthProcessorUtilitization DEFINE_CODECAPI_GUIDNAMED( AVEncStatHardwareBandwidthUtilitization )")]
        public static ref readonly Guid CODECAPI_AVEncStatBandwidthProcessorUtilitization => ref STATIC_CODECAPI_AVEncStatHardwareBandwidthUtilitization;
    }
}
