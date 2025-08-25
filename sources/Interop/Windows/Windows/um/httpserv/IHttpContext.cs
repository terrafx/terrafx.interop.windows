// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext"]/*' />
[Guid("424C1B8C-A1BA-44D7-AC98-9F8F457701A5")]
public unsafe partial struct IHttpContext : IHttpContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_IHttpContext);

    public void** lpVtbl;

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetSite"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public IHttpSite* GetSite()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, IHttpSite*>)(lpVtbl[0]))((IHttpContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    public IHttpApplication* GetApplication()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, IHttpApplication*>)(lpVtbl[1]))((IHttpContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetConnection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public IHttpConnection* GetConnection()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, IHttpConnection*>)(lpVtbl[2]))((IHttpContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetRequest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public IHttpRequest* GetRequest()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, IHttpRequest*>)(lpVtbl[3]))((IHttpContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetResponse"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public IHttpResponse* GetResponse()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, IHttpResponse*>)(lpVtbl[4]))((IHttpContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetResponseHeadersSent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public readonly BOOL GetResponseHeadersSent()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, int>)(lpVtbl[5]))((IHttpContext*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetUser"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public readonly IHttpUser* GetUser()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, IHttpUser*>)(lpVtbl[6]))((IHttpContext*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetModuleContextContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public IHttpModuleContextContainer* GetModuleContextContainer()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, IHttpModuleContextContainer*>)(lpVtbl[7]))((IHttpContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.IndicateCompletion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void IndicateCompletion(REQUEST_NOTIFICATION_STATUS notificationStatus)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpContext*, REQUEST_NOTIFICATION_STATUS, void>)(lpVtbl[8]))((IHttpContext*)Unsafe.AsPointer(ref this), notificationStatus);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.PostCompletion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT PostCompletion([NativeTypeName("DWORD")] uint cbBytes)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, uint, int>)(lpVtbl[9]))((IHttpContext*)Unsafe.AsPointer(ref this), cbBytes);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.DisableNotifications"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void DisableNotifications([NativeTypeName("DWORD")] uint dwNotifications, [NativeTypeName("DWORD")] uint dwPostNotifications)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpContext*, uint, uint, void>)(lpVtbl[10]))((IHttpContext*)Unsafe.AsPointer(ref this), dwNotifications, dwPostNotifications);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetNextNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public BOOL GetNextNotification(REQUEST_NOTIFICATION_STATUS status, [NativeTypeName("DWORD *")] uint* pdwNotification, BOOL* pfIsPostNotification, CHttpModule** ppModuleInfo, IHttpEventProvider** ppRequestOutput)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, REQUEST_NOTIFICATION_STATUS, uint*, BOOL*, CHttpModule**, IHttpEventProvider**, int>)(lpVtbl[11]))((IHttpContext*)Unsafe.AsPointer(ref this), status, pdwNotification, pfIsPostNotification, ppModuleInfo, ppRequestOutput);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetIsLastNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public BOOL GetIsLastNotification(REQUEST_NOTIFICATION_STATUS status)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, REQUEST_NOTIFICATION_STATUS, int>)(lpVtbl[12]))((IHttpContext*)Unsafe.AsPointer(ref this), status);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.ExecuteRequest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ExecuteRequest(BOOL fAsync, IHttpContext* pHttpContext, [NativeTypeName("DWORD")] uint dwExecuteFlags, IHttpUser* pHttpUser, BOOL* pfCompletionExpected = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, BOOL, IHttpContext*, uint, IHttpUser*, BOOL*, int>)(lpVtbl[13]))((IHttpContext*)Unsafe.AsPointer(ref this), fAsync, pHttpContext, dwExecuteFlags, pHttpUser, pfCompletionExpected);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetExecuteFlags"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [return: NativeTypeName("DWORD")]
    public readonly uint GetExecuteFlags()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, uint>)(lpVtbl[14]))((IHttpContext*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetServerVariable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetServerVariable([NativeTypeName("PCSTR")] sbyte* pszVariableName, [NativeTypeName("PCSTR *")] sbyte** ppszValue, [NativeTypeName("DWORD *")] uint* pcchValueLength)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, sbyte*, sbyte**, uint*, int>)(lpVtbl[15]))((IHttpContext*)Unsafe.AsPointer(ref this), pszVariableName, ppszValue, pcchValueLength);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetServerVariable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetServerVariable([NativeTypeName("PCSTR")] sbyte* pszVariableName, [NativeTypeName("PCWSTR *")] char** ppszValue, [NativeTypeName("DWORD *")] uint* pcchValueLength)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, sbyte*, char**, uint*, int>)(lpVtbl[16]))((IHttpContext*)Unsafe.AsPointer(ref this), pszVariableName, ppszValue, pcchValueLength);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.SetServerVariable"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetServerVariable([NativeTypeName("PCSTR")] sbyte* pszVariableName, [NativeTypeName("PCWSTR")] char* pszVariableValue)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, sbyte*, char*, int>)(lpVtbl[17]))((IHttpContext*)Unsafe.AsPointer(ref this), pszVariableName, pszVariableValue);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.AllocateRequestMemory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public void* AllocateRequestMemory([NativeTypeName("DWORD")] uint cbAllocation)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, uint, void*>)(lpVtbl[18]))((IHttpContext*)Unsafe.AsPointer(ref this), cbAllocation);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetUrlInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public IHttpUrlInfo* GetUrlInfo()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, IHttpUrlInfo*>)(lpVtbl[19]))((IHttpContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public IMetadataInfo* GetMetadata()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, IMetadataInfo*>)(lpVtbl[20]))((IHttpContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetPhysicalPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetPhysicalPath([NativeTypeName("DWORD *")] uint* pcchPhysicalPath = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, uint*, char*>)(lpVtbl[21]))((IHttpContext*)Unsafe.AsPointer(ref this), pcchPhysicalPath);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetScriptName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    [return: NativeTypeName("PCWSTR")]
    public readonly char* GetScriptName([NativeTypeName("DWORD *")] uint* pcchScriptName = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, uint*, char*>)(lpVtbl[22]))((IHttpContext*)Unsafe.AsPointer(in this), pcchScriptName);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetScriptTranslated"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetScriptTranslated([NativeTypeName("DWORD *")] uint* pcchScriptTranslated = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, uint*, char*>)(lpVtbl[23]))((IHttpContext*)Unsafe.AsPointer(ref this), pcchScriptTranslated);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetScriptMap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public readonly IScriptMapInfo* GetScriptMap()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, IScriptMapInfo*>)(lpVtbl[24]))((IHttpContext*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.SetRequestHandled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public void SetRequestHandled()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpContext*, void>)(lpVtbl[25]))((IHttpContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetFileInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public readonly IHttpFileInfo* GetFileInfo()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, IHttpFileInfo*>)(lpVtbl[26]))((IHttpContext*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.MapPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT MapPath([NativeTypeName("PCWSTR")] char* pszUrl, [NativeTypeName("PWSTR")] char* pszPhysicalPath, [NativeTypeName("DWORD *")] uint* pcbPhysicalPath)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, char*, char*, uint*, int>)(lpVtbl[27]))((IHttpContext*)Unsafe.AsPointer(ref this), pszUrl, pszPhysicalPath, pcbPhysicalPath);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.NotifyCustomNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT NotifyCustomNotification(ICustomNotificationProvider* pCustomOutput, BOOL* pfCompletionExpected)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, ICustomNotificationProvider*, BOOL*, int>)(lpVtbl[28]))((IHttpContext*)Unsafe.AsPointer(ref this), pCustomOutput, pfCompletionExpected);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetParentContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public readonly IHttpContext* GetParentContext()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, IHttpContext*>)(lpVtbl[29]))((IHttpContext*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetRootContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public readonly IHttpContext* GetRootContext()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, IHttpContext*>)(lpVtbl[30]))((IHttpContext*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.CloneContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT CloneContext([NativeTypeName("DWORD")] uint dwCloneFlags, IHttpContext** ppHttpContext)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, uint, IHttpContext**, int>)(lpVtbl[31]))((IHttpContext*)Unsafe.AsPointer(ref this), dwCloneFlags, ppHttpContext);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.ReleaseClonedContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT ReleaseClonedContext()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, int>)(lpVtbl[32]))((IHttpContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetCurrentExecutionStats"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public readonly HRESULT GetCurrentExecutionStats([NativeTypeName("DWORD *")] uint* pdwNotification, [NativeTypeName("DWORD *")] uint* pdwNotificationStartTickCount = null, [NativeTypeName("PCWSTR *")] char** ppszModule = null, [NativeTypeName("DWORD *")] uint* pdwModuleStartTickCount = null, [NativeTypeName("DWORD *")] uint* pdwAsyncNotification = null, [NativeTypeName("DWORD *")] uint* pdwAsyncNotificationStartTickCount = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, uint*, uint*, char**, uint*, uint*, uint*, int>)(lpVtbl[33]))((IHttpContext*)Unsafe.AsPointer(in this), pdwNotification, pdwNotificationStartTickCount, ppszModule, pdwModuleStartTickCount, pdwAsyncNotification, pdwAsyncNotificationStartTickCount);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetTraceContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public readonly IHttpTraceContext* GetTraceContext()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, IHttpTraceContext*>)(lpVtbl[34]))((IHttpContext*)Unsafe.AsPointer(in this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetServerVarChanges"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT GetServerVarChanges([NativeTypeName("DWORD")] uint dwOldChangeNumber, [NativeTypeName("DWORD *")] uint* pdwNewChangeNumber, [NativeTypeName("DWORD *")] uint* pdwVariableSnapshot, [NativeTypeName("PCSTR **")] sbyte*** ppVariableNameSnapshot, [NativeTypeName("PCWSTR **")] char*** ppVariableValueSnapshot, [NativeTypeName("DWORD *")] uint* pdwDiffedVariables, [NativeTypeName("DWORD **")] uint** ppDiffedVariableIndices)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, uint, uint*, uint*, sbyte***, char***, uint*, uint**, int>)(lpVtbl[35]))((IHttpContext*)Unsafe.AsPointer(ref this), dwOldChangeNumber, pdwNewChangeNumber, pdwVariableSnapshot, ppVariableNameSnapshot, ppVariableValueSnapshot, pdwDiffedVariables, ppDiffedVariableIndices);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.CancelIo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT CancelIo()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, int>)(lpVtbl[36]))((IHttpContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.MapHandler"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT MapHandler([NativeTypeName("DWORD")] uint dwSiteId, [NativeTypeName("PCWSTR")] char* pszSiteName, [NativeTypeName("PCWSTR")] char* pszUrl, [NativeTypeName("PCSTR")] sbyte* pszVerb, IScriptMapInfo** ppScriptMap, [Optional] BOOL fIgnoreWildcardMappings)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, uint, char*, char*, sbyte*, IScriptMapInfo**, BOOL, int>)(lpVtbl[37]))((IHttpContext*)Unsafe.AsPointer(ref this), dwSiteId, pszSiteName, pszUrl, pszVerb, ppScriptMap, fIgnoreWildcardMappings);
    }

    /// <include file='IHttpContext.xml' path='doc/member[@name="IHttpContext.GetExtendedInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    [Obsolete("This method is deprecated. Use the HttpGetExtendedInterface helper function instead.")]
    public HRESULT GetExtendedInterface(HTTP_CONTEXT_INTERFACE_VERSION version, [NativeTypeName("PVOID *")] void** ppInterface)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpContext*, HTTP_CONTEXT_INTERFACE_VERSION, void**, int>)(lpVtbl[38]))((IHttpContext*)Unsafe.AsPointer(ref this), version, ppInterface);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        IHttpSite* GetSite();

        [VtblIndex(1)]
        IHttpApplication* GetApplication();

        [VtblIndex(2)]
        IHttpConnection* GetConnection();

        [VtblIndex(3)]
        IHttpRequest* GetRequest();

        [VtblIndex(4)]
        IHttpResponse* GetResponse();

        [VtblIndex(5)]
        BOOL GetResponseHeadersSent();

        [VtblIndex(6)]
        IHttpUser* GetUser();

        [VtblIndex(7)]
        IHttpModuleContextContainer* GetModuleContextContainer();

        [VtblIndex(8)]
        void IndicateCompletion(REQUEST_NOTIFICATION_STATUS notificationStatus);

        [VtblIndex(9)]
        HRESULT PostCompletion([NativeTypeName("DWORD")] uint cbBytes);

        [VtblIndex(10)]
        void DisableNotifications([NativeTypeName("DWORD")] uint dwNotifications, [NativeTypeName("DWORD")] uint dwPostNotifications);

        [VtblIndex(11)]
        BOOL GetNextNotification(REQUEST_NOTIFICATION_STATUS status, [NativeTypeName("DWORD *")] uint* pdwNotification, BOOL* pfIsPostNotification, CHttpModule** ppModuleInfo, IHttpEventProvider** ppRequestOutput);

        [VtblIndex(12)]
        BOOL GetIsLastNotification(REQUEST_NOTIFICATION_STATUS status);

        [VtblIndex(13)]
        HRESULT ExecuteRequest(BOOL fAsync, IHttpContext* pHttpContext, [NativeTypeName("DWORD")] uint dwExecuteFlags, IHttpUser* pHttpUser, BOOL* pfCompletionExpected = null);

        [VtblIndex(14)]
        [return: NativeTypeName("DWORD")]
        uint GetExecuteFlags();

        [VtblIndex(15)]
        HRESULT GetServerVariable([NativeTypeName("PCSTR")] sbyte* pszVariableName, [NativeTypeName("PCSTR *")] sbyte** ppszValue, [NativeTypeName("DWORD *")] uint* pcchValueLength);

        [VtblIndex(16)]
        HRESULT GetServerVariable([NativeTypeName("PCSTR")] sbyte* pszVariableName, [NativeTypeName("PCWSTR *")] char** ppszValue, [NativeTypeName("DWORD *")] uint* pcchValueLength);

        [VtblIndex(17)]
        HRESULT SetServerVariable([NativeTypeName("PCSTR")] sbyte* pszVariableName, [NativeTypeName("PCWSTR")] char* pszVariableValue);

        [VtblIndex(18)]
        void* AllocateRequestMemory([NativeTypeName("DWORD")] uint cbAllocation);

        [VtblIndex(19)]
        IHttpUrlInfo* GetUrlInfo();

        [VtblIndex(20)]
        IMetadataInfo* GetMetadata();

        [VtblIndex(21)]
        [return: NativeTypeName("PCWSTR")]
        char* GetPhysicalPath([NativeTypeName("DWORD *")] uint* pcchPhysicalPath = null);

        [VtblIndex(22)]
        [return: NativeTypeName("PCWSTR")]
        char* GetScriptName([NativeTypeName("DWORD *")] uint* pcchScriptName = null);

        [VtblIndex(23)]
        [return: NativeTypeName("PCWSTR")]
        char* GetScriptTranslated([NativeTypeName("DWORD *")] uint* pcchScriptTranslated = null);

        [VtblIndex(24)]
        IScriptMapInfo* GetScriptMap();

        [VtblIndex(25)]
        void SetRequestHandled();

        [VtblIndex(26)]
        IHttpFileInfo* GetFileInfo();

        [VtblIndex(27)]
        HRESULT MapPath([NativeTypeName("PCWSTR")] char* pszUrl, [NativeTypeName("PWSTR")] char* pszPhysicalPath, [NativeTypeName("DWORD *")] uint* pcbPhysicalPath);

        [VtblIndex(28)]
        HRESULT NotifyCustomNotification(ICustomNotificationProvider* pCustomOutput, BOOL* pfCompletionExpected);

        [VtblIndex(29)]
        IHttpContext* GetParentContext();

        [VtblIndex(30)]
        IHttpContext* GetRootContext();

        [VtblIndex(31)]
        HRESULT CloneContext([NativeTypeName("DWORD")] uint dwCloneFlags, IHttpContext** ppHttpContext);

        [VtblIndex(32)]
        HRESULT ReleaseClonedContext();

        [VtblIndex(33)]
        HRESULT GetCurrentExecutionStats([NativeTypeName("DWORD *")] uint* pdwNotification, [NativeTypeName("DWORD *")] uint* pdwNotificationStartTickCount = null, [NativeTypeName("PCWSTR *")] char** ppszModule = null, [NativeTypeName("DWORD *")] uint* pdwModuleStartTickCount = null, [NativeTypeName("DWORD *")] uint* pdwAsyncNotification = null, [NativeTypeName("DWORD *")] uint* pdwAsyncNotificationStartTickCount = null);

        [VtblIndex(34)]
        IHttpTraceContext* GetTraceContext();

        [VtblIndex(35)]
        HRESULT GetServerVarChanges([NativeTypeName("DWORD")] uint dwOldChangeNumber, [NativeTypeName("DWORD *")] uint* pdwNewChangeNumber, [NativeTypeName("DWORD *")] uint* pdwVariableSnapshot, [NativeTypeName("PCSTR **")] sbyte*** ppVariableNameSnapshot, [NativeTypeName("PCWSTR **")] char*** ppVariableValueSnapshot, [NativeTypeName("DWORD *")] uint* pdwDiffedVariables, [NativeTypeName("DWORD **")] uint** ppDiffedVariableIndices);

        [VtblIndex(36)]
        HRESULT CancelIo();

        [VtblIndex(37)]
        HRESULT MapHandler([NativeTypeName("DWORD")] uint dwSiteId, [NativeTypeName("PCWSTR")] char* pszSiteName, [NativeTypeName("PCWSTR")] char* pszUrl, [NativeTypeName("PCSTR")] sbyte* pszVerb, IScriptMapInfo** ppScriptMap, [Optional] BOOL fIgnoreWildcardMappings);

        [VtblIndex(38)]
        [Obsolete("This method is deprecated. Use the HttpGetExtendedInterface helper function instead.")]
        HRESULT GetExtendedInterface(HTTP_CONTEXT_INTERFACE_VERSION version, [NativeTypeName("PVOID *")] void** ppInterface);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("IHttpSite *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpSite*> GetSite;

        [NativeTypeName("IHttpApplication *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpApplication*> GetApplication;

        [NativeTypeName("IHttpConnection *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpConnection*> GetConnection;

        [NativeTypeName("IHttpRequest *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpRequest*> GetRequest;

        [NativeTypeName("IHttpResponse *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpResponse*> GetResponse;

        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> GetResponseHeadersSent;

        [NativeTypeName("IHttpUser *() const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpUser*> GetUser;

        [NativeTypeName("IHttpModuleContextContainer *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpModuleContextContainer*> GetModuleContextContainer;

        [NativeTypeName("void (REQUEST_NOTIFICATION_STATUS)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, REQUEST_NOTIFICATION_STATUS, void> IndicateCompletion;

        [NativeTypeName("HRESULT (DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> PostCompletion;

        [NativeTypeName("void (DWORD, DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint, void> DisableNotifications;

        [NativeTypeName("BOOL (REQUEST_NOTIFICATION_STATUS, DWORD *, BOOL *, CHttpModule **, IHttpEventProvider **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, REQUEST_NOTIFICATION_STATUS, uint*, BOOL*, CHttpModule**, IHttpEventProvider**, int> GetNextNotification;

        [NativeTypeName("BOOL (REQUEST_NOTIFICATION_STATUS)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, REQUEST_NOTIFICATION_STATUS, int> GetIsLastNotification;

        [NativeTypeName("HRESULT (BOOL, IHttpContext *, DWORD, IHttpUser *, BOOL *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, IHttpContext*, uint, IHttpUser*, BOOL*, int> ExecuteRequest;

        [NativeTypeName("DWORD () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> GetExecuteFlags;

        [NativeTypeName("HRESULT (PCSTR, PCSTR *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, sbyte**, uint*, int> GetServerVariable;

        [NativeTypeName("HRESULT (PCSTR, PCWSTR *, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, char**, uint*, int> GetServerVariable1;

        [NativeTypeName("HRESULT (PCSTR, PCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, sbyte*, char*, int> SetServerVariable;

        [NativeTypeName("void *(DWORD)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, void*> AllocateRequestMemory;

        [NativeTypeName("IHttpUrlInfo *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpUrlInfo*> GetUrlInfo;

        [NativeTypeName("IMetadataInfo *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMetadataInfo*> GetMetadata;

        [NativeTypeName("PCWSTR (DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char*> GetPhysicalPath;

        [NativeTypeName("PCWSTR (DWORD *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char*> GetScriptName;

        [NativeTypeName("PCWSTR (DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char*> GetScriptTranslated;

        [NativeTypeName("IScriptMapInfo *() const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IScriptMapInfo*> GetScriptMap;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> SetRequestHandled;

        [NativeTypeName("IHttpFileInfo *() const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpFileInfo*> GetFileInfo;

        [NativeTypeName("HRESULT (PCWSTR, PWSTR, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint*, int> MapPath;

        [NativeTypeName("HRESULT (ICustomNotificationProvider *, BOOL *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICustomNotificationProvider*, BOOL*, int> NotifyCustomNotification;

        [NativeTypeName("IHttpContext *() const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpContext*> GetParentContext;

        [NativeTypeName("IHttpContext *() const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpContext*> GetRootContext;

        [NativeTypeName("HRESULT (DWORD, IHttpContext **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, IHttpContext**, int> CloneContext;

        [NativeTypeName("HRESULT ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> ReleaseClonedContext;

        [NativeTypeName("HRESULT (DWORD *, DWORD *, PCWSTR *, DWORD *, DWORD *, DWORD *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, uint*, char**, uint*, uint*, uint*, int> GetCurrentExecutionStats;

        [NativeTypeName("IHttpTraceContext *() const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpTraceContext*> GetTraceContext;

        [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *, PCSTR **, PCWSTR **, DWORD *, DWORD **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, uint*, uint*, sbyte***, char***, uint*, uint**, int> GetServerVarChanges;

        [NativeTypeName("HRESULT ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> CancelIo;

        [NativeTypeName("HRESULT (DWORD, PCWSTR, PCWSTR, PCSTR, IScriptMapInfo **, BOOL)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, char*, char*, sbyte*, IScriptMapInfo**, BOOL, int> MapHandler;

        [NativeTypeName("HRESULT (HTTP_CONTEXT_INTERFACE_VERSION, PVOID *)")]
        [Obsolete("This method is deprecated. Use the HttpGetExtendedInterface helper function instead.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HTTP_CONTEXT_INTERFACE_VERSION, void**, int> GetExtendedInterface;
    }
}
