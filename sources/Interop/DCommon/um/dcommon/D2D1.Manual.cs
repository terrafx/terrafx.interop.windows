// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    internal static unsafe partial class D2D1
    {
        private const string LibraryPath = "D2D1";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D2D1MakeRotateMatrix", ExactSpelling = true)]
        public static extern void D2D1MakeRotateMatrix([NativeTypeName("FLOAT")] float angle, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D2D1MakeSkewMatrix", ExactSpelling = true)]
        public static extern void D2D1MakeSkewMatrix([NativeTypeName("FLOAT")] float angleX, [NativeTypeName("FLOAT")] float angleY, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D2D1IsMatrixInvertible", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int D2D1IsMatrixInvertible([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D2D1InvertMatrix", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int D2D1InvertMatrix([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D2D1SinCos", ExactSpelling = true)]
        public static extern void D2D1SinCos([NativeTypeName("FLOAT")] float angle, [NativeTypeName("FLOAT *")] float* s, [NativeTypeName("FLOAT *")] float* c);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D2D1Tan", ExactSpelling = true)]
        [return: NativeTypeName("FLOAT")]
        public static extern float D2D1Tan([NativeTypeName("FLOAT")] float angle);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.StdCall, EntryPoint = "D2D1Vec3Length", ExactSpelling = true)]
        [return: NativeTypeName("FLOAT")]
        public static extern float D2D1Vec3Length([NativeTypeName("FLOAT")] float x, [NativeTypeName("FLOAT")] float y, [NativeTypeName("FLOAT")] float z);
    }
}
