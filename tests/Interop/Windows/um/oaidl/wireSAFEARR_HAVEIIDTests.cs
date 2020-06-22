// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="wireSAFEARR_HAVEIID" /> struct.</summary>
    public static unsafe class wireSAFEARR_HAVEIIDTests
    {
        /// <summary>Validates that the <see cref="wireSAFEARR_HAVEIID" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<wireSAFEARR_HAVEIID>(), Is.EqualTo(sizeof(wireSAFEARR_HAVEIID)));
        }

        /// <summary>Validates that the <see cref="wireSAFEARR_HAVEIID" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(wireSAFEARR_HAVEIID).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="wireSAFEARR_HAVEIID" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(wireSAFEARR_HAVEIID), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(wireSAFEARR_HAVEIID), Is.EqualTo(24));
            }
        }
    }
}
