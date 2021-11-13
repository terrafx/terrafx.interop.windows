// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("7BFEF914-2D75-4BAD-BE87-E18DDB077B6D")]
    [NativeTypeName("struct ID2D1Device6 : ID2D1Device5")]
    [NativeInheritance("ID2D1Device5")]
    public unsafe partial struct ID2D1Device6 : ID2D1Device6.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1Device6*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Device6*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1Device6*, uint>)(lpVtbl[1]))((ID2D1Device6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1Device6*, uint>)(lpVtbl[2]))((ID2D1Device6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public void GetFactory(ID2D1Factory** factory)
        {
            ((delegate* unmanaged<ID2D1Device6*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Device6*)Unsafe.AsPointer(ref this), factory);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext** deviceContext)
        {
            return ((delegate* unmanaged<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext**, int>)(lpVtbl[4]))((ID2D1Device6*)Unsafe.AsPointer(ref this), options, deviceContext);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT CreatePrintControl(IWICImagingFactory* wicFactory, IPrintDocumentPackageTarget* documentTarget, [NativeTypeName("const D2D1_PRINT_CONTROL_PROPERTIES *")] D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties, ID2D1PrintControl** printControl)
        {
            return ((delegate* unmanaged<ID2D1Device6*, IWICImagingFactory*, IPrintDocumentPackageTarget*, D2D1_PRINT_CONTROL_PROPERTIES*, ID2D1PrintControl**, int>)(lpVtbl[5]))((ID2D1Device6*)Unsafe.AsPointer(ref this), wicFactory, documentTarget, printControlProperties, printControl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public void SetMaximumTextureMemory([NativeTypeName("UINT64")] ulong maximumInBytes)
        {
            ((delegate* unmanaged<ID2D1Device6*, ulong, void>)(lpVtbl[6]))((ID2D1Device6*)Unsafe.AsPointer(ref this), maximumInBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("UINT64")]
        public ulong GetMaximumTextureMemory()
        {
            return ((delegate* unmanaged<ID2D1Device6*, ulong>)(lpVtbl[7]))((ID2D1Device6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public void ClearResources([NativeTypeName("UINT32")] uint millisecondsSinceUse = 0)
        {
            ((delegate* unmanaged<ID2D1Device6*, uint, void>)(lpVtbl[8]))((ID2D1Device6*)Unsafe.AsPointer(ref this), millisecondsSinceUse);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public D2D1_RENDERING_PRIORITY GetRenderingPriority()
        {
            return ((delegate* unmanaged<ID2D1Device6*, D2D1_RENDERING_PRIORITY>)(lpVtbl[9]))((ID2D1Device6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public void SetRenderingPriority(D2D1_RENDERING_PRIORITY renderingPriority)
        {
            ((delegate* unmanaged<ID2D1Device6*, D2D1_RENDERING_PRIORITY, void>)(lpVtbl[10]))((ID2D1Device6*)Unsafe.AsPointer(ref this), renderingPriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext1** deviceContext1)
        {
            return ((delegate* unmanaged<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext1**, int>)(lpVtbl[11]))((ID2D1Device6*)Unsafe.AsPointer(ref this), options, deviceContext1);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext2** deviceContext2)
        {
            return ((delegate* unmanaged<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext2**, int>)(lpVtbl[12]))((ID2D1Device6*)Unsafe.AsPointer(ref this), options, deviceContext2);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public void FlushDeviceContexts(ID2D1Bitmap* bitmap)
        {
            ((delegate* unmanaged<ID2D1Device6*, ID2D1Bitmap*, void>)(lpVtbl[13]))((ID2D1Device6*)Unsafe.AsPointer(ref this), bitmap);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT GetDxgiDevice(IDXGIDevice** dxgiDevice)
        {
            return ((delegate* unmanaged<ID2D1Device6*, IDXGIDevice**, int>)(lpVtbl[14]))((ID2D1Device6*)Unsafe.AsPointer(ref this), dxgiDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        public HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext3** deviceContext3)
        {
            return ((delegate* unmanaged<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext3**, int>)(lpVtbl[15]))((ID2D1Device6*)Unsafe.AsPointer(ref this), options, deviceContext3);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        public HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext4** deviceContext4)
        {
            return ((delegate* unmanaged<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext4**, int>)(lpVtbl[16]))((ID2D1Device6*)Unsafe.AsPointer(ref this), options, deviceContext4);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        public void SetMaximumColorGlyphCacheMemory([NativeTypeName("UINT64")] ulong maximumInBytes)
        {
            ((delegate* unmanaged<ID2D1Device6*, ulong, void>)(lpVtbl[17]))((ID2D1Device6*)Unsafe.AsPointer(ref this), maximumInBytes);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("UINT64")]
        public ulong GetMaximumColorGlyphCacheMemory()
        {
            return ((delegate* unmanaged<ID2D1Device6*, ulong>)(lpVtbl[18]))((ID2D1Device6*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        public HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext5** deviceContext5)
        {
            return ((delegate* unmanaged<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext5**, int>)(lpVtbl[19]))((ID2D1Device6*)Unsafe.AsPointer(ref this), options, deviceContext5);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        public HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext6** deviceContext6)
        {
            return ((delegate* unmanaged<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext6**, int>)(lpVtbl[20]))((ID2D1Device6*)Unsafe.AsPointer(ref this), options, deviceContext6);
        }

        public interface Interface : ID2D1Device5.Interface
        {
            [VtblIndex(20)]
            HRESULT CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, ID2D1DeviceContext6** deviceContext6);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, uint> Release;

            [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, ID2D1Factory**, void> GetFactory;

            [NativeTypeName("HRESULT (D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext**, int> CreateDeviceContext;

            [NativeTypeName("HRESULT (IWICImagingFactory *, IPrintDocumentPackageTarget *, const D2D1_PRINT_CONTROL_PROPERTIES *, ID2D1PrintControl **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, IWICImagingFactory*, IPrintDocumentPackageTarget*, D2D1_PRINT_CONTROL_PROPERTIES*, ID2D1PrintControl**, int> CreatePrintControl;

            [NativeTypeName("void (UINT64) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, ulong, void> SetMaximumTextureMemory;

            [NativeTypeName("UINT64 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, ulong> GetMaximumTextureMemory;

            [NativeTypeName("void (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, uint, void> ClearResources;

            [NativeTypeName("D2D1_RENDERING_PRIORITY () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, D2D1_RENDERING_PRIORITY> GetRenderingPriority;

            [NativeTypeName("void (D2D1_RENDERING_PRIORITY) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, D2D1_RENDERING_PRIORITY, void> SetRenderingPriority;

            [NativeTypeName("HRESULT (D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext1**, int> CreateDeviceContext1;

            [NativeTypeName("HRESULT (D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext2 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext2**, int> CreateDeviceContext2;

            [NativeTypeName("void (ID2D1Bitmap *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, ID2D1Bitmap*, void> FlushDeviceContexts;

            [NativeTypeName("HRESULT (IDXGIDevice **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, IDXGIDevice**, int> GetDxgiDevice;

            [NativeTypeName("HRESULT (D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext3 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext3**, int> CreateDeviceContext3;

            [NativeTypeName("HRESULT (D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext4 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext4**, int> CreateDeviceContext4;

            [NativeTypeName("void (UINT64) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, ulong, void> SetMaximumColorGlyphCacheMemory;

            [NativeTypeName("UINT64 () const __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, ulong> GetMaximumColorGlyphCacheMemory;

            [NativeTypeName("HRESULT (D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext5 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext5**, int> CreateDeviceContext5;

            [NativeTypeName("HRESULT (D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext6 **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1Device6*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext6**, int> CreateDeviceContext6;
        }
    }
}
