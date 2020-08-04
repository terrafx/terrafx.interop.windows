// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A86893-0AD4-11CE-B03A-0020AF0BA770")]
    public unsafe partial struct IEnumFilters
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IEnumFilters*, Guid*, void**, int>)(lpVtbl[0]))((IEnumFilters*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IEnumFilters*, uint>)(lpVtbl[1]))((IEnumFilters*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IEnumFilters*, uint>)(lpVtbl[2]))((IEnumFilters*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cFilters, [NativeTypeName("IBaseFilter **")] IBaseFilter** ppFilter, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* stdcall<IEnumFilters*, uint, IBaseFilter**, uint*, int>)(lpVtbl[3]))((IEnumFilters*)Unsafe.AsPointer(ref this), cFilters, ppFilter, pcFetched);
        }

        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cFilters)
        {
            return ((delegate* stdcall<IEnumFilters*, uint, int>)(lpVtbl[4]))((IEnumFilters*)Unsafe.AsPointer(ref this), cFilters);
        }

        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* stdcall<IEnumFilters*, int>)(lpVtbl[5]))((IEnumFilters*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Clone([NativeTypeName("IEnumFilters **")] IEnumFilters** ppEnum)
        {
            return ((delegate* stdcall<IEnumFilters*, IEnumFilters**, int>)(lpVtbl[6]))((IEnumFilters*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
