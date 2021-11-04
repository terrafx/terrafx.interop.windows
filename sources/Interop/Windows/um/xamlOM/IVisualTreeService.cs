// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A593B11A-D17F-48BB-8F66-83910731C8A5")]
    [NativeTypeName("struct IVisualTreeService : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IVisualTreeService
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVisualTreeService*, Guid*, void**, int>)(lpVtbl[0]))((IVisualTreeService*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVisualTreeService*, uint>)(lpVtbl[1]))((IVisualTreeService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVisualTreeService*, uint>)(lpVtbl[2]))((IVisualTreeService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AdviseVisualTreeChange(IVisualTreeServiceCallback* pCallback)
        {
            return ((delegate* unmanaged<IVisualTreeService*, IVisualTreeServiceCallback*, int>)(lpVtbl[3]))((IVisualTreeService*)Unsafe.AsPointer(ref this), pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UnadviseVisualTreeChange(IVisualTreeServiceCallback* pCallback)
        {
            return ((delegate* unmanaged<IVisualTreeService*, IVisualTreeServiceCallback*, int>)(lpVtbl[4]))((IVisualTreeService*)Unsafe.AsPointer(ref this), pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetEnums([NativeTypeName("unsigned int *")] uint* pCount, EnumType** ppEnums)
        {
            return ((delegate* unmanaged<IVisualTreeService*, uint*, EnumType**, int>)(lpVtbl[5]))((IVisualTreeService*)Unsafe.AsPointer(ref this), pCount, ppEnums);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT CreateInstance([NativeTypeName("BSTR")] ushort* typeName, [NativeTypeName("BSTR")] ushort* value, InstanceHandle* pInstanceHandle)
        {
            return ((delegate* unmanaged<IVisualTreeService*, ushort*, ushort*, InstanceHandle*, int>)(lpVtbl[6]))((IVisualTreeService*)Unsafe.AsPointer(ref this), typeName, value, pInstanceHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetPropertyValuesChain(InstanceHandle instanceHandle, [NativeTypeName("unsigned int *")] uint* pSourceCount, PropertyChainSource** ppPropertySources, [NativeTypeName("unsigned int *")] uint* pPropertyCount, PropertyChainValue** ppPropertyValues)
        {
            return ((delegate* unmanaged<IVisualTreeService*, InstanceHandle, uint*, PropertyChainSource**, uint*, PropertyChainValue**, int>)(lpVtbl[7]))((IVisualTreeService*)Unsafe.AsPointer(ref this), instanceHandle, pSourceCount, ppPropertySources, pPropertyCount, ppPropertyValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetProperty(InstanceHandle instanceHandle, InstanceHandle value, [NativeTypeName("unsigned int")] uint propertyIndex)
        {
            return ((delegate* unmanaged<IVisualTreeService*, InstanceHandle, InstanceHandle, uint, int>)(lpVtbl[8]))((IVisualTreeService*)Unsafe.AsPointer(ref this), instanceHandle, value, propertyIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT ClearProperty(InstanceHandle instanceHandle, [NativeTypeName("unsigned int")] uint propertyIndex)
        {
            return ((delegate* unmanaged<IVisualTreeService*, InstanceHandle, uint, int>)(lpVtbl[9]))((IVisualTreeService*)Unsafe.AsPointer(ref this), instanceHandle, propertyIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT GetCollectionCount(InstanceHandle instanceHandle, [NativeTypeName("unsigned int *")] uint* pCollectionSize)
        {
            return ((delegate* unmanaged<IVisualTreeService*, InstanceHandle, uint*, int>)(lpVtbl[10]))((IVisualTreeService*)Unsafe.AsPointer(ref this), instanceHandle, pCollectionSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetCollectionElements(InstanceHandle instanceHandle, [NativeTypeName("unsigned int")] uint startIndex, [NativeTypeName("unsigned int *")] uint* pElementCount, CollectionElementValue** ppElementValues)
        {
            return ((delegate* unmanaged<IVisualTreeService*, InstanceHandle, uint, uint*, CollectionElementValue**, int>)(lpVtbl[11]))((IVisualTreeService*)Unsafe.AsPointer(ref this), instanceHandle, startIndex, pElementCount, ppElementValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT AddChild(InstanceHandle parent, InstanceHandle child, [NativeTypeName("unsigned int")] uint index)
        {
            return ((delegate* unmanaged<IVisualTreeService*, InstanceHandle, InstanceHandle, uint, int>)(lpVtbl[12]))((IVisualTreeService*)Unsafe.AsPointer(ref this), parent, child, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HRESULT RemoveChild(InstanceHandle parent, [NativeTypeName("unsigned int")] uint index)
        {
            return ((delegate* unmanaged<IVisualTreeService*, InstanceHandle, uint, int>)(lpVtbl[13]))((IVisualTreeService*)Unsafe.AsPointer(ref this), parent, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HRESULT ClearChildren(InstanceHandle parent)
        {
            return ((delegate* unmanaged<IVisualTreeService*, InstanceHandle, int>)(lpVtbl[14]))((IVisualTreeService*)Unsafe.AsPointer(ref this), parent);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IVisualTreeService*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IVisualTreeService*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IVisualTreeService*, uint> Release;

            [NativeTypeName("HRESULT (IVisualTreeServiceCallback *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVisualTreeService*, IVisualTreeServiceCallback*, int> AdviseVisualTreeChange;

            [NativeTypeName("HRESULT (IVisualTreeServiceCallback *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVisualTreeService*, IVisualTreeServiceCallback*, int> UnadviseVisualTreeChange;

            [NativeTypeName("HRESULT (unsigned int *, EnumType **) __attribute__((stdcall))")]
            public delegate* unmanaged<IVisualTreeService*, uint*, EnumType**, int> GetEnums;

            [NativeTypeName("HRESULT (BSTR, BSTR, InstanceHandle *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVisualTreeService*, ushort*, ushort*, InstanceHandle*, int> CreateInstance;

            [NativeTypeName("HRESULT (InstanceHandle, unsigned int *, PropertyChainSource **, unsigned int *, PropertyChainValue **) __attribute__((stdcall))")]
            public delegate* unmanaged<IVisualTreeService*, InstanceHandle, uint*, PropertyChainSource**, uint*, PropertyChainValue**, int> GetPropertyValuesChain;

            [NativeTypeName("HRESULT (InstanceHandle, InstanceHandle, unsigned int) __attribute__((stdcall))")]
            public delegate* unmanaged<IVisualTreeService*, InstanceHandle, InstanceHandle, uint, int> SetProperty;

            [NativeTypeName("HRESULT (InstanceHandle, unsigned int) __attribute__((stdcall))")]
            public delegate* unmanaged<IVisualTreeService*, InstanceHandle, uint, int> ClearProperty;

            [NativeTypeName("HRESULT (InstanceHandle, unsigned int *) __attribute__((stdcall))")]
            public delegate* unmanaged<IVisualTreeService*, InstanceHandle, uint*, int> GetCollectionCount;

            [NativeTypeName("HRESULT (InstanceHandle, unsigned int, unsigned int *, CollectionElementValue **) __attribute__((stdcall))")]
            public delegate* unmanaged<IVisualTreeService*, InstanceHandle, uint, uint*, CollectionElementValue**, int> GetCollectionElements;

            [NativeTypeName("HRESULT (InstanceHandle, InstanceHandle, unsigned int) __attribute__((stdcall))")]
            public delegate* unmanaged<IVisualTreeService*, InstanceHandle, InstanceHandle, uint, int> AddChild;

            [NativeTypeName("HRESULT (InstanceHandle, unsigned int) __attribute__((stdcall))")]
            public delegate* unmanaged<IVisualTreeService*, InstanceHandle, uint, int> RemoveChild;

            [NativeTypeName("HRESULT (InstanceHandle) __attribute__((stdcall))")]
            public delegate* unmanaged<IVisualTreeService*, InstanceHandle, int> ClearChildren;
        }
    }
}
