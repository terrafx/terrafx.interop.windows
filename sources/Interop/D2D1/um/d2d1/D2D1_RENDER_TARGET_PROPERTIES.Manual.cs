// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.D2D1;
using static TerraFX.Interop.D2D1_FEATURE_LEVEL;
using static TerraFX.Interop.D2D1_RENDER_TARGET_TYPE;
using static TerraFX.Interop.D2D1_RENDER_TARGET_USAGE;

namespace TerraFX.Interop
{
    public partial struct D2D1_RENDER_TARGET_PROPERTIES
    {
        public static readonly D2D1_RENDER_TARGET_PROPERTIES DEFAULT = new D2D1_RENDER_TARGET_PROPERTIES(D2D1_RENDER_TARGET_TYPE_DEFAULT, default, 0.0f, 0.0f, D2D1_RENDER_TARGET_USAGE_NONE, D2D1_FEATURE_LEVEL_DEFAULT);

        public D2D1_RENDER_TARGET_PROPERTIES(D2D1_RENDER_TARGET_TYPE type = D2D1_RENDER_TARGET_TYPE_DEFAULT, [NativeTypeName("const D2D1_PIXEL_FORMAT &")] in D2D1_PIXEL_FORMAT pixelFormat = default, [NativeTypeName("FLOAT")] float dpiX = 0.0f, [NativeTypeName("FLOAT")] float dpiY = 0.0f, D2D1_RENDER_TARGET_USAGE usage = D2D1_RENDER_TARGET_USAGE_NONE, D2D1_FEATURE_LEVEL minLevel = D2D1_FEATURE_LEVEL_DEFAULT)
        {
            this = RenderTargetProperties(type, pixelFormat, dpiX, dpiY, usage, minLevel);
        }
    }
}
