// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("449494BC-B468-4927-96D7-BA90D31AB505")]
    public unsafe partial struct IWICStreamProvider
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICStreamProvider*, Guid*, void**, int>)(lpVtbl[0]))((IWICStreamProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICStreamProvider*, uint>)(lpVtbl[1]))((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICStreamProvider*, uint>)(lpVtbl[2]))((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStream([NativeTypeName("IStream **")] IStream** ppIStream)
        {
            return ((delegate* stdcall<IWICStreamProvider*, IStream**, int>)(lpVtbl[3]))((IWICStreamProvider*)Unsafe.AsPointer(ref this), ppIStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPersistOptions([NativeTypeName("DWORD *")] uint* pdwPersistOptions)
        {
            return ((delegate* stdcall<IWICStreamProvider*, uint*, int>)(lpVtbl[4]))((IWICStreamProvider*)Unsafe.AsPointer(ref this), pdwPersistOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPreferredVendorGUID([NativeTypeName("GUID *")] Guid* pguidPreferredVendor)
        {
            return ((delegate* stdcall<IWICStreamProvider*, Guid*, int>)(lpVtbl[5]))((IWICStreamProvider*)Unsafe.AsPointer(ref this), pguidPreferredVendor);
        }

        [return: NativeTypeName("HRESULT")]
        public int RefreshStream()
        {
            return ((delegate* stdcall<IWICStreamProvider*, int>)(lpVtbl[6]))((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }
    }
}
