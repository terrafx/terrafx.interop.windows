// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.620.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D12DeviceDumpFile.xml' path='doc/member[@name="ID3D12DeviceDumpFile"]/*' />
[Guid("DB82BFED-784D-40EA-AEBF-08BCD7F0A9E4")]
[NativeTypeName("struct ID3D12DeviceDumpFile : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DeviceDumpFile : ID3D12DeviceDumpFile.Interface, INativeGuid
{
    /// <include file='ID3D12DeviceDumpFile.xml' path='doc/member[@name="ID3D12DeviceDumpFile.INativeGuid.NativeGuid"]/*' />
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ID3D12DeviceDumpFile);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DeviceDumpFile*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DeviceDumpFile*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DeviceDumpFile*, uint>)(lpVtbl[1]))((ID3D12DeviceDumpFile*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DeviceDumpFile*, uint>)(lpVtbl[2]))((ID3D12DeviceDumpFile*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID3D12DeviceDumpFile.xml' path='doc/member[@name="ID3D12DeviceDumpFile.ConfigureDumpFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ConfigureDumpFile(D3D12_DUMP_FILE_DRIVER_OPTIONS driverOptions)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DeviceDumpFile*, D3D12_DUMP_FILE_DRIVER_OPTIONS, int>)(lpVtbl[3]))((ID3D12DeviceDumpFile*)Unsafe.AsPointer(ref this), driverOptions);
    }

    /// <include file='ID3D12DeviceDumpFile.xml' path='doc/member[@name="ID3D12DeviceDumpFile.SetDumpFileCallbacks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void SetDumpFileCallbacks([NativeTypeName("D3D12_DUMPFILEBEGINCALLBACK")] delegate* unmanaged<ulong, uint> pBeginCallback, [NativeTypeName("D3D12_DUMPFILEENDCALLBACK")] delegate* unmanaged<char*, void> pEndCallback)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12DeviceDumpFile*, delegate* unmanaged<ulong, uint>, delegate* unmanaged<char*, void>, void>)(lpVtbl[4]))((ID3D12DeviceDumpFile*)Unsafe.AsPointer(ref this), pBeginCallback, pEndCallback);
    }

    /// <include file='ID3D12DeviceDumpFile.xml' path='doc/member[@name="ID3D12DeviceDumpFile.AddBlobToDumpFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddBlobToDumpFile(void* pBlob, uint sizeBytes, [NativeTypeName("UINT64")] ulong metadata)
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DeviceDumpFile*, void*, uint, ulong, int>)(lpVtbl[5]))((ID3D12DeviceDumpFile*)Unsafe.AsPointer(ref this), pBlob, sizeBytes, metadata);
    }

    /// <include file='ID3D12DeviceDumpFile.xml' path='doc/member[@name="ID3D12DeviceDumpFile.RetainDumpFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void RetainDumpFile(BOOL retain)
    {
        ((delegate* unmanaged[MemberFunction]<ID3D12DeviceDumpFile*, BOOL, void>)(lpVtbl[6]))((ID3D12DeviceDumpFile*)Unsafe.AsPointer(ref this), retain);
    }

    /// <include file='ID3D12DeviceDumpFile.xml' path='doc/member[@name="ID3D12DeviceDumpFile.GetDeviceErrorCode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public D3D12_DEVICE_ERROR_CODE GetDeviceErrorCode()
    {
        return ((delegate* unmanaged[MemberFunction]<ID3D12DeviceDumpFile*, D3D12_DEVICE_ERROR_CODE>)(lpVtbl[7]))((ID3D12DeviceDumpFile*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ConfigureDumpFile(D3D12_DUMP_FILE_DRIVER_OPTIONS driverOptions);

        [VtblIndex(5)]
        HRESULT AddBlobToDumpFile(void* pBlob, uint sizeBytes, [NativeTypeName("UINT64")] ulong metadata);

        [VtblIndex(6)]
        void RetainDumpFile(BOOL retain);

        [VtblIndex(7)]
        D3D12_DEVICE_ERROR_CODE GetDeviceErrorCode();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (D3D12_DUMP_FILE_DRIVER_OPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_DUMP_FILE_DRIVER_OPTIONS, int> ConfigureDumpFile;

        [NativeTypeName("void (D3D12_DUMPFILEBEGINCALLBACK, D3D12_DUMPFILEENDCALLBACK) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, delegate* unmanaged<ulong, uint>, delegate* unmanaged<char*, void>, void> SetDumpFileCallbacks;

        [NativeTypeName("HRESULT (void *, UINT, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, ulong, int> AddBlobToDumpFile;

        [NativeTypeName("void (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, void> RetainDumpFile;

        [NativeTypeName("D3D12_DEVICE_ERROR_CODE () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, D3D12_DEVICE_ERROR_CODE> GetDeviceErrorCode;
    }
}
