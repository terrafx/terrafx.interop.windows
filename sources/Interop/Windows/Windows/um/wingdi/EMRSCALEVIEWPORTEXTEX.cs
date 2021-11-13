// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct EMRSCALEVIEWPORTEXTEX
    {
        public EMR emr;

        [NativeTypeName("LONG")]
        public int xNum;

        [NativeTypeName("LONG")]
        public int xDenom;

        [NativeTypeName("LONG")]
        public int yNum;

        [NativeTypeName("LONG")]
        public int yDenom;
    }
}
