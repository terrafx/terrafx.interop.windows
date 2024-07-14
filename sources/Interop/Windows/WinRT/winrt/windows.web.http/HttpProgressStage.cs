// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.web.http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='HttpProgressStage.xml' path='doc/member[@name="HttpProgressStage"]/*' />
public enum HttpProgressStage
{
    /// <include file='HttpProgressStage.xml' path='doc/member[@name="HttpProgressStage.HttpProgressStage_None"]/*' />
    HttpProgressStage_None = 0,

    /// <include file='HttpProgressStage.xml' path='doc/member[@name="HttpProgressStage.HttpProgressStage_DetectingProxy"]/*' />
    HttpProgressStage_DetectingProxy = 10,

    /// <include file='HttpProgressStage.xml' path='doc/member[@name="HttpProgressStage.HttpProgressStage_ResolvingName"]/*' />
    HttpProgressStage_ResolvingName = 20,

    /// <include file='HttpProgressStage.xml' path='doc/member[@name="HttpProgressStage.HttpProgressStage_ConnectingToServer"]/*' />
    HttpProgressStage_ConnectingToServer = 30,

    /// <include file='HttpProgressStage.xml' path='doc/member[@name="HttpProgressStage.HttpProgressStage_NegotiatingSsl"]/*' />
    HttpProgressStage_NegotiatingSsl = 40,

    /// <include file='HttpProgressStage.xml' path='doc/member[@name="HttpProgressStage.HttpProgressStage_SendingHeaders"]/*' />
    HttpProgressStage_SendingHeaders = 50,

    /// <include file='HttpProgressStage.xml' path='doc/member[@name="HttpProgressStage.HttpProgressStage_SendingContent"]/*' />
    HttpProgressStage_SendingContent = 60,

    /// <include file='HttpProgressStage.xml' path='doc/member[@name="HttpProgressStage.HttpProgressStage_WaitingForResponse"]/*' />
    HttpProgressStage_WaitingForResponse = 70,

    /// <include file='HttpProgressStage.xml' path='doc/member[@name="HttpProgressStage.HttpProgressStage_ReceivingHeaders"]/*' />
    HttpProgressStage_ReceivingHeaders = 80,

    /// <include file='HttpProgressStage.xml' path='doc/member[@name="HttpProgressStage.HttpProgressStage_ReceivingContent"]/*' />
    HttpProgressStage_ReceivingContent = 90,
}
