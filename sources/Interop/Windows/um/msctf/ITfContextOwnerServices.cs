// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B23EB630-3E1C-11D3-A745-0050040AB407")]
    [NativeTypeName("struct ITfContextOwnerServices : IUnknown")]
    public unsafe partial struct ITfContextOwnerServices
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, Guid*, void**, int>)(lpVtbl[0]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, uint>)(lpVtbl[1]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, uint>)(lpVtbl[2]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnLayoutChange()
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, int>)(lpVtbl[3]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnStatusChange([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, uint, int>)(lpVtbl[4]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnAttributeChange([NativeTypeName("const GUID &")] Guid* rguidAttribute)
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, Guid*, int>)(lpVtbl[5]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this), rguidAttribute);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Serialize([NativeTypeName("ITfProperty *")] ITfProperty* pProp, [NativeTypeName("ITfRange *")] ITfRange* pRange, [NativeTypeName("TF_PERSISTENT_PROPERTY_HEADER_ACP *")] TF_PERSISTENT_PROPERTY_HEADER_ACP* pHdr, [NativeTypeName("IStream *")] IStream* pStream)
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, ITfProperty*, ITfRange*, TF_PERSISTENT_PROPERTY_HEADER_ACP*, IStream*, int>)(lpVtbl[6]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this), pProp, pRange, pHdr, pStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Unserialize([NativeTypeName("ITfProperty *")] ITfProperty* pProp, [NativeTypeName("const TF_PERSISTENT_PROPERTY_HEADER_ACP *")] TF_PERSISTENT_PROPERTY_HEADER_ACP* pHdr, [NativeTypeName("IStream *")] IStream* pStream, [NativeTypeName("ITfPersistentPropertyLoaderACP *")] ITfPersistentPropertyLoaderACP* pLoader)
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, ITfProperty*, TF_PERSISTENT_PROPERTY_HEADER_ACP*, IStream*, ITfPersistentPropertyLoaderACP*, int>)(lpVtbl[7]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this), pProp, pHdr, pStream, pLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ForceLoadProperty([NativeTypeName("ITfProperty *")] ITfProperty* pProp)
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, ITfProperty*, int>)(lpVtbl[8]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this), pProp);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateRange([NativeTypeName("LONG")] int acpStart, [NativeTypeName("LONG")] int acpEnd, [NativeTypeName("ITfRangeACP **")] ITfRangeACP** ppRange)
        {
            return ((delegate* unmanaged<ITfContextOwnerServices*, int, int, ITfRangeACP**, int>)(lpVtbl[9]))((ITfContextOwnerServices*)Unsafe.AsPointer(ref this), acpStart, acpEnd, ppRange);
        }
    }
}
