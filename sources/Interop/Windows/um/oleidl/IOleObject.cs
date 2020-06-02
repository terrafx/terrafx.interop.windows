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

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IOleObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int SetClientSite([NativeTypeName("IOleClientSite *")] IOleClientSite* pClientSite)
        {
            return lpVtbl->SetClientSite((IOleObject*)Unsafe.AsPointer(ref this), pClientSite);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClientSite([NativeTypeName("IOleClientSite **")] IOleClientSite** ppClientSite)
        {
            return lpVtbl->GetClientSite((IOleObject*)Unsafe.AsPointer(ref this), ppClientSite);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetHostNames([NativeTypeName("LPCOLESTR")] ushort* szContainerApp, [NativeTypeName("LPCOLESTR")] ushort* szContainerObj)
        {
            return lpVtbl->SetHostNames((IOleObject*)Unsafe.AsPointer(ref this), szContainerApp, szContainerObj);
        }

        [return: NativeTypeName("HRESULT")]
        public int Close([NativeTypeName("DWORD")] uint dwSaveOption)
        {
            return lpVtbl->Close((IOleObject*)Unsafe.AsPointer(ref this), dwSaveOption);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetMoniker([NativeTypeName("DWORD")] uint dwWhichMoniker, [NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            return lpVtbl->SetMoniker((IOleObject*)Unsafe.AsPointer(ref this), dwWhichMoniker, pmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMoniker([NativeTypeName("DWORD")] uint dwAssign, [NativeTypeName("DWORD")] uint dwWhichMoniker, [NativeTypeName("IMoniker **")] IMoniker** ppmk)
        {
            return lpVtbl->GetMoniker((IOleObject*)Unsafe.AsPointer(ref this), dwAssign, dwWhichMoniker, ppmk);
        }

        [return: NativeTypeName("HRESULT")]
        public int InitFromData([NativeTypeName("IDataObject *")] IDataObject* pDataObject, [NativeTypeName("BOOL")] int fCreation, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return lpVtbl->InitFromData((IOleObject*)Unsafe.AsPointer(ref this), pDataObject, fCreation, dwReserved);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetClipboardData([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("IDataObject **")] IDataObject** ppDataObject)
        {
            return lpVtbl->GetClipboardData((IOleObject*)Unsafe.AsPointer(ref this), dwReserved, ppDataObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int DoVerb([NativeTypeName("LONG")] int iVerb, [NativeTypeName("LPMSG")] MSG* lpmsg, [NativeTypeName("IOleClientSite *")] IOleClientSite* pActiveSite, [NativeTypeName("LONG")] int lindex, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return lpVtbl->DoVerb((IOleObject*)Unsafe.AsPointer(ref this), iVerb, lpmsg, pActiveSite, lindex, hwndParent, lprcPosRect);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumVerbs([NativeTypeName("IEnumOLEVERB **")] IEnumOLEVERB** ppEnumOleVerb)
        {
            return lpVtbl->EnumVerbs((IOleObject*)Unsafe.AsPointer(ref this), ppEnumOleVerb);
        }

        [return: NativeTypeName("HRESULT")]
        public int Update()
        {
            return lpVtbl->Update((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int IsUpToDate()
        {
            return lpVtbl->IsUpToDate((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserClassID([NativeTypeName("CLSID *")] Guid* pClsid)
        {
            return lpVtbl->GetUserClassID((IOleObject*)Unsafe.AsPointer(ref this), pClsid);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetUserType([NativeTypeName("DWORD")] uint dwFormOfType, [NativeTypeName("LPOLESTR *")] ushort** pszUserType)
        {
            return lpVtbl->GetUserType((IOleObject*)Unsafe.AsPointer(ref this), dwFormOfType, pszUserType);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("SIZEL *")] SIZE* psizel)
        {
            return lpVtbl->SetExtent((IOleObject*)Unsafe.AsPointer(ref this), dwDrawAspect, psizel);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("SIZEL *")] SIZE* psizel)
        {
            return lpVtbl->GetExtent((IOleObject*)Unsafe.AsPointer(ref this), dwDrawAspect, psizel);
        }

        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvSink, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return lpVtbl->Advise((IOleObject*)Unsafe.AsPointer(ref this), pAdvSink, pdwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return lpVtbl->Unadvise((IOleObject*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [return: NativeTypeName("HRESULT")]
        public int EnumAdvise([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise)
        {
            return lpVtbl->EnumAdvise((IOleObject*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetMiscStatus([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return lpVtbl->GetMiscStatus((IOleObject*)Unsafe.AsPointer(ref this), dwAspect, pdwStatus);
        }

        [return: NativeTypeName("HRESULT")]
        public int SetColorScheme([NativeTypeName("LOGPALETTE *")] LOGPALETTE* pLogpal)
        {
            return lpVtbl->SetColorScheme((IOleObject*)Unsafe.AsPointer(ref this), pLogpal);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, uint> Release;

            [NativeTypeName("HRESULT (IOleClientSite *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, IOleClientSite*, int> SetClientSite;

            [NativeTypeName("HRESULT (IOleClientSite **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, IOleClientSite**, int> GetClientSite;

            [NativeTypeName("HRESULT (LPCOLESTR, LPCOLESTR) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, ushort*, ushort*, int> SetHostNames;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, uint, int> Close;

            [NativeTypeName("HRESULT (DWORD, IMoniker *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, uint, IMoniker*, int> SetMoniker;

            [NativeTypeName("HRESULT (DWORD, DWORD, IMoniker **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, uint, uint, IMoniker**, int> GetMoniker;

            [NativeTypeName("HRESULT (IDataObject *, BOOL, DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, IDataObject*, int, uint, int> InitFromData;

            [NativeTypeName("HRESULT (DWORD, IDataObject **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, uint, IDataObject**, int> GetClipboardData;

            [NativeTypeName("HRESULT (LONG, LPMSG, IOleClientSite *, LONG, HWND, LPCRECT) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, int, MSG*, IOleClientSite*, int, IntPtr, RECT*, int> DoVerb;

            [NativeTypeName("HRESULT (IEnumOLEVERB **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, IEnumOLEVERB**, int> EnumVerbs;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, int> Update;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, int> IsUpToDate;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, Guid*, int> GetUserClassID;

            [NativeTypeName("HRESULT (DWORD, LPOLESTR *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, uint, ushort**, int> GetUserType;

            [NativeTypeName("HRESULT (DWORD, SIZEL *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, uint, SIZE*, int> SetExtent;

            [NativeTypeName("HRESULT (DWORD, SIZEL *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, uint, SIZE*, int> GetExtent;

            [NativeTypeName("HRESULT (IAdviseSink *, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, IAdviseSink*, uint*, int> Advise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, uint, int> Unadvise;

            [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, IEnumSTATDATA**, int> EnumAdvise;

            [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, uint, uint*, int> GetMiscStatus;

            [NativeTypeName("HRESULT (LOGPALETTE *) __attribute__((stdcall))")]
            public delegate* stdcall<IOleObject*, LOGPALETTE*, int> SetColorScheme;
        }
    }
}
