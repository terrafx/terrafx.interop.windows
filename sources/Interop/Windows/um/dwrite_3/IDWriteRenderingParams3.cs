// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B7924BAA-391B-412A-8C5C-E44CC2D867DC")]
    public unsafe partial struct IDWriteRenderingParams3
    {
        public Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteRenderingParams3* pThis, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteRenderingParams3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteRenderingParams3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetGamma(IDWriteRenderingParams3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetEnhancedContrast(IDWriteRenderingParams3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetClearTypeLevel(IDWriteRenderingParams3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DWRITE_PIXEL_GEOMETRY _GetPixelGeometry(IDWriteRenderingParams3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DWRITE_RENDERING_MODE _GetRenderingMode(IDWriteRenderingParams3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        [return: NativeTypeName("FLOAT")]
        public delegate float _GetGrayscaleEnhancedContrast(IDWriteRenderingParams3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DWRITE_GRID_FIT_MODE _GetGridFitMode(IDWriteRenderingParams3* pThis);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate DWRITE_RENDERING_MODE1 _GetRenderingMode1(IDWriteRenderingParams3* pThis);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetGamma()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGamma>(lpVtbl->GetGamma)((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetEnhancedContrast()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetEnhancedContrast>(lpVtbl->GetEnhancedContrast)((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetClearTypeLevel()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetClearTypeLevel>(lpVtbl->GetClearTypeLevel)((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_PIXEL_GEOMETRY GetPixelGeometry()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetPixelGeometry>(lpVtbl->GetPixelGeometry)((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_RENDERING_MODE GetRenderingMode()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRenderingMode>(lpVtbl->GetRenderingMode)((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("FLOAT")]
        public float GetGrayscaleEnhancedContrast()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGrayscaleEnhancedContrast>(lpVtbl->GetGrayscaleEnhancedContrast)((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_GRID_FIT_MODE GetGridFitMode()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetGridFitMode>(lpVtbl->GetGridFitMode)((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        public DWRITE_RENDERING_MODE1 GetRenderingMode1()
        {
            return Marshal.GetDelegateForFunctionPointer<_GetRenderingMode1>(lpVtbl->GetRenderingMode1)((IDWriteRenderingParams3*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public IntPtr QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public IntPtr Release;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGamma;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetEnhancedContrast;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetClearTypeLevel;

            [NativeTypeName("DWRITE_PIXEL_GEOMETRY () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetPixelGeometry;

            [NativeTypeName("DWRITE_RENDERING_MODE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetRenderingMode;

            [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGrayscaleEnhancedContrast;

            [NativeTypeName("DWRITE_GRID_FIT_MODE () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetGridFitMode;

            [NativeTypeName("DWRITE_RENDERING_MODE1 () __attribute__((nothrow)) __attribute__((stdcall))")]
            public IntPtr GetRenderingMode1;
        }
    }
}
