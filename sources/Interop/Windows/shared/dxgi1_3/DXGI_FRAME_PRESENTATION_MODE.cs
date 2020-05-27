// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DXGI_FRAME_PRESENTATION_MODE
    {
        DXGI_FRAME_PRESENTATION_MODE_COMPOSED = 0,
        DXGI_FRAME_PRESENTATION_MODE_OVERLAY = 1,
        DXGI_FRAME_PRESENTATION_MODE_NONE = 2,
        DXGI_FRAME_PRESENTATION_MODE_COMPOSITION_FAILURE = 3,
    }
}
