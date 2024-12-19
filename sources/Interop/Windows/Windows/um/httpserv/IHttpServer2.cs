// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpServer2.xml' path='doc/member[@name="IHttpServer2"]/*' />
[Guid("34AF637E-AFE8-4556-BCC1-767F8E0B4A4E")]
[NativeTypeName("struct IHttpServer2 : IHttpServer")]
[NativeInheritance("IHttpServer")]
public unsafe partial struct IHttpServer2 : IHttpServer2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpServer2));

    public void** lpVtbl;

    /// <inheritdoc cref="IHttpServer.IsCommandLineLaunch" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public BOOL IsCommandLineLaunch()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, int>)(lpVtbl[0]))((IHttpServer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpServer.GetAppPoolName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetAppPoolName()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, char*>)(lpVtbl[1]))((IHttpServer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpServer.AssociateWithThreadPool" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT AssociateWithThreadPool(HANDLE hHandle, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> completionRoutine)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, HANDLE, delegate* unmanaged<uint, uint, OVERLAPPED*, void>, int>)(lpVtbl[2]))((IHttpServer2*)Unsafe.AsPointer(ref this), hHandle, completionRoutine);
    }

    /// <inheritdoc cref="IHttpServer.IncrementThreadCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void IncrementThreadCount()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpServer2*, void>)(lpVtbl[3]))((IHttpServer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpServer.DecrementThreadCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void DecrementThreadCount()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpServer2*, void>)(lpVtbl[4]))((IHttpServer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpServer.ReportUnhealthy" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void ReportUnhealthy([NativeTypeName("PCWSTR")] char* pszReasonString, HRESULT hrReason)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpServer2*, char*, HRESULT, void>)(lpVtbl[5]))((IHttpServer2*)Unsafe.AsPointer(ref this), pszReasonString, hrReason);
    }

    /// <inheritdoc cref="IHttpServer.RecycleProcess" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void RecycleProcess([NativeTypeName("PCWSTR")] char* pszReason)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpServer2*, char*, void>)(lpVtbl[6]))((IHttpServer2*)Unsafe.AsPointer(ref this), pszReason);
    }

    /// <inheritdoc cref="IHttpServer.GetAdminManager" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public IAppHostAdminManager* GetAdminManager()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, IAppHostAdminManager*>)(lpVtbl[7]))((IHttpServer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpServer.GetFileInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFileInfo([NativeTypeName("PCWSTR")] char* pszPhysicalPath, HANDLE hUserToken, [NativeTypeName("PSID")] void* pSid, [NativeTypeName("PCWSTR")] char* pszChangeNotificationPath, HANDLE hChangeNotificationToken, BOOL fCache, IHttpFileInfo** ppFileInfo, IHttpTraceContext* pHttpTraceContext = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, char*, HANDLE, void*, char*, HANDLE, BOOL, IHttpFileInfo**, IHttpTraceContext*, int>)(lpVtbl[8]))((IHttpServer2*)Unsafe.AsPointer(ref this), pszPhysicalPath, hUserToken, pSid, pszChangeNotificationPath, hChangeNotificationToken, fCache, ppFileInfo, pHttpTraceContext);
    }

    /// <inheritdoc cref="IHttpServer.FlushKernelCache" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FlushKernelCache([NativeTypeName("PCWSTR")] char* pszUrl)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, char*, int>)(lpVtbl[9]))((IHttpServer2*)Unsafe.AsPointer(ref this), pszUrl);
    }

    /// <inheritdoc cref="IHttpServer.DoCacheOperation" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DoCacheOperation(CACHE_OPERATION cacheOperation, IHttpCacheKey* pCacheKey, IHttpCacheSpecificData** ppCacheSpecificData, IHttpTraceContext* pHttpTraceContext = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, CACHE_OPERATION, IHttpCacheKey*, IHttpCacheSpecificData**, IHttpTraceContext*, int>)(lpVtbl[10]))((IHttpServer2*)Unsafe.AsPointer(ref this), cacheOperation, pCacheKey, ppCacheSpecificData, pHttpTraceContext);
    }

    /// <inheritdoc cref="IHttpServer.NotifyCustomNotification" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public GLOBAL_NOTIFICATION_STATUS NotifyCustomNotification(ICustomNotificationProvider* pCustomOutput)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, ICustomNotificationProvider*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[11]))((IHttpServer2*)Unsafe.AsPointer(ref this), pCustomOutput);
    }

    /// <inheritdoc cref="IHttpServer.GetPerfCounterInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public IHttpPerfCounterInfo* GetPerfCounterInfo()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, IHttpPerfCounterInfo*>)(lpVtbl[12]))((IHttpServer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpServer.RecycleApplication" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void RecycleApplication([NativeTypeName("PCWSTR")] char* pszAppConfigPath)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpServer2*, char*, void>)(lpVtbl[13]))((IHttpServer2*)Unsafe.AsPointer(ref this), pszAppConfigPath);
    }

    /// <inheritdoc cref="IHttpServer.NotifyConfigurationChange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void NotifyConfigurationChange([NativeTypeName("PCWSTR")] char* pszPath)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpServer2*, char*, void>)(lpVtbl[14]))((IHttpServer2*)Unsafe.AsPointer(ref this), pszPath);
    }

    /// <inheritdoc cref="IHttpServer.NotifyFileChange" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void NotifyFileChange([NativeTypeName("PCWSTR")] char* pszFileName)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpServer2*, char*, void>)(lpVtbl[15]))((IHttpServer2*)Unsafe.AsPointer(ref this), pszFileName);
    }

    /// <inheritdoc cref="IHttpServer.DispenseContainer" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public IDispensedHttpModuleContextContainer* DispenseContainer()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, IDispensedHttpModuleContextContainer*>)(lpVtbl[16]))((IHttpServer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpServer.AddFragmentToCache" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AddFragmentToCache(HTTP_DATA_CHUNK* pDataChunk, [NativeTypeName("PCWSTR")] char* pszFragmentName)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, HTTP_DATA_CHUNK*, char*, int>)(lpVtbl[17]))((IHttpServer2*)Unsafe.AsPointer(ref this), pDataChunk, pszFragmentName);
    }

    /// <inheritdoc cref="IHttpServer.ReadFragmentFromCache" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ReadFragmentFromCache([NativeTypeName("PCWSTR")] char* pszFragmentName, byte* pvBuffer, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("DWORD *")] uint* pcbCopied)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, char*, byte*, uint, uint*, int>)(lpVtbl[18]))((IHttpServer2*)Unsafe.AsPointer(ref this), pszFragmentName, pvBuffer, cbSize, pcbCopied);
    }

    /// <inheritdoc cref="IHttpServer.RemoveFragmentFromCache" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT RemoveFragmentFromCache([NativeTypeName("PCWSTR")] char* pszFragmentName)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, char*, int>)(lpVtbl[19]))((IHttpServer2*)Unsafe.AsPointer(ref this), pszFragmentName);
    }

    /// <inheritdoc cref="IHttpServer.GetWorkerProcessSettings" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetWorkerProcessSettings(IWpfSettings** ppWorkerProcessSettings)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, IWpfSettings**, int>)(lpVtbl[20]))((IHttpServer2*)Unsafe.AsPointer(ref this), ppWorkerProcessSettings);
    }

    /// <inheritdoc cref="IHttpServer.GetProtocolManagerCustomInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetProtocolManagerCustomInterface([NativeTypeName("PCWSTR")] char* pProtocolManagerDll, [NativeTypeName("PCWSTR")] char* pProtocolManagerDllInitFunction, [NativeTypeName("DWORD")] uint dwCustomInterfaceId, [NativeTypeName("PVOID *")] void** ppCustomInterface)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, char*, char*, uint, void**, int>)(lpVtbl[21]))((IHttpServer2*)Unsafe.AsPointer(ref this), pProtocolManagerDll, pProtocolManagerDllInitFunction, dwCustomInterfaceId, ppCustomInterface);
    }

    /// <inheritdoc cref="IHttpServer.SatisfiesPrecondition" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public BOOL SatisfiesPrecondition([NativeTypeName("PCWSTR")] char* pszPrecondition, BOOL* pfUnknownPrecondition = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, char*, BOOL*, int>)(lpVtbl[22]))((IHttpServer2*)Unsafe.AsPointer(ref this), pszPrecondition, pfUnknownPrecondition);
    }

    /// <inheritdoc cref="IHttpServer.GetTraceContext" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public IHttpTraceContext* GetTraceContext()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, IHttpTraceContext*>)(lpVtbl[23]))((IHttpServer2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IHttpServer.RegisterFileChangeMonitor" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT RegisterFileChangeMonitor([NativeTypeName("PCWSTR")] char* pszPath, HANDLE hToken, IHttpFileMonitor** ppFileMonitor)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, char*, HANDLE, IHttpFileMonitor**, int>)(lpVtbl[24]))((IHttpServer2*)Unsafe.AsPointer(ref this), pszPath, hToken, ppFileMonitor);
    }

    /// <inheritdoc cref="IHttpServer.GetExtendedInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetExtendedInterface(HTTP_SERVER_INTERFACE_VERSION version, [NativeTypeName("PVOID *")] void** ppInterface)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, HTTP_SERVER_INTERFACE_VERSION, void**, int>)(lpVtbl[25]))((IHttpServer2*)Unsafe.AsPointer(ref this), version, ppInterface);
    }

    /// <include file='IHttpServer2.xml' path='doc/member[@name="IHttpServer2.GetToken"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetToken([NativeTypeName("PCWSTR")] char* pszUserName, [NativeTypeName("PCWSTR")] char* pszPassword, [NativeTypeName("DWORD")] uint dwLogonMethod, IHttpTokenEntry** ppTokenEntry, [NativeTypeName("PCWSTR")] char* pszDefaultDomain = null, [NativeTypeName("PSOCKADDR")] SOCKADDR* pSockAddr = null, IHttpTraceContext* pHttpTraceContext = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, char*, char*, uint, IHttpTokenEntry**, char*, SOCKADDR*, IHttpTraceContext*, int>)(lpVtbl[26]))((IHttpServer2*)Unsafe.AsPointer(ref this), pszUserName, pszPassword, dwLogonMethod, ppTokenEntry, pszDefaultDomain, pSockAddr, pHttpTraceContext);
    }

    /// <include file='IHttpServer2.xml' path='doc/member[@name="IHttpServer2.GetAppPoolConfigFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetAppPoolConfigFile([NativeTypeName("DWORD *")] uint* pcchConfigFilePath = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, uint*, char*>)(lpVtbl[27]))((IHttpServer2*)Unsafe.AsPointer(ref this), pcchConfigFilePath);
    }

    /// <include file='IHttpServer2.xml' path='doc/member[@name="IHttpServer2.GetExtendedInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT GetExtendedInterface([NativeTypeName("const GUID &")] Guid* Version1, [NativeTypeName("PVOID")] void* pInput, [NativeTypeName("const GUID &")] Guid* Version2, [NativeTypeName("PVOID *")] void** ppOutput)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, Guid*, void*, Guid*, void**, int>)(lpVtbl[28]))((IHttpServer2*)Unsafe.AsPointer(ref this), Version1, pInput, Version2, ppOutput);
    }

    /// <include file='IHttpServer2.xml' path='doc/member[@name="IHttpServer2.GetMetadata"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetMetadata([NativeTypeName("PCWSTR")] char* pszSiteName, [NativeTypeName("PCWSTR")] char* pszUrl, IReferencedMetadataInfo** ppMetadataInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, char*, char*, IReferencedMetadataInfo**, int>)(lpVtbl[29]))((IHttpServer2*)Unsafe.AsPointer(ref this), pszSiteName, pszUrl, ppMetadataInfo);
    }

    /// <include file='IHttpServer2.xml' path='doc/member[@name="IHttpServer2.GetWorkerProcessFramework"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetWorkerProcessFramework(IWorkerProcessFramework** ppWorkerProcessFramework)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer2*, IWorkerProcessFramework**, int>)(lpVtbl[30]))((IHttpServer2*)Unsafe.AsPointer(ref this), ppWorkerProcessFramework);
    }

    public interface Interface : IHttpServer.Interface
    {
        [VtblIndex(26)]
        HRESULT GetToken([NativeTypeName("PCWSTR")] char* pszUserName, [NativeTypeName("PCWSTR")] char* pszPassword, [NativeTypeName("DWORD")] uint dwLogonMethod, IHttpTokenEntry** ppTokenEntry, [NativeTypeName("PCWSTR")] char* pszDefaultDomain = null, [NativeTypeName("PSOCKADDR")] SOCKADDR* pSockAddr = null, IHttpTraceContext* pHttpTraceContext = null);

        [VtblIndex(27)]
        [return: NativeTypeName("PCWSTR")]
        char* GetAppPoolConfigFile([NativeTypeName("DWORD *")] uint* pcchConfigFilePath = null);

        [VtblIndex(28)]
        HRESULT GetExtendedInterface([NativeTypeName("const GUID &")] Guid* Version1, [NativeTypeName("PVOID")] void* pInput, [NativeTypeName("const GUID &")] Guid* Version2, [NativeTypeName("PVOID *")] void** ppOutput);

        [VtblIndex(29)]
        HRESULT GetMetadata([NativeTypeName("PCWSTR")] char* pszSiteName, [NativeTypeName("PCWSTR")] char* pszUrl, IReferencedMetadataInfo** ppMetadataInfo);

        [VtblIndex(30)]
        HRESULT GetWorkerProcessFramework(IWorkerProcessFramework** ppWorkerProcessFramework);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("BOOL () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> IsCommandLineLaunch;

        [NativeTypeName("PCWSTR () const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*> GetAppPoolName;

        [NativeTypeName("HRESULT (HANDLE, LPOVERLAPPED_COMPLETION_ROUTINE)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HANDLE, delegate* unmanaged<uint, uint, OVERLAPPED*, void>, int> AssociateWithThreadPool;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> IncrementThreadCount;

        [NativeTypeName("void ()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void> DecrementThreadCount;

        [NativeTypeName("void (PCWSTR, HRESULT)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, HRESULT, void> ReportUnhealthy;

        [NativeTypeName("void (PCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, void> RecycleProcess;

        [NativeTypeName("IAppHostAdminManager *() const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAppHostAdminManager*> GetAdminManager;

        [NativeTypeName("HRESULT (PCWSTR, HANDLE, PSID, PCWSTR, HANDLE, BOOL, IHttpFileInfo **, IHttpTraceContext *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, HANDLE, void*, char*, HANDLE, BOOL, IHttpFileInfo**, IHttpTraceContext*, int> GetFileInfo;

        [NativeTypeName("HRESULT (PCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> FlushKernelCache;

        [NativeTypeName("HRESULT (CACHE_OPERATION, IHttpCacheKey *, IHttpCacheSpecificData **, IHttpTraceContext *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, CACHE_OPERATION, IHttpCacheKey*, IHttpCacheSpecificData**, IHttpTraceContext*, int> DoCacheOperation;

        [NativeTypeName("GLOBAL_NOTIFICATION_STATUS (ICustomNotificationProvider *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ICustomNotificationProvider*, GLOBAL_NOTIFICATION_STATUS> NotifyCustomNotification;

        [NativeTypeName("IHttpPerfCounterInfo *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpPerfCounterInfo*> GetPerfCounterInfo;

        [NativeTypeName("void (PCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, void> RecycleApplication;

        [NativeTypeName("void (PCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, void> NotifyConfigurationChange;

        [NativeTypeName("void (PCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, void> NotifyFileChange;

        [NativeTypeName("IDispensedHttpModuleContextContainer *()")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IDispensedHttpModuleContextContainer*> DispenseContainer;

        [NativeTypeName("HRESULT (HTTP_DATA_CHUNK *, PCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HTTP_DATA_CHUNK*, char*, int> AddFragmentToCache;

        [NativeTypeName("HRESULT (PCWSTR, BYTE *, DWORD, DWORD *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, byte*, uint, uint*, int> ReadFragmentFromCache;

        [NativeTypeName("HRESULT (PCWSTR)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> RemoveFragmentFromCache;

        [NativeTypeName("HRESULT (IWpfSettings **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWpfSettings**, int> GetWorkerProcessSettings;

        [NativeTypeName("HRESULT (PCWSTR, PCWSTR, DWORD, PVOID *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, void**, int> GetProtocolManagerCustomInterface;

        [NativeTypeName("BOOL (PCWSTR, BOOL *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, BOOL*, int> SatisfiesPrecondition;

        [NativeTypeName("IHttpTraceContext *() const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IHttpTraceContext*> GetTraceContext;

        [NativeTypeName("HRESULT (PCWSTR, HANDLE, IHttpFileMonitor **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, HANDLE, IHttpFileMonitor**, int> RegisterFileChangeMonitor;

        [NativeTypeName("HRESULT (HTTP_SERVER_INTERFACE_VERSION, PVOID *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HTTP_SERVER_INTERFACE_VERSION, void**, int> GetExtendedInterface;

        [NativeTypeName("HRESULT (PCWSTR, PCWSTR, DWORD, IHttpTokenEntry **, PCWSTR, PSOCKADDR, IHttpTraceContext *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, uint, IHttpTokenEntry**, char*, SOCKADDR*, IHttpTraceContext*, int> GetToken;

        [NativeTypeName("PCWSTR (DWORD *) const")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, char*> GetAppPoolConfigFile;

        [NativeTypeName("HRESULT (const GUID &, PVOID, const GUID &, PVOID *)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void*, Guid*, void**, int> GetExtendedInterface1;

        [NativeTypeName("HRESULT (PCWSTR, PCWSTR, IReferencedMetadataInfo **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, IReferencedMetadataInfo**, int> GetMetadata;

        [NativeTypeName("HRESULT (IWorkerProcessFramework **)")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IWorkerProcessFramework**, int> GetWorkerProcessFramework;
    }
}
