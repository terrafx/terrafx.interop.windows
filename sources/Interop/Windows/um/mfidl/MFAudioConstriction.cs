// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFAudioConstriction
    {
        MFaudioConstrictionOff = 0,
        MFaudioConstriction48_16 = (MFaudioConstrictionOff + 1),
        MFaudioConstriction44_16 = (MFaudioConstriction48_16 + 1),
        MFaudioConstriction14_14 = (MFaudioConstriction44_16 + 1),
        MFaudioConstrictionMute = (MFaudioConstriction14_14 + 1),
    }
}
