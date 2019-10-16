// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class D2D1
    {
        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D2D1GetGradientMeshInteriorPointsFromCoonsPatch", ExactSpelling = true)]
        public static extern void D2D1GetGradientMeshInteriorPointsFromCoonsPatch([NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* pPoint0, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* pPoint1, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* pPoint2, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* pPoint3, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* pPoint4, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* pPoint5, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* pPoint6, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* pPoint7, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* pPoint8, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* pPoint9, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* pPoint10, [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* pPoint11, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* pTensorPoint11, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* pTensorPoint12, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* pTensorPoint21, [NativeTypeName("D2D1_POINT_2F *")] D2D_POINT_2F* pTensorPoint22);
    }
}
