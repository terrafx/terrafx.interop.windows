// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct INTERACTION_CONTEXT_CONFIGURATION
    {
        public INTERACTION_ID interactionId;

        public INTERACTION_CONFIGURATION_FLAGS enable;
    }
}
