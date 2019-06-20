// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>This identifies a certain input connection of a certain effect.</summary>
    [Unmanaged]
    public unsafe struct D2D1_EFFECT_INPUT_DESCRIPTION
    {
        #region Fields
        /// <summary>The effect whose input connection is being specified.</summary>
        public ID2D1Effect* effect;

        /// <summary>The index of the input connection into the specified effect.</summary>
        [NativeTypeName("UINT32")]
        public uint inputIndex;

        /// <summary>The rectangle which would be available on the specified input connection during render operations.</summary>
        [NativeTypeName("D2D_RECT_F")]
        public D2D_RECT_F inputRectangle;
        #endregion
    }
}
