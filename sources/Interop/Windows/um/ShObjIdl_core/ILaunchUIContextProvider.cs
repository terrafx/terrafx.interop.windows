// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0D12C4C8-A3D9-4E24-94C1-0E20C5A956C4")]
    [NativeTypeName("struct ILaunchUIContextProvider : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ILaunchUIContextProvider
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ILaunchUIContextProvider*, Guid*, void**, int>)(lpVtbl[0]))((ILaunchUIContextProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILaunchUIContextProvider*, uint>)(lpVtbl[1]))((ILaunchUIContextProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILaunchUIContextProvider*, uint>)(lpVtbl[2]))((ILaunchUIContextProvider*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT UpdateContext(ILaunchUIContext* context)
        {
            return ((delegate* unmanaged<ILaunchUIContextProvider*, ILaunchUIContext*, int>)(lpVtbl[3]))((ILaunchUIContextProvider*)Unsafe.AsPointer(ref this), context);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ILaunchUIContextProvider*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ILaunchUIContextProvider*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ILaunchUIContextProvider*, uint> Release;

            [NativeTypeName("HRESULT (ILaunchUIContext *) __attribute__((stdcall))")]
            public delegate* unmanaged<ILaunchUIContextProvider*, ILaunchUIContext*, int> UpdateContext;
        }
    }
}
