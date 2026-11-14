// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.28000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static partial class GP
{
    /// <include file='GP.xml' path='doc/member[@name="GP.GP_DLLNAME"]/*' />
    [NativeTypeName("#define GP_DLLNAME TEXT(\"DllName\")")]
    public const string GP_DLLNAME = "DllName";

    /// <include file='GP.xml' path='doc/member[@name="GP.GP_ENABLEASYNCHRONOUSPROCESSING"]/*' />
    [NativeTypeName("#define GP_ENABLEASYNCHRONOUSPROCESSING TEXT(\"EnableAsynchronousProcessing\")")]
    public const string GP_ENABLEASYNCHRONOUSPROCESSING = "EnableAsynchronousProcessing";

    /// <include file='GP.xml' path='doc/member[@name="GP.GP_MAXNOGPOLISTCHANGESINTERVAL"]/*' />
    [NativeTypeName("#define GP_MAXNOGPOLISTCHANGESINTERVAL TEXT(\"MaxNoGPOListChangesInterval\")")]
    public const string GP_MAXNOGPOLISTCHANGESINTERVAL = "MaxNoGPOListChangesInterval";

    /// <include file='GP.xml' path='doc/member[@name="GP.GP_NOBACKGROUNDPOLICY"]/*' />
    [NativeTypeName("#define GP_NOBACKGROUNDPOLICY TEXT(\"NoBackgroundPolicy\")")]
    public const string GP_NOBACKGROUNDPOLICY = "NoBackgroundPolicy";

    /// <include file='GP.xml' path='doc/member[@name="GP.GP_NOGPOLISTCHANGES"]/*' />
    [NativeTypeName("#define GP_NOGPOLISTCHANGES TEXT(\"NoGPOListChanges\")")]
    public const string GP_NOGPOLISTCHANGES = "NoGPOListChanges";

    /// <include file='GP.xml' path='doc/member[@name="GP.GP_NOMACHINEPOLICY"]/*' />
    [NativeTypeName("#define GP_NOMACHINEPOLICY TEXT(\"NoMachinePolicy\")")]
    public const string GP_NOMACHINEPOLICY = "NoMachinePolicy";

    /// <include file='GP.xml' path='doc/member[@name="GP.GP_NOSLOWLINK"]/*' />
    [NativeTypeName("#define GP_NOSLOWLINK TEXT(\"NoSlowLink\")")]
    public const string GP_NOSLOWLINK = "NoSlowLink";

    /// <include file='GP.xml' path='doc/member[@name="GP.GP_NOTIFYLINKTRANSITION"]/*' />
    [NativeTypeName("#define GP_NOTIFYLINKTRANSITION TEXT(\"NotifyLinkTransition\")")]
    public const string GP_NOTIFYLINKTRANSITION = "NotifyLinkTransition";

    /// <include file='GP.xml' path='doc/member[@name="GP.GP_NOUSERPOLICY"]/*' />
    [NativeTypeName("#define GP_NOUSERPOLICY TEXT(\"NoUserPolicy\")")]
    public const string GP_NOUSERPOLICY = "NoUserPolicy";

    /// <include file='GP.xml' path='doc/member[@name="GP.GP_PERUSERLOCALSETTINGS"]/*' />
    [NativeTypeName("#define GP_PERUSERLOCALSETTINGS TEXT(\"PerUserLocalSettings\")")]
    public const string GP_PERUSERLOCALSETTINGS = "PerUserLocalSettings";

    /// <include file='GP.xml' path='doc/member[@name="GP.GP_PROCESSGROUPPOLICY"]/*' />
    [NativeTypeName("#define GP_PROCESSGROUPPOLICY TEXT(\"ProcessGroupPolicy\")")]
    public const string GP_PROCESSGROUPPOLICY = "ProcessGroupPolicy";

    /// <include file='GP.xml' path='doc/member[@name="GP.GP_REQUIRESSUCCESSFULREGISTRY"]/*' />
    [NativeTypeName("#define GP_REQUIRESSUCCESSFULREGISTRY TEXT(\"RequiresSuccessfulRegistry\")")]
    public const string GP_REQUIRESSUCCESSFULREGISTRY = "RequiresSuccessfulRegistry";
}
