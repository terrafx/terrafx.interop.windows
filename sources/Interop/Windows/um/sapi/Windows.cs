// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.SPPHRASERNG;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const float")]
        public const float Speech_Default_Weight = (1);

        [NativeTypeName("const LONG")]
        public const int Speech_Max_Word_Length = (128);

        [NativeTypeName("const LONG")]
        public const int Speech_Max_Pron_Length = (384);

        [NativeTypeName("const LONG")]
        public const int Speech_StreamPos_Asap = (0);

        [NativeTypeName("const LONG")]
        public const int Speech_StreamPos_RealTime = (-1);

        [NativeTypeName("const LONG")]
        public const int SpeechAllElements = (int)(SPPR_ALL_ELEMENTS);
    }
}
