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
    public unsafe partial struct IVisualTreeService
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IVisualTreeService*, Guid*, void**, int>)(lpVtbl[0]))((IVisualTreeService*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IVisualTreeService*, uint>)(lpVtbl[1]))((IVisualTreeService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IVisualTreeService*, uint>)(lpVtbl[2]))((IVisualTreeService*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AdviseVisualTreeChange(IVisualTreeServiceCallback* pCallback)
        {
            return ((delegate* unmanaged<IVisualTreeService*, IVisualTreeServiceCallback*, int>)(lpVtbl[3]))((IVisualTreeService*)Unsafe.AsPointer(ref this), pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UnadviseVisualTreeChange(IVisualTreeServiceCallback* pCallback)
        {
            return ((delegate* unmanaged<IVisualTreeService*, IVisualTreeServiceCallback*, int>)(lpVtbl[4]))((IVisualTreeService*)Unsafe.AsPointer(ref this), pCallback);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEnums([NativeTypeName("unsigned int *")] uint* pCount, EnumType** ppEnums)
        {
            return ((delegate* unmanaged<IVisualTreeService*, uint*, EnumType**, int>)(lpVtbl[5]))((IVisualTreeService*)Unsafe.AsPointer(ref this), pCount, ppEnums);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateInstance([NativeTypeName("BSTR")] ushort* typeName, [NativeTypeName("BSTR")] ushort* value, [NativeTypeName("InstanceHandle *")] ulong* pInstanceHandle)
        {
            return ((delegate* unmanaged<IVisualTreeService*, ushort*, ushort*, ulong*, int>)(lpVtbl[6]))((IVisualTreeService*)Unsafe.AsPointer(ref this), typeName, value, pInstanceHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPropertyValuesChain([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("unsigned int *")] uint* pSourceCount, PropertyChainSource** ppPropertySources, [NativeTypeName("unsigned int *")] uint* pPropertyCount, PropertyChainValue** ppPropertyValues)
        {
            return ((delegate* unmanaged<IVisualTreeService*, ulong, uint*, PropertyChainSource**, uint*, PropertyChainValue**, int>)(lpVtbl[7]))((IVisualTreeService*)Unsafe.AsPointer(ref this), instanceHandle, pSourceCount, ppPropertySources, pPropertyCount, ppPropertyValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetProperty([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("InstanceHandle")] ulong value, [NativeTypeName("unsigned int")] uint propertyIndex)
        {
            return ((delegate* unmanaged<IVisualTreeService*, ulong, ulong, uint, int>)(lpVtbl[8]))((IVisualTreeService*)Unsafe.AsPointer(ref this), instanceHandle, value, propertyIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearProperty([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("unsigned int")] uint propertyIndex)
        {
            return ((delegate* unmanaged<IVisualTreeService*, ulong, uint, int>)(lpVtbl[9]))((IVisualTreeService*)Unsafe.AsPointer(ref this), instanceHandle, propertyIndex);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCollectionCount([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("unsigned int *")] uint* pCollectionSize)
        {
            return ((delegate* unmanaged<IVisualTreeService*, ulong, uint*, int>)(lpVtbl[10]))((IVisualTreeService*)Unsafe.AsPointer(ref this), instanceHandle, pCollectionSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCollectionElements([NativeTypeName("InstanceHandle")] ulong instanceHandle, [NativeTypeName("unsigned int")] uint startIndex, [NativeTypeName("unsigned int *")] uint* pElementCount, CollectionElementValue** ppElementValues)
        {
            return ((delegate* unmanaged<IVisualTreeService*, ulong, uint, uint*, CollectionElementValue**, int>)(lpVtbl[11]))((IVisualTreeService*)Unsafe.AsPointer(ref this), instanceHandle, startIndex, pElementCount, ppElementValues);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int AddChild([NativeTypeName("InstanceHandle")] ulong parent, [NativeTypeName("InstanceHandle")] ulong child, [NativeTypeName("unsigned int")] uint index)
        {
            return ((delegate* unmanaged<IVisualTreeService*, ulong, ulong, uint, int>)(lpVtbl[12]))((IVisualTreeService*)Unsafe.AsPointer(ref this), parent, child, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RemoveChild([NativeTypeName("InstanceHandle")] ulong parent, [NativeTypeName("unsigned int")] uint index)
        {
            return ((delegate* unmanaged<IVisualTreeService*, ulong, uint, int>)(lpVtbl[13]))((IVisualTreeService*)Unsafe.AsPointer(ref this), parent, index);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ClearChildren([NativeTypeName("InstanceHandle")] ulong parent)
        {
            return ((delegate* unmanaged<IVisualTreeService*, ulong, int>)(lpVtbl[14]))((IVisualTreeService*)Unsafe.AsPointer(ref this), parent);
        }
    }
}
