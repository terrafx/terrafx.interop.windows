// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='eAV1EncoderOperatingMode.xml' path='doc/member[@name="eAV1EncoderOperatingMode"]/*' />
public enum eAV1EncoderOperatingMode
{
    /// <include file='eAV1EncoderOperatingMode.xml' path='doc/member[@name="eAV1EncoderOperatingMode.eAV1EncoderOperatingMode_Auto"]/*' />
    eAV1EncoderOperatingMode_Auto = 0,

    /// <include file='eAV1EncoderOperatingMode.xml' path='doc/member[@name="eAV1EncoderOperatingMode.eAV1EncoderOperatingMode_Reference"]/*' />
    eAV1EncoderOperatingMode_Reference = 1,

    /// <include file='eAV1EncoderOperatingMode.xml' path='doc/member[@name="eAV1EncoderOperatingMode.eAV1EncoderOperatingMode_Optimized"]/*' />
    eAV1EncoderOperatingMode_Optimized = 2,
}
