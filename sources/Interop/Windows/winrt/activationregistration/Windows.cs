// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/activationregistration.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const WCHAR [49]")]
        public const string InterfaceName_Windows_Foundation_IActivatableClassRegistration = "Windows.Foundation.IActivatableClassRegistration";

        [NativeTypeName("const WCHAR [58]")]
        public const string InterfaceName_Windows_Foundation_IDllServerActivatableClassRegistration = "Windows.Foundation.IDllServerActivatableClassRegistration";

        [NativeTypeName("const WCHAR [58]")]
        public const string InterfaceName_Windows_Foundation_IExeServerActivatableClassRegistration = "Windows.Foundation.IExeServerActivatableClassRegistration";

        [NativeTypeName("const WCHAR [42]")]
        public const string InterfaceName_Windows_Foundation_IExeServerRegistration = "Windows.Foundation.IExeServerRegistration";

        [NativeTypeName("const WCHAR [57]")]
        public const string RuntimeClass_Windows_Foundation_DllServerActivatableClassRegistration = "Windows.Foundation.DllServerActivatableClassRegistration";

        [NativeTypeName("const WCHAR [57]")]
        public const string RuntimeClass_Windows_Foundation_ExeServerActivatableClassRegistration = "Windows.Foundation.ExeServerActivatableClassRegistration";

        [NativeTypeName("const WCHAR [41]")]
        public const string RuntimeClass_Windows_Foundation_ExeServerRegistration = "Windows.Foundation.ExeServerRegistration";

        public static readonly Guid IID_IActivatableClassRegistration = new Guid(0x9BBCAE23, 0x3DD6, 0x49C3, 0xB6, 0x3C, 0x1C, 0x58, 0x7E, 0x7A, 0x6A, 0x67);

        public static readonly Guid IID_IDllServerActivatableClassRegistration = new Guid(0xC8AA04F6, 0x66C6, 0x46A3, 0x8F, 0xE6, 0xF5, 0x6B, 0xE7, 0xDD, 0xC0, 0x91);

        public static readonly Guid IID_IExeServerActivatableClassRegistration = new Guid(0x9308C3C5, 0xC2AC, 0x49D1, 0xA0, 0x24, 0x66, 0x0A, 0x2B, 0xB5, 0xD5, 0xAC);

        public static readonly Guid IID_IExeServerRegistration = new Guid(0xEC734A06, 0x0401, 0x4317, 0xBA, 0xC1, 0x3B, 0x7E, 0x20, 0x72, 0x42, 0xE3);
    }
}
