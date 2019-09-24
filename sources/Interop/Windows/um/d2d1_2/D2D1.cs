// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1_2.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    public static unsafe partial class D2D1
    {
        public static readonly Guid IID_ID2D1GeometryRealization = new Guid(0xA16907D7, 0xBC02, 0x4801, 0x99, 0xE8, 0x8C, 0xF7, 0xF4, 0x85, 0xF7, 0x74);

        public static readonly Guid IID_ID2D1DeviceContext1 = new Guid(0xD37F57E4, 0x6908, 0x459F, 0xA1, 0x99, 0xE7, 0x2F, 0x24, 0xF7, 0x99, 0x87);

        public static readonly Guid IID_ID2D1Device1 = new Guid(0xD21768E1, 0x23A4, 0x4823, 0xA1, 0x4B, 0x7C, 0x3E, 0xBA, 0x85, 0xD6, 0x58);

        public static readonly Guid IID_ID2D1Factory2 = new Guid(0x94F81A73, 0x9212, 0x4376, 0x9C, 0x58, 0xB1, 0x6A, 0x3A, 0x0D, 0x39, 0x92);

        public static readonly Guid IID_ID2D1CommandSink1 = new Guid(0x9EB767FD, 0x4269, 0x4467, 0xB8, 0xC2, 0xEB, 0x30, 0xCB, 0x30, 0x57, 0x43);

        [DllImport(DllName, BestFitMapping = false, CallingConvention = CallingConvention.Winapi, CharSet = CharSet.Unicode, EntryPoint = "D2D1ComputeMaximumScaleFactor", ExactSpelling = true, PreserveSig = true, SetLastError = false, ThrowOnUnmappableChar = false)]
        [return: NativeTypeName("FLOAT")]
        public static extern float D2D1ComputeMaximumScaleFactor(
            [In, NativeTypeName("D2D1_MATRIX_3X2_F")] D2D_MATRIX_3X2_F* matrix
        );
    }
}
