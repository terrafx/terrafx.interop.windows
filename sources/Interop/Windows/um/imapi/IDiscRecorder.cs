// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("85AC9776-CA88-4CF2-894E-09598C078A41")]
    [NativeTypeName("struct IDiscRecorder : IUnknown")]
    public unsafe partial struct IDiscRecorder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDiscRecorder*, Guid*, void**, int>)(lpVtbl[0]))((IDiscRecorder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDiscRecorder*, uint>)(lpVtbl[1]))((IDiscRecorder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDiscRecorder*, uint>)(lpVtbl[2]))((IDiscRecorder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Init([NativeTypeName("byte *")] byte* pbyUniqueID, [NativeTypeName("ULONG")] uint nulIDSize, [NativeTypeName("ULONG")] uint nulDriveNumber)
        {
            return ((delegate* unmanaged<IDiscRecorder*, byte*, uint, uint, int>)(lpVtbl[3]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pbyUniqueID, nulIDSize, nulDriveNumber);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecorderGUID([NativeTypeName("byte *")] byte* pbyUniqueID, [NativeTypeName("ULONG")] uint ulBufferSize, [NativeTypeName("ULONG *")] uint* pulReturnSizeRequired)
        {
            return ((delegate* unmanaged<IDiscRecorder*, byte*, uint, uint*, int>)(lpVtbl[4]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pbyUniqueID, ulBufferSize, pulReturnSizeRequired);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecorderType([NativeTypeName("long *")] int* fTypeCode)
        {
            return ((delegate* unmanaged<IDiscRecorder*, int*, int>)(lpVtbl[5]))((IDiscRecorder*)Unsafe.AsPointer(ref this), fTypeCode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDisplayNames([NativeTypeName("BSTR *")] ushort** pbstrVendorID, [NativeTypeName("BSTR *")] ushort** pbstrProductID, [NativeTypeName("BSTR *")] ushort** pbstrRevision)
        {
            return ((delegate* unmanaged<IDiscRecorder*, ushort**, ushort**, ushort**, int>)(lpVtbl[6]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pbstrVendorID, pbstrProductID, pbstrRevision);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetBasePnPID([NativeTypeName("BSTR *")] ushort** pbstrBasePnPID)
        {
            return ((delegate* unmanaged<IDiscRecorder*, ushort**, int>)(lpVtbl[7]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pbstrBasePnPID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPath([NativeTypeName("BSTR *")] ushort** pbstrPath)
        {
            return ((delegate* unmanaged<IDiscRecorder*, ushort**, int>)(lpVtbl[8]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pbstrPath);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecorderProperties([NativeTypeName("IPropertyStorage **")] IPropertyStorage** ppPropStg)
        {
            return ((delegate* unmanaged<IDiscRecorder*, IPropertyStorage**, int>)(lpVtbl[9]))((IDiscRecorder*)Unsafe.AsPointer(ref this), ppPropStg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetRecorderProperties([NativeTypeName("IPropertyStorage *")] IPropertyStorage* pPropStg)
        {
            return ((delegate* unmanaged<IDiscRecorder*, IPropertyStorage*, int>)(lpVtbl[10]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pPropStg);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetRecorderState([NativeTypeName("ULONG *")] uint* pulDevStateFlags)
        {
            return ((delegate* unmanaged<IDiscRecorder*, uint*, int>)(lpVtbl[11]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pulDevStateFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int OpenExclusive()
        {
            return ((delegate* unmanaged<IDiscRecorder*, int>)(lpVtbl[12]))((IDiscRecorder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryMediaType([NativeTypeName("long *")] int* fMediaType, [NativeTypeName("long *")] int* fMediaFlags)
        {
            return ((delegate* unmanaged<IDiscRecorder*, int*, int*, int>)(lpVtbl[13]))((IDiscRecorder*)Unsafe.AsPointer(ref this), fMediaType, fMediaFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryMediaInfo([NativeTypeName("byte *")] byte* pbSessions, [NativeTypeName("byte *")] byte* pbLastTrack, [NativeTypeName("ULONG *")] uint* ulStartAddress, [NativeTypeName("ULONG *")] uint* ulNextWritable, [NativeTypeName("ULONG *")] uint* ulFreeBlocks)
        {
            return ((delegate* unmanaged<IDiscRecorder*, byte*, byte*, uint*, uint*, uint*, int>)(lpVtbl[14]))((IDiscRecorder*)Unsafe.AsPointer(ref this), pbSessions, pbLastTrack, ulStartAddress, ulNextWritable, ulFreeBlocks);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Eject()
        {
            return ((delegate* unmanaged<IDiscRecorder*, int>)(lpVtbl[15]))((IDiscRecorder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Erase([NativeTypeName("boolean")] byte bFullErase)
        {
            return ((delegate* unmanaged<IDiscRecorder*, byte, int>)(lpVtbl[16]))((IDiscRecorder*)Unsafe.AsPointer(ref this), bFullErase);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged<IDiscRecorder*, int>)(lpVtbl[17]))((IDiscRecorder*)Unsafe.AsPointer(ref this));
        }
    }
}
