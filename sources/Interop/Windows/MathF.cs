// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
#if NETSTANDARD2_0
    internal static class MathF
    {
        public const float PI = (float)Math.PI;

        public static float Asin(float x) => (float)Math.Asin(x);

        public static float Log10(float x) => (float)Math.Log10(x);

        public static float Pow(float x, float y) => (float)Math.Pow(x, y);

        public static float Sin(float x) => (float)Math.Sin(x);
    }
#endif
}
