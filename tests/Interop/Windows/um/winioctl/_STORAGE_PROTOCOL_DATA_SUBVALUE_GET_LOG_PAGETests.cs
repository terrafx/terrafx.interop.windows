// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="_STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE" /> struct.</summary>
    public static unsafe class _STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGETests
    {
        /// <summary>Validates that the <see cref="_STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<_STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE>(), Is.EqualTo(sizeof(_STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE)));
        }

        /// <summary>Validates that the <see cref="_STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(_STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="_STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(_STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE), Is.EqualTo(4));
        }
    }
}
