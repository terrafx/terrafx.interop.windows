// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="__MIDL___MIDL_itf_dia2_0000_0042_0001" /> struct.</summary>
    public static unsafe partial class __MIDL___MIDL_itf_dia2_0000_0042_0001Tests
    {
        /// <summary>Validates that the <see cref="__MIDL___MIDL_itf_dia2_0000_0042_0001" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<__MIDL___MIDL_itf_dia2_0000_0042_0001>(), Is.EqualTo(sizeof(__MIDL___MIDL_itf_dia2_0000_0042_0001)));
        }

        /// <summary>Validates that the <see cref="__MIDL___MIDL_itf_dia2_0000_0042_0001" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(__MIDL___MIDL_itf_dia2_0000_0042_0001).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="__MIDL___MIDL_itf_dia2_0000_0042_0001" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(__MIDL___MIDL_itf_dia2_0000_0042_0001), Is.EqualTo(16));
        }
    }
}
