// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("894AD3B0-EF97-11CE-9BC9-00AA00608E01")]
    [NativeTypeName("struct IOleUndoUnit : IUnknown")]
    public unsafe partial struct IOleUndoUnit
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleUndoUnit*, Guid*, void**, int>)(lpVtbl[0]))((IOleUndoUnit*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleUndoUnit*, uint>)(lpVtbl[1]))((IOleUndoUnit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleUndoUnit*, uint>)(lpVtbl[2]))((IOleUndoUnit*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Do(IOleUndoManager* pUndoManager)
        {
            return ((delegate* unmanaged<IOleUndoUnit*, IOleUndoManager*, int>)(lpVtbl[3]))((IOleUndoUnit*)Unsafe.AsPointer(ref this), pUndoManager);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return ((delegate* unmanaged<IOleUndoUnit*, ushort**, int>)(lpVtbl[4]))((IOleUndoUnit*)Unsafe.AsPointer(ref this), pBstr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetUnitType([NativeTypeName("CLSID *")] Guid* pClsid, [NativeTypeName("LONG *")] int* plID)
        {
            return ((delegate* unmanaged<IOleUndoUnit*, Guid*, int*, int>)(lpVtbl[5]))((IOleUndoUnit*)Unsafe.AsPointer(ref this), pClsid, plID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OnNextAdd()
        {
            return ((delegate* unmanaged<IOleUndoUnit*, int>)(lpVtbl[6]))((IOleUndoUnit*)Unsafe.AsPointer(ref this));
        }
    }
}
