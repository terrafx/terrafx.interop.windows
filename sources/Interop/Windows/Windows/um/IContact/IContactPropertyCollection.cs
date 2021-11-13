// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IContact.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("FFD3ADF8-FA64-4328-B1B6-2E0DB509CB3C")]
    [NativeTypeName("struct IContactPropertyCollection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IContactPropertyCollection : IContactPropertyCollection.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IContactPropertyCollection*, Guid*, void**, int>)(lpVtbl[0]))((IContactPropertyCollection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IContactPropertyCollection*, uint>)(lpVtbl[1]))((IContactPropertyCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IContactPropertyCollection*, uint>)(lpVtbl[2]))((IContactPropertyCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IContactPropertyCollection*, int>)(lpVtbl[3]))((IContactPropertyCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Next()
        {
            return ((delegate* unmanaged<IContactPropertyCollection*, int>)(lpVtbl[4]))((IContactPropertyCollection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetPropertyName([NativeTypeName("LPWSTR")] ushort* pszPropertyName, [NativeTypeName("DWORD")] uint cchPropertyName, [NativeTypeName("DWORD *")] uint* pdwcchPropertyNameRequired)
        {
            return ((delegate* unmanaged<IContactPropertyCollection*, ushort*, uint, uint*, int>)(lpVtbl[5]))((IContactPropertyCollection*)Unsafe.AsPointer(ref this), pszPropertyName, cchPropertyName, pdwcchPropertyNameRequired);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetPropertyType([NativeTypeName("DWORD *")] uint* pdwType)
        {
            return ((delegate* unmanaged<IContactPropertyCollection*, uint*, int>)(lpVtbl[6]))((IContactPropertyCollection*)Unsafe.AsPointer(ref this), pdwType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetPropertyVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
        {
            return ((delegate* unmanaged<IContactPropertyCollection*, uint*, int>)(lpVtbl[7]))((IContactPropertyCollection*)Unsafe.AsPointer(ref this), pdwVersion);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetPropertyModificationDate(FILETIME* pftModificationDate)
        {
            return ((delegate* unmanaged<IContactPropertyCollection*, FILETIME*, int>)(lpVtbl[8]))((IContactPropertyCollection*)Unsafe.AsPointer(ref this), pftModificationDate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetPropertyArrayElementID([NativeTypeName("LPWSTR")] ushort* pszArrayElementID, [NativeTypeName("DWORD")] uint cchArrayElementID, [NativeTypeName("DWORD *")] uint* pdwcchArrayElementIDRequired)
        {
            return ((delegate* unmanaged<IContactPropertyCollection*, ushort*, uint, uint*, int>)(lpVtbl[9]))((IContactPropertyCollection*)Unsafe.AsPointer(ref this), pszArrayElementID, cchArrayElementID, pdwcchArrayElementIDRequired);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Reset();

            [VtblIndex(4)]
            HRESULT Next();

            [VtblIndex(5)]
            HRESULT GetPropertyName([NativeTypeName("LPWSTR")] ushort* pszPropertyName, [NativeTypeName("DWORD")] uint cchPropertyName, [NativeTypeName("DWORD *")] uint* pdwcchPropertyNameRequired);

            [VtblIndex(6)]
            HRESULT GetPropertyType([NativeTypeName("DWORD *")] uint* pdwType);

            [VtblIndex(7)]
            HRESULT GetPropertyVersion([NativeTypeName("DWORD *")] uint* pdwVersion);

            [VtblIndex(8)]
            HRESULT GetPropertyModificationDate(FILETIME* pftModificationDate);

            [VtblIndex(9)]
            HRESULT GetPropertyArrayElementID([NativeTypeName("LPWSTR")] ushort* pszArrayElementID, [NativeTypeName("DWORD")] uint cchArrayElementID, [NativeTypeName("DWORD *")] uint* pdwcchArrayElementIDRequired);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IContactPropertyCollection*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IContactPropertyCollection*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IContactPropertyCollection*, uint> Release;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IContactPropertyCollection*, int> Reset;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IContactPropertyCollection*, int> Next;

            [NativeTypeName("HRESULT (LPWSTR, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IContactPropertyCollection*, ushort*, uint, uint*, int> GetPropertyName;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IContactPropertyCollection*, uint*, int> GetPropertyType;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IContactPropertyCollection*, uint*, int> GetPropertyVersion;

            [NativeTypeName("HRESULT (FILETIME *) __attribute__((stdcall))")]
            public delegate* unmanaged<IContactPropertyCollection*, FILETIME*, int> GetPropertyModificationDate;

            [NativeTypeName("HRESULT (LPWSTR, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IContactPropertyCollection*, ushort*, uint, uint*, int> GetPropertyArrayElementID;
        }
    }
}
