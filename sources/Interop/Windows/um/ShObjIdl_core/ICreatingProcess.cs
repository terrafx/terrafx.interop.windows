// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C2B937A9-3110-4398-8A56-F34C6342D244")]
    [NativeTypeName("struct ICreatingProcess : IUnknown")]
    public unsafe partial struct ICreatingProcess
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICreatingProcess*, Guid*, void**, int>)(lpVtbl[0]))((ICreatingProcess*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICreatingProcess*, uint>)(lpVtbl[1]))((ICreatingProcess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICreatingProcess*, uint>)(lpVtbl[2]))((ICreatingProcess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnCreating(ICreateProcessInputs* pcpi)
        {
            return ((delegate* unmanaged<ICreatingProcess*, ICreateProcessInputs*, int>)(lpVtbl[3]))((ICreatingProcess*)Unsafe.AsPointer(ref this), pcpi);
        }
    }
}
