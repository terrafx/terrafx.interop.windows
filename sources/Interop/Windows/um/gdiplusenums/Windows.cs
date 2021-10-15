// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.ObjectType;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const float")]
        public const float FlatnessDefault = 1.0f / 4.0f;

        [return: NativeTypeName("BOOL")]
        public static int ObjectTypeIsValid([NativeTypeName("Gdiplus::ObjectType")] ObjectType type)
        {
            return ((type >= (ObjectTypeMin)) && (type <= (ObjectTypeMax))) ? 1 : 0;
        }

        [NativeTypeName("#define GDIP_EMFPLUS_RECORD_BASE 0x00004000")]
        public const int GDIP_EMFPLUS_RECORD_BASE = 0x00004000;

        [NativeTypeName("#define GDIP_WMF_RECORD_BASE 0x00010000")]
        public const int GDIP_WMF_RECORD_BASE = 0x00010000;
    }
}
