// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("47DD575D-AC05-4CDD-8049-9B02CD16F44C")]
    [NativeTypeName("struct ID2D1Device : ID2D1Resource")]
    public unsafe partial struct ID2D1Device
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ID2D1Device*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1Device*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ID2D1Device*, uint>)(lpVtbl[1]))((ID2D1Device*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ID2D1Device*, uint>)(lpVtbl[2]))((ID2D1Device*)Unsafe.AsPointer(ref this));
        }

        public void GetFactory([NativeTypeName("ID2D1Factory **")] ID2D1Factory** factory)
        {
            ((delegate* stdcall<ID2D1Device*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1Device*)Unsafe.AsPointer(ref this), factory);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateDeviceContext(D2D1_DEVICE_CONTEXT_OPTIONS options, [NativeTypeName("ID2D1DeviceContext **")] ID2D1DeviceContext** deviceContext)
        {
            return ((delegate* stdcall<ID2D1Device*, D2D1_DEVICE_CONTEXT_OPTIONS, ID2D1DeviceContext**, int>)(lpVtbl[4]))((ID2D1Device*)Unsafe.AsPointer(ref this), options, deviceContext);
        }

        [return: NativeTypeName("HRESULT")]
        public int CreatePrintControl([NativeTypeName("IWICImagingFactory *")] IWICImagingFactory* wicFactory, [NativeTypeName("IPrintDocumentPackageTarget *")] IPrintDocumentPackageTarget* documentTarget, [NativeTypeName("const D2D1_PRINT_CONTROL_PROPERTIES *")] D2D1_PRINT_CONTROL_PROPERTIES* printControlProperties, [NativeTypeName("ID2D1PrintControl **")] ID2D1PrintControl** printControl)
        {
            return ((delegate* stdcall<ID2D1Device*, IWICImagingFactory*, IPrintDocumentPackageTarget*, D2D1_PRINT_CONTROL_PROPERTIES*, ID2D1PrintControl**, int>)(lpVtbl[5]))((ID2D1Device*)Unsafe.AsPointer(ref this), wicFactory, documentTarget, printControlProperties, printControl);
        }

        public void SetMaximumTextureMemory([NativeTypeName("UINT64")] ulong maximumInBytes)
        {
            ((delegate* stdcall<ID2D1Device*, ulong, void>)(lpVtbl[6]))((ID2D1Device*)Unsafe.AsPointer(ref this), maximumInBytes);
        }

        [return: NativeTypeName("UINT64")]
        public ulong GetMaximumTextureMemory()
        {
            return ((delegate* stdcall<ID2D1Device*, ulong>)(lpVtbl[7]))((ID2D1Device*)Unsafe.AsPointer(ref this));
        }

        public void ClearResources([NativeTypeName("UINT32")] uint millisecondsSinceUse = 0)
        {
            ((delegate* stdcall<ID2D1Device*, uint, void>)(lpVtbl[8]))((ID2D1Device*)Unsafe.AsPointer(ref this), millisecondsSinceUse);
        }
    }
}
