// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000112-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleObject : IUnknown")]
    public unsafe partial struct IOleObject
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, Guid*, void**, int>)(lpVtbl[0]))((IOleObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, uint>)(lpVtbl[1]))((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, uint>)(lpVtbl[2]))((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetClientSite([NativeTypeName("IOleClientSite *")] IOleClientSite* pClientSite)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, IOleClientSite*, int>)(lpVtbl[3]))((IOleObject*)Unsafe.AsPointer(ref this), pClientSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClientSite([NativeTypeName("IOleClientSite **")] IOleClientSite** ppClientSite)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, IOleClientSite**, int>)(lpVtbl[4]))((IOleObject*)Unsafe.AsPointer(ref this), ppClientSite);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetHostNames([NativeTypeName("LPCOLESTR")] ushort* szContainerApp, [NativeTypeName("LPCOLESTR")] ushort* szContainerObj)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, ushort*, ushort*, int>)(lpVtbl[5]))((IOleObject*)Unsafe.AsPointer(ref this), szContainerApp, szContainerObj);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close([NativeTypeName("DWORD")] uint dwSaveOption)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, uint, int>)(lpVtbl[6]))((IOleObject*)Unsafe.AsPointer(ref this), dwSaveOption);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMoniker([NativeTypeName("DWORD")] uint dwWhichMoniker, [NativeTypeName("IMoniker *")] IMoniker* pmk)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, uint, IMoniker*, int>)(lpVtbl[7]))((IOleObject*)Unsafe.AsPointer(ref this), dwWhichMoniker, pmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMoniker([NativeTypeName("DWORD")] uint dwAssign, [NativeTypeName("DWORD")] uint dwWhichMoniker, [NativeTypeName("IMoniker **")] IMoniker** ppmk)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, uint, uint, IMoniker**, int>)(lpVtbl[8]))((IOleObject*)Unsafe.AsPointer(ref this), dwAssign, dwWhichMoniker, ppmk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int InitFromData([NativeTypeName("IDataObject *")] IDataObject* pDataObject, [NativeTypeName("BOOL")] int fCreation, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, IDataObject*, int, uint, int>)(lpVtbl[9]))((IOleObject*)Unsafe.AsPointer(ref this), pDataObject, fCreation, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClipboardData([NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("IDataObject **")] IDataObject** ppDataObject)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, uint, IDataObject**, int>)(lpVtbl[10]))((IOleObject*)Unsafe.AsPointer(ref this), dwReserved, ppDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DoVerb([NativeTypeName("LONG")] int iVerb, [NativeTypeName("LPMSG")] MSG* lpmsg, [NativeTypeName("IOleClientSite *")] IOleClientSite* pActiveSite, [NativeTypeName("LONG")] int lindex, [NativeTypeName("HWND")] IntPtr hwndParent, [NativeTypeName("LPCRECT")] RECT* lprcPosRect)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, int, MSG*, IOleClientSite*, int, IntPtr, RECT*, int>)(lpVtbl[11]))((IOleObject*)Unsafe.AsPointer(ref this), iVerb, lpmsg, pActiveSite, lindex, hwndParent, lprcPosRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumVerbs([NativeTypeName("IEnumOLEVERB **")] IEnumOLEVERB** ppEnumOleVerb)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, IEnumOLEVERB**, int>)(lpVtbl[12]))((IOleObject*)Unsafe.AsPointer(ref this), ppEnumOleVerb);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Update()
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, int>)(lpVtbl[13]))((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsUpToDate()
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, int>)(lpVtbl[14]))((IOleObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUserClassID([NativeTypeName("CLSID *")] Guid* pClsid)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, Guid*, int>)(lpVtbl[15]))((IOleObject*)Unsafe.AsPointer(ref this), pClsid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUserType([NativeTypeName("DWORD")] uint dwFormOfType, [NativeTypeName("LPOLESTR *")] ushort** pszUserType)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, uint, ushort**, int>)(lpVtbl[16]))((IOleObject*)Unsafe.AsPointer(ref this), dwFormOfType, pszUserType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("SIZEL *")] SIZE* psizel)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, uint, SIZE*, int>)(lpVtbl[17]))((IOleObject*)Unsafe.AsPointer(ref this), dwDrawAspect, psizel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetExtent([NativeTypeName("DWORD")] uint dwDrawAspect, [NativeTypeName("SIZEL *")] SIZE* psizel)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, uint, SIZE*, int>)(lpVtbl[18]))((IOleObject*)Unsafe.AsPointer(ref this), dwDrawAspect, psizel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Advise([NativeTypeName("IAdviseSink *")] IAdviseSink* pAdvSink, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, IAdviseSink*, uint*, int>)(lpVtbl[19]))((IOleObject*)Unsafe.AsPointer(ref this), pAdvSink, pdwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, uint, int>)(lpVtbl[20]))((IOleObject*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumAdvise([NativeTypeName("IEnumSTATDATA **")] IEnumSTATDATA** ppenumAdvise)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, IEnumSTATDATA**, int>)(lpVtbl[21]))((IOleObject*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetMiscStatus([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, uint, uint*, int>)(lpVtbl[22]))((IOleObject*)Unsafe.AsPointer(ref this), dwAspect, pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetColorScheme([NativeTypeName("LOGPALETTE *")] LOGPALETTE* pLogpal)
        {
            return ((delegate* unmanaged[Stdcall]<IOleObject*, LOGPALETTE*, int>)(lpVtbl[23]))((IOleObject*)Unsafe.AsPointer(ref this), pLogpal);
        }
    }
}
