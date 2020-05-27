// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000112-0000-0000-C000-000000000046")]
    public unsafe partial struct IOleObject
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IOleObject* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IOleObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IOleObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetClientSite(IOleObject* pThis, [NativeTypeName("IOleClientSite *")] IOleClientSite* pClientSite);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClientSite(IOleObject* pThis, [NativeTypeName("IOleClientSite **")] IOleClientSite** ppClientSite);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetHostNames(IOleObject* pThis, [NativeTypeName("LPCOLESTR")] ushort* szContainerApp, [NativeTypeName("LPCOLESTR")] ushort* szContainerObj);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Close(IOleObject* pThis, [NativeTypeName("DWORD")] uint dwSaveOption);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetMoniker(IOleObject* pThis, [NativeTypeName("DWORD")] uint dwWhichMoniker, [NativeTypeName("IMoniker *")] IMoniker* pmk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMoniker(IOleObject* pThis, [NativeTypeName("DWORD")] uint dwAssign, [NativeTypeName("DWORD")] uint dwWhichMoniker, [NativeTypeName("IMoniker **")] IMoniker** ppmk);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _InitFromData(IOleObject* pThis, [NativeTypeName("IDataObject *")] IDataObject* pDataObject, [NativeTypeName("BOOL")] int fCreation, [NativeTypeName("DWORD")] uint dwReserved);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetClipboardData(IOleObject* pThis, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("IDataObject **")] IDataObject** ppDataObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _DoVerb(IOleObject* pThis, [NativeTypeName("LONG")] int iVerb, [NativeTypeName("LPMSG")] MSG* lpmsg, [NativeTypeName("IOleClientSite *")] IOleClientSite* pActiveSite, [NativeTypeName("LONG")] int lindex, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LPCRECT")] RECT* lprcPosRect);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumVerbs(IOleObject* pThis, [NativeTypeName("IEnumOLEVERB **")] IEnumOLEVERB** ppEnumOleVerb);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Update(IOleObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _IsUpToDate(IOleObject* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetUserClassID(IOleObject* pThis, [NativeTypeName("CLSID *")] Guid* pClsid);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetUserType(IOleObject* pThis, [NativeTypeName("DWORD")] uint dwFormOfType, [NativeTypeName("LPOLESTR *")] ushort** pszUserType);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetExtent(IOleObject* pThis, [NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("SIZEL *")] SIZE* psizel);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetExtent(IOleObject* pThis, [NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("SIZEL *")] SIZE* psizel);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Advise(IOleObject* pThis, [NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvSink, [NativeTypeName("DWORD *")] uint* pdwConnection);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Unadvise(IOleObject* pThis, [NativeTypeName("DWORD")] uint dwConnection);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _EnumAdvise(IOleObject* pThis, [NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetMiscStatus(IOleObject* pThis, [NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("DWORD *")] uint* pdwStatus);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _SetColorScheme(IOleObject* pThis, [NativeTypeName("LOGPALETTE *")] LOGPALETTE* pLogpal);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IOleObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClientSite([NativeTypeName("IOleClientSite *")] IOleClientSite* pClientSite)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetClientSite>(lpVtbl->SetClientSite)((IOleObject*)Unsafe.AsPointer(ref this), pClientSite);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClientSite([NativeTypeName("IOleClientSite **")] IOleClientSite** ppClientSite)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetClientSite>(lpVtbl->GetClientSite)((IOleObject*)Unsafe.AsPointer(ref this), ppClientSite);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHostNames([NativeTypeName("LPCOLESTR")] ushort* szContainerApp, [NativeTypeName("LPCOLESTR")] ushort* szContainerObj)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetHostNames>(lpVtbl->SetHostNames)((IOleObject*)Unsafe.AsPointer(ref this), szContainerApp, szContainerObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close([NativeTypeName("DWORD")] uint dwSaveOption)
        {
            return Marshal.GetDelegateForFunctionPointer<_Close>(lpVtbl->Close)((IOleObject*)Unsafe.AsPointer(ref this), dwSaveOption);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMoniker([NativeTypeName("DWORD")] uint dwWhichMoniker, [NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetMoniker>(lpVtbl->SetMoniker)((IOleObject*)Unsafe.AsPointer(ref this), dwWhichMoniker, pmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMoniker([NativeTypeName("DWORD")] uint dwAssign, [NativeTypeName("DWORD")] uint dwWhichMoniker, [NativeTypeName("IMoniker **")] IMoniker** ppmk)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMoniker>(lpVtbl->GetMoniker)((IOleObject*)Unsafe.AsPointer(ref this), dwAssign, dwWhichMoniker, ppmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitFromData([NativeTypeName("IDataObject *")] IDataObject* pDataObject, [NativeTypeName("BOOL")] int fCreation, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return Marshal.GetDelegateForFunctionPointer<_InitFromData>(lpVtbl->InitFromData)((IOleObject*)Unsafe.AsPointer(ref this), pDataObject, fCreation, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClipboardData([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("IDataObject **")] IDataObject** ppDataObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetClipboardData>(lpVtbl->GetClipboardData)((IOleObject*)Unsafe.AsPointer(ref this), dwReserved, ppDataObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoVerb([NativeTypeName("LONG")] int iVerb, [NativeTypeName("LPMSG")] MSG* lpmsg, [NativeTypeName("IOleClientSite *")] IOleClientSite* pActiveSite, [NativeTypeName("LONG")] int lindex, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return Marshal.GetDelegateForFunctionPointer<_DoVerb>(lpVtbl->DoVerb)((IOleObject*)Unsafe.AsPointer(ref this), iVerb, lpmsg, pActiveSite, lindex, hwndParent, lprcPosRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumVerbs([NativeTypeName("IEnumOLEVERB **")] IEnumOLEVERB** ppEnumOleVerb)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumVerbs>(lpVtbl->EnumVerbs)((IOleObject*)Unsafe.AsPointer(ref this), ppEnumOleVerb);
        }

        [return: NativeTypeName("HRESULT")]
        public int Update()
        {
            return Marshal.GetDelegateForFunctionPointer<_Update>(lpVtbl->Update)((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int IsUpToDate()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsUpToDate>(lpVtbl->IsUpToDate)((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserClassID([NativeTypeName("CLSID *")] Guid* pClsid)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetUserClassID>(lpVtbl->GetUserClassID)((IOleObject*)Unsafe.AsPointer(ref this), pClsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserType([NativeTypeName("DWORD")] uint dwFormOfType, [NativeTypeName("LPOLESTR *")] ushort** pszUserType)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetUserType>(lpVtbl->GetUserType)((IOleObject*)Unsafe.AsPointer(ref this), dwFormOfType, pszUserType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("SIZEL *")] SIZE* psizel)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetExtent>(lpVtbl->SetExtent)((IOleObject*)Unsafe.AsPointer(ref this), dwDrawAspect, psizel);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("SIZEL *")] SIZE* psizel)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetExtent>(lpVtbl->GetExtent)((IOleObject*)Unsafe.AsPointer(ref this), dwDrawAspect, psizel);
        }

        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvSink, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return Marshal.GetDelegateForFunctionPointer<_Advise>(lpVtbl->Advise)((IOleObject*)Unsafe.AsPointer(ref this), pAdvSink, pdwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return Marshal.GetDelegateForFunctionPointer<_Unadvise>(lpVtbl->Unadvise)((IOleObject*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdvise([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise)
        {
            return Marshal.GetDelegateForFunctionPointer<_EnumAdvise>(lpVtbl->EnumAdvise)((IOleObject*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMiscStatus([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetMiscStatus>(lpVtbl->GetMiscStatus)((IOleObject*)Unsafe.AsPointer(ref this), dwAspect, pdwStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorScheme([NativeTypeName("LOGPALETTE *")] LOGPALETTE* pLogpal)
        {
            return Marshal.GetDelegateForFunctionPointer<_SetColorScheme>(lpVtbl->SetColorScheme)((IOleObject*)Unsafe.AsPointer(ref this), pLogpal);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (IOleClientSite *) __attribute__((stdcall))")]
            public IntPtr SetClientSite;

            [NativeTypeName("HRESULT (IOleClientSite **) __attribute__((stdcall))")]
            public IntPtr GetClientSite;

            [NativeTypeName("HRESULT (LPCOLESTR, LPCOLESTR) __attribute__((stdcall))")]
            public IntPtr SetHostNames;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr Close;

            [NativeTypeName("HRESULT (DWORD, IMoniker *) __attribute__((stdcall))")]
            public IntPtr SetMoniker;

            [NativeTypeName("HRESULT (DWORD, DWORD, IMoniker **) __attribute__((stdcall))")]
            public IntPtr GetMoniker;

            [NativeTypeName("HRESULT (IDataObject *, BOOL, DWORD) __attribute__((stdcall))")]
            public IntPtr InitFromData;

            [NativeTypeName("HRESULT (DWORD, IDataObject **) __attribute__((stdcall))")]
            public IntPtr GetClipboardData;

            [NativeTypeName("HRESULT (LONG, LPMSG, IOleClientSite *, LONG, HWND, LPCRECT) __attribute__((stdcall))")]
            public IntPtr DoVerb;

            [NativeTypeName("HRESULT (IEnumOLEVERB **) __attribute__((stdcall))")]
            public IntPtr EnumVerbs;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr Update;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public IntPtr IsUpToDate;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public IntPtr GetUserClassID;

            [NativeTypeName("HRESULT (DWORD, LPOLESTR *) __attribute__((stdcall))")]
            public IntPtr GetUserType;

            [NativeTypeName("HRESULT (DWORD, SIZEL *) __attribute__((stdcall))")]
            public IntPtr SetExtent;

            [NativeTypeName("HRESULT (DWORD, SIZEL *) __attribute__((stdcall))")]
            public IntPtr GetExtent;

            [NativeTypeName("HRESULT (IAdviseSink *, DWORD *) __attribute__((stdcall))")]
            public IntPtr Advise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public IntPtr Unadvise;

            [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
            public IntPtr EnumAdvise;

            [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
            public IntPtr GetMiscStatus;

            [NativeTypeName("HRESULT (LOGPALETTE *) __attribute__((stdcall))")]
            public IntPtr SetColorScheme;
        }
    }
}
