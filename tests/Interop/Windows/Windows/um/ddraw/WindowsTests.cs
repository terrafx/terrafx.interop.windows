// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="Windows" /> class.</summary>
    public static unsafe partial class WindowsTests
    {
        /// <summary>Validates that the value of the <see cref="CLSID_DirectDraw" /> property is correct.</summary>
        [Test]
        public static void CLSID_DirectDrawTest()
        {
            Assert.That(CLSID_DirectDraw, Is.EqualTo(new Guid(0xD7B70EE0, 0x4340, 0x11CF, 0xB0, 0x63, 0x00, 0x20, 0xAF, 0xC2, 0xCD, 0x35)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DirectDraw7" /> property is correct.</summary>
        [Test]
        public static void CLSID_DirectDraw7Test()
        {
            Assert.That(CLSID_DirectDraw7, Is.EqualTo(new Guid(0x3c305196, 0x50db, 0x11d3, 0x9c, 0xfe, 0x00, 0xc0, 0x4f, 0xd9, 0x30, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="CLSID_DirectDrawClipper" /> property is correct.</summary>
        [Test]
        public static void CLSID_DirectDrawClipperTest()
        {
            Assert.That(CLSID_DirectDrawClipper, Is.EqualTo(new Guid(0x593817A0, 0x7DB3, 0x11CF, 0xA2, 0xDE, 0x00, 0xAA, 0x00, 0xb9, 0x33, 0x56)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDraw" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDrawTest()
        {
            Assert.That(IID_IDirectDraw, Is.EqualTo(new Guid(0x6C14DB80, 0xA733, 0x11CE, 0xA5, 0x21, 0x00, 0x20, 0xAF, 0x0B, 0xE5, 0x60)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDraw2" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDraw2Test()
        {
            Assert.That(IID_IDirectDraw2, Is.EqualTo(new Guid(0xB3A6F3E0, 0x2B43, 0x11CF, 0xA2, 0xDE, 0x00, 0xAA, 0x00, 0xB9, 0x33, 0x56)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDraw4" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDraw4Test()
        {
            Assert.That(IID_IDirectDraw4, Is.EqualTo(new Guid(0x9c59509a, 0x39bd, 0x11d1, 0x8c, 0x4a, 0x00, 0xc0, 0x4f, 0xd9, 0x30, 0xc5)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDraw7" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDraw7Test()
        {
            Assert.That(IID_IDirectDraw7, Is.EqualTo(new Guid(0x15e65ec0, 0x3b9c, 0x11d2, 0xb9, 0x2f, 0x00, 0x60, 0x97, 0x97, 0xea, 0x5b)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDrawSurface" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDrawSurfaceTest()
        {
            Assert.That(IID_IDirectDrawSurface, Is.EqualTo(new Guid(0x6C14DB81, 0xA733, 0x11CE, 0xA5, 0x21, 0x00, 0x20, 0xAF, 0x0B, 0xE5, 0x60)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDrawSurface2" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDrawSurface2Test()
        {
            Assert.That(IID_IDirectDrawSurface2, Is.EqualTo(new Guid(0x57805885, 0x6eec, 0x11cf, 0x94, 0x41, 0xa8, 0x23, 0x03, 0xc1, 0x0e, 0x27)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDrawSurface3" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDrawSurface3Test()
        {
            Assert.That(IID_IDirectDrawSurface3, Is.EqualTo(new Guid(0xDA044E00, 0x69B2, 0x11D0, 0xA1, 0xD5, 0x00, 0xAA, 0x00, 0xB8, 0xDF, 0xBB)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDrawSurface4" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDrawSurface4Test()
        {
            Assert.That(IID_IDirectDrawSurface4, Is.EqualTo(new Guid(0x0B2B8630, 0xAD35, 0x11D0, 0x8E, 0xA6, 0x00, 0x60, 0x97, 0x97, 0xEA, 0x5B)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDrawSurface7" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDrawSurface7Test()
        {
            Assert.That(IID_IDirectDrawSurface7, Is.EqualTo(new Guid(0x06675a80, 0x3b9b, 0x11d2, 0xb9, 0x2f, 0x00, 0x60, 0x97, 0x97, 0xea, 0x5b)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDrawPalette" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDrawPaletteTest()
        {
            Assert.That(IID_IDirectDrawPalette, Is.EqualTo(new Guid(0x6C14DB84, 0xA733, 0x11CE, 0xA5, 0x21, 0x00, 0x20, 0xAF, 0x0B, 0xE5, 0x60)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDrawClipper" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDrawClipperTest()
        {
            Assert.That(IID_IDirectDrawClipper, Is.EqualTo(new Guid(0x6C14DB85, 0xA733, 0x11CE, 0xA5, 0x21, 0x00, 0x20, 0xAF, 0x0B, 0xE5, 0x60)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDrawColorControl" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDrawColorControlTest()
        {
            Assert.That(IID_IDirectDrawColorControl, Is.EqualTo(new Guid(0x4B9F0EE0, 0x0D7E, 0x11D0, 0x9B, 0x06, 0x00, 0xA0, 0xC9, 0x03, 0xA3, 0xB8)));
        }

        /// <summary>Validates that the value of the <see cref="IID_IDirectDrawGammaControl" /> property is correct.</summary>
        [Test]
        public static void IID_IDirectDrawGammaControlTest()
        {
            Assert.That(IID_IDirectDrawGammaControl, Is.EqualTo(new Guid(0x69C11C3E, 0xB46B, 0x11D1, 0xAD, 0x7A, 0x00, 0xC0, 0x4F, 0xC2, 0x9B, 0x4E)));
        }
    }
}
