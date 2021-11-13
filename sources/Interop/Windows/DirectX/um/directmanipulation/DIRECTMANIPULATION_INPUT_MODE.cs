// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX
{
    [SupportedOSPlatform("windows8.0")]
    public enum DIRECTMANIPULATION_INPUT_MODE
    {
        DIRECTMANIPULATION_INPUT_MODE_AUTOMATIC = 0,
        DIRECTMANIPULATION_INPUT_MODE_MANUAL = 1,
    }
}
