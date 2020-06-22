// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFVideoLighting
    {
        MFVideoLighting_Unknown = 0,
        MFVideoLighting_bright = 1,
        MFVideoLighting_office = 2,
        MFVideoLighting_dim = 3,
        MFVideoLighting_dark = 4,
        MFVideoLighting_Last = (MFVideoLighting_dark + 1),
        MFVideoLighting_ForceDWORD = 0x7fffffff,
    }
}
