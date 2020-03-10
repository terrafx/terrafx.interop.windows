// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.18362.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1AB42875-C57F-4BE9-BD85-9CD78D6F55EE")]
    public unsafe partial struct ID2D1ColorContext1
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1ColorContext1* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1ColorContext1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1ColorContext1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetFactory(ID2D1ColorContext1* pThis, [NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_COLOR_SPACE _GetColorSpace(ID2D1ColorContext1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetProfileSize(ID2D1ColorContext1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetProfile(ID2D1ColorContext1* pThis, [NativeTypeName("BYTE *")] byte* profile, [NativeTypeName("UINT32")] uint profileSize);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate D2D1_COLOR_CONTEXT_TYPE _GetColorContextType(ID2D1ColorContext1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate DXGI_COLOR_SPACE_TYPE _GetDXGIColorSpace(ID2D1ColorContext1* pThis);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _GetSimpleColorProfile(ID2D1ColorContext1* pThis, [NativeTypeName("D2D1_SIMPLE_COLOR_PROFILE *")] D2D1_SIMPLE_COLOR_PROFILE* simpleProfile);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((ID2D1ColorContext1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            Marshal.GetDelegateForFunctionPointer<_GetFactory>(lpVtbl->GetFactory)((ID2D1ColorContext1*)Unsafe.AsPointer(ref this), factory);
        }

        public D2D1_COLOR_SPACE GetColorSpace()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetColorSpace>(lpVtbl->GetColorSpace)((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("UINT32")]
        public uint GetProfileSize()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetProfileSize>(lpVtbl->GetProfileSize)((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetProfile([NativeTypeName("BYTE *")] byte* profile, [NativeTypeName("UINT32")] uint profileSize)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetProfile>(lpVtbl->GetProfile)((ID2D1ColorContext1*)Unsafe.AsPointer(ref this), profile, profileSize);
        }

        public D2D1_COLOR_CONTEXT_TYPE GetColorContextType()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetColorContextType>(lpVtbl->GetColorContextType)((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        public DXGI_COLOR_SPACE_TYPE GetDXGIColorSpace()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetDXGIColorSpace>(lpVtbl->GetDXGIColorSpace)((ID2D1ColorContext1*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetSimpleColorProfile([NativeTypeName("D2D1_SIMPLE_COLOR_PROFILE *")] D2D1_SIMPLE_COLOR_PROFILE* simpleProfile)
        {
            return Marshal.GetDelegateForFunctionPointer<_GetSimpleColorProfile>(lpVtbl->GetSimpleColorProfile)((ID2D1ColorContext1*)Unsafe.AsPointer(ref this), simpleProfile);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetFactory;

            [NativeTypeName("D2D1_COLOR_SPACE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetColorSpace;

            [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetProfileSize;

            [NativeTypeName("HRESULT (BYTE *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetProfile;

            [NativeTypeName("D2D1_COLOR_CONTEXT_TYPE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetColorContextType;

            [NativeTypeName("DXGI_COLOR_SPACE_TYPE () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetDXGIColorSpace;

            [NativeTypeName("HRESULT (D2D1_SIMPLE_COLOR_PROFILE *) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetSimpleColorProfile;
        }
    }
}
