// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct TA_CUBIC_BEZIER
    {
        public TA_TIMINGFUNCTION header;

        public float rX0;

        public float rY0;

        public float rX1;

        public float rY1;
    }
}
