// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.GetdfDIJoystick"]/*' />
    [DllImport("dinput8", ExactSpelling = true)]
    [return: NativeTypeName("LPCDIDATAFORMAT")]
    public static extern DIDATAFORMAT* GetdfDIJoystick();

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.DirectInput8Create"]/*' />
    [DllImport("dinput8", ExactSpelling = true)]
    public static extern HRESULT DirectInput8Create(HINSTANCE hinst, [NativeTypeName("DWORD")] uint dwVersion, [NativeTypeName("const IID &")] Guid* riidltf, [NativeTypeName("LPVOID *")] void** ppvOut, [NativeTypeName("LPUNKNOWN")] IUnknown* punkOuter);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.joyConfigChanged"]/*' />
    [DllImport("Winmm", ExactSpelling = true)]
    [return: NativeTypeName("MMRESULT")]
    public static extern uint joyConfigChanged([NativeTypeName("DWORD")] uint dwFlags);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.ShowJoyCPL"]/*' />
    [DllImport("joy.cpl", ExactSpelling = true)]
    public static extern void ShowJoyCPL(HWND hWnd);

    [NativeTypeName("#define DIRECTINPUT_HEADER_VERSION 0x0800")]
    public const int DIRECTINPUT_HEADER_VERSION = 0x0800;

    [NativeTypeName("#define DIRECTINPUT_VERSION DIRECTINPUT_HEADER_VERSION")]
    public const int DIRECTINPUT_VERSION = 0x0800;

    [NativeTypeName("#define DIEFT_ALL 0x00000000")]
    public const int DIEFT_ALL = 0x00000000;

    [NativeTypeName("#define DIEFT_CONSTANTFORCE 0x00000001")]
    public const int DIEFT_CONSTANTFORCE = 0x00000001;

    [NativeTypeName("#define DIEFT_RAMPFORCE 0x00000002")]
    public const int DIEFT_RAMPFORCE = 0x00000002;

    [NativeTypeName("#define DIEFT_PERIODIC 0x00000003")]
    public const int DIEFT_PERIODIC = 0x00000003;

    [NativeTypeName("#define DIEFT_CONDITION 0x00000004")]
    public const int DIEFT_CONDITION = 0x00000004;

    [NativeTypeName("#define DIEFT_CUSTOMFORCE 0x00000005")]
    public const int DIEFT_CUSTOMFORCE = 0x00000005;

    [NativeTypeName("#define DIEFT_HARDWARE 0x000000FF")]
    public const int DIEFT_HARDWARE = 0x000000FF;

    [NativeTypeName("#define DIEFT_FFATTACK 0x00000200")]
    public const int DIEFT_FFATTACK = 0x00000200;

    [NativeTypeName("#define DIEFT_FFFADE 0x00000400")]
    public const int DIEFT_FFFADE = 0x00000400;

    [NativeTypeName("#define DIEFT_SATURATION 0x00000800")]
    public const int DIEFT_SATURATION = 0x00000800;

    [NativeTypeName("#define DIEFT_POSNEGCOEFFICIENTS 0x00001000")]
    public const int DIEFT_POSNEGCOEFFICIENTS = 0x00001000;

    [NativeTypeName("#define DIEFT_POSNEGSATURATION 0x00002000")]
    public const int DIEFT_POSNEGSATURATION = 0x00002000;

    [NativeTypeName("#define DIEFT_DEADBAND 0x00004000")]
    public const int DIEFT_DEADBAND = 0x00004000;

    [NativeTypeName("#define DIEFT_STARTDELAY 0x00008000")]
    public const int DIEFT_STARTDELAY = 0x00008000;

    [NativeTypeName("#define DIEFF_OBJECTIDS 0x00000001")]
    public const int DIEFF_OBJECTIDS = 0x00000001;

    [NativeTypeName("#define DIEFF_OBJECTOFFSETS 0x00000002")]
    public const int DIEFF_OBJECTOFFSETS = 0x00000002;

    [NativeTypeName("#define DIEFF_CARTESIAN 0x00000010")]
    public const int DIEFF_CARTESIAN = 0x00000010;

    [NativeTypeName("#define DIEFF_POLAR 0x00000020")]
    public const int DIEFF_POLAR = 0x00000020;

    [NativeTypeName("#define DIEFF_SPHERICAL 0x00000040")]
    public const int DIEFF_SPHERICAL = 0x00000040;

    [NativeTypeName("#define DIEP_DURATION 0x00000001")]
    public const int DIEP_DURATION = 0x00000001;

    [NativeTypeName("#define DIEP_SAMPLEPERIOD 0x00000002")]
    public const int DIEP_SAMPLEPERIOD = 0x00000002;

    [NativeTypeName("#define DIEP_GAIN 0x00000004")]
    public const int DIEP_GAIN = 0x00000004;

    [NativeTypeName("#define DIEP_TRIGGERBUTTON 0x00000008")]
    public const int DIEP_TRIGGERBUTTON = 0x00000008;

    [NativeTypeName("#define DIEP_TRIGGERREPEATINTERVAL 0x00000010")]
    public const int DIEP_TRIGGERREPEATINTERVAL = 0x00000010;

    [NativeTypeName("#define DIEP_AXES 0x00000020")]
    public const int DIEP_AXES = 0x00000020;

    [NativeTypeName("#define DIEP_DIRECTION 0x00000040")]
    public const int DIEP_DIRECTION = 0x00000040;

    [NativeTypeName("#define DIEP_ENVELOPE 0x00000080")]
    public const int DIEP_ENVELOPE = 0x00000080;

    [NativeTypeName("#define DIEP_TYPESPECIFICPARAMS 0x00000100")]
    public const int DIEP_TYPESPECIFICPARAMS = 0x00000100;

    [NativeTypeName("#define DIEP_STARTDELAY 0x00000200")]
    public const int DIEP_STARTDELAY = 0x00000200;

    [NativeTypeName("#define DIEP_ALLPARAMS_DX5 0x000001FF")]
    public const int DIEP_ALLPARAMS_DX5 = 0x000001FF;

    [NativeTypeName("#define DIEP_ALLPARAMS 0x000003FF")]
    public const int DIEP_ALLPARAMS = 0x000003FF;

    [NativeTypeName("#define DIEP_START 0x20000000")]
    public const int DIEP_START = 0x20000000;

    [NativeTypeName("#define DIEP_NORESTART 0x40000000")]
    public const int DIEP_NORESTART = 0x40000000;

    [NativeTypeName("#define DIEP_NODOWNLOAD 0x80000000")]
    public const uint DIEP_NODOWNLOAD = 0x80000000;

    [NativeTypeName("#define DIEB_NOTRIGGER 0xFFFFFFFF")]
    public const uint DIEB_NOTRIGGER = 0xFFFFFFFF;

    [NativeTypeName("#define DIES_SOLO 0x00000001")]
    public const int DIES_SOLO = 0x00000001;

    [NativeTypeName("#define DIES_NODOWNLOAD 0x80000000")]
    public const uint DIES_NODOWNLOAD = 0x80000000;

    [NativeTypeName("#define DIEGES_PLAYING 0x00000001")]
    public const int DIEGES_PLAYING = 0x00000001;

    [NativeTypeName("#define DIEGES_EMULATED 0x00000002")]
    public const int DIEGES_EMULATED = 0x00000002;

    [NativeTypeName("#define DI8DEVCLASS_ALL 0")]
    public const int DI8DEVCLASS_ALL = 0;

    [NativeTypeName("#define DI8DEVCLASS_DEVICE 1")]
    public const int DI8DEVCLASS_DEVICE = 1;

    [NativeTypeName("#define DI8DEVCLASS_POINTER 2")]
    public const int DI8DEVCLASS_POINTER = 2;

    [NativeTypeName("#define DI8DEVCLASS_KEYBOARD 3")]
    public const int DI8DEVCLASS_KEYBOARD = 3;

    [NativeTypeName("#define DI8DEVCLASS_GAMECTRL 4")]
    public const int DI8DEVCLASS_GAMECTRL = 4;

    [NativeTypeName("#define DI8DEVTYPE_DEVICE 0x11")]
    public const int DI8DEVTYPE_DEVICE = 0x11;

    [NativeTypeName("#define DI8DEVTYPE_MOUSE 0x12")]
    public const int DI8DEVTYPE_MOUSE = 0x12;

    [NativeTypeName("#define DI8DEVTYPE_KEYBOARD 0x13")]
    public const int DI8DEVTYPE_KEYBOARD = 0x13;

    [NativeTypeName("#define DI8DEVTYPE_JOYSTICK 0x14")]
    public const int DI8DEVTYPE_JOYSTICK = 0x14;

    [NativeTypeName("#define DI8DEVTYPE_GAMEPAD 0x15")]
    public const int DI8DEVTYPE_GAMEPAD = 0x15;

    [NativeTypeName("#define DI8DEVTYPE_DRIVING 0x16")]
    public const int DI8DEVTYPE_DRIVING = 0x16;

    [NativeTypeName("#define DI8DEVTYPE_FLIGHT 0x17")]
    public const int DI8DEVTYPE_FLIGHT = 0x17;

    [NativeTypeName("#define DI8DEVTYPE_1STPERSON 0x18")]
    public const int DI8DEVTYPE_1STPERSON = 0x18;

    [NativeTypeName("#define DI8DEVTYPE_DEVICECTRL 0x19")]
    public const int DI8DEVTYPE_DEVICECTRL = 0x19;

    [NativeTypeName("#define DI8DEVTYPE_SCREENPOINTER 0x1A")]
    public const int DI8DEVTYPE_SCREENPOINTER = 0x1A;

    [NativeTypeName("#define DI8DEVTYPE_REMOTE 0x1B")]
    public const int DI8DEVTYPE_REMOTE = 0x1B;

    [NativeTypeName("#define DI8DEVTYPE_SUPPLEMENTAL 0x1C")]
    public const int DI8DEVTYPE_SUPPLEMENTAL = 0x1C;

    [NativeTypeName("#define DIDEVTYPE_HID 0x00010000")]
    public const int DIDEVTYPE_HID = 0x00010000;

    [NativeTypeName("#define DI8DEVTYPEMOUSE_UNKNOWN 1")]
    public const int DI8DEVTYPEMOUSE_UNKNOWN = 1;

    [NativeTypeName("#define DI8DEVTYPEMOUSE_TRADITIONAL 2")]
    public const int DI8DEVTYPEMOUSE_TRADITIONAL = 2;

    [NativeTypeName("#define DI8DEVTYPEMOUSE_FINGERSTICK 3")]
    public const int DI8DEVTYPEMOUSE_FINGERSTICK = 3;

    [NativeTypeName("#define DI8DEVTYPEMOUSE_TOUCHPAD 4")]
    public const int DI8DEVTYPEMOUSE_TOUCHPAD = 4;

    [NativeTypeName("#define DI8DEVTYPEMOUSE_TRACKBALL 5")]
    public const int DI8DEVTYPEMOUSE_TRACKBALL = 5;

    [NativeTypeName("#define DI8DEVTYPEMOUSE_ABSOLUTE 6")]
    public const int DI8DEVTYPEMOUSE_ABSOLUTE = 6;

    [NativeTypeName("#define DI8DEVTYPEKEYBOARD_UNKNOWN 0")]
    public const int DI8DEVTYPEKEYBOARD_UNKNOWN = 0;

    [NativeTypeName("#define DI8DEVTYPEKEYBOARD_PCXT 1")]
    public const int DI8DEVTYPEKEYBOARD_PCXT = 1;

    [NativeTypeName("#define DI8DEVTYPEKEYBOARD_OLIVETTI 2")]
    public const int DI8DEVTYPEKEYBOARD_OLIVETTI = 2;

    [NativeTypeName("#define DI8DEVTYPEKEYBOARD_PCAT 3")]
    public const int DI8DEVTYPEKEYBOARD_PCAT = 3;

    [NativeTypeName("#define DI8DEVTYPEKEYBOARD_PCENH 4")]
    public const int DI8DEVTYPEKEYBOARD_PCENH = 4;

    [NativeTypeName("#define DI8DEVTYPEKEYBOARD_NOKIA1050 5")]
    public const int DI8DEVTYPEKEYBOARD_NOKIA1050 = 5;

    [NativeTypeName("#define DI8DEVTYPEKEYBOARD_NOKIA9140 6")]
    public const int DI8DEVTYPEKEYBOARD_NOKIA9140 = 6;

    [NativeTypeName("#define DI8DEVTYPEKEYBOARD_NEC98 7")]
    public const int DI8DEVTYPEKEYBOARD_NEC98 = 7;

    [NativeTypeName("#define DI8DEVTYPEKEYBOARD_NEC98LAPTOP 8")]
    public const int DI8DEVTYPEKEYBOARD_NEC98LAPTOP = 8;

    [NativeTypeName("#define DI8DEVTYPEKEYBOARD_NEC98106 9")]
    public const int DI8DEVTYPEKEYBOARD_NEC98106 = 9;

    [NativeTypeName("#define DI8DEVTYPEKEYBOARD_JAPAN106 10")]
    public const int DI8DEVTYPEKEYBOARD_JAPAN106 = 10;

    [NativeTypeName("#define DI8DEVTYPEKEYBOARD_JAPANAX 11")]
    public const int DI8DEVTYPEKEYBOARD_JAPANAX = 11;

    [NativeTypeName("#define DI8DEVTYPEKEYBOARD_J3100 12")]
    public const int DI8DEVTYPEKEYBOARD_J3100 = 12;

    [NativeTypeName("#define DI8DEVTYPE_LIMITEDGAMESUBTYPE 1")]
    public const int DI8DEVTYPE_LIMITEDGAMESUBTYPE = 1;

    [NativeTypeName("#define DI8DEVTYPEJOYSTICK_LIMITED DI8DEVTYPE_LIMITEDGAMESUBTYPE")]
    public const int DI8DEVTYPEJOYSTICK_LIMITED = 1;

    [NativeTypeName("#define DI8DEVTYPEJOYSTICK_STANDARD 2")]
    public const int DI8DEVTYPEJOYSTICK_STANDARD = 2;

    [NativeTypeName("#define DI8DEVTYPEGAMEPAD_LIMITED DI8DEVTYPE_LIMITEDGAMESUBTYPE")]
    public const int DI8DEVTYPEGAMEPAD_LIMITED = 1;

    [NativeTypeName("#define DI8DEVTYPEGAMEPAD_STANDARD 2")]
    public const int DI8DEVTYPEGAMEPAD_STANDARD = 2;

    [NativeTypeName("#define DI8DEVTYPEGAMEPAD_TILT 3")]
    public const int DI8DEVTYPEGAMEPAD_TILT = 3;

    [NativeTypeName("#define DI8DEVTYPEDRIVING_LIMITED DI8DEVTYPE_LIMITEDGAMESUBTYPE")]
    public const int DI8DEVTYPEDRIVING_LIMITED = 1;

    [NativeTypeName("#define DI8DEVTYPEDRIVING_COMBINEDPEDALS 2")]
    public const int DI8DEVTYPEDRIVING_COMBINEDPEDALS = 2;

    [NativeTypeName("#define DI8DEVTYPEDRIVING_DUALPEDALS 3")]
    public const int DI8DEVTYPEDRIVING_DUALPEDALS = 3;

    [NativeTypeName("#define DI8DEVTYPEDRIVING_THREEPEDALS 4")]
    public const int DI8DEVTYPEDRIVING_THREEPEDALS = 4;

    [NativeTypeName("#define DI8DEVTYPEDRIVING_HANDHELD 5")]
    public const int DI8DEVTYPEDRIVING_HANDHELD = 5;

    [NativeTypeName("#define DI8DEVTYPEFLIGHT_LIMITED DI8DEVTYPE_LIMITEDGAMESUBTYPE")]
    public const int DI8DEVTYPEFLIGHT_LIMITED = 1;

    [NativeTypeName("#define DI8DEVTYPEFLIGHT_STICK 2")]
    public const int DI8DEVTYPEFLIGHT_STICK = 2;

    [NativeTypeName("#define DI8DEVTYPEFLIGHT_YOKE 3")]
    public const int DI8DEVTYPEFLIGHT_YOKE = 3;

    [NativeTypeName("#define DI8DEVTYPEFLIGHT_RC 4")]
    public const int DI8DEVTYPEFLIGHT_RC = 4;

    [NativeTypeName("#define DI8DEVTYPE1STPERSON_LIMITED DI8DEVTYPE_LIMITEDGAMESUBTYPE")]
    public const int DI8DEVTYPE1STPERSON_LIMITED = 1;

    [NativeTypeName("#define DI8DEVTYPE1STPERSON_UNKNOWN 2")]
    public const int DI8DEVTYPE1STPERSON_UNKNOWN = 2;

    [NativeTypeName("#define DI8DEVTYPE1STPERSON_SIXDOF 3")]
    public const int DI8DEVTYPE1STPERSON_SIXDOF = 3;

    [NativeTypeName("#define DI8DEVTYPE1STPERSON_SHOOTER 4")]
    public const int DI8DEVTYPE1STPERSON_SHOOTER = 4;

    [NativeTypeName("#define DI8DEVTYPESCREENPTR_UNKNOWN 2")]
    public const int DI8DEVTYPESCREENPTR_UNKNOWN = 2;

    [NativeTypeName("#define DI8DEVTYPESCREENPTR_LIGHTGUN 3")]
    public const int DI8DEVTYPESCREENPTR_LIGHTGUN = 3;

    [NativeTypeName("#define DI8DEVTYPESCREENPTR_LIGHTPEN 4")]
    public const int DI8DEVTYPESCREENPTR_LIGHTPEN = 4;

    [NativeTypeName("#define DI8DEVTYPESCREENPTR_TOUCH 5")]
    public const int DI8DEVTYPESCREENPTR_TOUCH = 5;

    [NativeTypeName("#define DI8DEVTYPEREMOTE_UNKNOWN 2")]
    public const int DI8DEVTYPEREMOTE_UNKNOWN = 2;

    [NativeTypeName("#define DI8DEVTYPEDEVICECTRL_UNKNOWN 2")]
    public const int DI8DEVTYPEDEVICECTRL_UNKNOWN = 2;

    [NativeTypeName("#define DI8DEVTYPEDEVICECTRL_COMMSSELECTION 3")]
    public const int DI8DEVTYPEDEVICECTRL_COMMSSELECTION = 3;

    [NativeTypeName("#define DI8DEVTYPEDEVICECTRL_COMMSSELECTION_HARDWIRED 4")]
    public const int DI8DEVTYPEDEVICECTRL_COMMSSELECTION_HARDWIRED = 4;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_UNKNOWN 2")]
    public const int DI8DEVTYPESUPPLEMENTAL_UNKNOWN = 2;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_2NDHANDCONTROLLER 3")]
    public const int DI8DEVTYPESUPPLEMENTAL_2NDHANDCONTROLLER = 3;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_HEADTRACKER 4")]
    public const int DI8DEVTYPESUPPLEMENTAL_HEADTRACKER = 4;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_HANDTRACKER 5")]
    public const int DI8DEVTYPESUPPLEMENTAL_HANDTRACKER = 5;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_SHIFTSTICKGATE 6")]
    public const int DI8DEVTYPESUPPLEMENTAL_SHIFTSTICKGATE = 6;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_SHIFTER 7")]
    public const int DI8DEVTYPESUPPLEMENTAL_SHIFTER = 7;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_THROTTLE 8")]
    public const int DI8DEVTYPESUPPLEMENTAL_THROTTLE = 8;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_SPLITTHROTTLE 9")]
    public const int DI8DEVTYPESUPPLEMENTAL_SPLITTHROTTLE = 9;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_COMBINEDPEDALS 10")]
    public const int DI8DEVTYPESUPPLEMENTAL_COMBINEDPEDALS = 10;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_DUALPEDALS 11")]
    public const int DI8DEVTYPESUPPLEMENTAL_DUALPEDALS = 11;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_THREEPEDALS 12")]
    public const int DI8DEVTYPESUPPLEMENTAL_THREEPEDALS = 12;

    [NativeTypeName("#define DI8DEVTYPESUPPLEMENTAL_RUDDERPEDALS 13")]
    public const int DI8DEVTYPESUPPLEMENTAL_RUDDERPEDALS = 13;

    [NativeTypeName("#define DIDC_ATTACHED 0x00000001")]
    public const int DIDC_ATTACHED = 0x00000001;

    [NativeTypeName("#define DIDC_POLLEDDEVICE 0x00000002")]
    public const int DIDC_POLLEDDEVICE = 0x00000002;

    [NativeTypeName("#define DIDC_EMULATED 0x00000004")]
    public const int DIDC_EMULATED = 0x00000004;

    [NativeTypeName("#define DIDC_POLLEDDATAFORMAT 0x00000008")]
    public const int DIDC_POLLEDDATAFORMAT = 0x00000008;

    [NativeTypeName("#define DIDC_FORCEFEEDBACK 0x00000100")]
    public const int DIDC_FORCEFEEDBACK = 0x00000100;

    [NativeTypeName("#define DIDC_FFATTACK 0x00000200")]
    public const int DIDC_FFATTACK = 0x00000200;

    [NativeTypeName("#define DIDC_FFFADE 0x00000400")]
    public const int DIDC_FFFADE = 0x00000400;

    [NativeTypeName("#define DIDC_SATURATION 0x00000800")]
    public const int DIDC_SATURATION = 0x00000800;

    [NativeTypeName("#define DIDC_POSNEGCOEFFICIENTS 0x00001000")]
    public const int DIDC_POSNEGCOEFFICIENTS = 0x00001000;

    [NativeTypeName("#define DIDC_POSNEGSATURATION 0x00002000")]
    public const int DIDC_POSNEGSATURATION = 0x00002000;

    [NativeTypeName("#define DIDC_DEADBAND 0x00004000")]
    public const int DIDC_DEADBAND = 0x00004000;

    [NativeTypeName("#define DIDC_STARTDELAY 0x00008000")]
    public const int DIDC_STARTDELAY = 0x00008000;

    [NativeTypeName("#define DIDC_ALIAS 0x00010000")]
    public const int DIDC_ALIAS = 0x00010000;

    [NativeTypeName("#define DIDC_PHANTOM 0x00020000")]
    public const int DIDC_PHANTOM = 0x00020000;

    [NativeTypeName("#define DIDC_HIDDEN 0x00040000")]
    public const int DIDC_HIDDEN = 0x00040000;

    [NativeTypeName("#define DIDFT_ALL 0x00000000")]
    public const int DIDFT_ALL = 0x00000000;

    [NativeTypeName("#define DIDFT_RELAXIS 0x00000001")]
    public const int DIDFT_RELAXIS = 0x00000001;

    [NativeTypeName("#define DIDFT_ABSAXIS 0x00000002")]
    public const int DIDFT_ABSAXIS = 0x00000002;

    [NativeTypeName("#define DIDFT_AXIS 0x00000003")]
    public const int DIDFT_AXIS = 0x00000003;

    [NativeTypeName("#define DIDFT_PSHBUTTON 0x00000004")]
    public const int DIDFT_PSHBUTTON = 0x00000004;

    [NativeTypeName("#define DIDFT_TGLBUTTON 0x00000008")]
    public const int DIDFT_TGLBUTTON = 0x00000008;

    [NativeTypeName("#define DIDFT_BUTTON 0x0000000C")]
    public const int DIDFT_BUTTON = 0x0000000C;

    [NativeTypeName("#define DIDFT_POV 0x00000010")]
    public const int DIDFT_POV = 0x00000010;

    [NativeTypeName("#define DIDFT_COLLECTION 0x00000040")]
    public const int DIDFT_COLLECTION = 0x00000040;

    [NativeTypeName("#define DIDFT_NODATA 0x00000080")]
    public const int DIDFT_NODATA = 0x00000080;

    [NativeTypeName("#define DIDFT_ANYINSTANCE 0x00FFFF00")]
    public const int DIDFT_ANYINSTANCE = 0x00FFFF00;

    [NativeTypeName("#define DIDFT_INSTANCEMASK DIDFT_ANYINSTANCE")]
    public const int DIDFT_INSTANCEMASK = 0x00FFFF00;

    [NativeTypeName("#define DIDFT_FFACTUATOR 0x01000000")]
    public const int DIDFT_FFACTUATOR = 0x01000000;

    [NativeTypeName("#define DIDFT_FFEFFECTTRIGGER 0x02000000")]
    public const int DIDFT_FFEFFECTTRIGGER = 0x02000000;

    [NativeTypeName("#define DIDFT_OUTPUT 0x10000000")]
    public const int DIDFT_OUTPUT = 0x10000000;

    [NativeTypeName("#define DIDFT_VENDORDEFINED 0x04000000")]
    public const int DIDFT_VENDORDEFINED = 0x04000000;

    [NativeTypeName("#define DIDFT_ALIAS 0x08000000")]
    public const int DIDFT_ALIAS = 0x08000000;

    [NativeTypeName("#define DIDFT_NOCOLLECTION 0x00FFFF00")]
    public const int DIDFT_NOCOLLECTION = 0x00FFFF00;

    [NativeTypeName("#define DIDF_ABSAXIS 0x00000001")]
    public const int DIDF_ABSAXIS = 0x00000001;

    [NativeTypeName("#define DIDF_RELAXIS 0x00000002")]
    public const int DIDF_RELAXIS = 0x00000002;

    [NativeTypeName("#define DIA_FORCEFEEDBACK 0x00000001")]
    public const int DIA_FORCEFEEDBACK = 0x00000001;

    [NativeTypeName("#define DIA_APPMAPPED 0x00000002")]
    public const int DIA_APPMAPPED = 0x00000002;

    [NativeTypeName("#define DIA_APPNOMAP 0x00000004")]
    public const int DIA_APPNOMAP = 0x00000004;

    [NativeTypeName("#define DIA_NORANGE 0x00000008")]
    public const int DIA_NORANGE = 0x00000008;

    [NativeTypeName("#define DIA_APPFIXED 0x00000010")]
    public const int DIA_APPFIXED = 0x00000010;

    [NativeTypeName("#define DIAH_UNMAPPED 0x00000000")]
    public const int DIAH_UNMAPPED = 0x00000000;

    [NativeTypeName("#define DIAH_USERCONFIG 0x00000001")]
    public const int DIAH_USERCONFIG = 0x00000001;

    [NativeTypeName("#define DIAH_APPREQUESTED 0x00000002")]
    public const int DIAH_APPREQUESTED = 0x00000002;

    [NativeTypeName("#define DIAH_HWAPP 0x00000004")]
    public const int DIAH_HWAPP = 0x00000004;

    [NativeTypeName("#define DIAH_HWDEFAULT 0x00000008")]
    public const int DIAH_HWDEFAULT = 0x00000008;

    [NativeTypeName("#define DIAH_DEFAULT 0x00000020")]
    public const int DIAH_DEFAULT = 0x00000020;

    [NativeTypeName("#define DIAH_ERROR 0x80000000")]
    public const uint DIAH_ERROR = 0x80000000;

    [NativeTypeName("#define DIAFTS_NEWDEVICELOW 0xFFFFFFFF")]
    public const uint DIAFTS_NEWDEVICELOW = 0xFFFFFFFF;

    [NativeTypeName("#define DIAFTS_NEWDEVICEHIGH 0xFFFFFFFF")]
    public const uint DIAFTS_NEWDEVICEHIGH = 0xFFFFFFFF;

    [NativeTypeName("#define DIAFTS_UNUSEDDEVICELOW 0x00000000")]
    public const int DIAFTS_UNUSEDDEVICELOW = 0x00000000;

    [NativeTypeName("#define DIAFTS_UNUSEDDEVICEHIGH 0x00000000")]
    public const int DIAFTS_UNUSEDDEVICEHIGH = 0x00000000;

    [NativeTypeName("#define DIDBAM_DEFAULT 0x00000000")]
    public const int DIDBAM_DEFAULT = 0x00000000;

    [NativeTypeName("#define DIDBAM_PRESERVE 0x00000001")]
    public const int DIDBAM_PRESERVE = 0x00000001;

    [NativeTypeName("#define DIDBAM_INITIALIZE 0x00000002")]
    public const int DIDBAM_INITIALIZE = 0x00000002;

    [NativeTypeName("#define DIDBAM_HWDEFAULTS 0x00000004")]
    public const int DIDBAM_HWDEFAULTS = 0x00000004;

    [NativeTypeName("#define DIDSAM_DEFAULT 0x00000000")]
    public const int DIDSAM_DEFAULT = 0x00000000;

    [NativeTypeName("#define DIDSAM_NOUSER 0x00000001")]
    public const int DIDSAM_NOUSER = 0x00000001;

    [NativeTypeName("#define DIDSAM_FORCESAVE 0x00000002")]
    public const int DIDSAM_FORCESAVE = 0x00000002;

    [NativeTypeName("#define DICD_DEFAULT 0x00000000")]
    public const int DICD_DEFAULT = 0x00000000;

    [NativeTypeName("#define DICD_EDIT 0x00000001")]
    public const int DICD_EDIT = 0x00000001;

    [NativeTypeName("#define DIDIFT_CONFIGURATION 0x00000001")]
    public const int DIDIFT_CONFIGURATION = 0x00000001;

    [NativeTypeName("#define DIDIFT_OVERLAY 0x00000002")]
    public const int DIDIFT_OVERLAY = 0x00000002;

    [NativeTypeName("#define DIDAL_CENTERED 0x00000000")]
    public const int DIDAL_CENTERED = 0x00000000;

    [NativeTypeName("#define DIDAL_LEFTALIGNED 0x00000001")]
    public const int DIDAL_LEFTALIGNED = 0x00000001;

    [NativeTypeName("#define DIDAL_RIGHTALIGNED 0x00000002")]
    public const int DIDAL_RIGHTALIGNED = 0x00000002;

    [NativeTypeName("#define DIDAL_MIDDLE 0x00000000")]
    public const int DIDAL_MIDDLE = 0x00000000;

    [NativeTypeName("#define DIDAL_TOPALIGNED 0x00000004")]
    public const int DIDAL_TOPALIGNED = 0x00000004;

    [NativeTypeName("#define DIDAL_BOTTOMALIGNED 0x00000008")]
    public const int DIDAL_BOTTOMALIGNED = 0x00000008;

    [NativeTypeName("#define DIDOI_FFACTUATOR 0x00000001")]
    public const int DIDOI_FFACTUATOR = 0x00000001;

    [NativeTypeName("#define DIDOI_FFEFFECTTRIGGER 0x00000002")]
    public const int DIDOI_FFEFFECTTRIGGER = 0x00000002;

    [NativeTypeName("#define DIDOI_POLLED 0x00008000")]
    public const int DIDOI_POLLED = 0x00008000;

    [NativeTypeName("#define DIDOI_ASPECTPOSITION 0x00000100")]
    public const int DIDOI_ASPECTPOSITION = 0x00000100;

    [NativeTypeName("#define DIDOI_ASPECTVELOCITY 0x00000200")]
    public const int DIDOI_ASPECTVELOCITY = 0x00000200;

    [NativeTypeName("#define DIDOI_ASPECTACCEL 0x00000300")]
    public const int DIDOI_ASPECTACCEL = 0x00000300;

    [NativeTypeName("#define DIDOI_ASPECTFORCE 0x00000400")]
    public const int DIDOI_ASPECTFORCE = 0x00000400;

    [NativeTypeName("#define DIDOI_ASPECTMASK 0x00000F00")]
    public const int DIDOI_ASPECTMASK = 0x00000F00;

    [NativeTypeName("#define DIDOI_GUIDISUSAGE 0x00010000")]
    public const int DIDOI_GUIDISUSAGE = 0x00010000;

    [NativeTypeName("#define DIPH_DEVICE 0")]
    public const int DIPH_DEVICE = 0;

    [NativeTypeName("#define DIPH_BYOFFSET 1")]
    public const int DIPH_BYOFFSET = 1;

    [NativeTypeName("#define DIPH_BYID 2")]
    public const int DIPH_BYID = 2;

    [NativeTypeName("#define DIPH_BYUSAGE 3")]
    public const int DIPH_BYUSAGE = 3;

    [NativeTypeName("#define DIPROPRANGE_NOMIN ((LONG)0x80000000)")]
    public const int DIPROPRANGE_NOMIN = unchecked((int)(0x80000000));

    [NativeTypeName("#define DIPROPRANGE_NOMAX ((LONG)0x7FFFFFFF)")]
    public const int DIPROPRANGE_NOMAX = ((int)(0x7FFFFFFF));

    [NativeTypeName("#define MAXCPOINTSNUM 8")]
    public const int MAXCPOINTSNUM = 8;

    [NativeTypeName("#define DIPROP_BUFFERSIZE MAKEDIPROP(1)")]
    public static ref readonly Guid DIPROP_BUFFERSIZE => ref unchecked(*(Guid*)(1));

    [NativeTypeName("#define DIPROP_AXISMODE MAKEDIPROP(2)")]
    public static ref readonly Guid DIPROP_AXISMODE => ref unchecked(*(Guid*)(2));

    [NativeTypeName("#define DIPROPAXISMODE_ABS 0")]
    public const int DIPROPAXISMODE_ABS = 0;

    [NativeTypeName("#define DIPROPAXISMODE_REL 1")]
    public const int DIPROPAXISMODE_REL = 1;

    [NativeTypeName("#define DIPROP_GRANULARITY MAKEDIPROP(3)")]
    public static ref readonly Guid DIPROP_GRANULARITY => ref unchecked(*(Guid*)(3));

    [NativeTypeName("#define DIPROP_RANGE MAKEDIPROP(4)")]
    public static ref readonly Guid DIPROP_RANGE => ref unchecked(*(Guid*)(4));

    [NativeTypeName("#define DIPROP_DEADZONE MAKEDIPROP(5)")]
    public static ref readonly Guid DIPROP_DEADZONE => ref unchecked(*(Guid*)(5));

    [NativeTypeName("#define DIPROP_SATURATION MAKEDIPROP(6)")]
    public static ref readonly Guid DIPROP_SATURATION => ref unchecked(*(Guid*)(6));

    [NativeTypeName("#define DIPROP_FFGAIN MAKEDIPROP(7)")]
    public static ref readonly Guid DIPROP_FFGAIN => ref unchecked(*(Guid*)(7));

    [NativeTypeName("#define DIPROP_FFLOAD MAKEDIPROP(8)")]
    public static ref readonly Guid DIPROP_FFLOAD => ref unchecked(*(Guid*)(8));

    [NativeTypeName("#define DIPROP_AUTOCENTER MAKEDIPROP(9)")]
    public static ref readonly Guid DIPROP_AUTOCENTER => ref unchecked(*(Guid*)(9));

    [NativeTypeName("#define DIPROPAUTOCENTER_OFF 0")]
    public const int DIPROPAUTOCENTER_OFF = 0;

    [NativeTypeName("#define DIPROPAUTOCENTER_ON 1")]
    public const int DIPROPAUTOCENTER_ON = 1;

    [NativeTypeName("#define DIPROP_CALIBRATIONMODE MAKEDIPROP(10)")]
    public static ref readonly Guid DIPROP_CALIBRATIONMODE => ref unchecked(*(Guid*)(10));

    [NativeTypeName("#define DIPROPCALIBRATIONMODE_COOKED 0")]
    public const int DIPROPCALIBRATIONMODE_COOKED = 0;

    [NativeTypeName("#define DIPROPCALIBRATIONMODE_RAW 1")]
    public const int DIPROPCALIBRATIONMODE_RAW = 1;

    [NativeTypeName("#define DIPROP_CALIBRATION MAKEDIPROP(11)")]
    public static ref readonly Guid DIPROP_CALIBRATION => ref unchecked(*(Guid*)(11));

    [NativeTypeName("#define DIPROP_GUIDANDPATH MAKEDIPROP(12)")]
    public static ref readonly Guid DIPROP_GUIDANDPATH => ref unchecked(*(Guid*)(12));

    [NativeTypeName("#define DIPROP_INSTANCENAME MAKEDIPROP(13)")]
    public static ref readonly Guid DIPROP_INSTANCENAME => ref unchecked(*(Guid*)(13));

    [NativeTypeName("#define DIPROP_PRODUCTNAME MAKEDIPROP(14)")]
    public static ref readonly Guid DIPROP_PRODUCTNAME => ref unchecked(*(Guid*)(14));

    [NativeTypeName("#define DIPROP_JOYSTICKID MAKEDIPROP(15)")]
    public static ref readonly Guid DIPROP_JOYSTICKID => ref unchecked(*(Guid*)(15));

    [NativeTypeName("#define DIPROP_GETPORTDISPLAYNAME MAKEDIPROP(16)")]
    public static ref readonly Guid DIPROP_GETPORTDISPLAYNAME => ref unchecked(*(Guid*)(16));

    [NativeTypeName("#define DIPROP_PHYSICALRANGE MAKEDIPROP(18)")]
    public static ref readonly Guid DIPROP_PHYSICALRANGE => ref unchecked(*(Guid*)(18));

    [NativeTypeName("#define DIPROP_LOGICALRANGE MAKEDIPROP(19)")]
    public static ref readonly Guid DIPROP_LOGICALRANGE => ref unchecked(*(Guid*)(19));

    [NativeTypeName("#define DIPROP_KEYNAME MAKEDIPROP(20)")]
    public static ref readonly Guid DIPROP_KEYNAME => ref unchecked(*(Guid*)(20));

    [NativeTypeName("#define DIPROP_CPOINTS MAKEDIPROP(21)")]
    public static ref readonly Guid DIPROP_CPOINTS => ref unchecked(*(Guid*)(21));

    [NativeTypeName("#define DIPROP_APPDATA MAKEDIPROP(22)")]
    public static ref readonly Guid DIPROP_APPDATA => ref unchecked(*(Guid*)(22));

    [NativeTypeName("#define DIPROP_SCANCODE MAKEDIPROP(23)")]
    public static ref readonly Guid DIPROP_SCANCODE => ref unchecked(*(Guid*)(23));

    [NativeTypeName("#define DIPROP_VIDPID MAKEDIPROP(24)")]
    public static ref readonly Guid DIPROP_VIDPID => ref unchecked(*(Guid*)(24));

    [NativeTypeName("#define DIPROP_USERNAME MAKEDIPROP(25)")]
    public static ref readonly Guid DIPROP_USERNAME => ref unchecked(*(Guid*)(25));

    [NativeTypeName("#define DIPROP_TYPENAME MAKEDIPROP(26)")]
    public static ref readonly Guid DIPROP_TYPENAME => ref unchecked(*(Guid*)(26));

    [NativeTypeName("#define DIGDD_PEEK 0x00000001")]
    public const int DIGDD_PEEK = 0x00000001;

    [NativeTypeName("#define DISCL_EXCLUSIVE 0x00000001")]
    public const int DISCL_EXCLUSIVE = 0x00000001;

    [NativeTypeName("#define DISCL_NONEXCLUSIVE 0x00000002")]
    public const int DISCL_NONEXCLUSIVE = 0x00000002;

    [NativeTypeName("#define DISCL_FOREGROUND 0x00000004")]
    public const int DISCL_FOREGROUND = 0x00000004;

    [NativeTypeName("#define DISCL_BACKGROUND 0x00000008")]
    public const int DISCL_BACKGROUND = 0x00000008;

    [NativeTypeName("#define DISCL_NOWINKEY 0x00000010")]
    public const int DISCL_NOWINKEY = 0x00000010;

    [NativeTypeName("#define DISFFC_RESET 0x00000001")]
    public const int DISFFC_RESET = 0x00000001;

    [NativeTypeName("#define DISFFC_STOPALL 0x00000002")]
    public const int DISFFC_STOPALL = 0x00000002;

    [NativeTypeName("#define DISFFC_PAUSE 0x00000004")]
    public const int DISFFC_PAUSE = 0x00000004;

    [NativeTypeName("#define DISFFC_CONTINUE 0x00000008")]
    public const int DISFFC_CONTINUE = 0x00000008;

    [NativeTypeName("#define DISFFC_SETACTUATORSON 0x00000010")]
    public const int DISFFC_SETACTUATORSON = 0x00000010;

    [NativeTypeName("#define DISFFC_SETACTUATORSOFF 0x00000020")]
    public const int DISFFC_SETACTUATORSOFF = 0x00000020;

    [NativeTypeName("#define DIGFFS_EMPTY 0x00000001")]
    public const int DIGFFS_EMPTY = 0x00000001;

    [NativeTypeName("#define DIGFFS_STOPPED 0x00000002")]
    public const int DIGFFS_STOPPED = 0x00000002;

    [NativeTypeName("#define DIGFFS_PAUSED 0x00000004")]
    public const int DIGFFS_PAUSED = 0x00000004;

    [NativeTypeName("#define DIGFFS_ACTUATORSON 0x00000010")]
    public const int DIGFFS_ACTUATORSON = 0x00000010;

    [NativeTypeName("#define DIGFFS_ACTUATORSOFF 0x00000020")]
    public const int DIGFFS_ACTUATORSOFF = 0x00000020;

    [NativeTypeName("#define DIGFFS_POWERON 0x00000040")]
    public const int DIGFFS_POWERON = 0x00000040;

    [NativeTypeName("#define DIGFFS_POWEROFF 0x00000080")]
    public const int DIGFFS_POWEROFF = 0x00000080;

    [NativeTypeName("#define DIGFFS_SAFETYSWITCHON 0x00000100")]
    public const int DIGFFS_SAFETYSWITCHON = 0x00000100;

    [NativeTypeName("#define DIGFFS_SAFETYSWITCHOFF 0x00000200")]
    public const int DIGFFS_SAFETYSWITCHOFF = 0x00000200;

    [NativeTypeName("#define DIGFFS_USERFFSWITCHON 0x00000400")]
    public const int DIGFFS_USERFFSWITCHON = 0x00000400;

    [NativeTypeName("#define DIGFFS_USERFFSWITCHOFF 0x00000800")]
    public const int DIGFFS_USERFFSWITCHOFF = 0x00000800;

    [NativeTypeName("#define DIGFFS_DEVICELOST 0x80000000")]
    public const uint DIGFFS_DEVICELOST = 0x80000000;

    [NativeTypeName("#define DISDD_CONTINUE 0x00000001")]
    public const int DISDD_CONTINUE = 0x00000001;

    [NativeTypeName("#define DIFEF_DEFAULT 0x00000000")]
    public const int DIFEF_DEFAULT = 0x00000000;

    [NativeTypeName("#define DIFEF_INCLUDENONSTANDARD 0x00000001")]
    public const int DIFEF_INCLUDENONSTANDARD = 0x00000001;

    [NativeTypeName("#define DIFEF_MODIFYIFNEEDED 0x00000010")]
    public const int DIFEF_MODIFYIFNEEDED = 0x00000010;

    [NativeTypeName("#define DIMOFS_X FIELD_OFFSET(DIMOUSESTATE, lX)")]
    public static int DIMOFS_X => ((int)(Marshal.OffsetOf<DIMOUSESTATE>("lX")));

    [NativeTypeName("#define DIMOFS_Y FIELD_OFFSET(DIMOUSESTATE, lY)")]
    public static int DIMOFS_Y => ((int)(Marshal.OffsetOf<DIMOUSESTATE>("lY")));

    [NativeTypeName("#define DIMOFS_Z FIELD_OFFSET(DIMOUSESTATE, lZ)")]
    public static int DIMOFS_Z => ((int)(Marshal.OffsetOf<DIMOUSESTATE>("lZ")));

    [NativeTypeName("#define DIMOFS_BUTTON0 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 0)")]
    public static int DIMOFS_BUTTON0 => (((int)(Marshal.OffsetOf<DIMOUSESTATE>("rgbButtons"))) + 0);

    [NativeTypeName("#define DIMOFS_BUTTON1 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 1)")]
    public static int DIMOFS_BUTTON1 => (((int)(Marshal.OffsetOf<DIMOUSESTATE>("rgbButtons"))) + 1);

    [NativeTypeName("#define DIMOFS_BUTTON2 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 2)")]
    public static int DIMOFS_BUTTON2 => (((int)(Marshal.OffsetOf<DIMOUSESTATE>("rgbButtons"))) + 2);

    [NativeTypeName("#define DIMOFS_BUTTON3 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 3)")]
    public static int DIMOFS_BUTTON3 => (((int)(Marshal.OffsetOf<DIMOUSESTATE>("rgbButtons"))) + 3);

    [NativeTypeName("#define DIMOFS_BUTTON4 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 4)")]
    public static int DIMOFS_BUTTON4 => (((int)(Marshal.OffsetOf<DIMOUSESTATE2>("rgbButtons"))) + 4);

    [NativeTypeName("#define DIMOFS_BUTTON5 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 5)")]
    public static int DIMOFS_BUTTON5 => (((int)(Marshal.OffsetOf<DIMOUSESTATE2>("rgbButtons"))) + 5);

    [NativeTypeName("#define DIMOFS_BUTTON6 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 6)")]
    public static int DIMOFS_BUTTON6 => (((int)(Marshal.OffsetOf<DIMOUSESTATE2>("rgbButtons"))) + 6);

    [NativeTypeName("#define DIMOFS_BUTTON7 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 7)")]
    public static int DIMOFS_BUTTON7 => (((int)(Marshal.OffsetOf<DIMOUSESTATE2>("rgbButtons"))) + 7);

    [NativeTypeName("#define DIK_ESCAPE 0x01")]
    public const int DIK_ESCAPE = 0x01;

    [NativeTypeName("#define DIK_1 0x02")]
    public const int DIK_1 = 0x02;

    [NativeTypeName("#define DIK_2 0x03")]
    public const int DIK_2 = 0x03;

    [NativeTypeName("#define DIK_3 0x04")]
    public const int DIK_3 = 0x04;

    [NativeTypeName("#define DIK_4 0x05")]
    public const int DIK_4 = 0x05;

    [NativeTypeName("#define DIK_5 0x06")]
    public const int DIK_5 = 0x06;

    [NativeTypeName("#define DIK_6 0x07")]
    public const int DIK_6 = 0x07;

    [NativeTypeName("#define DIK_7 0x08")]
    public const int DIK_7 = 0x08;

    [NativeTypeName("#define DIK_8 0x09")]
    public const int DIK_8 = 0x09;

    [NativeTypeName("#define DIK_9 0x0A")]
    public const int DIK_9 = 0x0A;

    [NativeTypeName("#define DIK_0 0x0B")]
    public const int DIK_0 = 0x0B;

    [NativeTypeName("#define DIK_MINUS 0x0C")]
    public const int DIK_MINUS = 0x0C;

    [NativeTypeName("#define DIK_EQUALS 0x0D")]
    public const int DIK_EQUALS = 0x0D;

    [NativeTypeName("#define DIK_BACK 0x0E")]
    public const int DIK_BACK = 0x0E;

    [NativeTypeName("#define DIK_TAB 0x0F")]
    public const int DIK_TAB = 0x0F;

    [NativeTypeName("#define DIK_Q 0x10")]
    public const int DIK_Q = 0x10;

    [NativeTypeName("#define DIK_W 0x11")]
    public const int DIK_W = 0x11;

    [NativeTypeName("#define DIK_E 0x12")]
    public const int DIK_E = 0x12;

    [NativeTypeName("#define DIK_R 0x13")]
    public const int DIK_R = 0x13;

    [NativeTypeName("#define DIK_T 0x14")]
    public const int DIK_T = 0x14;

    [NativeTypeName("#define DIK_Y 0x15")]
    public const int DIK_Y = 0x15;

    [NativeTypeName("#define DIK_U 0x16")]
    public const int DIK_U = 0x16;

    [NativeTypeName("#define DIK_I 0x17")]
    public const int DIK_I = 0x17;

    [NativeTypeName("#define DIK_O 0x18")]
    public const int DIK_O = 0x18;

    [NativeTypeName("#define DIK_P 0x19")]
    public const int DIK_P = 0x19;

    [NativeTypeName("#define DIK_LBRACKET 0x1A")]
    public const int DIK_LBRACKET = 0x1A;

    [NativeTypeName("#define DIK_RBRACKET 0x1B")]
    public const int DIK_RBRACKET = 0x1B;

    [NativeTypeName("#define DIK_RETURN 0x1C")]
    public const int DIK_RETURN = 0x1C;

    [NativeTypeName("#define DIK_LCONTROL 0x1D")]
    public const int DIK_LCONTROL = 0x1D;

    [NativeTypeName("#define DIK_A 0x1E")]
    public const int DIK_A = 0x1E;

    [NativeTypeName("#define DIK_S 0x1F")]
    public const int DIK_S = 0x1F;

    [NativeTypeName("#define DIK_D 0x20")]
    public const int DIK_D = 0x20;

    [NativeTypeName("#define DIK_F 0x21")]
    public const int DIK_F = 0x21;

    [NativeTypeName("#define DIK_G 0x22")]
    public const int DIK_G = 0x22;

    [NativeTypeName("#define DIK_H 0x23")]
    public const int DIK_H = 0x23;

    [NativeTypeName("#define DIK_J 0x24")]
    public const int DIK_J = 0x24;

    [NativeTypeName("#define DIK_K 0x25")]
    public const int DIK_K = 0x25;

    [NativeTypeName("#define DIK_L 0x26")]
    public const int DIK_L = 0x26;

    [NativeTypeName("#define DIK_SEMICOLON 0x27")]
    public const int DIK_SEMICOLON = 0x27;

    [NativeTypeName("#define DIK_APOSTROPHE 0x28")]
    public const int DIK_APOSTROPHE = 0x28;

    [NativeTypeName("#define DIK_GRAVE 0x29")]
    public const int DIK_GRAVE = 0x29;

    [NativeTypeName("#define DIK_LSHIFT 0x2A")]
    public const int DIK_LSHIFT = 0x2A;

    [NativeTypeName("#define DIK_BACKSLASH 0x2B")]
    public const int DIK_BACKSLASH = 0x2B;

    [NativeTypeName("#define DIK_Z 0x2C")]
    public const int DIK_Z = 0x2C;

    [NativeTypeName("#define DIK_X 0x2D")]
    public const int DIK_X = 0x2D;

    [NativeTypeName("#define DIK_C 0x2E")]
    public const int DIK_C = 0x2E;

    [NativeTypeName("#define DIK_V 0x2F")]
    public const int DIK_V = 0x2F;

    [NativeTypeName("#define DIK_B 0x30")]
    public const int DIK_B = 0x30;

    [NativeTypeName("#define DIK_N 0x31")]
    public const int DIK_N = 0x31;

    [NativeTypeName("#define DIK_M 0x32")]
    public const int DIK_M = 0x32;

    [NativeTypeName("#define DIK_COMMA 0x33")]
    public const int DIK_COMMA = 0x33;

    [NativeTypeName("#define DIK_PERIOD 0x34")]
    public const int DIK_PERIOD = 0x34;

    [NativeTypeName("#define DIK_SLASH 0x35")]
    public const int DIK_SLASH = 0x35;

    [NativeTypeName("#define DIK_RSHIFT 0x36")]
    public const int DIK_RSHIFT = 0x36;

    [NativeTypeName("#define DIK_MULTIPLY 0x37")]
    public const int DIK_MULTIPLY = 0x37;

    [NativeTypeName("#define DIK_LMENU 0x38")]
    public const int DIK_LMENU = 0x38;

    [NativeTypeName("#define DIK_SPACE 0x39")]
    public const int DIK_SPACE = 0x39;

    [NativeTypeName("#define DIK_CAPITAL 0x3A")]
    public const int DIK_CAPITAL = 0x3A;

    [NativeTypeName("#define DIK_F1 0x3B")]
    public const int DIK_F1 = 0x3B;

    [NativeTypeName("#define DIK_F2 0x3C")]
    public const int DIK_F2 = 0x3C;

    [NativeTypeName("#define DIK_F3 0x3D")]
    public const int DIK_F3 = 0x3D;

    [NativeTypeName("#define DIK_F4 0x3E")]
    public const int DIK_F4 = 0x3E;

    [NativeTypeName("#define DIK_F5 0x3F")]
    public const int DIK_F5 = 0x3F;

    [NativeTypeName("#define DIK_F6 0x40")]
    public const int DIK_F6 = 0x40;

    [NativeTypeName("#define DIK_F7 0x41")]
    public const int DIK_F7 = 0x41;

    [NativeTypeName("#define DIK_F8 0x42")]
    public const int DIK_F8 = 0x42;

    [NativeTypeName("#define DIK_F9 0x43")]
    public const int DIK_F9 = 0x43;

    [NativeTypeName("#define DIK_F10 0x44")]
    public const int DIK_F10 = 0x44;

    [NativeTypeName("#define DIK_NUMLOCK 0x45")]
    public const int DIK_NUMLOCK = 0x45;

    [NativeTypeName("#define DIK_SCROLL 0x46")]
    public const int DIK_SCROLL = 0x46;

    [NativeTypeName("#define DIK_NUMPAD7 0x47")]
    public const int DIK_NUMPAD7 = 0x47;

    [NativeTypeName("#define DIK_NUMPAD8 0x48")]
    public const int DIK_NUMPAD8 = 0x48;

    [NativeTypeName("#define DIK_NUMPAD9 0x49")]
    public const int DIK_NUMPAD9 = 0x49;

    [NativeTypeName("#define DIK_SUBTRACT 0x4A")]
    public const int DIK_SUBTRACT = 0x4A;

    [NativeTypeName("#define DIK_NUMPAD4 0x4B")]
    public const int DIK_NUMPAD4 = 0x4B;

    [NativeTypeName("#define DIK_NUMPAD5 0x4C")]
    public const int DIK_NUMPAD5 = 0x4C;

    [NativeTypeName("#define DIK_NUMPAD6 0x4D")]
    public const int DIK_NUMPAD6 = 0x4D;

    [NativeTypeName("#define DIK_ADD 0x4E")]
    public const int DIK_ADD = 0x4E;

    [NativeTypeName("#define DIK_NUMPAD1 0x4F")]
    public const int DIK_NUMPAD1 = 0x4F;

    [NativeTypeName("#define DIK_NUMPAD2 0x50")]
    public const int DIK_NUMPAD2 = 0x50;

    [NativeTypeName("#define DIK_NUMPAD3 0x51")]
    public const int DIK_NUMPAD3 = 0x51;

    [NativeTypeName("#define DIK_NUMPAD0 0x52")]
    public const int DIK_NUMPAD0 = 0x52;

    [NativeTypeName("#define DIK_DECIMAL 0x53")]
    public const int DIK_DECIMAL = 0x53;

    [NativeTypeName("#define DIK_OEM_102 0x56")]
    public const int DIK_OEM_102 = 0x56;

    [NativeTypeName("#define DIK_F11 0x57")]
    public const int DIK_F11 = 0x57;

    [NativeTypeName("#define DIK_F12 0x58")]
    public const int DIK_F12 = 0x58;

    [NativeTypeName("#define DIK_F13 0x64")]
    public const int DIK_F13 = 0x64;

    [NativeTypeName("#define DIK_F14 0x65")]
    public const int DIK_F14 = 0x65;

    [NativeTypeName("#define DIK_F15 0x66")]
    public const int DIK_F15 = 0x66;

    [NativeTypeName("#define DIK_KANA 0x70")]
    public const int DIK_KANA = 0x70;

    [NativeTypeName("#define DIK_ABNT_C1 0x73")]
    public const int DIK_ABNT_C1 = 0x73;

    [NativeTypeName("#define DIK_CONVERT 0x79")]
    public const int DIK_CONVERT = 0x79;

    [NativeTypeName("#define DIK_NOCONVERT 0x7B")]
    public const int DIK_NOCONVERT = 0x7B;

    [NativeTypeName("#define DIK_YEN 0x7D")]
    public const int DIK_YEN = 0x7D;

    [NativeTypeName("#define DIK_ABNT_C2 0x7E")]
    public const int DIK_ABNT_C2 = 0x7E;

    [NativeTypeName("#define DIK_NUMPADEQUALS 0x8D")]
    public const int DIK_NUMPADEQUALS = 0x8D;

    [NativeTypeName("#define DIK_PREVTRACK 0x90")]
    public const int DIK_PREVTRACK = 0x90;

    [NativeTypeName("#define DIK_AT 0x91")]
    public const int DIK_AT = 0x91;

    [NativeTypeName("#define DIK_COLON 0x92")]
    public const int DIK_COLON = 0x92;

    [NativeTypeName("#define DIK_UNDERLINE 0x93")]
    public const int DIK_UNDERLINE = 0x93;

    [NativeTypeName("#define DIK_KANJI 0x94")]
    public const int DIK_KANJI = 0x94;

    [NativeTypeName("#define DIK_STOP 0x95")]
    public const int DIK_STOP = 0x95;

    [NativeTypeName("#define DIK_AX 0x96")]
    public const int DIK_AX = 0x96;

    [NativeTypeName("#define DIK_UNLABELED 0x97")]
    public const int DIK_UNLABELED = 0x97;

    [NativeTypeName("#define DIK_NEXTTRACK 0x99")]
    public const int DIK_NEXTTRACK = 0x99;

    [NativeTypeName("#define DIK_NUMPADENTER 0x9C")]
    public const int DIK_NUMPADENTER = 0x9C;

    [NativeTypeName("#define DIK_RCONTROL 0x9D")]
    public const int DIK_RCONTROL = 0x9D;

    [NativeTypeName("#define DIK_MUTE 0xA0")]
    public const int DIK_MUTE = 0xA0;

    [NativeTypeName("#define DIK_CALCULATOR 0xA1")]
    public const int DIK_CALCULATOR = 0xA1;

    [NativeTypeName("#define DIK_PLAYPAUSE 0xA2")]
    public const int DIK_PLAYPAUSE = 0xA2;

    [NativeTypeName("#define DIK_MEDIASTOP 0xA4")]
    public const int DIK_MEDIASTOP = 0xA4;

    [NativeTypeName("#define DIK_VOLUMEDOWN 0xAE")]
    public const int DIK_VOLUMEDOWN = 0xAE;

    [NativeTypeName("#define DIK_VOLUMEUP 0xB0")]
    public const int DIK_VOLUMEUP = 0xB0;

    [NativeTypeName("#define DIK_WEBHOME 0xB2")]
    public const int DIK_WEBHOME = 0xB2;

    [NativeTypeName("#define DIK_NUMPADCOMMA 0xB3")]
    public const int DIK_NUMPADCOMMA = 0xB3;

    [NativeTypeName("#define DIK_DIVIDE 0xB5")]
    public const int DIK_DIVIDE = 0xB5;

    [NativeTypeName("#define DIK_SYSRQ 0xB7")]
    public const int DIK_SYSRQ = 0xB7;

    [NativeTypeName("#define DIK_RMENU 0xB8")]
    public const int DIK_RMENU = 0xB8;

    [NativeTypeName("#define DIK_PAUSE 0xC5")]
    public const int DIK_PAUSE = 0xC5;

    [NativeTypeName("#define DIK_HOME 0xC7")]
    public const int DIK_HOME = 0xC7;

    [NativeTypeName("#define DIK_UP 0xC8")]
    public const int DIK_UP = 0xC8;

    [NativeTypeName("#define DIK_PRIOR 0xC9")]
    public const int DIK_PRIOR = 0xC9;

    [NativeTypeName("#define DIK_LEFT 0xCB")]
    public const int DIK_LEFT = 0xCB;

    [NativeTypeName("#define DIK_RIGHT 0xCD")]
    public const int DIK_RIGHT = 0xCD;

    [NativeTypeName("#define DIK_END 0xCF")]
    public const int DIK_END = 0xCF;

    [NativeTypeName("#define DIK_DOWN 0xD0")]
    public const int DIK_DOWN = 0xD0;

    [NativeTypeName("#define DIK_NEXT 0xD1")]
    public const int DIK_NEXT = 0xD1;

    [NativeTypeName("#define DIK_INSERT 0xD2")]
    public const int DIK_INSERT = 0xD2;

    [NativeTypeName("#define DIK_DELETE 0xD3")]
    public const int DIK_DELETE = 0xD3;

    [NativeTypeName("#define DIK_LWIN 0xDB")]
    public const int DIK_LWIN = 0xDB;

    [NativeTypeName("#define DIK_RWIN 0xDC")]
    public const int DIK_RWIN = 0xDC;

    [NativeTypeName("#define DIK_APPS 0xDD")]
    public const int DIK_APPS = 0xDD;

    [NativeTypeName("#define DIK_POWER 0xDE")]
    public const int DIK_POWER = 0xDE;

    [NativeTypeName("#define DIK_SLEEP 0xDF")]
    public const int DIK_SLEEP = 0xDF;

    [NativeTypeName("#define DIK_WAKE 0xE3")]
    public const int DIK_WAKE = 0xE3;

    [NativeTypeName("#define DIK_WEBSEARCH 0xE5")]
    public const int DIK_WEBSEARCH = 0xE5;

    [NativeTypeName("#define DIK_WEBFAVORITES 0xE6")]
    public const int DIK_WEBFAVORITES = 0xE6;

    [NativeTypeName("#define DIK_WEBREFRESH 0xE7")]
    public const int DIK_WEBREFRESH = 0xE7;

    [NativeTypeName("#define DIK_WEBSTOP 0xE8")]
    public const int DIK_WEBSTOP = 0xE8;

    [NativeTypeName("#define DIK_WEBFORWARD 0xE9")]
    public const int DIK_WEBFORWARD = 0xE9;

    [NativeTypeName("#define DIK_WEBBACK 0xEA")]
    public const int DIK_WEBBACK = 0xEA;

    [NativeTypeName("#define DIK_MYCOMPUTER 0xEB")]
    public const int DIK_MYCOMPUTER = 0xEB;

    [NativeTypeName("#define DIK_MAIL 0xEC")]
    public const int DIK_MAIL = 0xEC;

    [NativeTypeName("#define DIK_MEDIASELECT 0xED")]
    public const int DIK_MEDIASELECT = 0xED;

    [NativeTypeName("#define DIK_BACKSPACE DIK_BACK")]
    public const int DIK_BACKSPACE = 0x0E;

    [NativeTypeName("#define DIK_NUMPADSTAR DIK_MULTIPLY")]
    public const int DIK_NUMPADSTAR = 0x37;

    [NativeTypeName("#define DIK_LALT DIK_LMENU")]
    public const int DIK_LALT = 0x38;

    [NativeTypeName("#define DIK_CAPSLOCK DIK_CAPITAL")]
    public const int DIK_CAPSLOCK = 0x3A;

    [NativeTypeName("#define DIK_NUMPADMINUS DIK_SUBTRACT")]
    public const int DIK_NUMPADMINUS = 0x4A;

    [NativeTypeName("#define DIK_NUMPADPLUS DIK_ADD")]
    public const int DIK_NUMPADPLUS = 0x4E;

    [NativeTypeName("#define DIK_NUMPADPERIOD DIK_DECIMAL")]
    public const int DIK_NUMPADPERIOD = 0x53;

    [NativeTypeName("#define DIK_NUMPADSLASH DIK_DIVIDE")]
    public const int DIK_NUMPADSLASH = 0xB5;

    [NativeTypeName("#define DIK_RALT DIK_RMENU")]
    public const int DIK_RALT = 0xB8;

    [NativeTypeName("#define DIK_UPARROW DIK_UP")]
    public const int DIK_UPARROW = 0xC8;

    [NativeTypeName("#define DIK_PGUP DIK_PRIOR")]
    public const int DIK_PGUP = 0xC9;

    [NativeTypeName("#define DIK_LEFTARROW DIK_LEFT")]
    public const int DIK_LEFTARROW = 0xCB;

    [NativeTypeName("#define DIK_RIGHTARROW DIK_RIGHT")]
    public const int DIK_RIGHTARROW = 0xCD;

    [NativeTypeName("#define DIK_DOWNARROW DIK_DOWN")]
    public const int DIK_DOWNARROW = 0xD0;

    [NativeTypeName("#define DIK_PGDN DIK_NEXT")]
    public const int DIK_PGDN = 0xD1;

    [NativeTypeName("#define DIK_CIRCUMFLEX DIK_PREVTRACK")]
    public const int DIK_CIRCUMFLEX = 0x90;

    [NativeTypeName("#define DIJOFS_X FIELD_OFFSET(DIJOYSTATE, lX)")]
    public static int DIJOFS_X => ((int)(Marshal.OffsetOf<DIJOYSTATE>("lX")));

    [NativeTypeName("#define DIJOFS_Y FIELD_OFFSET(DIJOYSTATE, lY)")]
    public static int DIJOFS_Y => ((int)(Marshal.OffsetOf<DIJOYSTATE>("lY")));

    [NativeTypeName("#define DIJOFS_Z FIELD_OFFSET(DIJOYSTATE, lZ)")]
    public static int DIJOFS_Z => ((int)(Marshal.OffsetOf<DIJOYSTATE>("lZ")));

    [NativeTypeName("#define DIJOFS_RX FIELD_OFFSET(DIJOYSTATE, lRx)")]
    public static int DIJOFS_RX => ((int)(Marshal.OffsetOf<DIJOYSTATE>("lRx")));

    [NativeTypeName("#define DIJOFS_RY FIELD_OFFSET(DIJOYSTATE, lRy)")]
    public static int DIJOFS_RY => ((int)(Marshal.OffsetOf<DIJOYSTATE>("lRy")));

    [NativeTypeName("#define DIJOFS_RZ FIELD_OFFSET(DIJOYSTATE, lRz)")]
    public static int DIJOFS_RZ => ((int)(Marshal.OffsetOf<DIJOYSTATE>("lRz")));

    [NativeTypeName("#define DIJOFS_BUTTON0 DIJOFS_BUTTON(0)")]
    public static int DIJOFS_BUTTON0 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (0));

    [NativeTypeName("#define DIJOFS_BUTTON1 DIJOFS_BUTTON(1)")]
    public static int DIJOFS_BUTTON1 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (1));

    [NativeTypeName("#define DIJOFS_BUTTON2 DIJOFS_BUTTON(2)")]
    public static int DIJOFS_BUTTON2 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (2));

    [NativeTypeName("#define DIJOFS_BUTTON3 DIJOFS_BUTTON(3)")]
    public static int DIJOFS_BUTTON3 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (3));

    [NativeTypeName("#define DIJOFS_BUTTON4 DIJOFS_BUTTON(4)")]
    public static int DIJOFS_BUTTON4 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (4));

    [NativeTypeName("#define DIJOFS_BUTTON5 DIJOFS_BUTTON(5)")]
    public static int DIJOFS_BUTTON5 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (5));

    [NativeTypeName("#define DIJOFS_BUTTON6 DIJOFS_BUTTON(6)")]
    public static int DIJOFS_BUTTON6 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (6));

    [NativeTypeName("#define DIJOFS_BUTTON7 DIJOFS_BUTTON(7)")]
    public static int DIJOFS_BUTTON7 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (7));

    [NativeTypeName("#define DIJOFS_BUTTON8 DIJOFS_BUTTON(8)")]
    public static int DIJOFS_BUTTON8 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (8));

    [NativeTypeName("#define DIJOFS_BUTTON9 DIJOFS_BUTTON(9)")]
    public static int DIJOFS_BUTTON9 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (9));

    [NativeTypeName("#define DIJOFS_BUTTON10 DIJOFS_BUTTON(10)")]
    public static int DIJOFS_BUTTON10 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (10));

    [NativeTypeName("#define DIJOFS_BUTTON11 DIJOFS_BUTTON(11)")]
    public static int DIJOFS_BUTTON11 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (11));

    [NativeTypeName("#define DIJOFS_BUTTON12 DIJOFS_BUTTON(12)")]
    public static int DIJOFS_BUTTON12 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (12));

    [NativeTypeName("#define DIJOFS_BUTTON13 DIJOFS_BUTTON(13)")]
    public static int DIJOFS_BUTTON13 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (13));

    [NativeTypeName("#define DIJOFS_BUTTON14 DIJOFS_BUTTON(14)")]
    public static int DIJOFS_BUTTON14 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (14));

    [NativeTypeName("#define DIJOFS_BUTTON15 DIJOFS_BUTTON(15)")]
    public static int DIJOFS_BUTTON15 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (15));

    [NativeTypeName("#define DIJOFS_BUTTON16 DIJOFS_BUTTON(16)")]
    public static int DIJOFS_BUTTON16 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (16));

    [NativeTypeName("#define DIJOFS_BUTTON17 DIJOFS_BUTTON(17)")]
    public static int DIJOFS_BUTTON17 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (17));

    [NativeTypeName("#define DIJOFS_BUTTON18 DIJOFS_BUTTON(18)")]
    public static int DIJOFS_BUTTON18 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (18));

    [NativeTypeName("#define DIJOFS_BUTTON19 DIJOFS_BUTTON(19)")]
    public static int DIJOFS_BUTTON19 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (19));

    [NativeTypeName("#define DIJOFS_BUTTON20 DIJOFS_BUTTON(20)")]
    public static int DIJOFS_BUTTON20 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (20));

    [NativeTypeName("#define DIJOFS_BUTTON21 DIJOFS_BUTTON(21)")]
    public static int DIJOFS_BUTTON21 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (21));

    [NativeTypeName("#define DIJOFS_BUTTON22 DIJOFS_BUTTON(22)")]
    public static int DIJOFS_BUTTON22 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (22));

    [NativeTypeName("#define DIJOFS_BUTTON23 DIJOFS_BUTTON(23)")]
    public static int DIJOFS_BUTTON23 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (23));

    [NativeTypeName("#define DIJOFS_BUTTON24 DIJOFS_BUTTON(24)")]
    public static int DIJOFS_BUTTON24 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (24));

    [NativeTypeName("#define DIJOFS_BUTTON25 DIJOFS_BUTTON(25)")]
    public static int DIJOFS_BUTTON25 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (25));

    [NativeTypeName("#define DIJOFS_BUTTON26 DIJOFS_BUTTON(26)")]
    public static int DIJOFS_BUTTON26 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (26));

    [NativeTypeName("#define DIJOFS_BUTTON27 DIJOFS_BUTTON(27)")]
    public static int DIJOFS_BUTTON27 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (27));

    [NativeTypeName("#define DIJOFS_BUTTON28 DIJOFS_BUTTON(28)")]
    public static int DIJOFS_BUTTON28 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (28));

    [NativeTypeName("#define DIJOFS_BUTTON29 DIJOFS_BUTTON(29)")]
    public static int DIJOFS_BUTTON29 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (29));

    [NativeTypeName("#define DIJOFS_BUTTON30 DIJOFS_BUTTON(30)")]
    public static int DIJOFS_BUTTON30 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (30));

    [NativeTypeName("#define DIJOFS_BUTTON31 DIJOFS_BUTTON(31)")]
    public static int DIJOFS_BUTTON31 => (((int)(Marshal.OffsetOf<DIJOYSTATE>("rgbButtons"))) + (31));

    [NativeTypeName("#define DIENUM_STOP 0")]
    public const int DIENUM_STOP = 0;

    [NativeTypeName("#define DIENUM_CONTINUE 1")]
    public const int DIENUM_CONTINUE = 1;

    [NativeTypeName("#define DIEDFL_ALLDEVICES 0x00000000")]
    public const int DIEDFL_ALLDEVICES = 0x00000000;

    [NativeTypeName("#define DIEDFL_ATTACHEDONLY 0x00000001")]
    public const int DIEDFL_ATTACHEDONLY = 0x00000001;

    [NativeTypeName("#define DIEDFL_FORCEFEEDBACK 0x00000100")]
    public const int DIEDFL_FORCEFEEDBACK = 0x00000100;

    [NativeTypeName("#define DIEDFL_INCLUDEALIASES 0x00010000")]
    public const int DIEDFL_INCLUDEALIASES = 0x00010000;

    [NativeTypeName("#define DIEDFL_INCLUDEPHANTOMS 0x00020000")]
    public const int DIEDFL_INCLUDEPHANTOMS = 0x00020000;

    [NativeTypeName("#define DIEDFL_INCLUDEHIDDEN 0x00040000")]
    public const int DIEDFL_INCLUDEHIDDEN = 0x00040000;

    [NativeTypeName("#define DIEDBS_MAPPEDPRI1 0x00000001")]
    public const int DIEDBS_MAPPEDPRI1 = 0x00000001;

    [NativeTypeName("#define DIEDBS_MAPPEDPRI2 0x00000002")]
    public const int DIEDBS_MAPPEDPRI2 = 0x00000002;

    [NativeTypeName("#define DIEDBS_RECENTDEVICE 0x00000010")]
    public const int DIEDBS_RECENTDEVICE = 0x00000010;

    [NativeTypeName("#define DIEDBS_NEWDEVICE 0x00000020")]
    public const int DIEDBS_NEWDEVICE = 0x00000020;

    [NativeTypeName("#define DIEDBSFL_ATTACHEDONLY 0x00000000")]
    public const int DIEDBSFL_ATTACHEDONLY = 0x00000000;

    [NativeTypeName("#define DIEDBSFL_THISUSER 0x00000010")]
    public const int DIEDBSFL_THISUSER = 0x00000010;

    [NativeTypeName("#define DIEDBSFL_FORCEFEEDBACK DIEDFL_FORCEFEEDBACK")]
    public const int DIEDBSFL_FORCEFEEDBACK = 0x00000100;

    [NativeTypeName("#define DIEDBSFL_AVAILABLEDEVICES 0x00001000")]
    public const int DIEDBSFL_AVAILABLEDEVICES = 0x00001000;

    [NativeTypeName("#define DIEDBSFL_MULTIMICEKEYBOARDS 0x00002000")]
    public const int DIEDBSFL_MULTIMICEKEYBOARDS = 0x00002000;

    [NativeTypeName("#define DIEDBSFL_NONGAMINGDEVICES 0x00004000")]
    public const int DIEDBSFL_NONGAMINGDEVICES = 0x00004000;

    [NativeTypeName("#define DIEDBSFL_VALID 0x00007110")]
    public const int DIEDBSFL_VALID = 0x00007110;

    [NativeTypeName("#define DIERR_OLDDIRECTINPUTVERSION MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_OLD_WIN_VERSION)")]
    public const int DIERR_OLDDIRECTINPUTVERSION = unchecked((int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(1150))));

    [NativeTypeName("#define DIERR_BETADIRECTINPUTVERSION MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_RMODE_APP)")]
    public const int DIERR_BETADIRECTINPUTVERSION = unchecked((int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(1153))));

    [NativeTypeName("#define DIERR_BADDRIVERVER MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_BAD_DRIVER_LEVEL)")]
    public const int DIERR_BADDRIVERVER = unchecked((int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(119))));

    [NativeTypeName("#define DIERR_DEVICENOTREG REGDB_E_CLASSNOTREG")]
    public const int DIERR_DEVICENOTREG = unchecked((int)(0x80040154));

    [NativeTypeName("#define DIERR_NOTFOUND MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_FILE_NOT_FOUND)")]
    public const int DIERR_NOTFOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(2))));

    [NativeTypeName("#define DIERR_OBJECTNOTFOUND MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_FILE_NOT_FOUND)")]
    public const int DIERR_OBJECTNOTFOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(2))));

    [NativeTypeName("#define DIERR_INVALIDPARAM E_INVALIDARG")]
    public const int DIERR_INVALIDPARAM = unchecked((int)(0x80070057));

    [NativeTypeName("#define DIERR_NOINTERFACE E_NOINTERFACE")]
    public const int DIERR_NOINTERFACE = unchecked((int)(0x80004002));

    [NativeTypeName("#define DIERR_GENERIC E_FAIL")]
    public const int DIERR_GENERIC = unchecked((int)(0x80004005));

    [NativeTypeName("#define DIERR_OUTOFMEMORY E_OUTOFMEMORY")]
    public const int DIERR_OUTOFMEMORY = unchecked((int)(0x8007000E));

    [NativeTypeName("#define DIERR_UNSUPPORTED E_NOTIMPL")]
    public const int DIERR_UNSUPPORTED = unchecked((int)(0x80004001));

    [NativeTypeName("#define DIERR_NOTINITIALIZED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_NOT_READY)")]
    public const int DIERR_NOTINITIALIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(21))));

    [NativeTypeName("#define DIERR_ALREADYINITIALIZED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_ALREADY_INITIALIZED)")]
    public const int DIERR_ALREADYINITIALIZED = unchecked((int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(1247))));

    [NativeTypeName("#define DIERR_NOAGGREGATION CLASS_E_NOAGGREGATION")]
    public const int DIERR_NOAGGREGATION = unchecked((int)(0x80040110));

    [NativeTypeName("#define DIERR_OTHERAPPHASPRIO E_ACCESSDENIED")]
    public const int DIERR_OTHERAPPHASPRIO = unchecked((int)(0x80070005));

    [NativeTypeName("#define DIERR_INPUTLOST MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_READ_FAULT)")]
    public const int DIERR_INPUTLOST = unchecked((int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(30))));

    [NativeTypeName("#define DIERR_ACQUIRED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_BUSY)")]
    public const int DIERR_ACQUIRED = unchecked((int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(170))));

    [NativeTypeName("#define DIERR_NOTACQUIRED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_INVALID_ACCESS)")]
    public const int DIERR_NOTACQUIRED = unchecked((int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(12))));

    [NativeTypeName("#define DIERR_READONLY E_ACCESSDENIED")]
    public const int DIERR_READONLY = unchecked((int)(0x80070005));

    [NativeTypeName("#define DIERR_HANDLEEXISTS E_ACCESSDENIED")]
    public const int DIERR_HANDLEEXISTS = unchecked((int)(0x80070005));

    [NativeTypeName("#define DIERR_INSUFFICIENTPRIVS 0x80040200L")]
    public const uint DIERR_INSUFFICIENTPRIVS = 0x80040200;

    [NativeTypeName("#define DIERR_DEVICEFULL 0x80040201L")]
    public const uint DIERR_DEVICEFULL = 0x80040201;

    [NativeTypeName("#define DIERR_MOREDATA 0x80040202L")]
    public const uint DIERR_MOREDATA = 0x80040202;

    [NativeTypeName("#define DIERR_NOTDOWNLOADED 0x80040203L")]
    public const uint DIERR_NOTDOWNLOADED = 0x80040203;

    [NativeTypeName("#define DIERR_HASEFFECTS 0x80040204L")]
    public const uint DIERR_HASEFFECTS = 0x80040204;

    [NativeTypeName("#define DIERR_NOTEXCLUSIVEACQUIRED 0x80040205L")]
    public const uint DIERR_NOTEXCLUSIVEACQUIRED = 0x80040205;

    [NativeTypeName("#define DIERR_INCOMPLETEEFFECT 0x80040206L")]
    public const uint DIERR_INCOMPLETEEFFECT = 0x80040206;

    [NativeTypeName("#define DIERR_NOTBUFFERED 0x80040207L")]
    public const uint DIERR_NOTBUFFERED = 0x80040207;

    [NativeTypeName("#define DIERR_EFFECTPLAYING 0x80040208L")]
    public const uint DIERR_EFFECTPLAYING = 0x80040208;

    [NativeTypeName("#define DIERR_UNPLUGGED 0x80040209L")]
    public const uint DIERR_UNPLUGGED = 0x80040209;

    [NativeTypeName("#define DIERR_REPORTFULL 0x8004020AL")]
    public const uint DIERR_REPORTFULL = 0x8004020A;

    [NativeTypeName("#define DIERR_MAPFILEFAIL 0x8004020BL")]
    public const uint DIERR_MAPFILEFAIL = 0x8004020B;

    [NativeTypeName("#define DIKEYBOARD_ESCAPE 0x81000401")]
    public const uint DIKEYBOARD_ESCAPE = 0x81000401;

    [NativeTypeName("#define DIKEYBOARD_1 0x81000402")]
    public const uint DIKEYBOARD_1 = 0x81000402;

    [NativeTypeName("#define DIKEYBOARD_2 0x81000403")]
    public const uint DIKEYBOARD_2 = 0x81000403;

    [NativeTypeName("#define DIKEYBOARD_3 0x81000404")]
    public const uint DIKEYBOARD_3 = 0x81000404;

    [NativeTypeName("#define DIKEYBOARD_4 0x81000405")]
    public const uint DIKEYBOARD_4 = 0x81000405;

    [NativeTypeName("#define DIKEYBOARD_5 0x81000406")]
    public const uint DIKEYBOARD_5 = 0x81000406;

    [NativeTypeName("#define DIKEYBOARD_6 0x81000407")]
    public const uint DIKEYBOARD_6 = 0x81000407;

    [NativeTypeName("#define DIKEYBOARD_7 0x81000408")]
    public const uint DIKEYBOARD_7 = 0x81000408;

    [NativeTypeName("#define DIKEYBOARD_8 0x81000409")]
    public const uint DIKEYBOARD_8 = 0x81000409;

    [NativeTypeName("#define DIKEYBOARD_9 0x8100040A")]
    public const uint DIKEYBOARD_9 = 0x8100040A;

    [NativeTypeName("#define DIKEYBOARD_0 0x8100040B")]
    public const uint DIKEYBOARD_0 = 0x8100040B;

    [NativeTypeName("#define DIKEYBOARD_MINUS 0x8100040C")]
    public const uint DIKEYBOARD_MINUS = 0x8100040C;

    [NativeTypeName("#define DIKEYBOARD_EQUALS 0x8100040D")]
    public const uint DIKEYBOARD_EQUALS = 0x8100040D;

    [NativeTypeName("#define DIKEYBOARD_BACK 0x8100040E")]
    public const uint DIKEYBOARD_BACK = 0x8100040E;

    [NativeTypeName("#define DIKEYBOARD_TAB 0x8100040F")]
    public const uint DIKEYBOARD_TAB = 0x8100040F;

    [NativeTypeName("#define DIKEYBOARD_Q 0x81000410")]
    public const uint DIKEYBOARD_Q = 0x81000410;

    [NativeTypeName("#define DIKEYBOARD_W 0x81000411")]
    public const uint DIKEYBOARD_W = 0x81000411;

    [NativeTypeName("#define DIKEYBOARD_E 0x81000412")]
    public const uint DIKEYBOARD_E = 0x81000412;

    [NativeTypeName("#define DIKEYBOARD_R 0x81000413")]
    public const uint DIKEYBOARD_R = 0x81000413;

    [NativeTypeName("#define DIKEYBOARD_T 0x81000414")]
    public const uint DIKEYBOARD_T = 0x81000414;

    [NativeTypeName("#define DIKEYBOARD_Y 0x81000415")]
    public const uint DIKEYBOARD_Y = 0x81000415;

    [NativeTypeName("#define DIKEYBOARD_U 0x81000416")]
    public const uint DIKEYBOARD_U = 0x81000416;

    [NativeTypeName("#define DIKEYBOARD_I 0x81000417")]
    public const uint DIKEYBOARD_I = 0x81000417;

    [NativeTypeName("#define DIKEYBOARD_O 0x81000418")]
    public const uint DIKEYBOARD_O = 0x81000418;

    [NativeTypeName("#define DIKEYBOARD_P 0x81000419")]
    public const uint DIKEYBOARD_P = 0x81000419;

    [NativeTypeName("#define DIKEYBOARD_LBRACKET 0x8100041A")]
    public const uint DIKEYBOARD_LBRACKET = 0x8100041A;

    [NativeTypeName("#define DIKEYBOARD_RBRACKET 0x8100041B")]
    public const uint DIKEYBOARD_RBRACKET = 0x8100041B;

    [NativeTypeName("#define DIKEYBOARD_RETURN 0x8100041C")]
    public const uint DIKEYBOARD_RETURN = 0x8100041C;

    [NativeTypeName("#define DIKEYBOARD_LCONTROL 0x8100041D")]
    public const uint DIKEYBOARD_LCONTROL = 0x8100041D;

    [NativeTypeName("#define DIKEYBOARD_A 0x8100041E")]
    public const uint DIKEYBOARD_A = 0x8100041E;

    [NativeTypeName("#define DIKEYBOARD_S 0x8100041F")]
    public const uint DIKEYBOARD_S = 0x8100041F;

    [NativeTypeName("#define DIKEYBOARD_D 0x81000420")]
    public const uint DIKEYBOARD_D = 0x81000420;

    [NativeTypeName("#define DIKEYBOARD_F 0x81000421")]
    public const uint DIKEYBOARD_F = 0x81000421;

    [NativeTypeName("#define DIKEYBOARD_G 0x81000422")]
    public const uint DIKEYBOARD_G = 0x81000422;

    [NativeTypeName("#define DIKEYBOARD_H 0x81000423")]
    public const uint DIKEYBOARD_H = 0x81000423;

    [NativeTypeName("#define DIKEYBOARD_J 0x81000424")]
    public const uint DIKEYBOARD_J = 0x81000424;

    [NativeTypeName("#define DIKEYBOARD_K 0x81000425")]
    public const uint DIKEYBOARD_K = 0x81000425;

    [NativeTypeName("#define DIKEYBOARD_L 0x81000426")]
    public const uint DIKEYBOARD_L = 0x81000426;

    [NativeTypeName("#define DIKEYBOARD_SEMICOLON 0x81000427")]
    public const uint DIKEYBOARD_SEMICOLON = 0x81000427;

    [NativeTypeName("#define DIKEYBOARD_APOSTROPHE 0x81000428")]
    public const uint DIKEYBOARD_APOSTROPHE = 0x81000428;

    [NativeTypeName("#define DIKEYBOARD_GRAVE 0x81000429")]
    public const uint DIKEYBOARD_GRAVE = 0x81000429;

    [NativeTypeName("#define DIKEYBOARD_LSHIFT 0x8100042A")]
    public const uint DIKEYBOARD_LSHIFT = 0x8100042A;

    [NativeTypeName("#define DIKEYBOARD_BACKSLASH 0x8100042B")]
    public const uint DIKEYBOARD_BACKSLASH = 0x8100042B;

    [NativeTypeName("#define DIKEYBOARD_Z 0x8100042C")]
    public const uint DIKEYBOARD_Z = 0x8100042C;

    [NativeTypeName("#define DIKEYBOARD_X 0x8100042D")]
    public const uint DIKEYBOARD_X = 0x8100042D;

    [NativeTypeName("#define DIKEYBOARD_C 0x8100042E")]
    public const uint DIKEYBOARD_C = 0x8100042E;

    [NativeTypeName("#define DIKEYBOARD_V 0x8100042F")]
    public const uint DIKEYBOARD_V = 0x8100042F;

    [NativeTypeName("#define DIKEYBOARD_B 0x81000430")]
    public const uint DIKEYBOARD_B = 0x81000430;

    [NativeTypeName("#define DIKEYBOARD_N 0x81000431")]
    public const uint DIKEYBOARD_N = 0x81000431;

    [NativeTypeName("#define DIKEYBOARD_M 0x81000432")]
    public const uint DIKEYBOARD_M = 0x81000432;

    [NativeTypeName("#define DIKEYBOARD_COMMA 0x81000433")]
    public const uint DIKEYBOARD_COMMA = 0x81000433;

    [NativeTypeName("#define DIKEYBOARD_PERIOD 0x81000434")]
    public const uint DIKEYBOARD_PERIOD = 0x81000434;

    [NativeTypeName("#define DIKEYBOARD_SLASH 0x81000435")]
    public const uint DIKEYBOARD_SLASH = 0x81000435;

    [NativeTypeName("#define DIKEYBOARD_RSHIFT 0x81000436")]
    public const uint DIKEYBOARD_RSHIFT = 0x81000436;

    [NativeTypeName("#define DIKEYBOARD_MULTIPLY 0x81000437")]
    public const uint DIKEYBOARD_MULTIPLY = 0x81000437;

    [NativeTypeName("#define DIKEYBOARD_LMENU 0x81000438")]
    public const uint DIKEYBOARD_LMENU = 0x81000438;

    [NativeTypeName("#define DIKEYBOARD_SPACE 0x81000439")]
    public const uint DIKEYBOARD_SPACE = 0x81000439;

    [NativeTypeName("#define DIKEYBOARD_CAPITAL 0x8100043A")]
    public const uint DIKEYBOARD_CAPITAL = 0x8100043A;

    [NativeTypeName("#define DIKEYBOARD_F1 0x8100043B")]
    public const uint DIKEYBOARD_F1 = 0x8100043B;

    [NativeTypeName("#define DIKEYBOARD_F2 0x8100043C")]
    public const uint DIKEYBOARD_F2 = 0x8100043C;

    [NativeTypeName("#define DIKEYBOARD_F3 0x8100043D")]
    public const uint DIKEYBOARD_F3 = 0x8100043D;

    [NativeTypeName("#define DIKEYBOARD_F4 0x8100043E")]
    public const uint DIKEYBOARD_F4 = 0x8100043E;

    [NativeTypeName("#define DIKEYBOARD_F5 0x8100043F")]
    public const uint DIKEYBOARD_F5 = 0x8100043F;

    [NativeTypeName("#define DIKEYBOARD_F6 0x81000440")]
    public const uint DIKEYBOARD_F6 = 0x81000440;

    [NativeTypeName("#define DIKEYBOARD_F7 0x81000441")]
    public const uint DIKEYBOARD_F7 = 0x81000441;

    [NativeTypeName("#define DIKEYBOARD_F8 0x81000442")]
    public const uint DIKEYBOARD_F8 = 0x81000442;

    [NativeTypeName("#define DIKEYBOARD_F9 0x81000443")]
    public const uint DIKEYBOARD_F9 = 0x81000443;

    [NativeTypeName("#define DIKEYBOARD_F10 0x81000444")]
    public const uint DIKEYBOARD_F10 = 0x81000444;

    [NativeTypeName("#define DIKEYBOARD_NUMLOCK 0x81000445")]
    public const uint DIKEYBOARD_NUMLOCK = 0x81000445;

    [NativeTypeName("#define DIKEYBOARD_SCROLL 0x81000446")]
    public const uint DIKEYBOARD_SCROLL = 0x81000446;

    [NativeTypeName("#define DIKEYBOARD_NUMPAD7 0x81000447")]
    public const uint DIKEYBOARD_NUMPAD7 = 0x81000447;

    [NativeTypeName("#define DIKEYBOARD_NUMPAD8 0x81000448")]
    public const uint DIKEYBOARD_NUMPAD8 = 0x81000448;

    [NativeTypeName("#define DIKEYBOARD_NUMPAD9 0x81000449")]
    public const uint DIKEYBOARD_NUMPAD9 = 0x81000449;

    [NativeTypeName("#define DIKEYBOARD_SUBTRACT 0x8100044A")]
    public const uint DIKEYBOARD_SUBTRACT = 0x8100044A;

    [NativeTypeName("#define DIKEYBOARD_NUMPAD4 0x8100044B")]
    public const uint DIKEYBOARD_NUMPAD4 = 0x8100044B;

    [NativeTypeName("#define DIKEYBOARD_NUMPAD5 0x8100044C")]
    public const uint DIKEYBOARD_NUMPAD5 = 0x8100044C;

    [NativeTypeName("#define DIKEYBOARD_NUMPAD6 0x8100044D")]
    public const uint DIKEYBOARD_NUMPAD6 = 0x8100044D;

    [NativeTypeName("#define DIKEYBOARD_ADD 0x8100044E")]
    public const uint DIKEYBOARD_ADD = 0x8100044E;

    [NativeTypeName("#define DIKEYBOARD_NUMPAD1 0x8100044F")]
    public const uint DIKEYBOARD_NUMPAD1 = 0x8100044F;

    [NativeTypeName("#define DIKEYBOARD_NUMPAD2 0x81000450")]
    public const uint DIKEYBOARD_NUMPAD2 = 0x81000450;

    [NativeTypeName("#define DIKEYBOARD_NUMPAD3 0x81000451")]
    public const uint DIKEYBOARD_NUMPAD3 = 0x81000451;

    [NativeTypeName("#define DIKEYBOARD_NUMPAD0 0x81000452")]
    public const uint DIKEYBOARD_NUMPAD0 = 0x81000452;

    [NativeTypeName("#define DIKEYBOARD_DECIMAL 0x81000453")]
    public const uint DIKEYBOARD_DECIMAL = 0x81000453;

    [NativeTypeName("#define DIKEYBOARD_OEM_102 0x81000456")]
    public const uint DIKEYBOARD_OEM_102 = 0x81000456;

    [NativeTypeName("#define DIKEYBOARD_F11 0x81000457")]
    public const uint DIKEYBOARD_F11 = 0x81000457;

    [NativeTypeName("#define DIKEYBOARD_F12 0x81000458")]
    public const uint DIKEYBOARD_F12 = 0x81000458;

    [NativeTypeName("#define DIKEYBOARD_F13 0x81000464")]
    public const uint DIKEYBOARD_F13 = 0x81000464;

    [NativeTypeName("#define DIKEYBOARD_F14 0x81000465")]
    public const uint DIKEYBOARD_F14 = 0x81000465;

    [NativeTypeName("#define DIKEYBOARD_F15 0x81000466")]
    public const uint DIKEYBOARD_F15 = 0x81000466;

    [NativeTypeName("#define DIKEYBOARD_KANA 0x81000470")]
    public const uint DIKEYBOARD_KANA = 0x81000470;

    [NativeTypeName("#define DIKEYBOARD_ABNT_C1 0x81000473")]
    public const uint DIKEYBOARD_ABNT_C1 = 0x81000473;

    [NativeTypeName("#define DIKEYBOARD_CONVERT 0x81000479")]
    public const uint DIKEYBOARD_CONVERT = 0x81000479;

    [NativeTypeName("#define DIKEYBOARD_NOCONVERT 0x8100047B")]
    public const uint DIKEYBOARD_NOCONVERT = 0x8100047B;

    [NativeTypeName("#define DIKEYBOARD_YEN 0x8100047D")]
    public const uint DIKEYBOARD_YEN = 0x8100047D;

    [NativeTypeName("#define DIKEYBOARD_ABNT_C2 0x8100047E")]
    public const uint DIKEYBOARD_ABNT_C2 = 0x8100047E;

    [NativeTypeName("#define DIKEYBOARD_NUMPADEQUALS 0x8100048D")]
    public const uint DIKEYBOARD_NUMPADEQUALS = 0x8100048D;

    [NativeTypeName("#define DIKEYBOARD_PREVTRACK 0x81000490")]
    public const uint DIKEYBOARD_PREVTRACK = 0x81000490;

    [NativeTypeName("#define DIKEYBOARD_AT 0x81000491")]
    public const uint DIKEYBOARD_AT = 0x81000491;

    [NativeTypeName("#define DIKEYBOARD_COLON 0x81000492")]
    public const uint DIKEYBOARD_COLON = 0x81000492;

    [NativeTypeName("#define DIKEYBOARD_UNDERLINE 0x81000493")]
    public const uint DIKEYBOARD_UNDERLINE = 0x81000493;

    [NativeTypeName("#define DIKEYBOARD_KANJI 0x81000494")]
    public const uint DIKEYBOARD_KANJI = 0x81000494;

    [NativeTypeName("#define DIKEYBOARD_STOP 0x81000495")]
    public const uint DIKEYBOARD_STOP = 0x81000495;

    [NativeTypeName("#define DIKEYBOARD_AX 0x81000496")]
    public const uint DIKEYBOARD_AX = 0x81000496;

    [NativeTypeName("#define DIKEYBOARD_UNLABELED 0x81000497")]
    public const uint DIKEYBOARD_UNLABELED = 0x81000497;

    [NativeTypeName("#define DIKEYBOARD_NEXTTRACK 0x81000499")]
    public const uint DIKEYBOARD_NEXTTRACK = 0x81000499;

    [NativeTypeName("#define DIKEYBOARD_NUMPADENTER 0x8100049C")]
    public const uint DIKEYBOARD_NUMPADENTER = 0x8100049C;

    [NativeTypeName("#define DIKEYBOARD_RCONTROL 0x8100049D")]
    public const uint DIKEYBOARD_RCONTROL = 0x8100049D;

    [NativeTypeName("#define DIKEYBOARD_MUTE 0x810004A0")]
    public const uint DIKEYBOARD_MUTE = 0x810004A0;

    [NativeTypeName("#define DIKEYBOARD_CALCULATOR 0x810004A1")]
    public const uint DIKEYBOARD_CALCULATOR = 0x810004A1;

    [NativeTypeName("#define DIKEYBOARD_PLAYPAUSE 0x810004A2")]
    public const uint DIKEYBOARD_PLAYPAUSE = 0x810004A2;

    [NativeTypeName("#define DIKEYBOARD_MEDIASTOP 0x810004A4")]
    public const uint DIKEYBOARD_MEDIASTOP = 0x810004A4;

    [NativeTypeName("#define DIKEYBOARD_VOLUMEDOWN 0x810004AE")]
    public const uint DIKEYBOARD_VOLUMEDOWN = 0x810004AE;

    [NativeTypeName("#define DIKEYBOARD_VOLUMEUP 0x810004B0")]
    public const uint DIKEYBOARD_VOLUMEUP = 0x810004B0;

    [NativeTypeName("#define DIKEYBOARD_WEBHOME 0x810004B2")]
    public const uint DIKEYBOARD_WEBHOME = 0x810004B2;

    [NativeTypeName("#define DIKEYBOARD_NUMPADCOMMA 0x810004B3")]
    public const uint DIKEYBOARD_NUMPADCOMMA = 0x810004B3;

    [NativeTypeName("#define DIKEYBOARD_DIVIDE 0x810004B5")]
    public const uint DIKEYBOARD_DIVIDE = 0x810004B5;

    [NativeTypeName("#define DIKEYBOARD_SYSRQ 0x810004B7")]
    public const uint DIKEYBOARD_SYSRQ = 0x810004B7;

    [NativeTypeName("#define DIKEYBOARD_RMENU 0x810004B8")]
    public const uint DIKEYBOARD_RMENU = 0x810004B8;

    [NativeTypeName("#define DIKEYBOARD_PAUSE 0x810004C5")]
    public const uint DIKEYBOARD_PAUSE = 0x810004C5;

    [NativeTypeName("#define DIKEYBOARD_HOME 0x810004C7")]
    public const uint DIKEYBOARD_HOME = 0x810004C7;

    [NativeTypeName("#define DIKEYBOARD_UP 0x810004C8")]
    public const uint DIKEYBOARD_UP = 0x810004C8;

    [NativeTypeName("#define DIKEYBOARD_PRIOR 0x810004C9")]
    public const uint DIKEYBOARD_PRIOR = 0x810004C9;

    [NativeTypeName("#define DIKEYBOARD_LEFT 0x810004CB")]
    public const uint DIKEYBOARD_LEFT = 0x810004CB;

    [NativeTypeName("#define DIKEYBOARD_RIGHT 0x810004CD")]
    public const uint DIKEYBOARD_RIGHT = 0x810004CD;

    [NativeTypeName("#define DIKEYBOARD_END 0x810004CF")]
    public const uint DIKEYBOARD_END = 0x810004CF;

    [NativeTypeName("#define DIKEYBOARD_DOWN 0x810004D0")]
    public const uint DIKEYBOARD_DOWN = 0x810004D0;

    [NativeTypeName("#define DIKEYBOARD_NEXT 0x810004D1")]
    public const uint DIKEYBOARD_NEXT = 0x810004D1;

    [NativeTypeName("#define DIKEYBOARD_INSERT 0x810004D2")]
    public const uint DIKEYBOARD_INSERT = 0x810004D2;

    [NativeTypeName("#define DIKEYBOARD_DELETE 0x810004D3")]
    public const uint DIKEYBOARD_DELETE = 0x810004D3;

    [NativeTypeName("#define DIKEYBOARD_LWIN 0x810004DB")]
    public const uint DIKEYBOARD_LWIN = 0x810004DB;

    [NativeTypeName("#define DIKEYBOARD_RWIN 0x810004DC")]
    public const uint DIKEYBOARD_RWIN = 0x810004DC;

    [NativeTypeName("#define DIKEYBOARD_APPS 0x810004DD")]
    public const uint DIKEYBOARD_APPS = 0x810004DD;

    [NativeTypeName("#define DIKEYBOARD_POWER 0x810004DE")]
    public const uint DIKEYBOARD_POWER = 0x810004DE;

    [NativeTypeName("#define DIKEYBOARD_SLEEP 0x810004DF")]
    public const uint DIKEYBOARD_SLEEP = 0x810004DF;

    [NativeTypeName("#define DIKEYBOARD_WAKE 0x810004E3")]
    public const uint DIKEYBOARD_WAKE = 0x810004E3;

    [NativeTypeName("#define DIKEYBOARD_WEBSEARCH 0x810004E5")]
    public const uint DIKEYBOARD_WEBSEARCH = 0x810004E5;

    [NativeTypeName("#define DIKEYBOARD_WEBFAVORITES 0x810004E6")]
    public const uint DIKEYBOARD_WEBFAVORITES = 0x810004E6;

    [NativeTypeName("#define DIKEYBOARD_WEBREFRESH 0x810004E7")]
    public const uint DIKEYBOARD_WEBREFRESH = 0x810004E7;

    [NativeTypeName("#define DIKEYBOARD_WEBSTOP 0x810004E8")]
    public const uint DIKEYBOARD_WEBSTOP = 0x810004E8;

    [NativeTypeName("#define DIKEYBOARD_WEBFORWARD 0x810004E9")]
    public const uint DIKEYBOARD_WEBFORWARD = 0x810004E9;

    [NativeTypeName("#define DIKEYBOARD_WEBBACK 0x810004EA")]
    public const uint DIKEYBOARD_WEBBACK = 0x810004EA;

    [NativeTypeName("#define DIKEYBOARD_MYCOMPUTER 0x810004EB")]
    public const uint DIKEYBOARD_MYCOMPUTER = 0x810004EB;

    [NativeTypeName("#define DIKEYBOARD_MAIL 0x810004EC")]
    public const uint DIKEYBOARD_MAIL = 0x810004EC;

    [NativeTypeName("#define DIKEYBOARD_MEDIASELECT 0x810004ED")]
    public const uint DIKEYBOARD_MEDIASELECT = 0x810004ED;

    [NativeTypeName("#define DIVOICE_CHANNEL1 0x83000401")]
    public const uint DIVOICE_CHANNEL1 = 0x83000401;

    [NativeTypeName("#define DIVOICE_CHANNEL2 0x83000402")]
    public const uint DIVOICE_CHANNEL2 = 0x83000402;

    [NativeTypeName("#define DIVOICE_CHANNEL3 0x83000403")]
    public const uint DIVOICE_CHANNEL3 = 0x83000403;

    [NativeTypeName("#define DIVOICE_CHANNEL4 0x83000404")]
    public const uint DIVOICE_CHANNEL4 = 0x83000404;

    [NativeTypeName("#define DIVOICE_CHANNEL5 0x83000405")]
    public const uint DIVOICE_CHANNEL5 = 0x83000405;

    [NativeTypeName("#define DIVOICE_CHANNEL6 0x83000406")]
    public const uint DIVOICE_CHANNEL6 = 0x83000406;

    [NativeTypeName("#define DIVOICE_CHANNEL7 0x83000407")]
    public const uint DIVOICE_CHANNEL7 = 0x83000407;

    [NativeTypeName("#define DIVOICE_CHANNEL8 0x83000408")]
    public const uint DIVOICE_CHANNEL8 = 0x83000408;

    [NativeTypeName("#define DIVOICE_TEAM 0x83000409")]
    public const uint DIVOICE_TEAM = 0x83000409;

    [NativeTypeName("#define DIVOICE_ALL 0x8300040A")]
    public const uint DIVOICE_ALL = 0x8300040A;

    [NativeTypeName("#define DIVOICE_RECORDMUTE 0x8300040B")]
    public const uint DIVOICE_RECORDMUTE = 0x8300040B;

    [NativeTypeName("#define DIVOICE_PLAYBACKMUTE 0x8300040C")]
    public const uint DIVOICE_PLAYBACKMUTE = 0x8300040C;

    [NativeTypeName("#define DIVOICE_TRANSMIT 0x8300040D")]
    public const uint DIVOICE_TRANSMIT = 0x8300040D;

    [NativeTypeName("#define DIVOICE_VOICECOMMAND 0x83000410")]
    public const uint DIVOICE_VOICECOMMAND = 0x83000410;

    [NativeTypeName("#define DIVIRTUAL_DRIVING_RACE 0x01000000")]
    public const int DIVIRTUAL_DRIVING_RACE = 0x01000000;

    [NativeTypeName("#define DIAXIS_DRIVINGR_STEER 0x01008A01")]
    public const int DIAXIS_DRIVINGR_STEER = 0x01008A01;

    [NativeTypeName("#define DIAXIS_DRIVINGR_ACCELERATE 0x01039202")]
    public const int DIAXIS_DRIVINGR_ACCELERATE = 0x01039202;

    [NativeTypeName("#define DIAXIS_DRIVINGR_BRAKE 0x01041203")]
    public const int DIAXIS_DRIVINGR_BRAKE = 0x01041203;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_SHIFTUP 0x01000C01")]
    public const int DIBUTTON_DRIVINGR_SHIFTUP = 0x01000C01;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_SHIFTDOWN 0x01000C02")]
    public const int DIBUTTON_DRIVINGR_SHIFTDOWN = 0x01000C02;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_VIEW 0x01001C03")]
    public const int DIBUTTON_DRIVINGR_VIEW = 0x01001C03;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_MENU 0x010004FD")]
    public const int DIBUTTON_DRIVINGR_MENU = 0x010004FD;

    [NativeTypeName("#define DIAXIS_DRIVINGR_ACCEL_AND_BRAKE 0x01014A04")]
    public const int DIAXIS_DRIVINGR_ACCEL_AND_BRAKE = 0x01014A04;

    [NativeTypeName("#define DIHATSWITCH_DRIVINGR_GLANCE 0x01004601")]
    public const int DIHATSWITCH_DRIVINGR_GLANCE = 0x01004601;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_BRAKE 0x01004C04")]
    public const int DIBUTTON_DRIVINGR_BRAKE = 0x01004C04;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_DASHBOARD 0x01004405")]
    public const int DIBUTTON_DRIVINGR_DASHBOARD = 0x01004405;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_AIDS 0x01004406")]
    public const int DIBUTTON_DRIVINGR_AIDS = 0x01004406;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_MAP 0x01004407")]
    public const int DIBUTTON_DRIVINGR_MAP = 0x01004407;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_BOOST 0x01004408")]
    public const int DIBUTTON_DRIVINGR_BOOST = 0x01004408;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_PIT 0x01004409")]
    public const int DIBUTTON_DRIVINGR_PIT = 0x01004409;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_ACCELERATE_LINK 0x0103D4E0")]
    public const int DIBUTTON_DRIVINGR_ACCELERATE_LINK = 0x0103D4E0;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_STEER_LEFT_LINK 0x0100CCE4")]
    public const int DIBUTTON_DRIVINGR_STEER_LEFT_LINK = 0x0100CCE4;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_STEER_RIGHT_LINK 0x0100CCEC")]
    public const int DIBUTTON_DRIVINGR_STEER_RIGHT_LINK = 0x0100CCEC;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_GLANCE_LEFT_LINK 0x0107C4E4")]
    public const int DIBUTTON_DRIVINGR_GLANCE_LEFT_LINK = 0x0107C4E4;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_GLANCE_RIGHT_LINK 0x0107C4EC")]
    public const int DIBUTTON_DRIVINGR_GLANCE_RIGHT_LINK = 0x0107C4EC;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_DEVICE 0x010044FE")]
    public const int DIBUTTON_DRIVINGR_DEVICE = 0x010044FE;

    [NativeTypeName("#define DIBUTTON_DRIVINGR_PAUSE 0x010044FC")]
    public const int DIBUTTON_DRIVINGR_PAUSE = 0x010044FC;

    [NativeTypeName("#define DIVIRTUAL_DRIVING_COMBAT 0x02000000")]
    public const int DIVIRTUAL_DRIVING_COMBAT = 0x02000000;

    [NativeTypeName("#define DIAXIS_DRIVINGC_STEER 0x02008A01")]
    public const int DIAXIS_DRIVINGC_STEER = 0x02008A01;

    [NativeTypeName("#define DIAXIS_DRIVINGC_ACCELERATE 0x02039202")]
    public const int DIAXIS_DRIVINGC_ACCELERATE = 0x02039202;

    [NativeTypeName("#define DIAXIS_DRIVINGC_BRAKE 0x02041203")]
    public const int DIAXIS_DRIVINGC_BRAKE = 0x02041203;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_FIRE 0x02000C01")]
    public const int DIBUTTON_DRIVINGC_FIRE = 0x02000C01;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_WEAPONS 0x02000C02")]
    public const int DIBUTTON_DRIVINGC_WEAPONS = 0x02000C02;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_TARGET 0x02000C03")]
    public const int DIBUTTON_DRIVINGC_TARGET = 0x02000C03;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_MENU 0x020004FD")]
    public const int DIBUTTON_DRIVINGC_MENU = 0x020004FD;

    [NativeTypeName("#define DIAXIS_DRIVINGC_ACCEL_AND_BRAKE 0x02014A04")]
    public const int DIAXIS_DRIVINGC_ACCEL_AND_BRAKE = 0x02014A04;

    [NativeTypeName("#define DIHATSWITCH_DRIVINGC_GLANCE 0x02004601")]
    public const int DIHATSWITCH_DRIVINGC_GLANCE = 0x02004601;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_SHIFTUP 0x02004C04")]
    public const int DIBUTTON_DRIVINGC_SHIFTUP = 0x02004C04;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_SHIFTDOWN 0x02004C05")]
    public const int DIBUTTON_DRIVINGC_SHIFTDOWN = 0x02004C05;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_DASHBOARD 0x02004406")]
    public const int DIBUTTON_DRIVINGC_DASHBOARD = 0x02004406;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_AIDS 0x02004407")]
    public const int DIBUTTON_DRIVINGC_AIDS = 0x02004407;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_BRAKE 0x02004C08")]
    public const int DIBUTTON_DRIVINGC_BRAKE = 0x02004C08;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_FIRESECONDARY 0x02004C09")]
    public const int DIBUTTON_DRIVINGC_FIRESECONDARY = 0x02004C09;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_ACCELERATE_LINK 0x0203D4E0")]
    public const int DIBUTTON_DRIVINGC_ACCELERATE_LINK = 0x0203D4E0;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_STEER_LEFT_LINK 0x0200CCE4")]
    public const int DIBUTTON_DRIVINGC_STEER_LEFT_LINK = 0x0200CCE4;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_STEER_RIGHT_LINK 0x0200CCEC")]
    public const int DIBUTTON_DRIVINGC_STEER_RIGHT_LINK = 0x0200CCEC;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_GLANCE_LEFT_LINK 0x0207C4E4")]
    public const int DIBUTTON_DRIVINGC_GLANCE_LEFT_LINK = 0x0207C4E4;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_GLANCE_RIGHT_LINK 0x0207C4EC")]
    public const int DIBUTTON_DRIVINGC_GLANCE_RIGHT_LINK = 0x0207C4EC;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_DEVICE 0x020044FE")]
    public const int DIBUTTON_DRIVINGC_DEVICE = 0x020044FE;

    [NativeTypeName("#define DIBUTTON_DRIVINGC_PAUSE 0x020044FC")]
    public const int DIBUTTON_DRIVINGC_PAUSE = 0x020044FC;

    [NativeTypeName("#define DIVIRTUAL_DRIVING_TANK 0x03000000")]
    public const int DIVIRTUAL_DRIVING_TANK = 0x03000000;

    [NativeTypeName("#define DIAXIS_DRIVINGT_STEER 0x03008A01")]
    public const int DIAXIS_DRIVINGT_STEER = 0x03008A01;

    [NativeTypeName("#define DIAXIS_DRIVINGT_BARREL 0x03010202")]
    public const int DIAXIS_DRIVINGT_BARREL = 0x03010202;

    [NativeTypeName("#define DIAXIS_DRIVINGT_ACCELERATE 0x03039203")]
    public const int DIAXIS_DRIVINGT_ACCELERATE = 0x03039203;

    [NativeTypeName("#define DIAXIS_DRIVINGT_ROTATE 0x03020204")]
    public const int DIAXIS_DRIVINGT_ROTATE = 0x03020204;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_FIRE 0x03000C01")]
    public const int DIBUTTON_DRIVINGT_FIRE = 0x03000C01;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_WEAPONS 0x03000C02")]
    public const int DIBUTTON_DRIVINGT_WEAPONS = 0x03000C02;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_TARGET 0x03000C03")]
    public const int DIBUTTON_DRIVINGT_TARGET = 0x03000C03;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_MENU 0x030004FD")]
    public const int DIBUTTON_DRIVINGT_MENU = 0x030004FD;

    [NativeTypeName("#define DIHATSWITCH_DRIVINGT_GLANCE 0x03004601")]
    public const int DIHATSWITCH_DRIVINGT_GLANCE = 0x03004601;

    [NativeTypeName("#define DIAXIS_DRIVINGT_BRAKE 0x03045205")]
    public const int DIAXIS_DRIVINGT_BRAKE = 0x03045205;

    [NativeTypeName("#define DIAXIS_DRIVINGT_ACCEL_AND_BRAKE 0x03014A06")]
    public const int DIAXIS_DRIVINGT_ACCEL_AND_BRAKE = 0x03014A06;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_VIEW 0x03005C04")]
    public const int DIBUTTON_DRIVINGT_VIEW = 0x03005C04;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_DASHBOARD 0x03005C05")]
    public const int DIBUTTON_DRIVINGT_DASHBOARD = 0x03005C05;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_BRAKE 0x03004C06")]
    public const int DIBUTTON_DRIVINGT_BRAKE = 0x03004C06;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_FIRESECONDARY 0x03004C07")]
    public const int DIBUTTON_DRIVINGT_FIRESECONDARY = 0x03004C07;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_ACCELERATE_LINK 0x0303D4E0")]
    public const int DIBUTTON_DRIVINGT_ACCELERATE_LINK = 0x0303D4E0;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_STEER_LEFT_LINK 0x0300CCE4")]
    public const int DIBUTTON_DRIVINGT_STEER_LEFT_LINK = 0x0300CCE4;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_STEER_RIGHT_LINK 0x0300CCEC")]
    public const int DIBUTTON_DRIVINGT_STEER_RIGHT_LINK = 0x0300CCEC;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_BARREL_UP_LINK 0x030144E0")]
    public const int DIBUTTON_DRIVINGT_BARREL_UP_LINK = 0x030144E0;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_BARREL_DOWN_LINK 0x030144E8")]
    public const int DIBUTTON_DRIVINGT_BARREL_DOWN_LINK = 0x030144E8;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_ROTATE_LEFT_LINK 0x030244E4")]
    public const int DIBUTTON_DRIVINGT_ROTATE_LEFT_LINK = 0x030244E4;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_ROTATE_RIGHT_LINK 0x030244EC")]
    public const int DIBUTTON_DRIVINGT_ROTATE_RIGHT_LINK = 0x030244EC;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_GLANCE_LEFT_LINK 0x0307C4E4")]
    public const int DIBUTTON_DRIVINGT_GLANCE_LEFT_LINK = 0x0307C4E4;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_GLANCE_RIGHT_LINK 0x0307C4EC")]
    public const int DIBUTTON_DRIVINGT_GLANCE_RIGHT_LINK = 0x0307C4EC;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_DEVICE 0x030044FE")]
    public const int DIBUTTON_DRIVINGT_DEVICE = 0x030044FE;

    [NativeTypeName("#define DIBUTTON_DRIVINGT_PAUSE 0x030044FC")]
    public const int DIBUTTON_DRIVINGT_PAUSE = 0x030044FC;

    [NativeTypeName("#define DIVIRTUAL_FLYING_CIVILIAN 0x04000000")]
    public const int DIVIRTUAL_FLYING_CIVILIAN = 0x04000000;

    [NativeTypeName("#define DIAXIS_FLYINGC_BANK 0x04008A01")]
    public const int DIAXIS_FLYINGC_BANK = 0x04008A01;

    [NativeTypeName("#define DIAXIS_FLYINGC_PITCH 0x04010A02")]
    public const int DIAXIS_FLYINGC_PITCH = 0x04010A02;

    [NativeTypeName("#define DIAXIS_FLYINGC_THROTTLE 0x04039203")]
    public const int DIAXIS_FLYINGC_THROTTLE = 0x04039203;

    [NativeTypeName("#define DIBUTTON_FLYINGC_VIEW 0x04002401")]
    public const int DIBUTTON_FLYINGC_VIEW = 0x04002401;

    [NativeTypeName("#define DIBUTTON_FLYINGC_DISPLAY 0x04002402")]
    public const int DIBUTTON_FLYINGC_DISPLAY = 0x04002402;

    [NativeTypeName("#define DIBUTTON_FLYINGC_GEAR 0x04002C03")]
    public const int DIBUTTON_FLYINGC_GEAR = 0x04002C03;

    [NativeTypeName("#define DIBUTTON_FLYINGC_MENU 0x040004FD")]
    public const int DIBUTTON_FLYINGC_MENU = 0x040004FD;

    [NativeTypeName("#define DIHATSWITCH_FLYINGC_GLANCE 0x04004601")]
    public const int DIHATSWITCH_FLYINGC_GLANCE = 0x04004601;

    [NativeTypeName("#define DIAXIS_FLYINGC_BRAKE 0x04046A04")]
    public const int DIAXIS_FLYINGC_BRAKE = 0x04046A04;

    [NativeTypeName("#define DIAXIS_FLYINGC_RUDDER 0x04025205")]
    public const int DIAXIS_FLYINGC_RUDDER = 0x04025205;

    [NativeTypeName("#define DIAXIS_FLYINGC_FLAPS 0x04055A06")]
    public const int DIAXIS_FLYINGC_FLAPS = 0x04055A06;

    [NativeTypeName("#define DIBUTTON_FLYINGC_FLAPSUP 0x04006404")]
    public const int DIBUTTON_FLYINGC_FLAPSUP = 0x04006404;

    [NativeTypeName("#define DIBUTTON_FLYINGC_FLAPSDOWN 0x04006405")]
    public const int DIBUTTON_FLYINGC_FLAPSDOWN = 0x04006405;

    [NativeTypeName("#define DIBUTTON_FLYINGC_BRAKE_LINK 0x04046CE0")]
    public const int DIBUTTON_FLYINGC_BRAKE_LINK = 0x04046CE0;

    [NativeTypeName("#define DIBUTTON_FLYINGC_FASTER_LINK 0x0403D4E0")]
    public const int DIBUTTON_FLYINGC_FASTER_LINK = 0x0403D4E0;

    [NativeTypeName("#define DIBUTTON_FLYINGC_SLOWER_LINK 0x0403D4E8")]
    public const int DIBUTTON_FLYINGC_SLOWER_LINK = 0x0403D4E8;

    [NativeTypeName("#define DIBUTTON_FLYINGC_GLANCE_LEFT_LINK 0x0407C4E4")]
    public const int DIBUTTON_FLYINGC_GLANCE_LEFT_LINK = 0x0407C4E4;

    [NativeTypeName("#define DIBUTTON_FLYINGC_GLANCE_RIGHT_LINK 0x0407C4EC")]
    public const int DIBUTTON_FLYINGC_GLANCE_RIGHT_LINK = 0x0407C4EC;

    [NativeTypeName("#define DIBUTTON_FLYINGC_GLANCE_UP_LINK 0x0407C4E0")]
    public const int DIBUTTON_FLYINGC_GLANCE_UP_LINK = 0x0407C4E0;

    [NativeTypeName("#define DIBUTTON_FLYINGC_GLANCE_DOWN_LINK 0x0407C4E8")]
    public const int DIBUTTON_FLYINGC_GLANCE_DOWN_LINK = 0x0407C4E8;

    [NativeTypeName("#define DIBUTTON_FLYINGC_DEVICE 0x040044FE")]
    public const int DIBUTTON_FLYINGC_DEVICE = 0x040044FE;

    [NativeTypeName("#define DIBUTTON_FLYINGC_PAUSE 0x040044FC")]
    public const int DIBUTTON_FLYINGC_PAUSE = 0x040044FC;

    [NativeTypeName("#define DIVIRTUAL_FLYING_MILITARY 0x05000000")]
    public const int DIVIRTUAL_FLYING_MILITARY = 0x05000000;

    [NativeTypeName("#define DIAXIS_FLYINGM_BANK 0x05008A01")]
    public const int DIAXIS_FLYINGM_BANK = 0x05008A01;

    [NativeTypeName("#define DIAXIS_FLYINGM_PITCH 0x05010A02")]
    public const int DIAXIS_FLYINGM_PITCH = 0x05010A02;

    [NativeTypeName("#define DIAXIS_FLYINGM_THROTTLE 0x05039203")]
    public const int DIAXIS_FLYINGM_THROTTLE = 0x05039203;

    [NativeTypeName("#define DIBUTTON_FLYINGM_FIRE 0x05000C01")]
    public const int DIBUTTON_FLYINGM_FIRE = 0x05000C01;

    [NativeTypeName("#define DIBUTTON_FLYINGM_WEAPONS 0x05000C02")]
    public const int DIBUTTON_FLYINGM_WEAPONS = 0x05000C02;

    [NativeTypeName("#define DIBUTTON_FLYINGM_TARGET 0x05000C03")]
    public const int DIBUTTON_FLYINGM_TARGET = 0x05000C03;

    [NativeTypeName("#define DIBUTTON_FLYINGM_MENU 0x050004FD")]
    public const int DIBUTTON_FLYINGM_MENU = 0x050004FD;

    [NativeTypeName("#define DIHATSWITCH_FLYINGM_GLANCE 0x05004601")]
    public const int DIHATSWITCH_FLYINGM_GLANCE = 0x05004601;

    [NativeTypeName("#define DIBUTTON_FLYINGM_COUNTER 0x05005C04")]
    public const int DIBUTTON_FLYINGM_COUNTER = 0x05005C04;

    [NativeTypeName("#define DIAXIS_FLYINGM_RUDDER 0x05024A04")]
    public const int DIAXIS_FLYINGM_RUDDER = 0x05024A04;

    [NativeTypeName("#define DIAXIS_FLYINGM_BRAKE 0x05046205")]
    public const int DIAXIS_FLYINGM_BRAKE = 0x05046205;

    [NativeTypeName("#define DIBUTTON_FLYINGM_VIEW 0x05006405")]
    public const int DIBUTTON_FLYINGM_VIEW = 0x05006405;

    [NativeTypeName("#define DIBUTTON_FLYINGM_DISPLAY 0x05006406")]
    public const int DIBUTTON_FLYINGM_DISPLAY = 0x05006406;

    [NativeTypeName("#define DIAXIS_FLYINGM_FLAPS 0x05055206")]
    public const int DIAXIS_FLYINGM_FLAPS = 0x05055206;

    [NativeTypeName("#define DIBUTTON_FLYINGM_FLAPSUP 0x05005407")]
    public const int DIBUTTON_FLYINGM_FLAPSUP = 0x05005407;

    [NativeTypeName("#define DIBUTTON_FLYINGM_FLAPSDOWN 0x05005408")]
    public const int DIBUTTON_FLYINGM_FLAPSDOWN = 0x05005408;

    [NativeTypeName("#define DIBUTTON_FLYINGM_FIRESECONDARY 0x05004C09")]
    public const int DIBUTTON_FLYINGM_FIRESECONDARY = 0x05004C09;

    [NativeTypeName("#define DIBUTTON_FLYINGM_GEAR 0x0500640A")]
    public const int DIBUTTON_FLYINGM_GEAR = 0x0500640A;

    [NativeTypeName("#define DIBUTTON_FLYINGM_BRAKE_LINK 0x050464E0")]
    public const int DIBUTTON_FLYINGM_BRAKE_LINK = 0x050464E0;

    [NativeTypeName("#define DIBUTTON_FLYINGM_FASTER_LINK 0x0503D4E0")]
    public const int DIBUTTON_FLYINGM_FASTER_LINK = 0x0503D4E0;

    [NativeTypeName("#define DIBUTTON_FLYINGM_SLOWER_LINK 0x0503D4E8")]
    public const int DIBUTTON_FLYINGM_SLOWER_LINK = 0x0503D4E8;

    [NativeTypeName("#define DIBUTTON_FLYINGM_GLANCE_LEFT_LINK 0x0507C4E4")]
    public const int DIBUTTON_FLYINGM_GLANCE_LEFT_LINK = 0x0507C4E4;

    [NativeTypeName("#define DIBUTTON_FLYINGM_GLANCE_RIGHT_LINK 0x0507C4EC")]
    public const int DIBUTTON_FLYINGM_GLANCE_RIGHT_LINK = 0x0507C4EC;

    [NativeTypeName("#define DIBUTTON_FLYINGM_GLANCE_UP_LINK 0x0507C4E0")]
    public const int DIBUTTON_FLYINGM_GLANCE_UP_LINK = 0x0507C4E0;

    [NativeTypeName("#define DIBUTTON_FLYINGM_GLANCE_DOWN_LINK 0x0507C4E8")]
    public const int DIBUTTON_FLYINGM_GLANCE_DOWN_LINK = 0x0507C4E8;

    [NativeTypeName("#define DIBUTTON_FLYINGM_DEVICE 0x050044FE")]
    public const int DIBUTTON_FLYINGM_DEVICE = 0x050044FE;

    [NativeTypeName("#define DIBUTTON_FLYINGM_PAUSE 0x050044FC")]
    public const int DIBUTTON_FLYINGM_PAUSE = 0x050044FC;

    [NativeTypeName("#define DIVIRTUAL_FLYING_HELICOPTER 0x06000000")]
    public const int DIVIRTUAL_FLYING_HELICOPTER = 0x06000000;

    [NativeTypeName("#define DIAXIS_FLYINGH_BANK 0x06008A01")]
    public const int DIAXIS_FLYINGH_BANK = 0x06008A01;

    [NativeTypeName("#define DIAXIS_FLYINGH_PITCH 0x06010A02")]
    public const int DIAXIS_FLYINGH_PITCH = 0x06010A02;

    [NativeTypeName("#define DIAXIS_FLYINGH_COLLECTIVE 0x06018A03")]
    public const int DIAXIS_FLYINGH_COLLECTIVE = 0x06018A03;

    [NativeTypeName("#define DIBUTTON_FLYINGH_FIRE 0x06001401")]
    public const int DIBUTTON_FLYINGH_FIRE = 0x06001401;

    [NativeTypeName("#define DIBUTTON_FLYINGH_WEAPONS 0x06001402")]
    public const int DIBUTTON_FLYINGH_WEAPONS = 0x06001402;

    [NativeTypeName("#define DIBUTTON_FLYINGH_TARGET 0x06001403")]
    public const int DIBUTTON_FLYINGH_TARGET = 0x06001403;

    [NativeTypeName("#define DIBUTTON_FLYINGH_MENU 0x060004FD")]
    public const int DIBUTTON_FLYINGH_MENU = 0x060004FD;

    [NativeTypeName("#define DIHATSWITCH_FLYINGH_GLANCE 0x06004601")]
    public const int DIHATSWITCH_FLYINGH_GLANCE = 0x06004601;

    [NativeTypeName("#define DIAXIS_FLYINGH_TORQUE 0x06025A04")]
    public const int DIAXIS_FLYINGH_TORQUE = 0x06025A04;

    [NativeTypeName("#define DIAXIS_FLYINGH_THROTTLE 0x0603DA05")]
    public const int DIAXIS_FLYINGH_THROTTLE = 0x0603DA05;

    [NativeTypeName("#define DIBUTTON_FLYINGH_COUNTER 0x06005404")]
    public const int DIBUTTON_FLYINGH_COUNTER = 0x06005404;

    [NativeTypeName("#define DIBUTTON_FLYINGH_VIEW 0x06006405")]
    public const int DIBUTTON_FLYINGH_VIEW = 0x06006405;

    [NativeTypeName("#define DIBUTTON_FLYINGH_GEAR 0x06006406")]
    public const int DIBUTTON_FLYINGH_GEAR = 0x06006406;

    [NativeTypeName("#define DIBUTTON_FLYINGH_FIRESECONDARY 0x06004C07")]
    public const int DIBUTTON_FLYINGH_FIRESECONDARY = 0x06004C07;

    [NativeTypeName("#define DIBUTTON_FLYINGH_FASTER_LINK 0x0603DCE0")]
    public const int DIBUTTON_FLYINGH_FASTER_LINK = 0x0603DCE0;

    [NativeTypeName("#define DIBUTTON_FLYINGH_SLOWER_LINK 0x0603DCE8")]
    public const int DIBUTTON_FLYINGH_SLOWER_LINK = 0x0603DCE8;

    [NativeTypeName("#define DIBUTTON_FLYINGH_GLANCE_LEFT_LINK 0x0607C4E4")]
    public const int DIBUTTON_FLYINGH_GLANCE_LEFT_LINK = 0x0607C4E4;

    [NativeTypeName("#define DIBUTTON_FLYINGH_GLANCE_RIGHT_LINK 0x0607C4EC")]
    public const int DIBUTTON_FLYINGH_GLANCE_RIGHT_LINK = 0x0607C4EC;

    [NativeTypeName("#define DIBUTTON_FLYINGH_GLANCE_UP_LINK 0x0607C4E0")]
    public const int DIBUTTON_FLYINGH_GLANCE_UP_LINK = 0x0607C4E0;

    [NativeTypeName("#define DIBUTTON_FLYINGH_GLANCE_DOWN_LINK 0x0607C4E8")]
    public const int DIBUTTON_FLYINGH_GLANCE_DOWN_LINK = 0x0607C4E8;

    [NativeTypeName("#define DIBUTTON_FLYINGH_DEVICE 0x060044FE")]
    public const int DIBUTTON_FLYINGH_DEVICE = 0x060044FE;

    [NativeTypeName("#define DIBUTTON_FLYINGH_PAUSE 0x060044FC")]
    public const int DIBUTTON_FLYINGH_PAUSE = 0x060044FC;

    [NativeTypeName("#define DIVIRTUAL_SPACESIM 0x07000000")]
    public const int DIVIRTUAL_SPACESIM = 0x07000000;

    [NativeTypeName("#define DIAXIS_SPACESIM_LATERAL 0x07008201")]
    public const int DIAXIS_SPACESIM_LATERAL = 0x07008201;

    [NativeTypeName("#define DIAXIS_SPACESIM_MOVE 0x07010202")]
    public const int DIAXIS_SPACESIM_MOVE = 0x07010202;

    [NativeTypeName("#define DIAXIS_SPACESIM_THROTTLE 0x07038203")]
    public const int DIAXIS_SPACESIM_THROTTLE = 0x07038203;

    [NativeTypeName("#define DIBUTTON_SPACESIM_FIRE 0x07000401")]
    public const int DIBUTTON_SPACESIM_FIRE = 0x07000401;

    [NativeTypeName("#define DIBUTTON_SPACESIM_WEAPONS 0x07000402")]
    public const int DIBUTTON_SPACESIM_WEAPONS = 0x07000402;

    [NativeTypeName("#define DIBUTTON_SPACESIM_TARGET 0x07000403")]
    public const int DIBUTTON_SPACESIM_TARGET = 0x07000403;

    [NativeTypeName("#define DIBUTTON_SPACESIM_MENU 0x070004FD")]
    public const int DIBUTTON_SPACESIM_MENU = 0x070004FD;

    [NativeTypeName("#define DIHATSWITCH_SPACESIM_GLANCE 0x07004601")]
    public const int DIHATSWITCH_SPACESIM_GLANCE = 0x07004601;

    [NativeTypeName("#define DIAXIS_SPACESIM_CLIMB 0x0701C204")]
    public const int DIAXIS_SPACESIM_CLIMB = 0x0701C204;

    [NativeTypeName("#define DIAXIS_SPACESIM_ROTATE 0x07024205")]
    public const int DIAXIS_SPACESIM_ROTATE = 0x07024205;

    [NativeTypeName("#define DIBUTTON_SPACESIM_VIEW 0x07004404")]
    public const int DIBUTTON_SPACESIM_VIEW = 0x07004404;

    [NativeTypeName("#define DIBUTTON_SPACESIM_DISPLAY 0x07004405")]
    public const int DIBUTTON_SPACESIM_DISPLAY = 0x07004405;

    [NativeTypeName("#define DIBUTTON_SPACESIM_RAISE 0x07004406")]
    public const int DIBUTTON_SPACESIM_RAISE = 0x07004406;

    [NativeTypeName("#define DIBUTTON_SPACESIM_LOWER 0x07004407")]
    public const int DIBUTTON_SPACESIM_LOWER = 0x07004407;

    [NativeTypeName("#define DIBUTTON_SPACESIM_GEAR 0x07004408")]
    public const int DIBUTTON_SPACESIM_GEAR = 0x07004408;

    [NativeTypeName("#define DIBUTTON_SPACESIM_FIRESECONDARY 0x07004409")]
    public const int DIBUTTON_SPACESIM_FIRESECONDARY = 0x07004409;

    [NativeTypeName("#define DIBUTTON_SPACESIM_LEFT_LINK 0x0700C4E4")]
    public const int DIBUTTON_SPACESIM_LEFT_LINK = 0x0700C4E4;

    [NativeTypeName("#define DIBUTTON_SPACESIM_RIGHT_LINK 0x0700C4EC")]
    public const int DIBUTTON_SPACESIM_RIGHT_LINK = 0x0700C4EC;

    [NativeTypeName("#define DIBUTTON_SPACESIM_FORWARD_LINK 0x070144E0")]
    public const int DIBUTTON_SPACESIM_FORWARD_LINK = 0x070144E0;

    [NativeTypeName("#define DIBUTTON_SPACESIM_BACKWARD_LINK 0x070144E8")]
    public const int DIBUTTON_SPACESIM_BACKWARD_LINK = 0x070144E8;

    [NativeTypeName("#define DIBUTTON_SPACESIM_FASTER_LINK 0x0703C4E0")]
    public const int DIBUTTON_SPACESIM_FASTER_LINK = 0x0703C4E0;

    [NativeTypeName("#define DIBUTTON_SPACESIM_SLOWER_LINK 0x0703C4E8")]
    public const int DIBUTTON_SPACESIM_SLOWER_LINK = 0x0703C4E8;

    [NativeTypeName("#define DIBUTTON_SPACESIM_TURN_LEFT_LINK 0x070244E4")]
    public const int DIBUTTON_SPACESIM_TURN_LEFT_LINK = 0x070244E4;

    [NativeTypeName("#define DIBUTTON_SPACESIM_TURN_RIGHT_LINK 0x070244EC")]
    public const int DIBUTTON_SPACESIM_TURN_RIGHT_LINK = 0x070244EC;

    [NativeTypeName("#define DIBUTTON_SPACESIM_GLANCE_LEFT_LINK 0x0707C4E4")]
    public const int DIBUTTON_SPACESIM_GLANCE_LEFT_LINK = 0x0707C4E4;

    [NativeTypeName("#define DIBUTTON_SPACESIM_GLANCE_RIGHT_LINK 0x0707C4EC")]
    public const int DIBUTTON_SPACESIM_GLANCE_RIGHT_LINK = 0x0707C4EC;

    [NativeTypeName("#define DIBUTTON_SPACESIM_GLANCE_UP_LINK 0x0707C4E0")]
    public const int DIBUTTON_SPACESIM_GLANCE_UP_LINK = 0x0707C4E0;

    [NativeTypeName("#define DIBUTTON_SPACESIM_GLANCE_DOWN_LINK 0x0707C4E8")]
    public const int DIBUTTON_SPACESIM_GLANCE_DOWN_LINK = 0x0707C4E8;

    [NativeTypeName("#define DIBUTTON_SPACESIM_DEVICE 0x070044FE")]
    public const int DIBUTTON_SPACESIM_DEVICE = 0x070044FE;

    [NativeTypeName("#define DIBUTTON_SPACESIM_PAUSE 0x070044FC")]
    public const int DIBUTTON_SPACESIM_PAUSE = 0x070044FC;

    [NativeTypeName("#define DIVIRTUAL_FIGHTING_HAND2HAND 0x08000000")]
    public const int DIVIRTUAL_FIGHTING_HAND2HAND = 0x08000000;

    [NativeTypeName("#define DIAXIS_FIGHTINGH_LATERAL 0x08008201")]
    public const int DIAXIS_FIGHTINGH_LATERAL = 0x08008201;

    [NativeTypeName("#define DIAXIS_FIGHTINGH_MOVE 0x08010202")]
    public const int DIAXIS_FIGHTINGH_MOVE = 0x08010202;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_PUNCH 0x08000401")]
    public const int DIBUTTON_FIGHTINGH_PUNCH = 0x08000401;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_KICK 0x08000402")]
    public const int DIBUTTON_FIGHTINGH_KICK = 0x08000402;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_BLOCK 0x08000403")]
    public const int DIBUTTON_FIGHTINGH_BLOCK = 0x08000403;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_CROUCH 0x08000404")]
    public const int DIBUTTON_FIGHTINGH_CROUCH = 0x08000404;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_JUMP 0x08000405")]
    public const int DIBUTTON_FIGHTINGH_JUMP = 0x08000405;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_SPECIAL1 0x08000406")]
    public const int DIBUTTON_FIGHTINGH_SPECIAL1 = 0x08000406;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_SPECIAL2 0x08000407")]
    public const int DIBUTTON_FIGHTINGH_SPECIAL2 = 0x08000407;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_MENU 0x080004FD")]
    public const int DIBUTTON_FIGHTINGH_MENU = 0x080004FD;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_SELECT 0x08004408")]
    public const int DIBUTTON_FIGHTINGH_SELECT = 0x08004408;

    [NativeTypeName("#define DIHATSWITCH_FIGHTINGH_SLIDE 0x08004601")]
    public const int DIHATSWITCH_FIGHTINGH_SLIDE = 0x08004601;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_DISPLAY 0x08004409")]
    public const int DIBUTTON_FIGHTINGH_DISPLAY = 0x08004409;

    [NativeTypeName("#define DIAXIS_FIGHTINGH_ROTATE 0x08024203")]
    public const int DIAXIS_FIGHTINGH_ROTATE = 0x08024203;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_DODGE 0x0800440A")]
    public const int DIBUTTON_FIGHTINGH_DODGE = 0x0800440A;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_LEFT_LINK 0x0800C4E4")]
    public const int DIBUTTON_FIGHTINGH_LEFT_LINK = 0x0800C4E4;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_RIGHT_LINK 0x0800C4EC")]
    public const int DIBUTTON_FIGHTINGH_RIGHT_LINK = 0x0800C4EC;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_FORWARD_LINK 0x080144E0")]
    public const int DIBUTTON_FIGHTINGH_FORWARD_LINK = 0x080144E0;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_BACKWARD_LINK 0x080144E8")]
    public const int DIBUTTON_FIGHTINGH_BACKWARD_LINK = 0x080144E8;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_DEVICE 0x080044FE")]
    public const int DIBUTTON_FIGHTINGH_DEVICE = 0x080044FE;

    [NativeTypeName("#define DIBUTTON_FIGHTINGH_PAUSE 0x080044FC")]
    public const int DIBUTTON_FIGHTINGH_PAUSE = 0x080044FC;

    [NativeTypeName("#define DIVIRTUAL_FIGHTING_FPS 0x09000000")]
    public const int DIVIRTUAL_FIGHTING_FPS = 0x09000000;

    [NativeTypeName("#define DIAXIS_FPS_ROTATE 0x09008201")]
    public const int DIAXIS_FPS_ROTATE = 0x09008201;

    [NativeTypeName("#define DIAXIS_FPS_MOVE 0x09010202")]
    public const int DIAXIS_FPS_MOVE = 0x09010202;

    [NativeTypeName("#define DIBUTTON_FPS_FIRE 0x09000401")]
    public const int DIBUTTON_FPS_FIRE = 0x09000401;

    [NativeTypeName("#define DIBUTTON_FPS_WEAPONS 0x09000402")]
    public const int DIBUTTON_FPS_WEAPONS = 0x09000402;

    [NativeTypeName("#define DIBUTTON_FPS_APPLY 0x09000403")]
    public const int DIBUTTON_FPS_APPLY = 0x09000403;

    [NativeTypeName("#define DIBUTTON_FPS_SELECT 0x09000404")]
    public const int DIBUTTON_FPS_SELECT = 0x09000404;

    [NativeTypeName("#define DIBUTTON_FPS_CROUCH 0x09000405")]
    public const int DIBUTTON_FPS_CROUCH = 0x09000405;

    [NativeTypeName("#define DIBUTTON_FPS_JUMP 0x09000406")]
    public const int DIBUTTON_FPS_JUMP = 0x09000406;

    [NativeTypeName("#define DIAXIS_FPS_LOOKUPDOWN 0x09018203")]
    public const int DIAXIS_FPS_LOOKUPDOWN = 0x09018203;

    [NativeTypeName("#define DIBUTTON_FPS_STRAFE 0x09000407")]
    public const int DIBUTTON_FPS_STRAFE = 0x09000407;

    [NativeTypeName("#define DIBUTTON_FPS_MENU 0x090004FD")]
    public const int DIBUTTON_FPS_MENU = 0x090004FD;

    [NativeTypeName("#define DIHATSWITCH_FPS_GLANCE 0x09004601")]
    public const int DIHATSWITCH_FPS_GLANCE = 0x09004601;

    [NativeTypeName("#define DIBUTTON_FPS_DISPLAY 0x09004408")]
    public const int DIBUTTON_FPS_DISPLAY = 0x09004408;

    [NativeTypeName("#define DIAXIS_FPS_SIDESTEP 0x09024204")]
    public const int DIAXIS_FPS_SIDESTEP = 0x09024204;

    [NativeTypeName("#define DIBUTTON_FPS_DODGE 0x09004409")]
    public const int DIBUTTON_FPS_DODGE = 0x09004409;

    [NativeTypeName("#define DIBUTTON_FPS_GLANCEL 0x0900440A")]
    public const int DIBUTTON_FPS_GLANCEL = 0x0900440A;

    [NativeTypeName("#define DIBUTTON_FPS_GLANCER 0x0900440B")]
    public const int DIBUTTON_FPS_GLANCER = 0x0900440B;

    [NativeTypeName("#define DIBUTTON_FPS_FIRESECONDARY 0x0900440C")]
    public const int DIBUTTON_FPS_FIRESECONDARY = 0x0900440C;

    [NativeTypeName("#define DIBUTTON_FPS_ROTATE_LEFT_LINK 0x0900C4E4")]
    public const int DIBUTTON_FPS_ROTATE_LEFT_LINK = 0x0900C4E4;

    [NativeTypeName("#define DIBUTTON_FPS_ROTATE_RIGHT_LINK 0x0900C4EC")]
    public const int DIBUTTON_FPS_ROTATE_RIGHT_LINK = 0x0900C4EC;

    [NativeTypeName("#define DIBUTTON_FPS_FORWARD_LINK 0x090144E0")]
    public const int DIBUTTON_FPS_FORWARD_LINK = 0x090144E0;

    [NativeTypeName("#define DIBUTTON_FPS_BACKWARD_LINK 0x090144E8")]
    public const int DIBUTTON_FPS_BACKWARD_LINK = 0x090144E8;

    [NativeTypeName("#define DIBUTTON_FPS_GLANCE_UP_LINK 0x0901C4E0")]
    public const int DIBUTTON_FPS_GLANCE_UP_LINK = 0x0901C4E0;

    [NativeTypeName("#define DIBUTTON_FPS_GLANCE_DOWN_LINK 0x0901C4E8")]
    public const int DIBUTTON_FPS_GLANCE_DOWN_LINK = 0x0901C4E8;

    [NativeTypeName("#define DIBUTTON_FPS_STEP_LEFT_LINK 0x090244E4")]
    public const int DIBUTTON_FPS_STEP_LEFT_LINK = 0x090244E4;

    [NativeTypeName("#define DIBUTTON_FPS_STEP_RIGHT_LINK 0x090244EC")]
    public const int DIBUTTON_FPS_STEP_RIGHT_LINK = 0x090244EC;

    [NativeTypeName("#define DIBUTTON_FPS_DEVICE 0x090044FE")]
    public const int DIBUTTON_FPS_DEVICE = 0x090044FE;

    [NativeTypeName("#define DIBUTTON_FPS_PAUSE 0x090044FC")]
    public const int DIBUTTON_FPS_PAUSE = 0x090044FC;

    [NativeTypeName("#define DIVIRTUAL_FIGHTING_THIRDPERSON 0x0A000000")]
    public const int DIVIRTUAL_FIGHTING_THIRDPERSON = 0x0A000000;

    [NativeTypeName("#define DIAXIS_TPS_TURN 0x0A020201")]
    public const int DIAXIS_TPS_TURN = 0x0A020201;

    [NativeTypeName("#define DIAXIS_TPS_MOVE 0x0A010202")]
    public const int DIAXIS_TPS_MOVE = 0x0A010202;

    [NativeTypeName("#define DIBUTTON_TPS_RUN 0x0A000401")]
    public const int DIBUTTON_TPS_RUN = 0x0A000401;

    [NativeTypeName("#define DIBUTTON_TPS_ACTION 0x0A000402")]
    public const int DIBUTTON_TPS_ACTION = 0x0A000402;

    [NativeTypeName("#define DIBUTTON_TPS_SELECT 0x0A000403")]
    public const int DIBUTTON_TPS_SELECT = 0x0A000403;

    [NativeTypeName("#define DIBUTTON_TPS_USE 0x0A000404")]
    public const int DIBUTTON_TPS_USE = 0x0A000404;

    [NativeTypeName("#define DIBUTTON_TPS_JUMP 0x0A000405")]
    public const int DIBUTTON_TPS_JUMP = 0x0A000405;

    [NativeTypeName("#define DIBUTTON_TPS_MENU 0x0A0004FD")]
    public const int DIBUTTON_TPS_MENU = 0x0A0004FD;

    [NativeTypeName("#define DIHATSWITCH_TPS_GLANCE 0x0A004601")]
    public const int DIHATSWITCH_TPS_GLANCE = 0x0A004601;

    [NativeTypeName("#define DIBUTTON_TPS_VIEW 0x0A004406")]
    public const int DIBUTTON_TPS_VIEW = 0x0A004406;

    [NativeTypeName("#define DIBUTTON_TPS_STEPLEFT 0x0A004407")]
    public const int DIBUTTON_TPS_STEPLEFT = 0x0A004407;

    [NativeTypeName("#define DIBUTTON_TPS_STEPRIGHT 0x0A004408")]
    public const int DIBUTTON_TPS_STEPRIGHT = 0x0A004408;

    [NativeTypeName("#define DIAXIS_TPS_STEP 0x0A00C203")]
    public const int DIAXIS_TPS_STEP = 0x0A00C203;

    [NativeTypeName("#define DIBUTTON_TPS_DODGE 0x0A004409")]
    public const int DIBUTTON_TPS_DODGE = 0x0A004409;

    [NativeTypeName("#define DIBUTTON_TPS_INVENTORY 0x0A00440A")]
    public const int DIBUTTON_TPS_INVENTORY = 0x0A00440A;

    [NativeTypeName("#define DIBUTTON_TPS_TURN_LEFT_LINK 0x0A0244E4")]
    public const int DIBUTTON_TPS_TURN_LEFT_LINK = 0x0A0244E4;

    [NativeTypeName("#define DIBUTTON_TPS_TURN_RIGHT_LINK 0x0A0244EC")]
    public const int DIBUTTON_TPS_TURN_RIGHT_LINK = 0x0A0244EC;

    [NativeTypeName("#define DIBUTTON_TPS_FORWARD_LINK 0x0A0144E0")]
    public const int DIBUTTON_TPS_FORWARD_LINK = 0x0A0144E0;

    [NativeTypeName("#define DIBUTTON_TPS_BACKWARD_LINK 0x0A0144E8")]
    public const int DIBUTTON_TPS_BACKWARD_LINK = 0x0A0144E8;

    [NativeTypeName("#define DIBUTTON_TPS_GLANCE_UP_LINK 0x0A07C4E0")]
    public const int DIBUTTON_TPS_GLANCE_UP_LINK = 0x0A07C4E0;

    [NativeTypeName("#define DIBUTTON_TPS_GLANCE_DOWN_LINK 0x0A07C4E8")]
    public const int DIBUTTON_TPS_GLANCE_DOWN_LINK = 0x0A07C4E8;

    [NativeTypeName("#define DIBUTTON_TPS_GLANCE_LEFT_LINK 0x0A07C4E4")]
    public const int DIBUTTON_TPS_GLANCE_LEFT_LINK = 0x0A07C4E4;

    [NativeTypeName("#define DIBUTTON_TPS_GLANCE_RIGHT_LINK 0x0A07C4EC")]
    public const int DIBUTTON_TPS_GLANCE_RIGHT_LINK = 0x0A07C4EC;

    [NativeTypeName("#define DIBUTTON_TPS_DEVICE 0x0A0044FE")]
    public const int DIBUTTON_TPS_DEVICE = 0x0A0044FE;

    [NativeTypeName("#define DIBUTTON_TPS_PAUSE 0x0A0044FC")]
    public const int DIBUTTON_TPS_PAUSE = 0x0A0044FC;

    [NativeTypeName("#define DIVIRTUAL_STRATEGY_ROLEPLAYING 0x0B000000")]
    public const int DIVIRTUAL_STRATEGY_ROLEPLAYING = 0x0B000000;

    [NativeTypeName("#define DIAXIS_STRATEGYR_LATERAL 0x0B008201")]
    public const int DIAXIS_STRATEGYR_LATERAL = 0x0B008201;

    [NativeTypeName("#define DIAXIS_STRATEGYR_MOVE 0x0B010202")]
    public const int DIAXIS_STRATEGYR_MOVE = 0x0B010202;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_GET 0x0B000401")]
    public const int DIBUTTON_STRATEGYR_GET = 0x0B000401;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_APPLY 0x0B000402")]
    public const int DIBUTTON_STRATEGYR_APPLY = 0x0B000402;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_SELECT 0x0B000403")]
    public const int DIBUTTON_STRATEGYR_SELECT = 0x0B000403;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_ATTACK 0x0B000404")]
    public const int DIBUTTON_STRATEGYR_ATTACK = 0x0B000404;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_CAST 0x0B000405")]
    public const int DIBUTTON_STRATEGYR_CAST = 0x0B000405;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_CROUCH 0x0B000406")]
    public const int DIBUTTON_STRATEGYR_CROUCH = 0x0B000406;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_JUMP 0x0B000407")]
    public const int DIBUTTON_STRATEGYR_JUMP = 0x0B000407;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_MENU 0x0B0004FD")]
    public const int DIBUTTON_STRATEGYR_MENU = 0x0B0004FD;

    [NativeTypeName("#define DIHATSWITCH_STRATEGYR_GLANCE 0x0B004601")]
    public const int DIHATSWITCH_STRATEGYR_GLANCE = 0x0B004601;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_MAP 0x0B004408")]
    public const int DIBUTTON_STRATEGYR_MAP = 0x0B004408;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_DISPLAY 0x0B004409")]
    public const int DIBUTTON_STRATEGYR_DISPLAY = 0x0B004409;

    [NativeTypeName("#define DIAXIS_STRATEGYR_ROTATE 0x0B024203")]
    public const int DIAXIS_STRATEGYR_ROTATE = 0x0B024203;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_LEFT_LINK 0x0B00C4E4")]
    public const int DIBUTTON_STRATEGYR_LEFT_LINK = 0x0B00C4E4;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_RIGHT_LINK 0x0B00C4EC")]
    public const int DIBUTTON_STRATEGYR_RIGHT_LINK = 0x0B00C4EC;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_FORWARD_LINK 0x0B0144E0")]
    public const int DIBUTTON_STRATEGYR_FORWARD_LINK = 0x0B0144E0;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_BACK_LINK 0x0B0144E8")]
    public const int DIBUTTON_STRATEGYR_BACK_LINK = 0x0B0144E8;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_ROTATE_LEFT_LINK 0x0B0244E4")]
    public const int DIBUTTON_STRATEGYR_ROTATE_LEFT_LINK = 0x0B0244E4;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_ROTATE_RIGHT_LINK 0x0B0244EC")]
    public const int DIBUTTON_STRATEGYR_ROTATE_RIGHT_LINK = 0x0B0244EC;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_DEVICE 0x0B0044FE")]
    public const int DIBUTTON_STRATEGYR_DEVICE = 0x0B0044FE;

    [NativeTypeName("#define DIBUTTON_STRATEGYR_PAUSE 0x0B0044FC")]
    public const int DIBUTTON_STRATEGYR_PAUSE = 0x0B0044FC;

    [NativeTypeName("#define DIVIRTUAL_STRATEGY_TURN 0x0C000000")]
    public const int DIVIRTUAL_STRATEGY_TURN = 0x0C000000;

    [NativeTypeName("#define DIAXIS_STRATEGYT_LATERAL 0x0C008201")]
    public const int DIAXIS_STRATEGYT_LATERAL = 0x0C008201;

    [NativeTypeName("#define DIAXIS_STRATEGYT_MOVE 0x0C010202")]
    public const int DIAXIS_STRATEGYT_MOVE = 0x0C010202;

    [NativeTypeName("#define DIBUTTON_STRATEGYT_SELECT 0x0C000401")]
    public const int DIBUTTON_STRATEGYT_SELECT = 0x0C000401;

    [NativeTypeName("#define DIBUTTON_STRATEGYT_INSTRUCT 0x0C000402")]
    public const int DIBUTTON_STRATEGYT_INSTRUCT = 0x0C000402;

    [NativeTypeName("#define DIBUTTON_STRATEGYT_APPLY 0x0C000403")]
    public const int DIBUTTON_STRATEGYT_APPLY = 0x0C000403;

    [NativeTypeName("#define DIBUTTON_STRATEGYT_TEAM 0x0C000404")]
    public const int DIBUTTON_STRATEGYT_TEAM = 0x0C000404;

    [NativeTypeName("#define DIBUTTON_STRATEGYT_TURN 0x0C000405")]
    public const int DIBUTTON_STRATEGYT_TURN = 0x0C000405;

    [NativeTypeName("#define DIBUTTON_STRATEGYT_MENU 0x0C0004FD")]
    public const int DIBUTTON_STRATEGYT_MENU = 0x0C0004FD;

    [NativeTypeName("#define DIBUTTON_STRATEGYT_ZOOM 0x0C004406")]
    public const int DIBUTTON_STRATEGYT_ZOOM = 0x0C004406;

    [NativeTypeName("#define DIBUTTON_STRATEGYT_MAP 0x0C004407")]
    public const int DIBUTTON_STRATEGYT_MAP = 0x0C004407;

    [NativeTypeName("#define DIBUTTON_STRATEGYT_DISPLAY 0x0C004408")]
    public const int DIBUTTON_STRATEGYT_DISPLAY = 0x0C004408;

    [NativeTypeName("#define DIBUTTON_STRATEGYT_LEFT_LINK 0x0C00C4E4")]
    public const int DIBUTTON_STRATEGYT_LEFT_LINK = 0x0C00C4E4;

    [NativeTypeName("#define DIBUTTON_STRATEGYT_RIGHT_LINK 0x0C00C4EC")]
    public const int DIBUTTON_STRATEGYT_RIGHT_LINK = 0x0C00C4EC;

    [NativeTypeName("#define DIBUTTON_STRATEGYT_FORWARD_LINK 0x0C0144E0")]
    public const int DIBUTTON_STRATEGYT_FORWARD_LINK = 0x0C0144E0;

    [NativeTypeName("#define DIBUTTON_STRATEGYT_BACK_LINK 0x0C0144E8")]
    public const int DIBUTTON_STRATEGYT_BACK_LINK = 0x0C0144E8;

    [NativeTypeName("#define DIBUTTON_STRATEGYT_DEVICE 0x0C0044FE")]
    public const int DIBUTTON_STRATEGYT_DEVICE = 0x0C0044FE;

    [NativeTypeName("#define DIBUTTON_STRATEGYT_PAUSE 0x0C0044FC")]
    public const int DIBUTTON_STRATEGYT_PAUSE = 0x0C0044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_HUNTING 0x0D000000")]
    public const int DIVIRTUAL_SPORTS_HUNTING = 0x0D000000;

    [NativeTypeName("#define DIAXIS_HUNTING_LATERAL 0x0D008201")]
    public const int DIAXIS_HUNTING_LATERAL = 0x0D008201;

    [NativeTypeName("#define DIAXIS_HUNTING_MOVE 0x0D010202")]
    public const int DIAXIS_HUNTING_MOVE = 0x0D010202;

    [NativeTypeName("#define DIBUTTON_HUNTING_FIRE 0x0D000401")]
    public const int DIBUTTON_HUNTING_FIRE = 0x0D000401;

    [NativeTypeName("#define DIBUTTON_HUNTING_AIM 0x0D000402")]
    public const int DIBUTTON_HUNTING_AIM = 0x0D000402;

    [NativeTypeName("#define DIBUTTON_HUNTING_WEAPON 0x0D000403")]
    public const int DIBUTTON_HUNTING_WEAPON = 0x0D000403;

    [NativeTypeName("#define DIBUTTON_HUNTING_BINOCULAR 0x0D000404")]
    public const int DIBUTTON_HUNTING_BINOCULAR = 0x0D000404;

    [NativeTypeName("#define DIBUTTON_HUNTING_CALL 0x0D000405")]
    public const int DIBUTTON_HUNTING_CALL = 0x0D000405;

    [NativeTypeName("#define DIBUTTON_HUNTING_MAP 0x0D000406")]
    public const int DIBUTTON_HUNTING_MAP = 0x0D000406;

    [NativeTypeName("#define DIBUTTON_HUNTING_SPECIAL 0x0D000407")]
    public const int DIBUTTON_HUNTING_SPECIAL = 0x0D000407;

    [NativeTypeName("#define DIBUTTON_HUNTING_MENU 0x0D0004FD")]
    public const int DIBUTTON_HUNTING_MENU = 0x0D0004FD;

    [NativeTypeName("#define DIHATSWITCH_HUNTING_GLANCE 0x0D004601")]
    public const int DIHATSWITCH_HUNTING_GLANCE = 0x0D004601;

    [NativeTypeName("#define DIBUTTON_HUNTING_DISPLAY 0x0D004408")]
    public const int DIBUTTON_HUNTING_DISPLAY = 0x0D004408;

    [NativeTypeName("#define DIAXIS_HUNTING_ROTATE 0x0D024203")]
    public const int DIAXIS_HUNTING_ROTATE = 0x0D024203;

    [NativeTypeName("#define DIBUTTON_HUNTING_CROUCH 0x0D004409")]
    public const int DIBUTTON_HUNTING_CROUCH = 0x0D004409;

    [NativeTypeName("#define DIBUTTON_HUNTING_JUMP 0x0D00440A")]
    public const int DIBUTTON_HUNTING_JUMP = 0x0D00440A;

    [NativeTypeName("#define DIBUTTON_HUNTING_FIRESECONDARY 0x0D00440B")]
    public const int DIBUTTON_HUNTING_FIRESECONDARY = 0x0D00440B;

    [NativeTypeName("#define DIBUTTON_HUNTING_LEFT_LINK 0x0D00C4E4")]
    public const int DIBUTTON_HUNTING_LEFT_LINK = 0x0D00C4E4;

    [NativeTypeName("#define DIBUTTON_HUNTING_RIGHT_LINK 0x0D00C4EC")]
    public const int DIBUTTON_HUNTING_RIGHT_LINK = 0x0D00C4EC;

    [NativeTypeName("#define DIBUTTON_HUNTING_FORWARD_LINK 0x0D0144E0")]
    public const int DIBUTTON_HUNTING_FORWARD_LINK = 0x0D0144E0;

    [NativeTypeName("#define DIBUTTON_HUNTING_BACK_LINK 0x0D0144E8")]
    public const int DIBUTTON_HUNTING_BACK_LINK = 0x0D0144E8;

    [NativeTypeName("#define DIBUTTON_HUNTING_ROTATE_LEFT_LINK 0x0D0244E4")]
    public const int DIBUTTON_HUNTING_ROTATE_LEFT_LINK = 0x0D0244E4;

    [NativeTypeName("#define DIBUTTON_HUNTING_ROTATE_RIGHT_LINK 0x0D0244EC")]
    public const int DIBUTTON_HUNTING_ROTATE_RIGHT_LINK = 0x0D0244EC;

    [NativeTypeName("#define DIBUTTON_HUNTING_DEVICE 0x0D0044FE")]
    public const int DIBUTTON_HUNTING_DEVICE = 0x0D0044FE;

    [NativeTypeName("#define DIBUTTON_HUNTING_PAUSE 0x0D0044FC")]
    public const int DIBUTTON_HUNTING_PAUSE = 0x0D0044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_FISHING 0x0E000000")]
    public const int DIVIRTUAL_SPORTS_FISHING = 0x0E000000;

    [NativeTypeName("#define DIAXIS_FISHING_LATERAL 0x0E008201")]
    public const int DIAXIS_FISHING_LATERAL = 0x0E008201;

    [NativeTypeName("#define DIAXIS_FISHING_MOVE 0x0E010202")]
    public const int DIAXIS_FISHING_MOVE = 0x0E010202;

    [NativeTypeName("#define DIBUTTON_FISHING_CAST 0x0E000401")]
    public const int DIBUTTON_FISHING_CAST = 0x0E000401;

    [NativeTypeName("#define DIBUTTON_FISHING_TYPE 0x0E000402")]
    public const int DIBUTTON_FISHING_TYPE = 0x0E000402;

    [NativeTypeName("#define DIBUTTON_FISHING_BINOCULAR 0x0E000403")]
    public const int DIBUTTON_FISHING_BINOCULAR = 0x0E000403;

    [NativeTypeName("#define DIBUTTON_FISHING_BAIT 0x0E000404")]
    public const int DIBUTTON_FISHING_BAIT = 0x0E000404;

    [NativeTypeName("#define DIBUTTON_FISHING_MAP 0x0E000405")]
    public const int DIBUTTON_FISHING_MAP = 0x0E000405;

    [NativeTypeName("#define DIBUTTON_FISHING_MENU 0x0E0004FD")]
    public const int DIBUTTON_FISHING_MENU = 0x0E0004FD;

    [NativeTypeName("#define DIHATSWITCH_FISHING_GLANCE 0x0E004601")]
    public const int DIHATSWITCH_FISHING_GLANCE = 0x0E004601;

    [NativeTypeName("#define DIBUTTON_FISHING_DISPLAY 0x0E004406")]
    public const int DIBUTTON_FISHING_DISPLAY = 0x0E004406;

    [NativeTypeName("#define DIAXIS_FISHING_ROTATE 0x0E024203")]
    public const int DIAXIS_FISHING_ROTATE = 0x0E024203;

    [NativeTypeName("#define DIBUTTON_FISHING_CROUCH 0x0E004407")]
    public const int DIBUTTON_FISHING_CROUCH = 0x0E004407;

    [NativeTypeName("#define DIBUTTON_FISHING_JUMP 0x0E004408")]
    public const int DIBUTTON_FISHING_JUMP = 0x0E004408;

    [NativeTypeName("#define DIBUTTON_FISHING_LEFT_LINK 0x0E00C4E4")]
    public const int DIBUTTON_FISHING_LEFT_LINK = 0x0E00C4E4;

    [NativeTypeName("#define DIBUTTON_FISHING_RIGHT_LINK 0x0E00C4EC")]
    public const int DIBUTTON_FISHING_RIGHT_LINK = 0x0E00C4EC;

    [NativeTypeName("#define DIBUTTON_FISHING_FORWARD_LINK 0x0E0144E0")]
    public const int DIBUTTON_FISHING_FORWARD_LINK = 0x0E0144E0;

    [NativeTypeName("#define DIBUTTON_FISHING_BACK_LINK 0x0E0144E8")]
    public const int DIBUTTON_FISHING_BACK_LINK = 0x0E0144E8;

    [NativeTypeName("#define DIBUTTON_FISHING_ROTATE_LEFT_LINK 0x0E0244E4")]
    public const int DIBUTTON_FISHING_ROTATE_LEFT_LINK = 0x0E0244E4;

    [NativeTypeName("#define DIBUTTON_FISHING_ROTATE_RIGHT_LINK 0x0E0244EC")]
    public const int DIBUTTON_FISHING_ROTATE_RIGHT_LINK = 0x0E0244EC;

    [NativeTypeName("#define DIBUTTON_FISHING_DEVICE 0x0E0044FE")]
    public const int DIBUTTON_FISHING_DEVICE = 0x0E0044FE;

    [NativeTypeName("#define DIBUTTON_FISHING_PAUSE 0x0E0044FC")]
    public const int DIBUTTON_FISHING_PAUSE = 0x0E0044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_BASEBALL_BAT 0x0F000000")]
    public const int DIVIRTUAL_SPORTS_BASEBALL_BAT = 0x0F000000;

    [NativeTypeName("#define DIAXIS_BASEBALLB_LATERAL 0x0F008201")]
    public const int DIAXIS_BASEBALLB_LATERAL = 0x0F008201;

    [NativeTypeName("#define DIAXIS_BASEBALLB_MOVE 0x0F010202")]
    public const int DIAXIS_BASEBALLB_MOVE = 0x0F010202;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_SELECT 0x0F000401")]
    public const int DIBUTTON_BASEBALLB_SELECT = 0x0F000401;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_NORMAL 0x0F000402")]
    public const int DIBUTTON_BASEBALLB_NORMAL = 0x0F000402;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_POWER 0x0F000403")]
    public const int DIBUTTON_BASEBALLB_POWER = 0x0F000403;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_BUNT 0x0F000404")]
    public const int DIBUTTON_BASEBALLB_BUNT = 0x0F000404;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_STEAL 0x0F000405")]
    public const int DIBUTTON_BASEBALLB_STEAL = 0x0F000405;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_BURST 0x0F000406")]
    public const int DIBUTTON_BASEBALLB_BURST = 0x0F000406;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_SLIDE 0x0F000407")]
    public const int DIBUTTON_BASEBALLB_SLIDE = 0x0F000407;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_CONTACT 0x0F000408")]
    public const int DIBUTTON_BASEBALLB_CONTACT = 0x0F000408;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_MENU 0x0F0004FD")]
    public const int DIBUTTON_BASEBALLB_MENU = 0x0F0004FD;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_NOSTEAL 0x0F004409")]
    public const int DIBUTTON_BASEBALLB_NOSTEAL = 0x0F004409;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_BOX 0x0F00440A")]
    public const int DIBUTTON_BASEBALLB_BOX = 0x0F00440A;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_LEFT_LINK 0x0F00C4E4")]
    public const int DIBUTTON_BASEBALLB_LEFT_LINK = 0x0F00C4E4;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_RIGHT_LINK 0x0F00C4EC")]
    public const int DIBUTTON_BASEBALLB_RIGHT_LINK = 0x0F00C4EC;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_FORWARD_LINK 0x0F0144E0")]
    public const int DIBUTTON_BASEBALLB_FORWARD_LINK = 0x0F0144E0;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_BACK_LINK 0x0F0144E8")]
    public const int DIBUTTON_BASEBALLB_BACK_LINK = 0x0F0144E8;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_DEVICE 0x0F0044FE")]
    public const int DIBUTTON_BASEBALLB_DEVICE = 0x0F0044FE;

    [NativeTypeName("#define DIBUTTON_BASEBALLB_PAUSE 0x0F0044FC")]
    public const int DIBUTTON_BASEBALLB_PAUSE = 0x0F0044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_BASEBALL_PITCH 0x10000000")]
    public const int DIVIRTUAL_SPORTS_BASEBALL_PITCH = 0x10000000;

    [NativeTypeName("#define DIAXIS_BASEBALLP_LATERAL 0x10008201")]
    public const int DIAXIS_BASEBALLP_LATERAL = 0x10008201;

    [NativeTypeName("#define DIAXIS_BASEBALLP_MOVE 0x10010202")]
    public const int DIAXIS_BASEBALLP_MOVE = 0x10010202;

    [NativeTypeName("#define DIBUTTON_BASEBALLP_SELECT 0x10000401")]
    public const int DIBUTTON_BASEBALLP_SELECT = 0x10000401;

    [NativeTypeName("#define DIBUTTON_BASEBALLP_PITCH 0x10000402")]
    public const int DIBUTTON_BASEBALLP_PITCH = 0x10000402;

    [NativeTypeName("#define DIBUTTON_BASEBALLP_BASE 0x10000403")]
    public const int DIBUTTON_BASEBALLP_BASE = 0x10000403;

    [NativeTypeName("#define DIBUTTON_BASEBALLP_THROW 0x10000404")]
    public const int DIBUTTON_BASEBALLP_THROW = 0x10000404;

    [NativeTypeName("#define DIBUTTON_BASEBALLP_FAKE 0x10000405")]
    public const int DIBUTTON_BASEBALLP_FAKE = 0x10000405;

    [NativeTypeName("#define DIBUTTON_BASEBALLP_MENU 0x100004FD")]
    public const int DIBUTTON_BASEBALLP_MENU = 0x100004FD;

    [NativeTypeName("#define DIBUTTON_BASEBALLP_WALK 0x10004406")]
    public const int DIBUTTON_BASEBALLP_WALK = 0x10004406;

    [NativeTypeName("#define DIBUTTON_BASEBALLP_LOOK 0x10004407")]
    public const int DIBUTTON_BASEBALLP_LOOK = 0x10004407;

    [NativeTypeName("#define DIBUTTON_BASEBALLP_LEFT_LINK 0x1000C4E4")]
    public const int DIBUTTON_BASEBALLP_LEFT_LINK = 0x1000C4E4;

    [NativeTypeName("#define DIBUTTON_BASEBALLP_RIGHT_LINK 0x1000C4EC")]
    public const int DIBUTTON_BASEBALLP_RIGHT_LINK = 0x1000C4EC;

    [NativeTypeName("#define DIBUTTON_BASEBALLP_FORWARD_LINK 0x100144E0")]
    public const int DIBUTTON_BASEBALLP_FORWARD_LINK = 0x100144E0;

    [NativeTypeName("#define DIBUTTON_BASEBALLP_BACK_LINK 0x100144E8")]
    public const int DIBUTTON_BASEBALLP_BACK_LINK = 0x100144E8;

    [NativeTypeName("#define DIBUTTON_BASEBALLP_DEVICE 0x100044FE")]
    public const int DIBUTTON_BASEBALLP_DEVICE = 0x100044FE;

    [NativeTypeName("#define DIBUTTON_BASEBALLP_PAUSE 0x100044FC")]
    public const int DIBUTTON_BASEBALLP_PAUSE = 0x100044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_BASEBALL_FIELD 0x11000000")]
    public const int DIVIRTUAL_SPORTS_BASEBALL_FIELD = 0x11000000;

    [NativeTypeName("#define DIAXIS_BASEBALLF_LATERAL 0x11008201")]
    public const int DIAXIS_BASEBALLF_LATERAL = 0x11008201;

    [NativeTypeName("#define DIAXIS_BASEBALLF_MOVE 0x11010202")]
    public const int DIAXIS_BASEBALLF_MOVE = 0x11010202;

    [NativeTypeName("#define DIBUTTON_BASEBALLF_NEAREST 0x11000401")]
    public const int DIBUTTON_BASEBALLF_NEAREST = 0x11000401;

    [NativeTypeName("#define DIBUTTON_BASEBALLF_THROW1 0x11000402")]
    public const int DIBUTTON_BASEBALLF_THROW1 = 0x11000402;

    [NativeTypeName("#define DIBUTTON_BASEBALLF_THROW2 0x11000403")]
    public const int DIBUTTON_BASEBALLF_THROW2 = 0x11000403;

    [NativeTypeName("#define DIBUTTON_BASEBALLF_BURST 0x11000404")]
    public const int DIBUTTON_BASEBALLF_BURST = 0x11000404;

    [NativeTypeName("#define DIBUTTON_BASEBALLF_JUMP 0x11000405")]
    public const int DIBUTTON_BASEBALLF_JUMP = 0x11000405;

    [NativeTypeName("#define DIBUTTON_BASEBALLF_DIVE 0x11000406")]
    public const int DIBUTTON_BASEBALLF_DIVE = 0x11000406;

    [NativeTypeName("#define DIBUTTON_BASEBALLF_MENU 0x110004FD")]
    public const int DIBUTTON_BASEBALLF_MENU = 0x110004FD;

    [NativeTypeName("#define DIBUTTON_BASEBALLF_SHIFTIN 0x11004407")]
    public const int DIBUTTON_BASEBALLF_SHIFTIN = 0x11004407;

    [NativeTypeName("#define DIBUTTON_BASEBALLF_SHIFTOUT 0x11004408")]
    public const int DIBUTTON_BASEBALLF_SHIFTOUT = 0x11004408;

    [NativeTypeName("#define DIBUTTON_BASEBALLF_AIM_LEFT_LINK 0x1100C4E4")]
    public const int DIBUTTON_BASEBALLF_AIM_LEFT_LINK = 0x1100C4E4;

    [NativeTypeName("#define DIBUTTON_BASEBALLF_AIM_RIGHT_LINK 0x1100C4EC")]
    public const int DIBUTTON_BASEBALLF_AIM_RIGHT_LINK = 0x1100C4EC;

    [NativeTypeName("#define DIBUTTON_BASEBALLF_FORWARD_LINK 0x110144E0")]
    public const int DIBUTTON_BASEBALLF_FORWARD_LINK = 0x110144E0;

    [NativeTypeName("#define DIBUTTON_BASEBALLF_BACK_LINK 0x110144E8")]
    public const int DIBUTTON_BASEBALLF_BACK_LINK = 0x110144E8;

    [NativeTypeName("#define DIBUTTON_BASEBALLF_DEVICE 0x110044FE")]
    public const int DIBUTTON_BASEBALLF_DEVICE = 0x110044FE;

    [NativeTypeName("#define DIBUTTON_BASEBALLF_PAUSE 0x110044FC")]
    public const int DIBUTTON_BASEBALLF_PAUSE = 0x110044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_BASKETBALL_OFFENSE 0x12000000")]
    public const int DIVIRTUAL_SPORTS_BASKETBALL_OFFENSE = 0x12000000;

    [NativeTypeName("#define DIAXIS_BBALLO_LATERAL 0x12008201")]
    public const int DIAXIS_BBALLO_LATERAL = 0x12008201;

    [NativeTypeName("#define DIAXIS_BBALLO_MOVE 0x12010202")]
    public const int DIAXIS_BBALLO_MOVE = 0x12010202;

    [NativeTypeName("#define DIBUTTON_BBALLO_SHOOT 0x12000401")]
    public const int DIBUTTON_BBALLO_SHOOT = 0x12000401;

    [NativeTypeName("#define DIBUTTON_BBALLO_DUNK 0x12000402")]
    public const int DIBUTTON_BBALLO_DUNK = 0x12000402;

    [NativeTypeName("#define DIBUTTON_BBALLO_PASS 0x12000403")]
    public const int DIBUTTON_BBALLO_PASS = 0x12000403;

    [NativeTypeName("#define DIBUTTON_BBALLO_FAKE 0x12000404")]
    public const int DIBUTTON_BBALLO_FAKE = 0x12000404;

    [NativeTypeName("#define DIBUTTON_BBALLO_SPECIAL 0x12000405")]
    public const int DIBUTTON_BBALLO_SPECIAL = 0x12000405;

    [NativeTypeName("#define DIBUTTON_BBALLO_PLAYER 0x12000406")]
    public const int DIBUTTON_BBALLO_PLAYER = 0x12000406;

    [NativeTypeName("#define DIBUTTON_BBALLO_BURST 0x12000407")]
    public const int DIBUTTON_BBALLO_BURST = 0x12000407;

    [NativeTypeName("#define DIBUTTON_BBALLO_CALL 0x12000408")]
    public const int DIBUTTON_BBALLO_CALL = 0x12000408;

    [NativeTypeName("#define DIBUTTON_BBALLO_MENU 0x120004FD")]
    public const int DIBUTTON_BBALLO_MENU = 0x120004FD;

    [NativeTypeName("#define DIHATSWITCH_BBALLO_GLANCE 0x12004601")]
    public const int DIHATSWITCH_BBALLO_GLANCE = 0x12004601;

    [NativeTypeName("#define DIBUTTON_BBALLO_SCREEN 0x12004409")]
    public const int DIBUTTON_BBALLO_SCREEN = 0x12004409;

    [NativeTypeName("#define DIBUTTON_BBALLO_PLAY 0x1200440A")]
    public const int DIBUTTON_BBALLO_PLAY = 0x1200440A;

    [NativeTypeName("#define DIBUTTON_BBALLO_JAB 0x1200440B")]
    public const int DIBUTTON_BBALLO_JAB = 0x1200440B;

    [NativeTypeName("#define DIBUTTON_BBALLO_POST 0x1200440C")]
    public const int DIBUTTON_BBALLO_POST = 0x1200440C;

    [NativeTypeName("#define DIBUTTON_BBALLO_TIMEOUT 0x1200440D")]
    public const int DIBUTTON_BBALLO_TIMEOUT = 0x1200440D;

    [NativeTypeName("#define DIBUTTON_BBALLO_SUBSTITUTE 0x1200440E")]
    public const int DIBUTTON_BBALLO_SUBSTITUTE = 0x1200440E;

    [NativeTypeName("#define DIBUTTON_BBALLO_LEFT_LINK 0x1200C4E4")]
    public const int DIBUTTON_BBALLO_LEFT_LINK = 0x1200C4E4;

    [NativeTypeName("#define DIBUTTON_BBALLO_RIGHT_LINK 0x1200C4EC")]
    public const int DIBUTTON_BBALLO_RIGHT_LINK = 0x1200C4EC;

    [NativeTypeName("#define DIBUTTON_BBALLO_FORWARD_LINK 0x120144E0")]
    public const int DIBUTTON_BBALLO_FORWARD_LINK = 0x120144E0;

    [NativeTypeName("#define DIBUTTON_BBALLO_BACK_LINK 0x120144E8")]
    public const int DIBUTTON_BBALLO_BACK_LINK = 0x120144E8;

    [NativeTypeName("#define DIBUTTON_BBALLO_DEVICE 0x120044FE")]
    public const int DIBUTTON_BBALLO_DEVICE = 0x120044FE;

    [NativeTypeName("#define DIBUTTON_BBALLO_PAUSE 0x120044FC")]
    public const int DIBUTTON_BBALLO_PAUSE = 0x120044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_BASKETBALL_DEFENSE 0x13000000")]
    public const int DIVIRTUAL_SPORTS_BASKETBALL_DEFENSE = 0x13000000;

    [NativeTypeName("#define DIAXIS_BBALLD_LATERAL 0x13008201")]
    public const int DIAXIS_BBALLD_LATERAL = 0x13008201;

    [NativeTypeName("#define DIAXIS_BBALLD_MOVE 0x13010202")]
    public const int DIAXIS_BBALLD_MOVE = 0x13010202;

    [NativeTypeName("#define DIBUTTON_BBALLD_JUMP 0x13000401")]
    public const int DIBUTTON_BBALLD_JUMP = 0x13000401;

    [NativeTypeName("#define DIBUTTON_BBALLD_STEAL 0x13000402")]
    public const int DIBUTTON_BBALLD_STEAL = 0x13000402;

    [NativeTypeName("#define DIBUTTON_BBALLD_FAKE 0x13000403")]
    public const int DIBUTTON_BBALLD_FAKE = 0x13000403;

    [NativeTypeName("#define DIBUTTON_BBALLD_SPECIAL 0x13000404")]
    public const int DIBUTTON_BBALLD_SPECIAL = 0x13000404;

    [NativeTypeName("#define DIBUTTON_BBALLD_PLAYER 0x13000405")]
    public const int DIBUTTON_BBALLD_PLAYER = 0x13000405;

    [NativeTypeName("#define DIBUTTON_BBALLD_BURST 0x13000406")]
    public const int DIBUTTON_BBALLD_BURST = 0x13000406;

    [NativeTypeName("#define DIBUTTON_BBALLD_PLAY 0x13000407")]
    public const int DIBUTTON_BBALLD_PLAY = 0x13000407;

    [NativeTypeName("#define DIBUTTON_BBALLD_MENU 0x130004FD")]
    public const int DIBUTTON_BBALLD_MENU = 0x130004FD;

    [NativeTypeName("#define DIHATSWITCH_BBALLD_GLANCE 0x13004601")]
    public const int DIHATSWITCH_BBALLD_GLANCE = 0x13004601;

    [NativeTypeName("#define DIBUTTON_BBALLD_TIMEOUT 0x13004408")]
    public const int DIBUTTON_BBALLD_TIMEOUT = 0x13004408;

    [NativeTypeName("#define DIBUTTON_BBALLD_SUBSTITUTE 0x13004409")]
    public const int DIBUTTON_BBALLD_SUBSTITUTE = 0x13004409;

    [NativeTypeName("#define DIBUTTON_BBALLD_LEFT_LINK 0x1300C4E4")]
    public const int DIBUTTON_BBALLD_LEFT_LINK = 0x1300C4E4;

    [NativeTypeName("#define DIBUTTON_BBALLD_RIGHT_LINK 0x1300C4EC")]
    public const int DIBUTTON_BBALLD_RIGHT_LINK = 0x1300C4EC;

    [NativeTypeName("#define DIBUTTON_BBALLD_FORWARD_LINK 0x130144E0")]
    public const int DIBUTTON_BBALLD_FORWARD_LINK = 0x130144E0;

    [NativeTypeName("#define DIBUTTON_BBALLD_BACK_LINK 0x130144E8")]
    public const int DIBUTTON_BBALLD_BACK_LINK = 0x130144E8;

    [NativeTypeName("#define DIBUTTON_BBALLD_DEVICE 0x130044FE")]
    public const int DIBUTTON_BBALLD_DEVICE = 0x130044FE;

    [NativeTypeName("#define DIBUTTON_BBALLD_PAUSE 0x130044FC")]
    public const int DIBUTTON_BBALLD_PAUSE = 0x130044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_FOOTBALL_FIELD 0x14000000")]
    public const int DIVIRTUAL_SPORTS_FOOTBALL_FIELD = 0x14000000;

    [NativeTypeName("#define DIBUTTON_FOOTBALLP_PLAY 0x14000401")]
    public const int DIBUTTON_FOOTBALLP_PLAY = 0x14000401;

    [NativeTypeName("#define DIBUTTON_FOOTBALLP_SELECT 0x14000402")]
    public const int DIBUTTON_FOOTBALLP_SELECT = 0x14000402;

    [NativeTypeName("#define DIBUTTON_FOOTBALLP_HELP 0x14000403")]
    public const int DIBUTTON_FOOTBALLP_HELP = 0x14000403;

    [NativeTypeName("#define DIBUTTON_FOOTBALLP_MENU 0x140004FD")]
    public const int DIBUTTON_FOOTBALLP_MENU = 0x140004FD;

    [NativeTypeName("#define DIBUTTON_FOOTBALLP_DEVICE 0x140044FE")]
    public const int DIBUTTON_FOOTBALLP_DEVICE = 0x140044FE;

    [NativeTypeName("#define DIBUTTON_FOOTBALLP_PAUSE 0x140044FC")]
    public const int DIBUTTON_FOOTBALLP_PAUSE = 0x140044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_FOOTBALL_QBCK 0x15000000")]
    public const int DIVIRTUAL_SPORTS_FOOTBALL_QBCK = 0x15000000;

    [NativeTypeName("#define DIAXIS_FOOTBALLQ_LATERAL 0x15008201")]
    public const int DIAXIS_FOOTBALLQ_LATERAL = 0x15008201;

    [NativeTypeName("#define DIAXIS_FOOTBALLQ_MOVE 0x15010202")]
    public const int DIAXIS_FOOTBALLQ_MOVE = 0x15010202;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_SELECT 0x15000401")]
    public const int DIBUTTON_FOOTBALLQ_SELECT = 0x15000401;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_SNAP 0x15000402")]
    public const int DIBUTTON_FOOTBALLQ_SNAP = 0x15000402;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_JUMP 0x15000403")]
    public const int DIBUTTON_FOOTBALLQ_JUMP = 0x15000403;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_SLIDE 0x15000404")]
    public const int DIBUTTON_FOOTBALLQ_SLIDE = 0x15000404;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_PASS 0x15000405")]
    public const int DIBUTTON_FOOTBALLQ_PASS = 0x15000405;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_FAKE 0x15000406")]
    public const int DIBUTTON_FOOTBALLQ_FAKE = 0x15000406;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_MENU 0x150004FD")]
    public const int DIBUTTON_FOOTBALLQ_MENU = 0x150004FD;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_FAKESNAP 0x15004407")]
    public const int DIBUTTON_FOOTBALLQ_FAKESNAP = 0x15004407;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_MOTION 0x15004408")]
    public const int DIBUTTON_FOOTBALLQ_MOTION = 0x15004408;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_AUDIBLE 0x15004409")]
    public const int DIBUTTON_FOOTBALLQ_AUDIBLE = 0x15004409;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_LEFT_LINK 0x1500C4E4")]
    public const int DIBUTTON_FOOTBALLQ_LEFT_LINK = 0x1500C4E4;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_RIGHT_LINK 0x1500C4EC")]
    public const int DIBUTTON_FOOTBALLQ_RIGHT_LINK = 0x1500C4EC;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_FORWARD_LINK 0x150144E0")]
    public const int DIBUTTON_FOOTBALLQ_FORWARD_LINK = 0x150144E0;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_BACK_LINK 0x150144E8")]
    public const int DIBUTTON_FOOTBALLQ_BACK_LINK = 0x150144E8;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_DEVICE 0x150044FE")]
    public const int DIBUTTON_FOOTBALLQ_DEVICE = 0x150044FE;

    [NativeTypeName("#define DIBUTTON_FOOTBALLQ_PAUSE 0x150044FC")]
    public const int DIBUTTON_FOOTBALLQ_PAUSE = 0x150044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_FOOTBALL_OFFENSE 0x16000000")]
    public const int DIVIRTUAL_SPORTS_FOOTBALL_OFFENSE = 0x16000000;

    [NativeTypeName("#define DIAXIS_FOOTBALLO_LATERAL 0x16008201")]
    public const int DIAXIS_FOOTBALLO_LATERAL = 0x16008201;

    [NativeTypeName("#define DIAXIS_FOOTBALLO_MOVE 0x16010202")]
    public const int DIAXIS_FOOTBALLO_MOVE = 0x16010202;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_JUMP 0x16000401")]
    public const int DIBUTTON_FOOTBALLO_JUMP = 0x16000401;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_LEFTARM 0x16000402")]
    public const int DIBUTTON_FOOTBALLO_LEFTARM = 0x16000402;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_RIGHTARM 0x16000403")]
    public const int DIBUTTON_FOOTBALLO_RIGHTARM = 0x16000403;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_THROW 0x16000404")]
    public const int DIBUTTON_FOOTBALLO_THROW = 0x16000404;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_SPIN 0x16000405")]
    public const int DIBUTTON_FOOTBALLO_SPIN = 0x16000405;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_MENU 0x160004FD")]
    public const int DIBUTTON_FOOTBALLO_MENU = 0x160004FD;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_JUKE 0x16004406")]
    public const int DIBUTTON_FOOTBALLO_JUKE = 0x16004406;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_SHOULDER 0x16004407")]
    public const int DIBUTTON_FOOTBALLO_SHOULDER = 0x16004407;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_TURBO 0x16004408")]
    public const int DIBUTTON_FOOTBALLO_TURBO = 0x16004408;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_DIVE 0x16004409")]
    public const int DIBUTTON_FOOTBALLO_DIVE = 0x16004409;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_ZOOM 0x1600440A")]
    public const int DIBUTTON_FOOTBALLO_ZOOM = 0x1600440A;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_SUBSTITUTE 0x1600440B")]
    public const int DIBUTTON_FOOTBALLO_SUBSTITUTE = 0x1600440B;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_LEFT_LINK 0x1600C4E4")]
    public const int DIBUTTON_FOOTBALLO_LEFT_LINK = 0x1600C4E4;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_RIGHT_LINK 0x1600C4EC")]
    public const int DIBUTTON_FOOTBALLO_RIGHT_LINK = 0x1600C4EC;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_FORWARD_LINK 0x160144E0")]
    public const int DIBUTTON_FOOTBALLO_FORWARD_LINK = 0x160144E0;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_BACK_LINK 0x160144E8")]
    public const int DIBUTTON_FOOTBALLO_BACK_LINK = 0x160144E8;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_DEVICE 0x160044FE")]
    public const int DIBUTTON_FOOTBALLO_DEVICE = 0x160044FE;

    [NativeTypeName("#define DIBUTTON_FOOTBALLO_PAUSE 0x160044FC")]
    public const int DIBUTTON_FOOTBALLO_PAUSE = 0x160044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_FOOTBALL_DEFENSE 0x17000000")]
    public const int DIVIRTUAL_SPORTS_FOOTBALL_DEFENSE = 0x17000000;

    [NativeTypeName("#define DIAXIS_FOOTBALLD_LATERAL 0x17008201")]
    public const int DIAXIS_FOOTBALLD_LATERAL = 0x17008201;

    [NativeTypeName("#define DIAXIS_FOOTBALLD_MOVE 0x17010202")]
    public const int DIAXIS_FOOTBALLD_MOVE = 0x17010202;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_PLAY 0x17000401")]
    public const int DIBUTTON_FOOTBALLD_PLAY = 0x17000401;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_SELECT 0x17000402")]
    public const int DIBUTTON_FOOTBALLD_SELECT = 0x17000402;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_JUMP 0x17000403")]
    public const int DIBUTTON_FOOTBALLD_JUMP = 0x17000403;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_TACKLE 0x17000404")]
    public const int DIBUTTON_FOOTBALLD_TACKLE = 0x17000404;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_FAKE 0x17000405")]
    public const int DIBUTTON_FOOTBALLD_FAKE = 0x17000405;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_SUPERTACKLE 0x17000406")]
    public const int DIBUTTON_FOOTBALLD_SUPERTACKLE = 0x17000406;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_MENU 0x170004FD")]
    public const int DIBUTTON_FOOTBALLD_MENU = 0x170004FD;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_SPIN 0x17004407")]
    public const int DIBUTTON_FOOTBALLD_SPIN = 0x17004407;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_SWIM 0x17004408")]
    public const int DIBUTTON_FOOTBALLD_SWIM = 0x17004408;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_BULLRUSH 0x17004409")]
    public const int DIBUTTON_FOOTBALLD_BULLRUSH = 0x17004409;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_RIP 0x1700440A")]
    public const int DIBUTTON_FOOTBALLD_RIP = 0x1700440A;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_AUDIBLE 0x1700440B")]
    public const int DIBUTTON_FOOTBALLD_AUDIBLE = 0x1700440B;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_ZOOM 0x1700440C")]
    public const int DIBUTTON_FOOTBALLD_ZOOM = 0x1700440C;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_SUBSTITUTE 0x1700440D")]
    public const int DIBUTTON_FOOTBALLD_SUBSTITUTE = 0x1700440D;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_LEFT_LINK 0x1700C4E4")]
    public const int DIBUTTON_FOOTBALLD_LEFT_LINK = 0x1700C4E4;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_RIGHT_LINK 0x1700C4EC")]
    public const int DIBUTTON_FOOTBALLD_RIGHT_LINK = 0x1700C4EC;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_FORWARD_LINK 0x170144E0")]
    public const int DIBUTTON_FOOTBALLD_FORWARD_LINK = 0x170144E0;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_BACK_LINK 0x170144E8")]
    public const int DIBUTTON_FOOTBALLD_BACK_LINK = 0x170144E8;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_DEVICE 0x170044FE")]
    public const int DIBUTTON_FOOTBALLD_DEVICE = 0x170044FE;

    [NativeTypeName("#define DIBUTTON_FOOTBALLD_PAUSE 0x170044FC")]
    public const int DIBUTTON_FOOTBALLD_PAUSE = 0x170044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_GOLF 0x18000000")]
    public const int DIVIRTUAL_SPORTS_GOLF = 0x18000000;

    [NativeTypeName("#define DIAXIS_GOLF_LATERAL 0x18008201")]
    public const int DIAXIS_GOLF_LATERAL = 0x18008201;

    [NativeTypeName("#define DIAXIS_GOLF_MOVE 0x18010202")]
    public const int DIAXIS_GOLF_MOVE = 0x18010202;

    [NativeTypeName("#define DIBUTTON_GOLF_SWING 0x18000401")]
    public const int DIBUTTON_GOLF_SWING = 0x18000401;

    [NativeTypeName("#define DIBUTTON_GOLF_SELECT 0x18000402")]
    public const int DIBUTTON_GOLF_SELECT = 0x18000402;

    [NativeTypeName("#define DIBUTTON_GOLF_UP 0x18000403")]
    public const int DIBUTTON_GOLF_UP = 0x18000403;

    [NativeTypeName("#define DIBUTTON_GOLF_DOWN 0x18000404")]
    public const int DIBUTTON_GOLF_DOWN = 0x18000404;

    [NativeTypeName("#define DIBUTTON_GOLF_TERRAIN 0x18000405")]
    public const int DIBUTTON_GOLF_TERRAIN = 0x18000405;

    [NativeTypeName("#define DIBUTTON_GOLF_FLYBY 0x18000406")]
    public const int DIBUTTON_GOLF_FLYBY = 0x18000406;

    [NativeTypeName("#define DIBUTTON_GOLF_MENU 0x180004FD")]
    public const int DIBUTTON_GOLF_MENU = 0x180004FD;

    [NativeTypeName("#define DIHATSWITCH_GOLF_SCROLL 0x18004601")]
    public const int DIHATSWITCH_GOLF_SCROLL = 0x18004601;

    [NativeTypeName("#define DIBUTTON_GOLF_ZOOM 0x18004407")]
    public const int DIBUTTON_GOLF_ZOOM = 0x18004407;

    [NativeTypeName("#define DIBUTTON_GOLF_TIMEOUT 0x18004408")]
    public const int DIBUTTON_GOLF_TIMEOUT = 0x18004408;

    [NativeTypeName("#define DIBUTTON_GOLF_SUBSTITUTE 0x18004409")]
    public const int DIBUTTON_GOLF_SUBSTITUTE = 0x18004409;

    [NativeTypeName("#define DIBUTTON_GOLF_LEFT_LINK 0x1800C4E4")]
    public const int DIBUTTON_GOLF_LEFT_LINK = 0x1800C4E4;

    [NativeTypeName("#define DIBUTTON_GOLF_RIGHT_LINK 0x1800C4EC")]
    public const int DIBUTTON_GOLF_RIGHT_LINK = 0x1800C4EC;

    [NativeTypeName("#define DIBUTTON_GOLF_FORWARD_LINK 0x180144E0")]
    public const int DIBUTTON_GOLF_FORWARD_LINK = 0x180144E0;

    [NativeTypeName("#define DIBUTTON_GOLF_BACK_LINK 0x180144E8")]
    public const int DIBUTTON_GOLF_BACK_LINK = 0x180144E8;

    [NativeTypeName("#define DIBUTTON_GOLF_DEVICE 0x180044FE")]
    public const int DIBUTTON_GOLF_DEVICE = 0x180044FE;

    [NativeTypeName("#define DIBUTTON_GOLF_PAUSE 0x180044FC")]
    public const int DIBUTTON_GOLF_PAUSE = 0x180044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_HOCKEY_OFFENSE 0x19000000")]
    public const int DIVIRTUAL_SPORTS_HOCKEY_OFFENSE = 0x19000000;

    [NativeTypeName("#define DIAXIS_HOCKEYO_LATERAL 0x19008201")]
    public const int DIAXIS_HOCKEYO_LATERAL = 0x19008201;

    [NativeTypeName("#define DIAXIS_HOCKEYO_MOVE 0x19010202")]
    public const int DIAXIS_HOCKEYO_MOVE = 0x19010202;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_SHOOT 0x19000401")]
    public const int DIBUTTON_HOCKEYO_SHOOT = 0x19000401;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_PASS 0x19000402")]
    public const int DIBUTTON_HOCKEYO_PASS = 0x19000402;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_BURST 0x19000403")]
    public const int DIBUTTON_HOCKEYO_BURST = 0x19000403;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_SPECIAL 0x19000404")]
    public const int DIBUTTON_HOCKEYO_SPECIAL = 0x19000404;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_FAKE 0x19000405")]
    public const int DIBUTTON_HOCKEYO_FAKE = 0x19000405;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_MENU 0x190004FD")]
    public const int DIBUTTON_HOCKEYO_MENU = 0x190004FD;

    [NativeTypeName("#define DIHATSWITCH_HOCKEYO_SCROLL 0x19004601")]
    public const int DIHATSWITCH_HOCKEYO_SCROLL = 0x19004601;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_ZOOM 0x19004406")]
    public const int DIBUTTON_HOCKEYO_ZOOM = 0x19004406;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_STRATEGY 0x19004407")]
    public const int DIBUTTON_HOCKEYO_STRATEGY = 0x19004407;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_TIMEOUT 0x19004408")]
    public const int DIBUTTON_HOCKEYO_TIMEOUT = 0x19004408;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_SUBSTITUTE 0x19004409")]
    public const int DIBUTTON_HOCKEYO_SUBSTITUTE = 0x19004409;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_LEFT_LINK 0x1900C4E4")]
    public const int DIBUTTON_HOCKEYO_LEFT_LINK = 0x1900C4E4;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_RIGHT_LINK 0x1900C4EC")]
    public const int DIBUTTON_HOCKEYO_RIGHT_LINK = 0x1900C4EC;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_FORWARD_LINK 0x190144E0")]
    public const int DIBUTTON_HOCKEYO_FORWARD_LINK = 0x190144E0;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_BACK_LINK 0x190144E8")]
    public const int DIBUTTON_HOCKEYO_BACK_LINK = 0x190144E8;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_DEVICE 0x190044FE")]
    public const int DIBUTTON_HOCKEYO_DEVICE = 0x190044FE;

    [NativeTypeName("#define DIBUTTON_HOCKEYO_PAUSE 0x190044FC")]
    public const int DIBUTTON_HOCKEYO_PAUSE = 0x190044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_HOCKEY_DEFENSE 0x1A000000")]
    public const int DIVIRTUAL_SPORTS_HOCKEY_DEFENSE = 0x1A000000;

    [NativeTypeName("#define DIAXIS_HOCKEYD_LATERAL 0x1A008201")]
    public const int DIAXIS_HOCKEYD_LATERAL = 0x1A008201;

    [NativeTypeName("#define DIAXIS_HOCKEYD_MOVE 0x1A010202")]
    public const int DIAXIS_HOCKEYD_MOVE = 0x1A010202;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_PLAYER 0x1A000401")]
    public const int DIBUTTON_HOCKEYD_PLAYER = 0x1A000401;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_STEAL 0x1A000402")]
    public const int DIBUTTON_HOCKEYD_STEAL = 0x1A000402;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_BURST 0x1A000403")]
    public const int DIBUTTON_HOCKEYD_BURST = 0x1A000403;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_BLOCK 0x1A000404")]
    public const int DIBUTTON_HOCKEYD_BLOCK = 0x1A000404;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_FAKE 0x1A000405")]
    public const int DIBUTTON_HOCKEYD_FAKE = 0x1A000405;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_MENU 0x1A0004FD")]
    public const int DIBUTTON_HOCKEYD_MENU = 0x1A0004FD;

    [NativeTypeName("#define DIHATSWITCH_HOCKEYD_SCROLL 0x1A004601")]
    public const int DIHATSWITCH_HOCKEYD_SCROLL = 0x1A004601;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_ZOOM 0x1A004406")]
    public const int DIBUTTON_HOCKEYD_ZOOM = 0x1A004406;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_STRATEGY 0x1A004407")]
    public const int DIBUTTON_HOCKEYD_STRATEGY = 0x1A004407;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_TIMEOUT 0x1A004408")]
    public const int DIBUTTON_HOCKEYD_TIMEOUT = 0x1A004408;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_SUBSTITUTE 0x1A004409")]
    public const int DIBUTTON_HOCKEYD_SUBSTITUTE = 0x1A004409;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_LEFT_LINK 0x1A00C4E4")]
    public const int DIBUTTON_HOCKEYD_LEFT_LINK = 0x1A00C4E4;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_RIGHT_LINK 0x1A00C4EC")]
    public const int DIBUTTON_HOCKEYD_RIGHT_LINK = 0x1A00C4EC;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_FORWARD_LINK 0x1A0144E0")]
    public const int DIBUTTON_HOCKEYD_FORWARD_LINK = 0x1A0144E0;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_BACK_LINK 0x1A0144E8")]
    public const int DIBUTTON_HOCKEYD_BACK_LINK = 0x1A0144E8;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_DEVICE 0x1A0044FE")]
    public const int DIBUTTON_HOCKEYD_DEVICE = 0x1A0044FE;

    [NativeTypeName("#define DIBUTTON_HOCKEYD_PAUSE 0x1A0044FC")]
    public const int DIBUTTON_HOCKEYD_PAUSE = 0x1A0044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_HOCKEY_GOALIE 0x1B000000")]
    public const int DIVIRTUAL_SPORTS_HOCKEY_GOALIE = 0x1B000000;

    [NativeTypeName("#define DIAXIS_HOCKEYG_LATERAL 0x1B008201")]
    public const int DIAXIS_HOCKEYG_LATERAL = 0x1B008201;

    [NativeTypeName("#define DIAXIS_HOCKEYG_MOVE 0x1B010202")]
    public const int DIAXIS_HOCKEYG_MOVE = 0x1B010202;

    [NativeTypeName("#define DIBUTTON_HOCKEYG_PASS 0x1B000401")]
    public const int DIBUTTON_HOCKEYG_PASS = 0x1B000401;

    [NativeTypeName("#define DIBUTTON_HOCKEYG_POKE 0x1B000402")]
    public const int DIBUTTON_HOCKEYG_POKE = 0x1B000402;

    [NativeTypeName("#define DIBUTTON_HOCKEYG_STEAL 0x1B000403")]
    public const int DIBUTTON_HOCKEYG_STEAL = 0x1B000403;

    [NativeTypeName("#define DIBUTTON_HOCKEYG_BLOCK 0x1B000404")]
    public const int DIBUTTON_HOCKEYG_BLOCK = 0x1B000404;

    [NativeTypeName("#define DIBUTTON_HOCKEYG_MENU 0x1B0004FD")]
    public const int DIBUTTON_HOCKEYG_MENU = 0x1B0004FD;

    [NativeTypeName("#define DIHATSWITCH_HOCKEYG_SCROLL 0x1B004601")]
    public const int DIHATSWITCH_HOCKEYG_SCROLL = 0x1B004601;

    [NativeTypeName("#define DIBUTTON_HOCKEYG_ZOOM 0x1B004405")]
    public const int DIBUTTON_HOCKEYG_ZOOM = 0x1B004405;

    [NativeTypeName("#define DIBUTTON_HOCKEYG_STRATEGY 0x1B004406")]
    public const int DIBUTTON_HOCKEYG_STRATEGY = 0x1B004406;

    [NativeTypeName("#define DIBUTTON_HOCKEYG_TIMEOUT 0x1B004407")]
    public const int DIBUTTON_HOCKEYG_TIMEOUT = 0x1B004407;

    [NativeTypeName("#define DIBUTTON_HOCKEYG_SUBSTITUTE 0x1B004408")]
    public const int DIBUTTON_HOCKEYG_SUBSTITUTE = 0x1B004408;

    [NativeTypeName("#define DIBUTTON_HOCKEYG_LEFT_LINK 0x1B00C4E4")]
    public const int DIBUTTON_HOCKEYG_LEFT_LINK = 0x1B00C4E4;

    [NativeTypeName("#define DIBUTTON_HOCKEYG_RIGHT_LINK 0x1B00C4EC")]
    public const int DIBUTTON_HOCKEYG_RIGHT_LINK = 0x1B00C4EC;

    [NativeTypeName("#define DIBUTTON_HOCKEYG_FORWARD_LINK 0x1B0144E0")]
    public const int DIBUTTON_HOCKEYG_FORWARD_LINK = 0x1B0144E0;

    [NativeTypeName("#define DIBUTTON_HOCKEYG_BACK_LINK 0x1B0144E8")]
    public const int DIBUTTON_HOCKEYG_BACK_LINK = 0x1B0144E8;

    [NativeTypeName("#define DIBUTTON_HOCKEYG_DEVICE 0x1B0044FE")]
    public const int DIBUTTON_HOCKEYG_DEVICE = 0x1B0044FE;

    [NativeTypeName("#define DIBUTTON_HOCKEYG_PAUSE 0x1B0044FC")]
    public const int DIBUTTON_HOCKEYG_PAUSE = 0x1B0044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_BIKING_MOUNTAIN 0x1C000000")]
    public const int DIVIRTUAL_SPORTS_BIKING_MOUNTAIN = 0x1C000000;

    [NativeTypeName("#define DIAXIS_BIKINGM_TURN 0x1C008201")]
    public const int DIAXIS_BIKINGM_TURN = 0x1C008201;

    [NativeTypeName("#define DIAXIS_BIKINGM_PEDAL 0x1C010202")]
    public const int DIAXIS_BIKINGM_PEDAL = 0x1C010202;

    [NativeTypeName("#define DIBUTTON_BIKINGM_JUMP 0x1C000401")]
    public const int DIBUTTON_BIKINGM_JUMP = 0x1C000401;

    [NativeTypeName("#define DIBUTTON_BIKINGM_CAMERA 0x1C000402")]
    public const int DIBUTTON_BIKINGM_CAMERA = 0x1C000402;

    [NativeTypeName("#define DIBUTTON_BIKINGM_SPECIAL1 0x1C000403")]
    public const int DIBUTTON_BIKINGM_SPECIAL1 = 0x1C000403;

    [NativeTypeName("#define DIBUTTON_BIKINGM_SELECT 0x1C000404")]
    public const int DIBUTTON_BIKINGM_SELECT = 0x1C000404;

    [NativeTypeName("#define DIBUTTON_BIKINGM_SPECIAL2 0x1C000405")]
    public const int DIBUTTON_BIKINGM_SPECIAL2 = 0x1C000405;

    [NativeTypeName("#define DIBUTTON_BIKINGM_MENU 0x1C0004FD")]
    public const int DIBUTTON_BIKINGM_MENU = 0x1C0004FD;

    [NativeTypeName("#define DIHATSWITCH_BIKINGM_SCROLL 0x1C004601")]
    public const int DIHATSWITCH_BIKINGM_SCROLL = 0x1C004601;

    [NativeTypeName("#define DIBUTTON_BIKINGM_ZOOM 0x1C004406")]
    public const int DIBUTTON_BIKINGM_ZOOM = 0x1C004406;

    [NativeTypeName("#define DIAXIS_BIKINGM_BRAKE 0x1C044203")]
    public const int DIAXIS_BIKINGM_BRAKE = 0x1C044203;

    [NativeTypeName("#define DIBUTTON_BIKINGM_LEFT_LINK 0x1C00C4E4")]
    public const int DIBUTTON_BIKINGM_LEFT_LINK = 0x1C00C4E4;

    [NativeTypeName("#define DIBUTTON_BIKINGM_RIGHT_LINK 0x1C00C4EC")]
    public const int DIBUTTON_BIKINGM_RIGHT_LINK = 0x1C00C4EC;

    [NativeTypeName("#define DIBUTTON_BIKINGM_FASTER_LINK 0x1C0144E0")]
    public const int DIBUTTON_BIKINGM_FASTER_LINK = 0x1C0144E0;

    [NativeTypeName("#define DIBUTTON_BIKINGM_SLOWER_LINK 0x1C0144E8")]
    public const int DIBUTTON_BIKINGM_SLOWER_LINK = 0x1C0144E8;

    [NativeTypeName("#define DIBUTTON_BIKINGM_BRAKE_BUTTON_LINK 0x1C0444E8")]
    public const int DIBUTTON_BIKINGM_BRAKE_BUTTON_LINK = 0x1C0444E8;

    [NativeTypeName("#define DIBUTTON_BIKINGM_DEVICE 0x1C0044FE")]
    public const int DIBUTTON_BIKINGM_DEVICE = 0x1C0044FE;

    [NativeTypeName("#define DIBUTTON_BIKINGM_PAUSE 0x1C0044FC")]
    public const int DIBUTTON_BIKINGM_PAUSE = 0x1C0044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_SKIING 0x1D000000")]
    public const int DIVIRTUAL_SPORTS_SKIING = 0x1D000000;

    [NativeTypeName("#define DIAXIS_SKIING_TURN 0x1D008201")]
    public const int DIAXIS_SKIING_TURN = 0x1D008201;

    [NativeTypeName("#define DIAXIS_SKIING_SPEED 0x1D010202")]
    public const int DIAXIS_SKIING_SPEED = 0x1D010202;

    [NativeTypeName("#define DIBUTTON_SKIING_JUMP 0x1D000401")]
    public const int DIBUTTON_SKIING_JUMP = 0x1D000401;

    [NativeTypeName("#define DIBUTTON_SKIING_CROUCH 0x1D000402")]
    public const int DIBUTTON_SKIING_CROUCH = 0x1D000402;

    [NativeTypeName("#define DIBUTTON_SKIING_CAMERA 0x1D000403")]
    public const int DIBUTTON_SKIING_CAMERA = 0x1D000403;

    [NativeTypeName("#define DIBUTTON_SKIING_SPECIAL1 0x1D000404")]
    public const int DIBUTTON_SKIING_SPECIAL1 = 0x1D000404;

    [NativeTypeName("#define DIBUTTON_SKIING_SELECT 0x1D000405")]
    public const int DIBUTTON_SKIING_SELECT = 0x1D000405;

    [NativeTypeName("#define DIBUTTON_SKIING_SPECIAL2 0x1D000406")]
    public const int DIBUTTON_SKIING_SPECIAL2 = 0x1D000406;

    [NativeTypeName("#define DIBUTTON_SKIING_MENU 0x1D0004FD")]
    public const int DIBUTTON_SKIING_MENU = 0x1D0004FD;

    [NativeTypeName("#define DIHATSWITCH_SKIING_GLANCE 0x1D004601")]
    public const int DIHATSWITCH_SKIING_GLANCE = 0x1D004601;

    [NativeTypeName("#define DIBUTTON_SKIING_ZOOM 0x1D004407")]
    public const int DIBUTTON_SKIING_ZOOM = 0x1D004407;

    [NativeTypeName("#define DIBUTTON_SKIING_LEFT_LINK 0x1D00C4E4")]
    public const int DIBUTTON_SKIING_LEFT_LINK = 0x1D00C4E4;

    [NativeTypeName("#define DIBUTTON_SKIING_RIGHT_LINK 0x1D00C4EC")]
    public const int DIBUTTON_SKIING_RIGHT_LINK = 0x1D00C4EC;

    [NativeTypeName("#define DIBUTTON_SKIING_FASTER_LINK 0x1D0144E0")]
    public const int DIBUTTON_SKIING_FASTER_LINK = 0x1D0144E0;

    [NativeTypeName("#define DIBUTTON_SKIING_SLOWER_LINK 0x1D0144E8")]
    public const int DIBUTTON_SKIING_SLOWER_LINK = 0x1D0144E8;

    [NativeTypeName("#define DIBUTTON_SKIING_DEVICE 0x1D0044FE")]
    public const int DIBUTTON_SKIING_DEVICE = 0x1D0044FE;

    [NativeTypeName("#define DIBUTTON_SKIING_PAUSE 0x1D0044FC")]
    public const int DIBUTTON_SKIING_PAUSE = 0x1D0044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_SOCCER_OFFENSE 0x1E000000")]
    public const int DIVIRTUAL_SPORTS_SOCCER_OFFENSE = 0x1E000000;

    [NativeTypeName("#define DIAXIS_SOCCERO_LATERAL 0x1E008201")]
    public const int DIAXIS_SOCCERO_LATERAL = 0x1E008201;

    [NativeTypeName("#define DIAXIS_SOCCERO_MOVE 0x1E010202")]
    public const int DIAXIS_SOCCERO_MOVE = 0x1E010202;

    [NativeTypeName("#define DIAXIS_SOCCERO_BEND 0x1E018203")]
    public const int DIAXIS_SOCCERO_BEND = 0x1E018203;

    [NativeTypeName("#define DIBUTTON_SOCCERO_SHOOT 0x1E000401")]
    public const int DIBUTTON_SOCCERO_SHOOT = 0x1E000401;

    [NativeTypeName("#define DIBUTTON_SOCCERO_PASS 0x1E000402")]
    public const int DIBUTTON_SOCCERO_PASS = 0x1E000402;

    [NativeTypeName("#define DIBUTTON_SOCCERO_FAKE 0x1E000403")]
    public const int DIBUTTON_SOCCERO_FAKE = 0x1E000403;

    [NativeTypeName("#define DIBUTTON_SOCCERO_PLAYER 0x1E000404")]
    public const int DIBUTTON_SOCCERO_PLAYER = 0x1E000404;

    [NativeTypeName("#define DIBUTTON_SOCCERO_SPECIAL1 0x1E000405")]
    public const int DIBUTTON_SOCCERO_SPECIAL1 = 0x1E000405;

    [NativeTypeName("#define DIBUTTON_SOCCERO_SELECT 0x1E000406")]
    public const int DIBUTTON_SOCCERO_SELECT = 0x1E000406;

    [NativeTypeName("#define DIBUTTON_SOCCERO_MENU 0x1E0004FD")]
    public const int DIBUTTON_SOCCERO_MENU = 0x1E0004FD;

    [NativeTypeName("#define DIHATSWITCH_SOCCERO_GLANCE 0x1E004601")]
    public const int DIHATSWITCH_SOCCERO_GLANCE = 0x1E004601;

    [NativeTypeName("#define DIBUTTON_SOCCERO_SUBSTITUTE 0x1E004407")]
    public const int DIBUTTON_SOCCERO_SUBSTITUTE = 0x1E004407;

    [NativeTypeName("#define DIBUTTON_SOCCERO_SHOOTLOW 0x1E004408")]
    public const int DIBUTTON_SOCCERO_SHOOTLOW = 0x1E004408;

    [NativeTypeName("#define DIBUTTON_SOCCERO_SHOOTHIGH 0x1E004409")]
    public const int DIBUTTON_SOCCERO_SHOOTHIGH = 0x1E004409;

    [NativeTypeName("#define DIBUTTON_SOCCERO_PASSTHRU 0x1E00440A")]
    public const int DIBUTTON_SOCCERO_PASSTHRU = 0x1E00440A;

    [NativeTypeName("#define DIBUTTON_SOCCERO_SPRINT 0x1E00440B")]
    public const int DIBUTTON_SOCCERO_SPRINT = 0x1E00440B;

    [NativeTypeName("#define DIBUTTON_SOCCERO_CONTROL 0x1E00440C")]
    public const int DIBUTTON_SOCCERO_CONTROL = 0x1E00440C;

    [NativeTypeName("#define DIBUTTON_SOCCERO_HEAD 0x1E00440D")]
    public const int DIBUTTON_SOCCERO_HEAD = 0x1E00440D;

    [NativeTypeName("#define DIBUTTON_SOCCERO_LEFT_LINK 0x1E00C4E4")]
    public const int DIBUTTON_SOCCERO_LEFT_LINK = 0x1E00C4E4;

    [NativeTypeName("#define DIBUTTON_SOCCERO_RIGHT_LINK 0x1E00C4EC")]
    public const int DIBUTTON_SOCCERO_RIGHT_LINK = 0x1E00C4EC;

    [NativeTypeName("#define DIBUTTON_SOCCERO_FORWARD_LINK 0x1E0144E0")]
    public const int DIBUTTON_SOCCERO_FORWARD_LINK = 0x1E0144E0;

    [NativeTypeName("#define DIBUTTON_SOCCERO_BACK_LINK 0x1E0144E8")]
    public const int DIBUTTON_SOCCERO_BACK_LINK = 0x1E0144E8;

    [NativeTypeName("#define DIBUTTON_SOCCERO_DEVICE 0x1E0044FE")]
    public const int DIBUTTON_SOCCERO_DEVICE = 0x1E0044FE;

    [NativeTypeName("#define DIBUTTON_SOCCERO_PAUSE 0x1E0044FC")]
    public const int DIBUTTON_SOCCERO_PAUSE = 0x1E0044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_SOCCER_DEFENSE 0x1F000000")]
    public const int DIVIRTUAL_SPORTS_SOCCER_DEFENSE = 0x1F000000;

    [NativeTypeName("#define DIAXIS_SOCCERD_LATERAL 0x1F008201")]
    public const int DIAXIS_SOCCERD_LATERAL = 0x1F008201;

    [NativeTypeName("#define DIAXIS_SOCCERD_MOVE 0x1F010202")]
    public const int DIAXIS_SOCCERD_MOVE = 0x1F010202;

    [NativeTypeName("#define DIBUTTON_SOCCERD_BLOCK 0x1F000401")]
    public const int DIBUTTON_SOCCERD_BLOCK = 0x1F000401;

    [NativeTypeName("#define DIBUTTON_SOCCERD_STEAL 0x1F000402")]
    public const int DIBUTTON_SOCCERD_STEAL = 0x1F000402;

    [NativeTypeName("#define DIBUTTON_SOCCERD_FAKE 0x1F000403")]
    public const int DIBUTTON_SOCCERD_FAKE = 0x1F000403;

    [NativeTypeName("#define DIBUTTON_SOCCERD_PLAYER 0x1F000404")]
    public const int DIBUTTON_SOCCERD_PLAYER = 0x1F000404;

    [NativeTypeName("#define DIBUTTON_SOCCERD_SPECIAL 0x1F000405")]
    public const int DIBUTTON_SOCCERD_SPECIAL = 0x1F000405;

    [NativeTypeName("#define DIBUTTON_SOCCERD_SELECT 0x1F000406")]
    public const int DIBUTTON_SOCCERD_SELECT = 0x1F000406;

    [NativeTypeName("#define DIBUTTON_SOCCERD_SLIDE 0x1F000407")]
    public const int DIBUTTON_SOCCERD_SLIDE = 0x1F000407;

    [NativeTypeName("#define DIBUTTON_SOCCERD_MENU 0x1F0004FD")]
    public const int DIBUTTON_SOCCERD_MENU = 0x1F0004FD;

    [NativeTypeName("#define DIHATSWITCH_SOCCERD_GLANCE 0x1F004601")]
    public const int DIHATSWITCH_SOCCERD_GLANCE = 0x1F004601;

    [NativeTypeName("#define DIBUTTON_SOCCERD_FOUL 0x1F004408")]
    public const int DIBUTTON_SOCCERD_FOUL = 0x1F004408;

    [NativeTypeName("#define DIBUTTON_SOCCERD_HEAD 0x1F004409")]
    public const int DIBUTTON_SOCCERD_HEAD = 0x1F004409;

    [NativeTypeName("#define DIBUTTON_SOCCERD_CLEAR 0x1F00440A")]
    public const int DIBUTTON_SOCCERD_CLEAR = 0x1F00440A;

    [NativeTypeName("#define DIBUTTON_SOCCERD_GOALIECHARGE 0x1F00440B")]
    public const int DIBUTTON_SOCCERD_GOALIECHARGE = 0x1F00440B;

    [NativeTypeName("#define DIBUTTON_SOCCERD_SUBSTITUTE 0x1F00440C")]
    public const int DIBUTTON_SOCCERD_SUBSTITUTE = 0x1F00440C;

    [NativeTypeName("#define DIBUTTON_SOCCERD_LEFT_LINK 0x1F00C4E4")]
    public const int DIBUTTON_SOCCERD_LEFT_LINK = 0x1F00C4E4;

    [NativeTypeName("#define DIBUTTON_SOCCERD_RIGHT_LINK 0x1F00C4EC")]
    public const int DIBUTTON_SOCCERD_RIGHT_LINK = 0x1F00C4EC;

    [NativeTypeName("#define DIBUTTON_SOCCERD_FORWARD_LINK 0x1F0144E0")]
    public const int DIBUTTON_SOCCERD_FORWARD_LINK = 0x1F0144E0;

    [NativeTypeName("#define DIBUTTON_SOCCERD_BACK_LINK 0x1F0144E8")]
    public const int DIBUTTON_SOCCERD_BACK_LINK = 0x1F0144E8;

    [NativeTypeName("#define DIBUTTON_SOCCERD_DEVICE 0x1F0044FE")]
    public const int DIBUTTON_SOCCERD_DEVICE = 0x1F0044FE;

    [NativeTypeName("#define DIBUTTON_SOCCERD_PAUSE 0x1F0044FC")]
    public const int DIBUTTON_SOCCERD_PAUSE = 0x1F0044FC;

    [NativeTypeName("#define DIVIRTUAL_SPORTS_RACQUET 0x20000000")]
    public const int DIVIRTUAL_SPORTS_RACQUET = 0x20000000;

    [NativeTypeName("#define DIAXIS_RACQUET_LATERAL 0x20008201")]
    public const int DIAXIS_RACQUET_LATERAL = 0x20008201;

    [NativeTypeName("#define DIAXIS_RACQUET_MOVE 0x20010202")]
    public const int DIAXIS_RACQUET_MOVE = 0x20010202;

    [NativeTypeName("#define DIBUTTON_RACQUET_SWING 0x20000401")]
    public const int DIBUTTON_RACQUET_SWING = 0x20000401;

    [NativeTypeName("#define DIBUTTON_RACQUET_BACKSWING 0x20000402")]
    public const int DIBUTTON_RACQUET_BACKSWING = 0x20000402;

    [NativeTypeName("#define DIBUTTON_RACQUET_SMASH 0x20000403")]
    public const int DIBUTTON_RACQUET_SMASH = 0x20000403;

    [NativeTypeName("#define DIBUTTON_RACQUET_SPECIAL 0x20000404")]
    public const int DIBUTTON_RACQUET_SPECIAL = 0x20000404;

    [NativeTypeName("#define DIBUTTON_RACQUET_SELECT 0x20000405")]
    public const int DIBUTTON_RACQUET_SELECT = 0x20000405;

    [NativeTypeName("#define DIBUTTON_RACQUET_MENU 0x200004FD")]
    public const int DIBUTTON_RACQUET_MENU = 0x200004FD;

    [NativeTypeName("#define DIHATSWITCH_RACQUET_GLANCE 0x20004601")]
    public const int DIHATSWITCH_RACQUET_GLANCE = 0x20004601;

    [NativeTypeName("#define DIBUTTON_RACQUET_TIMEOUT 0x20004406")]
    public const int DIBUTTON_RACQUET_TIMEOUT = 0x20004406;

    [NativeTypeName("#define DIBUTTON_RACQUET_SUBSTITUTE 0x20004407")]
    public const int DIBUTTON_RACQUET_SUBSTITUTE = 0x20004407;

    [NativeTypeName("#define DIBUTTON_RACQUET_LEFT_LINK 0x2000C4E4")]
    public const int DIBUTTON_RACQUET_LEFT_LINK = 0x2000C4E4;

    [NativeTypeName("#define DIBUTTON_RACQUET_RIGHT_LINK 0x2000C4EC")]
    public const int DIBUTTON_RACQUET_RIGHT_LINK = 0x2000C4EC;

    [NativeTypeName("#define DIBUTTON_RACQUET_FORWARD_LINK 0x200144E0")]
    public const int DIBUTTON_RACQUET_FORWARD_LINK = 0x200144E0;

    [NativeTypeName("#define DIBUTTON_RACQUET_BACK_LINK 0x200144E8")]
    public const int DIBUTTON_RACQUET_BACK_LINK = 0x200144E8;

    [NativeTypeName("#define DIBUTTON_RACQUET_DEVICE 0x200044FE")]
    public const int DIBUTTON_RACQUET_DEVICE = 0x200044FE;

    [NativeTypeName("#define DIBUTTON_RACQUET_PAUSE 0x200044FC")]
    public const int DIBUTTON_RACQUET_PAUSE = 0x200044FC;

    [NativeTypeName("#define DIVIRTUAL_ARCADE_SIDE2SIDE 0x21000000")]
    public const int DIVIRTUAL_ARCADE_SIDE2SIDE = 0x21000000;

    [NativeTypeName("#define DIAXIS_ARCADES_LATERAL 0x21008201")]
    public const int DIAXIS_ARCADES_LATERAL = 0x21008201;

    [NativeTypeName("#define DIAXIS_ARCADES_MOVE 0x21010202")]
    public const int DIAXIS_ARCADES_MOVE = 0x21010202;

    [NativeTypeName("#define DIBUTTON_ARCADES_THROW 0x21000401")]
    public const int DIBUTTON_ARCADES_THROW = 0x21000401;

    [NativeTypeName("#define DIBUTTON_ARCADES_CARRY 0x21000402")]
    public const int DIBUTTON_ARCADES_CARRY = 0x21000402;

    [NativeTypeName("#define DIBUTTON_ARCADES_ATTACK 0x21000403")]
    public const int DIBUTTON_ARCADES_ATTACK = 0x21000403;

    [NativeTypeName("#define DIBUTTON_ARCADES_SPECIAL 0x21000404")]
    public const int DIBUTTON_ARCADES_SPECIAL = 0x21000404;

    [NativeTypeName("#define DIBUTTON_ARCADES_SELECT 0x21000405")]
    public const int DIBUTTON_ARCADES_SELECT = 0x21000405;

    [NativeTypeName("#define DIBUTTON_ARCADES_MENU 0x210004FD")]
    public const int DIBUTTON_ARCADES_MENU = 0x210004FD;

    [NativeTypeName("#define DIHATSWITCH_ARCADES_VIEW 0x21004601")]
    public const int DIHATSWITCH_ARCADES_VIEW = 0x21004601;

    [NativeTypeName("#define DIBUTTON_ARCADES_LEFT_LINK 0x2100C4E4")]
    public const int DIBUTTON_ARCADES_LEFT_LINK = 0x2100C4E4;

    [NativeTypeName("#define DIBUTTON_ARCADES_RIGHT_LINK 0x2100C4EC")]
    public const int DIBUTTON_ARCADES_RIGHT_LINK = 0x2100C4EC;

    [NativeTypeName("#define DIBUTTON_ARCADES_FORWARD_LINK 0x210144E0")]
    public const int DIBUTTON_ARCADES_FORWARD_LINK = 0x210144E0;

    [NativeTypeName("#define DIBUTTON_ARCADES_BACK_LINK 0x210144E8")]
    public const int DIBUTTON_ARCADES_BACK_LINK = 0x210144E8;

    [NativeTypeName("#define DIBUTTON_ARCADES_VIEW_UP_LINK 0x2107C4E0")]
    public const int DIBUTTON_ARCADES_VIEW_UP_LINK = 0x2107C4E0;

    [NativeTypeName("#define DIBUTTON_ARCADES_VIEW_DOWN_LINK 0x2107C4E8")]
    public const int DIBUTTON_ARCADES_VIEW_DOWN_LINK = 0x2107C4E8;

    [NativeTypeName("#define DIBUTTON_ARCADES_VIEW_LEFT_LINK 0x2107C4E4")]
    public const int DIBUTTON_ARCADES_VIEW_LEFT_LINK = 0x2107C4E4;

    [NativeTypeName("#define DIBUTTON_ARCADES_VIEW_RIGHT_LINK 0x2107C4EC")]
    public const int DIBUTTON_ARCADES_VIEW_RIGHT_LINK = 0x2107C4EC;

    [NativeTypeName("#define DIBUTTON_ARCADES_DEVICE 0x210044FE")]
    public const int DIBUTTON_ARCADES_DEVICE = 0x210044FE;

    [NativeTypeName("#define DIBUTTON_ARCADES_PAUSE 0x210044FC")]
    public const int DIBUTTON_ARCADES_PAUSE = 0x210044FC;

    [NativeTypeName("#define DIVIRTUAL_ARCADE_PLATFORM 0x22000000")]
    public const int DIVIRTUAL_ARCADE_PLATFORM = 0x22000000;

    [NativeTypeName("#define DIAXIS_ARCADEP_LATERAL 0x22008201")]
    public const int DIAXIS_ARCADEP_LATERAL = 0x22008201;

    [NativeTypeName("#define DIAXIS_ARCADEP_MOVE 0x22010202")]
    public const int DIAXIS_ARCADEP_MOVE = 0x22010202;

    [NativeTypeName("#define DIBUTTON_ARCADEP_JUMP 0x22000401")]
    public const int DIBUTTON_ARCADEP_JUMP = 0x22000401;

    [NativeTypeName("#define DIBUTTON_ARCADEP_FIRE 0x22000402")]
    public const int DIBUTTON_ARCADEP_FIRE = 0x22000402;

    [NativeTypeName("#define DIBUTTON_ARCADEP_CROUCH 0x22000403")]
    public const int DIBUTTON_ARCADEP_CROUCH = 0x22000403;

    [NativeTypeName("#define DIBUTTON_ARCADEP_SPECIAL 0x22000404")]
    public const int DIBUTTON_ARCADEP_SPECIAL = 0x22000404;

    [NativeTypeName("#define DIBUTTON_ARCADEP_SELECT 0x22000405")]
    public const int DIBUTTON_ARCADEP_SELECT = 0x22000405;

    [NativeTypeName("#define DIBUTTON_ARCADEP_MENU 0x220004FD")]
    public const int DIBUTTON_ARCADEP_MENU = 0x220004FD;

    [NativeTypeName("#define DIHATSWITCH_ARCADEP_VIEW 0x22004601")]
    public const int DIHATSWITCH_ARCADEP_VIEW = 0x22004601;

    [NativeTypeName("#define DIBUTTON_ARCADEP_FIRESECONDARY 0x22004406")]
    public const int DIBUTTON_ARCADEP_FIRESECONDARY = 0x22004406;

    [NativeTypeName("#define DIBUTTON_ARCADEP_LEFT_LINK 0x2200C4E4")]
    public const int DIBUTTON_ARCADEP_LEFT_LINK = 0x2200C4E4;

    [NativeTypeName("#define DIBUTTON_ARCADEP_RIGHT_LINK 0x2200C4EC")]
    public const int DIBUTTON_ARCADEP_RIGHT_LINK = 0x2200C4EC;

    [NativeTypeName("#define DIBUTTON_ARCADEP_FORWARD_LINK 0x220144E0")]
    public const int DIBUTTON_ARCADEP_FORWARD_LINK = 0x220144E0;

    [NativeTypeName("#define DIBUTTON_ARCADEP_BACK_LINK 0x220144E8")]
    public const int DIBUTTON_ARCADEP_BACK_LINK = 0x220144E8;

    [NativeTypeName("#define DIBUTTON_ARCADEP_VIEW_UP_LINK 0x2207C4E0")]
    public const int DIBUTTON_ARCADEP_VIEW_UP_LINK = 0x2207C4E0;

    [NativeTypeName("#define DIBUTTON_ARCADEP_VIEW_DOWN_LINK 0x2207C4E8")]
    public const int DIBUTTON_ARCADEP_VIEW_DOWN_LINK = 0x2207C4E8;

    [NativeTypeName("#define DIBUTTON_ARCADEP_VIEW_LEFT_LINK 0x2207C4E4")]
    public const int DIBUTTON_ARCADEP_VIEW_LEFT_LINK = 0x2207C4E4;

    [NativeTypeName("#define DIBUTTON_ARCADEP_VIEW_RIGHT_LINK 0x2207C4EC")]
    public const int DIBUTTON_ARCADEP_VIEW_RIGHT_LINK = 0x2207C4EC;

    [NativeTypeName("#define DIBUTTON_ARCADEP_DEVICE 0x220044FE")]
    public const int DIBUTTON_ARCADEP_DEVICE = 0x220044FE;

    [NativeTypeName("#define DIBUTTON_ARCADEP_PAUSE 0x220044FC")]
    public const int DIBUTTON_ARCADEP_PAUSE = 0x220044FC;

    [NativeTypeName("#define DIVIRTUAL_CAD_2DCONTROL 0x23000000")]
    public const int DIVIRTUAL_CAD_2DCONTROL = 0x23000000;

    [NativeTypeName("#define DIAXIS_2DCONTROL_LATERAL 0x23008201")]
    public const int DIAXIS_2DCONTROL_LATERAL = 0x23008201;

    [NativeTypeName("#define DIAXIS_2DCONTROL_MOVE 0x23010202")]
    public const int DIAXIS_2DCONTROL_MOVE = 0x23010202;

    [NativeTypeName("#define DIAXIS_2DCONTROL_INOUT 0x23018203")]
    public const int DIAXIS_2DCONTROL_INOUT = 0x23018203;

    [NativeTypeName("#define DIBUTTON_2DCONTROL_SELECT 0x23000401")]
    public const int DIBUTTON_2DCONTROL_SELECT = 0x23000401;

    [NativeTypeName("#define DIBUTTON_2DCONTROL_SPECIAL1 0x23000402")]
    public const int DIBUTTON_2DCONTROL_SPECIAL1 = 0x23000402;

    [NativeTypeName("#define DIBUTTON_2DCONTROL_SPECIAL 0x23000403")]
    public const int DIBUTTON_2DCONTROL_SPECIAL = 0x23000403;

    [NativeTypeName("#define DIBUTTON_2DCONTROL_SPECIAL2 0x23000404")]
    public const int DIBUTTON_2DCONTROL_SPECIAL2 = 0x23000404;

    [NativeTypeName("#define DIBUTTON_2DCONTROL_MENU 0x230004FD")]
    public const int DIBUTTON_2DCONTROL_MENU = 0x230004FD;

    [NativeTypeName("#define DIHATSWITCH_2DCONTROL_HATSWITCH 0x23004601")]
    public const int DIHATSWITCH_2DCONTROL_HATSWITCH = 0x23004601;

    [NativeTypeName("#define DIAXIS_2DCONTROL_ROTATEZ 0x23024204")]
    public const int DIAXIS_2DCONTROL_ROTATEZ = 0x23024204;

    [NativeTypeName("#define DIBUTTON_2DCONTROL_DISPLAY 0x23004405")]
    public const int DIBUTTON_2DCONTROL_DISPLAY = 0x23004405;

    [NativeTypeName("#define DIBUTTON_2DCONTROL_DEVICE 0x230044FE")]
    public const int DIBUTTON_2DCONTROL_DEVICE = 0x230044FE;

    [NativeTypeName("#define DIBUTTON_2DCONTROL_PAUSE 0x230044FC")]
    public const int DIBUTTON_2DCONTROL_PAUSE = 0x230044FC;

    [NativeTypeName("#define DIVIRTUAL_CAD_3DCONTROL 0x24000000")]
    public const int DIVIRTUAL_CAD_3DCONTROL = 0x24000000;

    [NativeTypeName("#define DIAXIS_3DCONTROL_LATERAL 0x24008201")]
    public const int DIAXIS_3DCONTROL_LATERAL = 0x24008201;

    [NativeTypeName("#define DIAXIS_3DCONTROL_MOVE 0x24010202")]
    public const int DIAXIS_3DCONTROL_MOVE = 0x24010202;

    [NativeTypeName("#define DIAXIS_3DCONTROL_INOUT 0x24018203")]
    public const int DIAXIS_3DCONTROL_INOUT = 0x24018203;

    [NativeTypeName("#define DIBUTTON_3DCONTROL_SELECT 0x24000401")]
    public const int DIBUTTON_3DCONTROL_SELECT = 0x24000401;

    [NativeTypeName("#define DIBUTTON_3DCONTROL_SPECIAL1 0x24000402")]
    public const int DIBUTTON_3DCONTROL_SPECIAL1 = 0x24000402;

    [NativeTypeName("#define DIBUTTON_3DCONTROL_SPECIAL 0x24000403")]
    public const int DIBUTTON_3DCONTROL_SPECIAL = 0x24000403;

    [NativeTypeName("#define DIBUTTON_3DCONTROL_SPECIAL2 0x24000404")]
    public const int DIBUTTON_3DCONTROL_SPECIAL2 = 0x24000404;

    [NativeTypeName("#define DIBUTTON_3DCONTROL_MENU 0x240004FD")]
    public const int DIBUTTON_3DCONTROL_MENU = 0x240004FD;

    [NativeTypeName("#define DIHATSWITCH_3DCONTROL_HATSWITCH 0x24004601")]
    public const int DIHATSWITCH_3DCONTROL_HATSWITCH = 0x24004601;

    [NativeTypeName("#define DIAXIS_3DCONTROL_ROTATEX 0x24034204")]
    public const int DIAXIS_3DCONTROL_ROTATEX = 0x24034204;

    [NativeTypeName("#define DIAXIS_3DCONTROL_ROTATEY 0x2402C205")]
    public const int DIAXIS_3DCONTROL_ROTATEY = 0x2402C205;

    [NativeTypeName("#define DIAXIS_3DCONTROL_ROTATEZ 0x24024206")]
    public const int DIAXIS_3DCONTROL_ROTATEZ = 0x24024206;

    [NativeTypeName("#define DIBUTTON_3DCONTROL_DISPLAY 0x24004405")]
    public const int DIBUTTON_3DCONTROL_DISPLAY = 0x24004405;

    [NativeTypeName("#define DIBUTTON_3DCONTROL_DEVICE 0x240044FE")]
    public const int DIBUTTON_3DCONTROL_DEVICE = 0x240044FE;

    [NativeTypeName("#define DIBUTTON_3DCONTROL_PAUSE 0x240044FC")]
    public const int DIBUTTON_3DCONTROL_PAUSE = 0x240044FC;

    [NativeTypeName("#define DIVIRTUAL_CAD_FLYBY 0x25000000")]
    public const int DIVIRTUAL_CAD_FLYBY = 0x25000000;

    [NativeTypeName("#define DIAXIS_CADF_LATERAL 0x25008201")]
    public const int DIAXIS_CADF_LATERAL = 0x25008201;

    [NativeTypeName("#define DIAXIS_CADF_MOVE 0x25010202")]
    public const int DIAXIS_CADF_MOVE = 0x25010202;

    [NativeTypeName("#define DIAXIS_CADF_INOUT 0x25018203")]
    public const int DIAXIS_CADF_INOUT = 0x25018203;

    [NativeTypeName("#define DIBUTTON_CADF_SELECT 0x25000401")]
    public const int DIBUTTON_CADF_SELECT = 0x25000401;

    [NativeTypeName("#define DIBUTTON_CADF_SPECIAL1 0x25000402")]
    public const int DIBUTTON_CADF_SPECIAL1 = 0x25000402;

    [NativeTypeName("#define DIBUTTON_CADF_SPECIAL 0x25000403")]
    public const int DIBUTTON_CADF_SPECIAL = 0x25000403;

    [NativeTypeName("#define DIBUTTON_CADF_SPECIAL2 0x25000404")]
    public const int DIBUTTON_CADF_SPECIAL2 = 0x25000404;

    [NativeTypeName("#define DIBUTTON_CADF_MENU 0x250004FD")]
    public const int DIBUTTON_CADF_MENU = 0x250004FD;

    [NativeTypeName("#define DIHATSWITCH_CADF_HATSWITCH 0x25004601")]
    public const int DIHATSWITCH_CADF_HATSWITCH = 0x25004601;

    [NativeTypeName("#define DIAXIS_CADF_ROTATEX 0x25034204")]
    public const int DIAXIS_CADF_ROTATEX = 0x25034204;

    [NativeTypeName("#define DIAXIS_CADF_ROTATEY 0x2502C205")]
    public const int DIAXIS_CADF_ROTATEY = 0x2502C205;

    [NativeTypeName("#define DIAXIS_CADF_ROTATEZ 0x25024206")]
    public const int DIAXIS_CADF_ROTATEZ = 0x25024206;

    [NativeTypeName("#define DIBUTTON_CADF_DISPLAY 0x25004405")]
    public const int DIBUTTON_CADF_DISPLAY = 0x25004405;

    [NativeTypeName("#define DIBUTTON_CADF_DEVICE 0x250044FE")]
    public const int DIBUTTON_CADF_DEVICE = 0x250044FE;

    [NativeTypeName("#define DIBUTTON_CADF_PAUSE 0x250044FC")]
    public const int DIBUTTON_CADF_PAUSE = 0x250044FC;

    [NativeTypeName("#define DIVIRTUAL_CAD_MODEL 0x26000000")]
    public const int DIVIRTUAL_CAD_MODEL = 0x26000000;

    [NativeTypeName("#define DIAXIS_CADM_LATERAL 0x26008201")]
    public const int DIAXIS_CADM_LATERAL = 0x26008201;

    [NativeTypeName("#define DIAXIS_CADM_MOVE 0x26010202")]
    public const int DIAXIS_CADM_MOVE = 0x26010202;

    [NativeTypeName("#define DIAXIS_CADM_INOUT 0x26018203")]
    public const int DIAXIS_CADM_INOUT = 0x26018203;

    [NativeTypeName("#define DIBUTTON_CADM_SELECT 0x26000401")]
    public const int DIBUTTON_CADM_SELECT = 0x26000401;

    [NativeTypeName("#define DIBUTTON_CADM_SPECIAL1 0x26000402")]
    public const int DIBUTTON_CADM_SPECIAL1 = 0x26000402;

    [NativeTypeName("#define DIBUTTON_CADM_SPECIAL 0x26000403")]
    public const int DIBUTTON_CADM_SPECIAL = 0x26000403;

    [NativeTypeName("#define DIBUTTON_CADM_SPECIAL2 0x26000404")]
    public const int DIBUTTON_CADM_SPECIAL2 = 0x26000404;

    [NativeTypeName("#define DIBUTTON_CADM_MENU 0x260004FD")]
    public const int DIBUTTON_CADM_MENU = 0x260004FD;

    [NativeTypeName("#define DIHATSWITCH_CADM_HATSWITCH 0x26004601")]
    public const int DIHATSWITCH_CADM_HATSWITCH = 0x26004601;

    [NativeTypeName("#define DIAXIS_CADM_ROTATEX 0x26034204")]
    public const int DIAXIS_CADM_ROTATEX = 0x26034204;

    [NativeTypeName("#define DIAXIS_CADM_ROTATEY 0x2602C205")]
    public const int DIAXIS_CADM_ROTATEY = 0x2602C205;

    [NativeTypeName("#define DIAXIS_CADM_ROTATEZ 0x26024206")]
    public const int DIAXIS_CADM_ROTATEZ = 0x26024206;

    [NativeTypeName("#define DIBUTTON_CADM_DISPLAY 0x26004405")]
    public const int DIBUTTON_CADM_DISPLAY = 0x26004405;

    [NativeTypeName("#define DIBUTTON_CADM_DEVICE 0x260044FE")]
    public const int DIBUTTON_CADM_DEVICE = 0x260044FE;

    [NativeTypeName("#define DIBUTTON_CADM_PAUSE 0x260044FC")]
    public const int DIBUTTON_CADM_PAUSE = 0x260044FC;

    [NativeTypeName("#define DIVIRTUAL_REMOTE_CONTROL 0x27000000")]
    public const int DIVIRTUAL_REMOTE_CONTROL = 0x27000000;

    [NativeTypeName("#define DIAXIS_REMOTE_SLIDER 0x27050201")]
    public const int DIAXIS_REMOTE_SLIDER = 0x27050201;

    [NativeTypeName("#define DIBUTTON_REMOTE_MUTE 0x27000401")]
    public const int DIBUTTON_REMOTE_MUTE = 0x27000401;

    [NativeTypeName("#define DIBUTTON_REMOTE_SELECT 0x27000402")]
    public const int DIBUTTON_REMOTE_SELECT = 0x27000402;

    [NativeTypeName("#define DIBUTTON_REMOTE_PLAY 0x27002403")]
    public const int DIBUTTON_REMOTE_PLAY = 0x27002403;

    [NativeTypeName("#define DIBUTTON_REMOTE_CUE 0x27002404")]
    public const int DIBUTTON_REMOTE_CUE = 0x27002404;

    [NativeTypeName("#define DIBUTTON_REMOTE_REVIEW 0x27002405")]
    public const int DIBUTTON_REMOTE_REVIEW = 0x27002405;

    [NativeTypeName("#define DIBUTTON_REMOTE_CHANGE 0x27002406")]
    public const int DIBUTTON_REMOTE_CHANGE = 0x27002406;

    [NativeTypeName("#define DIBUTTON_REMOTE_RECORD 0x27002407")]
    public const int DIBUTTON_REMOTE_RECORD = 0x27002407;

    [NativeTypeName("#define DIBUTTON_REMOTE_MENU 0x270004FD")]
    public const int DIBUTTON_REMOTE_MENU = 0x270004FD;

    [NativeTypeName("#define DIAXIS_REMOTE_SLIDER2 0x27054202")]
    public const int DIAXIS_REMOTE_SLIDER2 = 0x27054202;

    [NativeTypeName("#define DIBUTTON_REMOTE_TV 0x27005C08")]
    public const int DIBUTTON_REMOTE_TV = 0x27005C08;

    [NativeTypeName("#define DIBUTTON_REMOTE_CABLE 0x27005C09")]
    public const int DIBUTTON_REMOTE_CABLE = 0x27005C09;

    [NativeTypeName("#define DIBUTTON_REMOTE_CD 0x27005C0A")]
    public const int DIBUTTON_REMOTE_CD = 0x27005C0A;

    [NativeTypeName("#define DIBUTTON_REMOTE_VCR 0x27005C0B")]
    public const int DIBUTTON_REMOTE_VCR = 0x27005C0B;

    [NativeTypeName("#define DIBUTTON_REMOTE_TUNER 0x27005C0C")]
    public const int DIBUTTON_REMOTE_TUNER = 0x27005C0C;

    [NativeTypeName("#define DIBUTTON_REMOTE_DVD 0x27005C0D")]
    public const int DIBUTTON_REMOTE_DVD = 0x27005C0D;

    [NativeTypeName("#define DIBUTTON_REMOTE_ADJUST 0x27005C0E")]
    public const int DIBUTTON_REMOTE_ADJUST = 0x27005C0E;

    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT0 0x2700540F")]
    public const int DIBUTTON_REMOTE_DIGIT0 = 0x2700540F;

    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT1 0x27005410")]
    public const int DIBUTTON_REMOTE_DIGIT1 = 0x27005410;

    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT2 0x27005411")]
    public const int DIBUTTON_REMOTE_DIGIT2 = 0x27005411;

    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT3 0x27005412")]
    public const int DIBUTTON_REMOTE_DIGIT3 = 0x27005412;

    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT4 0x27005413")]
    public const int DIBUTTON_REMOTE_DIGIT4 = 0x27005413;

    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT5 0x27005414")]
    public const int DIBUTTON_REMOTE_DIGIT5 = 0x27005414;

    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT6 0x27005415")]
    public const int DIBUTTON_REMOTE_DIGIT6 = 0x27005415;

    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT7 0x27005416")]
    public const int DIBUTTON_REMOTE_DIGIT7 = 0x27005416;

    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT8 0x27005417")]
    public const int DIBUTTON_REMOTE_DIGIT8 = 0x27005417;

    [NativeTypeName("#define DIBUTTON_REMOTE_DIGIT9 0x27005418")]
    public const int DIBUTTON_REMOTE_DIGIT9 = 0x27005418;

    [NativeTypeName("#define DIBUTTON_REMOTE_DEVICE 0x270044FE")]
    public const int DIBUTTON_REMOTE_DEVICE = 0x270044FE;

    [NativeTypeName("#define DIBUTTON_REMOTE_PAUSE 0x270044FC")]
    public const int DIBUTTON_REMOTE_PAUSE = 0x270044FC;

    [NativeTypeName("#define DIVIRTUAL_BROWSER_CONTROL 0x28000000")]
    public const int DIVIRTUAL_BROWSER_CONTROL = 0x28000000;

    [NativeTypeName("#define DIAXIS_BROWSER_LATERAL 0x28008201")]
    public const int DIAXIS_BROWSER_LATERAL = 0x28008201;

    [NativeTypeName("#define DIAXIS_BROWSER_MOVE 0x28010202")]
    public const int DIAXIS_BROWSER_MOVE = 0x28010202;

    [NativeTypeName("#define DIBUTTON_BROWSER_SELECT 0x28000401")]
    public const int DIBUTTON_BROWSER_SELECT = 0x28000401;

    [NativeTypeName("#define DIAXIS_BROWSER_VIEW 0x28018203")]
    public const int DIAXIS_BROWSER_VIEW = 0x28018203;

    [NativeTypeName("#define DIBUTTON_BROWSER_REFRESH 0x28000402")]
    public const int DIBUTTON_BROWSER_REFRESH = 0x28000402;

    [NativeTypeName("#define DIBUTTON_BROWSER_MENU 0x280004FD")]
    public const int DIBUTTON_BROWSER_MENU = 0x280004FD;

    [NativeTypeName("#define DIBUTTON_BROWSER_SEARCH 0x28004403")]
    public const int DIBUTTON_BROWSER_SEARCH = 0x28004403;

    [NativeTypeName("#define DIBUTTON_BROWSER_STOP 0x28004404")]
    public const int DIBUTTON_BROWSER_STOP = 0x28004404;

    [NativeTypeName("#define DIBUTTON_BROWSER_HOME 0x28004405")]
    public const int DIBUTTON_BROWSER_HOME = 0x28004405;

    [NativeTypeName("#define DIBUTTON_BROWSER_FAVORITES 0x28004406")]
    public const int DIBUTTON_BROWSER_FAVORITES = 0x28004406;

    [NativeTypeName("#define DIBUTTON_BROWSER_NEXT 0x28004407")]
    public const int DIBUTTON_BROWSER_NEXT = 0x28004407;

    [NativeTypeName("#define DIBUTTON_BROWSER_PREVIOUS 0x28004408")]
    public const int DIBUTTON_BROWSER_PREVIOUS = 0x28004408;

    [NativeTypeName("#define DIBUTTON_BROWSER_HISTORY 0x28004409")]
    public const int DIBUTTON_BROWSER_HISTORY = 0x28004409;

    [NativeTypeName("#define DIBUTTON_BROWSER_PRINT 0x2800440A")]
    public const int DIBUTTON_BROWSER_PRINT = 0x2800440A;

    [NativeTypeName("#define DIBUTTON_BROWSER_DEVICE 0x280044FE")]
    public const int DIBUTTON_BROWSER_DEVICE = 0x280044FE;

    [NativeTypeName("#define DIBUTTON_BROWSER_PAUSE 0x280044FC")]
    public const int DIBUTTON_BROWSER_PAUSE = 0x280044FC;

    [NativeTypeName("#define DIVIRTUAL_DRIVING_MECHA 0x29000000")]
    public const int DIVIRTUAL_DRIVING_MECHA = 0x29000000;

    [NativeTypeName("#define DIAXIS_MECHA_STEER 0x29008201")]
    public const int DIAXIS_MECHA_STEER = 0x29008201;

    [NativeTypeName("#define DIAXIS_MECHA_TORSO 0x29010202")]
    public const int DIAXIS_MECHA_TORSO = 0x29010202;

    [NativeTypeName("#define DIAXIS_MECHA_ROTATE 0x29020203")]
    public const int DIAXIS_MECHA_ROTATE = 0x29020203;

    [NativeTypeName("#define DIAXIS_MECHA_THROTTLE 0x29038204")]
    public const int DIAXIS_MECHA_THROTTLE = 0x29038204;

    [NativeTypeName("#define DIBUTTON_MECHA_FIRE 0x29000401")]
    public const int DIBUTTON_MECHA_FIRE = 0x29000401;

    [NativeTypeName("#define DIBUTTON_MECHA_WEAPONS 0x29000402")]
    public const int DIBUTTON_MECHA_WEAPONS = 0x29000402;

    [NativeTypeName("#define DIBUTTON_MECHA_TARGET 0x29000403")]
    public const int DIBUTTON_MECHA_TARGET = 0x29000403;

    [NativeTypeName("#define DIBUTTON_MECHA_REVERSE 0x29000404")]
    public const int DIBUTTON_MECHA_REVERSE = 0x29000404;

    [NativeTypeName("#define DIBUTTON_MECHA_ZOOM 0x29000405")]
    public const int DIBUTTON_MECHA_ZOOM = 0x29000405;

    [NativeTypeName("#define DIBUTTON_MECHA_JUMP 0x29000406")]
    public const int DIBUTTON_MECHA_JUMP = 0x29000406;

    [NativeTypeName("#define DIBUTTON_MECHA_MENU 0x290004FD")]
    public const int DIBUTTON_MECHA_MENU = 0x290004FD;

    [NativeTypeName("#define DIBUTTON_MECHA_CENTER 0x29004407")]
    public const int DIBUTTON_MECHA_CENTER = 0x29004407;

    [NativeTypeName("#define DIHATSWITCH_MECHA_GLANCE 0x29004601")]
    public const int DIHATSWITCH_MECHA_GLANCE = 0x29004601;

    [NativeTypeName("#define DIBUTTON_MECHA_VIEW 0x29004408")]
    public const int DIBUTTON_MECHA_VIEW = 0x29004408;

    [NativeTypeName("#define DIBUTTON_MECHA_FIRESECONDARY 0x29004409")]
    public const int DIBUTTON_MECHA_FIRESECONDARY = 0x29004409;

    [NativeTypeName("#define DIBUTTON_MECHA_LEFT_LINK 0x2900C4E4")]
    public const int DIBUTTON_MECHA_LEFT_LINK = 0x2900C4E4;

    [NativeTypeName("#define DIBUTTON_MECHA_RIGHT_LINK 0x2900C4EC")]
    public const int DIBUTTON_MECHA_RIGHT_LINK = 0x2900C4EC;

    [NativeTypeName("#define DIBUTTON_MECHA_FORWARD_LINK 0x290144E0")]
    public const int DIBUTTON_MECHA_FORWARD_LINK = 0x290144E0;

    [NativeTypeName("#define DIBUTTON_MECHA_BACK_LINK 0x290144E8")]
    public const int DIBUTTON_MECHA_BACK_LINK = 0x290144E8;

    [NativeTypeName("#define DIBUTTON_MECHA_ROTATE_LEFT_LINK 0x290244E4")]
    public const int DIBUTTON_MECHA_ROTATE_LEFT_LINK = 0x290244E4;

    [NativeTypeName("#define DIBUTTON_MECHA_ROTATE_RIGHT_LINK 0x290244EC")]
    public const int DIBUTTON_MECHA_ROTATE_RIGHT_LINK = 0x290244EC;

    [NativeTypeName("#define DIBUTTON_MECHA_FASTER_LINK 0x2903C4E0")]
    public const int DIBUTTON_MECHA_FASTER_LINK = 0x2903C4E0;

    [NativeTypeName("#define DIBUTTON_MECHA_SLOWER_LINK 0x2903C4E8")]
    public const int DIBUTTON_MECHA_SLOWER_LINK = 0x2903C4E8;

    [NativeTypeName("#define DIBUTTON_MECHA_DEVICE 0x290044FE")]
    public const int DIBUTTON_MECHA_DEVICE = 0x290044FE;

    [NativeTypeName("#define DIBUTTON_MECHA_PAUSE 0x290044FC")]
    public const int DIBUTTON_MECHA_PAUSE = 0x290044FC;

    [NativeTypeName("#define DIAXIS_ANY_X_1 0xFF00C201")]
    public const uint DIAXIS_ANY_X_1 = 0xFF00C201;

    [NativeTypeName("#define DIAXIS_ANY_X_2 0xFF00C202")]
    public const uint DIAXIS_ANY_X_2 = 0xFF00C202;

    [NativeTypeName("#define DIAXIS_ANY_Y_1 0xFF014201")]
    public const uint DIAXIS_ANY_Y_1 = 0xFF014201;

    [NativeTypeName("#define DIAXIS_ANY_Y_2 0xFF014202")]
    public const uint DIAXIS_ANY_Y_2 = 0xFF014202;

    [NativeTypeName("#define DIAXIS_ANY_Z_1 0xFF01C201")]
    public const uint DIAXIS_ANY_Z_1 = 0xFF01C201;

    [NativeTypeName("#define DIAXIS_ANY_Z_2 0xFF01C202")]
    public const uint DIAXIS_ANY_Z_2 = 0xFF01C202;

    [NativeTypeName("#define DIAXIS_ANY_R_1 0xFF024201")]
    public const uint DIAXIS_ANY_R_1 = 0xFF024201;

    [NativeTypeName("#define DIAXIS_ANY_R_2 0xFF024202")]
    public const uint DIAXIS_ANY_R_2 = 0xFF024202;

    [NativeTypeName("#define DIAXIS_ANY_U_1 0xFF02C201")]
    public const uint DIAXIS_ANY_U_1 = 0xFF02C201;

    [NativeTypeName("#define DIAXIS_ANY_U_2 0xFF02C202")]
    public const uint DIAXIS_ANY_U_2 = 0xFF02C202;

    [NativeTypeName("#define DIAXIS_ANY_V_1 0xFF034201")]
    public const uint DIAXIS_ANY_V_1 = 0xFF034201;

    [NativeTypeName("#define DIAXIS_ANY_V_2 0xFF034202")]
    public const uint DIAXIS_ANY_V_2 = 0xFF034202;

    [NativeTypeName("#define DIAXIS_ANY_A_1 0xFF03C201")]
    public const uint DIAXIS_ANY_A_1 = 0xFF03C201;

    [NativeTypeName("#define DIAXIS_ANY_A_2 0xFF03C202")]
    public const uint DIAXIS_ANY_A_2 = 0xFF03C202;

    [NativeTypeName("#define DIAXIS_ANY_B_1 0xFF044201")]
    public const uint DIAXIS_ANY_B_1 = 0xFF044201;

    [NativeTypeName("#define DIAXIS_ANY_B_2 0xFF044202")]
    public const uint DIAXIS_ANY_B_2 = 0xFF044202;

    [NativeTypeName("#define DIAXIS_ANY_C_1 0xFF04C201")]
    public const uint DIAXIS_ANY_C_1 = 0xFF04C201;

    [NativeTypeName("#define DIAXIS_ANY_C_2 0xFF04C202")]
    public const uint DIAXIS_ANY_C_2 = 0xFF04C202;

    [NativeTypeName("#define DIAXIS_ANY_S_1 0xFF054201")]
    public const uint DIAXIS_ANY_S_1 = 0xFF054201;

    [NativeTypeName("#define DIAXIS_ANY_S_2 0xFF054202")]
    public const uint DIAXIS_ANY_S_2 = 0xFF054202;

    [NativeTypeName("#define DIAXIS_ANY_1 0xFF004201")]
    public const uint DIAXIS_ANY_1 = 0xFF004201;

    [NativeTypeName("#define DIAXIS_ANY_2 0xFF004202")]
    public const uint DIAXIS_ANY_2 = 0xFF004202;

    [NativeTypeName("#define DIAXIS_ANY_3 0xFF004203")]
    public const uint DIAXIS_ANY_3 = 0xFF004203;

    [NativeTypeName("#define DIAXIS_ANY_4 0xFF004204")]
    public const uint DIAXIS_ANY_4 = 0xFF004204;

    [NativeTypeName("#define DIPOV_ANY_1 0xFF004601")]
    public const uint DIPOV_ANY_1 = 0xFF004601;

    [NativeTypeName("#define DIPOV_ANY_2 0xFF004602")]
    public const uint DIPOV_ANY_2 = 0xFF004602;

    [NativeTypeName("#define DIPOV_ANY_3 0xFF004603")]
    public const uint DIPOV_ANY_3 = 0xFF004603;

    [NativeTypeName("#define DIPOV_ANY_4 0xFF004604")]
    public const uint DIPOV_ANY_4 = 0xFF004604;

    [NativeTypeName("#define JOY_PASSDRIVERDATA 0x10000000l")]
    public const int JOY_PASSDRIVERDATA = 0x10000000;

    [NativeTypeName("#define JOY_HWS_ISHEADTRACKER 0x02000000l")]
    public const int JOY_HWS_ISHEADTRACKER = 0x02000000;

    [NativeTypeName("#define JOY_HWS_ISGAMEPORTDRIVER 0x04000000l")]
    public const int JOY_HWS_ISGAMEPORTDRIVER = 0x04000000;

    [NativeTypeName("#define JOY_HWS_ISANALOGPORTDRIVER 0x08000000l")]
    public const int JOY_HWS_ISANALOGPORTDRIVER = 0x08000000;

    [NativeTypeName("#define JOY_HWS_AUTOLOAD 0x10000000l")]
    public const int JOY_HWS_AUTOLOAD = 0x10000000;

    [NativeTypeName("#define JOY_HWS_NODEVNODE 0x20000000l")]
    public const int JOY_HWS_NODEVNODE = 0x20000000;

    [NativeTypeName("#define JOY_HWS_ISGAMEPORTBUS 0x80000000l")]
    public const uint JOY_HWS_ISGAMEPORTBUS = 0x80000000;

    [NativeTypeName("#define JOY_HWS_GAMEPORTBUSBUSY 0x00000001l")]
    public const int JOY_HWS_GAMEPORTBUSBUSY = 0x00000001;

    [NativeTypeName("#define JOY_US_VOLATILE 0x00000008L")]
    public const int JOY_US_VOLATILE = 0x00000008;
}
