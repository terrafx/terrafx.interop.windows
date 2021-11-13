// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("00020410-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ITypeChangeEvents : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITypeChangeEvents : ITypeChangeEvents.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITypeChangeEvents*, Guid*, void**, int>)(lpVtbl[0]))((ITypeChangeEvents*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITypeChangeEvents*, uint>)(lpVtbl[1]))((ITypeChangeEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITypeChangeEvents*, uint>)(lpVtbl[2]))((ITypeChangeEvents*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT RequestTypeChange(CHANGEKIND changeKind, ITypeInfo* pTInfoBefore, [NativeTypeName("LPOLESTR")] ushort* pStrName, int* pfCancel)
        {
            return ((delegate* unmanaged<ITypeChangeEvents*, CHANGEKIND, ITypeInfo*, ushort*, int*, int>)(lpVtbl[3]))((ITypeChangeEvents*)Unsafe.AsPointer(ref this), changeKind, pTInfoBefore, pStrName, pfCancel);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AfterTypeChange(CHANGEKIND changeKind, ITypeInfo* pTInfoAfter, [NativeTypeName("LPOLESTR")] ushort* pStrName)
        {
            return ((delegate* unmanaged<ITypeChangeEvents*, CHANGEKIND, ITypeInfo*, ushort*, int>)(lpVtbl[4]))((ITypeChangeEvents*)Unsafe.AsPointer(ref this), changeKind, pTInfoAfter, pStrName);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT RequestTypeChange(CHANGEKIND changeKind, ITypeInfo* pTInfoBefore, [NativeTypeName("LPOLESTR")] ushort* pStrName, int* pfCancel);

            [VtblIndex(4)]
            HRESULT AfterTypeChange(CHANGEKIND changeKind, ITypeInfo* pTInfoAfter, [NativeTypeName("LPOLESTR")] ushort* pStrName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeChangeEvents*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeChangeEvents*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeChangeEvents*, uint> Release;

            [NativeTypeName("HRESULT (CHANGEKIND, ITypeInfo *, LPOLESTR, INT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeChangeEvents*, CHANGEKIND, ITypeInfo*, ushort*, int*, int> RequestTypeChange;

            [NativeTypeName("HRESULT (CHANGEKIND, ITypeInfo *, LPOLESTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeChangeEvents*, CHANGEKIND, ITypeInfo*, ushort*, int> AfterTypeChange;
        }
    }
}
