// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static TerraFX.Interop.D3D12;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID3D12RootSignatureDeserializer" /> struct.</summary>
    public static class ID3D12RootSignatureDeserializerTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12RootSignatureDeserializer" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ID3D12RootSignatureDeserializer).GUID, Is.EqualTo(IID_ID3D12RootSignatureDeserializer));
        }

        /// <summary>Validates that the layout of the <see cref="ID3D12RootSignatureDeserializer" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID3D12RootSignatureDeserializer).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the size of the <see cref="ID3D12RootSignatureDeserializer" /> struct is correct.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(Marshal.SizeOf<ID3D12RootSignatureDeserializer>(), Is.EqualTo(8));
            }
            else
            {
                Assert.That(Marshal.SizeOf<ID3D12RootSignatureDeserializer>(), Is.EqualTo(4));
            }
        }

        /// <summary>Provides validation of the <see cref="ID3D12RootSignatureDeserializer.Vtbl" /> struct.</summary>
        public static class VtblTests
        {
            /// <summary>Validates that the layout of the <see cref="ID3D12RootSignatureDeserializer" /> struct is <see cref="LayoutKind.Sequential" />.</summary>
            [Test]
            public static void IsLayoutSequentialTest()
            {
                Assert.That(typeof(ID3D12RootSignatureDeserializer.Vtbl).IsLayoutSequential, Is.True);
            }

            /// <summary>Validates that the size of the <see cref="ID3D12RootSignatureDeserializer" /> struct is correct.</summary>
            [Test]
            public static void SizeOfTest()
            {
                if (Environment.Is64BitProcess)
                {
                    Assert.That(Marshal.SizeOf<ID3D12RootSignatureDeserializer.Vtbl>(), Is.EqualTo(32));
                }
                else
                {
                    Assert.That(Marshal.SizeOf<ID3D12RootSignatureDeserializer.Vtbl>(), Is.EqualTo(16));
                }
            }
        }
    }
}
