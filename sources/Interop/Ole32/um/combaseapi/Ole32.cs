// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Ole32
    {
        private const string LibraryPath = "Ole32";

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetMalloc", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetMalloc([NativeTypeName("DWORD")] uint dwMemContext, [NativeTypeName("LPMALLOC *")] IMalloc** ppMalloc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CreateStreamOnHGlobal", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateStreamOnHGlobal([NativeTypeName("HGLOBAL")] void* hGlobal, [NativeTypeName("BOOL")] int fDeleteOnRelease, [NativeTypeName("LPSTREAM *")] IStream** ppstm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "GetHGlobalFromStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetHGlobalFromStream([NativeTypeName("LPSTREAM")] IStream* pstm, [NativeTypeName("HGLOBAL *")] void** phglobal);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoUninitialize", ExactSpelling = true)]
        public static extern void CoUninitialize();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetCurrentProcess", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CoGetCurrentProcess();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoInitializeEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInitializeEx([NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint dwCoInit);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetCallerTID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetCallerTID([NativeTypeName("LPDWORD")] uint* lpdwTID);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetCurrentLogicalThreadId", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetCurrentLogicalThreadId([NativeTypeName("GUID *")] Guid* pguid);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetContextToken", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetContextToken([NativeTypeName("ULONG_PTR *")] uint* pToken);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetDefaultContext", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetDefaultContext(APTTYPE aptType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetApartmentType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetApartmentType([NativeTypeName("APTTYPE *")] APTTYPE* pAptType, [NativeTypeName("APTTYPEQUALIFIER *")] APTTYPEQUALIFIER* pAptQualifier);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoDecodeProxy", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoDecodeProxy([NativeTypeName("DWORD")] uint dwClientPid, [NativeTypeName("UINT64")] ulong ui64ProxyAddress, [NativeTypeName("PServerInformation")] ServerInformation* pServerInformation);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoIncrementMTAUsage", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoIncrementMTAUsage([NativeTypeName("CO_MTA_USAGE_COOKIE *")] IntPtr* pCookie);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoDecrementMTAUsage", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoDecrementMTAUsage([NativeTypeName("CO_MTA_USAGE_COOKIE")] IntPtr Cookie);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoAllowUnmarshalerCLSID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoAllowUnmarshalerCLSID([NativeTypeName("const IID &")] Guid* clsid);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetObjectContext", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetObjectContext([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetClassObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetClassObject([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoRegisterClassObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRegisterClassObject([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpdwRegister);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoRevokeClassObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRevokeClassObject([NativeTypeName("DWORD")] uint dwRegister);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoResumeClassObjects", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoResumeClassObjects();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoSuspendClassObjects", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoSuspendClassObjects();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoAddRefServerProcess", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint CoAddRefServerProcess();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoReleaseServerProcess", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint CoReleaseServerProcess();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetPSClsid", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetPSClsid([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("CLSID *")] Guid* pClsid);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoRegisterPSClsid", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRegisterPSClsid([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("const IID &")] Guid* rclsid);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoRegisterSurrogate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRegisterSurrogate([NativeTypeName("LPSURROGATE")] ISurrogate* pSurrogate);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetMarshalSizeMax", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetMarshalSizeMax([NativeTypeName("ULONG *")] uint* pulSize, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("LPVOID")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoMarshalInterface", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoMarshalInterface([NativeTypeName("LPSTREAM")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("LPVOID")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoUnmarshalInterface", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoUnmarshalInterface([NativeTypeName("LPSTREAM")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoMarshalHresult", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoMarshalHresult([NativeTypeName("LPSTREAM")] IStream* pstm, [NativeTypeName("HRESULT")] int hresult);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoUnmarshalHresult", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoUnmarshalHresult([NativeTypeName("LPSTREAM")] IStream* pstm, [NativeTypeName("HRESULT *")] int* phresult);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoReleaseMarshalData", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoReleaseMarshalData([NativeTypeName("LPSTREAM")] IStream* pStm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoDisconnectObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoDisconnectObject([NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoLockObjectExternal", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoLockObjectExternal([NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("BOOL")] int fLock, [NativeTypeName("BOOL")] int fLastUnlockReleases);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetStandardMarshal", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetStandardMarshal([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("LPVOID")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("LPMARSHAL *")] IMarshal** ppMarshal);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetStdMarshalEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetStdMarshalEx([NativeTypeName("LPUNKNOWN")] IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint smexflags, [NativeTypeName("LPUNKNOWN *")] IUnknown** ppUnkInner);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoIsHandlerConnected", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CoIsHandlerConnected([NativeTypeName("LPUNKNOWN")] IUnknown* pUnk);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoMarshalInterThreadInterfaceInStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoMarshalInterThreadInterfaceInStream([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("LPSTREAM *")] IStream** ppStm);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetInterfaceAndReleaseStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetInterfaceAndReleaseStream([NativeTypeName("LPSTREAM")] IStream* pStm, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoCreateFreeThreadedMarshaler", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCreateFreeThreadedMarshaler([NativeTypeName("LPUNKNOWN")] IUnknown* punkOuter, [NativeTypeName("LPUNKNOWN *")] IUnknown** ppunkMarshal);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoFreeUnusedLibraries", ExactSpelling = true)]
        public static extern void CoFreeUnusedLibraries();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoFreeUnusedLibrariesEx", ExactSpelling = true)]
        public static extern void CoFreeUnusedLibrariesEx([NativeTypeName("DWORD")] uint dwUnloadDelay, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoDisconnectContext", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoDisconnectContext([NativeTypeName("DWORD")] uint dwTimeout);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoInitializeSecurity", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInitializeSecurity([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecDesc, [NativeTypeName("LONG")] int cAuthSvc, [NativeTypeName("SOLE_AUTHENTICATION_SERVICE *")] SOLE_AUTHENTICATION_SERVICE* asAuthSvc, [NativeTypeName("void *")] void* pReserved1, [NativeTypeName("DWORD")] uint dwAuthnLevel, [NativeTypeName("DWORD")] uint dwImpLevel, [NativeTypeName("void *")] void* pAuthList, [NativeTypeName("DWORD")] uint dwCapabilities, [NativeTypeName("void *")] void* pReserved3);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetCallContext", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetCallContext([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppInterface);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoQueryProxyBlanket", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoQueryProxyBlanket([NativeTypeName("IUnknown *")] IUnknown* pProxy, [NativeTypeName("DWORD *")] uint* pwAuthnSvc, [NativeTypeName("DWORD *")] uint* pAuthzSvc, [NativeTypeName("LPOLESTR *")] ushort** pServerPrincName, [NativeTypeName("DWORD *")] uint* pAuthnLevel, [NativeTypeName("DWORD *")] uint* pImpLevel, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE *")] void** pAuthInfo, [NativeTypeName("DWORD *")] uint* pCapabilites);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoSetProxyBlanket", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoSetProxyBlanket([NativeTypeName("IUnknown *")] IUnknown* pProxy, [NativeTypeName("DWORD")] uint dwAuthnSvc, [NativeTypeName("DWORD")] uint dwAuthzSvc, [NativeTypeName("OLECHAR *")] ushort* pServerPrincName, [NativeTypeName("DWORD")] uint dwAuthnLevel, [NativeTypeName("DWORD")] uint dwImpLevel, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE")] void* pAuthInfo, [NativeTypeName("DWORD")] uint dwCapabilities);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoCopyProxy", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCopyProxy([NativeTypeName("IUnknown *")] IUnknown* pProxy, [NativeTypeName("IUnknown **")] IUnknown** ppCopy);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoQueryClientBlanket", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoQueryClientBlanket([NativeTypeName("DWORD *")] uint* pAuthnSvc, [NativeTypeName("DWORD *")] uint* pAuthzSvc, [NativeTypeName("LPOLESTR *")] ushort** pServerPrincName, [NativeTypeName("DWORD *")] uint* pAuthnLevel, [NativeTypeName("DWORD *")] uint* pImpLevel, [NativeTypeName("RPC_AUTHZ_HANDLE *")] void** pPrivs, [NativeTypeName("DWORD *")] uint* pCapabilities);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoImpersonateClient", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoImpersonateClient();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoRevertToSelf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRevertToSelf();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoQueryAuthenticationServices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoQueryAuthenticationServices([NativeTypeName("DWORD *")] uint* pcAuthSvc, [NativeTypeName("SOLE_AUTHENTICATION_SERVICE **")] SOLE_AUTHENTICATION_SERVICE** asAuthSvc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoSwitchCallContext", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoSwitchCallContext([NativeTypeName("IUnknown *")] IUnknown* pNewObject, [NativeTypeName("IUnknown **")] IUnknown** ppOldObject);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoCreateInstance", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCreateInstance([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoCreateInstanceEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCreateInstanceEx([NativeTypeName("const IID &")] Guid* Clsid, [NativeTypeName("IUnknown *")] IUnknown* punkOuter, [NativeTypeName("DWORD")] uint dwClsCtx, [NativeTypeName("COSERVERINFO *")] COSERVERINFO* pServerInfo, [NativeTypeName("DWORD")] uint dwCount, [NativeTypeName("MULTI_QI *")] MULTI_QI* pResults);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoRegisterActivationFilter", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRegisterActivationFilter([NativeTypeName("IActivationFilter *")] IActivationFilter* pActivationFilter);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoCreateInstanceFromApp", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCreateInstanceFromApp([NativeTypeName("const IID &")] Guid* Clsid, [NativeTypeName("IUnknown *")] IUnknown* punkOuter, [NativeTypeName("DWORD")] uint dwClsCtx, [NativeTypeName("PVOID")] void* reserved, [NativeTypeName("DWORD")] uint dwCount, [NativeTypeName("MULTI_QI *")] MULTI_QI* pResults);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetCancelObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetCancelObject([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** ppUnk);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoSetCancelObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoSetCancelObject([NativeTypeName("IUnknown *")] IUnknown* pUnk);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoCancelCall", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCancelCall([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("ULONG")] uint ulTimeout);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoTestCancel", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoTestCancel();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoEnableCallCancellation", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoEnableCallCancellation([NativeTypeName("LPVOID")] void* pReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoDisableCallCancellation", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoDisableCallCancellation([NativeTypeName("LPVOID")] void* pReserved);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "StringFromCLSID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int StringFromCLSID([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPOLESTR *")] ushort** lplpsz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CLSIDFromString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CLSIDFromString([NativeTypeName("LPCOLESTR")] ushort* lpsz, [NativeTypeName("LPCLSID")] Guid* pclsid);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "StringFromIID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int StringFromIID([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPOLESTR *")] ushort** lplpsz);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "IIDFromString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IIDFromString([NativeTypeName("LPCOLESTR")] ushort* lpsz, [NativeTypeName("LPIID")] Guid* lpiid);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "ProgIDFromCLSID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ProgIDFromCLSID([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPOLESTR *")] ushort** lplpszProgID);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CLSIDFromProgID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CLSIDFromProgID([NativeTypeName("LPCOLESTR")] ushort* lpszProgID, [NativeTypeName("LPCLSID")] Guid* lpclsid);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "StringFromGUID2", ExactSpelling = true)]
        public static extern int StringFromGUID2([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("LPOLESTR")] ushort* lpsz, int cchMax);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoCreateGuid", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCreateGuid([NativeTypeName("GUID *")] Guid* pguid);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PropVariantCopy", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PropVariantCopy([NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarDest, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSrc);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "PropVariantClear", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PropVariantClear([NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvar);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "FreePropVariantArray", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int FreePropVariantArray([NativeTypeName("ULONG")] uint cVariants, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* rgvars);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoWaitForMultipleHandles", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoWaitForMultipleHandles([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("ULONG")] uint cHandles, [NativeTypeName("LPHANDLE")] void** pHandles, [NativeTypeName("LPDWORD")] uint* lpdwindex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoWaitForMultipleObjects", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoWaitForMultipleObjects([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("ULONG")] uint cHandles, [NativeTypeName("const HANDLE *")] void** pHandles, [NativeTypeName("LPDWORD")] uint* lpdwindex);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoGetTreatAsClass", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetTreatAsClass([NativeTypeName("const IID &")] Guid* clsidOld, [NativeTypeName("LPCLSID")] Guid* pClsidNew);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoInvalidateRemoteMachineBindings", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInvalidateRemoteMachineBindings([NativeTypeName("LPOLESTR")] ushort* pszMachineName);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "RoGetAgileReference", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoGetAgileReference([NativeTypeName("enum AgileReferenceOptions")] AgileReferenceOptions options, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* pUnk, [NativeTypeName("IAgileReference **")] IAgileReference** ppAgileReference);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DllGetClassObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DllGetClassObject([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "DllCanUnloadNow", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DllCanUnloadNow();

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoTaskMemAlloc", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CoTaskMemAlloc([NativeTypeName("SIZE_T")] uint cb);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoTaskMemRealloc", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CoTaskMemRealloc([NativeTypeName("LPVOID")] void* pv, [NativeTypeName("SIZE_T")] uint cb);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoTaskMemFree", ExactSpelling = true)]
        public static extern void CoTaskMemFree([NativeTypeName("LPVOID")] void* pv);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CoFileTimeNow", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoFileTimeNow([NativeTypeName("FILETIME *")] FILETIME* lpFileTime);

        [DllImport(LibraryPath, CallingConvention = CallingConvention.Winapi, EntryPoint = "CLSIDFromProgIDEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CLSIDFromProgIDEx([NativeTypeName("LPCOLESTR")] ushort* lpszProgID, [NativeTypeName("LPCLSID")] Guid* lpclsid);
    }
}
