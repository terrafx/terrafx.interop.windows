// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D001F200-EF97-11CE-9BC9-00AA00608E01")]
    [NativeTypeName("struct IOleUndoManager : IUnknown")]
    public unsafe partial struct IOleUndoManager
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IOleUndoManager*, Guid*, void**, int>)(lpVtbl[0]))((IOleUndoManager*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IOleUndoManager*, uint>)(lpVtbl[1]))((IOleUndoManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IOleUndoManager*, uint>)(lpVtbl[2]))((IOleUndoManager*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Open(IOleParentUndoUnit* pPUU)
        {
            return ((delegate* unmanaged<IOleUndoManager*, IOleParentUndoUnit*, int>)(lpVtbl[3]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pPUU);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close(IOleParentUndoUnit* pPUU, [NativeTypeName("BOOL")] int fCommit)
        {
            return ((delegate* unmanaged<IOleUndoManager*, IOleParentUndoUnit*, int, int>)(lpVtbl[4]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pPUU, fCommit);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Add(IOleUndoUnit* pUU)
        {
            return ((delegate* unmanaged<IOleUndoManager*, IOleUndoUnit*, int>)(lpVtbl[5]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetOpenParentState([NativeTypeName("DWORD *")] uint* pdwState)
        {
            return ((delegate* unmanaged<IOleUndoManager*, uint*, int>)(lpVtbl[6]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pdwState);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DiscardFrom(IOleUndoUnit* pUU)
        {
            return ((delegate* unmanaged<IOleUndoManager*, IOleUndoUnit*, int>)(lpVtbl[7]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int UndoTo(IOleUndoUnit* pUU)
        {
            return ((delegate* unmanaged<IOleUndoManager*, IOleUndoUnit*, int>)(lpVtbl[8]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RedoTo(IOleUndoUnit* pUU)
        {
            return ((delegate* unmanaged<IOleUndoManager*, IOleUndoUnit*, int>)(lpVtbl[9]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pUU);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumUndoable(IEnumOleUndoUnits** ppEnum)
        {
            return ((delegate* unmanaged<IOleUndoManager*, IEnumOleUndoUnits**, int>)(lpVtbl[10]))((IOleUndoManager*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EnumRedoable(IEnumOleUndoUnits** ppEnum)
        {
            return ((delegate* unmanaged<IOleUndoManager*, IEnumOleUndoUnits**, int>)(lpVtbl[11]))((IOleUndoManager*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLastUndoDescription([NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return ((delegate* unmanaged<IOleUndoManager*, ushort**, int>)(lpVtbl[12]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pBstr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetLastRedoDescription([NativeTypeName("BSTR *")] ushort** pBstr)
        {
            return ((delegate* unmanaged<IOleUndoManager*, ushort**, int>)(lpVtbl[13]))((IOleUndoManager*)Unsafe.AsPointer(ref this), pBstr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Enable([NativeTypeName("BOOL")] int fEnable)
        {
            return ((delegate* unmanaged<IOleUndoManager*, int, int>)(lpVtbl[14]))((IOleUndoManager*)Unsafe.AsPointer(ref this), fEnable);
        }
    }
}
