// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("DC12A680-737F-11CF-884D-00AA004B2E24")]
    [NativeTypeName("struct IWbemQualifierSet : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWbemQualifierSet : IWbemQualifierSet.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, Guid*, void**, int>)(lpVtbl[0]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, uint>)(lpVtbl[1]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, uint>)(lpVtbl[2]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Get([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pVal, [NativeTypeName("long *")] int* plFlavor)
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, ushort*, int, VARIANT*, int*, int>)(lpVtbl[3]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this), wszName, lFlags, pVal, plFlavor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Put([NativeTypeName("LPCWSTR")] ushort* wszName, VARIANT* pVal, [NativeTypeName("long")] int lFlavor)
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, ushort*, VARIANT*, int, int>)(lpVtbl[4]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this), wszName, pVal, lFlavor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Delete([NativeTypeName("LPCWSTR")] ushort* wszName)
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, ushort*, int>)(lpVtbl[5]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this), wszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetNames([NativeTypeName("long")] int lFlags, SAFEARRAY** pNames)
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, int, SAFEARRAY**, int>)(lpVtbl[6]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this), lFlags, pNames);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT BeginEnumeration([NativeTypeName("long")] int lFlags)
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, int, int>)(lpVtbl[7]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this), lFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT Next([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** pstrName, VARIANT* pVal, [NativeTypeName("long *")] int* plFlavor)
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, int, ushort**, VARIANT*, int*, int>)(lpVtbl[8]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this), lFlags, pstrName, pVal, plFlavor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT EndEnumeration()
        {
            return ((delegate* unmanaged<IWbemQualifierSet*, int>)(lpVtbl[9]))((IWbemQualifierSet*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Get([NativeTypeName("LPCWSTR")] ushort* wszName, [NativeTypeName("long")] int lFlags, VARIANT* pVal, [NativeTypeName("long *")] int* plFlavor);

            [VtblIndex(4)]
            HRESULT Put([NativeTypeName("LPCWSTR")] ushort* wszName, VARIANT* pVal, [NativeTypeName("long")] int lFlavor);

            [VtblIndex(5)]
            HRESULT Delete([NativeTypeName("LPCWSTR")] ushort* wszName);

            [VtblIndex(6)]
            HRESULT GetNames([NativeTypeName("long")] int lFlags, SAFEARRAY** pNames);

            [VtblIndex(7)]
            HRESULT BeginEnumeration([NativeTypeName("long")] int lFlags);

            [VtblIndex(8)]
            HRESULT Next([NativeTypeName("long")] int lFlags, [NativeTypeName("BSTR *")] ushort** pstrName, VARIANT* pVal, [NativeTypeName("long *")] int* plFlavor);

            [VtblIndex(9)]
            HRESULT EndEnumeration();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemQualifierSet*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemQualifierSet*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemQualifierSet*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, long, VARIANT *, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemQualifierSet*, ushort*, int, VARIANT*, int*, int> Get;

            [NativeTypeName("HRESULT (LPCWSTR, VARIANT *, long) __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemQualifierSet*, ushort*, VARIANT*, int, int> Put;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemQualifierSet*, ushort*, int> Delete;

            [NativeTypeName("HRESULT (long, SAFEARRAY **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemQualifierSet*, int, SAFEARRAY**, int> GetNames;

            [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemQualifierSet*, int, int> BeginEnumeration;

            [NativeTypeName("HRESULT (long, BSTR *, VARIANT *, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemQualifierSet*, int, ushort**, VARIANT*, int*, int> Next;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IWbemQualifierSet*, int> EndEnumeration;
        }
    }
}
