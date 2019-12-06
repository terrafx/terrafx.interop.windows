// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_RENDER_TARGET_PROPERTIES
    {
        public static readonly D2D1_RENDER_TARGET_PROPERTIES DEFAULT = new D2D1_RENDER_TARGET_PROPERTIES(D2D1_RENDER_TARGET_TYPE.D2D1_RENDER_TARGET_TYPE_DEFAULT, D2D1_PIXEL_FORMAT.DEFAULT, 0.0f, 0.0f, D2D1_RENDER_TARGET_USAGE.D2D1_RENDER_TARGET_USAGE_NONE, D2D1_FEATURE_LEVEL.D2D1_FEATURE_LEVEL_DEFAULT);

        public D2D1_RENDER_TARGET_PROPERTIES(D2D1_RENDER_TARGET_TYPE type, D2D1_PIXEL_FORMAT pixelFormat, float dpiX, float dpiY, D2D1_RENDER_TARGET_USAGE usage, D2D1_FEATURE_LEVEL minLevel)
        {
            this.type = type;
            this.pixelFormat = pixelFormat;
            this.dpiX = dpiX;
            this.dpiY = dpiY;
            this.usage = usage;
            this.minLevel = minLevel;
        }
    }
}
