// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="tagFolderSetData" /> struct.</summary>
    public static unsafe partial class tagFolderSetDataTests
    {
        /// <summary>Validates that the <see cref="tagFolderSetData" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<tagFolderSetData>(), Is.EqualTo(sizeof(tagFolderSetData)));
        }

        /// <summary>Validates that the <see cref="tagFolderSetData" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(tagFolderSetData).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="tagFolderSetData" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(tagFolderSetData), Is.EqualTo(28));
        }
    }
}
