// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/Windows.ApplicationModel.core.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const WCHAR [44]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_IAppListEntry = "Windows.ApplicationModel.Core.IAppListEntry";

        [NativeTypeName("const WCHAR [45]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_IAppListEntry2 = "Windows.ApplicationModel.Core.IAppListEntry2";

        [NativeTypeName("const WCHAR [45]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_IAppListEntry3 = "Windows.ApplicationModel.Core.IAppListEntry3";

        [NativeTypeName("const WCHAR [47]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_ICoreApplication = "Windows.ApplicationModel.Core.ICoreApplication";

        [NativeTypeName("const WCHAR [48]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_ICoreApplication2 = "Windows.ApplicationModel.Core.ICoreApplication2";

        [NativeTypeName("const WCHAR [48]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_ICoreApplication3 = "Windows.ApplicationModel.Core.ICoreApplication3";

        [NativeTypeName("const WCHAR [51]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_ICoreApplicationExit = "Windows.ApplicationModel.Core.ICoreApplicationExit";

        [NativeTypeName("const WCHAR [61]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_ICoreApplicationUnhandledError = "Windows.ApplicationModel.Core.ICoreApplicationUnhandledError";

        [NativeTypeName("const WCHAR [55]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_ICoreApplicationUseCount = "Windows.ApplicationModel.Core.ICoreApplicationUseCount";

        [NativeTypeName("const WCHAR [51]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_ICoreApplicationView = "Windows.ApplicationModel.Core.ICoreApplicationView";

        [NativeTypeName("const WCHAR [52]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_ICoreApplicationView2 = "Windows.ApplicationModel.Core.ICoreApplicationView2";

        [NativeTypeName("const WCHAR [52]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_ICoreApplicationView3 = "Windows.ApplicationModel.Core.ICoreApplicationView3";

        [NativeTypeName("const WCHAR [52]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_ICoreApplicationView5 = "Windows.ApplicationModel.Core.ICoreApplicationView5";

        [NativeTypeName("const WCHAR [52]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_ICoreApplicationView6 = "Windows.ApplicationModel.Core.ICoreApplicationView6";

        [NativeTypeName("const WCHAR [59]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_ICoreApplicationViewTitleBar = "Windows.ApplicationModel.Core.ICoreApplicationViewTitleBar";

        [NativeTypeName("const WCHAR [56]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_ICoreImmersiveApplication = "Windows.ApplicationModel.Core.ICoreImmersiveApplication";

        [NativeTypeName("const WCHAR [57]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_ICoreImmersiveApplication2 = "Windows.ApplicationModel.Core.ICoreImmersiveApplication2";

        [NativeTypeName("const WCHAR [57]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_ICoreImmersiveApplication3 = "Windows.ApplicationModel.Core.ICoreImmersiveApplication3";

        [NativeTypeName("const WCHAR [45]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_IFrameworkView = "Windows.ApplicationModel.Core.IFrameworkView";

        [NativeTypeName("const WCHAR [51]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_IFrameworkViewSource = "Windows.ApplicationModel.Core.IFrameworkViewSource";

        [NativeTypeName("const WCHAR [58]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_IHostedViewClosingEventArgs = "Windows.ApplicationModel.Core.IHostedViewClosingEventArgs";

        [NativeTypeName("const WCHAR [46]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_IUnhandledError = "Windows.ApplicationModel.Core.IUnhandledError";

        [NativeTypeName("const WCHAR [63]")]
        public const string InterfaceName_Windows_ApplicationModel_Core_IUnhandledErrorDetectedEventArgs = "Windows.ApplicationModel.Core.IUnhandledErrorDetectedEventArgs";

        [NativeTypeName("const WCHAR [43]")]
        public const string RuntimeClass_Windows_ApplicationModel_Core_AppListEntry = "Windows.ApplicationModel.Core.AppListEntry";

        [NativeTypeName("const WCHAR [46]")]
        public const string RuntimeClass_Windows_ApplicationModel_Core_CoreApplication = "Windows.ApplicationModel.Core.CoreApplication";

        [NativeTypeName("const WCHAR [50]")]
        public const string RuntimeClass_Windows_ApplicationModel_Core_CoreApplicationView = "Windows.ApplicationModel.Core.CoreApplicationView";

        [NativeTypeName("const WCHAR [58]")]
        public const string RuntimeClass_Windows_ApplicationModel_Core_CoreApplicationViewTitleBar = "Windows.ApplicationModel.Core.CoreApplicationViewTitleBar";

        [NativeTypeName("const WCHAR [57]")]
        public const string RuntimeClass_Windows_ApplicationModel_Core_HostedViewClosingEventArgs = "Windows.ApplicationModel.Core.HostedViewClosingEventArgs";

        [NativeTypeName("const WCHAR [45]")]
        public const string RuntimeClass_Windows_ApplicationModel_Core_UnhandledError = "Windows.ApplicationModel.Core.UnhandledError";

        [NativeTypeName("const WCHAR [62]")]
        public const string RuntimeClass_Windows_ApplicationModel_Core_UnhandledErrorDetectedEventArgs = "Windows.ApplicationModel.Core.UnhandledErrorDetectedEventArgs";

        [NativeTypeName("#define WINDOWS_APPLICATIONMODEL_ACTIVATION_ACTIVATEDEVENTSCONTRACT_VERSION 0x10000")]
        public const int WINDOWS_APPLICATIONMODEL_ACTIVATION_ACTIVATEDEVENTSCONTRACT_VERSION = 0x10000;

        [NativeTypeName("#define WINDOWS_APPLICATIONMODEL_ACTIVATION_ACTIVATIONCAMERASETTINGSCONTRACT_VERSION 0x10000")]
        public const int WINDOWS_APPLICATIONMODEL_ACTIVATION_ACTIVATIONCAMERASETTINGSCONTRACT_VERSION = 0x10000;

        [NativeTypeName("#define WINDOWS_APPLICATIONMODEL_ACTIVATION_CONTACTACTIVATEDEVENTSCONTRACT_VERSION 0x10000")]
        public const int WINDOWS_APPLICATIONMODEL_ACTIVATION_CONTACTACTIVATEDEVENTSCONTRACT_VERSION = 0x10000;

        [NativeTypeName("#define WINDOWS_APPLICATIONMODEL_ACTIVATION_WEBUISEARCHACTIVATEDEVENTSCONTRACT_VERSION 0x10000")]
        public const int WINDOWS_APPLICATIONMODEL_ACTIVATION_WEBUISEARCHACTIVATEDEVENTSCONTRACT_VERSION = 0x10000;

        public static readonly Guid IID_IAppListEntry = new Guid(0xEF00F07F, 0x2108, 0x490A, 0x87, 0x7A, 0x8A, 0x9F, 0x17, 0xC2, 0x5F, 0xAD);

        public static readonly Guid IID_IAppListEntry2 = new Guid(0xD0A618AD, 0xBF35, 0x42AC, 0xAC, 0x06, 0x86, 0xEE, 0xEB, 0x41, 0xD0, 0x4B);

        public static readonly Guid IID_IAppListEntry3 = new Guid(0x6099F28D, 0xFC32, 0x470A, 0xBC, 0x69, 0x4B, 0x06, 0x1A, 0x76, 0xEF, 0x2E);

        public static readonly Guid IID_ICoreApplication = new Guid(0x0AACF7A4, 0x5E1D, 0x49DF, 0x80, 0x34, 0xFB, 0x6A, 0x68, 0xBC, 0x5E, 0xD1);

        public static readonly Guid IID_ICoreApplication2 = new Guid(0x998681FB, 0x1AB6, 0x4B7F, 0xBE, 0x4A, 0x9A, 0x06, 0x45, 0x22, 0x4C, 0x04);

        public static readonly Guid IID_ICoreApplication3 = new Guid(0xFEEC0D39, 0x598B, 0x4507, 0x8A, 0x67, 0x77, 0x26, 0x32, 0x58, 0x0A, 0x57);

        public static readonly Guid IID_ICoreApplicationExit = new Guid(0xCF86461D, 0x261E, 0x4B72, 0x9A, 0xCD, 0x44, 0xED, 0x2A, 0xCE, 0x6A, 0x29);

        public static readonly Guid IID_ICoreApplicationUnhandledError = new Guid(0xF0E24AB0, 0xDD09, 0x42E1, 0xB0, 0xBC, 0xE0, 0xE1, 0x31, 0xF7, 0x8D, 0x7E);

        public static readonly Guid IID_ICoreApplicationUseCount = new Guid(0x518DC408, 0xC077, 0x475B, 0x80, 0x9E, 0x0B, 0xC0, 0xC5, 0x7E, 0x4B, 0x74);

        public static readonly Guid IID_ICoreApplicationView = new Guid(0x638BB2DB, 0x451D, 0x4661, 0xB0, 0x99, 0x41, 0x4F, 0x34, 0xFF, 0xB9, 0xF1);

        public static readonly Guid IID_ICoreApplicationView2 = new Guid(0x68EB7ADF, 0x917F, 0x48EB, 0x9A, 0xEB, 0x7D, 0xE5, 0x3E, 0x08, 0x6A, 0xB1);

        public static readonly Guid IID_ICoreApplicationView3 = new Guid(0x07EBE1B3, 0xA4CF, 0x4550, 0xAB, 0x70, 0xB0, 0x7E, 0x85, 0x33, 0x0B, 0xC8);

        public static readonly Guid IID_ICoreApplicationView5 = new Guid(0x2BC095A8, 0x8EF0, 0x446D, 0x9E, 0x60, 0x3A, 0x3E, 0x04, 0x28, 0xC6, 0x71);

        public static readonly Guid IID_ICoreApplicationView6 = new Guid(0xC119D49A, 0x0679, 0x49BA, 0x80, 0x3F, 0xB7, 0x9C, 0x5C, 0xF3, 0x4C, 0xCA);

        public static readonly Guid IID_ICoreApplicationViewTitleBar = new Guid(0x006D35E3, 0xE1F1, 0x431B, 0x95, 0x08, 0x29, 0xB9, 0x69, 0x26, 0xAC, 0x53);

        public static readonly Guid IID_ICoreImmersiveApplication = new Guid(0x1ADA0E3E, 0xE4A2, 0x4123, 0xB4, 0x51, 0xDC, 0x96, 0xBF, 0x80, 0x04, 0x19);

        public static readonly Guid IID_ICoreImmersiveApplication2 = new Guid(0x828E1E36, 0xE9E3, 0x4CFC, 0x9B, 0x66, 0x48, 0xB7, 0x8E, 0xA9, 0xBB, 0x2C);

        public static readonly Guid IID_ICoreImmersiveApplication3 = new Guid(0x34A05B2F, 0xEE0D, 0x41E5, 0x83, 0x14, 0xCF, 0x10, 0xC9, 0x1B, 0xF0, 0xAF);

        public static readonly Guid IID_IFrameworkView = new Guid(0xFAAB5CD0, 0x8924, 0x45AC, 0xAD, 0x0F, 0xA0, 0x8F, 0xAE, 0x5D, 0x03, 0x24);

        public static readonly Guid IID_IFrameworkViewSource = new Guid(0xCD770614, 0x65C4, 0x426C, 0x94, 0x94, 0x34, 0xFC, 0x43, 0x55, 0x48, 0x62);

        public static readonly Guid IID_IHostedViewClosingEventArgs = new Guid(0xD238943C, 0xB24E, 0x4790, 0xAC, 0xB5, 0x3E, 0x42, 0x43, 0xC4, 0xFF, 0x87);

        public static readonly Guid IID_IUnhandledError = new Guid(0x9459B726, 0x53B5, 0x4686, 0x9E, 0xAF, 0xFA, 0x81, 0x62, 0xDC, 0x39, 0x80);

        public static readonly Guid IID_IUnhandledErrorDetectedEventArgs = new Guid(0x679AB78B, 0xB336, 0x4822, 0xAC, 0x40, 0x0D, 0x75, 0x0F, 0x0B, 0x7A, 0x2B);
    }
}
