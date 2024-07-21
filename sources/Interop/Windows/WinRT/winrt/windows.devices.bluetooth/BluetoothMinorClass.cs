// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.bluetooth.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass"]/*' />
public enum BluetoothMinorClass
{
    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_Uncategorized"]/*' />
    BluetoothMinorClass_Uncategorized = 0,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_ComputerDesktop"]/*' />
    BluetoothMinorClass_ComputerDesktop = 1,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_ComputerServer"]/*' />
    BluetoothMinorClass_ComputerServer = 2,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_ComputerLaptop"]/*' />
    BluetoothMinorClass_ComputerLaptop = 3,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_ComputerHandheld"]/*' />
    BluetoothMinorClass_ComputerHandheld = 4,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_ComputerPalmSize"]/*' />
    BluetoothMinorClass_ComputerPalmSize = 5,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_ComputerWearable"]/*' />
    BluetoothMinorClass_ComputerWearable = 6,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_ComputerTablet"]/*' />
    BluetoothMinorClass_ComputerTablet = 7,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_PhoneCellular"]/*' />
    BluetoothMinorClass_PhoneCellular = 1,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_PhoneCordless"]/*' />
    BluetoothMinorClass_PhoneCordless = 2,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_PhoneSmartPhone"]/*' />
    BluetoothMinorClass_PhoneSmartPhone = 3,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_PhoneWired"]/*' />
    BluetoothMinorClass_PhoneWired = 4,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_PhoneIsdn"]/*' />
    BluetoothMinorClass_PhoneIsdn = 5,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_NetworkFullyAvailable"]/*' />
    BluetoothMinorClass_NetworkFullyAvailable = 0,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_NetworkUsed01To17Percent"]/*' />
    BluetoothMinorClass_NetworkUsed01To17Percent = 8,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_NetworkUsed17To33Percent"]/*' />
    BluetoothMinorClass_NetworkUsed17To33Percent = 16,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_NetworkUsed33To50Percent"]/*' />
    BluetoothMinorClass_NetworkUsed33To50Percent = 24,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_NetworkUsed50To67Percent"]/*' />
    BluetoothMinorClass_NetworkUsed50To67Percent = 32,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_NetworkUsed67To83Percent"]/*' />
    BluetoothMinorClass_NetworkUsed67To83Percent = 40,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_NetworkUsed83To99Percent"]/*' />
    BluetoothMinorClass_NetworkUsed83To99Percent = 48,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_NetworkNoServiceAvailable"]/*' />
    BluetoothMinorClass_NetworkNoServiceAvailable = 56,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoWearableHeadset"]/*' />
    BluetoothMinorClass_AudioVideoWearableHeadset = 1,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoHandsFree"]/*' />
    BluetoothMinorClass_AudioVideoHandsFree = 2,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoMicrophone"]/*' />
    BluetoothMinorClass_AudioVideoMicrophone = 4,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoLoudspeaker"]/*' />
    BluetoothMinorClass_AudioVideoLoudspeaker = 5,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoHeadphones"]/*' />
    BluetoothMinorClass_AudioVideoHeadphones = 6,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoPortableAudio"]/*' />
    BluetoothMinorClass_AudioVideoPortableAudio = 7,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoCarAudio"]/*' />
    BluetoothMinorClass_AudioVideoCarAudio = 8,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoSetTopBox"]/*' />
    BluetoothMinorClass_AudioVideoSetTopBox = 9,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoHifiAudioDevice"]/*' />
    BluetoothMinorClass_AudioVideoHifiAudioDevice = 10,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoVcr"]/*' />
    BluetoothMinorClass_AudioVideoVcr = 11,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoVideoCamera"]/*' />
    BluetoothMinorClass_AudioVideoVideoCamera = 12,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoCamcorder"]/*' />
    BluetoothMinorClass_AudioVideoCamcorder = 13,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoVideoMonitor"]/*' />
    BluetoothMinorClass_AudioVideoVideoMonitor = 14,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoVideoDisplayAndLoudspeaker"]/*' />
    BluetoothMinorClass_AudioVideoVideoDisplayAndLoudspeaker = 15,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoVideoConferencing"]/*' />
    BluetoothMinorClass_AudioVideoVideoConferencing = 16,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_AudioVideoGamingOrToy"]/*' />
    BluetoothMinorClass_AudioVideoGamingOrToy = 18,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_PeripheralJoystick"]/*' />
    BluetoothMinorClass_PeripheralJoystick = 1,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_PeripheralGamepad"]/*' />
    BluetoothMinorClass_PeripheralGamepad = 2,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_PeripheralRemoteControl"]/*' />
    BluetoothMinorClass_PeripheralRemoteControl = 3,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_PeripheralSensing"]/*' />
    BluetoothMinorClass_PeripheralSensing = 4,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_PeripheralDigitizerTablet"]/*' />
    BluetoothMinorClass_PeripheralDigitizerTablet = 5,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_PeripheralCardReader"]/*' />
    BluetoothMinorClass_PeripheralCardReader = 6,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_PeripheralDigitalPen"]/*' />
    BluetoothMinorClass_PeripheralDigitalPen = 7,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_PeripheralHandheldScanner"]/*' />
    BluetoothMinorClass_PeripheralHandheldScanner = 8,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_PeripheralHandheldGesture"]/*' />
    BluetoothMinorClass_PeripheralHandheldGesture = 9,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_WearableWristwatch"]/*' />
    BluetoothMinorClass_WearableWristwatch = 1,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_WearablePager"]/*' />
    BluetoothMinorClass_WearablePager = 2,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_WearableJacket"]/*' />
    BluetoothMinorClass_WearableJacket = 3,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_WearableHelmet"]/*' />
    BluetoothMinorClass_WearableHelmet = 4,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_WearableGlasses"]/*' />
    BluetoothMinorClass_WearableGlasses = 5,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_ToyRobot"]/*' />
    BluetoothMinorClass_ToyRobot = 1,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_ToyVehicle"]/*' />
    BluetoothMinorClass_ToyVehicle = 2,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_ToyDoll"]/*' />
    BluetoothMinorClass_ToyDoll = 3,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_ToyController"]/*' />
    BluetoothMinorClass_ToyController = 4,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_ToyGame"]/*' />
    BluetoothMinorClass_ToyGame = 5,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_HealthBloodPressureMonitor"]/*' />
    BluetoothMinorClass_HealthBloodPressureMonitor = 1,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_HealthThermometer"]/*' />
    BluetoothMinorClass_HealthThermometer = 2,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_HealthWeighingScale"]/*' />
    BluetoothMinorClass_HealthWeighingScale = 3,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_HealthGlucoseMeter"]/*' />
    BluetoothMinorClass_HealthGlucoseMeter = 4,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_HealthPulseOximeter"]/*' />
    BluetoothMinorClass_HealthPulseOximeter = 5,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_HealthHeartRateMonitor"]/*' />
    BluetoothMinorClass_HealthHeartRateMonitor = 6,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_HealthHealthDataDisplay"]/*' />
    BluetoothMinorClass_HealthHealthDataDisplay = 7,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_HealthStepCounter"]/*' />
    BluetoothMinorClass_HealthStepCounter = 8,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_HealthBodyCompositionAnalyzer"]/*' />
    BluetoothMinorClass_HealthBodyCompositionAnalyzer = 9,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_HealthPeakFlowMonitor"]/*' />
    BluetoothMinorClass_HealthPeakFlowMonitor = 10,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_HealthMedicationMonitor"]/*' />
    BluetoothMinorClass_HealthMedicationMonitor = 11,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_HealthKneeProsthesis"]/*' />
    BluetoothMinorClass_HealthKneeProsthesis = 12,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_HealthAnkleProsthesis"]/*' />
    BluetoothMinorClass_HealthAnkleProsthesis = 13,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_HealthGenericHealthManager"]/*' />
    BluetoothMinorClass_HealthGenericHealthManager = 14,

    /// <include file='BluetoothMinorClass.xml' path='doc/member[@name="BluetoothMinorClass.BluetoothMinorClass_HealthPersonalMobilityDevice"]/*' />
    BluetoothMinorClass_HealthPersonalMobilityDevice = 15,
}
