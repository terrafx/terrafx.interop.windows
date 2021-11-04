// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Unknwnbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000001-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IClassFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IClassFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IClassFactory*, uint>)(lpVtbl[1]))((IClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IClassFactory*, uint>)(lpVtbl[2]))((IClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateInstance(IUnknown* pUnkOuter, [NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IClassFactory*, IUnknown*, Guid*, void**, int>)(lpVtbl[3]))((IClassFactory*)Unsafe.AsPointer(ref this), pUnkOuter, riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT LockServer(BOOL fLock)
        {
            return ((delegate* unmanaged<IClassFactory*, BOOL, int>)(lpVtbl[4]))((IClassFactory*)Unsafe.AsPointer(ref this), fLock);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IClassFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IClassFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IClassFactory*, uint> Release;

            [NativeTypeName("HRESULT (IUnknown *, const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IClassFactory*, IUnknown*, Guid*, void**, int> CreateInstance;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IClassFactory*, BOOL, int> LockServer;
        }
    }
}
