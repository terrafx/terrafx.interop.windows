// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.activation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind"]/*' />
public enum ActivationKind
{
    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_Launch"]/*' />
    ActivationKind_Launch = 0,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_Search"]/*' />
    ActivationKind_Search = 1,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_ShareTarget"]/*' />
    ActivationKind_ShareTarget = 2,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_File"]/*' />
    ActivationKind_File = 3,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_Protocol"]/*' />
    ActivationKind_Protocol = 4,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_FileOpenPicker"]/*' />
    ActivationKind_FileOpenPicker = 5,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_FileSavePicker"]/*' />
    ActivationKind_FileSavePicker = 6,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_CachedFileUpdater"]/*' />
    ActivationKind_CachedFileUpdater = 7,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_ContactPicker"]/*' />
    ActivationKind_ContactPicker = 8,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_Device"]/*' />
    ActivationKind_Device = 9,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_PrintTaskSettings"]/*' />
    ActivationKind_PrintTaskSettings = 10,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_CameraSettings"]/*' />
    ActivationKind_CameraSettings = 11,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_RestrictedLaunch"]/*' />
    ActivationKind_RestrictedLaunch = 12,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_AppointmentsProvider"]/*' />
    ActivationKind_AppointmentsProvider = 13,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_Contact"]/*' />
    ActivationKind_Contact = 14,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_LockScreenCall"]/*' />
    ActivationKind_LockScreenCall = 15,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_VoiceCommand"]/*' />
    ActivationKind_VoiceCommand = 16,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_LockScreen"]/*' />
    ActivationKind_LockScreen = 17,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_PickerReturned"]/*' />
    ActivationKind_PickerReturned = 1000,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_WalletAction"]/*' />
    ActivationKind_WalletAction = 1001,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_PickFileContinuation"]/*' />
    ActivationKind_PickFileContinuation = 1002,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_PickSaveFileContinuation"]/*' />
    ActivationKind_PickSaveFileContinuation = 1003,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_PickFolderContinuation"]/*' />
    ActivationKind_PickFolderContinuation = 1004,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_WebAuthenticationBrokerContinuation"]/*' />
    ActivationKind_WebAuthenticationBrokerContinuation = 1005,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_WebAccountProvider"]/*' />
    ActivationKind_WebAccountProvider = 1006,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_ComponentUI"]/*' />
    ActivationKind_ComponentUI = 1007,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_ProtocolForResults"]/*' />
    ActivationKind_ProtocolForResults = 1009,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_ToastNotification"]/*' />
    ActivationKind_ToastNotification = 1010,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_Print3DWorkflow"]/*' />
    ActivationKind_Print3DWorkflow = 1011,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_DialReceiver"]/*' />
    ActivationKind_DialReceiver = 1012,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_DevicePairing"]/*' />
    ActivationKind_DevicePairing = 1013,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_UserDataAccountsProvider"]/*' />
    ActivationKind_UserDataAccountsProvider = 1014,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_FilePickerExperience"]/*' />
    ActivationKind_FilePickerExperience = 1015,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_LockScreenComponent"]/*' />
    ActivationKind_LockScreenComponent = 1016,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_ContactPanel"]/*' />
    ActivationKind_ContactPanel = 1017,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_PrintWorkflowForegroundTask"]/*' />
    ActivationKind_PrintWorkflowForegroundTask = 1018,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_GameUIProvider"]/*' />
    ActivationKind_GameUIProvider = 1019,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_StartupTask"]/*' />
    ActivationKind_StartupTask = 1020,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_CommandLineLaunch"]/*' />
    ActivationKind_CommandLineLaunch = 1021,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_BarcodeScannerProvider"]/*' />
    ActivationKind_BarcodeScannerProvider = 1022,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_PrintSupportJobUI"]/*' />
    ActivationKind_PrintSupportJobUI = 1023,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_PrintSupportSettingsUI"]/*' />
    ActivationKind_PrintSupportSettingsUI = 1024,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_PhoneCallActivation"]/*' />
    ActivationKind_PhoneCallActivation = 1025,

    /// <include file='ActivationKind.xml' path='doc/member[@name="ActivationKind.ActivationKind_VpnForeground"]/*' />
    ActivationKind_VpnForeground = 1026,
}
