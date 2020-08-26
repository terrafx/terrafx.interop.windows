// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2C3CD98A-2BFA-4A53-9C27-5249BA64BA0F")]
    [NativeTypeName("struct IEnumDMO : IUnknown")]
    public unsafe partial struct IEnumDMO
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IEnumDMO*, Guid*, void**, int>)(lpVtbl[0]))((IEnumDMO*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IEnumDMO*, uint>)(lpVtbl[1]))((IEnumDMO*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IEnumDMO*, uint>)(lpVtbl[2]))((IEnumDMO*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("DWORD")] uint cItemsToFetch, [NativeTypeName("CLSID *")] Guid* pCLSID, [NativeTypeName("LPWSTR *")] ushort** Names, [NativeTypeName("DWORD *")] uint* pcItemsFetched)
        {
            return ((delegate* stdcall<IEnumDMO*, uint, Guid*, ushort**, uint*, int>)(lpVtbl[3]))((IEnumDMO*)Unsafe.AsPointer(ref this), cItemsToFetch, pCLSID, Names, pcItemsFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("DWORD")] uint cItemsToSkip)
        {
            return ((delegate* stdcall<IEnumDMO*, uint, int>)(lpVtbl[4]))((IEnumDMO*)Unsafe.AsPointer(ref this), cItemsToSkip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* stdcall<IEnumDMO*, int>)(lpVtbl[5]))((IEnumDMO*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumDMO **")] IEnumDMO** ppEnum)
        {
            return ((delegate* stdcall<IEnumDMO*, IEnumDMO**, int>)(lpVtbl[6]))((IEnumDMO*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
