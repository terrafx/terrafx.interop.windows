// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00020410-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ITypeChangeEvents : IUnknown")]
    public unsafe partial struct ITypeChangeEvents
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<ITypeChangeEvents*, Guid*, void**, int>)(lpVtbl[0]))((ITypeChangeEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<ITypeChangeEvents*, uint>)(lpVtbl[1]))((ITypeChangeEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<ITypeChangeEvents*, uint>)(lpVtbl[2]))((ITypeChangeEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RequestTypeChange(CHANGEKIND changeKind, [NativeTypeName("ITypeInfo *")] ITypeInfo* pTInfoBefore, [NativeTypeName("LPOLESTR")] ushort* pStrName, [NativeTypeName("INT *")] int* pfCancel)
        {
            return ((delegate* stdcall<ITypeChangeEvents*, CHANGEKIND, ITypeInfo*, ushort*, int*, int>)(lpVtbl[3]))((ITypeChangeEvents*)Unsafe.AsPointer(ref this), changeKind, pTInfoBefore, pStrName, pfCancel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AfterTypeChange(CHANGEKIND changeKind, [NativeTypeName("ITypeInfo *")] ITypeInfo* pTInfoAfter, [NativeTypeName("LPOLESTR")] ushort* pStrName)
        {
            return ((delegate* stdcall<ITypeChangeEvents*, CHANGEKIND, ITypeInfo*, ushort*, int>)(lpVtbl[4]))((ITypeChangeEvents*)Unsafe.AsPointer(ref this), changeKind, pTInfoAfter, pStrName);
        }
    }
}
