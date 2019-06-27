// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Blend description which configures a blend transform object.</summary>
    public unsafe struct D2D1_BLEND_DESCRIPTION
    {
        #region Fields
        public D2D1_BLEND sourceBlend;

        public D2D1_BLEND destinationBlend;

        public D2D1_BLEND_OPERATION blendOperation;

        public D2D1_BLEND sourceBlendAlpha;

        public D2D1_BLEND destinationBlendAlpha;

        public D2D1_BLEND_OPERATION blendOperationAlpha;

        [NativeTypeName("FLOAT[4]")]
        public fixed float blendFactor[4];
        #endregion
    }
}
