// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer"]/*' />
[Guid("EDA2A40F-FB92-4D6D-B52B-C8C207380B4E")]
public unsafe partial struct IHttpServer : IHttpServer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHttpServer));

    public void** lpVtbl;

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.IsCommandLineLaunch"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public BOOL IsCommandLineLaunch()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, int>)(lpVtbl[0]))((IHttpServer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.GetAppPoolName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("PCWSTR")]
    public char* GetAppPoolName()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, char*>)(lpVtbl[1]))((IHttpServer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.AssociateWithThreadPool"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    public HRESULT AssociateWithThreadPool(HANDLE hHandle, [NativeTypeName("LPOVERLAPPED_COMPLETION_ROUTINE")] delegate* unmanaged<uint, uint, OVERLAPPED*, void> completionRoutine)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, HANDLE, delegate* unmanaged<uint, uint, OVERLAPPED*, void>, int>)(lpVtbl[2]))((IHttpServer*)Unsafe.AsPointer(ref this), hHandle, completionRoutine);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.IncrementThreadCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void IncrementThreadCount()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpServer*, void>)(lpVtbl[3]))((IHttpServer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.DecrementThreadCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void DecrementThreadCount()
    {
        ((delegate* unmanaged[MemberFunction]<IHttpServer*, void>)(lpVtbl[4]))((IHttpServer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.ReportUnhealthy"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void ReportUnhealthy([NativeTypeName("PCWSTR")] char* pszReasonString, HRESULT hrReason)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpServer*, char*, HRESULT, void>)(lpVtbl[5]))((IHttpServer*)Unsafe.AsPointer(ref this), pszReasonString, hrReason);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.RecycleProcess"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void RecycleProcess([NativeTypeName("PCWSTR")] char* pszReason)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpServer*, char*, void>)(lpVtbl[6]))((IHttpServer*)Unsafe.AsPointer(ref this), pszReason);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.GetAdminManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public IAppHostAdminManager* GetAdminManager()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, IAppHostAdminManager*>)(lpVtbl[7]))((IHttpServer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.GetFileInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetFileInfo([NativeTypeName("PCWSTR")] char* pszPhysicalPath, HANDLE hUserToken, [NativeTypeName("PSID")] void* pSid, [NativeTypeName("PCWSTR")] char* pszChangeNotificationPath, HANDLE hChangeNotificationToken, BOOL fCache, IHttpFileInfo** ppFileInfo, IHttpTraceContext* pHttpTraceContext = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, char*, HANDLE, void*, char*, HANDLE, BOOL, IHttpFileInfo**, IHttpTraceContext*, int>)(lpVtbl[8]))((IHttpServer*)Unsafe.AsPointer(ref this), pszPhysicalPath, hUserToken, pSid, pszChangeNotificationPath, hChangeNotificationToken, fCache, ppFileInfo, pHttpTraceContext);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.FlushKernelCache"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT FlushKernelCache([NativeTypeName("PCWSTR")] char* pszUrl)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, char*, int>)(lpVtbl[9]))((IHttpServer*)Unsafe.AsPointer(ref this), pszUrl);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.DoCacheOperation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT DoCacheOperation(CACHE_OPERATION cacheOperation, IHttpCacheKey* pCacheKey, IHttpCacheSpecificData** ppCacheSpecificData, IHttpTraceContext* pHttpTraceContext = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, CACHE_OPERATION, IHttpCacheKey*, IHttpCacheSpecificData**, IHttpTraceContext*, int>)(lpVtbl[10]))((IHttpServer*)Unsafe.AsPointer(ref this), cacheOperation, pCacheKey, ppCacheSpecificData, pHttpTraceContext);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.NotifyCustomNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public GLOBAL_NOTIFICATION_STATUS NotifyCustomNotification(ICustomNotificationProvider* pCustomOutput)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, ICustomNotificationProvider*, GLOBAL_NOTIFICATION_STATUS>)(lpVtbl[11]))((IHttpServer*)Unsafe.AsPointer(ref this), pCustomOutput);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.GetPerfCounterInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public IHttpPerfCounterInfo* GetPerfCounterInfo()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, IHttpPerfCounterInfo*>)(lpVtbl[12]))((IHttpServer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.RecycleApplication"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public void RecycleApplication([NativeTypeName("PCWSTR")] char* pszAppConfigPath)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpServer*, char*, void>)(lpVtbl[13]))((IHttpServer*)Unsafe.AsPointer(ref this), pszAppConfigPath);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.NotifyConfigurationChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public void NotifyConfigurationChange([NativeTypeName("PCWSTR")] char* pszPath)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpServer*, char*, void>)(lpVtbl[14]))((IHttpServer*)Unsafe.AsPointer(ref this), pszPath);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.NotifyFileChange"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public void NotifyFileChange([NativeTypeName("PCWSTR")] char* pszFileName)
    {
        ((delegate* unmanaged[MemberFunction]<IHttpServer*, char*, void>)(lpVtbl[15]))((IHttpServer*)Unsafe.AsPointer(ref this), pszFileName);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.DispenseContainer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public IDispensedHttpModuleContextContainer* DispenseContainer()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, IDispensedHttpModuleContextContainer*>)(lpVtbl[16]))((IHttpServer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.AddFragmentToCache"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT AddFragmentToCache(HTTP_DATA_CHUNK* pDataChunk, [NativeTypeName("PCWSTR")] char* pszFragmentName)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, HTTP_DATA_CHUNK*, char*, int>)(lpVtbl[17]))((IHttpServer*)Unsafe.AsPointer(ref this), pDataChunk, pszFragmentName);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.ReadFragmentFromCache"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT ReadFragmentFromCache([NativeTypeName("PCWSTR")] char* pszFragmentName, byte* pvBuffer, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("DWORD *")] uint* pcbCopied)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, char*, byte*, uint, uint*, int>)(lpVtbl[18]))((IHttpServer*)Unsafe.AsPointer(ref this), pszFragmentName, pvBuffer, cbSize, pcbCopied);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.RemoveFragmentFromCache"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT RemoveFragmentFromCache([NativeTypeName("PCWSTR")] char* pszFragmentName)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, char*, int>)(lpVtbl[19]))((IHttpServer*)Unsafe.AsPointer(ref this), pszFragmentName);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.GetWorkerProcessSettings"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetWorkerProcessSettings(IWpfSettings** ppWorkerProcessSettings)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, IWpfSettings**, int>)(lpVtbl[20]))((IHttpServer*)Unsafe.AsPointer(ref this), ppWorkerProcessSettings);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.GetProtocolManagerCustomInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetProtocolManagerCustomInterface([NativeTypeName("PCWSTR")] char* pProtocolManagerDll, [NativeTypeName("PCWSTR")] char* pProtocolManagerDllInitFunction, [NativeTypeName("DWORD")] uint dwCustomInterfaceId, [NativeTypeName("PVOID *")] void** ppCustomInterface)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, char*, char*, uint, void**, int>)(lpVtbl[21]))((IHttpServer*)Unsafe.AsPointer(ref this), pProtocolManagerDll, pProtocolManagerDllInitFunction, dwCustomInterfaceId, ppCustomInterface);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.SatisfiesPrecondition"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public BOOL SatisfiesPrecondition([NativeTypeName("PCWSTR")] char* pszPrecondition, BOOL* pfUnknownPrecondition = null)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, char*, BOOL*, int>)(lpVtbl[22]))((IHttpServer*)Unsafe.AsPointer(ref this), pszPrecondition, pfUnknownPrecondition);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.GetTraceContext"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public IHttpTraceContext* GetTraceContext()
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, IHttpTraceContext*>)(lpVtbl[23]))((IHttpServer*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.RegisterFileChangeMonitor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT RegisterFileChangeMonitor([NativeTypeName("PCWSTR")] char* pszPath, HANDLE hToken, IHttpFileMonitor** ppFileMonitor)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, char*, HANDLE, IHttpFileMonitor**, int>)(lpVtbl[24]))((IHttpServer*)Unsafe.AsPointer(ref this), pszPath, hToken, ppFileMonitor);
    }

    /// <include file='IHttpServer.xml' path='doc/member[@name="IHttpServer.GetExtendedInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetExtendedInterface(HTTP_SERVER_INTERFACE_VERSION version, [NativeTypeName("PVOID *")] void** ppInterface)
    {
        return ((delegate* unmanaged[MemberFunction]<IHttpServer*, HTTP_SERVER_INTERFACE_VERSION, void**, int>)(lpVtbl[25]))((IHttpServer*)Unsafe.AsPointer(ref this), version, ppInterface);
    }

    public interface Interface
    {
        [VtblIndex(0)]
        BOOL IsCommandLineLaunch();

        [VtblIndex(1)]
        [return: NativeTypeName("PCWSTR")]
        char* GetAppPoolName();

        [VtblIndex(3)]
        void IncrementThreadCount();

        [VtblIndex(4)]
        void DecrementThreadCount();

        [VtblIndex(5)]
        void ReportUnhealthy([NativeTypeName("PCWSTR")] char* pszReasonString, HRESULT hrReason);

        [VtblIndex(6)]
        void RecycleProcess([NativeTypeName("PCWSTR")] char* pszReason);

        [VtblIndex(7)]
        IAppHostAdminManager* GetAdminManager();

        [VtblIndex(8)]
        HRESULT GetFileInfo([NativeTypeName("PCWSTR")] char* pszPhysicalPath, HANDLE hUserToken, [NativeTypeName("PSID")] void* pSid, [NativeTypeName("PCWSTR")] char* pszChangeNotificationPath, HANDLE hChangeNotificationToken, BOOL fCache, IHttpFileInfo** ppFileInfo, IHttpTraceContext* pHttpTraceContext = null);

        [VtblIndex(9)]
        HRESULT FlushKernelCache([NativeTypeName("PCWSTR")] char* pszUrl);

        [VtblIndex(10)]
        HRESULT DoCacheOperation(CACHE_OPERATION cacheOperation, IHttpCacheKey* pCacheKey, IHttpCacheSpecificData** ppCacheSpecificData, IHttpTraceContext* pHttpTraceContext = null);

        [VtblIndex(11)]
        GLOBAL_NOTIFICATION_STATUS NotifyCustomNotification(ICustomNotificationProvider* pCustomOutput);

        [VtblIndex(12)]
        IHttpPerfCounterInfo* GetPerfCounterInfo();

        [VtblIndex(13)]
        void RecycleApplication([NativeTypeName("PCWSTR")] char* pszAppConfigPath);

        [VtblIndex(14)]
        void NotifyConfigurationChange([NativeTypeName("PCWSTR")] char* pszPath);

        [VtblIndex(15)]
        void NotifyFileChange([NativeTypeName("PCWSTR")] char* pszFileName);

        [VtblIndex(16)]
        IDispensedHttpModuleContextContainer* DispenseContainer();

        [VtblIndex(17)]
        HRESULT AddFragmentToCache(HTTP_DATA_CHUNK* pDataChunk, [NativeTypeName("PCWSTR")] char* pszFragmentName);

        [VtblIndex(18)]
        HRESULT ReadFragmentFromCache([NativeTypeName("PCWSTR")] char* pszFragmentName, byte* pvBuffer, [NativeTypeName("DWORD")] uint cbSize, [NativeTypeName("DWORD *")] uint* pcbCopied);

        [VtblIndex(19)]
        HRESULT RemoveFragmentFromCache([NativeTypeName("PCWSTR")] char* pszFragmentName);

        [VtblIndex(20)]
        HRESULT GetWorkerProcessSettings(IWpfSettings** ppWorkerProcessSettings);

        [VtblIndex(21)]
        HRESULT GetProtocolManagerCustomInterface([NativeTypeName("PCWSTR")] char* pProtocolManagerDll, [NativeTypeName("PCWSTR")] char* pProtocolManagerDllInitFunction, [NativeTypeName("DWORD")] uint dwCustomInterfaceId, [NativeTypeName("PVOID *")] void** ppCustomInterface);

        [VtblIndex(22)]
        BOOL SatisfiesPrecondition([NativeTypeName("PCWSTR")] char* pszPrecondition, BOOL* pfUnknownPrecondition = null);

        [VtblIndex(23)]
        IHttpTraceContext* GetTraceContext();

        [VtblIndex(24)]
        HRESULT RegisterFileChangeMonitor([NativeTypeName("PCWSTR")] char* pszPath, HANDLE hToken, IHttpFileMonitor** ppFileMonitor);

        [VtblIndex(25)]
        HRESULT GetExtendedInterface(HTTP_SERVER_INTERFACE_VERSION version, [NativeTypeName("PVOID *")] void** ppInterface);
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
    }
}
