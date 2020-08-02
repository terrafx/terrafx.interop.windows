// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IBaseVideoMixer" />struct.</summary>
    public static unsafe class IBaseVideoMixerTests
    {
        /// <summary>Validates that the <see cref="IBaseVideoMixer" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IBaseVideoMixer>(), Is.EqualTo(sizeof(IBaseVideoMixer)));
        }

        /// <summary>Validates that the <see cref="IBaseVideoMixer" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IBaseVideoMixer).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IBaseVideoMixer" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IBaseVideoMixer), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IBaseVideoMixer), Is.EqualTo(4));
            }
        }
    }
}
