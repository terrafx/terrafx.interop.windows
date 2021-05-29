// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum JOBOBJECTINFOCLASS
    {
        JobObjectBasicAccountingInformation = 1,
        JobObjectBasicLimitInformation,
        JobObjectBasicProcessIdList,
        JobObjectBasicUIRestrictions,
        JobObjectSecurityLimitInformation,
        JobObjectEndOfJobTimeInformation,
        JobObjectAssociateCompletionPortInformation,
        JobObjectBasicAndIoAccountingInformation,
        JobObjectExtendedLimitInformation,
        JobObjectJobSetInformation,
        JobObjectGroupInformation,
        JobObjectNotificationLimitInformation,
        JobObjectLimitViolationInformation,
        JobObjectGroupInformationEx,
        JobObjectCpuRateControlInformation,
        JobObjectCompletionFilter,
        JobObjectCompletionCounter,
        JobObjectReserved1Information = 18,
        JobObjectReserved2Information,
        JobObjectReserved3Information,
        JobObjectReserved4Information,
        JobObjectReserved5Information,
        JobObjectReserved6Information,
        JobObjectReserved7Information,
        JobObjectReserved8Information,
        JobObjectReserved9Information,
        JobObjectReserved10Information,
        JobObjectReserved11Information,
        JobObjectReserved12Information,
        JobObjectReserved13Information,
        JobObjectReserved14Information = 31,
        JobObjectNetRateControlInformation,
        JobObjectNotificationLimitInformation2,
        JobObjectLimitViolationInformation2,
        JobObjectCreateSilo,
        JobObjectSiloBasicInformation,
        JobObjectReserved15Information = 37,
        JobObjectReserved16Information = 38,
        JobObjectReserved17Information = 39,
        JobObjectReserved18Information = 40,
        JobObjectReserved19Information = 41,
        JobObjectReserved20Information = 42,
        JobObjectReserved21Information = 43,
        JobObjectReserved22Information = 44,
        JobObjectReserved23Information = 45,
        JobObjectReserved24Information = 46,
        JobObjectReserved25Information = 47,
        MaxJobObjectInfoClass,
    }
}
