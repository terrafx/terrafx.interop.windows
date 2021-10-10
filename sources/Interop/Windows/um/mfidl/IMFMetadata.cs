// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("F88CFB8C-EF16-4991-B450-CB8C69E51704")]
    [NativeTypeName("struct IMFMetadata : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMetadata
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMetadata*, Guid*, void**, int>)(lpVtbl[0]))((IMFMetadata*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMetadata*, uint>)(lpVtbl[1]))((IMFMetadata*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMetadata*, uint>)(lpVtbl[2]))((IMFMetadata*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetLanguage([NativeTypeName("LPCWSTR")] ushort* pwszRFC1766)
        {
            return ((delegate* unmanaged<IMFMetadata*, ushort*, int>)(lpVtbl[3]))((IMFMetadata*)Unsafe.AsPointer(ref this), pwszRFC1766);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetLanguage([NativeTypeName("LPWSTR *")] ushort** ppwszRFC1766)
        {
            return ((delegate* unmanaged<IMFMetadata*, ushort**, int>)(lpVtbl[4]))((IMFMetadata*)Unsafe.AsPointer(ref this), ppwszRFC1766);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllLanguages(PROPVARIANT* ppvLanguages)
        {
            return ((delegate* unmanaged<IMFMetadata*, PROPVARIANT*, int>)(lpVtbl[5]))((IMFMetadata*)Unsafe.AsPointer(ref this), ppvLanguages);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetProperty([NativeTypeName("LPCWSTR")] ushort* pwszName, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* ppvValue)
        {
            return ((delegate* unmanaged<IMFMetadata*, ushort*, PROPVARIANT*, int>)(lpVtbl[6]))((IMFMetadata*)Unsafe.AsPointer(ref this), pwszName, ppvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetProperty([NativeTypeName("LPCWSTR")] ushort* pwszName, PROPVARIANT* ppvValue)
        {
            return ((delegate* unmanaged<IMFMetadata*, ushort*, PROPVARIANT*, int>)(lpVtbl[7]))((IMFMetadata*)Unsafe.AsPointer(ref this), pwszName, ppvValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int DeleteProperty([NativeTypeName("LPCWSTR")] ushort* pwszName)
        {
            return ((delegate* unmanaged<IMFMetadata*, ushort*, int>)(lpVtbl[8]))((IMFMetadata*)Unsafe.AsPointer(ref this), pwszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int GetAllPropertyNames(PROPVARIANT* ppvNames)
        {
            return ((delegate* unmanaged<IMFMetadata*, PROPVARIANT*, int>)(lpVtbl[9]))((IMFMetadata*)Unsafe.AsPointer(ref this), ppvNames);
        }
    }
}
