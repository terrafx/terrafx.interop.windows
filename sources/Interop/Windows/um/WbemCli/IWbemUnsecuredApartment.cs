// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("31739D04-3471-4CF4-9A7C-57A44AE71956")]
    [NativeTypeName("struct IWbemUnsecuredApartment : IUnsecuredApartment")]
    [NativeInheritance("IUnsecuredApartment")]
    public unsafe partial struct IWbemUnsecuredApartment : IWbemUnsecuredApartment.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemUnsecuredApartment*, Guid*, void**, int>)(lpVtbl[0]))((IWbemUnsecuredApartment*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemUnsecuredApartment*, uint>)(lpVtbl[1]))((IWbemUnsecuredApartment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemUnsecuredApartment*, uint>)(lpVtbl[2]))((IWbemUnsecuredApartment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateObjectStub(IUnknown* pObject, IUnknown** ppStub)
        {
            return ((delegate* unmanaged<IWbemUnsecuredApartment*, IUnknown*, IUnknown**, int>)(lpVtbl[3]))((IWbemUnsecuredApartment*)Unsafe.AsPointer(ref this), pObject, ppStub);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateSinkStub(IWbemObjectSink* pSink, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* wszReserved, IWbemObjectSink** ppStub)
        {
            return ((delegate* unmanaged<IWbemUnsecuredApartment*, IWbemObjectSink*, uint, ushort*, IWbemObjectSink**, int>)(lpVtbl[4]))((IWbemUnsecuredApartment*)Unsafe.AsPointer(ref this), pSink, dwFlags, wszReserved, ppStub);
        }

        public interface Interface : IUnsecuredApartment.Interface
        {
            [VtblIndex(4)]
            HRESULT CreateSinkStub(IWbemObjectSink* pSink, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("LPCWSTR")] ushort* wszReserved, IWbemObjectSink** ppStub);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemUnsecuredApartment*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemUnsecuredApartment*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemUnsecuredApartment*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemUnsecuredApartment*, IUnknown*, IUnknown**, int> CreateObjectStub;

            [NativeTypeName("HRESULT (IWbemObjectSink *, DWORD, LPCWSTR, IWbemObjectSink **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemUnsecuredApartment*, IWbemObjectSink*, uint, ushort*, IWbemObjectSink**, int> CreateSinkStub;
        }
    }
}
