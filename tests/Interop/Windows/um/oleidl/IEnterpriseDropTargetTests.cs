// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IEnterpriseDropTarget" /> struct.</summary>
    public static unsafe partial class IEnterpriseDropTargetTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IEnterpriseDropTarget" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IEnterpriseDropTarget).GUID, Is.EqualTo(IID_IEnterpriseDropTarget));
        }

        /// <summary>Validates that the <see cref="IEnterpriseDropTarget" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IEnterpriseDropTarget>(), Is.EqualTo(sizeof(IEnterpriseDropTarget)));
        }

        /// <summary>Validates that the <see cref="IEnterpriseDropTarget" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IEnterpriseDropTarget).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IEnterpriseDropTarget" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IEnterpriseDropTarget), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IEnterpriseDropTarget), Is.EqualTo(4));
            }
        }
    }
}
