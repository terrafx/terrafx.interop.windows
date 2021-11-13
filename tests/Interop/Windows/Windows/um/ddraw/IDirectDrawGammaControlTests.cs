// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDirectDrawGammaControl" /> struct.</summary>
    public static unsafe partial class IDirectDrawGammaControlTests
    {
        /// <summary>Validates that the <see cref="IDirectDrawGammaControl" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDirectDrawGammaControl>(), Is.EqualTo(sizeof(IDirectDrawGammaControl)));
        }

        /// <summary>Validates that the <see cref="IDirectDrawGammaControl" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDirectDrawGammaControl).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDirectDrawGammaControl" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDirectDrawGammaControl), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDirectDrawGammaControl), Is.EqualTo(4));
            }
        }
    }
}
