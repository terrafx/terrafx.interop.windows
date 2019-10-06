// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dcommon.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>A vector of 2 float values (x, y).</summary>
    public partial struct D2D_VECTOR_2F
    {
        [NativeTypeName("FLOAT")]
        public float x;

        [NativeTypeName("FLOAT")]
        public float y;
    }
}
