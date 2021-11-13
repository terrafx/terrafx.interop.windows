// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("894AD3B0-EF97-11CE-9BC9-00AA00608E01")]
    [NativeTypeName("struct IOleUndoUnit : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IOleUndoUnit : IOleUndoUnit.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleUndoUnit*, Guid*, void**, int>)(lpVtbl[0]))((IOleUndoUnit*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleUndoUnit*, uint>)(lpVtbl[1]))((IOleUndoUnit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleUndoUnit*, uint>)(lpVtbl[2]))((IOleUndoUnit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Do(IOleUndoManager* pUndoManager)
        {
            return ((delegate* unmanaged<IOleUndoUnit*, IOleUndoManager*, int>)(lpVtbl[3]))((IOleUndoUnit*)Unsafe.AsPointer(ref this), pUndoManager);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return ((delegate* unmanaged<IOleUndoUnit*, ushort**, int>)(lpVtbl[4]))((IOleUndoUnit*)Unsafe.AsPointer(ref this), pBstr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetUnitType([NativeTypeName("CLSID *")] Guid* pClsid, [NativeTypeName("LONG *")] int* plID)
        {
            return ((delegate* unmanaged<IOleUndoUnit*, Guid*, int*, int>)(lpVtbl[5]))((IOleUndoUnit*)Unsafe.AsPointer(ref this), pClsid, plID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT OnNextAdd()
        {
            return ((delegate* unmanaged<IOleUndoUnit*, int>)(lpVtbl[6]))((IOleUndoUnit*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Do(IOleUndoManager* pUndoManager);

            [VtblIndex(4)]
            HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pBstr);

            [VtblIndex(5)]
            HRESULT GetUnitType([NativeTypeName("CLSID *")] Guid* pClsid, [NativeTypeName("LONG *")] int* plID);

            [VtblIndex(6)]
            HRESULT OnNextAdd();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleUndoUnit*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleUndoUnit*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleUndoUnit*, uint> Release;

            [NativeTypeName("HRESULT (IOleUndoManager *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleUndoUnit*, IOleUndoManager*, int> Do;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleUndoUnit*, ushort**, int> GetDescription;

            [NativeTypeName("HRESULT (CLSID *, LONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IOleUndoUnit*, Guid*, int*, int> GetUnitType;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IOleUndoUnit*, int> OnNextAdd;
        }
    }
}
