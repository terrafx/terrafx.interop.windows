// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    public static partial class Windows
    {
        [NativeTypeName("#define IMAPI_SECTOR_SIZE ( 2048 )")]
        public const int IMAPI_SECTOR_SIZE = (2048);

        [NativeTypeName("#define IMAPI2_DEFAULT_COMMAND_TIMEOUT 10")]
        public const int IMAPI2_DEFAULT_COMMAND_TIMEOUT = 10;

        [NativeTypeName("#define DISPID_DDISCMASTER2EVENTS_DEVICEADDED 0x100")]
        public const int DISPID_DDISCMASTER2EVENTS_DEVICEADDED = 0x100;

        [NativeTypeName("#define DISPID_DDISCMASTER2EVENTS_DEVICEREMOVED 0x101")]
        public const int DISPID_DDISCMASTER2EVENTS_DEVICEREMOVED = 0x101;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_EJECTMEDIA 0x100")]
        public const int DISPID_IDISCRECORDER2_EJECTMEDIA = 0x100;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_CLOSETRAY 0x101")]
        public const int DISPID_IDISCRECORDER2_CLOSETRAY = 0x101;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_ACQUIREEXCLUSIVEACCESS 0x102")]
        public const int DISPID_IDISCRECORDER2_ACQUIREEXCLUSIVEACCESS = 0x102;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_RELEASEEXCLUSIVEACCESS 0x103")]
        public const int DISPID_IDISCRECORDER2_RELEASEEXCLUSIVEACCESS = 0x103;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_DISABLEMCN 0x104")]
        public const int DISPID_IDISCRECORDER2_DISABLEMCN = 0x104;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_ENABLEMCN 0x105")]
        public const int DISPID_IDISCRECORDER2_ENABLEMCN = 0x105;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_INITIALIZEDISCRECORDER 0x106")]
        public const int DISPID_IDISCRECORDER2_INITIALIZEDISCRECORDER = 0x106;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_ACTIVEDISCRECORDER DISPID_VALUE")]
        public const int DISPID_IDISCRECORDER2_ACTIVEDISCRECORDER = (0);

        [NativeTypeName("#define DISPID_IDISCRECORDER2_VENDORID 0x201")]
        public const int DISPID_IDISCRECORDER2_VENDORID = 0x201;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_PRODUCTID 0x202")]
        public const int DISPID_IDISCRECORDER2_PRODUCTID = 0x202;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_PRODUCTREVISION 0x203")]
        public const int DISPID_IDISCRECORDER2_PRODUCTREVISION = 0x203;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_VOLUMENAME 0x204")]
        public const int DISPID_IDISCRECORDER2_VOLUMENAME = 0x204;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_VOLUMEPATHNAMES 0x205")]
        public const int DISPID_IDISCRECORDER2_VOLUMEPATHNAMES = 0x205;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_DEVICECANLOADMEDIA 0x206")]
        public const int DISPID_IDISCRECORDER2_DEVICECANLOADMEDIA = 0x206;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_LEGACYDEVICENUMBER 0x207")]
        public const int DISPID_IDISCRECORDER2_LEGACYDEVICENUMBER = 0x207;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_SUPPORTEDFEATUREPAGES 0x208")]
        public const int DISPID_IDISCRECORDER2_SUPPORTEDFEATUREPAGES = 0x208;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_CURRENTFEATUREPAGES 0x209")]
        public const int DISPID_IDISCRECORDER2_CURRENTFEATUREPAGES = 0x209;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_SUPPORTEDPROFILES 0x20A")]
        public const int DISPID_IDISCRECORDER2_SUPPORTEDPROFILES = 0x20A;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_CURRENTPROFILES 0x20B")]
        public const int DISPID_IDISCRECORDER2_CURRENTPROFILES = 0x20B;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_SUPPORTEDMODEPAGES 0x20C")]
        public const int DISPID_IDISCRECORDER2_SUPPORTEDMODEPAGES = 0x20C;

        [NativeTypeName("#define DISPID_IDISCRECORDER2_EXCLUSIVEACCESSOWNER 0x20D")]
        public const int DISPID_IDISCRECORDER2_EXCLUSIVEACCESSOWNER = 0x20D;

        [NativeTypeName("#define DISPID_IWRITEENGINE2_WRITESECTION 0x200")]
        public const int DISPID_IWRITEENGINE2_WRITESECTION = 0x200;

        [NativeTypeName("#define DISPID_IWRITEENGINE2_CANCELWRITE 0x201")]
        public const int DISPID_IWRITEENGINE2_CANCELWRITE = 0x201;

        [NativeTypeName("#define DISPID_IWRITEENGINE2_DISCRECORDER 0x100")]
        public const int DISPID_IWRITEENGINE2_DISCRECORDER = 0x100;

        [NativeTypeName("#define DISPID_IWRITEENGINE2_USESTREAMINGWRITE12 0x101")]
        public const int DISPID_IWRITEENGINE2_USESTREAMINGWRITE12 = 0x101;

        [NativeTypeName("#define DISPID_IWRITEENGINE2_STARTINGSECTORSPERSECOND 0x102")]
        public const int DISPID_IWRITEENGINE2_STARTINGSECTORSPERSECOND = 0x102;

        [NativeTypeName("#define DISPID_IWRITEENGINE2_ENDINGSECTORSPERSECOND 0x103")]
        public const int DISPID_IWRITEENGINE2_ENDINGSECTORSPERSECOND = 0x103;

        [NativeTypeName("#define DISPID_IWRITEENGINE2_BYTESPERSECTOR 0x104")]
        public const int DISPID_IWRITEENGINE2_BYTESPERSECTOR = 0x104;

        [NativeTypeName("#define DISPID_IWRITEENGINE2_WRITEINPROGRESS 0x105")]
        public const int DISPID_IWRITEENGINE2_WRITEINPROGRESS = 0x105;

        [NativeTypeName("#define DISPID_IWRITEENGINE2EVENTARGS_STARTLBA 0x100")]
        public const int DISPID_IWRITEENGINE2EVENTARGS_STARTLBA = 0x100;

        [NativeTypeName("#define DISPID_IWRITEENGINE2EVENTARGS_SECTORCOUNT 0x101")]
        public const int DISPID_IWRITEENGINE2EVENTARGS_SECTORCOUNT = 0x101;

        [NativeTypeName("#define DISPID_IWRITEENGINE2EVENTARGS_LASTREADLBA 0x102")]
        public const int DISPID_IWRITEENGINE2EVENTARGS_LASTREADLBA = 0x102;

        [NativeTypeName("#define DISPID_IWRITEENGINE2EVENTARGS_LASTWRITTENLBA 0x103")]
        public const int DISPID_IWRITEENGINE2EVENTARGS_LASTWRITTENLBA = 0x103;

        [NativeTypeName("#define DISPID_IWRITEENGINE2EVENTARGS_TOTALDEVICEBUFFER 0x104")]
        public const int DISPID_IWRITEENGINE2EVENTARGS_TOTALDEVICEBUFFER = 0x104;

        [NativeTypeName("#define DISPID_IWRITEENGINE2EVENTARGS_USEDDEVICEBUFFER 0x105")]
        public const int DISPID_IWRITEENGINE2EVENTARGS_USEDDEVICEBUFFER = 0x105;

        [NativeTypeName("#define DISPID_IWRITEENGINE2EVENTARGS_TOTALSYSTEMBUFFER 0x106")]
        public const int DISPID_IWRITEENGINE2EVENTARGS_TOTALSYSTEMBUFFER = 0x106;

        [NativeTypeName("#define DISPID_IWRITEENGINE2EVENTARGS_USEDSYSTEMBUFFER 0x107")]
        public const int DISPID_IWRITEENGINE2EVENTARGS_USEDSYSTEMBUFFER = 0x107;

        [NativeTypeName("#define DISPID_IWRITEENGINE2EVENTARGS_FREESYSTEMBUFFER 0x108")]
        public const int DISPID_IWRITEENGINE2EVENTARGS_FREESYSTEMBUFFER = 0x108;

        [NativeTypeName("#define DISPID_DWRITEENGINE2EVENTS_UPDATE 0x100")]
        public const int DISPID_DWRITEENGINE2EVENTS_UPDATE = 0x100;

        [NativeTypeName("#define DISPID_IDISCFORMAT2_RECORDERSUPPORTED 0x800")]
        public const int DISPID_IDISCFORMAT2_RECORDERSUPPORTED = 0x800;

        [NativeTypeName("#define DISPID_IDISCFORMAT2_MEDIASUPPORTED 0x801")]
        public const int DISPID_IDISCFORMAT2_MEDIASUPPORTED = 0x801;

        [NativeTypeName("#define DISPID_IDISCFORMAT2_MEDIAPHYSICALLYBLANK 0x700")]
        public const int DISPID_IDISCFORMAT2_MEDIAPHYSICALLYBLANK = 0x700;

        [NativeTypeName("#define DISPID_IDISCFORMAT2_MEDIAHEURISTICALLYBLANK 0x701")]
        public const int DISPID_IDISCFORMAT2_MEDIAHEURISTICALLYBLANK = 0x701;

        [NativeTypeName("#define DISPID_IDISCFORMAT2_SUPPORTEDMEDIATYPES 0x702")]
        public const int DISPID_IDISCFORMAT2_SUPPORTEDMEDIATYPES = 0x702;

        [NativeTypeName("#define DISPID_IDISCFORMAT2ERASE_RECORDER 0x100")]
        public const int DISPID_IDISCFORMAT2ERASE_RECORDER = 0x100;

        [NativeTypeName("#define DISPID_IDISCFORMAT2ERASE_FULLERASE 0x101")]
        public const int DISPID_IDISCFORMAT2ERASE_FULLERASE = 0x101;

        [NativeTypeName("#define DISPID_IDISCFORMAT2ERASE_MEDIATYPE 0x102")]
        public const int DISPID_IDISCFORMAT2ERASE_MEDIATYPE = 0x102;

        [NativeTypeName("#define DISPID_IDISCFORMAT2ERASE_CLIENTNAME 0x103")]
        public const int DISPID_IDISCFORMAT2ERASE_CLIENTNAME = 0x103;

        [NativeTypeName("#define DISPID_IDISCFORMAT2ERASE_ERASEMEDIA 0x201")]
        public const int DISPID_IDISCFORMAT2ERASE_ERASEMEDIA = 0x201;

        [NativeTypeName("#define DISPID_IDISCFORMAT2ERASEEVENTS_UPDATE 0x200")]
        public const int DISPID_IDISCFORMAT2ERASEEVENTS_UPDATE = 0x200;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_RECORDER 0x100")]
        public const int DISPID_IDISCFORMAT2DATA_RECORDER = 0x100;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_BUFFERUNDERRUNFREEDISABLED 0x101")]
        public const int DISPID_IDISCFORMAT2DATA_BUFFERUNDERRUNFREEDISABLED = 0x101;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_POSTGAPALREADYINIMAGE 0x104")]
        public const int DISPID_IDISCFORMAT2DATA_POSTGAPALREADYINIMAGE = 0x104;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_CURRENTMEDIASTATUS 0x106")]
        public const int DISPID_IDISCFORMAT2DATA_CURRENTMEDIASTATUS = 0x106;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_WRITEPROTECTSTATUS 0x107")]
        public const int DISPID_IDISCFORMAT2DATA_WRITEPROTECTSTATUS = 0x107;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_TOTALSECTORS 0x108")]
        public const int DISPID_IDISCFORMAT2DATA_TOTALSECTORS = 0x108;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_FREESECTORS 0x109")]
        public const int DISPID_IDISCFORMAT2DATA_FREESECTORS = 0x109;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_NEXTWRITABLEADDRESS 0x10A")]
        public const int DISPID_IDISCFORMAT2DATA_NEXTWRITABLEADDRESS = 0x10A;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_STARTSECTOROFPREVIOUSSESSION 0x10B")]
        public const int DISPID_IDISCFORMAT2DATA_STARTSECTOROFPREVIOUSSESSION = 0x10B;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_LASTSECTOROFPREVIOUSSESSION 0x10C")]
        public const int DISPID_IDISCFORMAT2DATA_LASTSECTOROFPREVIOUSSESSION = 0x10C;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_FORCEMEDIATOBECLOSED 0x10D")]
        public const int DISPID_IDISCFORMAT2DATA_FORCEMEDIATOBECLOSED = 0x10D;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_DISABLEDVDCOMPATIBILITYMODE 0x10E")]
        public const int DISPID_IDISCFORMAT2DATA_DISABLEDVDCOMPATIBILITYMODE = 0x10E;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_CURRENTMEDIATYPE 0x10F")]
        public const int DISPID_IDISCFORMAT2DATA_CURRENTMEDIATYPE = 0x10F;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_CLIENTNAME 0x110")]
        public const int DISPID_IDISCFORMAT2DATA_CLIENTNAME = 0x110;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_REQUESTEDWRITESPEED 0x111")]
        public const int DISPID_IDISCFORMAT2DATA_REQUESTEDWRITESPEED = 0x111;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_REQUESTEDROTATIONTYPEISPURECAV 0x112")]
        public const int DISPID_IDISCFORMAT2DATA_REQUESTEDROTATIONTYPEISPURECAV = 0x112;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_CURRENTWRITESPEED 0x113")]
        public const int DISPID_IDISCFORMAT2DATA_CURRENTWRITESPEED = 0x113;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_CURRENTROTATIONTYPEISPURECAV 0x114")]
        public const int DISPID_IDISCFORMAT2DATA_CURRENTROTATIONTYPEISPURECAV = 0x114;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_SUPPORTEDWRITESPEEDS 0x115")]
        public const int DISPID_IDISCFORMAT2DATA_SUPPORTEDWRITESPEEDS = 0x115;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_SUPPORTEDWRITESPEEDDESCRIPTORS 0x116")]
        public const int DISPID_IDISCFORMAT2DATA_SUPPORTEDWRITESPEEDDESCRIPTORS = 0x116;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_FORCEOVERWRITE 0x117")]
        public const int DISPID_IDISCFORMAT2DATA_FORCEOVERWRITE = 0x117;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_MUTLISESSIONINTERFACES 0x118")]
        public const int DISPID_IDISCFORMAT2DATA_MUTLISESSIONINTERFACES = 0x118;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_WRITE 0x200")]
        public const int DISPID_IDISCFORMAT2DATA_WRITE = 0x200;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_CANCELWRITE 0x201")]
        public const int DISPID_IDISCFORMAT2DATA_CANCELWRITE = 0x201;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATA_SETWRITESPEED 0x202")]
        public const int DISPID_IDISCFORMAT2DATA_SETWRITESPEED = 0x202;

        [NativeTypeName("#define DISPID_DDISCFORMAT2DATAEVENTS_UPDATE 0x200")]
        public const int DISPID_DDISCFORMAT2DATAEVENTS_UPDATE = 0x200;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATAEVENTARGS_ELAPSEDTIME 0x300")]
        public const int DISPID_IDISCFORMAT2DATAEVENTARGS_ELAPSEDTIME = 0x300;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATAEVENTARGS_ESTIMATEDREMAININGTIME 0x301")]
        public const int DISPID_IDISCFORMAT2DATAEVENTARGS_ESTIMATEDREMAININGTIME = 0x301;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATAEVENTARGS_ESTIMATEDTOTALTIME 0x302")]
        public const int DISPID_IDISCFORMAT2DATAEVENTARGS_ESTIMATEDTOTALTIME = 0x302;

        [NativeTypeName("#define DISPID_IDISCFORMAT2DATAEVENTARGS_CURRENTACTION 0x303")]
        public const int DISPID_IDISCFORMAT2DATAEVENTARGS_CURRENTACTION = 0x303;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_RECORDER 0x100")]
        public const int DISPID_IDISCFORMAT2TAO_RECORDER = 0x100;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_BUFFERUNDERRUNFREEDISABLED 0x102")]
        public const int DISPID_IDISCFORMAT2TAO_BUFFERUNDERRUNFREEDISABLED = 0x102;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_NUMBEROFEXISTINGTRACKS 0x103")]
        public const int DISPID_IDISCFORMAT2TAO_NUMBEROFEXISTINGTRACKS = 0x103;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_TOTALSECTORSONMEDIA 0x104")]
        public const int DISPID_IDISCFORMAT2TAO_TOTALSECTORSONMEDIA = 0x104;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_FREESECTORSONMEDIA 0x105")]
        public const int DISPID_IDISCFORMAT2TAO_FREESECTORSONMEDIA = 0x105;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_USEDSECTORSONMEDIA 0x106")]
        public const int DISPID_IDISCFORMAT2TAO_USEDSECTORSONMEDIA = 0x106;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_DONOTFINALIZEMEDIA 0x107")]
        public const int DISPID_IDISCFORMAT2TAO_DONOTFINALIZEMEDIA = 0x107;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_EXPECTEDTABLEOFCONTENTS 0x10A")]
        public const int DISPID_IDISCFORMAT2TAO_EXPECTEDTABLEOFCONTENTS = 0x10A;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_CURRENTMEDIATYPE 0x10B")]
        public const int DISPID_IDISCFORMAT2TAO_CURRENTMEDIATYPE = 0x10B;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_CLIENTNAME 0x10E")]
        public const int DISPID_IDISCFORMAT2TAO_CLIENTNAME = 0x10E;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_REQUESTEDWRITESPEED 0x10F")]
        public const int DISPID_IDISCFORMAT2TAO_REQUESTEDWRITESPEED = 0x10F;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_REQUESTEDROTATIONTYPEISPURECAV 0x110")]
        public const int DISPID_IDISCFORMAT2TAO_REQUESTEDROTATIONTYPEISPURECAV = 0x110;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_CURRENTWRITESPEED 0x111")]
        public const int DISPID_IDISCFORMAT2TAO_CURRENTWRITESPEED = 0x111;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_CURRENTROTATIONTYPEISPURECAV 0x112")]
        public const int DISPID_IDISCFORMAT2TAO_CURRENTROTATIONTYPEISPURECAV = 0x112;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_SUPPORTEDWRITESPEEDS 0x113")]
        public const int DISPID_IDISCFORMAT2TAO_SUPPORTEDWRITESPEEDS = 0x113;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_SUPPORTEDWRITESPEEDDESCRIPTORS 0x114")]
        public const int DISPID_IDISCFORMAT2TAO_SUPPORTEDWRITESPEEDDESCRIPTORS = 0x114;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_PREPAREMEDIA 0x200")]
        public const int DISPID_IDISCFORMAT2TAO_PREPAREMEDIA = 0x200;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_ADDAUDIOTRACK 0x201")]
        public const int DISPID_IDISCFORMAT2TAO_ADDAUDIOTRACK = 0x201;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_CANCELADDTRACK 0x202")]
        public const int DISPID_IDISCFORMAT2TAO_CANCELADDTRACK = 0x202;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_FINISHMEDIA 0x203")]
        public const int DISPID_IDISCFORMAT2TAO_FINISHMEDIA = 0x203;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAO_SETWRITESPEED 0x204")]
        public const int DISPID_IDISCFORMAT2TAO_SETWRITESPEED = 0x204;

        [NativeTypeName("#define DISPID_DDISCFORMAT2TAOEVENTS_UPDATE 0x200")]
        public const int DISPID_DDISCFORMAT2TAOEVENTS_UPDATE = 0x200;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAOEVENTARGS_CURRENTTRACKNUMBER 0x300")]
        public const int DISPID_IDISCFORMAT2TAOEVENTARGS_CURRENTTRACKNUMBER = 0x300;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAOEVENTARGS_CURRENTACTION 0x301")]
        public const int DISPID_IDISCFORMAT2TAOEVENTARGS_CURRENTACTION = 0x301;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAOEVENTARGS_ELAPSEDTIME 0x302")]
        public const int DISPID_IDISCFORMAT2TAOEVENTARGS_ELAPSEDTIME = 0x302;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAOEVENTARGS_ESTIMATEDREMAININGTIME 0x303")]
        public const int DISPID_IDISCFORMAT2TAOEVENTARGS_ESTIMATEDREMAININGTIME = 0x303;

        [NativeTypeName("#define DISPID_IDISCFORMAT2TAOEVENTARGS_ESTIMATEDTOTALTIME 0x304")]
        public const int DISPID_IDISCFORMAT2TAOEVENTARGS_ESTIMATEDTOTALTIME = 0x304;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_RECORDER 0x100")]
        public const int DISPID_IDISCFORMAT2RAWCD_RECORDER = 0x100;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_BUFFERUNDERRUNFREEDISABLED 0x102")]
        public const int DISPID_IDISCFORMAT2RAWCD_BUFFERUNDERRUNFREEDISABLED = 0x102;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_STARTOFNEXTSESSION 0x103")]
        public const int DISPID_IDISCFORMAT2RAWCD_STARTOFNEXTSESSION = 0x103;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_LASTPOSSIBLESTARTOFLEADOUT 0x104")]
        public const int DISPID_IDISCFORMAT2RAWCD_LASTPOSSIBLESTARTOFLEADOUT = 0x104;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_CURRENTMEDIATYPE 0x105")]
        public const int DISPID_IDISCFORMAT2RAWCD_CURRENTMEDIATYPE = 0x105;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_SUPPORTEDDATASECTORTYPES 0x108")]
        public const int DISPID_IDISCFORMAT2RAWCD_SUPPORTEDDATASECTORTYPES = 0x108;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_REQUESTEDDATASECTORTYPE 0x109")]
        public const int DISPID_IDISCFORMAT2RAWCD_REQUESTEDDATASECTORTYPE = 0x109;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_CLIENTNAME 0x10A")]
        public const int DISPID_IDISCFORMAT2RAWCD_CLIENTNAME = 0x10A;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_REQUESTEDWRITESPEED 0x10B")]
        public const int DISPID_IDISCFORMAT2RAWCD_REQUESTEDWRITESPEED = 0x10B;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_REQUESTEDROTATIONTYPEISPURECAV 0x10C")]
        public const int DISPID_IDISCFORMAT2RAWCD_REQUESTEDROTATIONTYPEISPURECAV = 0x10C;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_CURRENTWRITESPEED 0x10D")]
        public const int DISPID_IDISCFORMAT2RAWCD_CURRENTWRITESPEED = 0x10D;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_CURRENTROTATIONTYPEISPURECAV 0x10E")]
        public const int DISPID_IDISCFORMAT2RAWCD_CURRENTROTATIONTYPEISPURECAV = 0x10E;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_SUPPORTEDWRITESPEEDS 0x10F")]
        public const int DISPID_IDISCFORMAT2RAWCD_SUPPORTEDWRITESPEEDS = 0x10F;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_SUPPORTEDWRITESPEEDDESCRIPTORS 0x110")]
        public const int DISPID_IDISCFORMAT2RAWCD_SUPPORTEDWRITESPEEDDESCRIPTORS = 0x110;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_PREPAREMEDIA 0x200")]
        public const int DISPID_IDISCFORMAT2RAWCD_PREPAREMEDIA = 0x200;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_WRITEMEDIA 0x201")]
        public const int DISPID_IDISCFORMAT2RAWCD_WRITEMEDIA = 0x201;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_WRITEMEDIAWITHVALIDATION 0x202")]
        public const int DISPID_IDISCFORMAT2RAWCD_WRITEMEDIAWITHVALIDATION = 0x202;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_CANCELWRITE 0x203")]
        public const int DISPID_IDISCFORMAT2RAWCD_CANCELWRITE = 0x203;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_RELEASEMEDIA 0x204")]
        public const int DISPID_IDISCFORMAT2RAWCD_RELEASEMEDIA = 0x204;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCD_SETWRITESPEED 0x205")]
        public const int DISPID_IDISCFORMAT2RAWCD_SETWRITESPEED = 0x205;

        [NativeTypeName("#define DISPID_DDISCFORMAT2RAWCDEVENTS_UPDATE 0x200")]
        public const int DISPID_DDISCFORMAT2RAWCDEVENTS_UPDATE = 0x200;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCDEVENTARGS_CURRENTTRACKNUMBER 0x300")]
        public const int DISPID_IDISCFORMAT2RAWCDEVENTARGS_CURRENTTRACKNUMBER = 0x300;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCDEVENTARGS_CURRENTACTION 0x301")]
        public const int DISPID_IDISCFORMAT2RAWCDEVENTARGS_CURRENTACTION = 0x301;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCDEVENTARGS_ELAPSEDTIME 0x300")]
        public const int DISPID_IDISCFORMAT2RAWCDEVENTARGS_ELAPSEDTIME = 0x300;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCDEVENTARGS_ESTIMATEDREMAININGTIME 0x301")]
        public const int DISPID_IDISCFORMAT2RAWCDEVENTARGS_ESTIMATEDREMAININGTIME = 0x301;

        [NativeTypeName("#define DISPID_IDISCFORMAT2RAWCDEVENTARGS_ESTIMATEDTOTALTIME 0x302")]
        public const int DISPID_IDISCFORMAT2RAWCDEVENTARGS_ESTIMATEDTOTALTIME = 0x302;

        [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_CD 75")]
        public const int IMAPI_SECTORS_PER_SECOND_AT_1X_CD = 75;

        [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_DVD 680")]
        public const int IMAPI_SECTORS_PER_SECOND_AT_1X_DVD = 680;

        [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_BD 2195")]
        public const int IMAPI_SECTORS_PER_SECOND_AT_1X_BD = 2195;

        [NativeTypeName("#define IMAPI_SECTORS_PER_SECOND_AT_1X_HD_DVD 4568")]
        public const int IMAPI_SECTORS_PER_SECOND_AT_1X_HD_DVD = 4568;

        [NativeTypeName("#define DISPID_IMULTISESSION_SUPPORTEDONCURRENTMEDIA 0x100")]
        public const int DISPID_IMULTISESSION_SUPPORTEDONCURRENTMEDIA = 0x100;

        [NativeTypeName("#define DISPID_IMULTISESSION_INUSE 0x101")]
        public const int DISPID_IMULTISESSION_INUSE = 0x101;

        [NativeTypeName("#define DISPID_IMULTISESSION_IMPORTRECORDER 0x102")]
        public const int DISPID_IMULTISESSION_IMPORTRECORDER = 0x102;

        [NativeTypeName("#define DISPID_IMULTISESSION_FIRSTDATASESSION 0x200")]
        public const int DISPID_IMULTISESSION_FIRSTDATASESSION = 0x200;

        [NativeTypeName("#define DISPID_IMULTISESSION_STARTSECTOROFPREVIOUSSESSION 0x201")]
        public const int DISPID_IMULTISESSION_STARTSECTOROFPREVIOUSSESSION = 0x201;

        [NativeTypeName("#define DISPID_IMULTISESSION_LASTSECTOROFPREVIOUSSESSION 0x202")]
        public const int DISPID_IMULTISESSION_LASTSECTOROFPREVIOUSSESSION = 0x202;

        [NativeTypeName("#define DISPID_IMULTISESSION_NEXTWRITABLEADDRESS 0x203")]
        public const int DISPID_IMULTISESSION_NEXTWRITABLEADDRESS = 0x203;

        [NativeTypeName("#define DISPID_IMULTISESSION_FREESECTORS 0x204")]
        public const int DISPID_IMULTISESSION_FREESECTORS = 0x204;

        [NativeTypeName("#define DISPID_IMULTISESSION_WRITEUNITSIZE 0x205")]
        public const int DISPID_IMULTISESSION_WRITEUNITSIZE = 0x205;

        [NativeTypeName("#define DISPID_IMULTISESSION_LASTWRITTENADDRESS 0x206")]
        public const int DISPID_IMULTISESSION_LASTWRITTENADDRESS = 0x206;

        [NativeTypeName("#define DISPID_IMULTISESSION_SECTORSONMEDIA 0x207")]
        public const int DISPID_IMULTISESSION_SECTORSONMEDIA = 0x207;

        [NativeTypeName("#define DISPID_IRAWCDIMAGECREATOR_CREATERESULTIMAGE 0x200")]
        public const int DISPID_IRAWCDIMAGECREATOR_CREATERESULTIMAGE = 0x200;

        [NativeTypeName("#define DISPID_IRAWCDIMAGECREATOR_ADDTRACK 0x201")]
        public const int DISPID_IRAWCDIMAGECREATOR_ADDTRACK = 0x201;

        [NativeTypeName("#define DISPID_IRAWCDIMAGECREATOR_ADDSPECIALPREGAP 0x202")]
        public const int DISPID_IRAWCDIMAGECREATOR_ADDSPECIALPREGAP = 0x202;

        [NativeTypeName("#define DISPID_IRAWCDIMAGECREATOR_ADDSUBCODERWGENERATOR 0x203")]
        public const int DISPID_IRAWCDIMAGECREATOR_ADDSUBCODERWGENERATOR = 0x203;

        [NativeTypeName("#define DISPID_IRAWCDIMAGECREATOR_RESULTINGIMAGETYPE 0x100")]
        public const int DISPID_IRAWCDIMAGECREATOR_RESULTINGIMAGETYPE = 0x100;

        [NativeTypeName("#define DISPID_IRAWCDIMAGECREATOR_STARTOFLEADOUT 0x101")]
        public const int DISPID_IRAWCDIMAGECREATOR_STARTOFLEADOUT = 0x101;

        [NativeTypeName("#define DISPID_IRAWCDIMAGECREATOR_STARTOFLEADOUTLIMIT 0x102")]
        public const int DISPID_IRAWCDIMAGECREATOR_STARTOFLEADOUTLIMIT = 0x102;

        [NativeTypeName("#define DISPID_IRAWCDIMAGECREATOR_DISABLEGAPLESSAUDIO 0x103")]
        public const int DISPID_IRAWCDIMAGECREATOR_DISABLEGAPLESSAUDIO = 0x103;

        [NativeTypeName("#define DISPID_IRAWCDIMAGECREATOR_MEDIACATALOGNUMBER 0x104")]
        public const int DISPID_IRAWCDIMAGECREATOR_MEDIACATALOGNUMBER = 0x104;

        [NativeTypeName("#define DISPID_IRAWCDIMAGECREATOR_STARTINGTRACKNUMBER 0x105")]
        public const int DISPID_IRAWCDIMAGECREATOR_STARTINGTRACKNUMBER = 0x105;

        [NativeTypeName("#define DISPID_IRAWCDIMAGECREATOR_TRACKINFO 0x106")]
        public const int DISPID_IRAWCDIMAGECREATOR_TRACKINFO = 0x106;

        [NativeTypeName("#define DISPID_IRAWCDIMAGECREATOR_NUMBEROFEXISTINGTRACKS 0x107")]
        public const int DISPID_IRAWCDIMAGECREATOR_NUMBEROFEXISTINGTRACKS = 0x107;

        [NativeTypeName("#define DISPID_IRAWCDIMAGECREATOR_USEDSECTORSONDISC 0x108")]
        public const int DISPID_IRAWCDIMAGECREATOR_USEDSECTORSONDISC = 0x108;

        [NativeTypeName("#define DISPID_IRAWCDIMAGECREATOR_EXPECTEDTABLEOFCONTENTS 0x109")]
        public const int DISPID_IRAWCDIMAGECREATOR_EXPECTEDTABLEOFCONTENTS = 0x109;

        [NativeTypeName("#define DISPID_IRAWCDTRACKINFO_STARTINGLBA 0x100")]
        public const int DISPID_IRAWCDTRACKINFO_STARTINGLBA = 0x100;

        [NativeTypeName("#define DISPID_IRAWCDTRACKINFO_SECTORCOUNT 0x101")]
        public const int DISPID_IRAWCDTRACKINFO_SECTORCOUNT = 0x101;

        [NativeTypeName("#define DISPID_IRAWCDTRACKINFO_TRACKNUMBER 0x102")]
        public const int DISPID_IRAWCDTRACKINFO_TRACKNUMBER = 0x102;

        [NativeTypeName("#define DISPID_IRAWCDTRACKINFO_SECTORTYPE 0x103")]
        public const int DISPID_IRAWCDTRACKINFO_SECTORTYPE = 0x103;

        [NativeTypeName("#define DISPID_IRAWCDTRACKINFO_ISRC 0x104")]
        public const int DISPID_IRAWCDTRACKINFO_ISRC = 0x104;

        [NativeTypeName("#define DISPID_IRAWCDTRACKINFO_DIGITALAUDIOCOPYSETTING 0x105")]
        public const int DISPID_IRAWCDTRACKINFO_DIGITALAUDIOCOPYSETTING = 0x105;

        [NativeTypeName("#define DISPID_IRAWCDTRACKINFO_AUDIOHASPREEMPHASIS 0x106")]
        public const int DISPID_IRAWCDTRACKINFO_AUDIOHASPREEMPHASIS = 0x106;

        [NativeTypeName("#define DISPID_IBLOCKRANGE_STARTLBA 0x100")]
        public const int DISPID_IBLOCKRANGE_STARTLBA = 0x100;

        [NativeTypeName("#define DISPID_IBLOCKRANGE_ENDLBA 0x101")]
        public const int DISPID_IBLOCKRANGE_ENDLBA = 0x101;

        [NativeTypeName("#define DISPID_IBLOCKRANGELIST_BLOCKRANGES 0x100")]
        public const int DISPID_IBLOCKRANGELIST_BLOCKRANGES = 0x100;

        [NativeTypeName("#define IMAPILib2_MajorVersion 1")]
        public const int IMAPILib2_MajorVersion = 1;

        [NativeTypeName("#define IMAPILib2_MinorVersion 0")]
        public const int IMAPILib2_MinorVersion = 0;

        public static ref readonly Guid IID_IDiscMaster2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x30, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DDiscMaster2Events
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x31, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscRecorder2Ex
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x32, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscRecorder2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x33, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWriteEngine2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x35, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWriteEngine2EventArgs
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x36, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DWriteEngine2Events
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x52, 0x41, 0x35, 0x27,
                    0x64, 0x8F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2Erase
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x56, 0x41, 0x35, 0x27,
                    0x64, 0x8F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DDiscFormat2EraseEvents
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3A, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2Data
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x53, 0x41, 0x35, 0x27,
                    0x64, 0x9F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DDiscFormat2DataEvents
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3C, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2DataEventArgs
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3D, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2TrackAtOnce
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x54, 0x41, 0x35, 0x27,
                    0x64, 0x8F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DDiscFormat2TrackAtOnceEvents
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x3F, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2TrackAtOnceEventArgs
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x40, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2RawCD
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x55, 0x41, 0x35, 0x27,
                    0x64, 0x8F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_DDiscFormat2RawCDEvents
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x42, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IDiscFormat2RawCDEventArgs
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x43, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBurnVerification
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x34, 0xD8, 0xFF, 0xD2,
                    0x8B, 0x95,
                    0x6D, 0x42,
                    0x84,
                    0x70,
                    0x2A,
                    0x13,
                    0x87,
                    0x9C,
                    0x6A,
                    0x91
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IWriteSpeedDescriptor
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x44, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMultisession
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMultisessionSequential
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x51, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMultisessionSequential2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0xCA, 0x07, 0xB5,
                    0x04, 0x22,
                    0xDD, 0x11,
                    0x96,
                    0x6A,
                    0x00,
                    0x1A,
                    0xA0,
                    0x1B,
                    0xBC,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IMultisessionRandomWrite
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x23, 0xCA, 0x07, 0xB5,
                    0x04, 0x22,
                    0xDD, 0x11,
                    0x96,
                    0x6A,
                    0x00,
                    0x1A,
                    0xA0,
                    0x1B,
                    0xBC,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IStreamPseudoRandomBased
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x45, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IStreamConcatenate
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x46, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IStreamInterleave
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x47, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IRawCDImageCreator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x50, 0x35, 0x98, 0x25,
                    0x65, 0x9D,
                    0xCE, 0x49,
                    0xB3,
                    0x35,
                    0x40,
                    0x63,
                    0x0D,
                    0x90,
                    0x12,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IRawCDImageTrackInfo
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x51, 0x35, 0x98, 0x25,
                    0x65, 0x9D,
                    0xCE, 0x49,
                    0xB3,
                    0x35,
                    0x40,
                    0x63,
                    0x0D,
                    0x90,
                    0x12,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBlockRange
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x25, 0xCA, 0x07, 0xB5,
                    0x04, 0x22,
                    0xDD, 0x11,
                    0x96,
                    0x6A,
                    0x00,
                    0x1A,
                    0xA0,
                    0x1B,
                    0xBC,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_IBlockRangeList
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0xCA, 0x07, 0xB5,
                    0x04, 0x22,
                    0xDD, 0x11,
                    0x96,
                    0x6A,
                    0x00,
                    0x1A,
                    0xA0,
                    0x1B,
                    0xBC,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_MsftDiscMaster2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2E, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftDiscRecorder2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2D, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftWriteEngine2
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2C, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftDiscFormat2Erase
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2B, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftDiscFormat2Data
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2A, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftDiscFormat2TrackAtOnce
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x29, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftDiscFormat2RawCD
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x28, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftStreamZero
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x27, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftStreamPrng001
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x26, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftStreamConcatenate
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x25, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftStreamInterleave
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftWriteSpeedDescriptor
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x23, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftMultisessionSequential
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x22, 0x41, 0x35, 0x27,
                    0x64, 0x7F,
                    0x0F, 0x5B,
                    0x8F,
                    0x00,
                    0x5D,
                    0x77,
                    0xAF,
                    0xBE,
                    0x26,
                    0x1E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftMultisessionRandomWrite
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x24, 0xCA, 0x07, 0xB5,
                    0x04, 0x22,
                    0xDD, 0x11,
                    0x96,
                    0x6A,
                    0x00,
                    0x1A,
                    0xA0,
                    0x1B,
                    0xBC,
                    0x58
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid CLSID_MsftRawCDImageCreator
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x61, 0x35, 0x98, 0x25,
                    0x65, 0x9D,
                    0xCE, 0x49,
                    0xB3,
                    0x35,
                    0x40,
                    0x63,
                    0x0D,
                    0x90,
                    0x12,
                    0x27
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
