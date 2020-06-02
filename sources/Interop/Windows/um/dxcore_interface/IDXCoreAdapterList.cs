// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("526C7776-40E9-459B-B711-F32AD76DFC28")]
    public unsafe partial struct IDXCoreAdapterList
    {
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IDXCoreAdapterList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IDXCoreAdapterList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAdapter([NativeTypeName("uint32_t")] uint index, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter)
        {
            return lpVtbl->GetAdapter((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), index, riid, ppvAdapter);
        }

        [return: NativeTypeName("uint32_t")]
        public uint GetAdapterCount()
        {
            return lpVtbl->GetAdapterCount((IDXCoreAdapterList*)Unsafe.AsPointer(ref this));
        }

        public bool IsStale()
        {
            return lpVtbl->IsStale((IDXCoreAdapterList*)Unsafe.AsPointer(ref this)) != 0;
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFactory([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvFactory)
        {
            return lpVtbl->GetFactory((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), riid, ppvFactory);
        }

        [return: NativeTypeName("HRESULT")]
        public int Sort([NativeTypeName("uint32_t")] uint numPreferences, [NativeTypeName("const DXCoreAdapterPreference *")] DXCoreAdapterPreference* preferences)
        {
            return lpVtbl->Sort((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), numPreferences, preferences);
        }

        public bool IsAdapterPreferenceSupported(DXCoreAdapterPreference preference)
        {
            return lpVtbl->IsAdapterPreferenceSupported((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), preference) != 0;
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterList*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterList*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterList*, uint> Release;

            [NativeTypeName("HRESULT (uint32_t, const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterList*, uint, Guid*, void**, int> GetAdapter;

            [NativeTypeName("uint32_t () __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterList*, uint> GetAdapterCount;

            [NativeTypeName("bool () __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterList*, byte> IsStale;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterList*, Guid*, void**, int> GetFactory;

            [NativeTypeName("HRESULT (uint32_t, const DXCoreAdapterPreference *) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterList*, uint, DXCoreAdapterPreference*, int> Sort;

            [NativeTypeName("bool (DXCoreAdapterPreference) __attribute__((stdcall))")]
            public delegate* stdcall<IDXCoreAdapterList*, DXCoreAdapterPreference, byte> IsAdapterPreferenceSupported;
        }
    }
}
