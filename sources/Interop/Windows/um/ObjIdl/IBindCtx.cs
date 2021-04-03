// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ObjIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000000E-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IBindCtx : IUnknown")]
    public unsafe partial struct IBindCtx
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBindCtx*, Guid*, void**, int>)(lpVtbl[0]))((IBindCtx*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBindCtx*, uint>)(lpVtbl[1]))((IBindCtx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBindCtx*, uint>)(lpVtbl[2]))((IBindCtx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterObjectBound(IUnknown* punk)
        {
            return ((delegate* unmanaged<IBindCtx*, IUnknown*, int>)(lpVtbl[3]))((IBindCtx*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RevokeObjectBound(IUnknown* punk)
        {
            return ((delegate* unmanaged<IBindCtx*, IUnknown*, int>)(lpVtbl[4]))((IBindCtx*)Unsafe.AsPointer(ref this), punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ReleaseBoundObjects()
        {
            return ((delegate* unmanaged<IBindCtx*, int>)(lpVtbl[5]))((IBindCtx*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetBindOptions(BIND_OPTS* pbindopts)
        {
            return ((delegate* unmanaged<IBindCtx*, BIND_OPTS*, int>)(lpVtbl[6]))((IBindCtx*)Unsafe.AsPointer(ref this), pbindopts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBindOptions(BIND_OPTS* pbindopts)
        {
            return ((delegate* unmanaged<IBindCtx*, BIND_OPTS*, int>)(lpVtbl[7]))((IBindCtx*)Unsafe.AsPointer(ref this), pbindopts);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRunningObjectTable(IRunningObjectTable** pprot)
        {
            return ((delegate* unmanaged<IBindCtx*, IRunningObjectTable**, int>)(lpVtbl[8]))((IBindCtx*)Unsafe.AsPointer(ref this), pprot);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, IUnknown* punk)
        {
            return ((delegate* unmanaged<IBindCtx*, ushort*, IUnknown*, int>)(lpVtbl[9]))((IBindCtx*)Unsafe.AsPointer(ref this), pszKey, punk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<IBindCtx*, ushort*, IUnknown**, int>)(lpVtbl[10]))((IBindCtx*)Unsafe.AsPointer(ref this), pszKey, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumObjectParam(IEnumString** ppenum)
        {
            return ((delegate* unmanaged<IBindCtx*, IEnumString**, int>)(lpVtbl[11]))((IBindCtx*)Unsafe.AsPointer(ref this), ppenum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RevokeObjectParam([NativeTypeName("LPOLESTR")] ushort* pszKey)
        {
            return ((delegate* unmanaged<IBindCtx*, ushort*, int>)(lpVtbl[12]))((IBindCtx*)Unsafe.AsPointer(ref this), pszKey);
        }
    }
}
