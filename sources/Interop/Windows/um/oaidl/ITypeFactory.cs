// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("0000002E-0000-0000-C000-000000000046")]
    [NativeTypeName("struct ITypeFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITypeFactory : ITypeFactory.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITypeFactory*, Guid*, void**, int>)(lpVtbl[0]))((ITypeFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITypeFactory*, uint>)(lpVtbl[1]))((ITypeFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITypeFactory*, uint>)(lpVtbl[2]))((ITypeFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateFromTypeInfo(ITypeInfo* pTypeInfo, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppv)
        {
            return ((delegate* unmanaged<ITypeFactory*, ITypeInfo*, Guid*, IUnknown**, int>)(lpVtbl[3]))((ITypeFactory*)Unsafe.AsPointer(ref this), pTypeInfo, riid, ppv);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateFromTypeInfo(ITypeInfo* pTypeInfo, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeFactory*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeFactory*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeFactory*, uint> Release;

            [NativeTypeName("HRESULT (ITypeInfo *, const IID &, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITypeFactory*, ITypeInfo*, Guid*, IUnknown**, int> CreateFromTypeInfo;
        }
    }
}
