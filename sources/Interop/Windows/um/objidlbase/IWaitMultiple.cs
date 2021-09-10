// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000002B-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IWaitMultiple : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IWaitMultiple
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWaitMultiple*, Guid*, void**, int>)(lpVtbl[0]))((IWaitMultiple*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWaitMultiple*, uint>)(lpVtbl[1]))((IWaitMultiple*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWaitMultiple*, uint>)(lpVtbl[2]))((IWaitMultiple*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int WaitMultiple([NativeTypeName("DWORD")] uint timeout, ISynchronize** pSync)
        {
            return ((delegate* unmanaged<IWaitMultiple*, uint, ISynchronize**, int>)(lpVtbl[3]))((IWaitMultiple*)Unsafe.AsPointer(ref this), timeout, pSync);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int AddSynchronize(ISynchronize* pSync)
        {
            return ((delegate* unmanaged<IWaitMultiple*, ISynchronize*, int>)(lpVtbl[4]))((IWaitMultiple*)Unsafe.AsPointer(ref this), pSync);
        }
    }
}
