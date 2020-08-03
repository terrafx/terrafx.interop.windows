// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.eAVEncH264VProfile;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define eAVEncH264VProfile_ConstrainedHigh eAVEncH264VProfile_UCConstrainedHigh")]
        public const eAVEncH264VProfile eAVEncH264VProfile_ConstrainedHigh = eAVEncH264VProfile_UCConstrainedHigh;

        [NativeTypeName("#define AVENC_H263V_LEVELCOUNT 8")]
        public const int AVENC_H263V_LEVELCOUNT = 8;

        [NativeTypeName("#define AVENC_H264V_LEVELCOUNT 16")]
        public const int AVENC_H264V_LEVELCOUNT = 16;

        [NativeTypeName("#define AVENC_H264V_MAX_MBBITS 3200")]
        public const int AVENC_H264V_MAX_MBBITS = 3200;
    }
}
