// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F670-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IElementNamespaceTable : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IElementNamespaceTable
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IElementNamespaceTable*, Guid*, void**, int>)(lpVtbl[0]))((IElementNamespaceTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IElementNamespaceTable*, uint>)(lpVtbl[1]))((IElementNamespaceTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IElementNamespaceTable*, uint>)(lpVtbl[2]))((IElementNamespaceTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddNamespace([NativeTypeName("BSTR")] ushort* bstrNamespace, [NativeTypeName("BSTR")] ushort* bstrUrn, [NativeTypeName("LONG")] int lFlags, VARIANT* pvarFactory)
        {
            return ((delegate* unmanaged<IElementNamespaceTable*, ushort*, ushort*, int, VARIANT*, int>)(lpVtbl[3]))((IElementNamespaceTable*)Unsafe.AsPointer(ref this), bstrNamespace, bstrUrn, lFlags, pvarFactory);
        }
    }
}
