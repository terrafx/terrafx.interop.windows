// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDiaEnumSourceFiles" /> struct.</summary>
    public static unsafe partial class IDiaEnumSourceFilesTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDiaEnumSourceFiles" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDiaEnumSourceFiles).GUID, Is.EqualTo(IID_IDiaEnumSourceFiles));
        }

        /// <summary>Validates that the <see cref="IDiaEnumSourceFiles" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDiaEnumSourceFiles>(), Is.EqualTo(sizeof(IDiaEnumSourceFiles)));
        }

        /// <summary>Validates that the <see cref="IDiaEnumSourceFiles" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDiaEnumSourceFiles).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDiaEnumSourceFiles" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDiaEnumSourceFiles), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDiaEnumSourceFiles), Is.EqualTo(4));
            }
        }
    }
}
