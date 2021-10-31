// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000109-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IPersistStream : IPersist")]
    [NativeInheritance("IPersist")]
    public unsafe partial struct IPersistStream
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPersistStream*, Guid*, void**, int>)(lpVtbl[0]))((IPersistStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPersistStream*, uint>)(lpVtbl[1]))((IPersistStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPersistStream*, uint>)(lpVtbl[2]))((IPersistStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IPersistStream*, Guid*, int>)(lpVtbl[3]))((IPersistStream*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return ((delegate* unmanaged<IPersistStream*, int>)(lpVtbl[4]))((IPersistStream*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Load(IStream* pStm)
        {
            return ((delegate* unmanaged<IPersistStream*, IStream*, int>)(lpVtbl[5]))((IPersistStream*)Unsafe.AsPointer(ref this), pStm);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Save(IStream* pStm, BOOL fClearDirty)
        {
            return ((delegate* unmanaged<IPersistStream*, IStream*, BOOL, int>)(lpVtbl[6]))((IPersistStream*)Unsafe.AsPointer(ref this), pStm, fClearDirty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int GetSizeMax(ULARGE_INTEGER* pcbSize)
        {
            return ((delegate* unmanaged<IPersistStream*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IPersistStream*)Unsafe.AsPointer(ref this), pcbSize);
        }
    }
}
