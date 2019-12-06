// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DXGI_RGBA
    {
        private const uint RedShift = 16u;
        private const uint GreenShift = 8u;
        private const uint BlueShift = 0u;
        private const uint RedMask = 0xff << (int)RedShift;
        private const uint GreenMask = 0xff << (int)GreenShift;
        private const uint BlueMask = 0xff << (int)BlueShift;

        public DXGI_RGBA(uint rgb, float a = 1.0f)
        {
            r = ((rgb & RedMask) >> (int)RedShift) / 255.0f;
            g = ((rgb & GreenMask) >> (int)GreenShift) / 255.0f;
            b = ((rgb & BlueMask) >> (int)BlueShift) / 255.0f;
            this.a = a;
        }

        public DXGI_RGBA(ColorF knownColor, float a = 1.0f) : this((uint)knownColor, a)
        {
        }

        public DXGI_RGBA(float red, float green, float blue, float alpha = 1.0f)
        {
            r = red;
            g = green;
            b = blue;
            a = alpha;
        }
    }
}
