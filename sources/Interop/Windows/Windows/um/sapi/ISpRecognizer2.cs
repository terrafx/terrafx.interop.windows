// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("8FC6D974-C81E-4098-93C5-0147F61ED4D3")]
[NativeTypeName("struct ISpRecognizer2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpRecognizer2 : ISpRecognizer2.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpRecognizer2*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecognizer2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpRecognizer2*, uint>)(lpVtbl[1]))((ISpRecognizer2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpRecognizer2*, uint>)(lpVtbl[2]))((ISpRecognizer2*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EmulateRecognitionEx(ISpPhrase* pPhrase, [NativeTypeName("DWORD")] uint dwCompareFlags)
    {
        return ((delegate* unmanaged<ISpRecognizer2*, ISpPhrase*, uint, int>)(lpVtbl[3]))((ISpRecognizer2*)Unsafe.AsPointer(ref this), pPhrase, dwCompareFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTrainingState(BOOL fDoingTraining, BOOL fAdaptFromTrainingData)
    {
        return ((delegate* unmanaged<ISpRecognizer2*, BOOL, BOOL, int>)(lpVtbl[4]))((ISpRecognizer2*)Unsafe.AsPointer(ref this), fDoingTraining, fAdaptFromTrainingData);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ResetAcousticModelAdaptation()
    {
        return ((delegate* unmanaged<ISpRecognizer2*, int>)(lpVtbl[5]))((ISpRecognizer2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EmulateRecognitionEx(ISpPhrase* pPhrase, [NativeTypeName("DWORD")] uint dwCompareFlags);

        [VtblIndex(4)]
        HRESULT SetTrainingState(BOOL fDoingTraining, BOOL fAdaptFromTrainingData);

        [VtblIndex(5)]
        HRESULT ResetAcousticModelAdaptation();
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpRecognizer2*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpRecognizer2*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpRecognizer2*, uint> Release;

        [NativeTypeName("HRESULT (ISpPhrase *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpRecognizer2*, ISpPhrase*, uint, int> EmulateRecognitionEx;

        [NativeTypeName("HRESULT (BOOL, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<ISpRecognizer2*, BOOL, BOOL, int> SetTrainingState;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<ISpRecognizer2*, int> ResetAcousticModelAdaptation;
    }
}
