// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9C9-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IPersistMoniker : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPersistMoniker
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPersistMoniker*, Guid*, void**, int>)(lpVtbl[0]))((IPersistMoniker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPersistMoniker*, uint>)(lpVtbl[1]))((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPersistMoniker*, uint>)(lpVtbl[2]))((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IPersistMoniker*, Guid*, int>)(lpVtbl[3]))((IPersistMoniker*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return ((delegate* unmanaged<IPersistMoniker*, int>)(lpVtbl[4]))((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int Load(BOOL fFullyAvailable, IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("DWORD")] uint grfMode)
        {
            return ((delegate* unmanaged<IPersistMoniker*, BOOL, IMoniker*, IBindCtx*, uint, int>)(lpVtbl[5]))((IPersistMoniker*)Unsafe.AsPointer(ref this), fFullyAvailable, pimkName, pibc, grfMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Save(IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pbc, BOOL fRemember)
        {
            return ((delegate* unmanaged<IPersistMoniker*, IMoniker*, IBindCtx*, BOOL, int>)(lpVtbl[6]))((IPersistMoniker*)Unsafe.AsPointer(ref this), pimkName, pbc, fRemember);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SaveCompleted(IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc)
        {
            return ((delegate* unmanaged<IPersistMoniker*, IMoniker*, IBindCtx*, int>)(lpVtbl[7]))((IPersistMoniker*)Unsafe.AsPointer(ref this), pimkName, pibc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurMoniker(IMoniker** ppimkName)
        {
            return ((delegate* unmanaged<IPersistMoniker*, IMoniker**, int>)(lpVtbl[8]))((IPersistMoniker*)Unsafe.AsPointer(ref this), ppimkName);
        }
    }
}
