// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DC2BB46D-3F07-481E-8625-220C4AEDBB33")]
    [NativeTypeName("struct IWICEnumMetadataItem : IUnknown")]
    public unsafe partial struct IWICEnumMetadataItem
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWICEnumMetadataItem*, Guid*, void**, int>)(lpVtbl[0]))((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWICEnumMetadataItem*, uint>)(lpVtbl[1]))((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWICEnumMetadataItem*, uint>)(lpVtbl[2]))((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint celt, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* rgeltSchema, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* rgeltId, [NativeTypeName("PROPVARIANT *")] PROPVARIANT* rgeltValue, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* stdcall<IWICEnumMetadataItem*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, uint*, int>)(lpVtbl[3]))((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), celt, rgeltSchema, rgeltId, rgeltValue, pceltFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* stdcall<IWICEnumMetadataItem*, uint, int>)(lpVtbl[4]))((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), celt);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* stdcall<IWICEnumMetadataItem*, int>)(lpVtbl[5]))((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IWICEnumMetadataItem **")] IWICEnumMetadataItem** ppIEnumMetadataItem)
        {
            return ((delegate* stdcall<IWICEnumMetadataItem*, IWICEnumMetadataItem**, int>)(lpVtbl[6]))((IWICEnumMetadataItem*)Unsafe.AsPointer(ref this), ppIEnumMetadataItem);
        }
    }
}
