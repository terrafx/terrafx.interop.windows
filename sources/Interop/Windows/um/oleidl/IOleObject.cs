// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000112-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleObject : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IOleObject
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleObject*, Guid*, void**, int>)(lpVtbl[0]))((IOleObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleObject*, uint>)(lpVtbl[1]))((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleObject*, uint>)(lpVtbl[2]))((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetClientSite(IOleClientSite* pClientSite)
        {
            return ((delegate* unmanaged<IOleObject*, IOleClientSite*, int>)(lpVtbl[3]))((IOleObject*)Unsafe.AsPointer(ref this), pClientSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetClientSite(IOleClientSite** ppClientSite)
        {
            return ((delegate* unmanaged<IOleObject*, IOleClientSite**, int>)(lpVtbl[4]))((IOleObject*)Unsafe.AsPointer(ref this), ppClientSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetHostNames([NativeTypeName("LPCOLESTR")] ushort* szContainerApp, [NativeTypeName("LPCOLESTR")] ushort* szContainerObj)
        {
            return ((delegate* unmanaged<IOleObject*, ushort*, ushort*, int>)(lpVtbl[5]))((IOleObject*)Unsafe.AsPointer(ref this), szContainerApp, szContainerObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Close([NativeTypeName("DWORD")] uint dwSaveOption)
        {
            return ((delegate* unmanaged<IOleObject*, uint, int>)(lpVtbl[6]))((IOleObject*)Unsafe.AsPointer(ref this), dwSaveOption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetMoniker([NativeTypeName("DWORD")] uint dwWhichMoniker, IMoniker* pmk)
        {
            return ((delegate* unmanaged<IOleObject*, uint, IMoniker*, int>)(lpVtbl[7]))((IOleObject*)Unsafe.AsPointer(ref this), dwWhichMoniker, pmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetMoniker([NativeTypeName("DWORD")] uint dwAssign, [NativeTypeName("DWORD")] uint dwWhichMoniker, IMoniker** ppmk)
        {
            return ((delegate* unmanaged<IOleObject*, uint, uint, IMoniker**, int>)(lpVtbl[8]))((IOleObject*)Unsafe.AsPointer(ref this), dwAssign, dwWhichMoniker, ppmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT InitFromData(IDataObject* pDataObject, BOOL fCreation, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IOleObject*, IDataObject*, BOOL, uint, int>)(lpVtbl[9]))((IOleObject*)Unsafe.AsPointer(ref this), pDataObject, fCreation, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetClipboardData([NativeTypeName("DWORD")] uint dwReserved, IDataObject** ppDataObject)
        {
            return ((delegate* unmanaged<IOleObject*, uint, IDataObject**, int>)(lpVtbl[10]))((IOleObject*)Unsafe.AsPointer(ref this), dwReserved, ppDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT DoVerb([NativeTypeName("LONG")] int iVerb, [NativeTypeName("LPMSG")] MSG* lpmsg, IOleClientSite* pActiveSite, [NativeTypeName("LONG")] int lindex, HWND hwndParent, [NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return ((delegate* unmanaged<IOleObject*, int, MSG*, IOleClientSite*, int, HWND, RECT*, int>)(lpVtbl[11]))((IOleObject*)Unsafe.AsPointer(ref this), iVerb, lpmsg, pActiveSite, lindex, hwndParent, lprcPosRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT EnumVerbs(IEnumOLEVERB** ppEnumOleVerb)
        {
            return ((delegate* unmanaged<IOleObject*, IEnumOLEVERB**, int>)(lpVtbl[12]))((IOleObject*)Unsafe.AsPointer(ref this), ppEnumOleVerb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT Update()
        {
            return ((delegate* unmanaged<IOleObject*, int>)(lpVtbl[13]))((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT IsUpToDate()
        {
            return ((delegate* unmanaged<IOleObject*, int>)(lpVtbl[14]))((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT GetUserClassID([NativeTypeName("CLSID *")] Guid* pClsid)
        {
            return ((delegate* unmanaged<IOleObject*, Guid*, int>)(lpVtbl[15]))((IOleObject*)Unsafe.AsPointer(ref this), pClsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT GetUserType([NativeTypeName("DWORD")] uint dwFormOfType, [NativeTypeName("LPOLESTR *")] ushort** pszUserType)
        {
            return ((delegate* unmanaged<IOleObject*, uint, ushort**, int>)(lpVtbl[16]))((IOleObject*)Unsafe.AsPointer(ref this), dwFormOfType, pszUserType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public HRESULT SetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("SIZEL *")] SIZE* psizel)
        {
            return ((delegate* unmanaged<IOleObject*, uint, SIZE*, int>)(lpVtbl[17]))((IOleObject*)Unsafe.AsPointer(ref this), dwDrawAspect, psizel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        public HRESULT GetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("SIZEL *")] SIZE* psizel)
        {
            return ((delegate* unmanaged<IOleObject*, uint, SIZE*, int>)(lpVtbl[18]))((IOleObject*)Unsafe.AsPointer(ref this), dwDrawAspect, psizel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT Advise(IAdviseSink* pAdvSink, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return ((delegate* unmanaged<IOleObject*, IAdviseSink*, uint*, int>)(lpVtbl[19]))((IOleObject*)Unsafe.AsPointer(ref this), pAdvSink, pdwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return ((delegate* unmanaged<IOleObject*, uint, int>)(lpVtbl[20]))((IOleObject*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        public HRESULT EnumAdvise(IEnumSTATDATA** ppenumAdvise)
        {
            return ((delegate* unmanaged<IOleObject*, IEnumSTATDATA**, int>)(lpVtbl[21]))((IOleObject*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        public HRESULT GetMiscStatus([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged<IOleObject*, uint, uint*, int>)(lpVtbl[22]))((IOleObject*)Unsafe.AsPointer(ref this), dwAspect, pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        public HRESULT SetColorScheme(LOGPALETTE* pLogpal)
        {
            return ((delegate* unmanaged<IOleObject*, LOGPALETTE*, int>)(lpVtbl[23]))((IOleObject*)Unsafe.AsPointer(ref this), pLogpal);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, uint> Release;

            [NativeTypeName("HRESULT (IOleClientSite *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, IOleClientSite*, int> SetClientSite;

            [NativeTypeName("HRESULT (IOleClientSite **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, IOleClientSite**, int> GetClientSite;

            [NativeTypeName("HRESULT (LPCOLESTR, LPCOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, ushort*, ushort*, int> SetHostNames;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, uint, int> Close;

            [NativeTypeName("HRESULT (DWORD, IMoniker *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, uint, IMoniker*, int> SetMoniker;

            [NativeTypeName("HRESULT (DWORD, DWORD, IMoniker **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, uint, uint, IMoniker**, int> GetMoniker;

            [NativeTypeName("HRESULT (IDataObject *, BOOL, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, IDataObject*, BOOL, uint, int> InitFromData;

            [NativeTypeName("HRESULT (DWORD, IDataObject **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, uint, IDataObject**, int> GetClipboardData;

            [NativeTypeName("HRESULT (LONG, LPMSG, IOleClientSite *, LONG, HWND, LPCRECT) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, int, MSG*, IOleClientSite*, int, HWND, RECT*, int> DoVerb;

            [NativeTypeName("HRESULT (IEnumOLEVERB **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, IEnumOLEVERB**, int> EnumVerbs;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, int> Update;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, int> IsUpToDate;

            [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, Guid*, int> GetUserClassID;

            [NativeTypeName("HRESULT (DWORD, LPOLESTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, uint, ushort**, int> GetUserType;

            [NativeTypeName("HRESULT (DWORD, SIZEL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, uint, SIZE*, int> SetExtent;

            [NativeTypeName("HRESULT (DWORD, SIZEL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, uint, SIZE*, int> GetExtent;

            [NativeTypeName("HRESULT (IAdviseSink *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, IAdviseSink*, uint*, int> Advise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, uint, int> Unadvise;

            [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, IEnumSTATDATA**, int> EnumAdvise;

            [NativeTypeName("HRESULT (DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, uint, uint*, int> GetMiscStatus;

            [NativeTypeName("HRESULT (LOGPALETTE *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleObject*, LOGPALETTE*, int> SetColorScheme;
        }
    }
}
