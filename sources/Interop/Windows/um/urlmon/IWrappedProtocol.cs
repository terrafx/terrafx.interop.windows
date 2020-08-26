// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("53C84785-8425-4DC5-971B-E58D9C19F9B6")]
    [NativeTypeName("struct IWrappedProtocol : IUnknown")]
    public unsafe partial struct IWrappedProtocol
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IWrappedProtocol*, Guid*, void**, int>)(lpVtbl[0]))((IWrappedProtocol*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IWrappedProtocol*, uint>)(lpVtbl[1]))((IWrappedProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IWrappedProtocol*, uint>)(lpVtbl[2]))((IWrappedProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetWrapperCode([NativeTypeName("LONG *")] int* pnCode, [NativeTypeName("DWORD_PTR")] nuint dwReserved)
        {
            return ((delegate* stdcall<IWrappedProtocol*, int*, nuint, int>)(lpVtbl[3]))((IWrappedProtocol*)Unsafe.AsPointer(ref this), pnCode, dwReserved);
        }
    }
}
