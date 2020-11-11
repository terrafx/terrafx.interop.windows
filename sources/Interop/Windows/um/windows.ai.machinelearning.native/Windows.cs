// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        public static readonly Guid IID_ILearningModelOperatorProviderNative = new Guid(0x1ADAA23A, 0xEB67, 0x41F3, 0xAA, 0xD8, 0x5D, 0x98, 0x4E, 0x9B, 0xAC, 0xD4);

        public static readonly Guid IID_ITensorNative = new Guid(0x52F547EF, 0x5B03, 0x49B5, 0x82, 0xD6, 0x56, 0x5F, 0x1E, 0xE0, 0xDD, 0x49);

        public static readonly Guid IID_ITensorStaticsNative = new Guid(0x39D055A4, 0x66F6, 0x4EBC, 0x95, 0xD9, 0x7A, 0x29, 0xEB, 0xE7, 0x69, 0x0A);

        public static readonly Guid IID_ILearningModelDeviceFactoryNative = new Guid(0x1E9B31A1, 0x662E, 0x4AE0, 0xAF, 0x67, 0xF6, 0x3B, 0xB3, 0x37, 0xE6, 0x34);
    }
}
