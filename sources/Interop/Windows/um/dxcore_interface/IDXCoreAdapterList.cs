// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("526C7776-40E9-459B-B711-F32AD76DFC28")]
    [NativeTypeName("struct IDXCoreAdapterList : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDXCoreAdapterList
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDXCoreAdapterList*, Guid*, void**, int>)(lpVtbl[0]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDXCoreAdapterList*, uint>)(lpVtbl[1]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDXCoreAdapterList*, uint>)(lpVtbl[2]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetAdapter([NativeTypeName("uint32_t")] uint index, [NativeTypeName("const IID &")] Guid* riid, void** ppvAdapter)
        {
            return ((delegate* unmanaged<IDXCoreAdapterList*, uint, Guid*, void**, int>)(lpVtbl[3]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), index, riid, ppvAdapter);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("uint32_t")]
        public uint GetAdapterCount()
        {
            return ((delegate* unmanaged<IDXCoreAdapterList*, uint>)(lpVtbl[4]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public bool IsStale()
        {
            return ((delegate* unmanaged<IDXCoreAdapterList*, byte>)(lpVtbl[5]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this)) != 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetFactory([NativeTypeName("const IID &")] Guid* riid, void** ppvFactory)
        {
            return ((delegate* unmanaged<IDXCoreAdapterList*, Guid*, void**, int>)(lpVtbl[6]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), riid, ppvFactory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int Sort([NativeTypeName("uint32_t")] uint numPreferences, [NativeTypeName("const DXCoreAdapterPreference *")] DXCoreAdapterPreference* preferences)
        {
            return ((delegate* unmanaged<IDXCoreAdapterList*, uint, DXCoreAdapterPreference*, int>)(lpVtbl[7]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), numPreferences, preferences);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public bool IsAdapterPreferenceSupported(DXCoreAdapterPreference preference)
        {
            return ((delegate* unmanaged<IDXCoreAdapterList*, DXCoreAdapterPreference, byte>)(lpVtbl[8]))((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), preference) != 0;
        }
    }
}
