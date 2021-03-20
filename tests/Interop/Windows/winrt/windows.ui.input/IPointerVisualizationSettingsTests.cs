// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.input.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IPointerVisualizationSettings" /> struct.</summary>
    public static unsafe class IPointerVisualizationSettingsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IPointerVisualizationSettings" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IPointerVisualizationSettings).GUID, Is.EqualTo(IID_IPointerVisualizationSettings));
        }

        /// <summary>Validates that the <see cref="IPointerVisualizationSettings" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IPointerVisualizationSettings>(), Is.EqualTo(sizeof(IPointerVisualizationSettings)));
        }

        /// <summary>Validates that the <see cref="IPointerVisualizationSettings" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IPointerVisualizationSettings).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IPointerVisualizationSettings" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IPointerVisualizationSettings), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IPointerVisualizationSettings), Is.EqualTo(4));
            }
        }
    }
}
