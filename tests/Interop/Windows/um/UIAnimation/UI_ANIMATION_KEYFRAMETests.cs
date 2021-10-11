// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="UI_ANIMATION_KEYFRAME" /> struct.</summary>
    public static unsafe partial class UI_ANIMATION_KEYFRAMETests
    {
        /// <summary>Validates that the <see cref="UI_ANIMATION_KEYFRAME" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<UI_ANIMATION_KEYFRAME>(), Is.EqualTo(sizeof(UI_ANIMATION_KEYFRAME)));
        }

        /// <summary>Validates that the <see cref="UI_ANIMATION_KEYFRAME" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(UI_ANIMATION_KEYFRAME).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="UI_ANIMATION_KEYFRAME" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(UI_ANIMATION_KEYFRAME), Is.EqualTo(4));
        }
    }
}
