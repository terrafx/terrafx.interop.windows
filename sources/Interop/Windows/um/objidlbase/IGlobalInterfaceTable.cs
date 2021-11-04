// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000146-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IGlobalInterfaceTable : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IGlobalInterfaceTable
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IGlobalInterfaceTable*, Guid*, void**, int>)(lpVtbl[0]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IGlobalInterfaceTable*, uint>)(lpVtbl[1]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IGlobalInterfaceTable*, uint>)(lpVtbl[2]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT RegisterInterfaceInGlobal(IUnknown* pUnk, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<IGlobalInterfaceTable*, IUnknown*, Guid*, uint*, int>)(lpVtbl[3]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), pUnk, riid, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT RevokeInterfaceFromGlobal([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<IGlobalInterfaceTable*, uint, int>)(lpVtbl[4]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetInterfaceFromGlobal([NativeTypeName("DWORD")] uint dwCookie, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IGlobalInterfaceTable*, uint, Guid*, void**, int>)(lpVtbl[5]))((IGlobalInterfaceTable*)Unsafe.AsPointer(ref this), dwCookie, riid, ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IGlobalInterfaceTable*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IGlobalInterfaceTable*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IGlobalInterfaceTable*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *, const IID &, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<IGlobalInterfaceTable*, IUnknown*, Guid*, uint*, int> RegisterInterfaceInGlobal;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IGlobalInterfaceTable*, uint, int> RevokeInterfaceFromGlobal;

            [NativeTypeName("HRESULT (DWORD, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IGlobalInterfaceTable*, uint, Guid*, void**, int> GetInterfaceFromGlobal;
        }
    }
}
