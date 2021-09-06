// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CompileStatusInfo" /> struct.</summary>
    public static unsafe class CompileStatusInfoTests
    {
        /// <summary>Validates that the <see cref="CompileStatusInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CompileStatusInfo>(), Is.EqualTo(sizeof(CompileStatusInfo)));
        }

        /// <summary>Validates that the <see cref="CompileStatusInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CompileStatusInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CompileStatusInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CompileStatusInfo), Is.EqualTo(24));
        }
    }
}
