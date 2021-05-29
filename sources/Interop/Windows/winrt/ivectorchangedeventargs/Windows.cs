// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/ivectorchangedeventargs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const WCHAR [55]")]
        public const string InterfaceName_Windows_Foundation_Collections_IVectorChangedEventArgs = "Windows.Foundation.Collections.IVectorChangedEventArgs";

        public static readonly Guid IID_IVectorChangedEventArgs = new Guid(0x575933DF, 0x34FE, 0x4480, 0xAF, 0x15, 0x07, 0x69, 0x1F, 0x3D, 0x5D, 0x9B);
    }
}
