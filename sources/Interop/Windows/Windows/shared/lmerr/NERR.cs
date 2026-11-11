// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/intsafe.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class NERR
{
    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_Success"]/*' />
    [NativeTypeName("#define NERR_Success 0")]
    public const int NERR_Success = 0;

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BASE"]/*' />
    [NativeTypeName("#define NERR_BASE 2100")]
    public const int NERR_BASE = 2100;

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NetNotStarted"]/*' />
    [NativeTypeName("#define NERR_NetNotStarted (NERR_BASE+2)")]
    public const int NERR_NetNotStarted = (2100 + 2);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UnknownServer"]/*' />
    [NativeTypeName("#define NERR_UnknownServer (NERR_BASE+3)")]
    public const int NERR_UnknownServer = (2100 + 3);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ShareMem"]/*' />
    [NativeTypeName("#define NERR_ShareMem (NERR_BASE+4)")]
    public const int NERR_ShareMem = (2100 + 4);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NoNetworkResource"]/*' />
    [NativeTypeName("#define NERR_NoNetworkResource (NERR_BASE+5)")]
    public const int NERR_NoNetworkResource = (2100 + 5);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RemoteOnly"]/*' />
    [NativeTypeName("#define NERR_RemoteOnly (NERR_BASE+6)")]
    public const int NERR_RemoteOnly = (2100 + 6);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DevNotRedirected"]/*' />
    [NativeTypeName("#define NERR_DevNotRedirected (NERR_BASE+7)")]
    public const int NERR_DevNotRedirected = (2100 + 7);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ServerNotStarted"]/*' />
    [NativeTypeName("#define NERR_ServerNotStarted (NERR_BASE+14)")]
    public const int NERR_ServerNotStarted = (2100 + 14);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ItemNotFound"]/*' />
    [NativeTypeName("#define NERR_ItemNotFound (NERR_BASE+15)")]
    public const int NERR_ItemNotFound = (2100 + 15);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UnknownDevDir"]/*' />
    [NativeTypeName("#define NERR_UnknownDevDir (NERR_BASE+16)")]
    public const int NERR_UnknownDevDir = (2100 + 16);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RedirectedPath"]/*' />
    [NativeTypeName("#define NERR_RedirectedPath (NERR_BASE+17)")]
    public const int NERR_RedirectedPath = (2100 + 17);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DuplicateShare"]/*' />
    [NativeTypeName("#define NERR_DuplicateShare (NERR_BASE+18)")]
    public const int NERR_DuplicateShare = (2100 + 18);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NoRoom"]/*' />
    [NativeTypeName("#define NERR_NoRoom (NERR_BASE+19)")]
    public const int NERR_NoRoom = (2100 + 19);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TooManyItems"]/*' />
    [NativeTypeName("#define NERR_TooManyItems (NERR_BASE+21)")]
    public const int NERR_TooManyItems = (2100 + 21);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_InvalidMaxUsers"]/*' />
    [NativeTypeName("#define NERR_InvalidMaxUsers (NERR_BASE+22)")]
    public const int NERR_InvalidMaxUsers = (2100 + 22);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BufTooSmall"]/*' />
    [NativeTypeName("#define NERR_BufTooSmall (NERR_BASE+23)")]
    public const int NERR_BufTooSmall = (2100 + 23);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RemoteErr"]/*' />
    [NativeTypeName("#define NERR_RemoteErr (NERR_BASE+27)")]
    public const int NERR_RemoteErr = (2100 + 27);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LanmanIniError"]/*' />
    [NativeTypeName("#define NERR_LanmanIniError (NERR_BASE+31)")]
    public const int NERR_LanmanIniError = (2100 + 31);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NetworkError"]/*' />
    [NativeTypeName("#define NERR_NetworkError (NERR_BASE+36)")]
    public const int NERR_NetworkError = (2100 + 36);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_WkstaInconsistentState"]/*' />
    [NativeTypeName("#define NERR_WkstaInconsistentState (NERR_BASE+37)")]
    public const int NERR_WkstaInconsistentState = (2100 + 37);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_WkstaNotStarted"]/*' />
    [NativeTypeName("#define NERR_WkstaNotStarted (NERR_BASE+38)")]
    public const int NERR_WkstaNotStarted = (2100 + 38);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BrowserNotStarted"]/*' />
    [NativeTypeName("#define NERR_BrowserNotStarted (NERR_BASE+39)")]
    public const int NERR_BrowserNotStarted = (2100 + 39);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_InternalError"]/*' />
    [NativeTypeName("#define NERR_InternalError (NERR_BASE+40)")]
    public const int NERR_InternalError = (2100 + 40);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadTransactConfig"]/*' />
    [NativeTypeName("#define NERR_BadTransactConfig (NERR_BASE+41)")]
    public const int NERR_BadTransactConfig = (2100 + 41);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_InvalidAPI"]/*' />
    [NativeTypeName("#define NERR_InvalidAPI (NERR_BASE+42)")]
    public const int NERR_InvalidAPI = (2100 + 42);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadEventName"]/*' />
    [NativeTypeName("#define NERR_BadEventName (NERR_BASE+43)")]
    public const int NERR_BadEventName = (2100 + 43);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DupNameReboot"]/*' />
    [NativeTypeName("#define NERR_DupNameReboot (NERR_BASE+44)")]
    public const int NERR_DupNameReboot = (2100 + 44);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_CfgCompNotFound"]/*' />
    [NativeTypeName("#define NERR_CfgCompNotFound (NERR_BASE+46)")]
    public const int NERR_CfgCompNotFound = (2100 + 46);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_CfgParamNotFound"]/*' />
    [NativeTypeName("#define NERR_CfgParamNotFound (NERR_BASE+47)")]
    public const int NERR_CfgParamNotFound = (2100 + 47);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LineTooLong"]/*' />
    [NativeTypeName("#define NERR_LineTooLong (NERR_BASE+49)")]
    public const int NERR_LineTooLong = (2100 + 49);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_QNotFound"]/*' />
    [NativeTypeName("#define NERR_QNotFound (NERR_BASE+50)")]
    public const int NERR_QNotFound = (2100 + 50);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_JobNotFound"]/*' />
    [NativeTypeName("#define NERR_JobNotFound (NERR_BASE+51)")]
    public const int NERR_JobNotFound = (2100 + 51);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DestNotFound"]/*' />
    [NativeTypeName("#define NERR_DestNotFound (NERR_BASE+52)")]
    public const int NERR_DestNotFound = (2100 + 52);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DestExists"]/*' />
    [NativeTypeName("#define NERR_DestExists (NERR_BASE+53)")]
    public const int NERR_DestExists = (2100 + 53);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_QExists"]/*' />
    [NativeTypeName("#define NERR_QExists (NERR_BASE+54)")]
    public const int NERR_QExists = (2100 + 54);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_QNoRoom"]/*' />
    [NativeTypeName("#define NERR_QNoRoom (NERR_BASE+55)")]
    public const int NERR_QNoRoom = (2100 + 55);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_JobNoRoom"]/*' />
    [NativeTypeName("#define NERR_JobNoRoom (NERR_BASE+56)")]
    public const int NERR_JobNoRoom = (2100 + 56);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DestNoRoom"]/*' />
    [NativeTypeName("#define NERR_DestNoRoom (NERR_BASE+57)")]
    public const int NERR_DestNoRoom = (2100 + 57);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DestIdle"]/*' />
    [NativeTypeName("#define NERR_DestIdle (NERR_BASE+58)")]
    public const int NERR_DestIdle = (2100 + 58);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DestInvalidOp"]/*' />
    [NativeTypeName("#define NERR_DestInvalidOp (NERR_BASE+59)")]
    public const int NERR_DestInvalidOp = (2100 + 59);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ProcNoRespond"]/*' />
    [NativeTypeName("#define NERR_ProcNoRespond (NERR_BASE+60)")]
    public const int NERR_ProcNoRespond = (2100 + 60);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_SpoolerNotLoaded"]/*' />
    [NativeTypeName("#define NERR_SpoolerNotLoaded (NERR_BASE+61)")]
    public const int NERR_SpoolerNotLoaded = (2100 + 61);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DestInvalidState"]/*' />
    [NativeTypeName("#define NERR_DestInvalidState (NERR_BASE+62)")]
    public const int NERR_DestInvalidState = (2100 + 62);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_QInvalidState"]/*' />
    [NativeTypeName("#define NERR_QInvalidState (NERR_BASE+63)")]
    public const int NERR_QInvalidState = (2100 + 63);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_JobInvalidState"]/*' />
    [NativeTypeName("#define NERR_JobInvalidState (NERR_BASE+64)")]
    public const int NERR_JobInvalidState = (2100 + 64);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_SpoolNoMemory"]/*' />
    [NativeTypeName("#define NERR_SpoolNoMemory (NERR_BASE+65)")]
    public const int NERR_SpoolNoMemory = (2100 + 65);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DriverNotFound"]/*' />
    [NativeTypeName("#define NERR_DriverNotFound (NERR_BASE+66)")]
    public const int NERR_DriverNotFound = (2100 + 66);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DataTypeInvalid"]/*' />
    [NativeTypeName("#define NERR_DataTypeInvalid (NERR_BASE+67)")]
    public const int NERR_DataTypeInvalid = (2100 + 67);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ProcNotFound"]/*' />
    [NativeTypeName("#define NERR_ProcNotFound (NERR_BASE+68)")]
    public const int NERR_ProcNotFound = (2100 + 68);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ServiceTableLocked"]/*' />
    [NativeTypeName("#define NERR_ServiceTableLocked (NERR_BASE+80)")]
    public const int NERR_ServiceTableLocked = (2100 + 80);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ServiceTableFull"]/*' />
    [NativeTypeName("#define NERR_ServiceTableFull (NERR_BASE+81)")]
    public const int NERR_ServiceTableFull = (2100 + 81);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ServiceInstalled"]/*' />
    [NativeTypeName("#define NERR_ServiceInstalled (NERR_BASE+82)")]
    public const int NERR_ServiceInstalled = (2100 + 82);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ServiceEntryLocked"]/*' />
    [NativeTypeName("#define NERR_ServiceEntryLocked (NERR_BASE+83)")]
    public const int NERR_ServiceEntryLocked = (2100 + 83);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ServiceNotInstalled"]/*' />
    [NativeTypeName("#define NERR_ServiceNotInstalled (NERR_BASE+84)")]
    public const int NERR_ServiceNotInstalled = (2100 + 84);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadServiceName"]/*' />
    [NativeTypeName("#define NERR_BadServiceName (NERR_BASE+85)")]
    public const int NERR_BadServiceName = (2100 + 85);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ServiceCtlTimeout"]/*' />
    [NativeTypeName("#define NERR_ServiceCtlTimeout (NERR_BASE+86)")]
    public const int NERR_ServiceCtlTimeout = (2100 + 86);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ServiceCtlBusy"]/*' />
    [NativeTypeName("#define NERR_ServiceCtlBusy (NERR_BASE+87)")]
    public const int NERR_ServiceCtlBusy = (2100 + 87);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadServiceProgName"]/*' />
    [NativeTypeName("#define NERR_BadServiceProgName (NERR_BASE+88)")]
    public const int NERR_BadServiceProgName = (2100 + 88);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ServiceNotCtrl"]/*' />
    [NativeTypeName("#define NERR_ServiceNotCtrl (NERR_BASE+89)")]
    public const int NERR_ServiceNotCtrl = (2100 + 89);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ServiceKillProc"]/*' />
    [NativeTypeName("#define NERR_ServiceKillProc (NERR_BASE+90)")]
    public const int NERR_ServiceKillProc = (2100 + 90);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ServiceCtlNotValid"]/*' />
    [NativeTypeName("#define NERR_ServiceCtlNotValid (NERR_BASE+91)")]
    public const int NERR_ServiceCtlNotValid = (2100 + 91);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NotInDispatchTbl"]/*' />
    [NativeTypeName("#define NERR_NotInDispatchTbl (NERR_BASE+92)")]
    public const int NERR_NotInDispatchTbl = (2100 + 92);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadControlRecv"]/*' />
    [NativeTypeName("#define NERR_BadControlRecv (NERR_BASE+93)")]
    public const int NERR_BadControlRecv = (2100 + 93);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ServiceNotStarting"]/*' />
    [NativeTypeName("#define NERR_ServiceNotStarting (NERR_BASE+94)")]
    public const int NERR_ServiceNotStarting = (2100 + 94);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_AlreadyLoggedOn"]/*' />
    [NativeTypeName("#define NERR_AlreadyLoggedOn (NERR_BASE+100)")]
    public const int NERR_AlreadyLoggedOn = (2100 + 100);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NotLoggedOn"]/*' />
    [NativeTypeName("#define NERR_NotLoggedOn (NERR_BASE+101)")]
    public const int NERR_NotLoggedOn = (2100 + 101);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadUsername"]/*' />
    [NativeTypeName("#define NERR_BadUsername (NERR_BASE+102)")]
    public const int NERR_BadUsername = (2100 + 102);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadPassword"]/*' />
    [NativeTypeName("#define NERR_BadPassword (NERR_BASE+103)")]
    public const int NERR_BadPassword = (2100 + 103);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UnableToAddName_W"]/*' />
    [NativeTypeName("#define NERR_UnableToAddName_W (NERR_BASE+104)")]
    public const int NERR_UnableToAddName_W = (2100 + 104);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UnableToAddName_F"]/*' />
    [NativeTypeName("#define NERR_UnableToAddName_F (NERR_BASE+105)")]
    public const int NERR_UnableToAddName_F = (2100 + 105);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UnableToDelName_W"]/*' />
    [NativeTypeName("#define NERR_UnableToDelName_W (NERR_BASE+106)")]
    public const int NERR_UnableToDelName_W = (2100 + 106);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UnableToDelName_F"]/*' />
    [NativeTypeName("#define NERR_UnableToDelName_F (NERR_BASE+107)")]
    public const int NERR_UnableToDelName_F = (2100 + 107);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LogonsPaused"]/*' />
    [NativeTypeName("#define NERR_LogonsPaused (NERR_BASE+109)")]
    public const int NERR_LogonsPaused = (2100 + 109);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LogonServerConflict"]/*' />
    [NativeTypeName("#define NERR_LogonServerConflict (NERR_BASE+110)")]
    public const int NERR_LogonServerConflict = (2100 + 110);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LogonNoUserPath"]/*' />
    [NativeTypeName("#define NERR_LogonNoUserPath (NERR_BASE+111)")]
    public const int NERR_LogonNoUserPath = (2100 + 111);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LogonScriptError"]/*' />
    [NativeTypeName("#define NERR_LogonScriptError (NERR_BASE+112)")]
    public const int NERR_LogonScriptError = (2100 + 112);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_StandaloneLogon"]/*' />
    [NativeTypeName("#define NERR_StandaloneLogon (NERR_BASE+114)")]
    public const int NERR_StandaloneLogon = (2100 + 114);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LogonServerNotFound"]/*' />
    [NativeTypeName("#define NERR_LogonServerNotFound (NERR_BASE+115)")]
    public const int NERR_LogonServerNotFound = (2100 + 115);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LogonDomainExists"]/*' />
    [NativeTypeName("#define NERR_LogonDomainExists (NERR_BASE+116)")]
    public const int NERR_LogonDomainExists = (2100 + 116);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NonValidatedLogon"]/*' />
    [NativeTypeName("#define NERR_NonValidatedLogon (NERR_BASE+117)")]
    public const int NERR_NonValidatedLogon = (2100 + 117);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ACFNotFound"]/*' />
    [NativeTypeName("#define NERR_ACFNotFound (NERR_BASE+119)")]
    public const int NERR_ACFNotFound = (2100 + 119);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_GroupNotFound"]/*' />
    [NativeTypeName("#define NERR_GroupNotFound (NERR_BASE+120)")]
    public const int NERR_GroupNotFound = (2100 + 120);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UserNotFound"]/*' />
    [NativeTypeName("#define NERR_UserNotFound (NERR_BASE+121)")]
    public const int NERR_UserNotFound = (2100 + 121);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ResourceNotFound"]/*' />
    [NativeTypeName("#define NERR_ResourceNotFound (NERR_BASE+122)")]
    public const int NERR_ResourceNotFound = (2100 + 122);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_GroupExists"]/*' />
    [NativeTypeName("#define NERR_GroupExists (NERR_BASE+123)")]
    public const int NERR_GroupExists = (2100 + 123);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UserExists"]/*' />
    [NativeTypeName("#define NERR_UserExists (NERR_BASE+124)")]
    public const int NERR_UserExists = (2100 + 124);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ResourceExists"]/*' />
    [NativeTypeName("#define NERR_ResourceExists (NERR_BASE+125)")]
    public const int NERR_ResourceExists = (2100 + 125);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NotPrimary"]/*' />
    [NativeTypeName("#define NERR_NotPrimary (NERR_BASE+126)")]
    public const int NERR_NotPrimary = (2100 + 126);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ACFNotLoaded"]/*' />
    [NativeTypeName("#define NERR_ACFNotLoaded (NERR_BASE+127)")]
    public const int NERR_ACFNotLoaded = (2100 + 127);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ACFNoRoom"]/*' />
    [NativeTypeName("#define NERR_ACFNoRoom (NERR_BASE+128)")]
    public const int NERR_ACFNoRoom = (2100 + 128);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ACFFileIOFail"]/*' />
    [NativeTypeName("#define NERR_ACFFileIOFail (NERR_BASE+129)")]
    public const int NERR_ACFFileIOFail = (2100 + 129);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ACFTooManyLists"]/*' />
    [NativeTypeName("#define NERR_ACFTooManyLists (NERR_BASE+130)")]
    public const int NERR_ACFTooManyLists = (2100 + 130);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UserLogon"]/*' />
    [NativeTypeName("#define NERR_UserLogon (NERR_BASE+131)")]
    public const int NERR_UserLogon = (2100 + 131);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ACFNoParent"]/*' />
    [NativeTypeName("#define NERR_ACFNoParent (NERR_BASE+132)")]
    public const int NERR_ACFNoParent = (2100 + 132);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_CanNotGrowSegment"]/*' />
    [NativeTypeName("#define NERR_CanNotGrowSegment (NERR_BASE+133)")]
    public const int NERR_CanNotGrowSegment = (2100 + 133);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_SpeGroupOp"]/*' />
    [NativeTypeName("#define NERR_SpeGroupOp (NERR_BASE+134)")]
    public const int NERR_SpeGroupOp = (2100 + 134);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NotInCache"]/*' />
    [NativeTypeName("#define NERR_NotInCache (NERR_BASE+135)")]
    public const int NERR_NotInCache = (2100 + 135);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UserInGroup"]/*' />
    [NativeTypeName("#define NERR_UserInGroup (NERR_BASE+136)")]
    public const int NERR_UserInGroup = (2100 + 136);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UserNotInGroup"]/*' />
    [NativeTypeName("#define NERR_UserNotInGroup (NERR_BASE+137)")]
    public const int NERR_UserNotInGroup = (2100 + 137);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_AccountUndefined"]/*' />
    [NativeTypeName("#define NERR_AccountUndefined (NERR_BASE+138)")]
    public const int NERR_AccountUndefined = (2100 + 138);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_AccountExpired"]/*' />
    [NativeTypeName("#define NERR_AccountExpired (NERR_BASE+139)")]
    public const int NERR_AccountExpired = (2100 + 139);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_InvalidWorkstation"]/*' />
    [NativeTypeName("#define NERR_InvalidWorkstation (NERR_BASE+140)")]
    public const int NERR_InvalidWorkstation = (2100 + 140);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_InvalidLogonHours"]/*' />
    [NativeTypeName("#define NERR_InvalidLogonHours (NERR_BASE+141)")]
    public const int NERR_InvalidLogonHours = (2100 + 141);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_PasswordExpired"]/*' />
    [NativeTypeName("#define NERR_PasswordExpired (NERR_BASE+142)")]
    public const int NERR_PasswordExpired = (2100 + 142);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_PasswordCantChange"]/*' />
    [NativeTypeName("#define NERR_PasswordCantChange (NERR_BASE+143)")]
    public const int NERR_PasswordCantChange = (2100 + 143);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_PasswordHistConflict"]/*' />
    [NativeTypeName("#define NERR_PasswordHistConflict (NERR_BASE+144)")]
    public const int NERR_PasswordHistConflict = (2100 + 144);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_PasswordTooShort"]/*' />
    [NativeTypeName("#define NERR_PasswordTooShort (NERR_BASE+145)")]
    public const int NERR_PasswordTooShort = (2100 + 145);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_PasswordTooRecent"]/*' />
    [NativeTypeName("#define NERR_PasswordTooRecent (NERR_BASE+146)")]
    public const int NERR_PasswordTooRecent = (2100 + 146);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_InvalidDatabase"]/*' />
    [NativeTypeName("#define NERR_InvalidDatabase (NERR_BASE+147)")]
    public const int NERR_InvalidDatabase = (2100 + 147);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DatabaseUpToDate"]/*' />
    [NativeTypeName("#define NERR_DatabaseUpToDate (NERR_BASE+148)")]
    public const int NERR_DatabaseUpToDate = (2100 + 148);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_SyncRequired"]/*' />
    [NativeTypeName("#define NERR_SyncRequired (NERR_BASE+149)")]
    public const int NERR_SyncRequired = (2100 + 149);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UseNotFound"]/*' />
    [NativeTypeName("#define NERR_UseNotFound (NERR_BASE+150)")]
    public const int NERR_UseNotFound = (2100 + 150);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadAsgType"]/*' />
    [NativeTypeName("#define NERR_BadAsgType (NERR_BASE+151)")]
    public const int NERR_BadAsgType = (2100 + 151);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DeviceIsShared"]/*' />
    [NativeTypeName("#define NERR_DeviceIsShared (NERR_BASE+152)")]
    public const int NERR_DeviceIsShared = (2100 + 152);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_SameAsComputerName"]/*' />
    [NativeTypeName("#define NERR_SameAsComputerName (NERR_BASE+153)")]
    public const int NERR_SameAsComputerName = (2100 + 153);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NoComputerName"]/*' />
    [NativeTypeName("#define NERR_NoComputerName (NERR_BASE+170)")]
    public const int NERR_NoComputerName = (2100 + 170);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_MsgAlreadyStarted"]/*' />
    [NativeTypeName("#define NERR_MsgAlreadyStarted (NERR_BASE+171)")]
    public const int NERR_MsgAlreadyStarted = (2100 + 171);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_MsgInitFailed"]/*' />
    [NativeTypeName("#define NERR_MsgInitFailed (NERR_BASE+172)")]
    public const int NERR_MsgInitFailed = (2100 + 172);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NameNotFound"]/*' />
    [NativeTypeName("#define NERR_NameNotFound (NERR_BASE+173)")]
    public const int NERR_NameNotFound = (2100 + 173);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_AlreadyForwarded"]/*' />
    [NativeTypeName("#define NERR_AlreadyForwarded (NERR_BASE+174)")]
    public const int NERR_AlreadyForwarded = (2100 + 174);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_AddForwarded"]/*' />
    [NativeTypeName("#define NERR_AddForwarded (NERR_BASE+175)")]
    public const int NERR_AddForwarded = (2100 + 175);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_AlreadyExists"]/*' />
    [NativeTypeName("#define NERR_AlreadyExists (NERR_BASE+176)")]
    public const int NERR_AlreadyExists = (2100 + 176);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TooManyNames"]/*' />
    [NativeTypeName("#define NERR_TooManyNames (NERR_BASE+177)")]
    public const int NERR_TooManyNames = (2100 + 177);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DelComputerName"]/*' />
    [NativeTypeName("#define NERR_DelComputerName (NERR_BASE+178)")]
    public const int NERR_DelComputerName = (2100 + 178);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LocalForward"]/*' />
    [NativeTypeName("#define NERR_LocalForward (NERR_BASE+179)")]
    public const int NERR_LocalForward = (2100 + 179);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_GrpMsgProcessor"]/*' />
    [NativeTypeName("#define NERR_GrpMsgProcessor (NERR_BASE+180)")]
    public const int NERR_GrpMsgProcessor = (2100 + 180);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_PausedRemote"]/*' />
    [NativeTypeName("#define NERR_PausedRemote (NERR_BASE+181)")]
    public const int NERR_PausedRemote = (2100 + 181);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadReceive"]/*' />
    [NativeTypeName("#define NERR_BadReceive (NERR_BASE+182)")]
    public const int NERR_BadReceive = (2100 + 182);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NameInUse"]/*' />
    [NativeTypeName("#define NERR_NameInUse (NERR_BASE+183)")]
    public const int NERR_NameInUse = (2100 + 183);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_MsgNotStarted"]/*' />
    [NativeTypeName("#define NERR_MsgNotStarted (NERR_BASE+184)")]
    public const int NERR_MsgNotStarted = (2100 + 184);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NotLocalName"]/*' />
    [NativeTypeName("#define NERR_NotLocalName (NERR_BASE+185)")]
    public const int NERR_NotLocalName = (2100 + 185);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NoForwardName"]/*' />
    [NativeTypeName("#define NERR_NoForwardName (NERR_BASE+186)")]
    public const int NERR_NoForwardName = (2100 + 186);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RemoteFull"]/*' />
    [NativeTypeName("#define NERR_RemoteFull (NERR_BASE+187)")]
    public const int NERR_RemoteFull = (2100 + 187);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NameNotForwarded"]/*' />
    [NativeTypeName("#define NERR_NameNotForwarded (NERR_BASE+188)")]
    public const int NERR_NameNotForwarded = (2100 + 188);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TruncatedBroadcast"]/*' />
    [NativeTypeName("#define NERR_TruncatedBroadcast (NERR_BASE+189)")]
    public const int NERR_TruncatedBroadcast = (2100 + 189);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_InvalidDevice"]/*' />
    [NativeTypeName("#define NERR_InvalidDevice (NERR_BASE+194)")]
    public const int NERR_InvalidDevice = (2100 + 194);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_WriteFault"]/*' />
    [NativeTypeName("#define NERR_WriteFault (NERR_BASE+195)")]
    public const int NERR_WriteFault = (2100 + 195);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DuplicateName"]/*' />
    [NativeTypeName("#define NERR_DuplicateName (NERR_BASE+197)")]
    public const int NERR_DuplicateName = (2100 + 197);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DeleteLater"]/*' />
    [NativeTypeName("#define NERR_DeleteLater (NERR_BASE+198)")]
    public const int NERR_DeleteLater = (2100 + 198);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_IncompleteDel"]/*' />
    [NativeTypeName("#define NERR_IncompleteDel (NERR_BASE+199)")]
    public const int NERR_IncompleteDel = (2100 + 199);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_MultipleNets"]/*' />
    [NativeTypeName("#define NERR_MultipleNets (NERR_BASE+200)")]
    public const int NERR_MultipleNets = (2100 + 200);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NetNameNotFound"]/*' />
    [NativeTypeName("#define NERR_NetNameNotFound (NERR_BASE+210)")]
    public const int NERR_NetNameNotFound = (2100 + 210);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DeviceNotShared"]/*' />
    [NativeTypeName("#define NERR_DeviceNotShared (NERR_BASE+211)")]
    public const int NERR_DeviceNotShared = (2100 + 211);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ClientNameNotFound"]/*' />
    [NativeTypeName("#define NERR_ClientNameNotFound (NERR_BASE+212)")]
    public const int NERR_ClientNameNotFound = (2100 + 212);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_FileIdNotFound"]/*' />
    [NativeTypeName("#define NERR_FileIdNotFound (NERR_BASE+214)")]
    public const int NERR_FileIdNotFound = (2100 + 214);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ExecFailure"]/*' />
    [NativeTypeName("#define NERR_ExecFailure (NERR_BASE+215)")]
    public const int NERR_ExecFailure = (2100 + 215);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TmpFile"]/*' />
    [NativeTypeName("#define NERR_TmpFile (NERR_BASE+216)")]
    public const int NERR_TmpFile = (2100 + 216);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TooMuchData"]/*' />
    [NativeTypeName("#define NERR_TooMuchData (NERR_BASE+217)")]
    public const int NERR_TooMuchData = (2100 + 217);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DeviceShareConflict"]/*' />
    [NativeTypeName("#define NERR_DeviceShareConflict (NERR_BASE+218)")]
    public const int NERR_DeviceShareConflict = (2100 + 218);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BrowserTableIncomplete"]/*' />
    [NativeTypeName("#define NERR_BrowserTableIncomplete (NERR_BASE+219)")]
    public const int NERR_BrowserTableIncomplete = (2100 + 219);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NotLocalDomain"]/*' />
    [NativeTypeName("#define NERR_NotLocalDomain (NERR_BASE+220)")]
    public const int NERR_NotLocalDomain = (2100 + 220);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_IsDfsShare"]/*' />
    [NativeTypeName("#define NERR_IsDfsShare (NERR_BASE+221)")]
    public const int NERR_IsDfsShare = (2100 + 221);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DevInvalidOpCode"]/*' />
    [NativeTypeName("#define NERR_DevInvalidOpCode (NERR_BASE+231)")]
    public const int NERR_DevInvalidOpCode = (2100 + 231);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DevNotFound"]/*' />
    [NativeTypeName("#define NERR_DevNotFound (NERR_BASE+232)")]
    public const int NERR_DevNotFound = (2100 + 232);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DevNotOpen"]/*' />
    [NativeTypeName("#define NERR_DevNotOpen (NERR_BASE+233)")]
    public const int NERR_DevNotOpen = (2100 + 233);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadQueueDevString"]/*' />
    [NativeTypeName("#define NERR_BadQueueDevString (NERR_BASE+234)")]
    public const int NERR_BadQueueDevString = (2100 + 234);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadQueuePriority"]/*' />
    [NativeTypeName("#define NERR_BadQueuePriority (NERR_BASE+235)")]
    public const int NERR_BadQueuePriority = (2100 + 235);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NoCommDevs"]/*' />
    [NativeTypeName("#define NERR_NoCommDevs (NERR_BASE+237)")]
    public const int NERR_NoCommDevs = (2100 + 237);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_QueueNotFound"]/*' />
    [NativeTypeName("#define NERR_QueueNotFound (NERR_BASE+238)")]
    public const int NERR_QueueNotFound = (2100 + 238);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadDevString"]/*' />
    [NativeTypeName("#define NERR_BadDevString (NERR_BASE+240)")]
    public const int NERR_BadDevString = (2100 + 240);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadDev"]/*' />
    [NativeTypeName("#define NERR_BadDev (NERR_BASE+241)")]
    public const int NERR_BadDev = (2100 + 241);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_InUseBySpooler"]/*' />
    [NativeTypeName("#define NERR_InUseBySpooler (NERR_BASE+242)")]
    public const int NERR_InUseBySpooler = (2100 + 242);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_CommDevInUse"]/*' />
    [NativeTypeName("#define NERR_CommDevInUse (NERR_BASE+243)")]
    public const int NERR_CommDevInUse = (2100 + 243);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_InvalidComputer"]/*' />
    [NativeTypeName("#define NERR_InvalidComputer (NERR_BASE+251)")]
    public const int NERR_InvalidComputer = (2100 + 251);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_MaxLenExceeded"]/*' />
    [NativeTypeName("#define NERR_MaxLenExceeded (NERR_BASE+254)")]
    public const int NERR_MaxLenExceeded = (2100 + 254);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadComponent"]/*' />
    [NativeTypeName("#define NERR_BadComponent (NERR_BASE+256)")]
    public const int NERR_BadComponent = (2100 + 256);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_CantType"]/*' />
    [NativeTypeName("#define NERR_CantType (NERR_BASE+257)")]
    public const int NERR_CantType = (2100 + 257);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TooManyEntries"]/*' />
    [NativeTypeName("#define NERR_TooManyEntries (NERR_BASE+262)")]
    public const int NERR_TooManyEntries = (2100 + 262);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ProfileFileTooBig"]/*' />
    [NativeTypeName("#define NERR_ProfileFileTooBig (NERR_BASE+270)")]
    public const int NERR_ProfileFileTooBig = (2100 + 270);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ProfileOffset"]/*' />
    [NativeTypeName("#define NERR_ProfileOffset (NERR_BASE+271)")]
    public const int NERR_ProfileOffset = (2100 + 271);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ProfileCleanup"]/*' />
    [NativeTypeName("#define NERR_ProfileCleanup (NERR_BASE+272)")]
    public const int NERR_ProfileCleanup = (2100 + 272);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ProfileUnknownCmd"]/*' />
    [NativeTypeName("#define NERR_ProfileUnknownCmd (NERR_BASE+273)")]
    public const int NERR_ProfileUnknownCmd = (2100 + 273);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ProfileLoadErr"]/*' />
    [NativeTypeName("#define NERR_ProfileLoadErr (NERR_BASE+274)")]
    public const int NERR_ProfileLoadErr = (2100 + 274);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ProfileSaveErr"]/*' />
    [NativeTypeName("#define NERR_ProfileSaveErr (NERR_BASE+275)")]
    public const int NERR_ProfileSaveErr = (2100 + 275);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LogOverflow"]/*' />
    [NativeTypeName("#define NERR_LogOverflow (NERR_BASE+277)")]
    public const int NERR_LogOverflow = (2100 + 277);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LogFileChanged"]/*' />
    [NativeTypeName("#define NERR_LogFileChanged (NERR_BASE+278)")]
    public const int NERR_LogFileChanged = (2100 + 278);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LogFileCorrupt"]/*' />
    [NativeTypeName("#define NERR_LogFileCorrupt (NERR_BASE+279)")]
    public const int NERR_LogFileCorrupt = (2100 + 279);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_SourceIsDir"]/*' />
    [NativeTypeName("#define NERR_SourceIsDir (NERR_BASE+280)")]
    public const int NERR_SourceIsDir = (2100 + 280);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadSource"]/*' />
    [NativeTypeName("#define NERR_BadSource (NERR_BASE+281)")]
    public const int NERR_BadSource = (2100 + 281);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadDest"]/*' />
    [NativeTypeName("#define NERR_BadDest (NERR_BASE+282)")]
    public const int NERR_BadDest = (2100 + 282);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DifferentServers"]/*' />
    [NativeTypeName("#define NERR_DifferentServers (NERR_BASE+283)")]
    public const int NERR_DifferentServers = (2100 + 283);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RunSrvPaused"]/*' />
    [NativeTypeName("#define NERR_RunSrvPaused (NERR_BASE+285)")]
    public const int NERR_RunSrvPaused = (2100 + 285);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ErrCommRunSrv"]/*' />
    [NativeTypeName("#define NERR_ErrCommRunSrv (NERR_BASE+289)")]
    public const int NERR_ErrCommRunSrv = (2100 + 289);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ErrorExecingGhost"]/*' />
    [NativeTypeName("#define NERR_ErrorExecingGhost (NERR_BASE+291)")]
    public const int NERR_ErrorExecingGhost = (2100 + 291);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ShareNotFound"]/*' />
    [NativeTypeName("#define NERR_ShareNotFound (NERR_BASE+292)")]
    public const int NERR_ShareNotFound = (2100 + 292);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_InvalidLana"]/*' />
    [NativeTypeName("#define NERR_InvalidLana (NERR_BASE+300)")]
    public const int NERR_InvalidLana = (2100 + 300);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_OpenFiles"]/*' />
    [NativeTypeName("#define NERR_OpenFiles (NERR_BASE+301)")]
    public const int NERR_OpenFiles = (2100 + 301);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ActiveConns"]/*' />
    [NativeTypeName("#define NERR_ActiveConns (NERR_BASE+302)")]
    public const int NERR_ActiveConns = (2100 + 302);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadPasswordCore"]/*' />
    [NativeTypeName("#define NERR_BadPasswordCore (NERR_BASE+303)")]
    public const int NERR_BadPasswordCore = (2100 + 303);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DevInUse"]/*' />
    [NativeTypeName("#define NERR_DevInUse (NERR_BASE+304)")]
    public const int NERR_DevInUse = (2100 + 304);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LocalDrive"]/*' />
    [NativeTypeName("#define NERR_LocalDrive (NERR_BASE+305)")]
    public const int NERR_LocalDrive = (2100 + 305);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_AlertExists"]/*' />
    [NativeTypeName("#define NERR_AlertExists (NERR_BASE+330)")]
    public const int NERR_AlertExists = (2100 + 330);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TooManyAlerts"]/*' />
    [NativeTypeName("#define NERR_TooManyAlerts (NERR_BASE+331)")]
    public const int NERR_TooManyAlerts = (2100 + 331);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NoSuchAlert"]/*' />
    [NativeTypeName("#define NERR_NoSuchAlert (NERR_BASE+332)")]
    public const int NERR_NoSuchAlert = (2100 + 332);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadRecipient"]/*' />
    [NativeTypeName("#define NERR_BadRecipient (NERR_BASE+333)")]
    public const int NERR_BadRecipient = (2100 + 333);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_AcctLimitExceeded"]/*' />
    [NativeTypeName("#define NERR_AcctLimitExceeded (NERR_BASE+334)")]
    public const int NERR_AcctLimitExceeded = (2100 + 334);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_InvalidLogSeek"]/*' />
    [NativeTypeName("#define NERR_InvalidLogSeek (NERR_BASE+340)")]
    public const int NERR_InvalidLogSeek = (2100 + 340);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadUasConfig"]/*' />
    [NativeTypeName("#define NERR_BadUasConfig (NERR_BASE+350)")]
    public const int NERR_BadUasConfig = (2100 + 350);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_InvalidUASOp"]/*' />
    [NativeTypeName("#define NERR_InvalidUASOp (NERR_BASE+351)")]
    public const int NERR_InvalidUASOp = (2100 + 351);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LastAdmin"]/*' />
    [NativeTypeName("#define NERR_LastAdmin (NERR_BASE+352)")]
    public const int NERR_LastAdmin = (2100 + 352);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DCNotFound"]/*' />
    [NativeTypeName("#define NERR_DCNotFound (NERR_BASE+353)")]
    public const int NERR_DCNotFound = (2100 + 353);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LogonTrackingError"]/*' />
    [NativeTypeName("#define NERR_LogonTrackingError (NERR_BASE+354)")]
    public const int NERR_LogonTrackingError = (2100 + 354);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NetlogonNotStarted"]/*' />
    [NativeTypeName("#define NERR_NetlogonNotStarted (NERR_BASE+355)")]
    public const int NERR_NetlogonNotStarted = (2100 + 355);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_CanNotGrowUASFile"]/*' />
    [NativeTypeName("#define NERR_CanNotGrowUASFile (NERR_BASE+356)")]
    public const int NERR_CanNotGrowUASFile = (2100 + 356);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TimeDiffAtDC"]/*' />
    [NativeTypeName("#define NERR_TimeDiffAtDC (NERR_BASE+357)")]
    public const int NERR_TimeDiffAtDC = (2100 + 357);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_PasswordMismatch"]/*' />
    [NativeTypeName("#define NERR_PasswordMismatch (NERR_BASE+358)")]
    public const int NERR_PasswordMismatch = (2100 + 358);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NoSuchServer"]/*' />
    [NativeTypeName("#define NERR_NoSuchServer (NERR_BASE+360)")]
    public const int NERR_NoSuchServer = (2100 + 360);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NoSuchSession"]/*' />
    [NativeTypeName("#define NERR_NoSuchSession (NERR_BASE+361)")]
    public const int NERR_NoSuchSession = (2100 + 361);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NoSuchConnection"]/*' />
    [NativeTypeName("#define NERR_NoSuchConnection (NERR_BASE+362)")]
    public const int NERR_NoSuchConnection = (2100 + 362);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TooManyServers"]/*' />
    [NativeTypeName("#define NERR_TooManyServers (NERR_BASE+363)")]
    public const int NERR_TooManyServers = (2100 + 363);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TooManySessions"]/*' />
    [NativeTypeName("#define NERR_TooManySessions (NERR_BASE+364)")]
    public const int NERR_TooManySessions = (2100 + 364);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TooManyConnections"]/*' />
    [NativeTypeName("#define NERR_TooManyConnections (NERR_BASE+365)")]
    public const int NERR_TooManyConnections = (2100 + 365);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TooManyFiles"]/*' />
    [NativeTypeName("#define NERR_TooManyFiles (NERR_BASE+366)")]
    public const int NERR_TooManyFiles = (2100 + 366);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NoAlternateServers"]/*' />
    [NativeTypeName("#define NERR_NoAlternateServers (NERR_BASE+367)")]
    public const int NERR_NoAlternateServers = (2100 + 367);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TryDownLevel"]/*' />
    [NativeTypeName("#define NERR_TryDownLevel (NERR_BASE+370)")]
    public const int NERR_TryDownLevel = (2100 + 370);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UPSDriverNotStarted"]/*' />
    [NativeTypeName("#define NERR_UPSDriverNotStarted (NERR_BASE+380)")]
    public const int NERR_UPSDriverNotStarted = (2100 + 380);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UPSInvalidConfig"]/*' />
    [NativeTypeName("#define NERR_UPSInvalidConfig (NERR_BASE+381)")]
    public const int NERR_UPSInvalidConfig = (2100 + 381);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UPSInvalidCommPort"]/*' />
    [NativeTypeName("#define NERR_UPSInvalidCommPort (NERR_BASE+382)")]
    public const int NERR_UPSInvalidCommPort = (2100 + 382);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UPSSignalAsserted"]/*' />
    [NativeTypeName("#define NERR_UPSSignalAsserted (NERR_BASE+383)")]
    public const int NERR_UPSSignalAsserted = (2100 + 383);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_UPSShutdownFailed"]/*' />
    [NativeTypeName("#define NERR_UPSShutdownFailed (NERR_BASE+384)")]
    public const int NERR_UPSShutdownFailed = (2100 + 384);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadDosRetCode"]/*' />
    [NativeTypeName("#define NERR_BadDosRetCode (NERR_BASE+400)")]
    public const int NERR_BadDosRetCode = (2100 + 400);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ProgNeedsExtraMem"]/*' />
    [NativeTypeName("#define NERR_ProgNeedsExtraMem (NERR_BASE+401)")]
    public const int NERR_ProgNeedsExtraMem = (2100 + 401);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadDosFunction"]/*' />
    [NativeTypeName("#define NERR_BadDosFunction (NERR_BASE+402)")]
    public const int NERR_BadDosFunction = (2100 + 402);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RemoteBootFailed"]/*' />
    [NativeTypeName("#define NERR_RemoteBootFailed (NERR_BASE+403)")]
    public const int NERR_RemoteBootFailed = (2100 + 403);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadFileCheckSum"]/*' />
    [NativeTypeName("#define NERR_BadFileCheckSum (NERR_BASE+404)")]
    public const int NERR_BadFileCheckSum = (2100 + 404);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NoRplBootSystem"]/*' />
    [NativeTypeName("#define NERR_NoRplBootSystem (NERR_BASE+405)")]
    public const int NERR_NoRplBootSystem = (2100 + 405);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplLoadrNetBiosErr"]/*' />
    [NativeTypeName("#define NERR_RplLoadrNetBiosErr (NERR_BASE+406)")]
    public const int NERR_RplLoadrNetBiosErr = (2100 + 406);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplLoadrDiskErr"]/*' />
    [NativeTypeName("#define NERR_RplLoadrDiskErr (NERR_BASE+407)")]
    public const int NERR_RplLoadrDiskErr = (2100 + 407);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ImageParamErr"]/*' />
    [NativeTypeName("#define NERR_ImageParamErr (NERR_BASE+408)")]
    public const int NERR_ImageParamErr = (2100 + 408);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TooManyImageParams"]/*' />
    [NativeTypeName("#define NERR_TooManyImageParams (NERR_BASE+409)")]
    public const int NERR_TooManyImageParams = (2100 + 409);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NonDosFloppyUsed"]/*' />
    [NativeTypeName("#define NERR_NonDosFloppyUsed (NERR_BASE+410)")]
    public const int NERR_NonDosFloppyUsed = (2100 + 410);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplBootRestart"]/*' />
    [NativeTypeName("#define NERR_RplBootRestart (NERR_BASE+411)")]
    public const int NERR_RplBootRestart = (2100 + 411);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplSrvrCallFailed"]/*' />
    [NativeTypeName("#define NERR_RplSrvrCallFailed (NERR_BASE+412)")]
    public const int NERR_RplSrvrCallFailed = (2100 + 412);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_CantConnectRplSrvr"]/*' />
    [NativeTypeName("#define NERR_CantConnectRplSrvr (NERR_BASE+413)")]
    public const int NERR_CantConnectRplSrvr = (2100 + 413);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_CantOpenImageFile"]/*' />
    [NativeTypeName("#define NERR_CantOpenImageFile (NERR_BASE+414)")]
    public const int NERR_CantOpenImageFile = (2100 + 414);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_CallingRplSrvr"]/*' />
    [NativeTypeName("#define NERR_CallingRplSrvr (NERR_BASE+415)")]
    public const int NERR_CallingRplSrvr = (2100 + 415);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_StartingRplBoot"]/*' />
    [NativeTypeName("#define NERR_StartingRplBoot (NERR_BASE+416)")]
    public const int NERR_StartingRplBoot = (2100 + 416);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplBootServiceTerm"]/*' />
    [NativeTypeName("#define NERR_RplBootServiceTerm (NERR_BASE+417)")]
    public const int NERR_RplBootServiceTerm = (2100 + 417);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplBootStartFailed"]/*' />
    [NativeTypeName("#define NERR_RplBootStartFailed (NERR_BASE+418)")]
    public const int NERR_RplBootStartFailed = (2100 + 418);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RPL_CONNECTED"]/*' />
    [NativeTypeName("#define NERR_RPL_CONNECTED (NERR_BASE+419)")]
    public const int NERR_RPL_CONNECTED = (2100 + 419);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BrowserConfiguredToNotRun"]/*' />
    [NativeTypeName("#define NERR_BrowserConfiguredToNotRun (NERR_BASE+450)")]
    public const int NERR_BrowserConfiguredToNotRun = (2100 + 450);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplNoAdaptersStarted"]/*' />
    [NativeTypeName("#define NERR_RplNoAdaptersStarted (NERR_BASE+510)")]
    public const int NERR_RplNoAdaptersStarted = (2100 + 510);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplBadRegistry"]/*' />
    [NativeTypeName("#define NERR_RplBadRegistry (NERR_BASE+511)")]
    public const int NERR_RplBadRegistry = (2100 + 511);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplBadDatabase"]/*' />
    [NativeTypeName("#define NERR_RplBadDatabase (NERR_BASE+512)")]
    public const int NERR_RplBadDatabase = (2100 + 512);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplRplfilesShare"]/*' />
    [NativeTypeName("#define NERR_RplRplfilesShare (NERR_BASE+513)")]
    public const int NERR_RplRplfilesShare = (2100 + 513);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplNotRplServer"]/*' />
    [NativeTypeName("#define NERR_RplNotRplServer (NERR_BASE+514)")]
    public const int NERR_RplNotRplServer = (2100 + 514);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplCannotEnum"]/*' />
    [NativeTypeName("#define NERR_RplCannotEnum (NERR_BASE+515)")]
    public const int NERR_RplCannotEnum = (2100 + 515);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplWkstaInfoCorrupted"]/*' />
    [NativeTypeName("#define NERR_RplWkstaInfoCorrupted (NERR_BASE+516)")]
    public const int NERR_RplWkstaInfoCorrupted = (2100 + 516);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplWkstaNotFound"]/*' />
    [NativeTypeName("#define NERR_RplWkstaNotFound (NERR_BASE+517)")]
    public const int NERR_RplWkstaNotFound = (2100 + 517);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplWkstaNameUnavailable"]/*' />
    [NativeTypeName("#define NERR_RplWkstaNameUnavailable (NERR_BASE+518)")]
    public const int NERR_RplWkstaNameUnavailable = (2100 + 518);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplProfileInfoCorrupted"]/*' />
    [NativeTypeName("#define NERR_RplProfileInfoCorrupted (NERR_BASE+519)")]
    public const int NERR_RplProfileInfoCorrupted = (2100 + 519);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplProfileNotFound"]/*' />
    [NativeTypeName("#define NERR_RplProfileNotFound (NERR_BASE+520)")]
    public const int NERR_RplProfileNotFound = (2100 + 520);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplProfileNameUnavailable"]/*' />
    [NativeTypeName("#define NERR_RplProfileNameUnavailable (NERR_BASE+521)")]
    public const int NERR_RplProfileNameUnavailable = (2100 + 521);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplProfileNotEmpty"]/*' />
    [NativeTypeName("#define NERR_RplProfileNotEmpty (NERR_BASE+522)")]
    public const int NERR_RplProfileNotEmpty = (2100 + 522);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplConfigInfoCorrupted"]/*' />
    [NativeTypeName("#define NERR_RplConfigInfoCorrupted (NERR_BASE+523)")]
    public const int NERR_RplConfigInfoCorrupted = (2100 + 523);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplConfigNotFound"]/*' />
    [NativeTypeName("#define NERR_RplConfigNotFound (NERR_BASE+524)")]
    public const int NERR_RplConfigNotFound = (2100 + 524);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplAdapterInfoCorrupted"]/*' />
    [NativeTypeName("#define NERR_RplAdapterInfoCorrupted (NERR_BASE+525)")]
    public const int NERR_RplAdapterInfoCorrupted = (2100 + 525);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplInternal"]/*' />
    [NativeTypeName("#define NERR_RplInternal (NERR_BASE+526)")]
    public const int NERR_RplInternal = (2100 + 526);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplVendorInfoCorrupted"]/*' />
    [NativeTypeName("#define NERR_RplVendorInfoCorrupted (NERR_BASE+527)")]
    public const int NERR_RplVendorInfoCorrupted = (2100 + 527);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplBootInfoCorrupted"]/*' />
    [NativeTypeName("#define NERR_RplBootInfoCorrupted (NERR_BASE+528)")]
    public const int NERR_RplBootInfoCorrupted = (2100 + 528);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplWkstaNeedsUserAcct"]/*' />
    [NativeTypeName("#define NERR_RplWkstaNeedsUserAcct (NERR_BASE+529)")]
    public const int NERR_RplWkstaNeedsUserAcct = (2100 + 529);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplNeedsRPLUSERAcct"]/*' />
    [NativeTypeName("#define NERR_RplNeedsRPLUSERAcct (NERR_BASE+530)")]
    public const int NERR_RplNeedsRPLUSERAcct = (2100 + 530);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplBootNotFound"]/*' />
    [NativeTypeName("#define NERR_RplBootNotFound (NERR_BASE+531)")]
    public const int NERR_RplBootNotFound = (2100 + 531);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplIncompatibleProfile"]/*' />
    [NativeTypeName("#define NERR_RplIncompatibleProfile (NERR_BASE+532)")]
    public const int NERR_RplIncompatibleProfile = (2100 + 532);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplAdapterNameUnavailable"]/*' />
    [NativeTypeName("#define NERR_RplAdapterNameUnavailable (NERR_BASE+533)")]
    public const int NERR_RplAdapterNameUnavailable = (2100 + 533);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplConfigNotEmpty"]/*' />
    [NativeTypeName("#define NERR_RplConfigNotEmpty (NERR_BASE+534)")]
    public const int NERR_RplConfigNotEmpty = (2100 + 534);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplBootInUse"]/*' />
    [NativeTypeName("#define NERR_RplBootInUse (NERR_BASE+535)")]
    public const int NERR_RplBootInUse = (2100 + 535);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplBackupDatabase"]/*' />
    [NativeTypeName("#define NERR_RplBackupDatabase (NERR_BASE+536)")]
    public const int NERR_RplBackupDatabase = (2100 + 536);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplAdapterNotFound"]/*' />
    [NativeTypeName("#define NERR_RplAdapterNotFound (NERR_BASE+537)")]
    public const int NERR_RplAdapterNotFound = (2100 + 537);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplVendorNotFound"]/*' />
    [NativeTypeName("#define NERR_RplVendorNotFound (NERR_BASE+538)")]
    public const int NERR_RplVendorNotFound = (2100 + 538);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplVendorNameUnavailable"]/*' />
    [NativeTypeName("#define NERR_RplVendorNameUnavailable (NERR_BASE+539)")]
    public const int NERR_RplVendorNameUnavailable = (2100 + 539);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplBootNameUnavailable"]/*' />
    [NativeTypeName("#define NERR_RplBootNameUnavailable (NERR_BASE+540)")]
    public const int NERR_RplBootNameUnavailable = (2100 + 540);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_RplConfigNameUnavailable"]/*' />
    [NativeTypeName("#define NERR_RplConfigNameUnavailable (NERR_BASE+541)")]
    public const int NERR_RplConfigNameUnavailable = (2100 + 541);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsInternalCorruption"]/*' />
    [NativeTypeName("#define NERR_DfsInternalCorruption (NERR_BASE+560)")]
    public const int NERR_DfsInternalCorruption = (2100 + 560);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsVolumeDataCorrupt"]/*' />
    [NativeTypeName("#define NERR_DfsVolumeDataCorrupt (NERR_BASE+561)")]
    public const int NERR_DfsVolumeDataCorrupt = (2100 + 561);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsNoSuchVolume"]/*' />
    [NativeTypeName("#define NERR_DfsNoSuchVolume (NERR_BASE+562)")]
    public const int NERR_DfsNoSuchVolume = (2100 + 562);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsVolumeAlreadyExists"]/*' />
    [NativeTypeName("#define NERR_DfsVolumeAlreadyExists (NERR_BASE+563)")]
    public const int NERR_DfsVolumeAlreadyExists = (2100 + 563);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsAlreadyShared"]/*' />
    [NativeTypeName("#define NERR_DfsAlreadyShared (NERR_BASE+564)")]
    public const int NERR_DfsAlreadyShared = (2100 + 564);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsNoSuchShare"]/*' />
    [NativeTypeName("#define NERR_DfsNoSuchShare (NERR_BASE+565)")]
    public const int NERR_DfsNoSuchShare = (2100 + 565);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsNotALeafVolume"]/*' />
    [NativeTypeName("#define NERR_DfsNotALeafVolume (NERR_BASE+566)")]
    public const int NERR_DfsNotALeafVolume = (2100 + 566);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsLeafVolume"]/*' />
    [NativeTypeName("#define NERR_DfsLeafVolume (NERR_BASE+567)")]
    public const int NERR_DfsLeafVolume = (2100 + 567);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsVolumeHasMultipleServers"]/*' />
    [NativeTypeName("#define NERR_DfsVolumeHasMultipleServers (NERR_BASE+568)")]
    public const int NERR_DfsVolumeHasMultipleServers = (2100 + 568);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsCantCreateJunctionPoint"]/*' />
    [NativeTypeName("#define NERR_DfsCantCreateJunctionPoint (NERR_BASE+569)")]
    public const int NERR_DfsCantCreateJunctionPoint = (2100 + 569);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsServerNotDfsAware"]/*' />
    [NativeTypeName("#define NERR_DfsServerNotDfsAware (NERR_BASE+570)")]
    public const int NERR_DfsServerNotDfsAware = (2100 + 570);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsBadRenamePath"]/*' />
    [NativeTypeName("#define NERR_DfsBadRenamePath (NERR_BASE+571)")]
    public const int NERR_DfsBadRenamePath = (2100 + 571);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsVolumeIsOffline"]/*' />
    [NativeTypeName("#define NERR_DfsVolumeIsOffline (NERR_BASE+572)")]
    public const int NERR_DfsVolumeIsOffline = (2100 + 572);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsNoSuchServer"]/*' />
    [NativeTypeName("#define NERR_DfsNoSuchServer (NERR_BASE+573)")]
    public const int NERR_DfsNoSuchServer = (2100 + 573);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsCyclicalName"]/*' />
    [NativeTypeName("#define NERR_DfsCyclicalName (NERR_BASE+574)")]
    public const int NERR_DfsCyclicalName = (2100 + 574);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsNotSupportedInServerDfs"]/*' />
    [NativeTypeName("#define NERR_DfsNotSupportedInServerDfs (NERR_BASE+575)")]
    public const int NERR_DfsNotSupportedInServerDfs = (2100 + 575);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsDuplicateService"]/*' />
    [NativeTypeName("#define NERR_DfsDuplicateService (NERR_BASE+576)")]
    public const int NERR_DfsDuplicateService = (2100 + 576);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsCantRemoveLastServerShare"]/*' />
    [NativeTypeName("#define NERR_DfsCantRemoveLastServerShare (NERR_BASE+577)")]
    public const int NERR_DfsCantRemoveLastServerShare = (2100 + 577);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsVolumeIsInterDfs"]/*' />
    [NativeTypeName("#define NERR_DfsVolumeIsInterDfs (NERR_BASE+578)")]
    public const int NERR_DfsVolumeIsInterDfs = (2100 + 578);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsInconsistent"]/*' />
    [NativeTypeName("#define NERR_DfsInconsistent (NERR_BASE+579)")]
    public const int NERR_DfsInconsistent = (2100 + 579);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsServerUpgraded"]/*' />
    [NativeTypeName("#define NERR_DfsServerUpgraded (NERR_BASE+580)")]
    public const int NERR_DfsServerUpgraded = (2100 + 580);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsDataIsIdentical"]/*' />
    [NativeTypeName("#define NERR_DfsDataIsIdentical (NERR_BASE+581)")]
    public const int NERR_DfsDataIsIdentical = (2100 + 581);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsCantRemoveDfsRoot"]/*' />
    [NativeTypeName("#define NERR_DfsCantRemoveDfsRoot (NERR_BASE+582)")]
    public const int NERR_DfsCantRemoveDfsRoot = (2100 + 582);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsChildOrParentInDfs"]/*' />
    [NativeTypeName("#define NERR_DfsChildOrParentInDfs (NERR_BASE+583)")]
    public const int NERR_DfsChildOrParentInDfs = (2100 + 583);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DfsInternalError"]/*' />
    [NativeTypeName("#define NERR_DfsInternalError (NERR_BASE+590)")]
    public const int NERR_DfsInternalError = (2100 + 590);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_SetupAlreadyJoined"]/*' />
    [NativeTypeName("#define NERR_SetupAlreadyJoined (NERR_BASE+591)")]
    public const int NERR_SetupAlreadyJoined = (2100 + 591);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_SetupNotJoined"]/*' />
    [NativeTypeName("#define NERR_SetupNotJoined (NERR_BASE+592)")]
    public const int NERR_SetupNotJoined = (2100 + 592);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_SetupDomainController"]/*' />
    [NativeTypeName("#define NERR_SetupDomainController (NERR_BASE+593)")]
    public const int NERR_SetupDomainController = (2100 + 593);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DefaultJoinRequired"]/*' />
    [NativeTypeName("#define NERR_DefaultJoinRequired (NERR_BASE+594)")]
    public const int NERR_DefaultJoinRequired = (2100 + 594);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_InvalidWorkgroupName"]/*' />
    [NativeTypeName("#define NERR_InvalidWorkgroupName (NERR_BASE+595)")]
    public const int NERR_InvalidWorkgroupName = (2100 + 595);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NameUsesIncompatibleCodePage"]/*' />
    [NativeTypeName("#define NERR_NameUsesIncompatibleCodePage (NERR_BASE+596)")]
    public const int NERR_NameUsesIncompatibleCodePage = (2100 + 596);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ComputerAccountNotFound"]/*' />
    [NativeTypeName("#define NERR_ComputerAccountNotFound (NERR_BASE+597)")]
    public const int NERR_ComputerAccountNotFound = (2100 + 597);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_PersonalSku"]/*' />
    [NativeTypeName("#define NERR_PersonalSku (NERR_BASE+598)")]
    public const int NERR_PersonalSku = (2100 + 598);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_SetupCheckDNSConfig"]/*' />
    [NativeTypeName("#define NERR_SetupCheckDNSConfig (NERR_BASE+599)")]
    public const int NERR_SetupCheckDNSConfig = (2100 + 599);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_AlreadyCloudDomainJoined"]/*' />
    [NativeTypeName("#define NERR_AlreadyCloudDomainJoined (NERR_BASE+600)")]
    public const int NERR_AlreadyCloudDomainJoined = (2100 + 600);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_PasswordMustChange"]/*' />
    [NativeTypeName("#define NERR_PasswordMustChange (NERR_BASE + 601)")]
    public const int NERR_PasswordMustChange = (2100 + 601);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_AccountLockedOut"]/*' />
    [NativeTypeName("#define NERR_AccountLockedOut (NERR_BASE + 602)")]
    public const int NERR_AccountLockedOut = (2100 + 602);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_PasswordTooLong"]/*' />
    [NativeTypeName("#define NERR_PasswordTooLong (NERR_BASE + 603)")]
    public const int NERR_PasswordTooLong = (2100 + 603);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_PasswordNotComplexEnough"]/*' />
    [NativeTypeName("#define NERR_PasswordNotComplexEnough (NERR_BASE + 604)")]
    public const int NERR_PasswordNotComplexEnough = (2100 + 604);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_PasswordFilterError"]/*' />
    [NativeTypeName("#define NERR_PasswordFilterError (NERR_BASE + 605)")]
    public const int NERR_PasswordFilterError = (2100 + 605);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NoOfflineJoinInfo"]/*' />
    [NativeTypeName("#define NERR_NoOfflineJoinInfo (NERR_BASE + 609)")]
    public const int NERR_NoOfflineJoinInfo = (2100 + 609);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadOfflineJoinInfo"]/*' />
    [NativeTypeName("#define NERR_BadOfflineJoinInfo (NERR_BASE + 610)")]
    public const int NERR_BadOfflineJoinInfo = (2100 + 610);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_CantCreateJoinInfo"]/*' />
    [NativeTypeName("#define NERR_CantCreateJoinInfo (NERR_BASE + 611)")]
    public const int NERR_CantCreateJoinInfo = (2100 + 611);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_BadDomainJoinInfo"]/*' />
    [NativeTypeName("#define NERR_BadDomainJoinInfo (NERR_BASE + 612)")]
    public const int NERR_BadDomainJoinInfo = (2100 + 612);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_JoinPerformedMustRestart"]/*' />
    [NativeTypeName("#define NERR_JoinPerformedMustRestart (NERR_BASE + 613)")]
    public const int NERR_JoinPerformedMustRestart = (2100 + 613);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_NoJoinPending"]/*' />
    [NativeTypeName("#define NERR_NoJoinPending (NERR_BASE + 614)")]
    public const int NERR_NoJoinPending = (2100 + 614);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ValuesNotSet"]/*' />
    [NativeTypeName("#define NERR_ValuesNotSet (NERR_BASE + 615)")]
    public const int NERR_ValuesNotSet = (2100 + 615);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_CantVerifyHostname"]/*' />
    [NativeTypeName("#define NERR_CantVerifyHostname (NERR_BASE + 616)")]
    public const int NERR_CantVerifyHostname = (2100 + 616);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_CantLoadOfflineHive"]/*' />
    [NativeTypeName("#define NERR_CantLoadOfflineHive (NERR_BASE + 617)")]
    public const int NERR_CantLoadOfflineHive = (2100 + 617);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ConnectionInsecure"]/*' />
    [NativeTypeName("#define NERR_ConnectionInsecure (NERR_BASE + 618)")]
    public const int NERR_ConnectionInsecure = (2100 + 618);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_ProvisioningBlobUnsupported"]/*' />
    [NativeTypeName("#define NERR_ProvisioningBlobUnsupported (NERR_BASE + 619)")]
    public const int NERR_ProvisioningBlobUnsupported = (2100 + 619);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DS8DCRequired"]/*' />
    [NativeTypeName("#define NERR_DS8DCRequired (NERR_BASE + 620)")]
    public const int NERR_DS8DCRequired = (2100 + 620);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_LDAPCapableDCRequired"]/*' />
    [NativeTypeName("#define NERR_LDAPCapableDCRequired (NERR_BASE + 621)")]
    public const int NERR_LDAPCapableDCRequired = (2100 + 621);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DS8DCNotFound"]/*' />
    [NativeTypeName("#define NERR_DS8DCNotFound (NERR_BASE + 622)")]
    public const int NERR_DS8DCNotFound = (2100 + 622);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TargetVersionUnsupported"]/*' />
    [NativeTypeName("#define NERR_TargetVersionUnsupported (NERR_BASE + 623)")]
    public const int NERR_TargetVersionUnsupported = (2100 + 623);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_InvalidMachineNameForJoin"]/*' />
    [NativeTypeName("#define NERR_InvalidMachineNameForJoin (NERR_BASE + 624)")]
    public const int NERR_InvalidMachineNameForJoin = (2100 + 624);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DS9DCNotFound"]/*' />
    [NativeTypeName("#define NERR_DS9DCNotFound (NERR_BASE + 625)")]
    public const int NERR_DS9DCNotFound = (2100 + 625);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_PlainTextSecretsRequired"]/*' />
    [NativeTypeName("#define NERR_PlainTextSecretsRequired (NERR_BASE + 626)")]
    public const int NERR_PlainTextSecretsRequired = (2100 + 626);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_CannotUnjoinAadDomain"]/*' />
    [NativeTypeName("#define NERR_CannotUnjoinAadDomain (NERR_BASE + 627)")]
    public const int NERR_CannotUnjoinAadDomain = (2100 + 627);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_CannotUpdateAadHostName"]/*' />
    [NativeTypeName("#define NERR_CannotUpdateAadHostName (NERR_BASE + 628)")]
    public const int NERR_CannotUpdateAadHostName = (2100 + 628);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_DuplicateHostName"]/*' />
    [NativeTypeName("#define NERR_DuplicateHostName (NERR_BASE + 629)")]
    public const int NERR_DuplicateHostName = (2100 + 629);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_HostNameTooLong"]/*' />
    [NativeTypeName("#define NERR_HostNameTooLong (NERR_BASE + 630)")]
    public const int NERR_HostNameTooLong = (2100 + 630);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_TooManyHostNames"]/*' />
    [NativeTypeName("#define NERR_TooManyHostNames (NERR_BASE + 631)")]
    public const int NERR_TooManyHostNames = (2100 + 631);

    /// <include file='NERR.xml' path='doc/member[@name="NERR.NERR_AccountReuseBlockedByPolicy"]/*' />
    [NativeTypeName("#define NERR_AccountReuseBlockedByPolicy (NERR_BASE + 632)")]
    public const int NERR_AccountReuseBlockedByPolicy = (2100 + 632);
}
