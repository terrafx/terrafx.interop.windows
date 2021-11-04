// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2271DCCA-74FC-4414-8FB7-C56B05ACE2D7")]
    [NativeTypeName("struct ICDBurnExt : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICDBurnExt
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICDBurnExt*, Guid*, void**, int>)(lpVtbl[0]))((ICDBurnExt*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICDBurnExt*, uint>)(lpVtbl[1]))((ICDBurnExt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICDBurnExt*, uint>)(lpVtbl[2]))((ICDBurnExt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetSupportedActionTypes([NativeTypeName("CDBE_ACTIONS *")] uint* pdwActions)
        {
            return ((delegate* unmanaged<ICDBurnExt*, uint*, int>)(lpVtbl[3]))((ICDBurnExt*)Unsafe.AsPointer(ref this), pdwActions);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICDBurnExt*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICDBurnExt*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICDBurnExt*, uint> Release;

            [NativeTypeName("HRESULT (CDBE_ACTIONS *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICDBurnExt*, uint*, int> GetSupportedActionTypes;
        }
    }
}
