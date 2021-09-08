// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4995F511-9DDB-4F12-BD3B-F04611807B79")]
    [NativeTypeName("struct IAMGraphBuilderCallback : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMGraphBuilderCallback
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMGraphBuilderCallback*, Guid*, void**, int>)(lpVtbl[0]))((IAMGraphBuilderCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMGraphBuilderCallback*, uint>)(lpVtbl[1]))((IAMGraphBuilderCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMGraphBuilderCallback*, uint>)(lpVtbl[2]))((IAMGraphBuilderCallback*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SelectedFilter(IMoniker* pMon)
        {
            return ((delegate* unmanaged<IAMGraphBuilderCallback*, IMoniker*, int>)(lpVtbl[3]))((IAMGraphBuilderCallback*)Unsafe.AsPointer(ref this), pMon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int CreatedFilter(IBaseFilter* pFil)
        {
            return ((delegate* unmanaged<IAMGraphBuilderCallback*, IBaseFilter*, int>)(lpVtbl[4]))((IAMGraphBuilderCallback*)Unsafe.AsPointer(ref this), pFil);
        }
    }
}
