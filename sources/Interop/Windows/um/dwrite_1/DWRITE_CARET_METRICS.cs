// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite_1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    /// <summary>Metrics for caret placement in a font.</summary>
    public struct DWRITE_CARET_METRICS
    {
        #region Fields
        /// <summary>Vertical rise of the caret. Rise / Run yields the caret angle. Rise = 1 for perfectly upright fonts (non-italic).</summary>
        [NativeTypeName("INT16")]
        public short slopeRise;

        /// <summary>Horizontal run of th caret. Rise / Run yields the caret angle. Run = 0 for perfectly upright fonts (non-italic).</summary>
        [NativeTypeName("INT16")]
        public short slopeRun;

        /// <summary>Horizontal offset of the caret along the baseline for good appearance. Offset = 0 for perfectly upright fonts (non-italic).</summary>
        [NativeTypeName("INT16")]
        public short offset;
        #endregion
    }
}
