// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IRecordInfo" /> struct.</summary>
    public static class IRecordInfoTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IRecordInfo" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IRecordInfo).GUID, Is.EqualTo(IID_IRecordInfo));
        }

        /// <summary>Validates that the layout of the <see cref="IRecordInfo" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IRecordInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="IRecordInfo" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<IRecordInfo>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<IRecordInfo>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="IRecordInfo.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="IRecordInfo" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(IRecordInfo.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="IRecordInfo" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<IRecordInfo.Vtbl>(), Is.EqualTo(152));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<IRecordInfo.Vtbl>(), Is.EqualTo(76));
                }
            }
        }
    }
}
