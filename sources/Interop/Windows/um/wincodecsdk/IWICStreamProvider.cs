// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("449494BC-B468-4927-96D7-BA90D31AB505")]
    [NativeTypeName("struct IWICStreamProvider : IUnknown")]
    public unsafe partial struct IWICStreamProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Guid*, void**, int>)(lpVtbl[0]))((IWICStreamProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, uint>)(lpVtbl[1]))((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, uint>)(lpVtbl[2]))((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetStream([NativeTypeName("IStream **")] IStream** ppIStream)
        {
            return ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, IStream**, int>)(lpVtbl[3]))((IWICStreamProvider*)Unsafe.AsPointer(ref this), ppIStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPersistOptions([NativeTypeName("DWORD *")] uint* pdwPersistOptions)
        {
            return ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, uint*, int>)(lpVtbl[4]))((IWICStreamProvider*)Unsafe.AsPointer(ref this), pdwPersistOptions);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreferredVendorGUID([NativeTypeName("GUID *")] Guid* pguidPreferredVendor)
        {
            return ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, Guid*, int>)(lpVtbl[5]))((IWICStreamProvider*)Unsafe.AsPointer(ref this), pguidPreferredVendor);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RefreshStream()
        {
            return ((delegate* unmanaged[Stdcall]<IWICStreamProvider*, int>)(lpVtbl[6]))((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }
    }
}
