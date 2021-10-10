// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("520CCA62-51A5-11D3-9144-00104BA11C5E")]
    [NativeTypeName("struct IDiscMaster : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IDiscMaster
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDiscMaster*, Guid*, void**, int>)(lpVtbl[0]))((IDiscMaster*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiscMaster*, uint>)(lpVtbl[1]))((IDiscMaster*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiscMaster*, uint>)(lpVtbl[2]))((IDiscMaster*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Open()
        {
            return ((delegate* unmanaged<IDiscMaster*, int>)(lpVtbl[3]))((IDiscMaster*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int EnumDiscMasterFormats(IEnumDiscMasterFormats** ppEnum)
        {
            return ((delegate* unmanaged<IDiscMaster*, IEnumDiscMasterFormats**, int>)(lpVtbl[4]))((IDiscMaster*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetActiveDiscMasterFormat([NativeTypeName("LPIID")] Guid* lpiid)
        {
            return ((delegate* unmanaged<IDiscMaster*, Guid*, int>)(lpVtbl[5]))((IDiscMaster*)Unsafe.AsPointer(ref this), lpiid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int SetActiveDiscMasterFormat([NativeTypeName("const IID &")] Guid* riid, void** ppUnk)
        {
            return ((delegate* unmanaged<IDiscMaster*, Guid*, void**, int>)(lpVtbl[6]))((IDiscMaster*)Unsafe.AsPointer(ref this), riid, ppUnk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int EnumDiscRecorders(IEnumDiscRecorders** ppEnum)
        {
            return ((delegate* unmanaged<IDiscMaster*, IEnumDiscRecorders**, int>)(lpVtbl[7]))((IDiscMaster*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetActiveDiscRecorder(IDiscRecorder** ppRecorder)
        {
            return ((delegate* unmanaged<IDiscMaster*, IDiscRecorder**, int>)(lpVtbl[8]))((IDiscMaster*)Unsafe.AsPointer(ref this), ppRecorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int SetActiveDiscRecorder(IDiscRecorder* pRecorder)
        {
            return ((delegate* unmanaged<IDiscMaster*, IDiscRecorder*, int>)(lpVtbl[9]))((IDiscMaster*)Unsafe.AsPointer(ref this), pRecorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int ClearFormatContent()
        {
            return ((delegate* unmanaged<IDiscMaster*, int>)(lpVtbl[10]))((IDiscMaster*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int ProgressAdvise(IDiscMasterProgressEvents* pEvents, [NativeTypeName("UINT_PTR *")] nuint* pvCookie)
        {
            return ((delegate* unmanaged<IDiscMaster*, IDiscMasterProgressEvents*, nuint*, int>)(lpVtbl[11]))((IDiscMaster*)Unsafe.AsPointer(ref this), pEvents, pvCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int ProgressUnadvise([NativeTypeName("UINT_PTR")] nuint vCookie)
        {
            return ((delegate* unmanaged<IDiscMaster*, nuint, int>)(lpVtbl[12]))((IDiscMaster*)Unsafe.AsPointer(ref this), vCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int RecordDisc([NativeTypeName("boolean")] byte bSimulate, [NativeTypeName("boolean")] byte bEjectAfterBurn)
        {
            return ((delegate* unmanaged<IDiscMaster*, byte, byte, int>)(lpVtbl[13]))((IDiscMaster*)Unsafe.AsPointer(ref this), bSimulate, bEjectAfterBurn);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged<IDiscMaster*, int>)(lpVtbl[14]))((IDiscMaster*)Unsafe.AsPointer(ref this));
        }
    }
}
