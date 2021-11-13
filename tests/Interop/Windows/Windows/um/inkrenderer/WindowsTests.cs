// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/inkrenderer.h and um/inkrenderer_i.c in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="IID_IInkD2DRenderer" /> property is correct.</summary>
        [Test]
        public static void IID_IInkD2DRendererTest()
        {
            Assert.That(IID_IInkD2DRenderer, Is.EqualTo(new Guid(0x407fb1de, 0xf85a, 0x4150, 0x97, 0xcf, 0xb7, 0xfb, 0x27, 0x4f, 0xb4, 0xf8)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IInkD2DRenderer2" /> property is correct.</summary>
        [Test]
        public static void IID_IInkD2DRenderer2Test()
        {
            Assert.That(IID_IInkD2DRenderer2, Is.EqualTo(new Guid(0x0a95dcd9, 0x4578, 0x4b71, 0xb2, 0x0b, 0xbf, 0x66, 0x4d, 0x4b, 0xfe, 0xee)));
        }

        /// <summary>Validates that the value of the <see cref="LIBID_InkD2DRendererLib" /> property is correct.</summary>
        [Test]
        public static void LIBID_InkD2DRendererLibTest()
        {
            Assert.That(LIBID_InkD2DRendererLib, Is.EqualTo(new Guid(0x390d0ab0, 0x19e2, 0x46bb, 0x86, 0x2e, 0xb0, 0x9f, 0x3c, 0xdc, 0xf8, 0xb9)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_InkD2DRenderer" /> property is correct.</summary>
        [Test]
        public static void CLSID_InkD2DRendererTest()
        {
            Assert.That(CLSID_InkD2DRenderer, Is.EqualTo(new Guid(0x4044e60c, 0x7b01, 0x4671, 0xa9, 0x7c, 0x04, 0xe0, 0x21, 0x0a, 0x07, 0xa5)));
        }
    }
}
