// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000128-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IOleCache2 : IOleCache")]
    [NativeInheritance("IOleCache")]
    public unsafe partial struct IOleCache2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleCache2*, Guid*, void**, int>)(lpVtbl[0]))((IOleCache2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleCache2*, uint>)(lpVtbl[1]))((IOleCache2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleCache2*, uint>)(lpVtbl[2]))((IOleCache2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Cache(FORMATETC* pformatetc, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return ((delegate* unmanaged<IOleCache2*, FORMATETC*, uint, uint*, int>)(lpVtbl[3]))((IOleCache2*)Unsafe.AsPointer(ref this), pformatetc, advf, pdwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Uncache([NativeTypeName("DWORD")] uint dwConnection)
        {
            return ((delegate* unmanaged<IOleCache2*, uint, int>)(lpVtbl[4]))((IOleCache2*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int EnumCache(IEnumSTATDATA** ppenumSTATDATA)
        {
            return ((delegate* unmanaged<IOleCache2*, IEnumSTATDATA**, int>)(lpVtbl[5]))((IOleCache2*)Unsafe.AsPointer(ref this), ppenumSTATDATA);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int InitCache(IDataObject* pDataObject)
        {
            return ((delegate* unmanaged<IOleCache2*, IDataObject*, int>)(lpVtbl[6]))((IOleCache2*)Unsafe.AsPointer(ref this), pDataObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetData(FORMATETC* pformatetc, STGMEDIUM* pmedium, BOOL fRelease)
        {
            return ((delegate* unmanaged<IOleCache2*, FORMATETC*, STGMEDIUM*, BOOL, int>)(lpVtbl[7]))((IOleCache2*)Unsafe.AsPointer(ref this), pformatetc, pmedium, fRelease);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int UpdateCache([NativeTypeName("LPDATAOBJECT")] IDataObject* pDataObject, [NativeTypeName("DWORD")] uint grfUpdf, [NativeTypeName("LPVOID")] void* pReserved)
        {
            return ((delegate* unmanaged<IOleCache2*, IDataObject*, uint, void*, int>)(lpVtbl[8]))((IOleCache2*)Unsafe.AsPointer(ref this), pDataObject, grfUpdf, pReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int DiscardCache([NativeTypeName("DWORD")] uint dwDiscardOptions)
        {
            return ((delegate* unmanaged<IOleCache2*, uint, int>)(lpVtbl[9]))((IOleCache2*)Unsafe.AsPointer(ref this), dwDiscardOptions);
        }
    }
}
