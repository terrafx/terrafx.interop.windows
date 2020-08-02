// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("Ole32", EntryPoint = "CoGetMalloc", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetMalloc([NativeTypeName("DWORD")] uint dwMemContext, [NativeTypeName("LPMALLOC *")] IMalloc** ppMalloc);

        [DllImport("Ole32", EntryPoint = "CreateStreamOnHGlobal", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CreateStreamOnHGlobal([NativeTypeName("HGLOBAL")] IntPtr hGlobal, [NativeTypeName("BOOL")] int fDeleteOnRelease, [NativeTypeName("LPSTREAM *")] IStream** ppstm);

        [DllImport("Ole32", EntryPoint = "GetHGlobalFromStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int GetHGlobalFromStream([NativeTypeName("LPSTREAM")] IStream* pstm, [NativeTypeName("HGLOBAL *")] IntPtr* phglobal);

        [DllImport("Ole32", EntryPoint = "CoUninitialize", ExactSpelling = true)]
        public static extern void CoUninitialize();

        [DllImport("Ole32", EntryPoint = "CoGetCurrentProcess", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint CoGetCurrentProcess();

        [DllImport("Ole32", EntryPoint = "CoInitializeEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInitializeEx([NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint dwCoInit);

        [DllImport("Ole32", EntryPoint = "CoGetCallerTID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetCallerTID([NativeTypeName("LPDWORD")] uint* lpdwTID);

        [DllImport("Ole32", EntryPoint = "CoGetCurrentLogicalThreadId", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetCurrentLogicalThreadId([NativeTypeName("GUID *")] Guid* pguid);

        [DllImport("Ole32", EntryPoint = "CoGetContextToken", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetContextToken([NativeTypeName("ULONG_PTR *")] nuint* pToken);

        [DllImport("Ole32", EntryPoint = "CoGetDefaultContext", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetDefaultContext(APTTYPE aptType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppv);

        [DllImport("Ole32", EntryPoint = "CoGetApartmentType", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetApartmentType([NativeTypeName("APTTYPE *")] APTTYPE* pAptType, [NativeTypeName("APTTYPEQUALIFIER *")] APTTYPEQUALIFIER* pAptQualifier);

        [DllImport("combase", EntryPoint = "CoDecodeProxy", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoDecodeProxy([NativeTypeName("DWORD")] uint dwClientPid, [NativeTypeName("UINT64")] ulong ui64ProxyAddress, [NativeTypeName("PServerInformation")] ServerInformation* pServerInformation);

        [DllImport("Ole32", EntryPoint = "CoIncrementMTAUsage", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoIncrementMTAUsage([NativeTypeName("CO_MTA_USAGE_COOKIE *")] IntPtr* pCookie);

        [DllImport("Ole32", EntryPoint = "CoDecrementMTAUsage", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoDecrementMTAUsage([NativeTypeName("CO_MTA_USAGE_COOKIE")] IntPtr Cookie);

        [DllImport("Ole32", EntryPoint = "CoAllowUnmarshalerCLSID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoAllowUnmarshalerCLSID([NativeTypeName("const IID &")] Guid* clsid);

        [DllImport("Ole32", EntryPoint = "CoGetObjectContext", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetObjectContext([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("Ole32", EntryPoint = "CoGetClassObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetClassObject([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("Ole32", EntryPoint = "CoRegisterClassObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRegisterClassObject([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPDWORD")] uint* lpdwRegister);

        [DllImport("Ole32", EntryPoint = "CoRevokeClassObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRevokeClassObject([NativeTypeName("DWORD")] uint dwRegister);

        [DllImport("Ole32", EntryPoint = "CoResumeClassObjects", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoResumeClassObjects();

        [DllImport("Ole32", EntryPoint = "CoSuspendClassObjects", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoSuspendClassObjects();

        [DllImport("Ole32", EntryPoint = "CoAddRefServerProcess", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint CoAddRefServerProcess();

        [DllImport("Ole32", EntryPoint = "CoReleaseServerProcess", ExactSpelling = true)]
        [return: NativeTypeName("ULONG")]
        public static extern uint CoReleaseServerProcess();

        [DllImport("Ole32", EntryPoint = "CoGetPSClsid", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetPSClsid([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("CLSID *")] Guid* pClsid);

        [DllImport("Ole32", EntryPoint = "CoRegisterPSClsid", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRegisterPSClsid([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("const IID &")] Guid* rclsid);

        [DllImport("Ole32", EntryPoint = "CoRegisterSurrogate", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRegisterSurrogate([NativeTypeName("LPSURROGATE")] ISurrogate* pSurrogate);

        [DllImport("Ole32", EntryPoint = "CoGetMarshalSizeMax", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetMarshalSizeMax([NativeTypeName("ULONG *")] uint* pulSize, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("LPVOID")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags);

        [DllImport("Ole32", EntryPoint = "CoMarshalInterface", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoMarshalInterface([NativeTypeName("LPSTREAM")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("LPVOID")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags);

        [DllImport("Ole32", EntryPoint = "CoUnmarshalInterface", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoUnmarshalInterface([NativeTypeName("LPSTREAM")] IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("Ole32", EntryPoint = "CoMarshalHresult", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoMarshalHresult([NativeTypeName("LPSTREAM")] IStream* pstm, [NativeTypeName("HRESULT")] int hresult);

        [DllImport("Ole32", EntryPoint = "CoUnmarshalHresult", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoUnmarshalHresult([NativeTypeName("LPSTREAM")] IStream* pstm, [NativeTypeName("HRESULT *")] int* phresult);

        [DllImport("Ole32", EntryPoint = "CoReleaseMarshalData", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoReleaseMarshalData([NativeTypeName("LPSTREAM")] IStream* pStm);

        [DllImport("Ole32", EntryPoint = "CoDisconnectObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoDisconnectObject([NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("Ole32", EntryPoint = "CoLockObjectExternal", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoLockObjectExternal([NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("BOOL")] int fLock, [NativeTypeName("BOOL")] int fLastUnlockReleases);

        [DllImport("Ole32", EntryPoint = "CoGetStandardMarshal", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetStandardMarshal([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("DWORD")] uint dwDestContext, [NativeTypeName("LPVOID")] void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("LPMARSHAL *")] IMarshal** ppMarshal);

        [DllImport("Ole32", EntryPoint = "CoGetStdMarshalEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetStdMarshalEx([NativeTypeName("LPUNKNOWN")] IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint smexflags, [NativeTypeName("LPUNKNOWN *")] IUnknown** ppUnkInner);

        [DllImport("Ole32", EntryPoint = "CoIsHandlerConnected", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int CoIsHandlerConnected([NativeTypeName("LPUNKNOWN")] IUnknown* pUnk);

        [DllImport("Ole32", EntryPoint = "CoMarshalInterThreadInterfaceInStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoMarshalInterThreadInterfaceInStream([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnk, [NativeTypeName("LPSTREAM *")] IStream** ppStm);

        [DllImport("Ole32", EntryPoint = "CoGetInterfaceAndReleaseStream", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetInterfaceAndReleaseStream([NativeTypeName("LPSTREAM")] IStream* pStm, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("Ole32", EntryPoint = "CoCreateFreeThreadedMarshaler", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCreateFreeThreadedMarshaler([NativeTypeName("LPUNKNOWN")] IUnknown* punkOuter, [NativeTypeName("LPUNKNOWN *")] IUnknown** ppunkMarshal);

        [DllImport("Ole32", EntryPoint = "CoFreeUnusedLibraries", ExactSpelling = true)]
        public static extern void CoFreeUnusedLibraries();

        [DllImport("combase", EntryPoint = "CoFreeUnusedLibrariesEx", ExactSpelling = true)]
        public static extern void CoFreeUnusedLibrariesEx([NativeTypeName("DWORD")] uint dwUnloadDelay, [NativeTypeName("DWORD")] uint dwReserved);

        [DllImport("Ole32", EntryPoint = "CoDisconnectContext", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoDisconnectContext([NativeTypeName("DWORD")] uint dwTimeout);

        [DllImport("Ole32", EntryPoint = "CoInitializeSecurity", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInitializeSecurity([NativeTypeName("PSECURITY_DESCRIPTOR")] void* pSecDesc, [NativeTypeName("LONG")] int cAuthSvc, [NativeTypeName("SOLE_AUTHENTICATION_SERVICE *")] SOLE_AUTHENTICATION_SERVICE* asAuthSvc, [NativeTypeName("void *")] void* pReserved1, [NativeTypeName("DWORD")] uint dwAuthnLevel, [NativeTypeName("DWORD")] uint dwImpLevel, [NativeTypeName("void *")] void* pAuthList, [NativeTypeName("DWORD")] uint dwCapabilities, [NativeTypeName("void *")] void* pReserved3);

        [DllImport("Ole32", EntryPoint = "CoGetCallContext", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetCallContext([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppInterface);

        [DllImport("Ole32", EntryPoint = "CoQueryProxyBlanket", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoQueryProxyBlanket([NativeTypeName("IUnknown *")] IUnknown* pProxy, [NativeTypeName("DWORD *")] uint* pwAuthnSvc, [NativeTypeName("DWORD *")] uint* pAuthzSvc, [NativeTypeName("LPOLESTR *")] ushort** pServerPrincName, [NativeTypeName("DWORD *")] uint* pAuthnLevel, [NativeTypeName("DWORD *")] uint* pImpLevel, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE *")] void** pAuthInfo, [NativeTypeName("DWORD *")] uint* pCapabilites);

        [DllImport("Ole32", EntryPoint = "CoSetProxyBlanket", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoSetProxyBlanket([NativeTypeName("IUnknown *")] IUnknown* pProxy, [NativeTypeName("DWORD")] uint dwAuthnSvc, [NativeTypeName("DWORD")] uint dwAuthzSvc, [NativeTypeName("OLECHAR *")] ushort* pServerPrincName, [NativeTypeName("DWORD")] uint dwAuthnLevel, [NativeTypeName("DWORD")] uint dwImpLevel, [NativeTypeName("RPC_AUTH_IDENTITY_HANDLE")] void* pAuthInfo, [NativeTypeName("DWORD")] uint dwCapabilities);

        [DllImport("Ole32", EntryPoint = "CoCopyProxy", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCopyProxy([NativeTypeName("IUnknown *")] IUnknown* pProxy, [NativeTypeName("IUnknown **")] IUnknown** ppCopy);

        [DllImport("Ole32", EntryPoint = "CoQueryClientBlanket", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoQueryClientBlanket([NativeTypeName("DWORD *")] uint* pAuthnSvc, [NativeTypeName("DWORD *")] uint* pAuthzSvc, [NativeTypeName("LPOLESTR *")] ushort** pServerPrincName, [NativeTypeName("DWORD *")] uint* pAuthnLevel, [NativeTypeName("DWORD *")] uint* pImpLevel, [NativeTypeName("RPC_AUTHZ_HANDLE *")] void** pPrivs, [NativeTypeName("DWORD *")] uint* pCapabilities);

        [DllImport("Ole32", EntryPoint = "CoImpersonateClient", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoImpersonateClient();

        [DllImport("Ole32", EntryPoint = "CoRevertToSelf", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRevertToSelf();

        [DllImport("Ole32", EntryPoint = "CoQueryAuthenticationServices", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoQueryAuthenticationServices([NativeTypeName("DWORD *")] uint* pcAuthSvc, [NativeTypeName("SOLE_AUTHENTICATION_SERVICE **")] SOLE_AUTHENTICATION_SERVICE** asAuthSvc);

        [DllImport("Ole32", EntryPoint = "CoSwitchCallContext", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoSwitchCallContext([NativeTypeName("IUnknown *")] IUnknown* pNewObject, [NativeTypeName("IUnknown **")] IUnknown** ppOldObject);

        [DllImport("Ole32", EntryPoint = "CoCreateInstance", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCreateInstance([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPUNKNOWN")] IUnknown* pUnkOuter, [NativeTypeName("DWORD")] uint dwClsContext, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("Ole32", EntryPoint = "CoCreateInstanceEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCreateInstanceEx([NativeTypeName("const IID &")] Guid* Clsid, [NativeTypeName("IUnknown *")] IUnknown* punkOuter, [NativeTypeName("DWORD")] uint dwClsCtx, [NativeTypeName("COSERVERINFO *")] COSERVERINFO* pServerInfo, [NativeTypeName("DWORD")] uint dwCount, [NativeTypeName("MULTI_QI *")] MULTI_QI* pResults);

        [DllImport("combase", EntryPoint = "CoCreateInstanceFromApp", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCreateInstanceFromApp([NativeTypeName("const IID &")] Guid* Clsid, [NativeTypeName("IUnknown *")] IUnknown* punkOuter, [NativeTypeName("DWORD")] uint dwClsCtx, [NativeTypeName("PVOID")] void* reserved, [NativeTypeName("DWORD")] uint dwCount, [NativeTypeName("MULTI_QI *")] MULTI_QI* pResults);

        [DllImport("Ole32", EntryPoint = "CoRegisterActivationFilter", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRegisterActivationFilter([NativeTypeName("IActivationFilter *")] IActivationFilter* pActivationFilter);

        [DllImport("Ole32", EntryPoint = "CoGetCancelObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetCancelObject([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("const IID &")] Guid* iid, [NativeTypeName("void **")] void** ppUnk);

        [DllImport("Ole32", EntryPoint = "CoSetCancelObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoSetCancelObject([NativeTypeName("IUnknown *")] IUnknown* pUnk);

        [DllImport("Ole32", EntryPoint = "CoCancelCall", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCancelCall([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("ULONG")] uint ulTimeout);

        [DllImport("Ole32", EntryPoint = "CoTestCancel", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoTestCancel();

        [DllImport("Ole32", EntryPoint = "CoEnableCallCancellation", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoEnableCallCancellation([NativeTypeName("LPVOID")] void* pReserved);

        [DllImport("Ole32", EntryPoint = "CoDisableCallCancellation", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoDisableCallCancellation([NativeTypeName("LPVOID")] void* pReserved);

        [DllImport("Ole32", EntryPoint = "StringFromCLSID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int StringFromCLSID([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPOLESTR *")] ushort** lplpsz);

        [DllImport("Ole32", EntryPoint = "CLSIDFromString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CLSIDFromString([NativeTypeName("LPCOLESTR")] ushort* lpsz, [NativeTypeName("LPCLSID")] Guid* pclsid);

        [DllImport("Ole32", EntryPoint = "StringFromIID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int StringFromIID([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LPOLESTR *")] ushort** lplpsz);

        [DllImport("Ole32", EntryPoint = "IIDFromString", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int IIDFromString([NativeTypeName("LPCOLESTR")] ushort* lpsz, [NativeTypeName("LPIID")] Guid* lpiid);

        [DllImport("Ole32", EntryPoint = "ProgIDFromCLSID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int ProgIDFromCLSID([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPOLESTR *")] ushort** lplpszProgID);

        [DllImport("Ole32", EntryPoint = "CLSIDFromProgID", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CLSIDFromProgID([NativeTypeName("LPCOLESTR")] ushort* lpszProgID, [NativeTypeName("LPCLSID")] Guid* lpclsid);

        [DllImport("Ole32", EntryPoint = "StringFromGUID2", ExactSpelling = true)]
        public static extern int StringFromGUID2([NativeTypeName("const GUID &")] Guid* rguid, [NativeTypeName("LPOLESTR")] ushort* lpsz, int cchMax);

        [DllImport("Ole32", EntryPoint = "CoCreateGuid", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoCreateGuid([NativeTypeName("GUID *")] Guid* pguid);

        [DllImport("Ole32", EntryPoint = "PropVariantCopy", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PropVariantCopy([NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvarDest, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSrc);

        [DllImport("Ole32", EntryPoint = "PropVariantClear", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PropVariantClear([NativeTypeName("PROPVARIANT *")] PROPVARIANT* pvar);

        [DllImport("Ole32", EntryPoint = "FreePropVariantArray", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int FreePropVariantArray([NativeTypeName("ULONG")] uint cVariants, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* rgvars);

        [DllImport("Ole32", EntryPoint = "CoWaitForMultipleHandles", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoWaitForMultipleHandles([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("ULONG")] uint cHandles, [NativeTypeName("LPHANDLE")] IntPtr* pHandles, [NativeTypeName("LPDWORD")] uint* lpdwindex);

        [DllImport("combase", EntryPoint = "CoWaitForMultipleObjects", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoWaitForMultipleObjects([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwTimeout, [NativeTypeName("ULONG")] uint cHandles, [NativeTypeName("const HANDLE *")] IntPtr* pHandles, [NativeTypeName("LPDWORD")] uint* lpdwindex);

        [DllImport("Ole32", EntryPoint = "CoGetTreatAsClass", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoGetTreatAsClass([NativeTypeName("const IID &")] Guid* clsidOld, [NativeTypeName("LPCLSID")] Guid* pClsidNew);

        [DllImport("Ole32", EntryPoint = "CoInvalidateRemoteMachineBindings", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoInvalidateRemoteMachineBindings([NativeTypeName("LPOLESTR")] ushort* pszMachineName);

        [DllImport("Ole32", EntryPoint = "RoGetAgileReference", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int RoGetAgileReference([NativeTypeName("enum AgileReferenceOptions")] AgileReferenceOptions options, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("IUnknown *")] IUnknown* pUnk, [NativeTypeName("IAgileReference **")] IAgileReference** ppAgileReference);

        [DllImport("Ole32", EntryPoint = "DllGetClassObject", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DllGetClassObject([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppv);

        [DllImport("Ole32", EntryPoint = "DllCanUnloadNow", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int DllCanUnloadNow();

        [DllImport("Ole32", EntryPoint = "CoTaskMemAlloc", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CoTaskMemAlloc([NativeTypeName("SIZE_T")] nuint cb);

        [DllImport("Ole32", EntryPoint = "CoTaskMemRealloc", ExactSpelling = true)]
        [return: NativeTypeName("LPVOID")]
        public static extern void* CoTaskMemRealloc([NativeTypeName("LPVOID")] void* pv, [NativeTypeName("SIZE_T")] nuint cb);

        [DllImport("Ole32", EntryPoint = "CoTaskMemFree", ExactSpelling = true)]
        public static extern void CoTaskMemFree([NativeTypeName("LPVOID")] void* pv);

        [DllImport("Ole32", EntryPoint = "CoFileTimeNow", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoFileTimeNow([NativeTypeName("FILETIME *")] FILETIME* lpFileTime);

        [DllImport("Ole32", EntryPoint = "CLSIDFromProgIDEx", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CLSIDFromProgIDEx([NativeTypeName("LPCOLESTR")] ushort* lpszProgID, [NativeTypeName("LPCLSID")] Guid* lpclsid);

        [DllImport("Ole32", EntryPoint = "CoRegisterDeviceCatalog", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRegisterDeviceCatalog([NativeTypeName("PCWSTR")] ushort* deviceInstanceId, [NativeTypeName("CO_DEVICE_CATALOG_COOKIE *")] IntPtr* cookie);

        [DllImport("Ole32", EntryPoint = "CoRevokeDeviceCatalog", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int CoRevokeDeviceCatalog([NativeTypeName("CO_DEVICE_CATALOG_COOKIE")] IntPtr cookie);
    }
}
