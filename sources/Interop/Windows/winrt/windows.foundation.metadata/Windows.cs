// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.metadata.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const WCHAR [51]")]
        public const string InterfaceName_Windows_Foundation_Metadata_IApiInformationStatics = "Windows.Foundation.Metadata.IApiInformationStatics";

        [NativeTypeName("const WCHAR [43]")]
        public const string RuntimeClass_Windows_Foundation_Metadata_ApiInformation = "Windows.Foundation.Metadata.ApiInformation";

        public static readonly Guid IID_IApiInformationStatics = new Guid(0x997439FE, 0xF681, 0x4A11, 0xB4, 0x16, 0xC1, 0x3A, 0x47, 0xE8, 0xBA, 0x36);
    }
}
