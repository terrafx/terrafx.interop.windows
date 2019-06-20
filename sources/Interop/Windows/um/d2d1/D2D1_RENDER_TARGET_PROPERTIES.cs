// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Utilities;

namespace TerraFX.Interop
{
    /// <summary>Contains rendering options (hardware or software), pixel format, DPI information, remoting options, and Direct3D support requirements for a render target.</summary>
    [Unmanaged]
    public struct D2D1_RENDER_TARGET_PROPERTIES
    {
        #region Fields
        public D2D1_RENDER_TARGET_TYPE type;

        public D2D1_PIXEL_FORMAT pixelFormat;

        [NativeTypeName("FLOAT")]
        public float dpiX;

        [NativeTypeName("FLOAT")]
        public float dpiY;

        public D2D1_RENDER_TARGET_USAGE usage;

        public D2D1_FEATURE_LEVEL minLevel;
        #endregion
    }
}
