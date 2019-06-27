// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>This controls advanced settings of the Direct2D imaging pipeline.</summary>
    public struct D2D1_RENDERING_CONTROLS
    {
        #region Fields
        /// <summary>The default buffer precision, used if the precision isn't otherwise specified.</summary>
        public D2D1_BUFFER_PRECISION bufferPrecision;

        /// <summary>The size of allocated tiles used to render imaging effects.</summary>
        [NativeTypeName("D2D1_SIZE_U")]
        public D2D_SIZE_U tileSize;
        #endregion
    }
}
