// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.D2D1_ANTIALIAS_MODE;
using static TerraFX.Interop.D2D1_LAYER_OPTIONS;
using static TerraFX.Interop.D2D1_LAYER_PARAMETERS;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D1_LAYER_PARAMETERS" /> struct.</summary>
    public static unsafe class D2D1_LAYER_PARAMETERSTests
    {
        /// <summary>Validates that the <see cref="D2D1_LAYER_PARAMETERS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D2D1_LAYER_PARAMETERS>(), Is.EqualTo(sizeof(D2D1_LAYER_PARAMETERS)));
        }

        /// <summary>Validates that the <see cref="D2D1_LAYER_PARAMETERS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D1_LAYER_PARAMETERS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D2D1_LAYER_PARAMETERS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(D2D1_LAYER_PARAMETERS), Is.EqualTo(72));
            }
            else
            {
                Assert.That(sizeof(D2D1_LAYER_PARAMETERS), Is.EqualTo(60));
            }
        }

        /// <summary>Validates that the value of the <see cref="DEFAULT" /> property is correct.</summary>
        [Test]
        public static void DEFAULTTest()
        {
            Assert.That(DEFAULT.contentBounds, Is.EqualTo(InfiniteRect));
            Assert.That((nuint)DEFAULT.geometricMask, Is.EqualTo((nuint)0));
            Assert.That(DEFAULT.maskAntialiasMode, Is.EqualTo(D2D1_ANTIALIAS_MODE_PER_PRIMITIVE));
            Assert.That(DEFAULT.maskTransform, Is.EqualTo(IdentityMatrix));
            Assert.That(DEFAULT.opacity, Is.EqualTo(1.0f));
            Assert.That((nuint)DEFAULT.opacityBrush, Is.EqualTo((nuint)0));
            Assert.That(DEFAULT.layerOptions, Is.EqualTo(D2D1_LAYER_OPTIONS_NONE));
        }
    }
}
