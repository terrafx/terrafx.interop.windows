// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct INTERACTION_ARGUMENTS_MANIPULATION
    {
        public MANIPULATION_TRANSFORM delta;

        public MANIPULATION_TRANSFORM cumulative;

        public MANIPULATION_VELOCITY velocity;

        public MANIPULATION_RAILS_STATE railsState;
    }
}
