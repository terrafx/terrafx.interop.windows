// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.foundation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const WCHAR [44]")]
        public const string InterfaceName_Windows_Foundation_Collections_IPropertySet = "Windows.Foundation.Collections.IPropertySet";

        [NativeTypeName("const WCHAR [32]")]
        public const string InterfaceName_Windows_Foundation_IAsyncAction = "Windows.Foundation.IAsyncAction";

        [NativeTypeName("const WCHAR [29]")]
        public const string InterfaceName_Windows_Foundation_IClosable = "Windows.Foundation.IClosable";

        [NativeTypeName("const WCHAR [29]")]
        public const string InterfaceName_Windows_Foundation_IDeferral = "Windows.Foundation.IDeferral";

        [NativeTypeName("const WCHAR [36]")]
        public const string InterfaceName_Windows_Foundation_IDeferralFactory = "Windows.Foundation.IDeferralFactory";

        [NativeTypeName("const WCHAR [41]")]
        public const string InterfaceName_Windows_Foundation_IGetActivationFactory = "Windows.Foundation.IGetActivationFactory";

        [NativeTypeName("const WCHAR [38]")]
        public const string InterfaceName_Windows_Foundation_IGuidHelperStatics = "Windows.Foundation.IGuidHelperStatics";

        [NativeTypeName("const WCHAR [33]")]
        public const string InterfaceName_Windows_Foundation_IMemoryBuffer = "Windows.Foundation.IMemoryBuffer";

        [NativeTypeName("const WCHAR [40]")]
        public const string InterfaceName_Windows_Foundation_IMemoryBufferFactory = "Windows.Foundation.IMemoryBufferFactory";

        [NativeTypeName("const WCHAR [42]")]
        public const string InterfaceName_Windows_Foundation_IMemoryBufferReference = "Windows.Foundation.IMemoryBufferReference";

        [NativeTypeName("const WCHAR [34]")]
        public const string InterfaceName_Windows_Foundation_IPropertyValue = "Windows.Foundation.IPropertyValue";

        [NativeTypeName("const WCHAR [41]")]
        public const string InterfaceName_Windows_Foundation_IPropertyValueStatics = "Windows.Foundation.IPropertyValueStatics";

        [NativeTypeName("const WCHAR [31]")]
        public const string InterfaceName_Windows_Foundation_IStringable = "Windows.Foundation.IStringable";

        [NativeTypeName("const WCHAR [37]")]
        public const string InterfaceName_Windows_Foundation_IUriEscapeStatics = "Windows.Foundation.IUriEscapeStatics";

        [NativeTypeName("const WCHAR [36]")]
        public const string InterfaceName_Windows_Foundation_IUriRuntimeClass = "Windows.Foundation.IUriRuntimeClass";

        [NativeTypeName("const WCHAR [43]")]
        public const string InterfaceName_Windows_Foundation_IUriRuntimeClassFactory = "Windows.Foundation.IUriRuntimeClassFactory";

        [NativeTypeName("const WCHAR [60]")]
        public const string InterfaceName_Windows_Foundation_IUriRuntimeClassWithAbsoluteCanonicalUri = "Windows.Foundation.IUriRuntimeClassWithAbsoluteCanonicalUri";

        [NativeTypeName("const WCHAR [43]")]
        public const string InterfaceName_Windows_Foundation_IWwwFormUrlDecoderEntry = "Windows.Foundation.IWwwFormUrlDecoderEntry";

        [NativeTypeName("const WCHAR [50]")]
        public const string InterfaceName_Windows_Foundation_IWwwFormUrlDecoderRuntimeClass = "Windows.Foundation.IWwwFormUrlDecoderRuntimeClass";

        [NativeTypeName("const WCHAR [57]")]
        public const string InterfaceName_Windows_Foundation_IWwwFormUrlDecoderRuntimeClassFactory = "Windows.Foundation.IWwwFormUrlDecoderRuntimeClassFactory";

        [NativeTypeName("const WCHAR [43]")]
        public const string RuntimeClass_Windows_Foundation_Collections_PropertySet = "Windows.Foundation.Collections.PropertySet";

        [NativeTypeName("const WCHAR [41]")]
        public const string RuntimeClass_Windows_Foundation_Collections_StringMap = "Windows.Foundation.Collections.StringMap";

        [NativeTypeName("const WCHAR [40]")]
        public const string RuntimeClass_Windows_Foundation_Collections_ValueSet = "Windows.Foundation.Collections.ValueSet";

        [NativeTypeName("const WCHAR [28]")]
        public const string RuntimeClass_Windows_Foundation_Deferral = "Windows.Foundation.Deferral";

        [NativeTypeName("const WCHAR [30]")]
        public const string RuntimeClass_Windows_Foundation_GuidHelper = "Windows.Foundation.GuidHelper";

        [NativeTypeName("const WCHAR [32]")]
        public const string RuntimeClass_Windows_Foundation_MemoryBuffer = "Windows.Foundation.MemoryBuffer";

        [NativeTypeName("const WCHAR [33]")]
        public const string RuntimeClass_Windows_Foundation_PropertyValue = "Windows.Foundation.PropertyValue";

        [NativeTypeName("const WCHAR [23]")]
        public const string RuntimeClass_Windows_Foundation_Uri = "Windows.Foundation.Uri";

        [NativeTypeName("const WCHAR [37]")]
        public const string RuntimeClass_Windows_Foundation_WwwFormUrlDecoder = "Windows.Foundation.WwwFormUrlDecoder";

        [NativeTypeName("const WCHAR [42]")]
        public const string RuntimeClass_Windows_Foundation_WwwFormUrlDecoderEntry = "Windows.Foundation.WwwFormUrlDecoderEntry";

        public static readonly Guid IID_IAsyncActionCompletedHandler = new Guid(0xA4ED5C81, 0x76C9, 0x40BD, 0x8B, 0xE6, 0xB1, 0xD9, 0x0F, 0xB2, 0x0A, 0xE7);

        public static readonly Guid IID_IDeferralCompletedHandler = new Guid(0xED32A372, 0xF3C8, 0x4FAA, 0x9C, 0xFB, 0x47, 0x01, 0x48, 0xDA, 0x38, 0x88);

        public static readonly Guid IID_IPropertySet = new Guid(0x8A43ED9F, 0xF4E6, 0x4421, 0xAC, 0xF9, 0x1D, 0xAB, 0x29, 0x86, 0x82, 0x0C);

        public static readonly Guid IID_IAsyncAction = new Guid(0x5A648006, 0x843A, 0x4DA9, 0x86, 0x5B, 0x9D, 0x26, 0xE5, 0xDF, 0xAD, 0x7B);

        public static readonly Guid IID_IClosable = new Guid(0x30D5A829, 0x7FA4, 0x4026, 0x83, 0xBB, 0xD7, 0x5B, 0xAE, 0x4E, 0xA9, 0x9E);

        public static readonly Guid IID_IDeferral = new Guid(0xD6269732, 0x3B7F, 0x46A7, 0xB4, 0x0B, 0x4F, 0xDC, 0xA2, 0xA2, 0xC6, 0x93);

        public static readonly Guid IID_IDeferralFactory = new Guid(0x65A1ECC5, 0x3FB5, 0x4832, 0x8C, 0xA9, 0xF0, 0x61, 0xB2, 0x81, 0xD1, 0x3A);

        public static readonly Guid IID_IGetActivationFactory = new Guid(0x4EDB8EE2, 0x96DD, 0x49A7, 0x94, 0xF7, 0x46, 0x07, 0xDD, 0xAB, 0x8E, 0x3C);

        public static readonly Guid IID_IGuidHelperStatics = new Guid(0x59C7966B, 0xAE52, 0x5283, 0xAD, 0x7F, 0xA1, 0xB9, 0xE9, 0x67, 0x8A, 0xDD);

        public static readonly Guid IID_IMemoryBuffer = new Guid(0xFBC4DD2A, 0x245B, 0x11E4, 0xAF, 0x98, 0x68, 0x94, 0x23, 0x26, 0x0C, 0xF8);

        public static readonly Guid IID_IMemoryBufferFactory = new Guid(0xFBC4DD2B, 0x245B, 0x11E4, 0xAF, 0x98, 0x68, 0x94, 0x23, 0x26, 0x0C, 0xF8);

        public static readonly Guid IID_IMemoryBufferReference = new Guid(0xFBC4DD29, 0x245B, 0x11E4, 0xAF, 0x98, 0x68, 0x94, 0x23, 0x26, 0x0C, 0xF8);

        public static readonly Guid IID_IPropertyValue = new Guid(0x4BD682DD, 0x7554, 0x40E9, 0x9A, 0x9B, 0x82, 0x65, 0x4E, 0xDE, 0x7E, 0x62);

        public static readonly Guid IID_IPropertyValueStatics = new Guid(0x629BDBC8, 0xD932, 0x4FF4, 0x96, 0xB9, 0x8D, 0x96, 0xC5, 0xC1, 0xE8, 0x58);

        public static readonly Guid IID_IStringable = new Guid(0x96369F54, 0x8EB6, 0x48F0, 0xAB, 0xCE, 0xC1, 0xB2, 0x11, 0xE6, 0x27, 0xC3);

        public static readonly Guid IID_IUriEscapeStatics = new Guid(0xC1D432BA, 0xC824, 0x4452, 0xA7, 0xFD, 0x51, 0x2B, 0xC3, 0xBB, 0xE9, 0xA1);

        public static readonly Guid IID_IUriRuntimeClass = new Guid(0x9E365E57, 0x48B2, 0x4160, 0x95, 0x6F, 0xC7, 0x38, 0x51, 0x20, 0xBB, 0xFC);

        public static readonly Guid IID_IUriRuntimeClassFactory = new Guid(0x44A9796F, 0x723E, 0x4FDF, 0xA2, 0x18, 0x03, 0x3E, 0x75, 0xB0, 0xC0, 0x84);

        public static readonly Guid IID_IUriRuntimeClassWithAbsoluteCanonicalUri = new Guid(0x758D9661, 0x221C, 0x480F, 0xA3, 0x39, 0x50, 0x65, 0x66, 0x73, 0xF4, 0x6F);

        public static readonly Guid IID_IWwwFormUrlDecoderEntry = new Guid(0x125E7431, 0xF678, 0x4E8E, 0xB6, 0x70, 0x20, 0xA9, 0xB0, 0x6C, 0x51, 0x2D);

        public static readonly Guid IID_IWwwFormUrlDecoderRuntimeClass = new Guid(0xD45A0451, 0xF225, 0x4542, 0x92, 0x96, 0x0E, 0x1D, 0xF5, 0xD2, 0x54, 0xDF);

        public static readonly Guid IID_IWwwFormUrlDecoderRuntimeClassFactory = new Guid(0x5B8C6B3D, 0x24AE, 0x41B5, 0xA1, 0xBF, 0xF0, 0xC3, 0xD5, 0x44, 0x84, 0x5B);
    }
}
