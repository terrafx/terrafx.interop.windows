// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9CD-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IBindProtocol : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBindProtocol
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBindProtocol*, Guid*, void**, int>)(lpVtbl[0]))((IBindProtocol*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBindProtocol*, uint>)(lpVtbl[1]))((IBindProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBindProtocol*, uint>)(lpVtbl[2]))((IBindProtocol*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateBinding([NativeTypeName("LPCWSTR")] ushort* szUrl, IBindCtx* pbc, IBinding** ppb)
        {
            return ((delegate* unmanaged<IBindProtocol*, ushort*, IBindCtx*, IBinding**, int>)(lpVtbl[3]))((IBindProtocol*)Unsafe.AsPointer(ref this), szUrl, pbc, ppb);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindProtocol*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBindProtocol*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBindProtocol*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, IBindCtx *, IBinding **) __attribute__((stdcall))")]
            public delegate* unmanaged<IBindProtocol*, ushort*, IBindCtx*, IBinding**, int> CreateBinding;
        }
    }
}
