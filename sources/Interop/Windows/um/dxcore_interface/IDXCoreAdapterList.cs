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

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDXCoreAdapterList* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDXCoreAdapterList* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDXCoreAdapterList* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetAdapter(IDXCoreAdapterList* pThis, [NativeTypeName("uint32_t")] uint index, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("uint32_t")]
        public delegate uint _GetAdapterCount(IDXCoreAdapterList* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("bool")]
        public delegate byte _IsStale(IDXCoreAdapterList* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetFactory(IDXCoreAdapterList* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvFactory);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _Sort(IDXCoreAdapterList* pThis, [NativeTypeName("uint32_t")] uint numPreferences, [NativeTypeName("const DXCoreAdapterPreference *")] DXCoreAdapterPreference* preferences);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("bool")]
        public delegate byte _IsAdapterPreferenceSupported(IDXCoreAdapterList* pThis, DXCoreAdapterPreference preference);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDXCoreAdapterList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDXCoreAdapterList*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetAdapter([NativeTypeName("uint32_t")] uint index, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvAdapter)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAdapter>(lpVtbl->GetAdapter)((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), index, riid, ppvAdapter);
        }

        [return: NativeTypeName("uint32_t")]
        public uint GetAdapterCount()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetAdapterCount>(lpVtbl->GetAdapterCount)((IDXCoreAdapterList*)Unsafe.AsPointer(ref this));
        }

        public bool IsStale()
        {
            return Marshal.GetDelegateForFunctionPointer<_IsStale>(lpVtbl->IsStale)((IDXCoreAdapterList*)Unsafe.AsPointer(ref this)) != 0;
        }

        [return: NativeTypeName("HRESULT")]
        public int GetFactory([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvFactory)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), riid, ppvFactory);
        }

        [return: NativeTypeName("HRESULT")]
        public int Sort([NativeTypeName("uint32_t")] uint numPreferences, [NativeTypeName("const DXCoreAdapterPreference *")] DXCoreAdapterPreference* preferences)
        {
            return Marshal.GetDelegateForFunctionPointer<_Sort>(lpVtbl->Sort)((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), numPreferences, preferences);
        }

        public bool IsAdapterPreferenceSupported(DXCoreAdapterPreference preference)
        {
            return Marshal.GetDelegateForFunctionPointer<_IsAdapterPreferenceSupported>(lpVtbl->IsAdapterPreferenceSupported)((IDXCoreAdapterList*)Unsafe.AsPointer(ref this), preference) != 0;
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("HRESULT (uint32_t, const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetAdapter;

            [NativeTypeName("uint32_t () __attribute__((stdcall))")]
            public IntPtr GetAdapterCount;

            [NativeTypeName("bool () __attribute__((stdcall))")]
            public IntPtr IsStale;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr GetFactory;

            [NativeTypeName("HRESULT (uint32_t, const DXCoreAdapterPreference *) __attribute__((stdcall))")]
            public IntPtr Sort;

            [NativeTypeName("bool (DXCoreAdapterPreference) __attribute__((stdcall))")]
            public IntPtr IsAdapterPreferenceSupported;
        }
    }
}
