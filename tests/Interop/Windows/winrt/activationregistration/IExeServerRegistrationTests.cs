// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/activationregistration.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IExeServerRegistration" /> struct.</summary>
    public static unsafe class IExeServerRegistrationTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IExeServerRegistration" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IExeServerRegistration).GUID, Is.EqualTo(IID_IExeServerRegistration));
        }

        /// <summary>Validates that the <see cref="IExeServerRegistration" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IExeServerRegistration>(), Is.EqualTo(sizeof(IExeServerRegistration)));
        }

        /// <summary>Validates that the <see cref="IExeServerRegistration" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IExeServerRegistration).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IExeServerRegistration" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IExeServerRegistration), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IExeServerRegistration), Is.EqualTo(4));
            }
        }
    }
}
