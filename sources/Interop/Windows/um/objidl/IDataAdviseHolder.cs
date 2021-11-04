// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000110-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IDataAdviseHolder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDataAdviseHolder : IDataAdviseHolder.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDataAdviseHolder*, Guid*, void**, int>)(lpVtbl[0]))((IDataAdviseHolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDataAdviseHolder*, uint>)(lpVtbl[1]))((IDataAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDataAdviseHolder*, uint>)(lpVtbl[2]))((IDataAdviseHolder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Advise(IDataObject* pDataObject, FORMATETC* pFetc, [NativeTypeName("DWORD")] uint advf, IAdviseSink* pAdvise, [NativeTypeName("DWORD *")] uint* pdwConnection)
        {
            return ((delegate* unmanaged<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int>)(lpVtbl[3]))((IDataAdviseHolder*)Unsafe.AsPointer(ref this), pDataObject, pFetc, advf, pAdvise, pdwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwConnection)
        {
            return ((delegate* unmanaged<IDataAdviseHolder*, uint, int>)(lpVtbl[4]))((IDataAdviseHolder*)Unsafe.AsPointer(ref this), dwConnection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT EnumAdvise(IEnumSTATDATA** ppenumAdvise)
        {
            return ((delegate* unmanaged<IDataAdviseHolder*, IEnumSTATDATA**, int>)(lpVtbl[5]))((IDataAdviseHolder*)Unsafe.AsPointer(ref this), ppenumAdvise);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SendOnDataChange(IDataObject* pDataObject, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint advf)
        {
            return ((delegate* unmanaged<IDataAdviseHolder*, IDataObject*, uint, uint, int>)(lpVtbl[6]))((IDataAdviseHolder*)Unsafe.AsPointer(ref this), pDataObject, dwReserved, advf);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Advise(IDataObject* pDataObject, FORMATETC* pFetc, [NativeTypeName("DWORD")] uint advf, IAdviseSink* pAdvise, [NativeTypeName("DWORD *")] uint* pdwConnection);

            [VtblIndex(4)]
            HRESULT Unadvise([NativeTypeName("DWORD")] uint dwConnection);

            [VtblIndex(5)]
            HRESULT EnumAdvise(IEnumSTATDATA** ppenumAdvise);

            [VtblIndex(6)]
            HRESULT SendOnDataChange(IDataObject* pDataObject, [NativeTypeName("DWORD")] uint dwReserved, [NativeTypeName("DWORD")] uint advf);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataAdviseHolder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDataAdviseHolder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDataAdviseHolder*, uint> Release;

            [NativeTypeName("HRESULT (IDataObject *, FORMATETC *, DWORD, IAdviseSink *, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataAdviseHolder*, IDataObject*, FORMATETC*, uint, IAdviseSink*, uint*, int> Advise;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataAdviseHolder*, uint, int> Unadvise;

            [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataAdviseHolder*, IEnumSTATDATA**, int> EnumAdvise;

            [NativeTypeName("HRESULT (IDataObject *, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IDataAdviseHolder*, IDataObject*, uint, uint, int> SendOnDataChange;
        }
    }
}
