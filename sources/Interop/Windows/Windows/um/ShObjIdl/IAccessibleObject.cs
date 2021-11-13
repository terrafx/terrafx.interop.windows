// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("95A391C5-9ED4-4C28-8401-AB9E06719E11")]
    [NativeTypeName("struct IAccessibleObject : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAccessibleObject : IAccessibleObject.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAccessibleObject*, Guid*, void**, int>)(lpVtbl[0]))((IAccessibleObject*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAccessibleObject*, uint>)(lpVtbl[1]))((IAccessibleObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAccessibleObject*, uint>)(lpVtbl[2]))((IAccessibleObject*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetAccessibleName([NativeTypeName("LPCWSTR")] ushort* pszName)
        {
            return ((delegate* unmanaged<IAccessibleObject*, ushort*, int>)(lpVtbl[3]))((IAccessibleObject*)Unsafe.AsPointer(ref this), pszName);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetAccessibleName([NativeTypeName("LPCWSTR")] ushort* pszName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAccessibleObject*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAccessibleObject*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAccessibleObject*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IAccessibleObject*, ushort*, int> SetAccessibleName;
        }
    }
}
