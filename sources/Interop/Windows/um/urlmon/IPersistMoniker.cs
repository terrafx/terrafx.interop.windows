// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("79EAC9C9-BAF9-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IPersistMoniker : IUnknown")]
    public unsafe partial struct IPersistMoniker
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IPersistMoniker*, Guid*, void**, int>)(lpVtbl[0]))((IPersistMoniker*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPersistMoniker*, uint>)(lpVtbl[1]))((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPersistMoniker*, uint>)(lpVtbl[2]))((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
        {
            return ((delegate* unmanaged<IPersistMoniker*, Guid*, int>)(lpVtbl[3]))((IPersistMoniker*)Unsafe.AsPointer(ref this), pClassID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IsDirty()
        {
            return ((delegate* unmanaged<IPersistMoniker*, int>)(lpVtbl[4]))((IPersistMoniker*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Load([NativeTypeName("BOOL")] int fFullyAvailable, [NativeTypeName("IMoniker *")] IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc, [NativeTypeName("DWORD")] uint grfMode)
        {
            return ((delegate* unmanaged<IPersistMoniker*, int, IMoniker*, IBindCtx*, uint, int>)(lpVtbl[5]))((IPersistMoniker*)Unsafe.AsPointer(ref this), fFullyAvailable, pimkName, pibc, grfMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Save([NativeTypeName("IMoniker *")] IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pbc, [NativeTypeName("BOOL")] int fRemember)
        {
            return ((delegate* unmanaged<IPersistMoniker*, IMoniker*, IBindCtx*, int, int>)(lpVtbl[6]))((IPersistMoniker*)Unsafe.AsPointer(ref this), pimkName, pbc, fRemember);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SaveCompleted([NativeTypeName("IMoniker *")] IMoniker* pimkName, [NativeTypeName("LPBC")] IBindCtx* pibc)
        {
            return ((delegate* unmanaged<IPersistMoniker*, IMoniker*, IBindCtx*, int>)(lpVtbl[7]))((IPersistMoniker*)Unsafe.AsPointer(ref this), pimkName, pibc);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCurMoniker([NativeTypeName("IMoniker **")] IMoniker** ppimkName)
        {
            return ((delegate* unmanaged<IPersistMoniker*, IMoniker**, int>)(lpVtbl[8]))((IPersistMoniker*)Unsafe.AsPointer(ref this), ppimkName);
        }
    }
}
