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
        public Vtbl* lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return lpVtbl->QueryInterface((IWICStreamProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return lpVtbl->AddRef((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return lpVtbl->Release((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetStream([NativeTypeName("IStream **")] IStream** ppIStream)
        {
            return lpVtbl->GetStream((IWICStreamProvider*)Unsafe.AsPointer(ref this), ppIStream);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPersistOptions([NativeTypeName("DWORD *")] uint* pdwPersistOptions)
        {
            return lpVtbl->GetPersistOptions((IWICStreamProvider*)Unsafe.AsPointer(ref this), pdwPersistOptions);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetPreferredVendorGUID([NativeTypeName("GUID *")] Guid* pguidPreferredVendor)
        {
            return lpVtbl->GetPreferredVendorGUID((IWICStreamProvider*)Unsafe.AsPointer(ref this), pguidPreferredVendor);
        }

        [return: NativeTypeName("HRESULT")]
        public int RefreshStream()
        {
            return lpVtbl->RefreshStream((IWICStreamProvider*)Unsafe.AsPointer(ref this));
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICStreamProvider*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICStreamProvider*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* stdcall<IWICStreamProvider*, uint> Release;

            [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
            public delegate* stdcall<IWICStreamProvider*, IStream**, int> GetStream;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICStreamProvider*, uint*, int> GetPersistOptions;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* stdcall<IWICStreamProvider*, Guid*, int> GetPreferredVendorGUID;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* stdcall<IWICStreamProvider*, int> RefreshStream;
        }
    }
}
