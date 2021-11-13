// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    [SupportedOSPlatform("windows8.0")]
    public enum INTERACTION_CONTEXT_PROPERTY
    {
        INTERACTION_CONTEXT_PROPERTY_MEASUREMENT_UNITS = 0x00000001,
        INTERACTION_CONTEXT_PROPERTY_INTERACTION_UI_FEEDBACK = 0x00000002,
        INTERACTION_CONTEXT_PROPERTY_FILTER_POINTERS = 0x00000003,
        INTERACTION_CONTEXT_PROPERTY_MAX = unchecked((int)(0xffffffff)),
    }
}
