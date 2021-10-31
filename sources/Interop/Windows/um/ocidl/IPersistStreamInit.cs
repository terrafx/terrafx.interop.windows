// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("7FD52380-4E07-101B-AE2D-08002B2EC713")]
    [NativeTypeName("struct IPersistStreamInit : IPersist")]
    [NativeInheritance("IPersist")]
    public unsafe partial struct IPersistStreamInit
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPersistStreamInit*, Guid*, void**, int>)(lpVtbl[0]))((IPersistStreamInit*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPersistStreamInit*, uint>)(lpVtbl[1]))((IPersistStreamInit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPersistStreamInit*, uint>)(lpVtbl[2]))((IPersistStreamInit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IPersistStreamInit*, Guid*, int>)(lpVtbl[3]))((IPersistStreamInit*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT IsDirty()
        {
            return ((delegate* unmanaged<IPersistStreamInit*, int>)(lpVtbl[4]))((IPersistStreamInit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Load([NativeTypeName("LPSTREAM")] IStream* pStm)
        {
            return ((delegate* unmanaged<IPersistStreamInit*, IStream*, int>)(lpVtbl[5]))((IPersistStreamInit*)Unsafe.AsPointer(ref this), pStm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Save([NativeTypeName("LPSTREAM")] IStream* pStm, BOOL fClearDirty)
        {
            return ((delegate* unmanaged<IPersistStreamInit*, IStream*, BOOL, int>)(lpVtbl[6]))((IPersistStreamInit*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetSizeMax(ULARGE_INTEGER* pCbSize)
        {
            return ((delegate* unmanaged<IPersistStreamInit*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IPersistStreamInit*)Unsafe.AsPointer(ref this), pCbSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT InitNew()
        {
            return ((delegate* unmanaged<IPersistStreamInit*, int>)(lpVtbl[8]))((IPersistStreamInit*)Unsafe.AsPointer(ref this));
        }
    }
}
