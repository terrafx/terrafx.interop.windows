// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("D7644B2C-1537-4767-B62F-F1387B02DDFD")]
    [NativeTypeName("struct IFileSystemImage2 : IFileSystemImage")]
    [NativeInheritance("IFileSystemImage")]
    public unsafe partial struct IFileSystemImage2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, Guid*, void**, int>)(lpVtbl[0]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileSystemImage2*, uint>)(lpVtbl[1]))((IFileSystemImage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileSystemImage2*, uint>)(lpVtbl[2]))((IFileSystemImage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, uint*, int>)(lpVtbl[3]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int get_Root(IFsiDirectoryItem** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, IFsiDirectoryItem**, int>)(lpVtbl[7]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int get_SessionStartBlock([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, int*, int>)(lpVtbl[8]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int put_SessionStartBlock([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, int, int>)(lpVtbl[9]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int get_FreeMediaBlocks([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, int*, int>)(lpVtbl[10]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int put_FreeMediaBlocks([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, int, int>)(lpVtbl[11]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaxMediaBlocksFromDevice(IDiscRecorder2* discRecorder)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, IDiscRecorder2*, int>)(lpVtbl[12]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), discRecorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int get_UsedBlocks([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, int*, int>)(lpVtbl[13]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int get_VolumeName([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, ushort**, int>)(lpVtbl[14]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int put_VolumeName([NativeTypeName("BSTR")] ushort* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, ushort*, int>)(lpVtbl[15]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int get_ImportedVolumeName([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, ushort**, int>)(lpVtbl[16]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int get_BootImageOptions(IBootOptions** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, IBootOptions**, int>)(lpVtbl[17]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int put_BootImageOptions(IBootOptions* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, IBootOptions*, int>)(lpVtbl[18]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int get_FileCount([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, int*, int>)(lpVtbl[19]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int get_DirectoryCount([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, int*, int>)(lpVtbl[20]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(21)]
        [return: NativeTypeName("HRESULT")]
        public int get_WorkingDirectory([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, ushort**, int>)(lpVtbl[21]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(22)]
        [return: NativeTypeName("HRESULT")]
        public int put_WorkingDirectory([NativeTypeName("BSTR")] ushort* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, ushort*, int>)(lpVtbl[22]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(23)]
        [return: NativeTypeName("HRESULT")]
        public int get_ChangePoint([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, int*, int>)(lpVtbl[23]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(24)]
        [return: NativeTypeName("HRESULT")]
        public int get_StrictFileSystemCompliance([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, short*, int>)(lpVtbl[24]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(25)]
        [return: NativeTypeName("HRESULT")]
        public int put_StrictFileSystemCompliance([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, short, int>)(lpVtbl[25]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(26)]
        [return: NativeTypeName("HRESULT")]
        public int get_UseRestrictedCharacterSet([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, short*, int>)(lpVtbl[26]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(27)]
        [return: NativeTypeName("HRESULT")]
        public int put_UseRestrictedCharacterSet([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, short, int>)(lpVtbl[27]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(28)]
        [return: NativeTypeName("HRESULT")]
        public int get_FileSystemsToCreate(FsiFileSystems* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, FsiFileSystems*, int>)(lpVtbl[28]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(29)]
        [return: NativeTypeName("HRESULT")]
        public int put_FileSystemsToCreate(FsiFileSystems newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, FsiFileSystems, int>)(lpVtbl[29]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(30)]
        [return: NativeTypeName("HRESULT")]
        public int get_FileSystemsSupported(FsiFileSystems* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, FsiFileSystems*, int>)(lpVtbl[30]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(31)]
        [return: NativeTypeName("HRESULT")]
        public int put_UDFRevision([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, int, int>)(lpVtbl[31]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(32)]
        [return: NativeTypeName("HRESULT")]
        public int get_UDFRevision([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, int*, int>)(lpVtbl[32]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(33)]
        [return: NativeTypeName("HRESULT")]
        public int get_UDFRevisionsSupported(SAFEARRAY** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, SAFEARRAY**, int>)(lpVtbl[33]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(34)]
        [return: NativeTypeName("HRESULT")]
        public int ChooseImageDefaults(IDiscRecorder2* discRecorder)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, IDiscRecorder2*, int>)(lpVtbl[34]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), discRecorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(35)]
        [return: NativeTypeName("HRESULT")]
        public int ChooseImageDefaultsForMediaType(IMAPI_MEDIA_PHYSICAL_TYPE value)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, IMAPI_MEDIA_PHYSICAL_TYPE, int>)(lpVtbl[35]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(36)]
        [return: NativeTypeName("HRESULT")]
        public int put_ISO9660InterchangeLevel([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, int, int>)(lpVtbl[36]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(37)]
        [return: NativeTypeName("HRESULT")]
        public int get_ISO9660InterchangeLevel([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, int*, int>)(lpVtbl[37]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(38)]
        [return: NativeTypeName("HRESULT")]
        public int get_ISO9660InterchangeLevelsSupported(SAFEARRAY** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, SAFEARRAY**, int>)(lpVtbl[38]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(39)]
        [return: NativeTypeName("HRESULT")]
        public int CreateResultImage(IFileSystemImageResult** resultStream)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, IFileSystemImageResult**, int>)(lpVtbl[39]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), resultStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(40)]
        [return: NativeTypeName("HRESULT")]
        public int Exists([NativeTypeName("BSTR")] ushort* fullPath, FsiItemType* itemType)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, ushort*, FsiItemType*, int>)(lpVtbl[40]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), fullPath, itemType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(41)]
        [return: NativeTypeName("HRESULT")]
        public int CalculateDiscIdentifier([NativeTypeName("BSTR *")] ushort** discIdentifier)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, ushort**, int>)(lpVtbl[41]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), discIdentifier);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(42)]
        [return: NativeTypeName("HRESULT")]
        public int IdentifyFileSystemsOnDisc(IDiscRecorder2* discRecorder, FsiFileSystems* fileSystems)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, IDiscRecorder2*, FsiFileSystems*, int>)(lpVtbl[42]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), discRecorder, fileSystems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(43)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultFileSystemForImport(FsiFileSystems fileSystems, FsiFileSystems* importDefault)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, FsiFileSystems, FsiFileSystems*, int>)(lpVtbl[43]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), fileSystems, importDefault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(44)]
        [return: NativeTypeName("HRESULT")]
        public int ImportFileSystem(FsiFileSystems* importedFileSystem)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, FsiFileSystems*, int>)(lpVtbl[44]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), importedFileSystem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(45)]
        [return: NativeTypeName("HRESULT")]
        public int ImportSpecificFileSystem(FsiFileSystems fileSystemToUse)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, FsiFileSystems, int>)(lpVtbl[45]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), fileSystemToUse);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(46)]
        [return: NativeTypeName("HRESULT")]
        public int RollbackToChangePoint([NativeTypeName("LONG")] int changePoint)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, int, int>)(lpVtbl[46]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), changePoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(47)]
        [return: NativeTypeName("HRESULT")]
        public int LockInChangePoint()
        {
            return ((delegate* unmanaged<IFileSystemImage2*, int>)(lpVtbl[47]))((IFileSystemImage2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(48)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDirectoryItem([NativeTypeName("BSTR")] ushort* name, IFsiDirectoryItem** newItem)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, ushort*, IFsiDirectoryItem**, int>)(lpVtbl[48]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), name, newItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(49)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFileItem([NativeTypeName("BSTR")] ushort* name, IFsiFileItem** newItem)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, ushort*, IFsiFileItem**, int>)(lpVtbl[49]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), name, newItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(50)]
        [return: NativeTypeName("HRESULT")]
        public int get_VolumeNameUDF([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, ushort**, int>)(lpVtbl[50]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(51)]
        [return: NativeTypeName("HRESULT")]
        public int get_VolumeNameJoliet([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, ushort**, int>)(lpVtbl[51]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(52)]
        [return: NativeTypeName("HRESULT")]
        public int get_VolumeNameISO9660([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, ushort**, int>)(lpVtbl[52]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(53)]
        [return: NativeTypeName("HRESULT")]
        public int get_StageFiles([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, short*, int>)(lpVtbl[53]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(54)]
        [return: NativeTypeName("HRESULT")]
        public int put_StageFiles([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, short, int>)(lpVtbl[54]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(55)]
        [return: NativeTypeName("HRESULT")]
        public int get_MultisessionInterfaces(SAFEARRAY** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, SAFEARRAY**, int>)(lpVtbl[55]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(56)]
        [return: NativeTypeName("HRESULT")]
        public int put_MultisessionInterfaces(SAFEARRAY* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, SAFEARRAY*, int>)(lpVtbl[56]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(57)]
        [return: NativeTypeName("HRESULT")]
        public int get_BootImageOptionsArray(SAFEARRAY** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, SAFEARRAY**, int>)(lpVtbl[57]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(58)]
        [return: NativeTypeName("HRESULT")]
        public int put_BootImageOptionsArray(SAFEARRAY* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage2*, SAFEARRAY*, int>)(lpVtbl[58]))((IFileSystemImage2*)Unsafe.AsPointer(ref this), newVal);
        }
    }
}
