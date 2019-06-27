// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dcommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Stores an ordered pair of integers, typically the width and height of a rectangle.</summary>
    public struct D2D_SIZE_U
    {
        #region Fields
        [NativeTypeName("UINT32")]
        public uint width;

        [NativeTypeName("UINT32")]
        public uint height;
        #endregion
    }
}
