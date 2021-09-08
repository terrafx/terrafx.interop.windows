// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9B1921E1-54AC-11D3-9144-00104BA11C5E")]
    [NativeTypeName("struct IEnumDiscRecorders : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumDiscRecorders
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumDiscRecorders*, Guid*, void**, int>)(lpVtbl[0]))((IEnumDiscRecorders*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumDiscRecorders*, uint>)(lpVtbl[1]))((IEnumDiscRecorders*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumDiscRecorders*, uint>)(lpVtbl[2]))((IEnumDiscRecorders*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Next([NativeTypeName("ULONG")] uint cRecorders, IDiscRecorder** ppRecorder, [NativeTypeName("ULONG *")] uint* pcFetched)
        {
            return ((delegate* unmanaged<IEnumDiscRecorders*, uint, IDiscRecorder**, uint*, int>)(lpVtbl[3]))((IEnumDiscRecorders*)Unsafe.AsPointer(ref this), cRecorders, ppRecorder, pcFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int Skip([NativeTypeName("ULONG")] uint cRecorders)
        {
            return ((delegate* unmanaged<IEnumDiscRecorders*, uint, int>)(lpVtbl[4]))((IEnumDiscRecorders*)Unsafe.AsPointer(ref this), cRecorders);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Reset()
        {
            return ((delegate* unmanaged<IEnumDiscRecorders*, int>)(lpVtbl[5]))((IEnumDiscRecorders*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Clone(IEnumDiscRecorders** ppEnum)
        {
            return ((delegate* unmanaged<IEnumDiscRecorders*, IEnumDiscRecorders**, int>)(lpVtbl[6]))((IEnumDiscRecorders*)Unsafe.AsPointer(ref this), ppEnum);
        }
    }
}
