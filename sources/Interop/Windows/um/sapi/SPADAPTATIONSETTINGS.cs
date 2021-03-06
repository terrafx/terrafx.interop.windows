// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SPADAPTATIONSETTINGS
    {
        SPADS_Default = 0,
        SPADS_CurrentRecognizer = 0x1,
        SPADS_RecoProfile = 0x2,
        SPADS_Immediate = 0x4,
        SPADS_Reset = 0x8,
        SPADS_HighVolumeDataSource = 0x10,
    }
}
