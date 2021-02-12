// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmdeviceapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum EDataFlow
    {
        eRender = 0,
        eCapture = (eRender + 1),
        eAll = (eCapture + 1),
        EDataFlow_enum_count = (eAll + 1),
    }
}
