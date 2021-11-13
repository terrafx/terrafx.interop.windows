// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;
using static TerraFX.Interop.Windows.NSTCSTYLE2;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHAddDefaultPropertiesByExt([NativeTypeName("PCWSTR")] ushort* pszExt, IPropertyStore* pPropStore);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHCreateDefaultPropertiesOp(IShellItem* psi, IFileOperation** ppFileOp);

        [DllImport("shell32", ExactSpelling = true)]
        public static extern HRESULT SHSetDefaultProperties(HWND hwnd, IShellItem* psi, [NativeTypeName("DWORD")] uint dwFileOpFlags, IFileOperationProgressSink* pfops);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid SID_SCommandBarState
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5C, 0xAA, 0x9E, 0xB9,
                    0x50, 0x38,
                    0x00, 0x44,
                    0xBC,
                    0x33,
                    0x2C,
                    0xE5,
                    0x34,
                    0x04,
                    0x8B,
                    0xF8
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define IDD_WIZEXTN_FIRST 0x5000")]
        public const int IDD_WIZEXTN_FIRST = 0x5000;

        [NativeTypeName("#define IDD_WIZEXTN_LAST 0x5100")]
        public const int IDD_WIZEXTN_LAST = 0x5100;

        [NativeTypeName("#define SID_WizardSite IID_IWizardSite")]
        public static ref readonly Guid SID_WizardSite => ref IID_IWizardSite;

        [NativeTypeName("#define SID_WebWizardHost IID_IWebWizardExtension")]
        public static ref readonly Guid SID_WebWizardHost => ref IID_IWebWizardExtension;

        [NativeTypeName("#define SHPWHF_NORECOMPRESS 0x00000001")]
        public const int SHPWHF_NORECOMPRESS = 0x00000001;

        [NativeTypeName("#define SHPWHF_NONETPLACECREATE 0x00000002")]
        public const int SHPWHF_NONETPLACECREATE = 0x00000002;

        [NativeTypeName("#define SHPWHF_NOFILESELECTOR 0x00000004")]
        public const int SHPWHF_NOFILESELECTOR = 0x00000004;

        [NativeTypeName("#define SHPWHF_USEMRU 0x00000008")]
        public const int SHPWHF_USEMRU = 0x00000008;

        [NativeTypeName("#define SHPWHF_ANYLOCATION 0x00000100")]
        public const int SHPWHF_ANYLOCATION = 0x00000100;

        [NativeTypeName("#define SHPWHF_VALIDATEVIAWEBFOLDERS 0x00010000")]
        public const int SHPWHF_VALIDATEVIAWEBFOLDERS = 0x00010000;

        [NativeTypeName("#define ACDD_VISIBLE 0x0001")]
        public const int ACDD_VISIBLE = 0x0001;

        [NativeTypeName("#define PROPSTR_EXTENSIONCOMPLETIONSTATE L\"ExtensionCompletionState\"")]
        public const string PROPSTR_EXTENSIONCOMPLETIONSTATE = "ExtensionCompletionState";

        [NativeTypeName("#define SID_CDWizardHost IID_ICDBurnExt")]
        public static ref readonly Guid SID_CDWizardHost => ref IID_ICDBurnExt;

        [NativeTypeName("#define SID_EnumerableView IID_IEnumerableView")]
        public static ref readonly Guid SID_EnumerableView => ref IID_IEnumerableView;

        [NativeTypeName("#define NSTCS2_ALLMASK (NSTCS2_INTERRUPTNOTIFICATIONS | NSTCS2_SHOWNULLSPACEMENU | NSTCS2_DISPLAYPADDING)")]
        public const NSTCSTYLE2 NSTCS2_ALLMASK = (NSTCS2_INTERRUPTNOTIFICATIONS | NSTCS2_SHOWNULLSPACEMENU | NSTCS2_DISPLAYPADDING);

        [NativeTypeName("#define NSTCDHPOS_ONTOP -1")]
        public const int NSTCDHPOS_ONTOP = -1;

        [NativeTypeName("#define SID_SBandHost IID_IBandHost")]
        public static ref readonly Guid SID_SBandHost => ref IID_IBandHost;

        [NativeTypeName("#define SID_PublishingWizard CLSID_PublishingWizard")]
        public static ref readonly Guid SID_PublishingWizard => ref CLSID_PublishingWizard;
    }
}
