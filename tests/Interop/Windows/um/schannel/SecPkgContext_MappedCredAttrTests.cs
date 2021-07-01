// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SecPkgContext_MappedCredAttr" /> struct.</summary>
    public static unsafe class SecPkgContext_MappedCredAttrTests
    {
        /// <summary>Validates that the <see cref="SecPkgContext_MappedCredAttr" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SecPkgContext_MappedCredAttr>(), Is.EqualTo(sizeof(SecPkgContext_MappedCredAttr)));
        }

        /// <summary>Validates that the <see cref="SecPkgContext_MappedCredAttr" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SecPkgContext_MappedCredAttr).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SecPkgContext_MappedCredAttr" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SecPkgContext_MappedCredAttr), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(SecPkgContext_MappedCredAttr), Is.EqualTo(8));
            }
        }
    }
}
