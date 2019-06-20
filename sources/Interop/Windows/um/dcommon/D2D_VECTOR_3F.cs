// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dcommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>A vector of 3 float values (x, y, z).</summary>
    [Unmanaged]
    public struct D2D_VECTOR_3F
    {
        #region Fields
        [NativeTypeName("FLOAT")]
        public float x;

        [NativeTypeName("FLOAT")]
        public float y;

        [NativeTypeName("FLOAT")]
        public float z;
        #endregion
    }
}
