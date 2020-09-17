// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MANIPULATION_TRANSFORM
    {
        public float translationX;

        public float translationY;

        public float scale;

        public float expansion;

        public float rotation;
    }
}