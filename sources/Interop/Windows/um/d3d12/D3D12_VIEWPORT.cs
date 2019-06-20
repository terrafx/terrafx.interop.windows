// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;
using static TerraFX.Utilities.HashUtilities;
using static TerraFX.Utilities.InteropUtilities;

namespace TerraFX.Interop
{
    [Unmanaged]
    public struct D3D12_VIEWPORT
    {
        #region Fields
        [NativeTypeName("FLOAT")]
        public float TopLeftX;

        [NativeTypeName("FLOAT")]
        public float TopLeftY;

        [NativeTypeName("FLOAT")]
        public float Width;

        [NativeTypeName("FLOAT")]
        public float Height;

        [NativeTypeName("FLOAT")]
        public float MinDepth;

        [NativeTypeName("FLOAT")]
        public float MaxDepth;
        #endregion

        #region Operators
        public static bool operator ==(D3D12_VIEWPORT l, D3D12_VIEWPORT r)
        {
            return (l.TopLeftX == r.TopLeftX)
                && (l.TopLeftY == r.TopLeftY)
                && (l.Width == r.Width)
                && (l.Height == r.Height)
                && (l.MinDepth == r.MinDepth)
                && (l.MaxDepth == r.MaxDepth);
        }

        public static bool operator !=(D3D12_VIEWPORT l, D3D12_VIEWPORT r)
        {
            return !(l == r);
        }
        #endregion

        #region System.Object
        public override bool Equals(object obj)
        {
            return (obj is D3D12_VIEWPORT other) && (this == other);
        }

        public override int GetHashCode()
        {
            var combinedValue = 0;
            {
                combinedValue = CombineValue(TopLeftX.GetHashCode(), combinedValue);
                combinedValue = CombineValue(TopLeftY.GetHashCode(), combinedValue);
                combinedValue = CombineValue(Width.GetHashCode(), combinedValue);
                combinedValue = CombineValue(Height.GetHashCode(), combinedValue);
                combinedValue = CombineValue(MinDepth.GetHashCode(), combinedValue);
                combinedValue = CombineValue(MaxDepth.GetHashCode(), combinedValue);
            }
            return FinalizeValue(combinedValue, SizeOf<D3D12_VIEWPORT>());
        }
        #endregion
    }
}
