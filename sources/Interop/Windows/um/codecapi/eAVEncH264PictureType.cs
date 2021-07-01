// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum eAVEncH264PictureType
    {
        eAVEncH264PictureType_IDR = 0,
        eAVEncH264PictureType_P,
        eAVEncH264PictureType_B,
    }
}
