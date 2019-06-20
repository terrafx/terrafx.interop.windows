// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>Indicates whether shader support for doubles is present on the underlying hardware.  This may be populated using CheckFeatureSupport.</summary>
    [Unmanaged]
    public struct D2D1_FEATURE_DATA_DOUBLES
    {
        #region Fields
        [NativeTypeName("BOOL")]
        public int doublePrecisionFloatShaderOps;
        #endregion
    }
}
