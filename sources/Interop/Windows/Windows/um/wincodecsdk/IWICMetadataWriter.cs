// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("F7836E16-3BE0-470B-86BB-160D0AECD7DE")]
    [NativeTypeName("struct IWICMetadataWriter : IWICMetadataReader")]
    [NativeInheritance("IWICMetadataReader")]
    public unsafe partial struct IWICMetadataWriter : IWICMetadataWriter.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IWICMetadataWriter*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IWICMetadataWriter*, uint>)(lpVtbl[1]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IWICMetadataWriter*, uint>)(lpVtbl[2]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetMetadataFormat(Guid* pguidMetadataFormat)
        {
            return ((delegate* unmanaged<IWICMetadataWriter*, Guid*, int>)(lpVtbl[3]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetMetadataHandlerInfo(IWICMetadataHandlerInfo** ppIHandler)
        {
            return ((delegate* unmanaged<IWICMetadataWriter*, IWICMetadataHandlerInfo**, int>)(lpVtbl[4]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), ppIHandler);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetCount(uint* pcCount)
        {
            return ((delegate* unmanaged<IWICMetadataWriter*, uint*, int>)(lpVtbl[5]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pcCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetValueByIndex(uint nIndex, PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue)
        {
            return ((delegate* unmanaged<IWICMetadataWriter*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[6]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, PROPVARIANT* pvarValue)
        {
            return ((delegate* unmanaged<IWICMetadataWriter*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[7]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetEnumerator(IWICEnumMetadataItem** ppIEnumMetadata)
        {
            return ((delegate* unmanaged<IWICMetadataWriter*, IWICEnumMetadataItem**, int>)(lpVtbl[8]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return ((delegate* unmanaged<IWICMetadataWriter*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[9]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetValueByIndex(uint nIndex, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue)
        {
            return ((delegate* unmanaged<IWICMetadataWriter*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[10]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT RemoveValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId)
        {
            return ((delegate* unmanaged<IWICMetadataWriter*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[11]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), pvarSchema, pvarId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT RemoveValueByIndex(uint nIndex)
        {
            return ((delegate* unmanaged<IWICMetadataWriter*, uint, int>)(lpVtbl[12]))((IWICMetadataWriter*)Unsafe.AsPointer(ref this), nIndex);
        }

        public interface Interface : IWICMetadataReader.Interface
        {
            [VtblIndex(9)]
            HRESULT SetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue);

            [VtblIndex(10)]
            HRESULT SetValueByIndex(uint nIndex, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue);

            [VtblIndex(11)]
            HRESULT RemoveValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId);

            [VtblIndex(12)]
            HRESULT RemoveValueByIndex(uint nIndex);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataWriter*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataWriter*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataWriter*, uint> Release;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataWriter*, Guid*, int> GetMetadataFormat;

            [NativeTypeName("HRESULT (IWICMetadataHandlerInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataWriter*, IWICMetadataHandlerInfo**, int> GetMetadataHandlerInfo;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataWriter*, uint*, int> GetCount;

            [NativeTypeName("HRESULT (UINT, PROPVARIANT *, PROPVARIANT *, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataWriter*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> GetValueByIndex;

            [NativeTypeName("HRESULT (const PROPVARIANT *, const PROPVARIANT *, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataWriter*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> GetValue;

            [NativeTypeName("HRESULT (IWICEnumMetadataItem **) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataWriter*, IWICEnumMetadataItem**, int> GetEnumerator;

            [NativeTypeName("HRESULT (const PROPVARIANT *, const PROPVARIANT *, const PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataWriter*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> SetValue;

            [NativeTypeName("HRESULT (UINT, const PROPVARIANT *, const PROPVARIANT *, const PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataWriter*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> SetValueByIndex;

            [NativeTypeName("HRESULT (const PROPVARIANT *, const PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataWriter*, PROPVARIANT*, PROPVARIANT*, int> RemoveValue;

            [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
            public delegate* unmanaged<IWICMetadataWriter*, uint, int> RemoveValueByIndex;
        }
    }
}
