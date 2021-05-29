// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CastingInterop.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const WCHAR [25]")]
        public const string CastingSourceInfo_Property_PreferredSourceUriScheme = "PreferredSourceUriScheme";

        [NativeTypeName("const WCHAR [13]")]
        public const string CastingSourceInfo_Property_CastingTypes = "CastingTypes";

        [NativeTypeName("const WCHAR [15]")]
        public const string CastingSourceInfo_Property_ProtectedMedia = "ProtectedMedia";

        public static readonly Guid IID_ICastingEventHandler = new Guid(0xC79A6CB7, 0xBEBD, 0x47A6, 0xA2, 0xAD, 0x4D, 0x45, 0xAD, 0x79, 0xC7, 0xBC);

        public static readonly Guid IID_ICastingController = new Guid(0xF0A56423, 0xA664, 0x4FBD, 0x8B, 0x43, 0x40, 0x9A, 0x45, 0xE8, 0xD9, 0xA1);

        public static readonly Guid IID_ICastingSourceInfo = new Guid(0x45101AB7, 0x7C3A, 0x4BCE, 0x95, 0x00, 0x12, 0xC0, 0x90, 0x24, 0xB2, 0x98);
    }
}
