// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D2D1_EFFECT_INPUT_DESCRIPTION
    {
        public D2D1_EFFECT_INPUT_DESCRIPTION(ID2D1Effect* effect, uint inputIndex, D2D_RECT_F inputRectangle)
        {
            this.effect = effect;
            this.inputIndex = inputIndex;
            this.inputRectangle = inputRectangle;
        }
    }
}
